Public Class FormNouveauPays

    'Public PaysFait As Pays
    Public PaysFait As DataRow

    Private Sub BtEnregistrer_Click(sender As Object, e As EventArgs) Handles BtEnregistrer.Click
        If TbNom.Text.Trim = "" Then
            MessageBox.Show("Veuillez entrer le nom du pays.")
        Else
            Using ctx As New CimEntities
                Dim PaysDeja = Bdd.Query("SELECT * FROM t_pays WHERE Pays_nom = """ & TbNom.Text & """")
                '(From p In ctx.Pays Where p.Nom = TbNom.Text).FirstOrDefault
                If PaysDeja.Rows.Count > 0 Then
                    MessageBox.Show("Ce pays est déjà enregistré.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    PaysFait = PaysDeja.Rows(0)
                Else
                    ''' 
'faire:              ajout Pays

                    Dim NvPays = New Pays With {.Nom = StrConv(TbNom.Text, VbStrConv.ProperCase)}
                    ctx.Pays.Add(NvPays)
                    ctx.SaveChanges()
                    'PaysFait = NvPays
                End If
            End Using
            DialogResult = DialogResult.OK
        End If
    End Sub
End Class