Public Class TextBoxInt64
    Inherits TextBoxInt

    ' pareil que textboxint, mais avec des grands nombres, spécialement pour le n° national

    Public Shadows Property Value As Int64?
        Get
            If Text.Trim = "" Then
                Return Nothing
            Else
                Dim Res As Int64?
                Try
                    Res = Int64.Parse(Text)
                Catch
                    Return Nothing
                End Try
                Return Res
            End If
        End Get
        Set(value As Int64?)
            Text = If(value, "")
        End Set
    End Property


End Class
