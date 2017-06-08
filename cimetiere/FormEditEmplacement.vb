Public Class FormEditEmplacement

    Public IdEmpl As Integer?

    Private LEmplacement As Emplacement
    'Private ListeDéfuntsAjoutes As New List(Of Défunt)
    'Private ListeDéfuntsRetirés As New List(Of Défunt)

    Public Sub New(Optional Id As Integer = -1)
        InitializeComponent()
        If Id <> -1 Then IdEmpl = Id
        DgvOccDest.AutoGenerateColumns = False
        DgvOccSrc.AutoGenerateColumns = False
    End Sub

    Private Sub FormEditEmplacement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using ctx As New CimEntities
            If IdEmpl IsNot Nothing Then
                Text = "Modifier un emplacement"
                LEmplacement = ctx.Emplacements.Single(Function(empl) empl.Id = IdEmpl)     ' doit renvoyer une erreur si l'emplacement n'existe pas

                TbRef.Text = LEmplacement.Reference
                CbTypeEmpl.SelectedValue = LEmplacement.Type
                TbintNbPlaces.Value = LEmplacement.NbPlaces
                CbMonumClassé.Checked = LEmplacement.MonumClasse
                TbHistoire.Text = If(LEmplacement.Histoire IsNot Nothing, LEmplacement.Histoire.Texte, "")

                ' l'ordre id descending devrait mettre les plus récemment ajoutés en haut
                DgvOccDest.DataSource = New SortableBindingList(Of Defunt)((From def In ctx.Defunts.Include("LocVille.Pays") Where def.EmplId = IdEmpl))
                DgvOccSrc.DataSource = New SortableBindingList(Of Defunt)((From def In ctx.Defunts.Include("LocVille.Pays") Where def.EmplId <> IdEmpl Order By def.Id Descending))
            Else
                Text = "Ajouter un emplacement"
                LEmplacement = New Emplacement
                TbRef.ReadOnly = False
                DgvOccDest.DataSource = New SortableBindingList(Of Defunt)(New List(Of Defunt))
                DgvOccSrc.DataSource = New SortableBindingList(Of Defunt)(ctx.Defunts.Include("LocVille.Pays"))
            End If
        End Using

    End Sub

    Private Sub BtAjouterOccupant_Click(sender As Object, e As EventArgs) Handles BtAjouterOccupant.Click
        Dim LOccupant = DgvOccSrc.SelectedItem
        If LOccupant IsNot Nothing Then
            DgvOccSrc.DataSource.remove(LOccupant)
            DgvOccDest.DataSource.add(LOccupant)
        End If
    End Sub

    Private Sub BtRetirerOccupant_Click(sender As Object, e As EventArgs) Handles BtRetirerOccupant.Click
        Dim LOccupant = DgvOccDest.SelectedItem
        If LOccupant IsNot Nothing Then
            DgvOccDest.DataSource.Remove(LOccupant)
            DgvOccSrc.DataSource.Add(LOccupant)
        End If
    End Sub



    ' PENSER à enregistrer la référence si l'emplacement est nouveau


    Private Sub AjusterTailleDgv(sender As Object, e As EventArgs) Handles MyBase.Layout
        DgvOccDest.Width = ClientSize.Width - DgvOccDest.Location.X - 5
        DgvOccSrc.Width = ClientSize.Width - DgvOccSrc.Location.X - 5
        DgvOccSrc.Height = ClientSize.Height - DgvOccSrc.Location.Y - 10


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a = 3
    End Sub

End Class