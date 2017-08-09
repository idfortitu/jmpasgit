Public Class FormReservation

    Private Sub FormReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitListeEmplacements()
    End Sub

    Private Sub InitListeEmplacements()
        ' emplacements, avec nombre de places disponibles (places totales - défunts étant dans cet emplacement)
        ' et fin de la location actuelle, si l'emplacement est loué
        'DgvEmplacements.DataSource = _
        'Bdd.Query("SELECT DISTINCT emplacements.empl_id,empl_reference,empl_type,empl_nb_places,empl_nb_places-count(defunts.def_id) as places_libres,con_date_fin,empl_monum_classe" &
        '    " FROM emplacements LEFT OUTER JOIN defunts ON defunts.empl_id = emplacements.empl_id " &
        '    " LEFT OUTER JOIN concessions ON concessions.empl_id= emplacements.empl_id" &
        '    " GROUP BY emplacements.empl_id,concessions.con_id")
        DgvEmplacements.DataSource =
        Bdd.Query("SELECT DISTINCT emplacements.empl_id,empl_reference,empl_type,empl_nb_places,empl_nb_places-count(defunts.def_id) as places_libres,con_date_fin,empl_monum_classe" &
                " FROM emplacements LEFT OUTER JOIN defunts ON defunts.empl_id = emplacements.empl_id " &
                " LEFT OUTER JOIN (SELECT empl_id,MAX(con_date_fin) as con_date_fin FROM concessions WHERE con_date_debut <= NOW() AND con_date_fin >= NOW() GROUP BY empl_id) AS dates_fin ON dates_fin.empl_id= emplacements.empl_id" &
                " GROUP BY emplacements.empl_id")


    End Sub

    Private Sub BtEnregistrer_Click(sender As Object, e As EventArgs) Handles BtEnregistrer.Click

        If ToutEstOk() Then


            'MessageBox.Show("trankil sa passe")

            ' enregistrer

            ' nouveau concessionnaire
            Dim RowCsnr = Bdd.GetRowVide("concessionnaires")

            RowCsnr("csnr_nom") = TbCsnrNom.Text.Trim
            RowCsnr("csnr_prenom") = TbCsnrPrenom.Text.Trim
            RowCsnr("csnr_date_naiss") = If(TbdateCsnrDateNaiss.DateValue IsNot Nothing, TbdateCsnrDateNaiss.DateValue, DBNull.Value)
            RowCsnr("csnr_adresse") = TbCsnrAdresse.Text.Trim
            RowCsnr("csnr_no_registre") = If(TbCsnrNoRegistre.Text.Trim = "", DBNull.Value,TbCsnrNoRegistre.Text)
            RowCsnr("csnr_tel") = TbCsnrTel.Text.Trim
            RowCsnr("locville_id") = If(CtrlLocVillePays1.LocVilleId > 0, CtrlLocVillePays1.LocVilleId, DBNull.Value)
            ' ICI ajouter csnr
            Dim IdCsnr = Bdd.Insert("concessionnaires", RowCsnr)

            ' commentaire
            Dim RowCom = Bdd.GetRowVide("t_commentaire")
            RowCom("com_commentaire") = TbCommentaire.Text.Trim
            Dim IdCom = Bdd.Insert("t_commentaire", RowCom)

            ' histoire, même si en fait on s'en fout
            Dim RowHist = Bdd.GetRowVide("t_histoire")
            RowHist("h_histoire") = ""
            Dim IdHist = Bdd.Insert("t_histoire", RowHist)


            ' concession
            Dim RowCsn = Bdd.GetRowVide("concessions")

            RowCsn("con_date_debut") = TbdDateDebut.DateValue
            RowCsn("con_date_fin") = DateAdd(DateInterval.Year, If(Rb15Ans.Checked, 15, 30), RowCsn("con_date_debut"))
            RowCsn("con_nbre_renovations") = 0
            RowCsn("con_montant_paye") = TbfloatMontantPaye.Value
            RowCsn("empl_id") = CType(DgvEmplacements.SelectedRow.DataBoundItem, DataRowView).Row("empl_id")
            RowCsn("csnr_id") = IdCsnr
            RowCsn("com_id") = IdCom
            RowCsn("h_id") = IdHist
            ' histoire : osef
            Dim IdCsn = Bdd.Insert("concessions", RowCsn)

            Dim bens = CtrlListeBenefs1.GetBenefs
            Dim PremIdBen = Bdd.Insert("beneficiaires", bens)

            Dim LiensBensCsn = Bdd.GetTableVide("beneficier")
            For idben = PremIdBen To PremIdBen + bens.Rows.Count - 1
                LiensBensCsn.Rows.Add(IdCsn, idben)     ' ordre con_id,ben_id
            Next
            Bdd.Insert("beneficier", LiensBensCsn, True)


            DialogResult = DialogResult.OK

        Else
            ToolTip1.Show("Le formulaire contient des champs incorrects.", BtEnregistrer)
        End If

    End Sub

    Private Sub TbCsnrPrenom_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) 'Handles TbCsnrPrenom.Validating
        If TbCsnrPrenom.Text.Trim = "" Then
            ErrorProvider1.SetError(TbCsnrPrenom, "Veuillez entrer le prénom du concessionnaire")
        Else
            ErrorProvider1.SetError(TbCsnrPrenom, "")
        End If

    End Sub

    Private Sub TbCsnrNom_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) ' Handles TbCsnrNom.Validating
        If TbCsnrNom.Text.Trim = "" Then
            ErrorProvider1.SetError(TbCsnrNom, "Veuillez entrer le nom du concessionnaire")
        Else
            ErrorProvider1.SetError(TbCsnrNom, "")
        End If
    End Sub

    Private Sub TbdateCsnrDateNaiss_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) ' Handles TbdateCsnrDateNaiss.Validating
        If Not TbdateCsnrDateNaiss.DateEstValide Then
            ErrorProvider1.SetError(TbdateCsnrDateNaiss, "La date est incorrecte")
        Else
            ErrorProvider1.SetError(TbdateCsnrDateNaiss, "")
        End If
    End Sub

    Private Sub TbCsnrNoRegistre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) 'Handles TbCsnrNoRegistre.Validating
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

    Private Sub TbfloatMontantPaye_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) ' Handles TbfloatMontantPaye.Validating
        If TbfloatMontantPaye.Text = "" Then
            ErrorProvider1.SetError(TbfloatMontantPaye, "Veuillez indiquer le montant")
        Else
            ErrorProvider1.SetError(TbfloatMontantPaye, "")
        End If
    End Sub

    Private Sub CbEmplacement_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        If DgvEmplacements.SelectedRow Is Nothing Then
            ErrorProvider1.SetError(DgvEmplacements, "Veuillez indiquer un emplacement")
        Else
            ErrorProvider1.SetError(DgvEmplacements, "")
        End If
    End Sub

    Private Sub RbPers_Validating()
        If Rb1Pers.Checked OrElse Rb2Pers.Checked Then
            ErrorProvider1.SetError(Rb2Pers, "")
        Else
            ErrorProvider1.SetError(Rb2Pers, "Veuillez indiquer un choix")
        End If
    End Sub

    Private Sub RbDuree_Validating()
        If Rb15Ans.Checked OrElse Rb30Ans.Checked Then
            ErrorProvider1.SetError(Rb30Ans, "")
        Else
            ErrorProvider1.SetError(Rb30Ans, "Veuillez indiquer un choix.")
        End If
    End Sub

    Private Function ToutEstOk() As Boolean
        ' validation
        TbCsnrPrenom_Validating(Nothing, Nothing)
        TbCsnrNom_Validating(Nothing, Nothing)
        TbdateCsnrDateNaiss_Validating(Nothing, Nothing)
        TbCsnrNoRegistre_Validating(Nothing, Nothing)
        TbfloatMontantPaye_Validating(Nothing, Nothing)
        TbdateDateDebut_Validating(Nothing, Nothing)
        CbEmplacement_Validating(Nothing, Nothing)
        RbPers_Validating()
        RbDuree_Validating()

        Return CtrlListeBenefs1.ToutEstOk _
            AndAlso ErrorProvider1.GetError(TbCsnrNom) = "" _
            AndAlso ErrorProvider1.GetError(TbCsnrPrenom) = "" _
            AndAlso ErrorProvider1.GetError(TbdateCsnrDateNaiss) = "" _
            AndAlso ErrorProvider1.GetError(TbfloatMontantPaye) = "" _
            AndAlso ErrorProvider1.GetError(TbCsnrNoRegistre) = "" _
            AndAlso ErrorProvider1.GetError(TbdDateDebut) = "" _
            AndAlso ErrorProvider1.GetError(DgvEmplacements) = "" _
            AndAlso ErrorProvider1.GetError(Rb2Pers) = "" _
            AndAlso ErrorProvider1.GetError(Rb30Ans) = ""
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CtrlListeBenefs1.ToutEstOk Then
            CtrlListeBenefs1.GetBenefs()
        End If
    End Sub

    ' enregistrement : si empl loué, demander confirm pour remplacer (effacer) location actuelle



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