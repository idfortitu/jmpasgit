Public Class FormReservation

    ' "publie" certaines données pour l'appelant
    ' la valeur de ces props n'est pas garantie tant que l'enregistrement n'a pas été fait
    ' + note : à part pour RowCsn, il n'est pas garanti que l'Id soit initialisé, à faire au besoin
    Public RowCsnr, RowComCsn, RowHist, RowCsn As DataRow
    Public TblBenefs As DataTable
    Public NomficPdf As String
    Public Property TypeCsn As TTypeCsnInh



    Public Property CbEnregPdfChecked As Boolean
        Get
            Return CbEnregPdf.Checked
        End Get
        Set(value As Boolean)
            CbEnregPdf.Checked = value
        End Set
    End Property

    Enum TMode
        Normal
        Dependant   ' si fait lors d'une demande inhumation
    End Enum
    Private Mode As TMode

    Public Sub New(Optional mode As TMode = TMode.Normal)
        InitializeComponent()
        Me.Mode = mode
        If mode = TMode.Dependant Then DtpDateSign.Hide()            'PanCbsPdf.Hide()
    End Sub

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

        ' empls sans con active
        DgvEmplacements.DataSource =
            Bdd.Query("SELECT emplacements.empl_id,empl_reference,empl_type,empl_nb_places,empl_nb_places-COUNT(defunts.def_id) AS places_libres,empl_monum_classe" &
                " FROM emplacements LEFT OUTER JOIN concessions ON emplacements.empl_id = concessions.empl_id" &
                " AND (con_date_fin IS NULL OR con_date_fin > NOW())" &
                " LEFT OUTER JOIN defunts ON defunts.empl_id = emplacements.empl_id" &
                " GROUP BY emplacements.empl_id" &
                " HAVING COUNT(concessions.con_id) = 0")



        ' pas virer, peut servir
        ' empls avec concessions actives & date fin 
        'Bdd.Query("SELECT DISTINCT emplacements.empl_id,empl_reference,empl_type,empl_nb_places,empl_nb_places-count(defunts.def_id) as places_libres,con_date_fin,empl_monum_classe" &
        '        " FROM emplacements LEFT OUTER JOIN defunts ON defunts.empl_id = emplacements.empl_id " &
        '        " LEFT OUTER JOIN (SELECT empl_id,MAX(con_date_fin) as con_date_fin FROM concessions WHERE con_date_debut <= NOW() AND con_date_fin >= NOW() GROUP BY empl_id) AS dates_fin ON dates_fin.empl_id= emplacements.empl_id" &
        '        " GROUP BY emplacements.empl_id")


    End Sub

    Private Sub BtEnregistrer_Click(sender As Object, e As EventArgs) Handles BtEnregistrer.Click

        If ToutEstOk() Then

            Dim AnnulerEnregistrement = False
            Dim NomficPdf As String = Nothing

            ' voyons d'abord si l'utilisateur entre un nom de fichier ; si il annule, on revient à la fenêtre sans enregistrer

            If CbEnregPdf.Checked Then
                ' À TESTER - si nomfic incorrect ?
                Dim SavDlg As New SaveFileDialog()
                With SavDlg
                    .AddExtension = True
                    .DefaultExt = "pdf"
                    .AutoUpgradeEnabled = True
                    .CheckPathExists = True
                    '.InitialDirectory =    ' à adapter selon config
                    .OverwritePrompt = True
                    '.Title =       ' à voir
                    .ValidateNames = True
                    .Filter = "Document pdf (*.pdf)|*.pdf"
                    ' nom du fichier par défaut, à adapter
                    .FileName = Format(Now.Year, "0000") & "_" & Format(Now.Month, "00") & "_" & Format(Now.Day, "00") & "_" & Format(Now.Hour, "00") & Format(Now.Minute, "00") & Format(Now.Second, "00") & ".pdf"
                End With
                If (SavDlg.ShowDialog = DialogResult.OK) Then
                    NomficPdf = SavDlg.FileName
                Else
                    AnnulerEnregistrement = True
                End If
            Else
                NomficPdf = IO.Path.GetTempFileName & Guid.NewGuid().ToString() + ".pdf"        ' .pdf pour qu'il s'ouvre avec le bon prog, guid pour diminuer les chances d'un fichier qui existe déjà
            End If
            Me.NomficPdf = NomficPdf


            If Not AnnulerEnregistrement Then

                ' enregistrer

                Dim DateSign As Date? = If(DtpDateSign.Checked, DtpDateSign.Value, Nothing)

                Dim TypeCsnDemande = {TTypeCsnInh.Cercueil1Pers15Ans,
                                      TTypeCsnInh.Cercueil2Pers15Ans,
                                      TTypeCsnInh.Caveau30AnsCercueil,
                                      TTypeCsnInh.UrneColomb15Ans,
                                      TTypeCsnInh.UrneColomb30Ans,
                                      TTypeCsnInh.CavurneCommunal} _
                                     (LbTypeConcession.SelectedIndex)

                Me.TypeCsn = TypeCsnDemande

                ' nouveau concessionnaire
                Me.RowCsnr = Bdd.GetRowVide("concessionnaires")

                RowCsnr("csnr_nom") = TbCsnrNom.Text.Trim
                RowCsnr("csnr_prenom") = TbCsnrPrenom.Text.Trim
                RowCsnr("csnr_date_naiss") = If(TbdateCsnrDateNaiss.DateValue IsNot Nothing, TbdateCsnrDateNaiss.DateValue, DBNull.Value)
                RowCsnr("csnr_adresse") = TbCsnrAdresse.Text.Trim
                RowCsnr("csnr_no_registre") = If(TbCsnrNoRegistre.Text.Trim = "", DBNull.Value, TbCsnrNoRegistre.Text)
                RowCsnr("csnr_tel") = TbCsnrTel.Text.Trim
                RowCsnr("locville_id") = If(CtrlLocVillePays1.LocVilleId > 0, CtrlLocVillePays1.LocVilleId, DBNull.Value)
                ' ICI ajouter csnr
                Dim IdCsnr = Bdd.Insert("concessionnaires", RowCsnr)

                ' commentaire
                Me.RowComCsn = Bdd.GetRowVide("t_commentaire")
                RowComCsn("com_commentaire") = TbCommentaire.Text.Trim
                Dim IdCom = Bdd.Insert("t_commentaire", RowComCsn)

                ' histoire, même si en fait on s'en fout
                Me.RowHist = Bdd.GetRowVide("t_histoire")
                RowHist("h_histoire") = ""
                Dim IdHist = Bdd.Insert("t_histoire", RowHist)


                ' concession
                Me.RowCsn = Bdd.GetRowVide("concessions")

                RowCsn("con_date_debut") = DtpDateDebut.Value
                RowCsn("con_date_fin") = DateAdd(DateInterval.Year, If({0, 1, 3}.Contains(LbTypeConcession.SelectedIndex), 15, 30), RowCsn("con_date_debut"))
                RowCsn("con_nbre_renovations") = 0
                RowCsn("con_montant_paye") = TbMontant.Value
                RowCsn("empl_id") = CType(DgvEmplacements.SelectedRow.DataBoundItem, DataRowView).Row("empl_id")
                RowCsn("csnr_id") = IdCsnr
                RowCsn("com_id") = IdCom
                RowCsn("h_id") = IdHist
                ' histoire : osef
                Dim IdCsn = Bdd.Insert("concessions", RowCsn)
                RowCsn("con_id") = IdCsn

                Me.TblBenefs = CtrlListeBenefs1.GetBenefs

                If TblBenefs.Rows.Count > 0 Then

                    Dim PremIdBen = Bdd.Insert("beneficiaires", TblBenefs)

                    Dim LiensBensCsn = Bdd.GetTableVide("beneficier")
                    For idben = PremIdBen To PremIdBen + TblBenefs.Rows.Count - 1
                        LiensBensCsn.Rows.Add(IdCsn, idben)     ' ordre con_id,ben_id
                    Next
                    Bdd.Insert("beneficier", LiensBensCsn, True)

                End If


                ' pdf

                If Me.Mode = TMode.Normal Then      ' en mode "demande inhumation", on laisse le soin à l'appelant de s'occuper du pdf à l'aide de Me.Nomficpdf et des infos rendues visibles
                    Dim p = New ExporteurPdf
                    p.CreePdfReservation(RowCsnr, TypeCsnDemande, TblBenefs, RowComCsn("com_commentaire"), DateSign)

                    Shell("explorer.exe """ & NomficPdf & """")      ' À faire : ne pas ouvrir si fichier non sauvegardé (car erreur par exemple)

                End If

                DialogResult = DialogResult.OK

            End If

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

    'Private Sub TbfloatMontantPaye_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) ' Handles TbfloatMontantPaye.Validating
    '    If TbMontant.Text = "" Then
    '        ErrorProvider1.SetError(TbMontant, "Veuillez indiquer le montant")
    '    Else
    '        ErrorProvider1.SetError(TbMontant, "")
    '    End If
    'End Sub

    Private Sub CbEmplacement_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        If DgvEmplacements.SelectedRow Is Nothing Then
            ErrorProvider1.SetError(DgvEmplacements, "Veuillez indiquer un emplacement")
        Else
            ErrorProvider1.SetError(DgvEmplacements, "")
        End If
    End Sub

    Private Sub LbTypeCsn_Validating()
        If LbTypeConcession.SelectedIndex = -1 Then
            ErrorProvider1.SetError(LbTypeConcession, "Veuillez indiquer un choix")
        Else
            ErrorProvider1.SetError(LbTypeConcession, "")
        End If
    End Sub

    Private Sub TbNbPlaces_Validating()
        If TbNbPlaces.Enabled And (TbNbPlaces.Value Is Nothing OrElse TbNbPlaces.Value = 0) Then
            ErrorProvider1.SetError(TbNbPlaces, "Veuillez indiquer le nombre de places")
        Else
            ErrorProvider1.SetError(TbNbPlaces, "")
        End If
    End Sub

    Private Function ToutEstOk() As Boolean
        ' validation
        TbCsnrPrenom_Validating(Nothing, Nothing)
        TbCsnrNom_Validating(Nothing, Nothing)
        TbdateCsnrDateNaiss_Validating(Nothing, Nothing)
        TbCsnrNoRegistre_Validating(Nothing, Nothing)
        'TbfloatMontantPaye_Validating(Nothing, Nothing)
        CbEmplacement_Validating(Nothing, Nothing)
        LbTypeCsn_Validating()
        TbNbPlaces_Validating()

        Return CtrlListeBenefs1.ToutEstOk _
            AndAlso ErrorProvider1.GetError(TbCsnrNom) = "" _
            AndAlso ErrorProvider1.GetError(TbCsnrPrenom) = "" _
            AndAlso ErrorProvider1.GetError(TbdateCsnrDateNaiss) = "" _
            AndAlso ErrorProvider1.GetError(TbCsnrNoRegistre) = "" _
            AndAlso ErrorProvider1.GetError(DgvEmplacements) = "" _
            AndAlso ErrorProvider1.GetError(LbTypeConcession) = "" _
            AndAlso ErrorProvider1.GetError(TbNbPlaces) = ""
        '            AndAlso ErrorProvider1.GetError(TbMontant) = "" _ ' readonly, montant généré automatiquement

    End Function


    Private Sub LbTypeConcession_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LbTypeConcession.SelectedIndexChanged
        ' activer ou désactiver tbnombre
        TbNbPlaces.Enabled = {2, 5}.Contains(LbTypeConcession.SelectedIndex)
        MajDateFin()
    End Sub

    Private Sub DtpDateDebut_ValueChanged(sender As Object, e As EventArgs) Handles DtpDateDebut.ValueChanged
        MajDateFin()
    End Sub

    Private Sub MajDateFin()
        If LbTypeConcession.SelectedIndex >= 0 Then
            TbDateFin.Text = DateAdd(DateInterval.Year, If({0, 1, 3}.Contains(LbTypeConcession.SelectedIndex), 15, 30), DtpDateDebut.Value).ToString("dd/MM/yyyy") 'RowCsn("con_date_debut"))
        Else
            TbDateFin.Text = ""
        End If

    End Sub

    Private Sub TrucChanged(sender As Object, e As EventArgs) Handles TbNbPlaces.TextChanged, CbTarifLh.CheckedChanged, LbTypeConcession.SelectedIndexChanged
        ' recalculer prix
        TbMontant.Value = PrixCalculé()
    End Sub



    Private Function PrixCalculé() As Single
        If LbTypeConcession.SelectedIndex = -1 Then Return 0
        Select Case LbTypeConcession.SelectedIndex
            Case 0       ' pleine terre 15ans 1pers
                Return If(CbTarifLh.Checked, 250, 1800)
            Case 1      ' idem 2 pers
                Return If(CbTarifLh.Checked, 500, 3600)
            Case 2      ' caveau
                Return If(CbTarifLh.Checked, 400 + 500 * If(TbNbPlaces.Value, 0), 1800 + 500 * If(TbNbPlaces.Value, 0))
            Case 3      ' urne 15 ans
                Return If(CbTarifLh.Checked, 250, 1800)
            Case 4      ' urne 30 ans
                Return If(CbTarifLh.Checked, 400, 2500)
            Case 5      ' cavurne communal
                Return If(CbTarifLh.Checked, If(TbNbPlaces.Value, 0) * 250, If(TbNbPlaces.Value, 0) * 500)
            Case Else
                Return 0    ' aucune chance normalement
        End Select
    End Function



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
                    Dim DateValue = CType(e.Value, Date?)
                    If DateValue >= Today Then
                        e.CellStyle.BackColor = Color.Red
                        e.CellStyle.ForeColor = Color.White
                        e.Value = "Oui" & If(DateValue IsNot Nothing, " -> " & DateValue.ToString("dd/MM/yyyy"), "")
                    Else
                        e.Value = "Non"
                    End If
                End If
        End Select
    End Sub

    Private Sub DgvEmplacements_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvEmplacements.CellFormatting

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New FormDemandeInhumation
        f.ShowDialog()
    End Sub
End Class