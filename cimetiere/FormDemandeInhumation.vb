Public Class FormDemandeInhumation

    Public Sub New()
        InitializeComponent()
        DgvCsnsExist.AutoGenerateColumns = False
        DgvEmplacementsPourInhOrd.AutoGenerateColumns = False
    End Sub

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
                'ChangerPage(TabP2NvCon)
                'Dim f As New FormReservation
                'f.ShowDialog()
                BtSuivantNouvelleCon()
                                '' a 
                'OngletNvConSelectionne()
            Case RbConcExis.Checked
                If ValidePourBtSuivant() Then
                    ChangerPage(TabP2ConExis)
                    OngletCsnsExistantesSelectionne()
                End If

        End Select
    End Sub

    Private Sub BtPrécédentDeConExis_Click(sender As Object, e As EventArgs) Handles BtPrécédentDeConExis.Click
        CbEnregPdfP1.Checked = CbEnregPdfCsnExis.Checked
        ChangerPage(TabPage1)
    End Sub

    Private Sub BtPrecedentDeInhOrd_Click(sender As Object, e As EventArgs) Handles BtPrecedentDeInhOrd.Click
        CbEnregPdfP1.Checked = CbEnregPdfInhOrd.Checked
        ChangerPage(TabPage1)
    End Sub

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

        Return ErrorProvider1.GetError(RbNouvelleCon) = "" _
            AndAlso ErrorProvider1.GetError(TbDefNumLh) = "" _
            AndAlso ErrorProvider1.GetError(TbDefNom) = "" _
            AndAlso ErrorProvider1.GetError(TbDefPrenom) = "" _
            AndAlso ErrorProvider1.GetError(TbDefDateNaiss) = "" _
            AndAlso ErrorProvider1.GetError(TbDefDateDeces) = "" _
            AndAlso ErrorProvider1.GetError(LbTypeInhOrd) = "" _
            AndAlso ErrorProvider1.GetError(TbDmdrNom) = "" _
            AndAlso ErrorProvider1.GetError(TbDmdrPrenom) = "" _


        ' valid code défunt : ne doit pas déjà exister
        ' si non précisé, on le génèrera automatiquement
        ' la ville devrait être correcte ; si elle ne l'est pas, on la corrigera/supprimera sans avertissement 
        ' pareil état civil
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

    Private Sub OngletCsnsExistantesSelectionne()
        CbEnregPdfCsnExis.Checked = CbEnregPdfP1.Checked
        If DgvCsnsExist.DataSource Is Nothing Then
            DgvCsnsExist.DataSource = GetListeConcessionsExistantes()
        End If
    End Sub

    Private TableConcessionsExistantes As DataTable
    Private Function GetListeConcessionsExistantes()
        If TableConcessionsExistantes Is Nothing Then
            TableConcessionsExistantes = Bdd.Query("SELECT con_id,emplacements.empl_id,empl_reference,con_date_debut,con_date_fin,CONCAT(UPPER(concessionnaires.csnr_nom),"" "",concessionnaires.csnr_prenom) AS csnr_nom,empl_nb_places,COUNT(defunts.def_id) AS empl_nb_defunts" &
                                                   " FROM concessions" &
                                                   " INNER JOIN emplacements ON concessions.empl_id = emplacements.empl_id" &
                                                   " INNER JOIN concessionnaires ON concessions.csnr_id = concessionnaires.csnr_id" &
                                                   " LEFT OUTER JOIN defunts ON defunts.empl_id = emplacements.empl_id" &
                                                   " WHERE concessions.con_date_fin > NOW()" &
                                                   " GROUP BY con_id")
        End If
        Return TableConcessionsExistantes
    End Function

    Private Function GetBenefsDeCsn(Id As Integer) As DataTable
        If CacheBenefsCsnExist.ContainsKey(Id) Then
            Return CacheBenefsCsnExist(Id)
        Else
            Dim res = Bdd.Query("SELECT * FROM beneficiaires INNER JOIN beneficier ON beneficier.ben_id = beneficiaires.ben_id" &
                                " INNER JOIN t_loc_ville ON t_loc_ville.locville_id = beneficiaires.locville_id" &
                                " WHERE beneficier.con_id = " & Id)
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
            CacheOccupantsEmpl.Add(Id, res)
            Return res
        End If
    End Function

    Private CacheOccupantsEmpl As New Dictionary(Of Integer, DataTable)

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



    Private Sub DgvCsnsExist_SelectionChanged(sender As Object, e As EventArgs) Handles DgvCsnsExist.SelectionChanged
        LvCsnExisBenefs.Items.Clear()
        LvCsnExistOccupants.Items.Clear()
        ' liste occupants
        If DgvCsnsExist.SelectedRows.Count > 0 Then
            Dim RowCsn = CType(DgvCsnsExist.SelectedRow.DataBoundItem, DataRowView).Row
            Dim TblBenefs = GetBenefsDeCsn(RowCsn("con_id"))
            For Each RowBen In TblBenefs.Rows
                LvCsnExisBenefs.Items.Add(New ListViewItem({RowBen("ben_nom"), RowBen("ben_prenom"), RowBen("ben_date_naiss"), RowBen("ben_lien_parente"), RowBen("ben_adresse") & " " & RowBen("locville_cp") & " " & RowBen("locville_ville")}))
            Next
            Dim TblOcc = GetOccupantsDeEmpl(RowCsn("empl_id"))
            For Each RowOcc In TblOcc.Rows
                LvCsnExistOccupants.Items.Add(New ListViewItem({RowOcc("def_nom"), RowOcc("def_prenom"), If(IsDBNull(RowOcc("def_date_naiss")), "", RowOcc("def_date_naiss")), If(IsDBNull(RowOcc("def_date_deces")), "", RowOcc("def_date_deces"))}))
            Next
        Else
            ' rien de spécial, les listes ont déjà été vidées
        End If
    End Sub

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

                ' enregistrement données

                ' réf de l'emplacement
                Dim CsnChoisie = CType(DgvCsnsExist.SelectedRow.DataBoundItem, DataRowView).Row
                Dim IdEmpl = CsnChoisie("empl_id")
                Dim Empl = Bdd.GetRow("emplacements", IdEmpl)
                Dim RefEmpl = Empl("empl_reference")

                Dim RowDef, RowDmdr As DataRow
                Dim osef As TTypeCsnInh
                Dim DateSign As Date?

                Enregistrer(RowDef, RowDmdr, osef, DateSign, IdEmpl)

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



#End Region


#Region "Opération nouvelle concession"

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
                Dim RowDef As DataRow
                Dim RowDmdr As DataRow
                Dim TypeInh As TTypeCsnInh
                Dim DateSign As Date?
                Dim osef As TTypeCsnInh
                Enregistrer(RowDef, RowDmdr, osef, DateSign, f.RowCsn("empl_id")) ' virer typeinh
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


#End Region



#Region "Onglet choix empl pour inh ord"

    Private Sub OngletInhSimpleSelectionne()
        CbEnregPdfInhOrd.Checked = CbEnregPdfP1.Checked

        If DgvEmplacementsPourInhOrd.DataSource Is Nothing Then
            DgvEmplacementsPourInhOrd.DataSource = GetListeEmplacementsNonLoues()

            ' peut-être mettre plancim

        End If
    End Sub


    Private Function GetListeEmplacementsNonLoues() As DataTable
        Static CacheEmplsNonLoues As DataTable

        If CacheEmplsNonLoues Is Nothing Then
            CacheEmplsNonLoues = Bdd.Query("SELECT emplacements.empl_id,empl_reference,empl_nb_places, empl_monum_classe, COUNT(def_id) AS empl_nb_defunts" &
                                           " FROM emplacements" &
                                           " LEFT OUTER JOIN concessions ON concessions.empl_id=emplacements.empl_id" &
                                           " LEFT OUTER JOIN defunts ON defunts.empl_id = emplacements.empl_id" &
                                           " WHERE con_id IS NULL" &
                                           " GROUP BY empl_id")
        End If
        Return CacheEmplsNonLoues
    End Function

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


    Private Sub DgvEmplacementsPourInhOrd_SelectionChanged(sender As Object, e As EventArgs) Handles DgvEmplacementsPourInhOrd.SelectionChanged
        LvOccupantsInhOrdEmpl.Items.Clear()
        If DgvEmplacementsPourInhOrd.SelectedRows.Count > 0 Then
            Dim RowEmpl = CType(DgvEmplacementsPourInhOrd.SelectedRow.DataBoundItem, DataRowView).Row
            Dim TblOcc = GetOccupantsDeEmpl(RowEmpl("empl_id"))
            For Each RowOcc In TblOcc.Rows
                LvOccupantsInhOrdEmpl.Items.Add(New ListViewItem({RowOcc("def_nom"), RowOcc("def_prenom"), If(IsDBNull(RowOcc("def_date_naiss")), "", RowOcc("def_date_naiss")), If(IsDBNull(RowOcc("def_date_deces")), "", RowOcc("def_date_deces"))}))
            Next
        End If
    End Sub


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
                Dim RowDef, RowDmdr As DataRow
                Dim TypeInhOrd As TTypeCsnInh
                Dim DateSign As Date?
                Dim RowEmpl As DataRow
                If LbTypeInhOrd.SelectedIndex <> 4 Then     ' si dispersion, on le mettra dans un emplacement spécial ayant la référence AIR
                    RowEmpl = CType(DgvEmplacementsPourInhOrd.SelectedRow.DataBoundItem, DataRowView).Row
                Else
                    RowEmpl = Bdd.GetRow("emplacements", "empl_reference", "AIR")
                End If
                Enregistrer(RowDef, RowDmdr, TypeInhOrd, DateSign, RowEmpl("empl_id"))

                ' pdf
                Dim p As New ExporteurPdf
                p.NomFic = NomficPdf
                p.CreerPdfInhum(RowDef, RowDmdr, TypeInhOrd, TTypeInhCsnExistante.NonPrecise, DateSign, RowEmpl("empl_reference"))

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




#End Region


    ' code mis à part car appelé depuis plusieurs endroits
    ' les byref sont des sorties, elles permettent à l'appelant de récupérer les rows générée à partir des données du formulaire
    Sub Enregistrer(ByRef RowDef As DataRow, ByRef RowDmdr As DataRow, ByRef TypeInhOrd As TTypeCsnInh, ByRef DateSign As Date?, IdEmpl As Integer)
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
        RowDef("empl_id") = IdEmpl

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


    ' possibilités :

    ' - choix d'une concession existante
    ' - réservation d'une concession
    ' - emplacement simple

    ' pcontact ?


    ' 1) infos du défunts
    '    choix si concession
    ' 1b) type emplacement simple si applicable
    '   - pleine terre cercueil/urne
    '   - urne en colomb
    '   - dispersion
    ' 2a) choix csn existante
    ' 2b) réservation
    ' x) personne de contact

    Private Function GetTypeInhCsnExis()
        If LbTypeInhCsnExis.SelectedIndex < -1 Then Return TTypeInhCsnExistante.NonPrecise
        Return {TTypeInhCsnExistante.Urne, TTypeInhCsnExistante.Cercueil, TTypeInhCsnExistante.PleineTerre, TTypeInhCsnExistante.Caveau, TTypeInhCsnExistante.CelluleColombarium, TTypeInhCsnExistante.Cavurne} _
                  (LbTypeInhCsnExis.SelectedIndex)
    End Function

End Class