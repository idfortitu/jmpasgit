Public Class FormNouvelleConcession
    Dim nbrbenf = 0
    Dim cb As New UCBenef()
    Dim cb2 As New UCBenef()
    Dim cb3 As New UCBenef()
    Private Sub FormNouvelleConcession_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using ctx As New CimEntities
            ChargerComboboxEmpl(ctx)
        End Using
        cb.Location = New Point(35, 70)
        cb2.Location = New Point(35, 120)
        cb3.Location = New Point(35, 170)
        GBListBenef.Size = New Size(502, 78)
        Panel3.Size = New Size(536, 114)

    End Sub

    Private Sub BtDebutPlus15Ans_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtDebutPlus30Ans_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ChargerComboboxEmpl(contexte As CimEntities)
        Dim ListeEmpls As New List(Of Emplacement)({New Emplacement With {.Id = -1, .Reference = ""}})      ' choix élément vide (qui ne sera pas accepté par le formulaire)
        ListeEmpls = ListeEmpls.Concat(From e In contexte.Emplacements Order By e.Reference).ToList


    End Sub

    Private Sub BtEnregistrer_Click(sender As Object, e As EventArgs)
        ' validation
        TbCsnrPrenom_Validating(Nothing, Nothing)
        TbCsnrNom_Validating(Nothing, Nothing)
        TbdateCsnrDateNaiss_Validating(Nothing, Nothing)
        TbCsnrNoRegistre_Validating(Nothing, Nothing)
        TbdateDateDebut_Validating(Nothing, Nothing)
        TbdateDateFin_Validating(Nothing, Nothing)
        TbfloatMontantPaye_Validating(Nothing, Nothing)
        CbEmplacement_Validating(Nothing, Nothing)


        If ErrorProvider1.GetError(TbCsnrNom) = "" _
            AndAlso ErrorProvider1.GetError(TbCsnrPrenom) = "" _
            AndAlso ErrorProvider1.GetError(TbdateCsnrDateNaiss) = "" _
            AndAlso ErrorProvider1.GetError(TbfloatMontantPaye) = "" _
            AndAlso ErrorProvider1.GetError(TbCsnrNoRegistre) = "" Then



            MessageBox.Show("trankil sa passe")

            ' enregistrer

            ' concessionnaire
            ' on en cherche un du même nom qui existerait déjà
            Dim LeConcessionnaire As Concessionnaire
            Using ctx As New CimEntities
                Dim NomsCsnrs = (From c In ctx.Concessionnaires Select New With {c.Id, c.Nom, c.Prenom}).ToList
                Dim IdCsnrDeja = (From c In NomsCsnrs Where ReduireString(c.Nom) = ReduireString(TbCsnrNom.Text) _
                                 AndAlso ReduireString(c.Prenom) = ReduireString(TbCsnrPrenom.Text)
                                  Select c.Id) _
                                .FirstOrDefault
                If IdCsnrDeja <> 0 Then
                    LeConcessionnaire = ctx.Concessionnaires.Find(IdCsnrDeja)
                Else
                    LeConcessionnaire = New Concessionnaire
                    ctx.Concessionnaires.Add(LeConcessionnaire)
                End If

                LeConcessionnaire.Nom = TbCsnrNom.Text.Trim
                LeConcessionnaire.Prenom = TbCsnrPrenom.Text.Trim
                Dim dnaiss As Date? = TbdateCsnrDateNaiss.DateValue
                If dnaiss.HasValue Then LeConcessionnaire.DateNaiss = dnaiss.Value      ' si une valeur n'est pas précisée, on n'enregistre pas le "Nothing" pour ne pas supprimer une valeur qui serait déjà présente (dans le cas d'un concessionnaire qui existe déjà)
                If TbCsnrNoRegistre.Text <> "" Then LeConcessionnaire.NoRegistre = TbCsnrNoRegistre.Text
                If TbCsnrTel.Text.Trim <> "" Then LeConcessionnaire.Tel = TbCsnrTel.Text.Trim
                If TbCsnrAdresse.Text.Trim <> "" Then LeConcessionnaire.Adresse = TbCsnrAdresse.Text.Trim

                If CtrlLocVillePays1.LocVilleId <> -1 Then               ' si la locville est précisée, on la met
                    LeConcessionnaire.LocVilleId = CtrlLocVillePays1.LocVilleId
                Else
                    If CtrlLocVillePays1.PaysId <> -1 Then          ' si la ville n'est pas précisée mais que le pays l'est
                        ' on met une LocVille avec le nom de la ville vide et ce pays
                        ' (si cette LocVille n'existe pas déjà, on la crée)
                        Dim LocVilleVide = (From l In ctx.LocVilles Where l.Ville = "" AndAlso l.PaysId = CtrlLocVillePays1.PaysId).FirstOrDefault
                        If LocVilleVide IsNot Nothing Then
                            LeConcessionnaire.LocVille = LocVilleVide
                        Else
                            LeConcessionnaire.LocVille = New LocVille With {.PaysId = CtrlLocVillePays1.PaysId}
                        End If
                    Else    ' si ni la ville ni le pays ne sont précisés
                        ' et si le concessionnaire n'a pas déjà une locville
                        If LeConcessionnaire.LocVilleId Is Nothing Then
                            ' on lui met une locville spéciale sans nom de ville et sans pays (plutôt que pas de locville)
                            ' (si elle n'existe pas, on la crée)
                            Dim LocVilleVide = (From l In ctx.LocVilles Where l.Ville = "" AndAlso l.PaysId Is Nothing).FirstOrDefault
                            If LocVilleVide IsNot Nothing Then
                                LeConcessionnaire.LocVille = LocVilleVide
                            Else
                                LeConcessionnaire.LocVille = New LocVille
                            End If
                        End If
                    End If
                End If

                ' concession
                Dim LaConcession As New Concession

                LaConcession.MontantPaye = Convert.ToDecimal(TbfloatMontantPaye.Text)


                If TbCommentaire.Text.Trim <> "" Then LaConcession.Commentaire = New Commentaire(TbCommentaire.Text.Trim)

                ctx.Concessions.Add(LaConcession)
                LaConcession.Concessionnaire = LeConcessionnaire

                ctx.SaveChanges()

                DialogResult = DialogResult.OK
            End Using

        Else
            ToolTip1.Show("Le formulaire contient des champs incorrects.", BtEnregistrer)
        End If



    End Sub


    Private Sub TbCsnrPrenom_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TbCsnrPrenom.Validating
        If TbCsnrPrenom.Text.Trim = "" Then
            ErrorProvider1.SetError(TbCsnrPrenom, "Veuillez entrer le prénom du concessionnaire")
        Else
            ErrorProvider1.SetError(TbCsnrPrenom, "")
        End If

    End Sub

    Private Sub TbCsnrNom_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TbCsnrNom.Validating
        If TbCsnrNom.Text.Trim = "" Then
            ErrorProvider1.SetError(TbCsnrNom, "Veuillez entrer le nom du concessionnaire")
        Else
            ErrorProvider1.SetError(TbCsnrNom, "")
        End If
    End Sub

    Private Sub TbdateCsnrDateNaiss_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TbdateCsnrDateNaiss.Validating
        If Not TbdateCsnrDateNaiss.DateEstValide Then
            ErrorProvider1.SetError(TbdateCsnrDateNaiss, "La date est incorrecte")
        Else
            ErrorProvider1.SetError(TbdateCsnrDateNaiss, "")
        End If
    End Sub

    Private Sub TbCsnrNoRegistre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TbCsnrNoRegistre.Validating
        If Not (TbCsnrNoRegistre.Text.Count = 0 OrElse (TbCsnrNoRegistre.Text.Count = 11 AndAlso IsNumeric(TbCsnrNoRegistre.Text))) Then
            ErrorProvider1.SetError(TbCsnrNoRegistre, "Le numéro n'est pas valide")
        Else
            ErrorProvider1.SetError(TbCsnrNoRegistre, "")
        End If
    End Sub

    Private Sub TbdateDateDebut_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub TbdateDateFin_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub TbfloatMontantPaye_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TbfloatMontantPaye.Validating
        If TbfloatMontantPaye.Text = "" Then
            ErrorProvider1.SetError(TbfloatMontantPaye, "Veuillez indiquer le montant")
        Else
            ErrorProvider1.SetError(TbfloatMontantPaye, "")
        End If
    End Sub


    Private Sub CbEmplacement_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub BtAnnuler_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub GbLocation_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub btAjoutBenef_Click(sender As Object, e As EventArgs) Handles btAjoutBenef.Click
        If nbrbenf = 0 Then
            GBListBenef.Controls.Add(cb)
            nbrbenf = 1
            GBListBenef.Size = New Size(502, 120)
            Panel3.Size = New Size(536, 160)

        ElseIf nbrbenf = 1 Then
            GBListBenef.Controls.Add(cb2)
            nbrbenf = 2
            GBListBenef.Size = New Size(502, 170)
            Panel3.Size = New Size(536, 205)

        ElseIf nbrbenf = 2 Then
            GBListBenef.Controls.Add(cb3)
            nbrbenf = 3
            GBListBenef.Size = New Size(502, 222)
            Panel3.Size = New Size(536, 260)

        ElseIf nbrbenf = 3 Then
            MsgBox("4 bénéficiaires maximum")
        End If

    End Sub

    Private Sub btRetirerBeneficiaire_Click(sender As Object, e As EventArgs) Handles btRetirerBeneficiaire.Click
        If nbrbenf = 1 Then
            GBListBenef.Controls.Remove(cb)
            nbrbenf = 0
            GBListBenef.Size = New Size(502, 78)
            Panel3.Size = New Size(536, 114)

        ElseIf nbrbenf = 2 Then
            GBListBenef.Controls.Remove(cb2)
            nbrbenf = 1
            GBListBenef.Size = New Size(502, 120)
            Panel3.Size = New Size(536, 160)

        ElseIf nbrbenf = 3 Then
            GBListBenef.Controls.Remove(cb3)
            nbrbenf = 2
            GBListBenef.Size = New Size(502, 170)
            Panel3.Size = New Size(536, 205)

        End If
    End Sub
End Class