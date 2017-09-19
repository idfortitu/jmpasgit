' met des couleurs différentes pour les concessions expirées ou proches de la date d'exp
Public Class DataGridViewConcessions
    Inherits DataGridViewCustom
    Private Sub ColorLignes(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles Me.CellFormatting
        Dim larow As DataGridViewRow = Me.Rows(e.RowIndex)
        Dim LaDataRow As DataRow = CType(larow.DataBoundItem, DataRowView).Row
        ''Dim datefin As Date? = CType(larow.DataBoundItem, Concession).DateFin
        Dim datefin As Date? = If(Not IsDBNull(LaDataRow("con_date_fin")), LaDataRow("con_date_fin"), Nothing)
        Dim expire As Boolean = datefin.HasValue AndAlso datefin < Today
        Dim expirebientot As Boolean = Not expire AndAlso datefin.HasValue AndAlso Today > DateAdd(DateInterval.Month, -1, datefin.Value)
        Dim impair As Boolean = e.RowIndex Mod 2 <> 0
        If expire Then
            If impair Then
                e.CellStyle.BackColor = Color.FromArgb(212, 212, 212)
                e.CellStyle.ForeColor = SystemColors.GrayText
            Else
                e.CellStyle.BackColor = Color.FromArgb(222, 222, 222)
                e.CellStyle.ForeColor = SystemColors.GrayText
            End If
        End If

        If expirebientot Then
            If impair Then
                e.CellStyle.BackColor = Color.FromArgb(232, 222, 222)
                'larow.DefaultCellStyle.ForeColor = SystemColors.GrayText
            Else
                e.CellStyle.BackColor = Color.FromArgb(242, 232, 232)
                'larow.DefaultCellStyle.ForeColor = SystemColors.GrayText
            End If

        End If



    End Sub

End Class

