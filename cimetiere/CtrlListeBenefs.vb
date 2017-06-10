Public Class CtrlListeBenefs

    ' suppose que toutes les données entrées sont correctes (l'appelant est censé vérifier avec ToutEstOk d'abord)
    Public Function GetBenefs() As DataTable
        Dim LaTable = Bdd.GetTableVide("beneficiaires")
        If PanelInterieur.Controls.Count > 1 Then
            For N = 0 To PanelInterieur.Controls.Count - 2
                LaTable.Rows.Add(CType(PanelInterieur.Controls.Item(N), CtrlBenefPourListe).GetBenef(LaTable.NewRow))
            Next
        End If
        Return LaTable
    End Function

    Public Function ToutEstOk() As Boolean
        Dim ok = True
        If PanelInterieur.Controls.Count > 1 Then
            For N = 0 To PanelInterieur.Controls.Count - 2          ' ne pas prendre le bouton +
                If Not CType(PanelInterieur.Controls.Item(N), CtrlBenefPourListe).ToutEstOk Then ok = False
            Next
        End If
        Return ok
    End Function

    Private Sub BtAjoutBenef_Click(sender As Object, e As EventArgs) Handles BtAjoutBenef.Click
        Dim NvBen = New CtrlBenefPourListe
        AddHandler NvBen.BtRetirerClick, AddressOf RetirerBenef
        PanelInterieur.Controls.Add(NvBen)
        PanelInterieur.Controls.SetChildIndex(BtAjoutBenef, PanelInterieur.Controls.Count - 1)
    End Sub

    Private Sub CtrlListeBenefs_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        PanelInterieur.Size = Me.Size
    End Sub

    Private Sub RetirerBenef(benef As CtrlBenefPourListe)
        ' demande confirmation si la moindre info a déjà été rentrée
        If "" = (benef.TbNom.Text.Trim & benef.TbPrenom.Text.Trim & benef.TbLienParente.Text.Trim & benef.TbAdresse.Text.Trim) _
          AndAlso benef.TbDateNaiss.DateEstVide _
          AndAlso benef.CtrlVille.LocVilleId = -1 _
          AndAlso benef.CtrlVille.PaysId = -1 _
          OrElse MsgBoxResult.Ok = MessageBox.Show("Retirer le bénéficiaire ?", "Confirmation", MessageBoxButtons.OKCancel) Then
            RemoveHandler benef.BtRetirerClick, AddressOf RetirerBenef
            PanelInterieur.Controls.Remove(benef)
            benef.Dispose()
        End If
    End Sub

End Class
