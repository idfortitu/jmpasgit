Public Class PanelEditEmplacement
    Private Sub PanelEditEmplacement_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        DgvOccupants.Width = DgvOccupants.Parent.Width - DgvOccupants.Location.X        ' tester Parent (contrôle ?)
    End Sub
End Class

