Imports System.IO
Public Class FormGestion
    Public dtdefunt As DataTable
    Public dtcons As DataTable
    Public dtCsnr As DataTable
    Public dtbenef As DataTable
    Public dtPersContact As DataTable
    Public dtville As DataTable
    Public dtpays As DataTable

    Public dvlistedefunts As DataView
    Public dvlisteempl As DataView
    Public dvCsnrs As DataView
    Public dvbenefs As DataView
    Public dvPersContact As DataView


    Public dvbenefsdeconcession As DataView
    Public dvdefuntcons As DataView


    Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
    Dim boutongestion = 0


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        If user = "User" Then

            FPBModifier.Hide()
            FPBSupprimer.Hide()
            BModifGestionPers.Hide()
            BmodifConsBenef.Hide()
            BmodifCons.Hide()
            BSupGestionPers.Hide()
            BSupGestionPersBenef.Hide()
            BSuppConsBenef.Hide()
            BSuppCons.Hide()
            BAddConsBenef.Hide()
            BModifGestionPersBenef.Hide()
        End If

        TextBoxDefuntRO()
        TextBoxConsRO()
        TextBoxPersRO()
        Panel10.Hide()
        Panel3.Hide()
        Panel1.Hide()
        TabControl1.Hide()
        Me.Size = New Size(820, 150)
        Me.Left = (screenWidth - Me.Width) / 2
        Me.Top = (screenHeight - Me.Height) / 2
        Lchargementdonnee.Text = "Chargement des données"
    End Sub

    Private Sub Form1_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        ProgressBar.Increment(10)
        DataTableDefunt() '1
        ProgressBar.Increment(25)
        Lchargementdonnee.Text = "Chargement des données ."
        'Threading.Thread.Sleep(500)
        DataTableConcess() '2
        ProgressBar.Increment(40)
        Lchargementdonnee.Text = "Chargement des données . ."
        'Threading.Thread.Sleep(500)
        DataTableConcession() '2
        ProgressBar.Increment(55)
        Lchargementdonnee.Text = "Chargement des données . . ."
        'Threading.Thread.Sleep(500)
        DataTablePersContact()
        ProgressBar.Increment(70)
        'Threading.Thread.Sleep(500)
        DataTableBeneficiaire()
        dtville = GetTable("t_loc_ville")
        dtpays = GetTable("t_pays")
        ProgressBar.Increment(85)
        'Threading.Thread.Sleep(500)
        DgvListeConcessionnaireBenef.Show()
        DgvListeConcessionnairePersonneContact.Hide()
        DgvListeConcessionnaireConcess.Hide()
        ProgressBar.Increment(100)
        'Threading.Thread.Sleep(500)
        ProgressBar.Hide()
        Me.Size = New Size(1252, 705)
        Me.Left = (screenWidth - Me.Width) / 2
        Me.Top = (screenHeight - Me.Height) / 2
        Panel10.Show()
        Panel3.Show()
        Panel1.Show()
        Lchargementdonnee.Hide()
        TabControl1.Show()

    End Sub


    Sub DataTableDefunt() '1

        dtdefunt = Bdd.Query("SELECT * FROM defunts LEFT OUTER JOIN t_loc_ville ON defunts.locville_id = t_loc_ville.locville_id LEFT OUTER JOIN t_pays on t_loc_ville.locville_id = t_pays.Pays_id LEFT OUTER JOIN emplacements on defunts.empl_id = emplacements.empl_id")

        ' liste principale des défunts

        dvlistedefunts = New DataView(dtdefunt)

        Dim DTGV_Id_Colonne = New DataGridViewTextBoxColumn()
        Dim ColonnePrenom = New DataGridViewTextBoxColumn()
        Dim colonneid = New DataGridViewTextBoxColumn()
        Dim colonnepc = New DataGridViewTextBoxColumn()
        Dim colonneref = New DataGridViewTextBoxColumn()
        Dim colonnedatedec = New DataGridViewTextBoxColumn()
        DTGV_Id_Colonne.DataPropertyName = "def_nom"
        DTGV_Id_Colonne.HeaderText = "nom"
        DTGV_Id_Colonne.Name = "def_nom"
        DgvListeDefunts.Columns.Add(DTGV_Id_Colonne)
        ColonnePrenom.DataPropertyName = "def_prenom"
        ColonnePrenom.HeaderText = "prenom"
        ColonnePrenom.Name = "def_prenom"
        DgvListeDefunts.Columns.Add(ColonnePrenom)
        colonneid.DataPropertyName = "def_id"
        colonneid.HeaderText = "id"
        colonneid.Name = "def_id"
        DgvListeDefunts.Columns.Add(colonneid)
        DgvListeDefunts.Columns("def_id").Visible = False
        colonnepc.DataPropertyName = "pc_id"
        colonnepc.HeaderText = "id"
        colonnepc.Name = "pc_id"
        DgvListeDefunts.Columns.Add(colonnepc)
        DgvListeDefunts.Columns("pc_id").Visible = False
        colonneref.DataPropertyName = "empl_reference"
        colonneref.HeaderText = "empl"
        colonneref.Name = "empl_reference"
        DgvListeDefunts.Columns.Add(colonneref)
        DgvListeDefunts.Columns("empl_reference").Visible = False
        colonnedatedec.DataPropertyName = "def_date_deces"
        colonnedatedec.HeaderText = "empl"
        colonnedatedec.Name = "def_date_deces"
        DgvListeDefunts.Columns.Add(colonnedatedec)
        DgvListeDefunts.Columns("def_date_deces").Visible = False
        DgvListeDefunts.AutoGenerateColumns = False
        DgvListeDefunts.DataSource = dvlistedefunts   ''''''dtdefunt
        DgvListeDefunts.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvListeDefunts.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        ' liste des défunts de l'emplacement sélectionné

        dvdefuntcons = New DataView(dtdefunt)

        Dim DTGV_Id_Colonne_def = New DataGridViewTextBoxColumn()
        Dim Colonne = New DataGridViewTextBoxColumn()
        colonneid = New DataGridViewTextBoxColumn()
        DTGV_Id_Colonne_def.DataPropertyName = "def_nom"
        DTGV_Id_Colonne_def.HeaderText = "nom"
        DTGV_Id_Colonne_def.Name = "def_nom"
        FCDGDefunt.Columns.Add(DTGV_Id_Colonne_def)
        Colonne.DataPropertyName = "def_prenom"
        Colonne.HeaderText = "prenom"
        Colonne.Name = "def_prenom"
        FCDGDefunt.Columns.Add(Colonne)
        colonneid.DataPropertyName = "def_id"
        colonneid.HeaderText = "id"
        colonneid.Name = "def_id"
        FCDGDefunt.Columns.Add(colonneid)
        FCDGDefunt.AutoGenerateColumns = False
        FCDGDefunt.DataSource = dvdefuntcons
        FCDGDefunt.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        FCDGDefunt.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        ' infos du défunt sélectionné
        DataBindDefunt()

    End Sub


    Sub DataTableConcess() '2
        dtCsnr = Bdd.Query("select * FROM concessionnaires LEFT OUTER JOIN t_loc_ville ON concessionnaires.locville_id = t_loc_ville.locville_id LEFT OUTER JOIN t_pays ON t_loc_ville.Pays_id = t_pays.Pays_id")

        ' datagridview des concessionnaires

        dvCsnrs = New DataView(dtCsnr)

        Dim DTGV_Id_Colonne = New DataGridViewTextBoxColumn()
        Dim ColonnePrenom = New DataGridViewTextBoxColumn()
        DTGV_Id_Colonne.DataPropertyName = "csnr_nom"
        DTGV_Id_Colonne.HeaderText = "nom"
        DTGV_Id_Colonne.Name = "csnr_nom"
        DgvListeConcessionnaireConcess.Columns.Add(DTGV_Id_Colonne)
        ColonnePrenom.DataPropertyName = "csnr_prenom"
        ColonnePrenom.HeaderText = "prenom"
        ColonnePrenom.Name = "csnr_prenom"
        DgvListeConcessionnaireConcess.Columns.Add(ColonnePrenom)
        DgvListeConcessionnaireConcess.AutoGenerateColumns = False
        DgvListeConcessionnaireConcess.DataSource = dvCsnrs
        DgvListeConcessionnaireConcess.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvListeConcessionnaireConcess.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

    End Sub


    Sub DataTableConcession() '2
        dtcons = Bdd.Query("SELECT * FROM emplacements LEFT OUTER JOIN concessions ON concessions.empl_id = emplacements.empl_id LEFT OUTER JOIN t_histoire ON concessions.h_id = t_histoire.h_id LEFT OUTER JOIN t_commentaire ON concessions.com_id = t_commentaire.com_id")

        ' datagridview des emplacements

        dvlisteempl = New DataView(dtcons)


        Dim DTGV_Id_Colonne = New DataGridViewTextBoxColumn()
        Dim ColonnePrenom = New DataGridViewTextBoxColumn()
        Dim colonneid = New DataGridViewTextBoxColumn()
        Dim colonnecsnr = New DataGridViewTextBoxColumn()
        Dim colonnedatefin = New DataGridViewTextBoxColumn()
        Dim colonneemplid = New DataGridViewTextBoxColumn()
        DTGV_Id_Colonne.DataPropertyName = "con_numero"
        DTGV_Id_Colonne.HeaderText = "numero"
        DTGV_Id_Colonne.Name = "con_numero"
        FCDGConss.Columns.Add(DTGV_Id_Colonne)
        ColonnePrenom.DataPropertyName = "empl_reference"
        ColonnePrenom.HeaderText = "emplacement"
        ColonnePrenom.Name = "empl_reference"
        FCDGConss.Columns.Add(ColonnePrenom)
        colonneid.DataPropertyName = "con_id"
        colonneid.HeaderText = "id"
        colonneid.Name = "con_id"
        FCDGConss.Columns.Add(colonneid)
        FCDGConss.Columns("con_id").Visible = False
        colonnecsnr.DataPropertyName = "csnr_id"
        colonnecsnr.HeaderText = "id"
        colonnecsnr.Name = "csnr_id"
        FCDGConss.Columns.Add(colonnecsnr)
        FCDGConss.Columns("csnr_id").Visible = False
        colonnedatefin.DataPropertyName = "con_date_fin"
        colonnedatefin.HeaderText = "con_date_fin"
        colonnedatefin.Name = "con_date_fin"
        FCDGConss.Columns.Add(colonnedatefin)
        FCDGConss.Columns("con_date_fin").Visible = False

        colonneemplid.DataPropertyName = "empl_id"
        colonneemplid.HeaderText = "empl_id"
        colonneemplid.Name = "empl_id"
        FCDGConss.Columns.Add(colonneemplid)
        FCDGConss.Columns("empl_id").Visible = False

        FCDGConss.AutoGenerateColumns = False
        FCDGConss.DataSource = dvlisteempl
        FCDGConss.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        FCDGConss.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        ' infos de l'emplacement affiché
        DataBindConsInfos()
    End Sub


    'Sub DataTableDefuntCons(ByRef Optional empl As Integer = 0)
    '    If empl = 0 Then

    '    Else
    '        FCDGConss.CurrentRow.Cells("empl_id").Value = empl
    '    End If

    '    'dtdefuntcons = Bdd.Query("SELECT * FROM defunts WHERE empl_id = " & FCDGConss.CurrentRow.Cells("empl_id").Value & "")

    '    ' A FAIRE si pas de sélection
    '    'dvdefuntcons = New
    '    'dtdefunt.Select("empl_id = " & CType(FCDGConss.SelectedRows(0).DataBoundItem, DataRowView).Row("empl_id"))

    'End Sub
    Sub DataTableBeneficiaire()
        ' intègre déjà l'id de la concession (ben_con_id) pour usage futur
        dtbenef = Query("SELECT *, beneficier.con_id AS ben_con_id FROM beneficiaires LEFT OUTER JOIN t_loc_ville ON beneficiaires.locville_id = t_loc_ville.locville_id LEFT OUTER JOIN t_pays ON t_loc_ville.Pays_id = t_pays.Pays_id INNER JOIN beneficier ON beneficier.ben_id = beneficiaires.ben_id")

        'datagridview tous bénéficiaires

        dvbenefs = New DataView(dtbenef)
        Dim DTGV_Id_Colonne = New DataGridViewTextBoxColumn()
        Dim ColonnePrenom = New DataGridViewTextBoxColumn()
        DTGV_Id_Colonne.DataPropertyName = "ben_nom"
        DTGV_Id_Colonne.HeaderText = "nom"
        DTGV_Id_Colonne.Name = "ben_nom"
        DgvListeConcessionnaireBenef.Columns.Add(DTGV_Id_Colonne)
        ColonnePrenom.DataPropertyName = "ben_prenom"
        ColonnePrenom.HeaderText = "prenom"
        ColonnePrenom.Name = "ben_prenom"
        DgvListeConcessionnaireBenef.Columns.Add(ColonnePrenom)
        DgvListeConcessionnaireBenef.AutoGenerateColumns = False
        DgvListeConcessionnaireBenef.DataSource = dvbenefs
        DgvListeConcessionnaireBenef.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvListeConcessionnaireBenef.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        ' datagridview des bénéficiaires de la concession sélectionnée

        dvbenefsdeconcession = New DataView(dtbenef)

        DTGV_Id_Colonne = New DataGridViewTextBoxColumn()
        ColonnePrenom = New DataGridViewTextBoxColumn()
        DTGV_Id_Colonne.DataPropertyName = "ben_nom"
        DTGV_Id_Colonne.HeaderText = "nom"
        DTGV_Id_Colonne.Name = "ben_nom"
        FCDGBeneficiaire.Columns.Add(DTGV_Id_Colonne)
        ColonnePrenom.DataPropertyName = "ben_prenom"
        ColonnePrenom.HeaderText = "prenom"
        ColonnePrenom.Name = "ben_prenom"
        FCDGBeneficiaire.Columns.Add(ColonnePrenom)
        FCDGBeneficiaire.AutoGenerateColumns = False
        FCDGBeneficiaire.DataSource = dvbenefsdeconcession
        FCDGBeneficiaire.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        FCDGBeneficiaire.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill


        ' infos du bénéficiaire sélectionné (onglet concessions)
        DataBindConsbenef()


    End Sub

    Sub DataTablePersContact()
        dtPersContact = Query("SELECT * FROM personnes_contact LEFT OUTER JOIN t_loc_ville ON personnes_contact.locville_id = t_loc_ville.locville_id LEFT OUTER JOIN t_pays ON t_loc_ville.Pays_id = t_pays.Pays_id")

        dvPersContact = New DataView(dtPersContact)

        Dim DTGV_Id_Colonne = New DataGridViewTextBoxColumn()
        Dim ColonnePrenom = New DataGridViewTextBoxColumn()
        DTGV_Id_Colonne.DataPropertyName = "pc_nom"
        DTGV_Id_Colonne.HeaderText = "nom"
        DTGV_Id_Colonne.Name = "pc_nom"
        DgvListeConcessionnairePersonneContact.Columns.Add(DTGV_Id_Colonne)
        ColonnePrenom.DataPropertyName = "pc_prenom"
        ColonnePrenom.HeaderText = "prenom"
        ColonnePrenom.Name = "pc_prenom"
        DgvListeConcessionnairePersonneContact.Columns.Add(ColonnePrenom)
        DgvListeConcessionnairePersonneContact.AutoGenerateColumns = False
        DgvListeConcessionnairePersonneContact.DataSource = dvPersContact
        DgvListeConcessionnairePersonneContact.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvListeConcessionnairePersonneContact.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub


    Private Sub DataBindConsInfos()
        FCTBnumero.DataBindings.Add("Text", dtcons, "con_numero")
        FCTBEmplacement.DataBindings.Add("Text", dtcons, "empl_reference")
        FCTBMonumentClasse.DataBindings.Add("Text", dtcons, "empl_monum_classe")
        FCTBCommentaire.DataBindings.Add("Text", dtcons, "com_commentaire")
        FCTBHistoire.DataBindings.Add("Text", dtcons, "h_histoire")
        FCTBType.DataBindings.Add("Text", dtcons, "empl_type")
        FCTBDateDeb.DataBindings.Add("Text", dtcons, "con_date_debut", True, DataSourceUpdateMode.OnValidation, "", "dd/MM/yyyy")
        FCTBDateFin.DataBindings.Add("Text", dtcons, "con_date_fin", True, DataSourceUpdateMode.OnValidation, "", "dd/MM/yyyy")
    End Sub

    Private Sub DataBindConsbenef()
        TBconsBenefnom.DataBindings.Add("Text", dvbenefsdeconcession, "ben_nom")
        TBconsBenefprenom.DataBindings.Add("Text", dvbenefsdeconcession, "ben_prenom")
        TBconsBenefadress.DataBindings.Add("Text", dvbenefsdeconcession, "ben_adresse")
        ''''''TBconsBenefdatenaiss.DataBindings.Add("Text", dvbenefsdeconcession, "ben_date_naiss")
        'TBconsBenefdatenaiss.DataBindings.Add("DateValue", dvbenefsdeconcession, "ben_date_naiss")
        CtrlLocBenefDeCons.DataBindings.Add("LocVilleId", dvbenefsdeconcession, "locville_id")

        ' À TESTER À TESTER + utiliser tbdate
        TBconsBenefdatenaiss.DataBindings.Add("Text", dvbenefsdeconcession, "ben_date_naiss", True, DataSourceUpdateMode.OnValidation, "", "dd/MM/yyyy")
    End Sub

    Private Sub DataBindDefunt()
        FPTBNom.DataBindings.Add("Text", dvlistedefunts, "def_nom")
        FPTBPrenom.DataBindings.Add("Text", dvlistedefunts, "def_prenom")
        'FPTBDateNaiss.DataBindings.Add("Text", dvlistedefunts, "def_date_naiss")
        'FPTBDateE.DataBindings.Add("Text", dvlistedefunts, "Date_debut")
        ' à voir...?
        TbDefDateNaiss.DataBindings.Add("DateValue", dvlistedefunts, "def_date_naiss")
        'TbDefDateNaiss.DataBindings.Add("Text", dvlistedefunts, "def_date_naiss", True, DataSourceUpdateMode.OnValidation, "", "dd/MM/yyyy")
        FPTBDateE.DataBindings.Add("Text", dvlistedefunts, "Date_debut", True, DataSourceUpdateMode.OnValidation, "", "dd/MM/yyyy")
        FPTBAdresse.DataBindings.Add("Text", dvlistedefunts, "def_adresse")
        'FPTBDateM.DataBindings.Add("Text", dvlistedefunts, "def_date_deces")
        ' à voir...?
        'FPTBDateM.DataBindings.Add("Text", dvlistedefunts, "def_date_deces", True, DataSourceUpdateMode.OnValidation, "", "dd/MM/yyyy")
        TbDefDateDeces.DataBindings.Add("DateValue", dvlistedefunts, "def_date_deces")
        FPTBLieuNaiss.DataBindings.Add("Text", dvlistedefunts, "def_lieu_naiss")
        CbDefEmplacement.DataBindings.Add("EmplId", dvlistedefunts, "empl_id")
        CtrlEtatCivDef.DataBindings.Add("EtatCivil", dvlistedefunts, "def_etat_civil")
        CtrlEtatCivDef.DataBindings.Add("EtatCivilDe", dvlistedefunts, "def_etat_civil_de")
        CtrlLocVilleDef.DataBindings.Add("LocVilleId", dvlistedefunts, "locville_id")
        ''''CtrlLocVilleDef.DataBindings.Add("osef", dvlistedefunts, "def_prenom")
        ''''CtrlEtatCivDef.DataBindings.Add("osef", dvlistedefunts, "def_prenom")

    End Sub



    Private Sub DataBindConss()
        TBPersNom.DataBindings.Add("Text", dvCsnrs, "csnr_nom")
        TBPersPrenom.DataBindings.Add("Text", dvCsnrs, "csnr_prenom")
        TBPersTel.DataBindings.Add("Text", dvCsnrs, "csnr_tel")
        'TBPersDN.DataBindings.Add("Text", dvCsnrs, "csnr_date_naiss")
        ' À TESTER
        TBPersDN.DataBindings.Add("Text", dvCsnrs, "csnr_date_naiss", True, DataSourceUpdateMode.OnValidation, "", "dd/MM/yyyy")
        TBPersAdress.DataBindings.Add("Text", dvCsnrs, "csnr_adresse")
        TBPersCodePostal.DataBindings.Add("Text", dvCsnrs, "locville_cp")
        TBPersVille.DataBindings.Add("Text", dvCsnrs, "locville_ville")
        TBPersPays.DataBindings.Add("Text", dvCsnrs, "Pays_nom")
        TBPersNumNational.DataBindings.Add("Text", dvCsnrs, "csnr_no_registre")
    End Sub

    Private Sub DataBindBenef()
        TBPersNom.DataBindings.Add("Text", dvbenefs, "ben_nom")
        TBPersPrenom.DataBindings.Add("Text", dvbenefs, "ben_prenom")
        'TBPersDN.DataBindings.Add("Text", dvbenefs, "ben_date_naiss")
        ' À TESTER
        TBPersDN.DataBindings.Add("Text", dvbenefs, "ben_date_naiss", True, DataSourceUpdateMode.OnValidation, "", "dd/MM/yyyy")
        TBPersAdress.DataBindings.Add("Text", dvbenefs, "ben_adresse")
        TBPersNumNational.DataBindings.Add("Text", dvbenefs, "ben_lien_parente")
        TBPersCodePostal.DataBindings.Add("Text", dvbenefs, "locville_cp")
        TBPersVille.DataBindings.Add("Text", dvbenefs, "locville_ville")
        TBPersPays.DataBindings.Add("Text", dvbenefs, "Pays_nom")
    End Sub

    Private Sub DataBindPersContact()
        TBPersNom.DataBindings.Add("Text", dvPersContact, "pc_nom")
        TBPersPrenom.DataBindings.Add("Text", dvPersContact, "pc_prenom")
        TBPersTel.DataBindings.Add("Text", dvPersContact, "pc_tel")
        TBPersAdress.DataBindings.Add("Text", dvPersContact, "pc_adresse")
        TBPersCodePostal.DataBindings.Add("Text", dvPersContact, "locville_cp")
        TBPersVille.DataBindings.Add("Text", dvPersContact, "locville_ville")
        TBPersPays.DataBindings.Add("Text", dvPersContact, "Pays_nom")
    End Sub

    Private Sub DataBindClear()
        TBPersNom.DataBindings.Clear()
        TBPersPrenom.DataBindings.Clear()
        TBPersTel.DataBindings.Clear()
        TBPersDN.DataBindings.Clear()
        TBPersAdress.DataBindings.Clear()
        TBPersCodePostal.DataBindings.Clear()
        TBPersNumNational.DataBindings.Clear()
        TBPersVille.DataBindings.Clear()
        TBPersPays.DataBindings.Clear()
    End Sub


    'Private Sub DataBindClearConcessions()
    '    FCTBnumero.DataBindings.Clear()
    '    FCTBEmplacement.DataBindings.Clear()
    '    FCTBMonumentClasse.DataBindings.Clear()
    '    FCTBType.DataBindings.Clear()
    '    FCTBCommentaire.DataBindings.Clear()
    '    FCTBHistoire.DataBindings.Clear()
    '    FCTBDateDeb.DataBindings.Clear()
    '    FCTBDateFin.DataBindings.Clear()
    'End Sub

    'Private Sub DataBindClearConcessionsBeneficiaire()
    '    TBconsBenefnom.DataBindings.Clear()
    '    TBconsBenefprenom.DataBindings.Clear()
    '    TBconsBenefadress.DataBindings.Clear()
    '    TBconsBenefdatenaiss.DataBindings.Clear()
    'End Sub

    'Private Sub DataBindClearBeneficiaire()
    '    FPTBNom.DataBindings.Clear()
    '    FPTBPrenom.DataBindings.Clear()
    '    FPTBDateNaiss.DataBindings.Clear()
    '    FPTBDateE.DataBindings.Clear()
    '    FPTBEtatCivil.DataBindings.Clear()
    '    FPTBSepulture.DataBindings.Clear()
    '    FPTBDateM.DataBindings.Clear()
    '    FPTBEtatCivil.DataBindings.Clear()
    '    FPTBAdresse.DataBindings.Clear()
    '    FPTBEmplacement.DataBindings.Clear()
    '    FPTBLieuNaiss.DataBindings.Clear()
    '    FPTBCodePostal.DataBindings.Clear()
    '    FPTBPays.DataBindings.Clear()
    '    FPTBVille.DataBindings.Clear()
    'End Sub


    Private Sub FPBDetails_Click(sender As Object, e As EventArgs)
        Dim FDetails As New FDetails
        FDetails.ShowDialog()
    End Sub



    Private Sub FPBAjouter_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub FPBRechercher_Click(sender As Object, e As EventArgs)
        'If FPCBNom.Checked = True Then
        'Dim Source As New BindingSource()
        'Source.DataSource = Me.DgvListeDefunts.DataSource
        'Source.Filter = "def_nom Like '%" & FPTBRechercher.Text & "%'"
        'ElseIf FPCBEmplacement.Checked = True Then

        '        ElseIf FPCBDate.Checked = True Then
        ' erreur avec les dates
        ' Dim Source As New BindingSource()
        '  Source.DataSource = Me.DgvListeDefunts.DataSource
        '  Source.Filter = "def_date_naiss like '%" & FPTBRechercher.ToString & "%'"

        ' ElseIf FPCBDateD.Checked = True Then

        ' Else
        'MessageBox.Show("Veuillez inserer un choix")
        '  End If

    End Sub



    Private Sub BtDefChercher_Click(sender As Object, e As EventArgs) Handles BtDefChercher.Click
        ''Dim Source As New BindingSource()
        ''Source.DataSource = Me.DgvListeDefunts.DataSource
        'Dim source As DataView = DgvListeDefunts.DataSource
        Dim dateavant As Date = DtpDefRechercherDateDecesAvant.Value.Date
        Dim dateapres As Date = DtpDefRechercherDateDecesApres.Value.Date
        Dim Filtre As String = ""
        If RbDefChercherNom.Checked = True Then
            Filtre = "def_nom Like '%" & TbDefChampRecherche.Text.Trim & "%'"
        Else
            Filtre = "empl_reference Like '%" & TbDefChampRecherche.Text.Trim & "%'"
        End If

        If DtpDefRechercherDateDecesApres.Checked Then
            Filtre &= " AND def_date_deces > #" & Format(dateapres, "M/d/yyyy") & "#"
        End If
        If DtpDefRechercherDateDecesAvant.Checked Then
            Filtre &= " AND def_date_deces < #" & Format(dateavant, "M/d/yyyy") & "#"
        End If

        dvlistedefunts.RowFilter = Filtre
    End Sub

    Private Sub BtDefAnnulerRecherche_Click(sender As Object, e As EventArgs) Handles BtDefAnnulerRecherche.Click
        dvlistedefunts.RowFilter = ""
        TbDefChampRecherche.Text = ""
        DtpDefRechercherDateDecesApres.Checked = False
        DtpDefRechercherDateDecesAvant.Checked = False
    End Sub

    Private Sub PRBConcessionnaire_CheckedChanged(sender As Object, e As EventArgs) Handles PRBConcessionnaire.CheckedChanged
        DgvListeConcessionnaireBenef.Hide()
        DgvListeConcessionnairePersonneContact.Hide()
        DgvListeConcessionnaireConcess.Show()
        DataBindClear()
        DataBindConss()
    End Sub

    Private Sub PRBPersCon_CheckedChanged(sender As Object, e As EventArgs) Handles PRBPersCon.CheckedChanged
        DgvListeConcessionnaireBenef.Hide()
        DgvListeConcessionnairePersonneContact.Show()
        DgvListeConcessionnaireConcess.Hide()
        DataBindClear()
        DataBindPersContact()
    End Sub

    Private Sub PRBBenef_CheckedChanged(sender As Object, e As EventArgs) Handles PRBBenef.CheckedChanged
        DgvListeConcessionnaireBenef.Show()
        DgvListeConcessionnairePersonneContact.Hide()
        DgvListeConcessionnaireConcess.Hide()
        DataBindClear()
        DataBindBenef()
    End Sub



    Private Sub FCDGConss_SelectionChanged(sender As Object, e As EventArgs) Handles FCDGConss.SelectionChanged
        ' A FAIRE vérif présence sélection (& aussi pr autres fcts c^ celle-ci)



        '''DataBindClearConcessions()
        'FCDGBeneficiaire.DataBindings.Clear()
        '''''''FCDGBeneficiaire.Columns.Clear()
        'FCDGDefunt.DataBindings.Clear()
        'FCDGDefunt.Columns.Clear()
        'DataTableDefuntCons()
        ''DataTableConsBeneficiaire()
        'DataBindConsDefunt()

        If FCDGConss.SelectedRows.Count > 0 Then
            Dim EmplSelect = CType(FCDGConss.SelectedRows(0).DataBoundItem, DataRowView).Row

            dvdefuntcons.RowFilter = "empl_id = " & EmplSelect("empl_id")
            ' suppose que la table des emplacements contient aussi les données de la location
            If Not IsDBNull(EmplSelect("con_id")) Then
                dvbenefsdeconcession.RowFilter = "ben_con_id = " & EmplSelect("con_id")
            Else
                dvbenefsdeconcession.RowFilter = "False"
            End If

            Dim nbplaces = EmplSelect("empl_nb_places")
            FCTBNbPlaces.Text = If(IsDBNull(nbplaces), "", EmplSelect("empl_nb_places"))         ' - (FCDGDefunt.RowCount - 1))

            FCTBPlaceOccupe.Text = FCDGDefunt.RowCount  '- 1

        Else
            ' À FAIRE/CONTINUER - si pas de sélection
            dvbenefsdeconcession.RowFilter = "False"
            dvdefuntcons.RowFilter = "False"

        End If

    End Sub

    Sub osefa() Handles DgvListeDefunts.SelectionChanged
        Dim a = "a"
    End Sub

    Private Sub FCDGBeneficiaire_SelectionChanged(sender As Object, e As EventArgs) Handles FCDGBeneficiaire.SelectionChanged
        If FCDGBeneficiaire.SelectedRows.Count > 0 Then
            Dim BenSelect = CType(FCDGBeneficiaire.SelectedRow.DataBoundItem, DataRowView).Row

            CtrlLocBenefDeCons.LocVilleId = If(IsDBNull(BenSelect("locville_id")), -1, BenSelect("locville_id"))

        Else
            CtrlLocBenefDeCons.LocVilleId = -1
            ' A FAIRE
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtRechEmpl.Click
        'Dim Source As New BindingSource()
        Dim dateavant As Date = DtpConsRechercherDateFin.Value.Date
        Dim dateapres As Date = DtpConsRechercherDateFinap.Value.Date
        Dim Filtre As String = ""
        'Source.DataSource = Me.FCDGConss.DataSource

        If RbfconsNumero.Checked = True Then
            Filtre = "CONVERT(con_numero, 'System.String') Like '%" & FCTBRechercher.Text.Trim & "%'"
        Else
            Filtre = "empl_reference Like '%" & FCTBRechercher.Text.Trim & "%'"
        End If

        If DtpConsRechercherDateFin.Checked Then
            Filtre &= " AND con_date_fin < #" & Format(dateavant, "M/d/yyyy") & "#"
        End If
        If DtpConsRechercherDateFinap.Checked Then
            Filtre &= " AND con_date_fin > #" & Format(dateapres, "M/d/yyyy") & "#"
        End If

        dvlisteempl.RowFilter = Filtre

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dvlisteempl.RowFilter = ""
        FCTBRechercher.Text = ""
        DtpConsRechercherDateFin.Checked = False
        DtpConsRechercherDateFinap.Checked = False
    End Sub

    Private Sub FPBLienCons_Click(sender As Object, e As EventArgs) Handles FPBLienCons.Click
        If Not DgvListeDefunts.SelectedRows.Count > 0 Then Exit Sub

        Dim Def = DgvListeDefunts.SelectedDataRow
        If IsDBNull(Def("empl_id")) Then Exit Sub

        TabControl1.SelectedIndex = 1
        Button2_Click(Nothing, Nothing) ' annule le filtrage dans les concessions, celle qu'on veut doit être visible
        Dim ligneaselect = (From r As DataGridViewRow In FCDGConss.Rows Where r.Cells("empl_id").Value = Def("empl_id")).First
        ligneaselect.Selected = True
        FCDGConss.ScrollSelectedIntoView()

        ' sélectionne aussi le défunt dans la liste des défunts de l'emplacement

        ligneaselect = (From r As DataGridViewRow In FCDGDefunt.Rows Where r.Cells("def_id").Value = Def("def_id")).First
        ligneaselect.Selected = True
        FCDGDefunt.ScrollSelectedIntoView()

    End Sub

    Private Sub FCBLienDefunt_Click(sender As Object, e As EventArgs) Handles FCBLienDefunt.Click
        If Not FCDGDefunt.SelectedRows.Count > 0 Then Exit Sub

        Dim def = FCDGDefunt.SelectedDataRow

        TabControl1.SelectedIndex = 0
        BtDefAnnulerRecherche_Click(Nothing, Nothing)
        Dim ligneaselect = (From r As DataGridViewRow In DgvListeDefunts.Rows Where r.Cells("def_id").value = def("def_id")).First
        ligneaselect.Selected = True

        DgvListeDefunts.ScrollSelectedIntoView()
    End Sub

    Private Sub TextBoxConsRO()
        FCTBnumero.ReadOnly = True
        FCTBnumero.Cursor = Cursors.No
        If FCTBnumero.BackColor <> SystemColors.Window Then FCTBnumero.BackColor = SystemColors.Window
        FCTBNbPlaces.ReadOnly = True
        FCTBNbPlaces.Cursor = Cursors.No
        If FCTBNbPlaces.BackColor <> SystemColors.Window Then FCTBNbPlaces.BackColor = SystemColors.Window
        FCTBPlaceOccupe.ReadOnly = True
        FCTBPlaceOccupe.Cursor = Cursors.No
        If FCTBPlaceOccupe.BackColor <> SystemColors.Window Then FCTBPlaceOccupe.BackColor = SystemColors.Window
        FCTBType.ReadOnly = True
        FCTBType.Cursor = Cursors.No
        If FCTBType.BackColor <> SystemColors.Window Then FCTBType.BackColor = SystemColors.Window
        FCTBMonumentClasse.ReadOnly = True
        FCTBMonumentClasse.Cursor = Cursors.No
        If FCTBMonumentClasse.BackColor <> SystemColors.Window Then FCTBMonumentClasse.BackColor = SystemColors.Window
        FCTBHistoire.ReadOnly = True
        FCTBHistoire.Cursor = Cursors.No
        If FCTBHistoire.BackColor <> SystemColors.Window Then FCTBHistoire.BackColor = SystemColors.Window
        FCTBEmplacement.ReadOnly = True
        FCTBEmplacement.Cursor = Cursors.No
        If FCTBEmplacement.BackColor <> SystemColors.Window Then FCTBEmplacement.BackColor = SystemColors.Window
        FCTBDateFin.ReadOnly = True
        FCTBDateFin.Cursor = Cursors.No
        If FCTBDateFin.BackColor <> SystemColors.Window Then FCTBDateFin.BackColor = SystemColors.Window
        FCTBDateDeb.ReadOnly = True
        FCTBDateDeb.Cursor = Cursors.No
        If FCTBDateDeb.BackColor <> SystemColors.Window Then FCTBDateDeb.BackColor = SystemColors.Window
        FCTBCommentaire.ReadOnly = True
        FCTBCommentaire.Cursor = Cursors.No
        If FCTBCommentaire.BackColor <> SystemColors.Window Then FCTBCommentaire.BackColor = SystemColors.Window
        TBconsBenefadress.ReadOnly = True
        TBconsBenefadress.Cursor = Cursors.No
        If TBconsBenefadress.BackColor <> SystemColors.Window Then TBconsBenefadress.BackColor = SystemColors.Window
        TBconsBenefdatenaiss.ReadOnly = True
        TBconsBenefdatenaiss.Cursor = Cursors.No
        If TBconsBenefdatenaiss.BackColor <> SystemColors.Window Then TBconsBenefdatenaiss.BackColor = SystemColors.Window
        TBconsBenefnom.ReadOnly = True
        TBconsBenefnom.Cursor = Cursors.No
        CtrlLocBenefDeCons.LectureSeule = True
        If TBconsBenefnom.BackColor <> SystemColors.Window Then TBconsBenefnom.BackColor = SystemColors.Window
        TBconsBenefpays.ReadOnly = True
        TBconsBenefpays.Cursor = Cursors.No
        If TBconsBenefpays.BackColor <> SystemColors.Window Then TBconsBenefpays.BackColor = SystemColors.Window
        TBconsBenefprenom.ReadOnly = True
        TBconsBenefprenom.Cursor = Cursors.No
        If TBconsBenefprenom.BackColor <> SystemColors.Window Then TBconsBenefprenom.BackColor = SystemColors.Window
        TBconsBenefville.ReadOnly = True
        TBconsBenefville.Cursor = Cursors.No
        If TBconsBenefville.BackColor <> SystemColors.Window Then TBconsBenefville.BackColor = SystemColors.Window
    End Sub
    Private Sub TextBoxDefuntRO()
        FPTBNom.ReadOnly = True
        FPTBNom.Cursor = Cursors.No
        If FPTBNom.BackColor <> SystemColors.Window Then FPTBNom.BackColor = SystemColors.Window
        FPTBPrenom.ReadOnly = True
        FPTBPrenom.Cursor = Cursors.No
        If FPTBPrenom.BackColor <> SystemColors.Window Then FPTBPrenom.BackColor = SystemColors.Window
        FPTBLieuNaiss.ReadOnly = True
        FPTBLieuNaiss.Cursor = Cursors.No
        If FPTBLieuNaiss.BackColor <> SystemColors.Window Then FPTBLieuNaiss.BackColor = SystemColors.Window
        CbDefEmplacement.Enabled = False
        CbDefEmplacement.Cursor = Cursors.No
        If CbDefEmplacement.BackColor <> SystemColors.Window Then CbDefEmplacement.BackColor = SystemColors.Window
        TbDefDateNaiss.ReadOnly = True
        TbDefDateNaiss.Cursor = Cursors.No
        If TbDefDateNaiss.BackColor <> SystemColors.Window Then TbDefDateNaiss.BackColor = SystemColors.Window
        TbDefDateDeces.ReadOnly = True
        TbDefDateDeces.Cursor = Cursors.No
        If TbDefDateDeces.BackColor <> SystemColors.Window Then TbDefDateDeces.BackColor = SystemColors.Window
        FPTBDateE.ReadOnly = True
        FPTBDateE.Cursor = Cursors.No
        If FPTBDateE.BackColor <> SystemColors.Window Then FPTBDateE.BackColor = SystemColors.Window
        FPTBAdresse.ReadOnly = True
        FPTBAdresse.Cursor = Cursors.No
        If FPTBAdresse.BackColor <> SystemColors.Window Then FPTBAdresse.BackColor = SystemColors.Window
    End Sub

    Private Sub TextBoxPersRO()
        TBPersNom.ReadOnly = True
        TBPersNom.Cursor = Cursors.No
        If TBPersNom.BackColor <> SystemColors.Window Then TBPersNom.BackColor = SystemColors.Window
        TBPersNumNational.ReadOnly = True
        TBPersNumNational.Cursor = Cursors.No
        If TBPersNumNational.BackColor <> SystemColors.Window Then TBPersNumNational.BackColor = SystemColors.Window
        TBPersPays.ReadOnly = True
        TBPersPays.Cursor = Cursors.No
        If TBPersPays.BackColor <> SystemColors.Window Then TBPersPays.BackColor = SystemColors.Window
        TBPersPrenom.ReadOnly = True
        TBPersPrenom.Cursor = Cursors.No
        If TBPersPrenom.BackColor <> SystemColors.Window Then TBPersPrenom.BackColor = SystemColors.Window
        TBPersTel.ReadOnly = True
        TBPersTel.Cursor = Cursors.No
        If TBPersTel.BackColor <> SystemColors.Window Then TBPersTel.BackColor = SystemColors.Window
        TBPersVille.ReadOnly = True
        TBPersVille.Cursor = Cursors.No
        If TBPersVille.BackColor <> SystemColors.Window Then TBPersVille.BackColor = SystemColors.Window
        TBPersDN.ReadOnly = True
        TBPersDN.Cursor = Cursors.No
        If TBPersDN.BackColor <> SystemColors.Window Then TBPersDN.BackColor = SystemColors.Window
        TBPersCodePostal.ReadOnly = True
        TBPersCodePostal.Cursor = Cursors.No
        If TBPersCodePostal.BackColor <> SystemColors.Window Then TBPersCodePostal.BackColor = SystemColors.Window
        TBPersAdress.ReadOnly = True
        TBPersAdress.Cursor = Cursors.No
        If TBPersAdress.BackColor <> SystemColors.Window Then TBPersAdress.BackColor = SystemColors.Window

    End Sub

    Private Sub TextBoxPersUpd()
        TBPersNom.ReadOnly = False
        TBPersNom.Cursor = Cursors.IBeam
        TBPersNumNational.ReadOnly = False
        TBPersNumNational.Cursor = Cursors.IBeam
        TBPersPays.ReadOnly = False
        TBPersPays.Cursor = Cursors.IBeam
        TBPersPrenom.ReadOnly = False
        TBPersPrenom.Cursor = Cursors.IBeam
        TBPersTel.ReadOnly = False
        TBPersTel.Cursor = Cursors.IBeam
        TBPersVille.ReadOnly = False
        TBPersVille.Cursor = Cursors.IBeam
        TBPersDN.ReadOnly = False
        TBPersDN.Cursor = Cursors.IBeam
        TBPersCodePostal.ReadOnly = False
        TBPersCodePostal.Cursor = Cursors.IBeam
        TBPersAdress.ReadOnly = False
        TBPersAdress.Cursor = Cursors.IBeam
    End Sub

    Private Sub TextBoxDefuntUpd()
        FPTBNom.ReadOnly = False
        FPTBNom.Cursor = Cursors.IBeam
        FPTBPrenom.ReadOnly = False
        FPTBPrenom.Cursor = Cursors.IBeam
        FPTBLieuNaiss.ReadOnly = False
        FPTBLieuNaiss.Cursor = Cursors.IBeam
        CbDefEmplacement.Enabled = True
        CbDefEmplacement.Cursor = Cursors.IBeam
        TbDefDateNaiss.ReadOnly = False
        TbDefDateNaiss.Cursor = Cursors.IBeam
        TbDefDateDeces.ReadOnly = False
        TbDefDateDeces.Cursor = Cursors.IBeam
        FPTBDateE.ReadOnly = False
        FPTBDateE.Cursor = Cursors.IBeam
        FPTBAdresse.ReadOnly = False
        FPTBAdresse.Cursor = Cursors.IBeam
    End Sub

    Private Sub TextBoxConsUpd()
        FCTBnumero.ReadOnly = False
        FCTBnumero.Cursor = Cursors.IBeam
        FCTBNbPlaces.ReadOnly = False
        FCTBNbPlaces.Cursor = Cursors.IBeam
        FCTBPlaceOccupe.ReadOnly = False
        FCTBPlaceOccupe.Cursor = Cursors.IBeam
        FCTBType.ReadOnly = False
        FCTBType.Cursor = Cursors.IBeam
        FCTBMonumentClasse.ReadOnly = False
        FCTBMonumentClasse.Cursor = Cursors.IBeam
        FCTBHistoire.ReadOnly = False
        FCTBHistoire.Cursor = Cursors.IBeam
        FCTBEmplacement.ReadOnly = False
        FCTBEmplacement.Cursor = Cursors.IBeam
        FCTBDateFin.ReadOnly = False
        FCTBDateFin.Cursor = Cursors.IBeam
        FCTBDateDeb.ReadOnly = False
        FCTBDateDeb.Cursor = Cursors.IBeam
        FCTBCommentaire.ReadOnly = False
        FCTBCommentaire.Cursor = Cursors.IBeam
    End Sub

    Private Sub TextBoxConsBenefUpd()
        TBconsBenefadress.ReadOnly = False
        TBconsBenefadress.Cursor = Cursors.IBeam
        TBconsBenefdatenaiss.ReadOnly = False
        TBconsBenefdatenaiss.Cursor = Cursors.IBeam
        TBconsBenefnom.ReadOnly = False
        TBconsBenefnom.Cursor = Cursors.IBeam
        CtrlLocBenefDeCons.LectureSeule = False
        TBconsBenefpays.ReadOnly = False
        TBconsBenefpays.Cursor = Cursors.IBeam
        TBconsBenefprenom.ReadOnly = False
        TBconsBenefprenom.Cursor = Cursors.IBeam
        TBconsBenefville.ReadOnly = False
        TBconsBenefville.Cursor = Cursors.IBeam
    End Sub

    Private Sub FPBModifier_Click(sender As Object, e As EventArgs) Handles FPBModifier.Click
        DgvListeDefunts.Enabled = False

        BtDefChercher.Enabled = False
        BtDefAnnulerRecherche.Enabled = False
        'FPTBCBEtatCivil.Visible = True
        'Select Case FPTBEtatCivil.Text
        '    Case "Non précisé"
        '        FPTBCBEtatCivil.SelectedIndex = 4
        '    Case "Célibataire"
        '        FPTBCBEtatCivil.SelectedIndex = 0
        '    Case "Epoux"
        '        FPTBCBEtatCivil.SelectedIndex = 1
        '    Case "Veuf"
        '        FPTBCBEtatCivil.SelectedIndex = 2
        '    Case "divorcé"
        '        FPTBCBEtatCivil.SelectedIndex = 3
        'End Select

        If boutongestion = 0 Then
            TextBoxDefuntUpd()
            boutongestion = 1
            FPBModifier.Text = "Sauvegarder ou annuler"
            TabControl1.TabPages(1).Enabled = False
            TabControl1.TabPages(2).Enabled = False
        Else
            Dim result As Integer = MessageBox.Show("Etes-vous sur de vouloir effectuer cette modification ?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                boutongestion = 0
                FPBModifier.Text = "Modifier"
                TextBoxDefuntRO()
                TabControl1.TabPages(1).Enabled = True
                TabControl1.TabPages(2).Enabled = True
            ElseIf result = DialogResult.Yes Then
                ' À FAIRE À FAIRE
                'If Bdd.NonQuery("Update defunts set def_nom = '" & FPTBNom.Text & "', def_prenom = '" & FPTBPrenom.Text & "', def_adresse " &
                '                " = '" & FPTBAdresse.Text & "', def_etat_civil_de = '" & FPTBCodeLieu.Text & "', def_lieu_de_naiss = '" & FPTBLieuNaiss.Text & "', " &
                '                "  where def_id ='" & DgvListeDefunts.CurrentRow.Cells("def_id").Value & "'") Then
                '    MsgBox("" & DgvListeDefunts.CurrentRow.Cells("def_nom").Value & " " & DgvListeDefunts.CurrentRow.Cells("def_prenom").Value & " " & vbCrLf & "a correctement été modifier")
                'Else
                '    MsgBox("Une erreur est venue dans la modification du défunt.")
                '    End If
                boutongestion = 0
                FPBModifier.Text = "Modifier"
                    TextBoxDefuntRO()
                    TabControl1.TabPages(1).Enabled = True
                    TabControl1.TabPages(2).Enabled = True
                End If
                DgvListeDefunts.Enabled = True

                BtDefChercher.Enabled = True
                BtDefAnnulerRecherche.Enabled = True
            End If
    End Sub

    Private Sub BmodifCons_Click(sender As Object, e As EventArgs) Handles BmodifCons.Click
        If boutongestion = 0 Then
            TextBoxConsUpd()
            boutongestion = 1
            BmodifCons.Text = "Sauvegarder"
            TabControl1.TabPages(0).Enabled = False
            TabControl1.TabPages(2).Enabled = False
        Else
            Dim result As Integer = MessageBox.Show("Etes-vous sur de vouloir effectuer cette modification ?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                boutongestion = 0
                BmodifCons.Text = "Modifier"
                TextBoxConsRO()
                TabControl1.TabPages(0).Enabled = True
                TabControl1.TabPages(2).Enabled = True
            ElseIf result = DialogResult.Yes Then
                boutongestion = 0
                BmodifCons.Text = "Modifier"
                TextBoxConsRO()
                TabControl1.TabPages(0).Enabled = True
                TabControl1.TabPages(2).Enabled = True
            End If
        End If
    End Sub

    Private Sub BmodifConsBenef_Click(sender As Object, e As EventArgs) Handles BmodifConsBenef.Click
        If boutongestion = 0 Then
            TextBoxConsBenefUpd()
            boutongestion = 1
            BmodifConsBenef.Text = "Sauvegarder"
            TabControl1.TabPages(0).Enabled = False
            TabControl1.TabPages(2).Enabled = False
        Else
            Dim result As Integer = MessageBox.Show("Etes-vous sur de vouloir effectuer cette modification ?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                boutongestion = 0
                BmodifConsBenef.Text = "Modifier"
                TextBoxConsRO()
                TabControl1.TabPages(0).Enabled = True
                TabControl1.TabPages(2).Enabled = True
            ElseIf result = DialogResult.Yes Then
                boutongestion = 0
                BmodifConsBenef.Text = "Modifier"
                TextBoxConsRO()
                TabControl1.TabPages(0).Enabled = True
                TabControl1.TabPages(2).Enabled = True
            End If
        End If
    End Sub

    Private Sub BModifGestionPers_Click(sender As Object, e As EventArgs) Handles BModifGestionPers.Click
        If boutongestion = 0 Then
            TextBoxPersUpd()
            boutongestion = 1
            BModifGestionPers.Text = "Sauvegarder"
            TabControl1.TabPages(0).Enabled = False
            TabControl1.TabPages(1).Enabled = False
        Else
            Dim result As Integer = MessageBox.Show("Etes-vous sur de vouloir effectuer cette modification ?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                boutongestion = 0
                BModifGestionPers.Text = "Modifier"
                TextBoxPersRO()
                TabControl1.TabPages(0).Enabled = True
                TabControl1.TabPages(1).Enabled = True
            ElseIf result = DialogResult.Yes Then
                boutongestion = 0
                BModifGestionPers.Text = "Modifier"
                TextBoxPersRO()
                TabControl1.TabPages(0).Enabled = True
                TabControl1.TabPages(1).Enabled = True
            End If
        End If
    End Sub



    Private Sub FDBLinkToPersCon_Click(sender As Object, e As EventArgs) Handles FDBLinkToPersCon.Click
        ' à revoir
        Dim personcontactid As String = DgvListeDefunts.SelectedRows(0).Cells("pc_id").Value
        TabControl1.SelectedIndex = 2
        PRBPersCon.Select()
        Dim Source As New BindingSource()
        Source.DataSource = Me.DgvListeConcessionnairePersonneContact.DataSource
        Source.Filter = "convert([pc_id],'System.String') LIKE '" & personcontactid & "'"

    End Sub

    Private Sub FDBLinkToConcessionnaire_Click(sender As Object, e As EventArgs) Handles FDBLinkToConcessionnaire.Click
        ' à revoir
        Dim concessionnaireid As String = FCDGConss.SelectedRows(0).Cells("csnr_id").Value
        TabControl1.SelectedIndex = 2
        PRBPersCon.Select()
        PRBConcessionnaire.Select()
        Dim Source As New BindingSource()
        Source.DataSource = Me.DgvListeConcessionnaireConcess.DataSource
        Source.Filter = "convert([csnr_id],'System.String') LIKE '" & concessionnaireid & "'"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim Source As New BindingSource()
        If PRBBenef.Checked = True Then
            Source.DataSource = Me.DgvListeConcessionnaireBenef.DataSource
            Source.Filter = "ben_nom like '%" & FPersonneTbSearch.Text & "%'"
        ElseIf PRBConcessionnaire.Checked = True Then
            Source.DataSource = Me.DgvListeConcessionnaireConcess.DataSource
            Source.Filter = "csnr_nom like '%" & FPersonneTbSearch.Text & "%'"
        ElseIf PRBPersCon.Checked = True Then
            Source.DataSource = Me.DgvListeConcessionnairePersonneContact.DataSource
            Source.Filter = "pc_nom like '%" & FPersonneTbSearch.Text & "%'"
        Else
            MsgBox("Veuillez effectuer un choix.")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Source As New BindingSource()
        If PRBBenef.Checked = True Then
            Source.DataSource = Me.DgvListeConcessionnaireBenef.DataSource
            Source.Filter = "ben_nom like '%'"
        ElseIf PRBConcessionnaire.Checked = True Then
            Source.DataSource = Me.DgvListeConcessionnaireConcess.DataSource
            Source.Filter = "csnr_nom like '%'"
        ElseIf PRBPersCon.Checked = True Then
            Source.DataSource = Me.DgvListeConcessionnairePersonneContact.DataSource
            Source.Filter = "pc_nom like '%'"
        Else
            MsgBox("Veuillez effectuer un choix.")
        End If
    End Sub

    Private Sub FPBSupprimer_Click(sender As Object, e As EventArgs) Handles FPBSupprimer.Click
        ' à revoir
        Dim result As Integer = MessageBox.Show("Etes-vous sur de vouloir supprimer ce défunt ?", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            If Bdd.NonQuery("DELETE FROM defunts where def_id =" & DgvListeDefunts.SelectedRows(0).Cells("def_id").Value) = 1 Then
                MsgBox("" & DgvListeDefunts.SelectedRows(0).Cells("def_nom").Value & " " & DgvListeDefunts.SelectedRows(0).Cells("def_prenom").Value & " " & vbCrLf & "a correctement été supprimer")
                DgvListeDefunts.Rows.Remove(DgvListeDefunts.SelectedRows(0))
            Else
                MsgBox("Une erreur est venue dans la suppression du défunt.")
            End If
        End If
    End Sub

    Private Sub BSuppCons_Click(sender As Object, e As EventArgs) Handles BSuppCons.Click

    End Sub

    Private Sub osefa(sender As Object, e As EventArgs) Handles DgvListeDefunts.SelectionChanged

    End Sub

    'Private Sub FPTBEtatCivil_TextChanged(sender As Object, e As EventArgs) Handles FPTBEtatCivil.TextChanged
    '    Select Case FPTBEtatCivil.Text
    '        Case "0"
    '            FPTBEtatCivil.Text = "Non précisé"
    '            FPTBCodeLieu.Text = "xxxxxxxxxx"
    '        Case "1"
    '            FPTBEtatCivil.Text = "Célibataire"
    '            FPTBCodeLieu.Text = "xxxxxxxxxx"
    '        Case "2"
    '            FPTBEtatCivil.Text = "Epoux"
    '        Case "3"
    '            FPTBEtatCivil.Text = "Veuf"
    '        Case "4"
    '            FPTBEtatCivil.Text = "divorcé"
    '            FPTBCodeLieu.Text = "xxxxxxxxxx"
    '    End Select
    'End Sub
End Class
