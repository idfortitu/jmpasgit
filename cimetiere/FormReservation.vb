Public Class FormReservation
    Dim nbrbenf = 0
    Dim cb As New UCBenef()
    Dim cb2 As New UCBenef()
    Dim cb3 As New UCBenef()
    Private Sub btAjoutBenef_Click(sender As Object, e As EventArgs) Handles btAjoutBenef.Click
        If nbrbenf = 0 Then
            GBListBenef.Controls.Add(cb)
            nbrbenf = 1
            GBListBenef.Size = New Size(502, 120)
            Panel3.Size = New Size(536, 160)

        ElseIf nbrbenf = 1 Then
            GBListBenef.Controls.Add(cb2)
            nbrbenf = 2
            GBListBenef.Size = New Size(502, 170)
            Panel3.Size = New Size(536, 205)

        ElseIf nbrbenf = 2 Then
            GBListBenef.Controls.Add(cb3)
            nbrbenf = 3
            GBListBenef.Size = New Size(502, 222)
            Panel3.Size = New Size(536, 260)

        ElseIf nbrbenf = 3 Then
            MsgBox("4 bénéficiaires maximum")
        End If
    End Sub

    Private Sub btRetirerBeneficiaire_Click(sender As Object, e As EventArgs) Handles btRetirerBeneficiaire.Click
        If nbrbenf = 1 Then
            GBListBenef.Controls.Remove(cb)
            nbrbenf = 0
            GBListBenef.Size = New Size(502, 78)
            Panel3.Size = New Size(536, 114)

        ElseIf nbrbenf = 2 Then
            GBListBenef.Controls.Remove(cb2)
            nbrbenf = 1
            GBListBenef.Size = New Size(502, 120)
            Panel3.Size = New Size(536, 160)

        ElseIf nbrbenf = 3 Then
            GBListBenef.Controls.Remove(cb3)
            nbrbenf = 2
            GBListBenef.Size = New Size(502, 170)
            Panel3.Size = New Size(536, 205)

        End If
    End Sub

    Private Sub FormReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb.Location = New Point(35, 70)
        cb2.Location = New Point(35, 120)
        cb3.Location = New Point(35, 170)
        GBListBenef.Size = New Size(502, 78)
        Panel3.Size = New Size(536, 114)
    End Sub
End Class