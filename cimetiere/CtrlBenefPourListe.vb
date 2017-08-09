Public Class CtrlBenefPourListe

    Public Event BtRetirerClick(sender As CtrlBenefPourListe)

    ' l'argument optionnel est juste là pour ne pas faire une requête à chaque itération quand le contrôle parent parcourt la liste des bénéficiaires
    Public Function GetBenef(Optional Benef As DataRow = Nothing) As DataRow
        If Benef Is Nothing Then Benef = Bdd.GetRowVide("beneficiaires")
        Benef("ben_id") = -1
        Benef("ben_nom") = TbNom.Text
        Benef("ben_prenom") = TbPrenom.Text
        Benef("ben_date_naiss") = If(TbDateNaiss.DateValue IsNot Nothing, TbDateNaiss.DateValue, DBNull.Value)
        Benef("ben_lien_parente") = TbLienParente.Text
        Benef("ben_adresse") = TbAdresse.Text
        Benef("locville_id") = If(CtrlVille.LocVilleId > 0, CtrlVille.LocVilleId, DBNull.Value)
        Return Benef
    End Function

    Public Function ToutEstOk() As Boolean
        FaireValidation()
        Return ErrorProvider1.GetError(TbPrenom) = "" _
       AndAlso ErrorProvider1.GetError(TbNom) = "" _
       AndAlso ErrorProvider1.GetError(TbDateNaiss) = ""
    End Function

    Private Sub FaireValidation()
        TbPrenom_Validating(Nothing, Nothing)
        TbNom_Validating(Nothing, Nothing)
        TbDateNais_Validating(Nothing, Nothing)
    End Sub


    Private Sub TbPrenom_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TbPrenom.Validating
        If TbPrenom.Text.Trim = "" Then
            ErrorProvider1.SetError(TbPrenom, "Veuillez indiquer le prénom.")
        Else
            ErrorProvider1.SetError(TbPrenom, "")
        End If
    End Sub

    Private Sub TbNom_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TbNom.Validating
        If TbNom.Text.Trim = "" Then
            ErrorProvider1.SetError(TbNom, "Veuillez indiquer le nom.")
        Else
            ErrorProvider1.SetError(TbNom, "")
        End If
    End Sub

    Private Sub TbDateNais_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TbDateNaiss.Validating
        If Not TbDateNaiss.DateEstValide Then
            ErrorProvider1.SetError(TbDateNaiss, "La date n'est pas valide.")
        Else
            ErrorProvider1.SetError(TbDateNaiss, "")
        End If
    End Sub

    Private Sub BtRetirer_Click(sender As Object, e As EventArgs) Handles BtRetirer.Click
        RaiseEvent BtRetirerClick(Me)
    End Sub
End Class
