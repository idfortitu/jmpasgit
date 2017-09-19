Public Class FormDemandeInhumation

    Public Sub New()
        InitializeComponent()
        DgvCsnsExist.AutoGenerateColumns = False
        DgvEmplacementsPourInhOrd.AutoGenerateColumns = False
    End Sub

    Private Sub FormDemandeInhumation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TVilles = Bdd.GetTable("t_loc_ville")
        Dim TPays = Bdd.GetTable("t_Pays")
        CtrlDefLocvillepays.chargercomboboxpays(TPays)
        CtrlDefLocvillepays.chargercomboboxville(TVilles)
        CtrlLocVillePays1.chargercomboboxpays(TPays)    ' sais même pas si il est utilisé
        CtrlLocVillePays1.chargercomboboxville(TVilles)
        CtrlVilleDmdr.chargercomboboxpays(TPays)
        CtrlVilleDmdr.chargercomboboxville(TVilles)
        CtrlLocPcont.chargercomboboxville(TVilles)
        CtrlLocPcont.chargercomboboxpays(TPays)
    End Sub


    ' bouton "suivant" de la première page
    ' passe à l'onglet ou à l'action appropriée
    Private Sub BtSuivant_Click(sender As Object, e As EventArgs) Handles BtSuivant.Click
        Select Case True
            Case RbInhOrd.Checked
                If ValidePourBtSuivant() Then
                    If LbTypeInhOrd.SelectedIndex <> 4 Then     ' saute le choix d'emplacement si c'est une dispersion
                        ChangerPage(TabP2InhOrd)
                        OngletInhSimpleSelectionne()
                    Else
                        CbEnregPdfInhOrd.Checked = CbEnregPdfP1.Checked
                        BtTerminerInhOrd_Click(Nothing, Nothing)
                    End If

                End If
            Case RbNouvelleCon.Checked
                BtSuivantNouvelleCon()
            Case RbConcExis.Checked
                If ValidePourBtSuivant() Then
                    ChangerPage(TabP2ConExis)
                    OngletCsnsExistantesSelectionne()
                End If
        End Select
    End Sub


#Region "Validation première page"

    Public Function ValidePourBtSuivant() As Boolean
        ValiderRbChoix()
        ValiderNumLhDefunt()
        ValiderNomDef()
        ValiderPrenomDef()
        ValiderDateNaissDef()
        ValiderDateDecesDef()
        ValiderLbTypeInh()
        ValiderNomDmdr()
        ValiderPrenomDmdr()
        ValiderNomPcont()
        ValiderPrenomPcont()

        Return ErrorProvider1.GetError(RbNouvelleCon) = "" _
            AndAlso ErrorProvider1.GetError(TbDefNumLh) = "" _
            AndAlso ErrorProvider1.GetError(TbDefNom) = "" _
            AndAlso ErrorProvider1.GetError(TbDefPrenom) = "" _
            AndAlso ErrorProvider1.GetError(TbDefDateNaiss) = "" _
            AndAlso ErrorProvider1.GetError(TbDefDateDeces) = "" _
            AndAlso ErrorProvider1.GetError(LbTypeInhOrd) = "" _
            AndAlso ErrorProvider1.GetError(TbDmdrNom) = "" _
            AndAlso ErrorProvider1.GetError(TbDmdrPrenom) = "" _
            AndAlso ErrorProvider1.GetError(TbPcontNom) = "" _
            AndAlso ErrorProvider1.GetError(TbPcontPrenom) = ""
    End Function

    Private Function ValidePrFinCsnExis() As Boolean
        ValiderChoixCsnExistante()
        Return ErrorProvider1.GetError(DgvCsnsExist) = ""
    End Function


    Private Sub ValiderRbChoix()
        If Not (RbConcExis.Checked OrElse RbInhOrd.Checked OrElse RbNouvelleCon.Checked) Then
            ErrorProvider1.SetError(RbNouvelleCon, "Veuillez indiquer un choix")
        Else
            ErrorProvider1.SetError(RbNouvelleCon, "")
        End If
    End Sub

    ' valid code défunt : ne doit pas déjà exister ; si non précisé, on le génèrera automatiquement
    Private Sub ValiderNumLhDefunt()
        If TbDefNumLh.Value IsNot Nothing AndAlso
        Bdd.Query("SELECT def_id FROM defunts WHERE def_numero_lh = " & TbDefNumLh.Value).Rows.Count > 0 Then
            ErrorProvider1.SetError(TbDefNumLh, "Un autre défunt porte déjà ce numéro")
        Else
            ErrorProvider1.SetError(TbDefNumLh, "")
        End If
    End Sub
    Private Sub ValiderNomDef()
        If TbDefNom.Text.Trim = "" Then
            ErrorProvider1.SetError(TbDefNom, "Veuillez indiquer le nom du défunt")
        Else
            ErrorProvider1.SetError(TbDefNom, "")
        End If
    End Sub
    Private Sub ValiderPrenomDef()
        If TbDefPrenom.Text.Trim = "" Then
            ErrorProvider1.SetError(TbDefPrenom, "Veuillez indiquer le prénom du défunt")
        Else
            ErrorProvider1.SetError(TbDefPrenom, "")
        End If
    End Sub
    Private Sub ValiderDateNaissDef()
        If TbDefDateNaiss.DateEstValide Then
            ErrorProvider1.SetError(TbDefDateNaiss, "")
        Else
            ErrorProvider1.SetError(TbDefDateNaiss, "La date n'est pas valide")
        End If
    End Sub
    Private Sub ValiderDateDecesDef()
        If TbDefDateDeces.DateEstValide Then
            ErrorProvider1.SetError(TbDefDateDeces, "")
        Else
            ErrorProvider1.SetError(TbDefDateDeces, "La date n'est pas valide")
        End If
    End Sub
    Private Sub ValiderLbTypeInh()
        If RbInhOrd.Checked AndAlso LbTypeInhOrd.SelectedIndex = -1 Then
            ErrorProvider1.SetError(LbTypeInhOrd, "Veuillez indiquer un choix")
        Else
            ErrorProvider1.SetError(LbTypeInhOrd, "")

        End If
    End Sub
    Private Sub ValiderNomDmdr()
        If TbDmdrNom.Text.Trim = "" Then
            ErrorProvider1.SetError(TbDmdrNom, "Veuillez indiquer le nom du demandeur")
        Else
            ErrorProvider1.SetError(TbDmdrNom, "")
        End If

    End Sub
    Private Sub ValiderPrenomDmdr()
        If TbDmdrPrenom.Text.Trim = "" Then
            ErrorProvider1.SetError(TbDmdrPrenom, "Veuillez indiquer le prénom du demandeur")
        Else
            ErrorProvider1.SetError(TbDmdrPrenom, "")
        End If
    End Sub
    Private Sub ValiderChoixCsnExistante()
        If DgvCsnsExist.SelectedRow Is Nothing Then
            ErrorProvider1.SetError(DgvCsnsExist, "Veuillez sélectionner une concession")
        Else
            ErrorProvider1.SetError(DgvCsnsExist, "")
        End If
    End Sub

    Private Sub ValiderNomPcont()
        If CbPCont.Checked AndAlso TbPcontNom.Text.Trim = "" Then
            ErrorProvider1.SetError(TbPcontNom, "Veuillez indiquer le nom de la personne de contact")
        Else
            ErrorProvider1.SetError(TbPcontNom, "")
        End If
    End Sub
    Private Sub ValiderPrenomPcont()
        If CbPCont.Checked AndAlso TbPcontPrenom.Text.Trim = "" Then
            ErrorProvider1.SetError(TbPcontPrenom, "Veuillez indiquer le prénom de la personne de contact")
        Else
            ErrorProvider1.SetError(TbPcontPrenom, "")
        End If
    End Sub


#End Region


    ' on ne doit pas pouvoir changer d'onglet manuellement, seulement en cliquant sur suivant/précédent
    Private TabsBloqués As Boolean = True
    Private Sub TabControl1_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles TabControl1.Selecting
        If TabsBloqués Then
            e.Cancel = True
        End If
    End Sub
    Sub ChangerPage(page As TabPage)
        TabsBloqués = False
        TabControl1.SelectTab(page)
        TabsBloqués = True
    End Sub

    Private Sub RbInhOrd_CheckedChanged(sender As RadioButton, e As EventArgs) Handles RbInhOrd.CheckedChanged
        LbTypeInhOrd.Visible = sender.Checked
    End Sub




#Region "Onglet concession existante"

    ' reprend la valeur de la checkbox 'enregistrer pdf' à la première page
    Private Sub OngletCsnsExistantesSelectionne()
        CbEnregPdfCsnExis.Checked = CbEnregPdfP1.Checked
        If DgvCsnsExist.DataSource Is Nothing Then
            DgvCsnsExist.DataSource = GetListeConcessionsExistantes()
        End If
    End Sub


    Private Sub BtPrécédentDeConExis_Click(sender As Object, e As EventArgs) Handles BtPrécédentDeConExis.Click
        If FormPlanCsnsExist IsNot Nothing Then
            FormPlanCsnsExist.Close()
        End If
        CbEnregPdfP1.Checked = CbEnregPdfCsnExis.Checked
        ChangerPage(TabPage1)
    End Sub


    Private TableConcessionsExistantes As DataTable
    Private Function GetListeConcessionsExistantes()
        If TableConcessionsExistantes Is Nothing Then
            TableConcessionsExistantes = Bdd.Query("SELECT concessions.con_id,emplacements.empl_id,empl_reference,empl_nb_places,con_date_debut,con_date_fin,com_commentaire,concessionnaires.csnr_id,CONCAT(csnr_prenom,' ',csnr_nom) AS csnr_nom" &
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

        End If
        Return TableConcessionsExistantes
    End Function


    ' à la sélection, affiche des infos suppl et sélectionne sur le form plan si il est ouvert
    Private Sub DgvCsnsExist_SelectionChanged(sender As Object, e As EventArgs) Handles DgvCsnsExist.SelectionChanged
        LvCsnExisBenefs.Items.Clear()
        LvCsnExistOccupants.Items.Clear()
        If DgvCsnsExist.SelectedRows.Count > 0 Then
            ' liste benefs
            Dim RowCsn = CType(DgvCsnsExist.SelectedRow.DataBoundItem, DataRowView).Row
            Dim TblBenefs = GetBenefsDeCsn(RowCsn("con_id"))

            For Each RowBen In TblBenefs.Rows
                LvCsnExisBenefs.Items.Add(New ListViewItem({RowBen("ben_nom"), RowBen("ben_prenom"), If(IsDBNull(RowBen("ben_date_naiss")), "", RowBen("ben_date_naiss")), RowBen("ben_lien_parente"), RowBen("ben_adresse") & " " & If(IsDBNull(RowBen("locville_cp")), "", RowBen("locville_cp")) & " " & RowBen("locville_ville")}))
            Next
            ' liste défunts
            Dim TblOcc = GetOccupantsDeEmpl(RowCsn("empl_id"))
            For Each RowOcc In TblOcc.Rows
                LvCsnExistOccupants.Items.Add(New ListViewItem({RowOcc("def_nom"), RowOcc("def_prenom"), If(IsDBNull(RowOcc("def_date_naiss")), "", RowOcc("def_date_naiss")), If(IsDBNull(RowOcc("def_date_deces")), "", RowOcc("def_date_deces"))}))
            Next
            ' sélection plan
            If FormPlanCsnsExist IsNot Nothing AndAlso Not FormPlanCsnsExist.IsDisposed Then
                FormPlanCsnsExist.IdEmplSelect = RowCsn("empl_id")
            End If
        Else
            FormPlanCsnsExist.EmplSelect = Nothing
        End If
    End Sub



    ' gestion du form plan

    Private FormPlanCsnsExist As FormChoixEmplSurPlan
    Private Sub BtMontrerFormPlanCimCsnsExist_Click(sender As Object, e As EventArgs) Handles BtMontrerFormPlanCimCsnsExist.Click
        If Me.FormPlanCsnsExist Is Nothing OrElse Me.FormPlanCsnsExist.IsDisposed Then
            FormPlanCsnsExist = New FormChoixEmplSurPlan(Me.GetEmplacementsPourPlan(DgvCsnsExist.DataSource), AddressOf FiltrerPlanCsnsExist) With {.Owner = Me}
            FormPlanCsnsExist.Size = New Size(1000, 500)
            AddHandler FormPlanCsnsExist.SelectionChanged, AddressOf FormPlanCsnsExist_SelectionChanged
        Else
            Me.FormPlanCsnsExist.Show()
            Me.FormPlanCsnsExist.Focus()
        End If
        FormPlanCsnsExist.Show()
        Dim EmplSel = DgvCsnsExist.SelectedDataRow
        If EmplSel IsNot Nothing Then
            FormPlanCsnsExist.RefSelect = EmplSel("empl_reference")
        End If
    End Sub

    Private Sub FormPlanCsnsExist_SelectionChanged(empl As DataRow)
        Dim IdEmplPlanSelect = FormPlanCsnsExist.IdEmplSelect
        If IdEmplPlanSelect <> -1 Then
            Dim RowDansDgv = (From r As DataGridViewRow In DgvCsnsExist.Rows Where r.Cells("DgvCsnsExistColEmplId").Value = IdEmplPlanSelect).FirstOrDefault
            If RowDansDgv Is Nothing Then
                DgvCsnsExist.ClearSelection()
            Else
                RowDansDgv.Selected = True
                DgvCsnsExist.ScrollSelectedIntoView()
            End If
        End If
    End Sub


    ' filtrage/recherche

    Private Function FiltrerPlanCsnsExist(empl As DataRow) As Boolean
        Return CType(empl("actif"), Boolean)
    End Function

    Private Sub TbFiltre_TextChanged(sender As Object, e As EventArgs) Handles TbFiltreCsnsExist.TextChanged
        If TableConcessionsExistantes IsNot Nothing Then
            Dim Txt = TbFiltreCsnsExist.Text.Trim
            TableConcessionsExistantes.DefaultView.RowFilter = "empl_reference Like '%" & Txt & "%' Or csnr_nom Like '%" & Txt & "%' Or noms_benefs Like '%" & Txt & "%' Or noms_defunts Like '%" & Txt & "%'"
        End If
    End Sub

    Private Sub BtViderFiltre_Click(sender As Object, e As EventArgs) Handles BtViderFiltreCsnsExist.Click
        TbFiltreCsnsExist.Text = ""
    End Sub


    ' validation finale, génération pdf et enregistrement

    Private Sub BtTerminerConExis_Click(sender As Object, e As EventArgs) Handles BtTerminerConExis.Click

        If ValidePrFinCsnExis() Then

            Dim AnnulerEnregistrement = False

            ' nom fic pdf
            Dim NomficPdf As String
            If CbEnregPdfCsnExis.Checked Then
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

                If FormPlanCsnsExist IsNot Nothing Then
                    FormPlanCsnsExist.Close()
                End If

                ' enregistrement données

                ' réf de l'emplacement
                Dim CsnChoisie = CType(DgvCsnsExist.SelectedRow.DataBoundItem, DataRowView).Row
                Dim IdEmpl = CsnChoisie("empl_id")
                Dim Empl = Bdd.GetRow("emplacements", IdEmpl)
                Dim RefEmpl = Empl("empl_reference")

                Dim RowDef, RowDmdr, RowPcont As DataRow
                Dim osef As TTypeCsnInh
                Dim DateSign As Date?

                Enregistrer(RowDef, RowDmdr, RowPcont, osef, DateSign, IdEmpl)

                Dim DefuntsDeja = Bdd.Query("SELECT * FROM defunts WHERE empl_id = " & IdEmpl)

                ' export pdf

                Dim p As New ExporteurPdf

                p.NomFic = NomficPdf
                p.CreerPdfInhum(RowDef, RowDmdr, TTypeCsnInh.CsnExistante, GetTypeInhCsnExis, DateSign, RefEmpl, DefuntsDeja)

                Shell("explorer.exe """ & NomficPdf & """")      ' À faire : ne pas ouvrir si fichier non sauvegardé (car erreur par exemple)

                Me.DialogResult = DialogResult.OK

            End If

        End If


    End Sub


    ' divers

    Private Sub DgvCsnsExist_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvCsnsExist.CellFormatting
        Dim LaCol = DgvCsnsExist.Columns(e.ColumnIndex)
        If LaCol.Name = "DgvCsnsExistColOccupants" Then
            Dim RowCsn = CType(DgvCsnsExist.Rows(e.RowIndex).DataBoundItem, DataRowView).Row
            Dim Aff As String = RowCsn("empl_nb_defunts")
            If Not IsDBNull(RowCsn("empl_nb_places")) Then
                Aff &= "/" & RowCsn("empl_nb_places")
                If RowCsn("empl_nb_places") < RowCsn("empl_nb_defunts") Then e.CellStyle.BackColor = Color.Yellow
            End If
            e.Value = Aff
        End If
    End Sub


#End Region


#Region "Opération nouvelle concession"


    ' validation, réservation de la nouvelle concession (via un FormReservation), enregistrement et création pdf
    Private Sub BtSuivantNouvelleCon()
        ' validation
        If ValidePourBtSuivant() Then

            Me.Hide()

            Dim f As New FormReservation(FormReservation.TMode.Dependant)
            f.CbEnregPdfChecked = Me.CbEnregPdfP1.Checked
            f.ShowDialog()
            If f.DialogResult = DialogResult.OK Then
                ' à ce stade la concession a été enregistrée
                ' -> enregistrer et mettre le défunt dans l'emplacement
                Dim RowDef, RowDmdr, RowPcont As DataRow
                Dim TypeInh As TTypeCsnInh
                Dim DateSign As Date?
                Dim osef As TTypeCsnInh
                ' récupère les données des contrôles du tabpage 1 pour l'inhumation
                Enregistrer(RowDef, RowDmdr, RowPcont, osef, DateSign, f.RowCsn("empl_id")) ' virer typeinh
                TypeInh = f.TypeCsn

                ' pdf
                Dim RefEmpl = Bdd.GetRow("emplacements", f.RowCsn("empl_id"))("empl_reference")

                Dim p As New ExporteurPdf
                p.NomFic = f.NomficPdf

                p.CreerPdfInhum(RowDef, RowDmdr, TypeInh, , DateSign, RefEmpl, Nothing, f.RowCsnr, f.TblBenefs)

                Shell("explorer.exe """ & f.NomficPdf & """")      ' À faire : ne pas ouvrir si fichier non sauvegardé (car erreur par exemple)

                Me.DialogResult = DialogResult.OK

            Else
                Me.Show()
                CbEnregPdfP1.Checked = f.CbEnregPdf.Checked

            End If

        End If
    End Sub


    ' fait correspondre choix listbox -> code type concession en bdd
    Private Function GetTypeInhCsnExis()
        If LbTypeInhCsnExis.SelectedIndex < 0 Then Return TTypeInhCsnExistante.NonPrecise
        Return {TTypeInhCsnExistante.Urne, TTypeInhCsnExistante.Cercueil, TTypeInhCsnExistante.PleineTerre, TTypeInhCsnExistante.Caveau, TTypeInhCsnExistante.CelluleColombarium, TTypeInhCsnExistante.Cavurne} _
                  (LbTypeInhCsnExis.SelectedIndex)
    End Function


#End Region



#Region "Onglet choix empl pour inh ord"


    ' charge les emplacements libres (y compris déjà partiellement ou totalement occupés)
    Private Sub OngletInhSimpleSelectionne()
        CbEnregPdfInhOrd.Checked = CbEnregPdfP1.Checked

        If DgvEmplacementsPourInhOrd.DataSource Is Nothing Then
            DgvEmplacementsPourInhOrd.DataSource = GetListeEmplacementsNonLoues()
        End If
    End Sub


    Private Sub BtPrecedentDeInhOrd_Click(sender As Object, e As EventArgs) Handles BtPrecedentDeInhOrd.Click
        If FormPlanEmplsOrdinaires IsNot Nothing AndAlso Not FormPlanEmplsOrdinaires.IsDisposed Then
            FormPlanEmplsOrdinaires.Close()
        End If
        CbEnregPdfP1.Checked = CbEnregPdfInhOrd.Checked
        ChangerPage(TabPage1)
    End Sub




    Private Function GetListeEmplacementsNonLoues() As DataTable
        Static CacheEmplsNonLoues As DataTable

        If CacheEmplsNonLoues Is Nothing Then
            CacheEmplsNonLoues = Bdd.Query("SELECT emplacements.empl_id,empl_reference,empl_nb_places, empl_monum_classe, COUNT(def_id) AS empl_nb_defunts, GROUP_CONCAT(DISTINCT def_prenom,' ',def_nom ORDER BY def_date_deces ASC SEPARATOR '¤') AS noms_defunts" &
                                           " FROM emplacements" &
                                           " LEFT OUTER JOIN concessions ON concessions.empl_id=emplacements.empl_id" &
                                           " LEFT OUTER JOIN defunts ON defunts.empl_id = emplacements.empl_id" &
                                           " WHERE con_id IS NULL OR con_date_fin < CURDATE()" &
                                           " GROUP BY empl_id")
        End If
        Return CacheEmplsNonLoues
    End Function


    Private Sub DgvEmplacementsPourInhOrd_SelectionChanged(sender As Object, e As EventArgs) Handles DgvEmplacementsPourInhOrd.SelectionChanged
        LvOccupantsInhOrdEmpl.Items.Clear()
        If DgvEmplacementsPourInhOrd.SelectedRows.Count > 0 Then
            Dim RowEmpl = CType(DgvEmplacementsPourInhOrd.SelectedRow.DataBoundItem, DataRowView).Row
            Dim TblOcc = GetOccupantsDeEmpl(RowEmpl("empl_id"))
            For Each RowOcc In TblOcc.Rows
                LvOccupantsInhOrdEmpl.Items.Add(New ListViewItem({RowOcc("def_nom"), RowOcc("def_prenom"), If(IsDBNull(RowOcc("def_date_naiss")), "", RowOcc("def_date_naiss")), If(IsDBNull(RowOcc("def_date_deces")), "", RowOcc("def_date_deces"))}))
            Next
            If FormPlanEmplsOrdinaires IsNot Nothing AndAlso Not FormPlanEmplsOrdinaires.IsDisposed Then
                FormPlanEmplsOrdinaires.IdEmplSelect = RowEmpl("empl_id")
            End If
        Else
            FormPlanEmplsOrdinaires.EmplSelect = Nothing
        End If
    End Sub

    Private Sub TbFiltreEmpls_TextChanged(sender As Object, e As EventArgs) Handles TbFiltreEmpls.TextChanged
        If DgvEmplacementsPourInhOrd.DataSource IsNot Nothing Then
            Dim fltr = TbFiltreEmpls.Text.Trim
            CType(DgvEmplacementsPourInhOrd.DataSource, DataTable).DefaultView.RowFilter = "empl_reference Like '%" & fltr & "%' Or noms_defunts Like '%" & fltr & "%'"
        End If
    End Sub

    Private Sub BtViderFiltreEmpls_Click(sender As Object, e As EventArgs) Handles BtViderFiltreEmpls.Click
        TbFiltreEmpls.Text = ""
    End Sub


    ' Gestion du form plan

    Private FormPlanEmplsOrdinaires As FormChoixEmplSurPlan
    Private Sub BtMontrerFormPlancimEmplOrd_Click(sender As Object, e As EventArgs) Handles BtMontrerFormPlancimEmplOrd.Click
        If Me.FormPlanEmplsOrdinaires Is Nothing OrElse Me.FormPlanEmplsOrdinaires.IsDisposed Then
            FormPlanEmplsOrdinaires = New FormChoixEmplSurPlan(Me.GetEmplacementsPourPlan(DgvEmplacementsPourInhOrd.DataSource), AddressOf FiltrerPlanEmplsOrdinaires) With {.Owner = Me}
            FormPlanEmplsOrdinaires.Size = New Size(1000, 500)
            AddHandler FormPlanEmplsOrdinaires.SelectionChanged, AddressOf FormPlanEmplsOrdinaires_SelectionChanged
        Else
            Me.FormPlanEmplsOrdinaires.Show()
            Me.FormPlanEmplsOrdinaires.Focus()
        End If
        FormPlanEmplsOrdinaires.Show()
        Dim EmplSel = DgvEmplacementsPourInhOrd.SelectedDataRow
        If EmplSel IsNot Nothing Then
            FormPlanEmplsOrdinaires.RefSelect = EmplSel("empl_reference")
        End If
    End Sub

    Private Sub FormPlanEmplsOrdinaires_SelectionChanged(empl As DataRow)
        Dim IdEmplPlanSelect = FormPlanEmplsOrdinaires.IdEmplSelect
        If IdEmplPlanSelect <> -1 Then
            Dim RowDansDgv = (From r As DataGridViewRow In DgvEmplacementsPourInhOrd.Rows Where r.Cells("DgvEmplsOrdColEmplId").Value = IdEmplPlanSelect).FirstOrDefault
            If RowDansDgv Is Nothing Then
                DgvEmplacementsPourInhOrd.ClearSelection()
            Else
                RowDansDgv.Selected = True
                DgvEmplacementsPourInhOrd.ScrollSelectedIntoView()
            End If
        End If
    End Sub

    Private Function FiltrerPlanEmplsOrdinaires(empl As DataRow) As Boolean
        Return CType(empl("actif"), Boolean)
    End Function


    ' validation et enregistrement

    Private Sub BtTerminerInhOrd_Click(sender As Object, e As EventArgs) Handles BtTerminerInhOrd.Click
        If ValidePrFinInhOrd() Then
            Dim AnnulerEnregistrement = False
            ' nom fic pdf
            Dim NomficPdf As String
            If CbEnregPdfInhOrd.Checked Then
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
                NomficPdf = IO.Path.GetTempFileName & Guid.NewGuid().ToString() + ".pdf"
            End If


            If Not AnnulerEnregistrement Then

                If FormPlanEmplsOrdinaires IsNot Nothing AndAlso Not FormPlanEmplsOrdinaires.IsDisposed Then
                    FormPlanEmplsOrdinaires.Close()
                End If

                Dim RowDef, RowDmdr, RowPcont As DataRow
                Dim TypeInhOrd As TTypeCsnInh
                Dim DateSign As Date?
                Dim RowEmpl As DataRow
                If LbTypeInhOrd.SelectedIndex <> 4 Then     ' si dispersion, on le mettra dans un emplacement spécial ayant la référence AIR
                    RowEmpl = CType(DgvEmplacementsPourInhOrd.SelectedRow.DataBoundItem, DataRowView).Row
                    'Else
                    'RowEmpl = Bdd.GetRow("emplacements", "empl_reference", "AIR")
                End If
                Enregistrer(RowDef, RowDmdr, RowPcont, TypeInhOrd, DateSign, If(RowEmpl IsNot Nothing, RowEmpl("empl_id"), Nothing))

                ' pdf
                Dim p As New ExporteurPdf
                p.NomFic = NomficPdf
                p.CreerPdfInhum(RowDef, RowDmdr, TypeInhOrd, TTypeInhCsnExistante.NonPrecise, DateSign, If(RowEmpl IsNot Nothing, RowEmpl("empl_reference"), ""))

                Shell("explorer.exe """ & NomficPdf & """")      ' À faire : ne pas ouvrir si fichier non sauvegardé (car erreur par exemple)

                Me.DialogResult = DialogResult.OK
            End If
        End If
    End Sub

    Private Function ValidePrFinInhOrd()
        ValiderLvEmplsPrInhOrd()
        Return ErrorProvider1.GetError(DgvEmplacementsPourInhOrd) = ""
    End Function

    Private Sub ValiderLvEmplsPrInhOrd()
        If LbTypeInhOrd.SelectedIndex <> 4 AndAlso DgvEmplacementsPourInhOrd.SelectedRows.Count <= 0 Then       ' pas besoin d'emplacement en cas de dispersion
            ErrorProvider1.SetError(DgvEmplacementsPourInhOrd, "Veuillez indiquer un emplacement")
        Else
            ErrorProvider1.SetError(DgvEmplacementsPourInhOrd, "")
        End If
    End Sub


    ' Divers

    Private Sub DgvEmplacementsPourInhOrd_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvEmplacementsPourInhOrd.CellFormatting
        Dim LaCol = DgvEmplacementsPourInhOrd.Columns(e.ColumnIndex)
        If LaCol.Name = "DgvEmplsInhOrdOccupants" Then
            Dim RowEmpl = CType(DgvEmplacementsPourInhOrd.Rows(e.RowIndex).DataBoundItem, DataRowView).Row
            Dim Aff As String = RowEmpl("empl_nb_defunts")
            If Not IsDBNull(RowEmpl("empl_nb_places")) Then
                Aff &= "/" & RowEmpl("empl_nb_places")
                If RowEmpl("empl_nb_places") < RowEmpl("empl_nb_defunts") Then e.CellStyle.BackColor = Color.Yellow
            End If
            e.Value = Aff
        ElseIf LaCol.Name = "DgvEmplsInhOrdClasse" Then
            e.Value = If(Not IsDBNull(e.Value) AndAlso CType(e.Value, Boolean), "Oui", "")
        End If
    End Sub


#End Region


    ' code mis à part car appelé depuis plusieurs endroits
    ' les byref sont des sorties, elles permettent à l'appelant de récupérer les rows générée à partir des données du formulaire pour le pdf etc
    Sub Enregistrer(ByRef RowDef As DataRow, ByRef RowDmdr As DataRow, ByRef RowPcont As DataRow, ByRef TypeInhOrd As TTypeCsnInh, ByRef DateSign As Date?, IdEmpl As Integer?)
        ' personne de contact

        RowPcont = Bdd.GetRowVide("personnes_contact")
        RowPcont("pc_nom") = TbPcontNom.Text.Trim
        RowPcont("pc_prenom") = TbPcontPrenom.Text.Trim
        RowPcont("pc_adresse") = TbPcontAdresse.Text.Trim
        RowPcont("locville_id") = If(CtrlLocPcont.LocVilleId = -1, DBNull.Value, CtrlLocPcont.LocVilleId)
        RowPcont("pc_tel") = TbPcontTel.Text.Trim
        If CbPCont.Checked Then
            RowPcont("pc_id") = Bdd.Insert("personnes_contact", RowPcont)
        End If

        ' défunt

        RowDef = Bdd.GetRowVide("defunts")
        ' numéro LH
        If TbDefNumLh.Value IsNot Nothing Then
            RowDef("def_numero_lh") = TbDefNumLh.Value
        Else
            ' génère un numéro - celui suivant le plus élevé trouvé en bdd
            Dim NumMaxBdd = Bdd.Query("SELECT MAX(def_numero_lh) from defunts").Rows(0)(0)
            RowDef("def_numero_lh") = If(Not IsDBNull(NumMaxBdd), NumMaxBdd + 1, 1)
        End If
        ' numéro année ----- à faire
        RowDef("def_nom") = TbDefNom.Text.Trim
        RowDef("def_prenom") = TbDefPrenom.Text.Trim
        RowDef("def_adresse") = TbDefAdresse.Text.Trim
        If CtrlDefLocvillepays.LocVilleId > 0 Then
            RowDef("locville_id") = CtrlDefLocvillepays.LocVilleId
        Else
            RowDef("locville_id") = DBNull.Value
        End If
        RowDef("def_date_naiss") = If(TbDefDateNaiss.DateValue, DBNull.Value)
        RowDef("def_lieu_naiss") = TbDefLieuNaiss.Text.Trim
        RowDef("def_date_deces") = If(TbDefDateDeces.DateValue, DBNull.Value)
        RowDef("def_lieu_deces") = TbDefLieuDeces.Text.Trim
        RowDef("def_etat_civil") = CtrlDefEtatCiv.EtatCivil
        RowDef("def_etat_civil_de") = CtrlDefEtatCiv.EtatCivilDe

        ' emplacement qui vient d'être alloué
        RowDef("empl_id") = If(IdEmpl IsNot Nothing, IdEmpl, DBNull.Value)

        If CbPCont.Checked Then
            RowDef("pc_id") = RowPcont("pc_id")
        End If

        Bdd.Insert("defunts", RowDef)


        ' quelques valeurs supplémentaires pour l'appelant

        RowDmdr = Bdd.GetRowDmdrVide
        RowDmdr("dmdr_nomcomplet") = TbDmdrPrenom.Text.Trim & " " & TbDmdrNom.Text.ToUpper
        RowDmdr("dmdr_tel") = TbDmdrTel.Text.Trim
        RowDmdr("dmdr_adresse") = TbDmdrAdresse.Text.Trim
        If CtrlVilleDmdr.LocVilleId > 0 Then
            Dim VilleDmdr = Bdd.GetRow("t_loc_ville", CtrlVilleDmdr.LocVilleId)
            RowDmdr("dmdr_nomville") = VilleDmdr("locville_ville")
            RowDmdr("dmdr_cp") = VilleDmdr("locville_cp")
            If Not IsDBNull(VilleDmdr("Pays_id")) AndAlso VilleDmdr("Pays_id") > 0 Then
                Dim PDmdr = Bdd.GetRow("t_pays", VilleDmdr("Pays_id"))
                RowDmdr("dmdr_nompays") = PDmdr("Pays_nom")
            Else
                RowDmdr("dmdr_nompays") = ""
            End If
        Else
            RowDmdr("dmdr_nomville") = ""
            RowDmdr("dmdr_nompays") = ""
        End If

        If Not LbTypeInhOrd.SelectedIndex >= 0 Then
            TypeInhOrd = TTypeCsnInh.NonPrecise
        Else
            TypeInhOrd = {TTypeCsnInh.OrdinaireCercueil,
                        TTypeCsnInh.OrdinaireUrne,
                        TTypeCsnInh.OuvertureCaveau,
                        TTypeCsnInh.UrneColombOrdinaire,
                        TTypeCsnInh.DispersionCendres} _
                      (LbTypeInhOrd.SelectedIndex)
        End If

        DateSign = If(DtpDateSign.Checked, DtpDateSign.Value, Nothing)

    End Sub



    Private Function GetBenefsDeCsn(Id As Integer) As DataTable
        If CacheBenefsCsnExist.ContainsKey(Id) Then
            Return CacheBenefsCsnExist(Id)
        Else
            Dim res = Bdd.Query("SELECT * FROM beneficiaires INNER JOIN beneficier ON beneficier.ben_id = beneficiaires.ben_id" &
                                " LEFT OUTER JOIN t_loc_ville ON t_loc_ville.locville_id = beneficiaires.locville_id" &
                                " WHERE beneficier.con_id = " & Id)
            ' met déjà des strings vides où il y a des dbnull (de type attendu string)
            For Each r As DataRow In res.Rows
                For i = 0 To res.Columns.Count - 1
                    If res.Columns(i).DataType = GetType(String) AndAlso IsDBNull(r(i)) Then r(i) = ""
                Next
            Next
            CacheBenefsCsnExist.Add(Id, res)
            Return res
        End If
    End Function
    Private CacheBenefsCsnExist As New Dictionary(Of Integer, DataTable)


    Private Function GetOccupantsDeEmpl(Id As Integer) As DataTable
        If CacheOccupantsEmpl.ContainsKey(Id) Then
            Return CacheOccupantsEmpl(Id)
        Else
            Dim res = Bdd.Query("SELECT * FROM defunts WHERE empl_id = " & Id)
            For Each r As DataRow In res.Rows
                For i = 0 To res.Columns.Count - 1
                    If res.Columns(i).DataType = GetType(String) AndAlso IsDBNull(r(i)) Then r(i) = ""
                Next
            Next
            CacheOccupantsEmpl.Add(Id, res)
            Return res
        End If
    End Function
    Private CacheOccupantsEmpl As New Dictionary(Of Integer, DataTable)

    ' inclut une colonne pour indiquer ceux qui sont loués ou pas
    ' sur base du fait qu'ils sont repris ou non dans l'argument TableAutorises
    ' performances à voir quand il y aura 3000 emplacements
    Private Function GetEmplacementsPourPlan(TableAutorises As DataTable) As DataTable
        If CacheEmplsPourPlan Is Nothing Then
            CacheEmplsPourPlan = Bdd.Query("SELECT emplacements.*,0 AS actif FROM emplacements LEFT OUTER JOIN concessions ON concessions.empl_id = emplacements.empl_id")
        End If
        For Each r As DataRow In CacheEmplsPourPlan.Rows
            r("actif") = (From RowAutorisee As DataRow In TableAutorises.Rows Where RowAutorisee("empl_id") = r("empl_id")).Any
        Next
        Return CacheEmplsPourPlan
    End Function
    Private CacheEmplsPourPlan As DataTable



    ' Divers

    Private Sub Me_Close() Handles Me.Closed
        If FormPlanCsnsExist IsNot Nothing AndAlso FormPlanCsnsExist.IsDisposed Then
            FormPlanCsnsExist.Close()
            FormPlanCsnsExist.Dispose()
        End If
        If FormPlanEmplsOrdinaires IsNot Nothing AndAlso Not FormPlanEmplsOrdinaires.IsDisposed Then
            FormPlanEmplsOrdinaires.Close()
            FormPlanCsnsExist.Dispose()
        End If

    End Sub


    ' les contrôles sont rendus en cache avant d'être affiché, ça peut éviter quelques scintillements mais en contrepartie ça retarde leur affichage
    ' selon les form, ça rend plus ou moins bien ; ici, ça va
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000    ' WS_EX_COMPOSITED
            Return cp
        End Get
    End Property

    Private Sub CbPCont_CheckedChanged(sender As Object, e As EventArgs) Handles CbPCont.CheckedChanged
        For Each c As Control In {TbPcontAdresse, TbPcontNom, TbPcontPrenom, TbPcontTel, CtrlLocPcont}
            c.Enabled = CbPCont.Checked
        Next
    End Sub

End Class