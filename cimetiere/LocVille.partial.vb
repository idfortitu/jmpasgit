Partial Public Class LocVille

    Public ReadOnly Property NomEtCp As String
        Get
            Return Ville & If(Cp.HasValue, " (" & Cp & ")", "")
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return NomEtCp
    End Function

    Public Shared Function FromDataTable(dt As DataTable) As List(Of LocVille)
        For Each Row In dt.Rows
            Dim lv As New LocVille With {
                .Id = Row("Id"),
                .Cp = Row("Cp"),
                .Ville = Row("")
            }

        Next
    End Function


End Class
