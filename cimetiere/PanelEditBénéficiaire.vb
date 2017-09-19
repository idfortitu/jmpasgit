Public Class PanelEditBénéficiaire

    Public Sub SetInfos(Benef As Beneficiaire)
        TbNom.Text = Benef.Nom
        TbPrénom.Text = Benef.Prenom
        TbAdresse.Text = Benef.Adresse
        TbintCp.Value = Benef.Cp
        'TbTel.Text = Benef.
        TbdateDateNaiss.DateValue = Benef.DateNaiss

    End Sub

    Public Sub GetInfos(Bénef As Beneficiaire)

    End Sub

    Public Function GetInfos() As Beneficiaire

    End Function

End Class
