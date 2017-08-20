Public Class CtrlLocVillePays


    ' <> -1 si la ville est choisie (auquel cas l'enregistrement LocVille existe)
    ' -1 si aucune ville n'est choisie, auquel cas le locville existe peut-être en tant que ville vide + pays sélectionné, ou pas et dans ce cas il faut le créer
    Public Property LocVilleId As Integer
        Get
            Return If(CbLocVille.SelectedValue Is Nothing, -1, CbLocVille.SelectedValue)
        End Get
        Set(value As Integer)
            If value = -1 Then
                CbLocVille.SelectedIndex = -1
            Else
                CbLocVille.SelectedValue = value
            End If
        End Set
    End Property

    Public ReadOnly Property PaysId As Integer
        Get
            Return If(CbPays.SelectedValue Is Nothing, -1, CbPays.SelectedValue)
        End Get
    End Property

    Public Sub New()
        InitializeComponent()       ' This call is required by the designer.
        If Not System.Diagnostics.Process.GetCurrentProcess().ProcessName = "devenv" Then
            ChargerComboboxLocVille()
            ChargerComboboxPays()
        End If
    End Sub

    Private Sub BtAjouterPays_Click(sender As Object, e As EventArgs) Handles BtAjouterPays.Click
        Dim f As New FormNouveauPays
        If f.ShowDialog = DialogResult.OK Then
            ChargerComboboxPays()
            CbLocVille.SelectedIndex = 0  ' ville vide
            CbPays.SelectedValue = f.PaysFait("Pays_id")
        End If
    End Sub

    Private Sub BtAjouterVille_Click(sender As Object, e As EventArgs) Handles BtAjouterVille.Click
        ' en cas d'ajout de ville, il faut aussi recharger la liste des pays, vu que la dlgbox d'ajout de ville permet de créer des pays
        Dim f As New FormNouvelleVille(CbPays.SelectedValue)
        If f.ShowDialog = DialogResult.OK Then
            ChargerComboboxLocVille()
            ChargerComboboxPays()
            CbLocVille.SelectedValue = f.VilleFaite("locville_id")
            CbLocVille_SelectedIndexChanged(Nothing, Nothing)
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
    End Sub

    Private Sub ChargerComboboxLocVille()
        Dim DtLocVilles = Bdd.Query("SELECT * from t_loc_ville WHERE locville_ville <> """"")
        Dim rowvide = DtLocVilles.NewRow
        rowvide("locville_id") = -1
        DtLocVilles.Rows.InsertAt(rowvide, 0)

        CbLocVille.DisplayMember = "locville_ville"
        CbLocVille.ValueMember = "locville_id"
        CbLocVille.DataSource = DtLocVilles
    End Sub

    Private Sub ChargerComboboxPays()
        Dim DtPays = Bdd.GetTable("t_pays")
        Dim rowvide = DtPays.NewRow
        rowvide("Pays_id") = -1
        DtPays.Rows.InsertAt(rowvide, 0)

        CbPays.DisplayMember = "Pays_nom"
        CbPays.ValueMember = "Pays_id"
        CbPays.DataSource = DtPays
    End Sub

    Public Sub Rafraichir(Optional ClearSelect As Boolean = False)
        If CbLocVille.DataSource IsNot Nothing Then CType(CbLocVille.DataSource, IDisposable).Dispose()
        If CbPays.DataSource IsNot Nothing Then CType(CbLocVille.DataSource, IDisposable).Dispose()
        Dim LocvilSelect = CbLocVille.SelectedValue
        Dim PaysSelect = CbPays.SelectedValue
        ChargerComboboxLocVille()
        ChargerComboboxPays()
        If Not ClearSelect Then
            CbLocVille.SelectedValue = LocvilSelect
            CbPays.SelectedValue = PaysSelect
        End If
    End Sub

End Class
