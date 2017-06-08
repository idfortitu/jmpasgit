Public Class TextBoxInt
    Inherits TextBox

    ' Textbox qui n'accepte que des chiffres et qui peut renvoyer une value de type Integer?

    Public Property Value As Integer?
        Get
            If Text.Trim = "" Then
                Return Nothing
            Else
                Return Int32.Parse(Text)
            End If
        End Get
        Set(value As Integer?)
            Text = If(value, "")
        End Set
    End Property

    ' empêche d'entrer du texte au clavier
    Public Sub nombreskeydown(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' filtre aussi le copier-coller
    Protected Overrides Sub WndProc(ByRef m As Message)

        If m.Msg <> 770 Then         ' WM_PASTE
            MyBase.WndProc(m)
            Return

        Else
            Dim s As String = ""
            Dim ex_s As String = Clipboard.GetText
            For Each c In ex_s
                If Char.IsNumber(c) Then s += c       ' retire les non-chiffres
            Next
            If s <> "" Then
                Clipboard.SetText(s)
                MyBase.WndProc(m)
                Clipboard.SetText(ex_s)
            End If
        End If
    End Sub

End Class
