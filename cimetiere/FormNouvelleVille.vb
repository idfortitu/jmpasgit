Public Class FormNouvelleVille

    Public VilleFaite As DataRow


    Private IdPaysSelectInitial As Integer = -1

    Public Sub New()
        InitializeComponent()        ' This call is required by the designer.
    End Sub

    Public Sub New(IdPaysSelectInit As Integer)
        InitializeComponent()       ' This call is required by the designer.
        IdPaysSelectInitial = IdPaysSelectInit
    End Sub

    Private Sub FormNouvelleVille_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChargerComboboxPays()
        If IdPaysSelectInitial <> -1 Then CbPays.SelectedValue = IdPaysSelectInitial
    End Sub

    Private Sub BtAjouterPays_Click(sender As Object, e As EventArgs) Handles BtAjouterPays.Click
        Dim f As New FormNouveauPays
        f.ShowDialog()
        If f.PaysFait IsNot Nothing Then
            ChargerComboboxPays(f.PaysFait("Pays_id"))
        End If
    End Sub

    Private Sub ChargerComboboxPays(Optional EtSélectionnerId As Integer = -1)
        Dim DtPays = Bdd.GetTable("t_pays")
        Dim rowvide = DtPays.NewRow
        rowvide("Pays_id") = -1
        DtPays.Rows.InsertAt(rowvide, 0)

        CbPays.DisplayMember = "Pays_nom"
        CbPays.ValueMember = "Pays_id"
        CbPays.DataSource = DtPays
        If EtSélectionnerId <> -1 Then CbPays.SelectedValue = EtSélectionnerId
    End Sub

    Private Sub BtEnregistrer_Click(sender As Object, e As EventArgs) Handles BtEnregistrer.Click
        If TbNom.Text.Trim = "" Then
            MessageBox.Show("Veuillez entrer le nom de la ville.")
        Else
            Dim NouvelleVille = GetRowVide("t_loc_ville")
            NouvelleVille("locville_ville") = StrConv(TbNom.Text, VbStrConv.ProperCase)
            NouvelleVille("locville_cp") = If(TbintCp.Value, DBNull.Value)      ' TESTER sans cp

            If CbPays.SelectedValue <> -1 Then
                NouvelleVille("Pays_id") = CbPays.SelectedValue
            End If

            ' essaie de reconnaître une ville qui existe déjà
            ' si les villes ont le même nom mais qu'elles diffèrent par leur CP ou pays, elles sont considérées comme différentes

            Dim VillesDeja = Bdd.Query("SELECT * FROM t_loc_ville WHERE locville_ville = """ & NouvelleVille("locville_ville") & """")
            If VillesDeja.Rows.Count <= 0 Then            ' pas encore enregistrée ? on l'ajoute
                NouvelleVille("locville_id") = Bdd.Insert("t_loc_ville", NouvelleVille)
                Me.VilleFaite = NouvelleVille
            Else
                Dim VilleDeja = VillesDeja.Rows(0)
                Dim combi = CombinerVilles(NouvelleVille, VilleDeja)
                If combi Is Nothing Then    ' les villes on des informations différentes ? on enregistre la nouvelle
                    NouvelleVille("locville_id") = Bdd.Insert("t_loc_ville", NouvelleVille)
                    Me.VilleFaite = NouvelleVille
                Else    ' la ville existe déjà, mais l'utilisateur ajoute des infos -> mettre à jour
                    VilleDeja("locville_cp") = combi("locville_cp")
                    VilleDeja("Pays_id") = combi("Pays_id")
                    Bdd.Update("t_loc_ville", VilleDeja)
                    Me.VilleFaite = VilleDeja
                End If
            End If
            DialogResult = DialogResult.OK
        End If
    End Sub


    ' "combine" les infos de deux villes
    ' bouche les trous de l'une avec les infos de l'autre
    ' renvoie nothing en cas d'incompatibilité
    Private Function CombinerVilles(v1 As DataRow, v2 As DataRow) As DataRow
        Dim Resultat = Bdd.GetRowVide("t_loc_ville")
        If v1("locville_ville") <> v2("locville_ville") Then
            Return Nothing
        Else
            Resultat("locville_ville") = v1("locville_ville")
        End If
        If Not IsDBNull(v1("locville_cp")) Then
            Resultat("locville_cp") = v1("locville_cp")
            If Not IsDBNull(v2("locville_cp")) Then
                If v2("locville_cp") <> Resultat("locville_cp") Then Return Nothing
            End If
        Else
            Resultat("locville_cp") = v2("locville_cp")
        End If

        If Not IsDBNull(v1("pays_id")) Then
            Resultat("pays_id") = v1("pays_id")
            If Not IsDBNull(v2("pays_id")) Then
                If v2("pays_id") <> Resultat("pays_id") Then Return Nothing
            End If
        Else
            Resultat("pays_id") = v2("pays_id")
        End If
        Return Resultat
    End Function


End Class