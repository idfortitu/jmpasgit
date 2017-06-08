Public Class ListBenefNewCons

    Public Event Retirer(elem As ListBenefNewCons)
    Private Sub btRetirerBeneficiaire_Click(sender As Object, e As EventArgs) 
        RaiseEvent Retirer(Me)
    End Sub
End Class