Imports System.Security.Cryptography


Public Class FormLogin
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles BtOk.Click
        Dim mMD5 As New MD5CryptoServiceProvider
        Dim UniEnc As New System.Text.UnicodeEncoding
        Dim bitPass() As Byte = UniEnc.GetBytes(TbMdp.Text)
        Dim pass As String = Convert.ToBase64String(mMD5.ComputeHash(bitPass)).ToString

        Dim LoginOk = Bdd.Login(TbNomUtilisateur.Text, pass).ToString
        If LoginOk Then
            DialogResult = DialogResult.OK
        Else
            MsgBox("Le nom d'utilisateur ou le mot de passe est incorrecte.")
        End If

    End Sub

    Private Sub BtQuitter_Click(sender As Object, e As EventArgs) Handles BtQuitter.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form As New debug
        debug.ShowDialog()
    End Sub
End Class