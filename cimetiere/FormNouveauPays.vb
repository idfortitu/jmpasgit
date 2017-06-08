Public Class FormNouveauPays

    'Public PaysFait As Pays
    Public PaysFait As DataRow

    Private Sub BtEnregistrer_Click(sender As Object, e As EventArgs) Handles BtEnregistrer.Click
        If TbNom.Text.Trim = "" Then
            MessageBox.Show("Veuillez entrer le nom du pays.")
        Else
            Dim PaysDeja = Bdd.Query("SELECT * FROM t_pays WHERE Pays_nom = """ & TbNom.Text & """")
            If PaysDeja.Rows.Count > 0 Then
                MessageBox.Show("Ce pays est déjà enregistré.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                PaysFait = PaysDeja.Rows(0)
            Else
                Dim r = GetRowVide("t_pays")
                r("Pays_nom") = StrConv(TbNom.Text, VbStrConv.ProperCase)
                r("Pays_id") = Bdd.Insert("t_pays", r)
                PaysFait = r
            End If
            DialogResult = DialogResult.OK
        End If
    End Sub
End Class