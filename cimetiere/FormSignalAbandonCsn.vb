Public Class FormSignalAbandonCsn

    Private FormChoix As FormChoixEmplSurPlan

    Private LesEmplacements As DataTable

    Public Sub Me_Load() Handles Me.Load
        Me.LesEmplacements = Bdd.GetTable("emplacements")
    End Sub

    Private Sub BtMontrerFormPlancim_Click(sender As Object, e As EventArgs) Handles BtMontrerFormPlancim.Click
        If FormChoix Is Nothing OrElse FormChoix.IsDisposed Then
            FormChoix = New FormChoixEmplSurPlan(Me.LesEmplacements) With {.TopMost = True}         '', .Size = New Size(500, 1000)} ' n'a pas l'air de marcher
            FormChoix.Size = New Size(1000, 500)
            AddHandler FormChoix.SelectionChanged, AddressOf FormChoix_SelectionChanged
            'Dim EmplTb = Bdd.GetRow("emplacements", "empl_reference", TbRefEmpl.Text.Trim)
            If TbRefEmpl.Text.Trim <> "" Then
                Dim EmplTb = Me.LesEmplacements.Select("empl_reference = '" & TbRefEmpl.Text.Trim & "'")
                If EmplTb.Count > 0 Then
                    FormChoix.EmplSelect = EmplTb(0)
                End If
            End If
            FormChoix.Show()
            End If
    End Sub

    Private Sub FormChoix_SelectionChanged(Empl As DataRow)
        If FormChoix.EmplSelect IsNot Nothing Then
            TbRefEmpl.Text = FormChoix.EmplSelect("empl_reference")
        End If
    End Sub

    Sub Me_Closing() Handles Me.Closing
        If Me.FormChoix IsNot Nothing Then
            If Not Me.FormChoix.IsDisposed Then
                Me.FormChoix.Close()
                Me.FormChoix.Dispose()
            End If
        End If
    End Sub

End Class