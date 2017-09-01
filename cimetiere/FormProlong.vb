Public Class FormProlong

    ' n'est valide que si le résultat du form est DialogResult.OK
    Public NouvelleDate As Date?

    Private Concessions As DataTable

    Private Preselection As Integer
    Private RowForcee As DataGridViewRow

    Public Sub New()
        InitializeComponent()
        DgvCsns.AutoGenerateColumns = False
        Me.Preselection = -1
    End Sub

    Public Sub New(IdSelectionInitiale As Integer)
        InitializeComponent()
        DgvCsns.AutoGenerateColumns = False
        Me.Preselection = IdSelectionInitiale
    End Sub

    Private Sub FormProlong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtInfosCsnr.Text = "Utiliser les informations" & vbCrLf & "du concessionnaire"
        ' on présente aussi les concessions non expirées ou qui ont expiré il y a moins de 2 mois - valeur un peu arbitraire

        ' ramène les noms des défunts et des bénéficiaires ensembles (group_concat), avec le séparateur "¤" - j'ose espérer que personne n'a ça dans son nom
        Concessions = Bdd.Query("SELECT concessions.con_id,emplacements.empl_id,empl_reference,con_date_debut,con_date_fin,com_commentaire,concessionnaires.csnr_id,CONCAT(csnr_prenom,' ',csnr_nom) AS csnr_nom" &
                                     ", COUNT(distinct defunts.def_id) AS empl_nb_defunts,GROUP_CONCAT(DISTINCT ben_prenom, ' ', ben_nom SEPARATOR '¤') AS noms_benefs" &
                                     ", GROUP_CONCAT(DISTINCT def_prenom,' ',def_nom ORDER BY def_date_deces ASC SEPARATOR '¤') AS noms_defunts" &
                                     " FROM concessions" &
                                     " INNER JOIN emplacements ON emplacements.empl_id = concessions.empl_id" &
                                     " INNER JOIN concessionnaires ON concessionnaires.csnr_id = concessions.con_id" &
                                     " LEFT OUTER JOIN beneficier ON beneficier.con_id = concessions.con_id" &
                                     " LEFT OUTER JOIN beneficiaires ON beneficiaires.ben_id = beneficier.ben_id" &
                                     " LEFT OUTER JOIN defunts ON defunts.empl_id = emplacements.empl_id" &
                                     " INNER JOIN t_commentaire ON t_commentaire.com_id = concessions.com_id" &
                                     " GROUP BY concessions.con_id")

        DgvCsns.DataSource = Concessions

        If Me.Preselection <> -1 Then
            Dim dgvrowcsn As DataGridViewRow = (From r As DataGridViewRow In DgvCsns.Rows Where r.Cells("ColConId").Value = Me.Preselection).FirstOrDefault
            If dgvrowcsn IsNot Nothing Then
                dgvrowcsn.Selected = True
                ChangementSelectionInterdit = True
                Me.RowForcee = dgvrowcsn
            End If
        End If

    End Sub


    ' recherche 
    ' - champs recherchés :
    ' - réf emplacement
    ' - nom csnr
    ' - noms bénefs
    ' - noms défunts
    ' - date fin ?



    Private ChangementSelectionInterdit = False

    Private Sub DgvCsns_SelectionChanged(sender As Object, e As EventArgs) Handles DgvCsns.SelectionChanged
        If ChangementSelectionInterdit Then
            Me.RowForcee.Selected = True
            Exit Sub
        End If
        LbBenefs.Items.Clear()
        LbOccupants.Items.Clear()
        Dim RowCsn = DgvCsns.SelectedDataRow
        If RowCsn IsNot Nothing Then
            If Not IsDBNull(RowCsn("noms_benefs")) Then LbBenefs.Items.AddRange(CType(RowCsn("noms_benefs"), String).Split("¤").ToArray)
            If Not IsDBNull(RowCsn("noms_defunts")) Then LbOccupants.Items.AddRange(CType(RowCsn("noms_defunts"), String).Split("¤").ToArray)
            TbCom.Text = RowCsn("com_commentaire")
            TbDateDebut.Text = If(IsDBNull(RowCsn("con_date_debut")), Nothing, CType(RowCsn("con_date_debut"), Date).ToString("dd/MM/yyyy"))
            TbDateFinAct.Text = If(IsDBNull(RowCsn("con_date_fin")), Nothing, CType(RowCsn("con_date_fin"), Date).ToString("dd/MM/yyyy"))
            TbNouvDateFin.Text = ""
            BtAjouterAnnees.Enabled = Not IsDBNull(RowCsn("con_date_fin"))
            TbAnneesAjout.Enabled = BtAjouterAnnees.Enabled
        Else
            BtAjouterAnnees.Enabled = False
            TbAnneesAjout.Enabled = False
            TbCom.Text = ""
            TbDateDebut.Text = ""
            TbDateFinAct.Text = ""
            TbNouvDateFin.Text = ""
        End If
    End Sub



    Private Sub BtTerminer_Click(sender As Object, e As EventArgs) Handles BtTerminer.Click
        Dim Erreur = False
        If DgvCsns.SelectedRows.Count = 0 Then
            ErProv.SetError(DgvCsns, "Veuillez indiquer une concession à prolonger")
            Erreur = True
        Else
            ErProv.SetError(DgvCsns, "")
        End If
        ' valid date fin
        ' ceci étant une demande de prolongation censée être examinée par le Collège, on accepte que la nouvelle date de fin ne soit pas encore indiquée
        If Not TbNouvDateFin.DateEstValide Then
            ErProv.SetError(TbNouvDateFin, "Le format de la date est invalide")
            Erreur = True
        Else
            ErProv.SetError(TbNouvDateFin, "")
        End If
        ' valid nom dmdr
        If TbDmdrNom.Text.Trim = "" Then
            Erreur = True
            ErProv.SetError(TbDmdrNom, "Veuillez indiquer le nom du demandeur")
        Else
            ErProv.SetError(TbDmdrNom, "")
        End If
        ' prénom dmdr
        If TbDmdrPrenom.Text.Trim = "" Then
            Erreur = True
            ErProv.SetError(TbDmdrPrenom, "Veuillez indiquer le prénom du demandeur")
        Else
            ErProv.SetError(TbDmdrNom, "")
        End If
        ' date naiss dmdr
        If TbDmdrDateNaiss.DateEstValide Then
            ErProv.SetError(TbDmdrDateNaiss, "")
        Else
            ErProv.SetError(TbDmdrDateNaiss, "Le format de la date n'est pas valide")
            Erreur = True
        End If


        If Not Erreur Then

            Dim AnnulerEnregistrement = False

            ' nom fic pdf
            Dim NomficPdf As String
            If CbEnregPdfCsn.Checked Then
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


            If Not AnnulerEnregistrement Then

                Dim RowCsnSelect = DgvCsns.SelectedDataRow
                Dim NvDateFin As Date? = TbNouvDateFin.DateValue
                'If TbNouvDateFin.DateValue IsNot Nothing Then
                Dim RowCsnUpdate = Bdd.GetRow("concessions", RowCsnSelect("con_id"))
                RowCsnUpdate("con_date_fin") = If(NvDateFin.HasValue, NvDateFin, DBNull.Value)
                Bdd.Update("concessions", RowCsnUpdate)
                'End If

                ' enregistrer pdf

                Dim RowDmdr As DataRow = Bdd.GetRowVide("concessionnaires")
                RowDmdr("csnr_nom") = TbDmdrNom.Text.Trim
                RowDmdr("csnr_prenom") = TbDmdrPrenom.Text.Trim
                RowDmdr("csnr_date_naiss") = If(TbDmdrDateNaiss.DateEstVide, DBNull.Value, TbDmdrDateNaiss.DateValue)
                RowDmdr("csnr_adresse") = TbDmdrAdresse.Text.Trim
                RowDmdr("csnr_no_registre") = DBNull.Value
                RowDmdr("csnr_tel") = TbDmdrTel.Text.Trim
                RowDmdr("locville_id") = If(CtrlVilleDmdr.LocVilleId <= 0, DBNull.Value, CtrlVilleDmdr.LocVilleId)

                Dim p As New ExporteurPdf

                p.NomFic = NomficPdf
                p.CreerPdfProlong(RowDmdr, Bdd.Query("SELECT * FROM defunts WHERE empl_id = " & RowCsnSelect("empl_id")), RowCsnSelect("empl_reference"), TbRem.Text.Trim) 'RowDef, RowDmdr, TTypeCsnInh.CsnExistante, GetTypeInhCsnExis, DateSign, RefEmpl, DefuntsDeja)

                Shell("explorer.exe """ & NomficPdf & """")      ' À faire : ne pas ouvrir si fichier non sauvegardé (car erreur par exemple)


                Me.NouvelleDate = TbNouvDateFin.DateValue
                Me.DialogResult = DialogResult.OK
            End If

        End If

    End Sub



    Private Sub TbRecherche_TextChanged(sender As Object, e As EventArgs) Handles TbRecherche.TextChanged
        If Concessions IsNot Nothing Then
            Dim Txt = TbRecherche.Text.Trim
            Concessions.DefaultView.RowFilter = "empl_reference Like '%" & Txt & "%' Or csnr_nom Like '%" & Txt & "%' Or noms_benefs Like '%" & Txt & "%' Or noms_defunts Like '%" & Txt & "%'"
        End If
    End Sub

    Private Sub BtViderFiltre_Click(sender As Object, e As EventArgs) Handles BtViderFiltre.Click
        TbRecherche.Text = ""
    End Sub

    Private Sub BtAjouterAnnees_Click(sender As Object, e As EventArgs) Handles BtAjouterAnnees.Click
        'Dim Nbre = TbAnneesAjout.Value
        TbNouvDateFin.DateValue = DateAdd(DateInterval.Year, Convert.ToDouble(TbAnneesAjout.Value), DgvCsns.SelectedDataRow("con_date_fin"))
    End Sub


    Private Sub TbAnneesAjout_TextChanged(sender As Object, e As EventArgs) Handles TbAnneesAjout.TextChanged
        BtAjouterAnnees.Enabled = TbAnneesAjout.Text <> ""
    End Sub

    Private Sub DgvCsns_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvCsns.CellFormatting
        If DgvCsns.Columns(e.ColumnIndex).Name = "DgvCsnsColOccupants" Then
            If Not IsDBNull(e.Value) Then e.Value = CType(e.Value, String).Replace("¤", ", ")
        End If
    End Sub

    Private Sub BtInfosCsnr_Click(sender As Object, e As EventArgs) Handles BtInfosCsnr.Click
        Static InfosCsnr As DataRow
        If InfosCsnr Is Nothing Then
            InfosCsnr = Bdd.Query("SELECT * FROM concessionnaires LEFT OUTER JOIN t_loc_ville ON concessionnaires.locville_id = t_loc_ville.locville_id WHERE csnr_id = " & DgvCsns.SelectedDataRow("csnr_id")).Rows(0)
        End If
        TbDmdrNom.Text = InfosCsnr("csnr_nom")
        TbDmdrPrenom.Text = InfosCsnr("csnr_prenom")
        TbDmdrAdresse.Text = InfosCsnr("csnr_adresse")
        TbDmdrDateNaiss.DateValue = If(IsDBNull(InfosCsnr("csnr_date_naiss")), Nothing, InfosCsnr("csnr_date_naiss"))
        TbDmdrTel.Text = InfosCsnr("csnr_tel")
        CtrlVilleDmdr.LocVilleId = If(IsDBNull(InfosCsnr("locville_id")), -1, InfosCsnr("locville_id"))
    End Sub







    ' choix concession (aff liste)
    ' choix durée avec auto +30 et +15
    ' montant payé

    ' infos suppl :
    ' bénefs
    ' commentaire
    ' infos csnr
    ' infos défunt(s)




End Class