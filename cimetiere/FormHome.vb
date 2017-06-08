Public Class FormHome
    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using FormLogin As New FormLogin
            Dim ResultatLogin = FormLogin.ShowDialog()
            If ResultatLogin <> DialogResult.OK Then
                Close()
            End If
        End Using
    End Sub

    Private Sub BtNotifsMasquer_Click(sender As Object, e As EventArgs) Handles BtNotifsMasquer.Click
        PanNotifs.Hide()
        BtNotifsMasquer.Hide()
        BtNotifsMontrer.Show()
    End Sub

    Private Sub BtNotifsMontrer_Click(sender As Object, e As EventArgs) Handles BtNotifsMontrer.Click
        PanNotifs.Show()
        BtNotifsMontrer.Hide()
        BtNotifsMasquer.Show()
    End Sub

    Private Sub BtDéclarationDécès_Click(sender As Object, e As EventArgs) Handles BtDéclarationDécès.Click
        Dim aer As New FormNouvelleConcession
        aer.ShowDialog()
    End Sub

    Private Sub BtRéserverCon_Click(sender As Object, e As EventArgs) Handles BtRéserverCon.Click
        Dim res As New FormReservation
        res.ShowDialog()
    End Sub

    Private Sub BtProlongation_Click(sender As Object, e As EventArgs) Handles BtProlongation.Click
        Dim a As New FormProlong
        a.ShowDialog()
    End Sub

    Private Sub BtConstatAbandon_Click(sender As Object, e As EventArgs) Handles BtConstatAbandon.Click

    End Sub

    Private Sub BtConsulterDonnées_Click(sender As Object, e As EventArgs) Handles BtConsulterDonnées.Click
        Dim f As New FormGestion
        f.ShowDialog()
    End Sub
End Class
