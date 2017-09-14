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
            BSuppConsBenef.Hide()
            BSuppCons.Hide()
            BAddConsBenef.Hide()
        End If

        TextBoxDefuntRO()
        TextBoxConsRO()
        TextBoxBenefDeConsRO()
        TextBoxPersRO()
        Panel10.Hide()
        Panel3.Hide()
        Panel1.Hide()
        TabControl1.Hide()
        Me.Size = New Size(820, 150)
        Me.Left = (screenWidth - Me.Width) / 2
        Me.Top = (screenHeight - Me.Height) / 2
        Lchargementdonnee.Text = "Chargement des données"

        dtville = Bdd.GetTable("t_loc_ville")
        dtpays = Bdd.GetTable("t_Pays")
        CtrlLocVilleDef.chargercomboboxpays(dtpays)
        CtrlLocVilleDef.chargercomboboxville(dtville)
        CtrlLocBenefDeCons.chargercomboboxville(dtville)
        CtrlLocBenefDeCons.chargercomboboxpays(dtpays)
        CtrlLocPersonne.chargercomboboxville(dtville)
        CtrlLocPersonne.chargercomboboxpays(dtpays)


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

        'dtdefunt = Bdd.Query("SELECT * FROM defunts LEFT OUTER JOIN t_loc_ville ON defunts.locville_id = t_loc_ville.locville_id LEFT OUTER JOIN t_pays on t_loc_ville.locville_id = t_pays.Pays_id LEFT OUTER JOIN emplacements on defunts.empl_id = emplacements.empl_id")
        dtdefunt = Bdd.Query("SELECT * FROM defunts")
        'dtdefunt.CaseSensitive = False
        'AjouterColonneMasque(dtdefunt)

        ' grille principale des défunts
        dvlistedefunts = New DataView(dtdefunt)
        InitDgvDefunts()
        DgvListeDefunts.DataSource = dvlistedefunts

        ' infos du défunt sélectionné
        DataBindDefunt()

        ' grille des défunts de l'emplacement sélectionné
        dvdefuntcons = New DataView(dtdefunt)
        InitDgvDefuntsDeEmpl()
        FCDGDefunt.DataSource = dvdefuntcons

    End Sub

    Private Sub InitDgvDefunts()
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
        colonneid.Visible = False
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
        DgvListeDefunts.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvListeDefunts.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub InitDgvDefuntsDeEmpl()
        Dim DTGV_Id_Colonne_def = New DataGridViewTextBoxColumn()
        DTGV_Id_Colonne_def.DataPropertyName = "def_nom"
        DTGV_Id_Colonne_def.HeaderText = "nom"
        DTGV_Id_Colonne_def.Name = "def_nom"
        'DTGV_Id_Colonne_def.FillWeight = 100
        FCDGDefunt.Columns.Add(DTGV_Id_Colonne_def)

        Dim Colonne = New DataGridViewTextBoxColumn()
        Colonne.DataPropertyName = "def_prenom"
        Colonne.HeaderText = "prenom"
        Colonne.Name = "def_prenom"
        'Colonne.FillWeight = 100
        FCDGDefunt.Columns.Add(Colonne)

        Dim colonneid = New DataGridViewTextBoxColumn()
        colonneid.DataPropertyName = "def_id"
        colonneid.HeaderText = "id"
        colonneid.Name = "def_id"
        colonneid.Visible = False
        FCDGDefunt.Columns.Add(colonneid)

        Dim colonnelien = New DataGridViewButtonColumn
        colonnelien.Name = "lien"
        colonnelien.HeaderText = ""
        colonnelien.FillWeight = 30
        FCDGDefunt.Columns.Add(colonnelien)

        FCDGDefunt.AutoGenerateColumns = False
        FCDGDefunt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        'FCDGDefunt.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        'FCDGDefunt.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Sub DataTableConcess() '2
        'dtCsnr = Bdd.Query("select * FROM concessionnaires LEFT OUTER JOIN t_loc_ville ON concessionnaires.locville_id = t_loc_ville.locville_id LEFT OUTER JOIN t_pays ON t_loc_ville.Pays_id = t_pays.Pays_id")
        dtCsnr = Bdd.Query("select * FROM concessionnaires")
        'AjouterColonneMasque(dtCsnr)

        ' datagridview des concessionnaires

        dvCsnrs = New DataView(dtCsnr)
        InitDgvConcessionnaires()
        DgvListeConcessionnaireConcess.DataSource = dvCsnrs
    End Sub

    Sub InitDgvConcessionnaires()
        Dim DTGV_Id_Colonne = New DataGridViewTextBoxColumn()
        DTGV_Id_Colonne.DataPropertyName = "csnr_nom"
        DTGV_Id_Colonne.HeaderText = "nom"
        DTGV_Id_Colonne.Name = "csnr_nom"
        DgvListeConcessionnaireConcess.Columns.Add(DTGV_Id_Colonne)

        DTGV_Id_Colonne = New DataGridViewTextBoxColumn()
        DTGV_Id_Colonne.DataPropertyName = "csnr_id"
        DTGV_Id_Colonne.Name = "csnr_id"
        DTGV_Id_Colonne.Visible = False
        DgvListeConcessionnaireConcess.Columns.Add(DTGV_Id_Colonne)

        Dim ColonnePrenom = New DataGridViewTextBoxColumn()
        ColonnePrenom.DataPropertyName = "csnr_prenom"
        ColonnePrenom.HeaderText = "prenom"
        ColonnePrenom.Name = "csnr_prenom"
        DgvListeConcessionnaireConcess.Columns.Add(ColonnePrenom)

        DgvListeConcessionnaireConcess.AutoGenerateColumns = False
        DgvListeConcessionnaireConcess.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvListeConcessionnaireConcess.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub


    Sub DataTableConcession() '2
        dtcons = Bdd.Query("SELECT * FROM emplacements LEFT OUTER JOIN concessions ON concessions.empl_id = emplacements.empl_id LEFT OUTER JOIN t_histoire ON emplacements.hist_id = t_histoire.h_id LEFT OUTER JOIN t_commentaire ON concessions.com_id = t_commentaire.com_id")
        'AjouterColonneMasque(dtcons)

        ' datagridview des emplacements

        dvlisteempl = New DataView(dtcons)
        InitDgvEmplacements()
        FCDGConss.DataSource = dvlisteempl

        ' infos de l'emplacement affiché
        DataBindConsInfos()
    End Sub

    Private Sub InitDgvEmplacements()
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
        FCDGConss.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        FCDGConss.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

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
        'dtbenef = Query("SELECT *, beneficier.con_id AS ben_con_id FROM beneficiaires LEFT OUTER JOIN t_loc_ville ON beneficiaires.locville_id = t_loc_ville.locville_id LEFT OUTER JOIN t_pays ON t_loc_ville.Pays_id = t_pays.Pays_id INNER JOIN beneficier ON beneficier.ben_id = beneficiaires.ben_id")
        dtbenef = Query("SELECT *, beneficier.con_id AS ben_con_id FROM beneficiaires INNER JOIN beneficier ON beneficier.ben_id = beneficiaires.ben_id")
        'AjouterColonneMasque(dtbenef)

        'datagridview tous bénéficiaires

        dvbenefs = New DataView(dtbenef)
        InitDgvBeneficiaires()
        DgvListeConcessionnaireBenef.DataSource = dvbenefs


        ' datagridview des bénéficiaires de la concession sélectionnée

        dvbenefsdeconcession = New DataView(dtbenef)
        InitDgvBeneficiairesDeConcession()
        FCDGBeneficiaire.DataSource = dvbenefsdeconcession

        ' infos du bénéficiaire sélectionné (onglet concessions)
        DataBindConsbenef()
    End Sub

    Private Sub InitDgvBeneficiaires()
        Dim DTGV_Id_Colonne = New DataGridViewTextBoxColumn()
        Dim ColonnePrenom = New DataGridViewTextBoxColumn()
        DTGV_Id_Colonne.DataPropertyName = "ben_nom"
        DTGV_Id_Colonne.HeaderText = "nom"
        DTGV_Id_Colonne.Name = "ben_nom"
        DgvListeConcessionnaireBenef.Columns.Add(DTGV_Id_Colonne)

        DTGV_Id_Colonne = New DataGridViewTextBoxColumn()
        DTGV_Id_Colonne.DataPropertyName = "ben_id"
        DTGV_Id_Colonne.Name = "ben_id"
        DTGV_Id_Colonne.Visible = False
        DgvListeConcessionnaireBenef.Columns.Add(DTGV_Id_Colonne)

        ColonnePrenom.DataPropertyName = "ben_prenom"
        ColonnePrenom.HeaderText = "prenom"
        ColonnePrenom.Name = "ben_prenom"
        DgvListeConcessionnaireBenef.Columns.Add(ColonnePrenom)

        DgvListeConcessionnaireBenef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvListeConcessionnaireBenef.AutoGenerateColumns = False
        'DgvListeConcessionnaireBenef.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        'DgvListeConcessionnaireBenef.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub InitDgvBeneficiairesDeConcession()
        Dim DTGV_Id_Colonne = New DataGridViewTextBoxColumn()
        Dim ColonnePrenom = New DataGridViewTextBoxColumn()
        DTGV_Id_Colonne.DataPropertyName = "ben_nom"
        DTGV_Id_Colonne.HeaderText = "nom"
        DTGV_Id_Colonne.Name = "ben_nom"
        FCDGBeneficiaire.Columns.Add(DTGV_Id_Colonne)
        ColonnePrenom.DataPropertyName = "ben_prenom"
        ColonnePrenom.HeaderText = "prenom"
        ColonnePrenom.Name = "ben_prenom"
        FCDGBeneficiaire.Columns.Add(ColonnePrenom)

        DTGV_Id_Colonne = New DataGridViewTextBoxColumn
        DTGV_Id_Colonne.DataPropertyName = "ben_id"
        DTGV_Id_Colonne.Visible = False
        DTGV_Id_Colonne.Name = "ben_id"
        FCDGBeneficiaire.Columns.Add(DTGV_Id_Colonne)

        Dim colonnelien = New DataGridViewButtonColumn
        colonnelien.Name = "lien"
        colonnelien.HeaderText = ""
        colonnelien.FillWeight = 30
        FCDGBeneficiaire.Columns.Add(colonnelien)


        FCDGBeneficiaire.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        FCDGBeneficiaire.AutoGenerateColumns = False
        'FCDGBeneficiaire.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        'FCDGBeneficiaire.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Sub DataTablePersContact()
        'dtPersContact = Query("SELECT * FROM personnes_contact LEFT OUTER JOIN t_loc_ville ON personnes_contact.locville_id = t_loc_ville.locville_id LEFT OUTER JOIN t_pays ON t_loc_ville.Pays_id = t_pays.Pays_id")
        dtPersContact = Query("SELECT * FROM personnes_contact")
        'AjouterColonneMasque(dtPersContact)

        ' liste principale personnes de contact
        dvPersContact = New DataView(dtPersContact)
        InitDgvPersCont()
        DgvListeConcessionnairePersonneContact.DataSource = dvPersContact
    End Sub

    Private Sub InitDgvPersCont()
        Dim DTGV_Id_Colonne = New DataGridViewTextBoxColumn()

        DTGV_Id_Colonne.DataPropertyName = "pc_nom"
        DTGV_Id_Colonne.HeaderText = "nom"
        DTGV_Id_Colonne.Name = "pc_nom"
        DgvListeConcessionnairePersonneContact.Columns.Add(DTGV_Id_Colonne)

        DTGV_Id_Colonne = New DataGridViewTextBoxColumn
        DTGV_Id_Colonne.DataPropertyName = "pc_id"
        DTGV_Id_Colonne.Visible = False
        DTGV_Id_Colonne.Name = "pc_id"
        DgvListeConcessionnairePersonneContact.Columns.Add(DTGV_Id_Colonne)

        Dim ColonnePrenom = New DataGridViewTextBoxColumn()
        ColonnePrenom.DataPropertyName = "pc_prenom"
        ColonnePrenom.HeaderText = "prenom"
        ColonnePrenom.Name = "pc_prenom"
        DgvListeConcessionnairePersonneContact.Columns.Add(ColonnePrenom)

        DgvListeConcessionnairePersonneContact.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvListeConcessionnairePersonneContact.AutoGenerateColumns = False
        'DgvListeConcessionnairePersonneContact.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        'DgvListeConcessionnairePersonneContact.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

    End Sub

    Private Sub DataBindConsInfos()
        FCTBnumero.DataBindings.Add("Text", dvlisteempl, "con_numero")
        CbConsEmplacement.DataBindings.Add("EmplId", dvlisteempl, "empl_id")
        CBMonumentClasse.DataBindings.Add("Checked", dvlisteempl, "empl_monum_classe")
        FCTBCommentaire.DataBindings.Add("Text", dvlisteempl, "com_commentaire")
        FCTBHistoire.DataBindings.Add("Text", dvlisteempl, "h_histoire")
        CBEmplType.DataBindings.Add("SelectedUnderlyingValue", dvlisteempl, "empl_type")
        FCTBDateDeb.DataBindings.Add("DateValue", dvlisteempl, "con_date_debut") ', True, DataSourceUpdateMode.OnValidation, "", "dd/MM/yyyy")
        FCTBDateFin.DataBindings.Add("DateValue", dvlisteempl, "con_date_fin")
        FCTBNbPlaces.DataBindings.Add("Text", dvlisteempl, "empl_nb_places") ' à voir pour les dbnull
    End Sub

    Private Sub DataBindConsbenef()
        TBconsBenefnom.DataBindings.Add("Text", dvbenefsdeconcession, "ben_nom")
        TBconsBenefprenom.DataBindings.Add("Text", dvbenefsdeconcession, "ben_prenom")
        TBconsBenefadress.DataBindings.Add("Text", dvbenefsdeconcession, "ben_adresse")
        TBconsBenefdatenaiss.DataBindings.Add("DateValue", dvbenefsdeconcession, "ben_date_naiss")
        CtrlLocBenefDeCons.DataBindings.Add("LocVilleId", dvbenefsdeconcession, "locville_id")
    End Sub

    Private Sub DataBindDefunt()
        FPTBNom.DataBindings.Add("Text", dvlistedefunts, "def_nom")
        FPTBPrenom.DataBindings.Add("Text", dvlistedefunts, "def_prenom")
        FPTBDateNaiss.DataBindings.Add("DateValue", dvlistedefunts, "def_date_naiss")
        FPTBAdresse.DataBindings.Add("Text", dvlistedefunts, "def_adresse")
        FPTBDateDeces.DataBindings.Add("DateValue", dvlistedefunts, "def_date_deces")
        FPTBLieuNaiss.DataBindings.Add("Text", dvlistedefunts, "def_lieu_naiss")
        CbDefEmplacement.DataBindings.Add("EmplId", dvlistedefunts, "empl_id")
        CtrlEtatCivDef.DataBindings.Add("EtatCivil", dvlistedefunts, "def_etat_civil")
        CtrlEtatCivDef.DataBindings.Add("EtatCivilDe", dvlistedefunts, "def_etat_civil_de")
        CtrlLocVilleDef.DataBindings.Add("LocVilleId", dvlistedefunts, "locville_id")
    End Sub

    Private Sub DataBindConss()
        TBPersNom.DataBindings.Add("Text", dvCsnrs, "csnr_nom")
        TBPersPrenom.DataBindings.Add("Text", dvCsnrs, "csnr_prenom")
        TBPersAdress.DataBindings.Add("Text", dvCsnrs, "csnr_adresse")
        CtrlLocPersonne.DataBindings.Add("LocVilleId", dvCsnrs, "locville_id")
        TBPersDN.DataBindings.Add("DateValue", dvCsnrs, "csnr_date_naiss")
        TBPersTel.DataBindings.Add("Text", dvCsnrs, "csnr_tel")
        TBPersNumNational.DataBindings.Add("Text", dvCsnrs, "csnr_no_registre")
    End Sub

    Private Sub DataBindBenef()
        TBPersNom.DataBindings.Add("Text", dvbenefs, "ben_nom")
        TBPersPrenom.DataBindings.Add("Text", dvbenefs, "ben_prenom")
        TBPersDN.DataBindings.Add("DateValue", dvbenefs, "ben_date_naiss")
        TBPersLienParente.DataBindings.Add("Text", dvbenefs, "ben_lien_parente")
        TBPersAdress.DataBindings.Add("Text", dvbenefs, "ben_adresse")
        CtrlLocPersonne.DataBindings.Add("LocVilleId", dvbenefs, "locville_id")
    End Sub

    Private Sub DataBindPersContact()
        TBPersNom.DataBindings.Add("Text", dvPersContact, "pc_nom")
        TBPersPrenom.DataBindings.Add("Text", dvPersContact, "pc_prenom")
        TBPersTel.DataBindings.Add("Text", dvPersContact, "pc_tel")
        TBPersAdress.DataBindings.Add("Text", dvPersContact, "pc_adresse")
        CtrlLocPersonne.DataBindings.Add("LocVilleId", dvPersContact, "locville_id")
    End Sub

    Private Sub DataBindClear()
        TBPersNom.DataBindings.Clear()
        TBPersPrenom.DataBindings.Clear()
        TBPersAdress.DataBindings.Clear()
        CtrlLocPersonne.DataBindings.Clear()
        TBPersDN.DataBindings.Clear()
        TBPersTel.DataBindings.Clear()
        TBPersNumNational.DataBindings.Clear()
        TBPersLienParente.DataBindings.Clear()
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


    'Private Sub FPBDetails_Click(sender As Object, e As EventArgs)
    '    Dim FDetails As New FDetails
    '    FDetails.ShowDialog()
    'End Sub



    'Private Sub FPBAjouter_Click(sender As Object, e As EventArgs)

    'End Sub


    'Private Sub FPBRechercher_Click(sender As Object, e As EventArgs)
    '    'If FPCBNom.Checked = True Then
    '    'Dim Source As New BindingSource()
    '    'Source.DataSource = Me.DgvListeDefunts.DataSource
    '    'Source.Filter = "def_nom Like '%" & FPTBRechercher.Text & "%'"
    '    'ElseIf FPCBEmplacement.Checked = True Then

    '    '        ElseIf FPCBDate.Checked = True Then
    '    ' erreur avec les dates
    '    ' Dim Source As New BindingSource()
    '    '  Source.DataSource = Me.DgvListeDefunts.DataSource
    '    '  Source.Filter = "def_date_naiss like '%" & FPTBRechercher.ToString & "%'"

    '    ' ElseIf FPCBDateD.Checked = True Then

    '    ' Else
    '    'MessageBox.Show("Veuillez inserer un choix")
    '    '  End If

    'End Sub


    ' ajoute à une datatable une colonne "masque" qui peut servir pour la recherche/le filtrage
    'Private Sub AjouterColonneMasque(dt As DataTable)
    '    dt.Columns.Add(New DataColumn("masque", GetType(Boolean)))
    'End Sub



    Private Sub BtDefChercher_Click(sender As Object, e As EventArgs) Handles BtDefChercher.Click
        If Not {CBDefChercherNom, CBDefChercherEmplacement, DtpDefRechercherDateDecesApres, DtpDefRechercherDateDecesAvant}.Any(Function(c) c.checked) Then
            dvlistedefunts.RowFilter = ""
            Exit Sub
        End If

        Dim dateavant As Date = DtpDefRechercherDateDecesAvant.Value.Date
        Dim dateapres As Date = DtpDefRechercherDateDecesApres.Value.Date
        Dim Filtre As String = ""
        Dim FiltresChamps As New List(Of String)
        Dim FiltresDates As New List(Of String)
        Dim TxtRech = TbDefChampRecherche.Text.Trim.ToUpper
        ' si au moins un des champs est choisi, le critère "champs" devient nécessaire (il faut que le texte se trouve dans l'un d'eux pour que la ligne soit sélectionnée)
        ' si aucun choix n'est fait, il n'y a pas de filtrage sur les champs
        If CBDefChercherNom.Checked OrElse CBDefChercherEmplacement.Checked Then
            If CBDefChercherNom.Checked Then
                FiltresChamps.Add("(def_nom Like '%" & TxtRech & "%') Or (def_prenom Like '%" & TxtRech & "%')")
            End If
            If CBDefChercherEmplacement.Checked Then
                ' récupère les id des emplacements dont la référence correspond, sous la form (42,19,20)
                Dim IdsEmpls = From r As DataRow In dtcons.Rows Where r("empl_reference").ToUpper Like "*" & TxtRech & "*" Select r("empl_id")
                FiltresChamps.Add(If(IdsEmpls.Count = 0, "False", "(empl_id In (" & String.Join(", ", IdsEmpls) & "))"))
            End If
        End If

        ' filtrage dates
        If DtpDefRechercherDateDecesApres.Checked Then
            FiltresDates.Add("(def_date_deces > #" & Format(dateapres, "M/d/yyyy") & "#)")
        End If
        If DtpDefRechercherDateDecesAvant.Checked Then
            FiltresDates.Add("(def_date_deces < #" & Format(dateavant, "M/d/yyyy") & "#)")
        End If
        Dim FiltresChampsEtDates As New List(Of String)
        If FiltresChamps.Count > 0 Then FiltresChampsEtDates.Add("(" & String.Join(" Or ", FiltresChamps) & ")")
        If FiltresDates.Count > 0 Then FiltresChampsEtDates.Add("(" & String.Join(" And ", FiltresDates) & ")")
        dvlistedefunts.RowFilter = String.Join(" And ", FiltresChampsEtDates)
    End Sub

    Private Sub BtDefAnnulerRecherche_Click(sender As Object, e As EventArgs) Handles BtDefAnnulerRecherche.Click
        dvlistedefunts.RowFilter = ""
        'TbDefChampRecherche.Text = ""
        'DtpDefRechercherDateDecesApres.Checked = False
        'DtpDefRechercherDateDecesAvant.Checked = False
    End Sub

    Private Sub PRBConcessionnaire_CheckedChanged(sender As RadioButton, e As EventArgs) Handles PRBConcessionnaire.CheckedChanged
        If Not sender.Checked Then Exit Sub

        DgvListeConcessionnaireBenef.Hide()
        DgvListeConcessionnairePersonneContact.Hide()
        DgvListeConcessionnaireConcess.Show()

        LabPcontDefAssoc.Hide()
        LabConAssoc.Show()
        LinkLabLienCsnrVersCon.Show()
        LinkLabLienPcontVersDef.Hide()
        LinkLabLienBenVersCon.Hide()

        LabPersDN.Show()
        TBPersDN.Show()
        LabPersTel.Show()
        TBPersTel.Show()
        LabPersNumNational.Show()
        TBPersNumNational.Show()
        LabPersLienParente.Hide()
        TBPersLienParente.Hide()

        DataBindClear()
        DataBindConss()
    End Sub

    Private Sub PRBPersCon_CheckedChanged(sender As RadioButton, e As EventArgs) Handles PRBPersCon.CheckedChanged
        If Not sender.Checked Then Exit Sub
        DgvListeConcessionnaireBenef.Hide()
        DgvListeConcessionnairePersonneContact.Show()
        DgvListeConcessionnaireConcess.Hide()

        LabConAssoc.Hide()
        LabPcontDefAssoc.Show()
        LinkLabLienCsnrVersCon.Hide()
        LinkLabLienPcontVersDef.Show()
        LinkLabLienBenVersCon.Hide()

        LabPersDN.Hide()
        TBPersDN.Hide()
        LabPersTel.Show()
        TBPersTel.Show()
        LabPersNumNational.Hide()
        TBPersNumNational.Hide()
        LabPersLienParente.Hide()
        TBPersLienParente.Hide()

        DataBindClear()
        DataBindPersContact()
    End Sub

    Private Sub PRBBenef_CheckedChanged(sender As RadioButton, e As EventArgs) Handles PRBBenef.CheckedChanged
        If Not sender.Checked Then Exit Sub
        DgvListeConcessionnaireBenef.Show()
        DgvListeConcessionnairePersonneContact.Hide()
        DgvListeConcessionnaireConcess.Hide()

        LabPcontDefAssoc.Hide()
        LabConAssoc.Show()
        LinkLabLienCsnrVersCon.Hide()
        LinkLabLienPcontVersDef.Hide()
        LinkLabLienBenVersCon.Show()

        LabPersDN.Show()
        TBPersDN.Show()
        LabPersTel.Hide()
        TBPersTel.Hide()
        LabPersNumNational.Hide()
        TBPersNumNational.Hide()
        LabPersLienParente.Show()
        TBPersLienParente.Show()

        DataBindClear()
        DataBindBenef()
    End Sub


    Private Sub FCDGConss_SelectionChanged(sender As Object, e As EventArgs) Handles FCDGConss.SelectionChanged

        If FCDGConss.SelectedRows.Count > 0 Then
            Dim EmplSelect = CType(FCDGConss.SelectedRows(0).DataBoundItem, DataRowView).Row

            dvdefuntcons.RowFilter = "empl_id = " & EmplSelect("empl_id")
            ' présuppose que la table des emplacements contient aussi les données de la location
            If Not IsDBNull(EmplSelect("con_id")) Then
                dvbenefsdeconcession.RowFilter = "ben_con_id = " & EmplSelect("con_id")

                Dim Csnr = dtCsnr.Select("csnr_id = " & EmplSelect("csnr_id"))(0)
                LinkLabCsnrDeCsn.Text = Csnr("csnr_prenom") & " " & Csnr("csnr_nom")
                GBInfosCsn.Show()
                GBInfosConsRienAMontrer.Hide()


            Else
                dvbenefsdeconcession.RowFilter = "False"
                GBInfosConsRienAMontrer.Show()
                GBInfosCsn.Hide()
            End If

            FCTBPlaceOccupe.Text = FCDGDefunt.RowCount  '- 1

        Else
            dvbenefsdeconcession.RowFilter = "False"
            dvdefuntcons.RowFilter = "False"
            FCTBPlaceOccupe.Text = ""
            GBInfosConsRienAMontrer.Show()
            GBInfosCsn.Hide()

        End If

    End Sub


    Private Sub BtRechEmpl_Click(sender As Object, e As EventArgs) Handles BtRechEmpl.Click

        If Not {CbfconsCsnr, CbfconsEmplacement, CbfConsOccupants, DtpConsRechercherDateFin, DtpConsRechercherDateFinap}.Any(Function(c) c.Checked) Then
            dvlisteempl.RowFilter = ""
            Exit Sub
        End If

        Dim dateavant As Date = DtpConsRechercherDateFin.Value.Date
        Dim dateapres As Date = DtpConsRechercherDateFinap.Value.Date
        Dim Filtre As String = ""
        Dim FiltresChamps As New List(Of String)
        Dim FiltresDates As New List(Of String)
        Dim TxtRech = FCTBRechercher.Text.Trim.ToUpper

        ' filtrage champs (si au moins un champ est choisi)
        If CbfconsEmplacement.Checked OrElse CbfconsCsnr.Checked OrElse CbfConsOccupants.Checked Then
            If CbfconsCsnr.Checked Then
                ' cherche les id des concessionnaires pouvant correspondre
                Dim IdsCsnrs = From r As DataRow In dtCsnr.Rows Where r("csnr_nom").ToUpper Like "*" & TxtRech & "*" OrElse r("csnr_prenom").ToUpper Like "*" & TxtRech & "*" Select r("csnr_id")
                FiltresChamps.Add(If(IdsCsnrs.Count = 0, "False", "(csnr_id In (" & String.Join(",", IdsCsnrs) & "))"))
            End If
            If CbfConsOccupants.Checked Then
                ' idem pour les occupants
                Dim IdsOccs = (From r As DataRow In dtdefunt.Rows Where Not IsDBNull(r("empl_id")) AndAlso (r("def_nom").ToUpper Like "*" & TxtRech & "*" OrElse r("def_prenom").ToUpper Like "*" & TxtRech & "*") Select r("empl_id")).Distinct
                FiltresChamps.Add(If(IdsOccs.Count = 0, "False", "(empl_id In (" & String.Join(",", IdsOccs) & "))"))
            End If
            If CbfconsEmplacement.Checked Then
                FiltresChamps.Add("(empl_reference Like '%" & TxtRech & "%')")
            End If

        End If

        If DtpConsRechercherDateFin.Checked Then
            FiltresDates.Add("(con_date_fin < #" & Format(dateavant, "M/d/yyyy") & "#)")
        End If
        If DtpConsRechercherDateFinap.Checked Then
            FiltresDates.Add("(con_date_fin > #" & Format(dateapres, "M/d/yyyy") & "#)")
        End If

        Dim FiltresChampsEtDates As New List(Of String)
        If FiltresChamps.Count > 0 Then FiltresChampsEtDates.Add("(" & String.Join(" Or ", FiltresChamps) & ")")
        If FiltresDates.Count > 0 Then FiltresChampsEtDates.Add("(" & String.Join(" And ", FiltresDates) & ")")

        dvlisteempl.RowFilter = String.Join(" And ", FiltresChampsEtDates)

    End Sub

    Private Sub BTCsnAnnulerRecherche_Click(sender As Object, e As EventArgs) Handles BTCsnAnnulerRecherche.Click
        dvlisteempl.RowFilter = ""
        'FCTBRechercher.Text = ""
        'DtpConsRechercherDateFin.Checked = False
        'DtpConsRechercherDateFinap.Checked = False
    End Sub

    Private Sub FPBLienCons_Click(sender As Object, e As EventArgs) Handles FPBLienCons.Click
        If Not DgvListeDefunts.SelectedRows.Count > 0 Then Exit Sub

        Dim Def = DgvListeDefunts.SelectedDataRow
        If IsDBNull(Def("empl_id")) Then Exit Sub

        TabControl1.SelectedTab = TabPage2
        BTCsnAnnulerRecherche_Click(Nothing, Nothing) ' annule le filtrage dans les concessions, celle qu'on veut doit être visible
        Dim ligneaselect = (From r As DataGridViewRow In FCDGConss.Rows Where r.Cells("empl_id").Value = Def("empl_id")).First
        ligneaselect.Selected = True
        FCDGConss.ScrollSelectedIntoView()

        ' sélectionne aussi le défunt dans la liste des défunts de l'emplacement

        ligneaselect = (From r As DataGridViewRow In FCDGDefunt.Rows Where r.Cells("def_id").Value = Def("def_id")).First
        ligneaselect.Selected = True
        FCDGDefunt.ScrollSelectedIntoView()

    End Sub

    'Private Sub FCBLienDefunt_Click(sender As Object, e As EventArgs) Handles FCBLienDefunt.Click
    '    If Not FCDGDefunt.SelectedRows.Count > 0 Then Exit Sub

    '    Dim def = FCDGDefunt.SelectedDataRow

    '    TabControl1.SelectedIndex = 0
    '    BtDefAnnulerRecherche_Click(Nothing, Nothing)
    '    Dim ligneaselect = (From r As DataGridViewRow In DgvListeDefunts.Rows Where r.Cells("def_id").Value = def("def_id")).First
    '    ligneaselect.Selected = True
    '    DgvListeDefunts.ScrollSelectedIntoView()
    'End Sub


    ' lien vers défunt depuis l'onglet emplacements
    Private Sub FCDGDefunt_CellContentClick(sender As DataGridViewCustom, e As DataGridViewCellEventArgs) Handles FCDGDefunt.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        Dim def = CType(FCDGDefunt.Rows(e.RowIndex).DataBoundItem, DataRowView).Row

        'Dim def = FCDGDefunt.SelectedDataRow

        If sender.Columns(e.ColumnIndex).Name = "lien" Then 'OrElse sender.Columns(e.ColumnIndex).Name = "DgvCsnsAbColBtDetails" Then
            TabControl1.SelectedIndex = 0
            BtDefAnnulerRecherche_Click(Nothing, Nothing)
            Dim ligneaselect = (From r As DataGridViewRow In DgvListeDefunts.Rows Where r.Cells("def_id").Value = def("def_id")).First
            ligneaselect.Selected = True
            DgvListeDefunts.ScrollSelectedIntoView()
        End If
    End Sub


    Private Sub FCDGBeneficiaire_CellContentClick(sender As DataGridViewCustom, e As DataGridViewCellEventArgs) Handles FCDGBeneficiaire.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        Dim ben = CType(FCDGBeneficiaire.Rows(e.RowIndex).DataBoundItem, DataRowView).Row
        BTAnnulerRechPers_Click(Nothing, Nothing)
        TabControl1.SelectedTab = TabPage3
        PRBBenef.Checked = True
        Dim ligneaselect = (From r As DataGridViewRow In DgvListeConcessionnaireBenef.Rows Where r.Cells("ben_id").Value = ben("ben_id")).First
        ligneaselect.Selected = True
        DgvListeConcessionnaireBenef.ScrollSelectedIntoView()


    End Sub



    'Private Sub FCBLienBenef_Click(sender As Object, e As EventArgs) Handles FCBLienBenef.Click
    '    If Not FCDGBeneficiaire.SelectedRows.Count > 0 Then Exit Sub

    '    Dim ben = FCDGBeneficiaire.SelectedDataRow

    '    BTAnnulerRechPers_Click(Nothing, Nothing)
    '    TabControl1.SelectedTab = TabPage3
    '    PRBBenef.Checked = True
    '    Dim ligneaselect = (From r As DataGridViewRow In DgvListeConcessionnaireBenef.Rows Where r.Cells("ben_id").Value = ben("ben_id")).First
    '    ligneaselect.Selected = True
    '    DgvListeConcessionnaireBenef.ScrollSelectedIntoView()
    'End Sub

    Private Sub BTLienCsnrVersConcession_Click(sender As Object, e As EventArgs) Handles LinkLabLienCsnrVersCon.Click
        If DgvListeConcessionnaireConcess.SelectedRows.Count = 0 Then Exit Sub

        Dim Csnr = DgvListeConcessionnaireConcess.SelectedDataRow

        BTCsnAnnulerRecherche_Click(Nothing, Nothing)
        TabControl1.SelectedTab = TabPage2
        Dim ligneaselect = (From r As DataGridViewRow In FCDGConss.Rows Where Not IsDBNull(r.Cells("csnr_id").Value) AndAlso r.Cells("csnr_id").Value = Csnr("csnr_id")).FirstOrDefault
        If ligneaselect Is Nothing Then Exit Sub     ' ça ne devrait jamais arriver, mais il est techniquement possible qu'un csnr se trouve en bdd sans concession associée
        ligneaselect.Selected = True
        FCDGConss.ScrollSelectedIntoView()
    End Sub




    Private Sub TextBoxConsRO()
        For Each tb As Object In {FCTBnumero, FCTBNbPlaces, FCTBCommentaire, FCTBHistoire, FCTBDateFin, FCTBDateDeb}
            tb.ReadOnly = True
            tb.Cursor = Cursors.No
            If tb.BackColor <> SystemColors.Window Then tb.BackColor = SystemColors.Window
        Next

        CBEmplType.Enabled = False
        CBEmplType.Cursor = Cursors.No

        CBMonumentClasse.Enabled = False
        CBMonumentClasse.Cursor = Cursors.No

        '''''CbConsEmplacement.LectureSeule = True
        CbConsEmplacement.Enabled = False
        CbConsEmplacement.Cursor = Cursors.No
    End Sub

    Private Sub TextBoxBenefDeConsRO()
        For Each tb As Object In {TBconsBenefprenom, TBconsBenefnom, TBconsBenefadress, TBconsBenefdatenaiss}
            tb.ReadOnly = True
            tb.Cursor = Cursors.No
            If tb.BackColor <> SystemColors.Window Then tb.BackColor = SystemColors.Window
        Next
        CtrlLocBenefDeCons.LectureSeule = True
    End Sub


    Private Sub TextBoxDefuntRO()

        For Each tb As Object In {FPTBNom, FPTBPrenom, FPTBAdresse, FPTBDateNaiss, FPTBDateDeces, FPTBLieuNaiss}
            tb.ReadOnly = True
            tb.Cursor = Cursors.No
            If tb.BackColor <> SystemColors.Window Then tb.BackColor = SystemColors.Window

        Next

        'CbDefEmplacement.LectureSeule = True
        CbDefEmplacement.Enabled = False
        CbDefEmplacement.Cursor = Cursors.No
    End Sub

    Private Sub TextBoxPersRO()
        TBPersNom.ReadOnly = True
        TBPersNom.Cursor = Cursors.No
        If TBPersNom.BackColor <> SystemColors.Window Then TBPersNom.BackColor = SystemColors.Window
        TBPersNumNational.ReadOnly = True
        TBPersNumNational.Cursor = Cursors.No
        If TBPersNumNational.BackColor <> SystemColors.Window Then TBPersNumNational.BackColor = SystemColors.Window
        TBPersPrenom.ReadOnly = True
        TBPersPrenom.Cursor = Cursors.No
        If TBPersPrenom.BackColor <> SystemColors.Window Then TBPersPrenom.BackColor = SystemColors.Window
        TBPersTel.ReadOnly = True
        TBPersTel.Cursor = Cursors.No
        If TBPersTel.BackColor <> SystemColors.Window Then TBPersTel.BackColor = SystemColors.Window
        TBPersDN.ReadOnly = True
        TBPersDN.Cursor = Cursors.No
        If TBPersDN.BackColor <> SystemColors.Window Then TBPersDN.BackColor = SystemColors.Window
        TBPersAdress.ReadOnly = True
        TBPersAdress.Cursor = Cursors.No
        If TBPersAdress.BackColor <> SystemColors.Window Then TBPersAdress.BackColor = SystemColors.Window
    End Sub

    Private Sub TextBoxPersUpd()
        TBPersNom.ReadOnly = False
        TBPersNom.Cursor = Cursors.IBeam
        TBPersNumNational.ReadOnly = False
        TBPersNumNational.Cursor = Cursors.IBeam
        TBPersPrenom.ReadOnly = False
        TBPersPrenom.Cursor = Cursors.IBeam
        TBPersTel.ReadOnly = False
        TBPersTel.Cursor = Cursors.IBeam
        TBPersDN.ReadOnly = False
        TBPersDN.Cursor = Cursors.IBeam
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
        'CbDefEmplacement.LectureSeule = False
        CbDefEmplacement.Cursor = Cursors.IBeam
        FPTBDateNaiss.ReadOnly = False
        FPTBDateNaiss.Cursor = Cursors.IBeam
        FPTBDateDeces.ReadOnly = False
        FPTBDateDeces.Cursor = Cursors.IBeam
        FPTBAdresse.ReadOnly = False
        FPTBAdresse.Cursor = Cursors.IBeam
    End Sub

    Private Sub TextBoxConsUpd()
        FCTBnumero.ReadOnly = False
        FCTBnumero.Cursor = Cursors.IBeam
        FCTBNbPlaces.ReadOnly = False
        FCTBNbPlaces.Cursor = Cursors.IBeam
        'FCTBPlaceOccupe.ReadOnly = False
        'FCTBPlaceOccupe.Cursor = Cursors.IBeam
        'CBEmplType.Enabled = True
        CBEmplType.Cursor = Cursors.IBeam
        CBMonumentClasse.Enabled = True
        'CBMonumentClasse.Cursor = Cursors.IBeam
        FCTBHistoire.ReadOnly = False
        FCTBHistoire.Cursor = Cursors.IBeam
        ''''CbConsEmplacement.LectureSeule = False
        CbConsEmplacement.Enabled = True
        CbConsEmplacement.Cursor = Cursors.IBeam
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
        TBconsBenefprenom.ReadOnly = False
        TBconsBenefprenom.Cursor = Cursors.IBeam
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
                ''TextBoxConsRO()
                TextBoxBenefDeConsRO()
                TabControl1.TabPages(0).Enabled = True
                TabControl1.TabPages(2).Enabled = True
            ElseIf result = DialogResult.Yes Then
                boutongestion = 0
                BmodifConsBenef.Text = "Modifier"
                ''TextBoxConsRO()
                TextBoxBenefDeConsRO()
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
        If Not DgvListeDefunts.SelectedRows.Count > 0 Then Exit Sub

        Dim Def = DgvListeDefunts.SelectedDataRow
        If IsDBNull(Def("pc_id")) Then Exit Sub

        BTAnnulerRechPers_Click(Nothing, Nothing)
        TabControl1.SelectedTab = TabPage3
        PRBPersCon.Select()

        Dim ligneaselect = (From r As DataGridViewRow In DgvListeConcessionnairePersonneContact.Rows Where r.Cells("pc_id").Value = Def("pc_id")).First
        ligneaselect.Selected = True
        DgvListeConcessionnairePersonneContact.ScrollSelectedIntoView()
    End Sub

    Private Sub FDBLinkToConcessionnaire_Click(sender As Object, e As EventArgs) Handles LinkLabCsnrDeCsn.Click
        If FCDGConss.SelectedRows.Count = 0 Then Exit Sub

        Dim Csn = FCDGConss.SelectedDataRow
        If IsDBNull(Csn("con_id")) Then Exit Sub

        BTAnnulerRechPers_Click(Nothing, Nothing)
        TabControl1.SelectedTab = TabPage3
        PRBConcessionnaire.Select()

        Dim ligneaselect = (From r As DataGridViewRow In DgvListeConcessionnaireConcess.Rows Where r.Cells("csnr_id").Value = Csn("csnr_id")).First
        ligneaselect.Selected = True
        DgvListeConcessionnaireConcess.ScrollSelectedIntoView()
    End Sub

    Private Sub BTChercherPersonne_Click(sender As Object, e As EventArgs) Handles BTChercherPersonne.Click
        Dim TxtRech = FPersonneTbSearch.Text.Trim
        For Each i In {New With {.dv = dvbenefs, .cn = "ben_nom", .cp = "ben_prenom"}, New With {.dv = dvCsnrs, .cn = "csnr_nom", .cp = "csnr_prenom"}, New With {.dv = dvPersContact, .cn = "pc_nom", .cp = "pc_prenom"}}
            i.dv.RowFilter = i.cn & " Like '%" & TxtRech & "%' Or " & i.cp & " Like '%" & TxtRech & "%'"
        Next
    End Sub

    Private Sub BTAnnulerRechPers_Click(sender As Object, e As EventArgs) Handles BTAnnulerRechPers.Click
        dvbenefs.RowFilter = ""
        dvCsnrs.RowFilter = ""
        dvPersContact.RowFilter = ""
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

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is TabPage3 Then
            If Not (PRBBenef.Checked OrElse PRBConcessionnaire.Checked OrElse PRBPersCon.Checked) Then
                PRBConcessionnaire.Checked = True
            End If
        End If
    End Sub

    Private Sub BTLienPcontVersDef_Click(sender As Object, e As EventArgs) Handles LinkLabLienPcontVersDef.Click
        If DgvListeConcessionnairePersonneContact.SelectedRows.Count = 0 Then Exit Sub

        Dim Pcont = DgvListeConcessionnairePersonneContact.SelectedDataRow

        BtDefAnnulerRecherche_Click(Nothing, Nothing)
        TabControl1.SelectedTab = TabPage1
        Dim ligneaselect = (From r As DataGridViewRow In DgvListeDefunts.Rows Where Not IsDBNull(r.Cells("pc_id").Value) AndAlso r.Cells("pc_id").Value = Pcont("pc_id")).FirstOrDefault
        If ligneaselect Is Nothing Then Exit Sub

        ligneaselect.Selected = True
        DgvListeDefunts.ScrollSelectedIntoView()
    End Sub

    Private Sub BTLienBenefVersConcession_Click(sender As Object, e As EventArgs) Handles LinkLabLienBenVersCon.Click
        If Not DgvListeConcessionnaireBenef.SelectedRows.Count > 0 Then Exit Sub

        Dim ben = DgvListeConcessionnaireBenef.SelectedDataRow
        If IsDBNull(ben("ben_con_id")) Then Exit Sub      ' il ne devrait pas y avoir de bénéficiaires sans concession, mais c'est techniquement possible même si anormal

        BTCsnAnnulerRecherche_Click(Nothing, Nothing)
        TabControl1.SelectedTab = TabPage2
        Dim ligneaselect = (From r As DataGridViewRow In FCDGConss.Rows Where Not IsDBNull(r.Cells("con_id").Value) AndAlso r.Cells("con_id").Value = ben("ben_con_id")).First
        ligneaselect.Selected = True
        FCDGConss.ScrollSelectedIntoView()

        ' + sélection dans la liste des bénefs de l'emplacement
        ligneaselect = (From r As DataGridViewRow In FCDGBeneficiaire.Rows Where r.Cells("ben_id").Value = ben("ben_id")).First
        ligneaselect.Selected = True
        FCDGBeneficiaire.ScrollSelectedIntoView()

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


    Private Sub FCDGDefunt_CellPainting(sender As DataGridView, e As DataGridViewCellPaintingEventArgs) Handles FCDGDefunt.CellPainting, FCDGBeneficiaire.CellPainting
        ' https://stackoverflow.com/a/36253883

        If e.RowIndex < 0 Then Exit Sub             ' -1 = en-tête de colonne

        Dim Dessiner As Boolean = False

        Dim LaCol As DataGridViewColumn
        Dim NomCol As String
        LaCol = sender.Columns(e.ColumnIndex)
        NomCol = LaCol.Name

        If NomCol = "lien" Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim w = My.Resources.Next_16xMD.Width
            Dim h = My.Resources.Next_16xMD.Height
            Dim x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2
            Dim y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2

            e.Graphics.DrawImage(My.Resources.Next_16xMD, New Rectangle(x, y, w, h))
            e.Handled = True
        End If

    End Sub


    Private Sub DgvListeConcessionnaireConcess_SelectionChanged(sender As Object, e As EventArgs) Handles DgvListeConcessionnaireConcess.SelectionChanged
        If Not DgvListeConcessionnaireConcess.Visible Then Exit Sub

        If DgvListeConcessionnaireConcess.SelectedRows.Count = 0 Then
            LinkLabLienCsnrVersCon.Text = "/"
        Else
            Dim Csns = dtcons.Select("csnr_id = " & DgvListeConcessionnaireConcess.SelectedDataRow("csnr_id"))

            If Csns.Count = 0 Then
                LinkLabLienCsnrVersCon.Text = "/"
            Else
                LinkLabLienCsnrVersCon.Text = Csns(0)("empl_reference")
            End If
        End If
    End Sub

    Private Sub DgvListeConcessionnairePersonneContact_SelectionChanged(sender As Object, e As EventArgs) Handles DgvListeConcessionnairePersonneContact.SelectionChanged
        If Not DgvListeConcessionnairePersonneContact.Visible Then Exit Sub
        If DgvListeConcessionnairePersonneContact.SelectedRows.Count = 0 Then
            LinkLabLienPcontVersDef.Text = "/"
        Else
            Dim Defs = dtdefunt.Select("pc_id = " & DgvListeConcessionnairePersonneContact.SelectedDataRow("pc_id"))
            If Defs.Count = 0 Then
                LinkLabLienPcontVersDef.Text = "/"
            Else
                LinkLabLienPcontVersDef.Text = Defs(0)("def_prenom") & " " & Defs(0)("def_nom")
            End If
        End If
    End Sub

    Private Sub DgvListeConcessionnaireBenef_SelectionChanged(sender As Object, e As EventArgs) Handles DgvListeConcessionnaireBenef.SelectionChanged
        If Not DgvListeConcessionnaireBenef.Visible Then Exit Sub
        If DgvListeConcessionnaireBenef.SelectedRows.Count = 0 Then
            LinkLabLienBenVersCon.Text = "/"
        Else
            Dim Csns = dtcons.Select("con_id = " & DgvListeConcessionnaireBenef.SelectedDataRow("ben_con_id"))
            If Csns.Count = 0 Then
                LinkLabLienBenVersCon.Text = "/"
            Else
                LinkLabLienBenVersCon.Text = Csns(0)("empl_reference")
            End If
        End If
    End Sub


    Private Sub FPersonneTbSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles FPersonneTbSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            BTChercherPersonne_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub FCTBRechercher_KeyDown(sender As Object, e As KeyEventArgs) Handles FCTBRechercher.KeyDown, CbfconsEmplacement.KeyDown, CbfconsCsnr.KeyDown, CbfConsOccupants.KeyDown, DtpConsRechercherDateFin.KeyDown, DtpConsRechercherDateFinap.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtRechEmpl_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub TbDefChampRecherche_KeyDown(sender As Object, e As KeyEventArgs) Handles TbDefChampRecherche.KeyDown, CBDefChercherNom.KeyDown, CBDefChercherEmplacement.KeyDown, DtpDefRechercherDateDecesApres.KeyDown, DtpDefRechercherDateDecesAvant.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtDefChercher_Click(Nothing, Nothing)
        End If
    End Sub
End Class
