Public Class CtrlLocVillePays


    ' <> -1 si la ville est choisie (auquel cas l'enregistrement LocVille existe)
    ' -1 si aucune ville n'est choisie, auquel cas le locville existe peut-être en tant que ville vide + pays sélectionné, ou pas et dans ce cas il faut le créer
    Public ReadOnly Property LocVilleId As Integer
        Get
            Return CbLocVille.SelectedValue
        End Get
    End Property

    Public ReadOnly Property PaysId As Integer
        Get
            Return CbPays.SelectedValue
        End Get
    End Property

    Public Sub New()
        InitializeComponent()       ' This call is required by the designer.
        If Not System.Diagnostics.Process.GetCurrentProcess().ProcessName = "devenv" Then
            'Using ctx As New CimEntities
            ChargerComboboxLocVille()
                ChargerComboboxPays()
            'End Using
        End If
    End Sub

    Private Sub BtAjouterPays_Click(sender As Object, e As EventArgs) Handles BtAjouterPays.Click


        Dim f As New FormNouveauPays
        If f.ShowDialog = DialogResult.OK Then
            Using ctx As New CimEntities
                ' à faire
                'Dim IdNouveauPays As Integer = f.PaysFait.Id      ' le contexte qui a chargé ces objets était différent, donc on ne peut pas compter sur les références d'objet pour reconnaître les entités
                ChargerComboboxPays()
                CbLocVille.SelectedIndex = -1
                'CbPays.SelectedValue = IdNouveauPays
            End Using
        End If
    End Sub

    Private Sub BtAjouterVille_Click(sender As Object, e As EventArgs) Handles BtAjouterVille.Click
        ' en cas d'ajout de ville, il faut aussi recharger la liste des pays, la dlgbox d'ajout de ville permettant de créer des pays
        Dim f As New FormNouvelleVille(CbPays.SelectedValue)
        If f.ShowDialog = DialogResult.OK Then
            Using ctx As New CimEntities
                ChargerComboboxLocVille()
                ChargerComboboxPays()
                CbLocVille.SelectedValue = f.VilleFaite.Id
                CbLocVille_SelectedIndexChanged(Nothing, Nothing)
            End Using
        End If
    End Sub



    ' si on change de ville, le pays doit être changé pour correspondre, et il ne peut être changé par l'utilisateur que si aucune ville n'est sélectionnée
    Private Sub CbLocVille_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbLocVille.SelectedIndexChanged

        If CbLocVille.SelectedItem IsNot Nothing AndAlso Not IsDBNull(CbLocVille.SelectedItem("Pays_id")) Then
            CbPays.SelectedValue = CbLocVille.SelectedItem("Pays_id")
            CbPays.Enabled = False
        Else
            CbPays.SelectedIndex = -1
            CbPays.Enabled = True
        End If

        'If CbLocVille.SelectedItem IsNot Nothing AndAlso CType(CbLocVille.SelectedItem, LocVille).Pays IsNot Nothing Then ' AndAlso CType(CbLocVille.SelectedItem, LocVille).Id <> -1 Then
        '    CbPays.SelectedValue = (CType(CbLocVille.SelectedItem, LocVille).Pays.Id)
        '    CbPays.Enabled = False
        'Else
        '    CbPays.SelectedIndex = -1
        '    CbPays.Enabled = True
        'End If
    End Sub



    'Private Sub ChargerComboboxLocVille(contexte As CimEntities)

    '    Dim ListeVilles As New List(Of LocVille)({New LocVille With {.Id = -1, .Ville = ""}})
    '    ListeVilles = ListeVilles.Concat(From v In contexte.LocVilles.Include("Pays") Where v.Ville <> "" Order By v.Ville).ToList     ' on charge aussi les pays pour pouvoir faire correspondre les éléments de la listbox des villes (Uneville.Pays) à ceux de la listbox des pays au changement de sélection de la ville

    '    CbLocVille.DisplayMember = "NomEtCp"
    '    CbLocVille.ValueMember = "Id"
    '    CbLocVille.DataSource = ListeVilles
    'End Sub
    Private Sub ChargerComboboxLocVille()

        Dim DtLocVilles = Bdd.Query("SELECT * from t_loc_ville WHERE locville_ville <> """"")
        Dim rowvide = DtLocVilles.NewRow
        rowvide("locville_id") = -1
        DtLocVilles.Rows.InsertAt(rowvide, 0)

        CbLocVille.DisplayMember = "locville_ville"
        CbLocVille.ValueMember = "locville_id"
        CbLocVille.DataSource = DtLocVilles


        'Dim ListeVilles As New List(Of LocVille)({New LocVille With {.Id = -1, .Ville = ""}})
        'ListeVilles = ListeVilles.Concat(From v In contexte.LocVilles.Include("Pays") Where v.Ville <> "" Order By v.Ville).ToList     ' on charge aussi les pays pour pouvoir faire correspondre les éléments de la listbox des villes (Uneville.Pays) à ceux de la listbox des pays au changement de sélection de la ville

        'CbLocVille.DisplayMember = "NomEtCp"
        'CbLocVille.ValueMember = "Id"
        'CbLocVille.DataSource = ListeVilles
    End Sub


    Private Sub ChargerComboboxPays()

        Dim DtLocPays = Bdd.GetTable("t_pays")
        Dim rowvide = DtLocPays.NewRow
        rowvide("Pays_id") = -1
        DtLocPays.Rows.InsertAt(rowvide, 0)

        CbPays.DisplayMember = "Pays_nom"
        CbPays.ValueMember = "Pays_id"
        CbPays.DataSource = DtLocPays

        'Dim ListePays As New List(Of Pays)({New Pays With {.Id = -1, .Nom = ""}})
        'ListePays = ListePays.Concat(From p In contexte.Pays.Include("LocVilles") Order By p.Nom).ToList

        'CbPays.DisplayMember = "Nom"
        'CbPays.ValueMember = "Id"
        'CbPays.DataSource = ListePays
    End Sub


End Class
