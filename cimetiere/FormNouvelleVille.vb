Public Class FormNouvelleVille

    Public VilleFaite As LocVille


    Private IdPaysSelectInitial As Integer = -1

    Public Sub New()
        InitializeComponent()        ' This call is required by the designer.
    End Sub

    Public Sub New(IdPaysSelectInit As Integer)
        InitializeComponent()       ' This call is required by the designer.
        IdPaysSelectInitial = IdPaysSelectInit
    End Sub


    Private Sub FormNouvelleVille_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using ctx As New CimEntities
            ChargerComboboxPays(ctx)
            If IdPaysSelectInitial <> -1 Then CbPays.SelectedValue = IdPaysSelectInitial

        End Using
    End Sub

    Private Sub BtAjouterPays_Click(sender As Object, e As EventArgs) Handles BtAjouterPays.Click
        Dim f As New FormNouveauPays
        f.ShowDialog()
        If f.PaysFait IsNot Nothing Then
            Using ctx As New CimEntities
                'ChargerComboboxPays(ctx, f.PaysFait)
            End Using
        End If
    End Sub

    ' si le contexte est Nothing, la fonction en ouvrira un (et le fermera en se finissant)
    Private Sub ChargerComboboxPays(contexte As CimEntities, Optional EtSélectionner As Pays = Nothing)
        If EtSélectionner IsNot Nothing Then contexte.Pays.Attach(EtSélectionner)    ' pour que le pays passé en paramètre soit le même objet que celui renvoyé par les requêtes sur ctx.Pays et donc que la combobox puisse le reconnaître comme SelectedItem

        Dim ListePays As New List(Of Pays)({New Pays With {.Id = -1, .Nom = ""}})
        ListePays = ListePays.Concat(From p In contexte.Pays Order By p.Nom).ToList

        CbPays.DisplayMember = "Nom"
        CbPays.ValueMember="Id"
        CbPays.DataSource = ListePays
        If EtSélectionner IsNot Nothing Then CbPays.SelectedItem = EtSélectionner
    End Sub

    Private Sub BtEnregistrer_Click(sender As Object, e As EventArgs) Handles BtEnregistrer.Click
        If TbNom.Text.Trim = "" Then
            MessageBox.Show("Veuillez entrer le nom de la ville.")
        Else
            Using ctx As New CimEntities

                Dim NouvelleVille As New LocVille With {.Ville = StrConv(TbNom.Text, VbStrConv.ProperCase), .Cp = TbintCp.Value}

                If CbPays.SelectedItem.Id <> -1 Then
                    ctx.Pays.Attach(CbPays.SelectedItem)
                    NouvelleVille.Pays = CbPays.SelectedItem
                End If

                ' essaie de reconnaître une ville qui existe déjà
                ' si les villes ont le même nom mais qu'elles diffèrent par leur CP ou pays, elles sont considérées comme différentes

                Dim VilleDéjà = ctx.LocVilles.Include("Pays").SingleOrDefault(Function(v) v.Ville = NouvelleVille.Ville)
                If VilleDéjà Is Nothing Then            ' pas encore enregistrée ? on l'ajoute
                    ctx.LocVilles.Add(NouvelleVille)
                    ctx.SaveChanges()
                    Me.VilleFaite = NouvelleVille
                Else
                    Dim combi As LocVille = CombinerVilles(NouvelleVille, VilleDéjà)
                    If combi Is Nothing Then    ' les villes on des informations différentes ? on enregistre la nouvelle
                        ctx.LocVilles.Add(NouvelleVille)
                        Me.VilleFaite = NouvelleVille
                    Else    ' la ville existe déjà, mais l'utilisateur ajoute des infos ? mettre à jour
                        VilleDéjà.Cp = combi.Cp       ' peut-être que VilleDéjà = combi marcherait, sais pas trop comment l'EF traite ça
                        VilleDéjà.Pays = combi.Pays
                        Me.VilleFaite = VilleDéjà

                    End If
                End If
                ctx.SaveChanges()
                Dim krupatt = "AddressOf"
            End Using
            DialogResult = DialogResult.OK
        End If
    End Sub


    ' "combine" les infos de deux villes
    ' bouche les trous de l'une avec les infos de l'autre
    ' renvoie nothing en cas d'incompatibilité
    Private Function CombinerVilles(v1 As LocVille, v2 As LocVille) As LocVille
        Dim Resultat As New LocVille
        If v1.Ville <> v2.Ville Then
            Return Nothing
        Else
            Resultat.Ville = v1.Ville
        End If
        If v1.Cp IsNot Nothing Then
            Resultat.Cp = v1.Cp
            If v2.Cp IsNot Nothing Then
                If v2.Cp <> Resultat.Cp Then Return Nothing
            End If
        Else
            Resultat.Cp = v2.Cp
        End If

        If v1.Pays IsNot Nothing Then
            Resultat.Pays = v1.Pays
            If v2.Pays IsNot Nothing Then
                If v2.Pays IsNot Resultat.Pays Then Return Nothing
            End If
        Else
            Resultat.Pays = v2.Pays
        End If
        Return Resultat
    End Function


End Class