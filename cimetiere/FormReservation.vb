Public Class FormReservation

    Private Sub FormReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitListeEmplacements()
    End Sub

    Private Sub InitListeEmplacements()
        ' emplacements, avec nombre de places disponibles (places totales - défunts étant dans cet emplacement)
        ' et fin de la location actuelle, si l'emplacement est loué
        DgvEmplacements.DataSource =
            Bdd.Query("SELECT DISTINCT emplacements.empl_id,empl_reference,empl_type,empl_nb_places,empl_nb_places-count(defunts.def_id) as places_libres,con_date_fin,empl_monum_classe" &
                " FROM emplacements LEFT OUTER JOIN defunts ON defunts.empl_id = emplacements.empl_id " &
                " LEFT OUTER JOIN concessions ON concessions.empl_id= emplacements.empl_id" &
                " GROUP BY emplacements.empl_id,concessions.con_id")
    End Sub

    Private Sub BtEnregistrer_Click(sender As Object, e As EventArgs)
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
        If Not TbdDateDebut.DateEstValide Then
            ErrorProvider1.SetError(TbdDateDebut, "La date est incorrecte")
        ElseIf TbdDateDebut.DateEstVide Then
            ErrorProvider1.SetError(TbdDateDebut, "Veuillez renseigner la date de début de la location")
        Else
            ErrorProvider1.SetError(TbdDateDebut, "")
        End If
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

    Private Sub ToutEstOk()
        ' validation
        TbCsnrPrenom_Validating(Nothing, Nothing)
        TbCsnrNom_Validating(Nothing, Nothing)
        TbdateCsnrDateNaiss_Validating(Nothing, Nothing)
        TbCsnrNoRegistre_Validating(Nothing, Nothing)
        TbdateDateDebut_Validating(Nothing, Nothing)
        TbfloatMontantPaye_Validating(Nothing, Nothing)
        CbEmplacement_Validating(Nothing, Nothing)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CtrlListeBenefs1.ToutEstOk Then
            CtrlListeBenefs1.GetBenefs()
        End If
    End Sub

    ' enregistrement : si empl loué, demander confirm pour remplacer (effacer) location actuelle


    Private Function GetTypeEmplacement() As TTypeEmpl

    End Function

    Private Sub DgvEmplacements_CellFormatting(sender As DataGridView, e As DataGridViewCellFormattingEventArgs) Handles DgvEmplacements.CellFormatting
        Select Case sender.Columns(e.ColumnIndex).DataPropertyName
            Case "empl_type"
                e.Value = Uzineagaz.TTypeEmplToString(e.Value)
            Case "places_libres"
                If Not IsDBNull(e.Value) AndAlso e.Value <= 0 Then
                    If e.Value < 0 Then e.Value = 0
                    e.CellStyle.BackColor = Color.Yellow
                End If
            Case "empl_monum_classe"
                If e.Value Then
                    e.Value = "Oui"
                    e.CellStyle.ForeColor = Color.Red
                Else
                    e.Value = "Non"
                End If
            Case "con_date_fin"
                If Not IsDBNull(e.Value) Then
                    Dim DateValue = CType(e.Value, Date)
                    If DateValue >= Today Then
                        e.CellStyle.BackColor = Color.Red
                        e.CellStyle.ForeColor = Color.White
                        e.Value = "Oui -> " & DateValue.ToString("dd/MM/yyyy")
                    Else
                        e.Value = "Non -> " & DateValue.ToString("dd/MM/yyyy")
                    End If
                End If
        End Select
    End Sub


End Class