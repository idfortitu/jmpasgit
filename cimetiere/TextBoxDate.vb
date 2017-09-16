Public Class TextBoxDate
    Inherits MaskedTextBox

    ' textbox qui n'accepte que les dates, au format j/m/a

    Public Sub New()
        MyBase.New
        Me.Mask = "00/00/0000"
        Me.TextAlign = HorizontalAlignment.Right    ' plus facile pour se mettre au début du texte en cliquant à gauche
    End Sub

    Public ReadOnly Property DateEstVide As Boolean
        Get
            Return Replace(Replace(Me.Text, " ", ""), "/", "") = ""
        End Get
    End Property


    ' en entrée, attend Me.Text au format j/m/a
    ' si un "champ" est 0 (mois, jour, année), le met à 1
    Public Property DateValue As Object 'Date?
        Get
            Dim TextSansespaces As String = Replace(Me.Text, " ", "")
            If Replace(TextSansespaces, "/", "").Equals(String.Empty) Then
                Return Nothing
            Else
                Dim strs() As String = Split(TextSansespaces, "/")
                For n = 0 To 1
                    If strs(n).Count = 0 Then strs(n) = "1"
                    strs(n) = Format(CType(strs(n), Integer), "00")
                Next
                If strs(2).Count = 0 Then strs(2) = "1"
                strs(2) = Format(CType(strs(2), Integer), "0000")
                Dim Res As Object
                Try
                    Res = Date.ParseExact(strs(0) & "/" & strs(1) & "/" & strs(2), "dd/MM/yyyy", Globalization.CultureInfo.InvariantCulture)
                Catch
                    Res = Nothing
                End Try
                Return Res
            End If
        End Get
        Set(value As Object) 'Date?)
            If value Is Nothing OrElse IsDBNull(value) Then
                Me.Text = "__/__/____"
            Else
                'Me.Text = Format(value.Value.Day, "00") & "/" & Format(value.Value.Month, "00") & "/" & Format(value.Value.Year, "0000")
                Me.Text = Format(value.Day, "00") & "/" & Format(value.Month, "00") & "/" & Format(value.Year, "0000")
            End If
        End Set
    End Property

    ' renvoie true si date valide OU vide
    Public ReadOnly Property DateEstValide As Boolean
        Get
            Dim TextSansEspaces As String = Replace(Me.Text, " ", "")
            If Not Replace(TextSansEspaces, "/", "").Equals(String.Empty) Then
                Dim strs() As String = Split(TextSansEspaces, "/")
                For n = 0 To 1
                    If strs(n).Count = 0 Then Return False
                    strs(n) = Format(CType(strs(n), Integer), "00")
                Next
                If strs(2).Count = 0 Then Return False
                strs(2) = Format(CType(strs(2), Integer), "0000")
                Try
                    Date.ParseExact(strs(0) & "/" & strs(1) & "/" & strs(2), "dd/MM/yyyy", Globalization.CultureInfo.InvariantCulture)
                Catch e As Exception
                    Return False
                End Try
            End If
            Return True
        End Get
    End Property

End Class
