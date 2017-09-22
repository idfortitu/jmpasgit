Public Class PlanCimEdit


    Public coords_empl_actuel As List(Of Point) = New List(Of Point)

    Private Sub PlanCimEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = Image.FromFile("planA1.JPG")
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim empl As DataRow = Bdd.GetRowVide("emplacements")
        'Dim nbr As Integer
        empl("empl_reference") = tbref.Text
        empl("empl_type") = 0
        empl("empl_monum_classe") = 0

        coords_empl_actuel.Add(coords_empl_actuel(0))
        Dim coords((coords_empl_actuel.Count * 4) - 1) As Byte
        Dim i As Integer = 0
        For Each pt As Point In coords_empl_actuel

            '330
            '00 00 01 4A
            '270 ; 500
            '15 1
            '1 * 255 + 15 = 270
            '270 = 01 0F

            coords(i) = pt.X And &HFF           ' 4A 
            i += 1
            coords(i) = pt.X >> 8 ' 01
            i += 1
            coords(i) = pt.Y And &HFF
            i += 1
            coords(i) = pt.Y >> 8  ' beaucoup
            i += 1
        Next
        empl("empl_coords") = coords

        Bdd.Insert("emplacements", empl)
        tbref.Text = ""
        Me.coords_empl_actuel.Clear()

        tbref.Focus()
    End Sub

    Private Sub PlanCimEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = "a" Then
            Button1_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick
        Dim propx As Single = 2000 / PictureBox1.Size.Width
        Dim propy As Single = 2000 / PictureBox1.Size.Height
        coords_empl_actuel.Add(New Point(CInt(e.Location.X * propx), CInt(e.Location.Y * propy)))
    End Sub

    Sub cancel() Handles Button2.Click
        Me.coords_empl_actuel.Clear()
    End Sub

    Private Sub tbref_KeyDown(sender As Object, e As KeyEventArgs) Handles tbref.KeyDown
        If e.KeyCode = Keys.Enter Then Button1_Click(Nothing, Nothing)
    End Sub
End Class
