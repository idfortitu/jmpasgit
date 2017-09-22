Imports System.IO
Public Class FormGestion
    Public dtdefunt As DataTable
    Public dtempls As DataTable
    Public dtcons As DataTable
    Public dtCsnr As DataTable
    Public dtbenef As DataTable
    Public dtPersContact As DataTable
    Public dtville As DataTable
    Public dtpays As DataTable
    Public dtcommentaires As DataTable
    Public dthistoires As DataTable

    'Public dvlistedefunts As DataView
    Public bslistedefunts As BindingSource
    Public dvlisteempl As DataView
    Public dvcons As DataView
    Public dvCsnrs As DataView
    Public dvbenefs As DataView
    Public dvPersContact As DataView



    Public dvbenefsdeconcession As DataView
    Public dvdefuntempl As DataView
    Public dvconsdeempl As DataView

    Dim FormPlan As FormChoixEmplSurPlan

    Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
    Dim ModeEdition As Boolean = False



    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        If user = "User" Then
            FPBModifier.Hide()
            FPBSupprimer.Hide()
            BModifGestionPers.Hide()
            BTModifEmpl.Hide()
            BSupGestionPers.Hide()
            BTSupprEmpl.Hide()
            FPBAjouter.Hide()
            BTSupprCons.Hide()
            BTModifCons.Hide()
            BTConsAjout.Hide()
            BModifGestionPers.Hide()
            BSupGestionPers.Hide()
            BtGererVilles.Hide()
            BTConAjoutBen.Hide()
        End If

        TextBoxDefuntRO()
        TextBoxEmplRO()
        'TextBoxBenefDeConsRO()
        TextBoxPersRO()
        TextBoxConcessRO()
        Panel10.Hide()
        Panel3.Hide()
        Panel1.Hide()
        TabControl1.Hide()
        Me.Size = New Size(820, 150)
        Me.Left = (screenWidth - Me.Width) / 2
        Me.Top = (screenHeight - Me.Height) / 2
        Lchargementdonnee.Text = "Chargement des données"


    End Sub

    Private Sub ChargerVillesPays()
        dtville = Bdd.GetTable("t_loc_ville", "locville_ville")
        dtpays = Bdd.GetTable("t_Pays", "Pays_nom")
        CtrlLocVilleDef.chargercomboboxpays(dtpays)
        CtrlLocVilleDef.chargercomboboxville(dtville)
        CtrlLocPersonne.chargercomboboxville(dtville)
        CtrlLocPersonne.chargercomboboxpays(dtpays)

    End Sub

    Private Sub Form1_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Dim AAppeler = New List(Of Action)({AddressOf DataTableConcessions, AddressOf DataTableDefunt, AddressOf DataTableConcessionnaires, AddressOf DataTableEmplacements, AddressOf DataTablePersContact, AddressOf DataTableBeneficiaire, AddressOf DataTableDivers})
        Dim Pas = 100 / AAppeler.Count
        Dim Chrg As Integer = 0
        Lchargementdonnee.Text = "Chargement des données"
        For Each a In AAppeler
            a()
            Chrg += Pas
            ProgressBar.Increment(Chrg)
            Lchargementdonnee.Text &= " ."
            'Threading.Thread.Sleep(500)

        Next

        'ProgressBar.Increment(10)
        'DataTableDefunt() '1
        'ProgressBar.Increment(25)
        'Lchargementdonnee.Text = "Chargement des données ."
        ''Threading.Thread.Sleep(500)
        'DataTableConcessionnaires() '2
        'ProgressBar.Increment(40)
        'Lchargementdonnee.Text = "Chargement des données . ."
        ''Threading.Thread.Sleep(500)
        'DataTableEmplacements() '2
        'ProgressBar.Increment(55)
        'Lchargementdonnee.Text = "Chargement des données . . ."
        ''Threading.Thread.Sleep(500)
        'DataTablePersContact()
        'ProgressBar.Increment(70)
        ''Threading.Thread.Sleep(500)
        'DataTableBeneficiaire()

        'dtville = GetTable("t_loc_ville")
        'dtpays = GetTable("t_pays")

        'ProgressBar.Increment(85)
        ''Threading.Thread.Sleep(500)


        DgvListeConcessionnaireBenef.Show()
        DgvListeConcessionnairePersonneContact.Hide()
        DgvListeConcessionnaireConcess.Hide()
        'ProgressBar.Increment(100)
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
        dtdefunt = Bdd.Query("SELECT defunts.*, emplacements.empl_reference, IFNULL(CONCAT(pc_prenom,' ',pc_nom),'-') AS pc_nomcomplet FROM defunts LEFT OUTER JOIN emplacements ON defunts.empl_id = emplacements.empl_id LEFT OUTER JOIN personnes_contact ON personnes_contact.pc_id = defunts.pc_id")
        'dtdefunt.CaseSensitive = False
        'AjouterColonneMasque(dtdefunt)

        ' grille principale des défunts
        'dvlistedefunts = New DataView(dtdefunt)
        bslistedefunts = New BindingSource()
        'bslistedefunts.DataSource = dvlistedefunts
        bslistedefunts.DataSource = dtdefunt


        InitDgvDefunts()
        DgvListeDefunts.DataSource = bslistedefunts

        ' infos du défunt sélectionné
        DataBindDefunt()

        ' grille des défunts de l'emplacement sélectionné
        dvdefuntempl = New DataView(dtdefunt)
        InitDgvDefuntsDeEmpl()
        FCDGDefunt.DataSource = dvdefuntempl

    End Sub

    ' met à jour la colonne référence de l'emplacement après une modif
    ' à tester
    Sub UpdateInfosDataTableDefunts(RowsAUpd As ICollection(Of DataRow))
        For Each r As DataRow In RowsAUpd
            If IsDBNull(r("empl_id")) Then
                r("empl_reference") = DBNull.Value
            Else
                Dim Empls = dtempls.Select("empl_id = " & r("empl_id"))
                If Empls.Count = 0 Then
                    r("empl_reference") = DBNull.Value
                Else
                    r("empl_reference") = Empls(0)("empl_reference")
                End If
            End If
            If IsDBNull(r("pc_id")) Then
                r("pc_nomcomplet") = "-"
            Else
                Dim Pcs = dtPersContact.Select("pc_id = " & r("pc_id"))
                If Pcs.Count = "0" Then
                    r("pc_nomcomplet") = "-"
                Else
                    r("pc_nomcomplet") = Pcs(0)("pc_prenom") & " " & Pcs(0)("pc_nom")
                End If
            End If
        Next
    End Sub

    Sub UpdateInfosDataTableDefunts()
        UpdateInfosDataTableDefunts((From r In dtdefunt.Rows).ToList)
    End Sub
    Sub UpdateInfosDataTableDefunts(Def As DataRow)
        UpdateInfosDataTableDefunts(New List(Of DataRow)({Def}))
    End Sub
    Sub UpdateInfosDataTableDefunts(IdDef As Integer)
        UpdateInfosDataTableDefunts(dtdefunt.Select("def_id = " & IdDef))
    End Sub


    Sub UpdateInfosRowsDataTableConcessions(RowsAUpd As ICollection(Of DataRow))
        For Each r In RowsAUpd
            Dim empls = dtempls.Select("empl_id = " & r("empl_id"))
            r("empl_reference") = empls(0)("empl_reference")
            Dim Csnrs = dtCsnr.Select("csnr_id = " & r("csnr_id"))
            r("csnr_nomcomplet") = Csnrs(0)("csnr_prenom") & " " & Csnrs(0)("csnr_nom")
            If IsDBNull(r("com_id")) Then
                r("com_commentaire") = ""
            Else
                Dim Coms = dtcommentaires.Select("com_id = " & r("com_id"))
                If Coms.Count = 0 Then
                    r("com_commentaire") = ""
                Else
                    r("com_commentaire") = Coms(0)("com_commentaire")
                End If
            End If
        Next
    End Sub

    Sub UpdateInfosDataTableConcessions(Csn As DataRow)
        UpdateInfosRowsDataTableConcessions(New List(Of DataRow)({Csn}))
    End Sub

    Sub UpdateInfosDataTableEmplacements(RowsAUpd As ICollection(Of DataRow))
        For Each r In RowsAUpd
            If IsDBNull(r("hist_id")) Then
                r("h_histoire") = ""
            Else
                Dim Hists = dthistoires.Select("h_id = " & r("hist_id"))
                If Hists.Count = 0 Then
                    r("h_histoire") = ""
                Else
                    r("h_histoire") = Hists(0)("h_histoire")
                End If
            End If
            Dim RowsConsActu = dtcons.Select("empl_id = " & r("empl_id") & " And con_date_fin >= #" & Format(Today, "M/d/yyyy") & " 00:00:00 AM# And con_date_debut <= #" & Format(Today, "M/d/yyyy") & " 11:59:59 PM#")
            If RowsConsActu.Count = 0 Then
                r("con_actuelle_id") = DBNull.Value
            Else
                r("con_actuelle_id") = RowsConsActu(0)("con_id")
            End If
        Next
    End Sub

    Sub UpdateInfosDataTableEmplacements(Empl As DataRow)
        UpdateInfosDataTableEmplacements(New List(Of DataRow)({Empl}))
    End Sub

    Sub UpdateInfosDataTableEmplacements(IdEmpl As Integer)
        UpdateInfosDataTableEmplacements(dtempls.Select("empl_id = " & IdEmpl))
    End Sub

    Private Sub InitDgvDefunts()
        Dim DTGV_Id_Colonne = New DataGridViewTextBoxColumn()
        Dim ColonnePrenom = New DataGridViewTextBoxColumn()
        Dim colonneid = New DataGridViewTextBoxColumn()
        Dim colonnepc = New DataGridViewTextBoxColumn()
        Dim colonneref = New DataGridViewTextBoxColumn()
        Dim colonnedatedec = New DataGridViewTextBoxColumn()
        DTGV_Id_Colonne.DataPropertyName = "def_nom"
        DTGV_Id_Colonne.HeaderText = "Nom"
        DTGV_Id_Colonne.Name = "def_nom"
        DTGV_Id_Colonne.FillWeight = 100
        DgvListeDefunts.Columns.Add(DTGV_Id_Colonne)

        ColonnePrenom.DataPropertyName = "def_prenom"
        ColonnePrenom.HeaderText = "prenom"
        ColonnePrenom.Name = "def_prenom"
        ColonnePrenom.FillWeight = 100
        DgvListeDefunts.Columns.Add(ColonnePrenom)

        colonneref.DataPropertyName = "empl_reference"
        colonneref.HeaderText = "Emplacement"
        colonneref.Name = "empl_reference"
        colonneref.FillWeight = 60
        DgvListeDefunts.Columns.Add(colonneref)

        colonneid.DataPropertyName = "def_id"
        colonneid.HeaderText = "id"
        colonneid.Name = "def_id"
        colonneid.Visible = False
        DgvListeDefunts.Columns.Add(colonneid)

        colonnepc.DataPropertyName = "pc_id"
        colonnepc.HeaderText = "id"
        colonnepc.Name = "pc_id"
        colonnepc.Visible = False
        DgvListeDefunts.Columns.Add(colonnepc)

        colonnedatedec.DataPropertyName = "def_date_deces"
        colonnedatedec.HeaderText = "Date de décès"
        colonnedatedec.Name = "def_date_deces"
        colonnedatedec.FillWeight = 80
        DgvListeDefunts.Columns.Add(colonnedatedec)


        DgvListeDefunts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvListeDefunts.AutoGenerateColumns = False
    End Sub

    Private Sub InitDgvDefuntsDeEmpl()
        Dim DTGV_Id_Colonne_def = New DataGridViewTextBoxColumn()
        DTGV_Id_Colonne_def.DataPropertyName = "def_nom"
        DTGV_Id_Colonne_def.HeaderText = "nom"
        DTGV_Id_Colonne_def.Name = "def_nom"
        FCDGDefunt.Columns.Add(DTGV_Id_Colonne_def)

        Dim Colonne = New DataGridViewTextBoxColumn()
        Colonne.DataPropertyName = "def_prenom"
        Colonne.HeaderText = "prenom"
        Colonne.Name = "def_prenom"
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

    Sub DataTableConcessionnaires() '2
        'dtCsnr = Bdd.Query("select * FROM concessionnaires LEFT OUTER JOIN t_loc_ville ON concessionnaires.locville_id = t_loc_ville.locville_id LEFT OUTER JOIN t_pays ON t_loc_ville.Pays_id = t_pays.Pays_id")
        dtCsnr = Bdd.Query("select * FROM concessionnaires")

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


    Sub DataTableEmplacements() '2
        dtempls = Bdd.Query("SELECT emplacements.*, t_histoire.h_histoire, MAX(concessions.con_id) AS con_actuelle_id FROM emplacements LEFT OUTER JOIN t_histoire ON emplacements.hist_id = t_histoire.h_id LEFT OUTER JOIN concessions ON concessions.empl_id = emplacements.empl_id AND con_date_debut <= CURDATE() AND con_date_fin >= CURDATE() GROUP BY emplacements.empl_id")

        ' datagridview des emplacements

        dvlisteempl = New DataView(dtempls)
        InitDgvEmplacements()
        DgvEmplacements.DataSource = dvlisteempl

        ' infos de l'emplacement affiché
        DataBindEmplInfos()
    End Sub

    Private Sub InitDgvEmplacements()
        'Dim ColonnePrenom = New DataGridViewTextBoxColumn()
        Dim col As DataGridViewTextBoxColumn
        'Dim colonnecsnr = New DataGridViewTextBoxColumn()
        'Dim colonneemplid = New DataGridViewTextBoxColumn()

        'Dim DTGV_Id_Colonne = New DataGridViewTextBoxColumn()
        'DTGV_Id_Colonne.DataPropertyName = "con_numero"
        'DTGV_Id_Colonne.HeaderText = "numero"
        'DTGV_Id_Colonne.Name = "con_numero"
        'DgvEmplacements.Columns.Add(DTGV_Id_Colonne)

        col = New DataGridViewTextBoxColumn()
        col.DataPropertyName = "empl_id"
        col.Name = "empl_id"
        col.Visible = False
        DgvEmplacements.Columns.Add(col)

        col = New DataGridViewTextBoxColumn()
        col.DataPropertyName = "empl_reference"
        col.HeaderText = "Référence"
        col.Name = "empl_reference"
        DgvEmplacements.Columns.Add(col)

        col = New DataGridViewTextBoxColumn()
        col.DataPropertyName = "empl_type"
        col.HeaderText = "Type"
        col.Name = "empl_type"
        DgvEmplacements.Columns.Add(col)

        col = New DataGridViewTextBoxColumn
        col.DataPropertyName = "con_actuelle_id"
        col.HeaderText = "Loué"
        col.Name = "con_actuelle_id"
        DgvEmplacements.Columns.Add(col)


        DgvEmplacements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        DgvEmplacements.AutoGenerateColumns = False

    End Sub

    Sub DataTableBeneficiaire()
        ' intègre déjà l'id de la concession (ben_con_id) pour usage futur
        'dtbenef = Query("SELECT *, beneficier.con_id AS ben_con_id FROM beneficiaires LEFT OUTER JOIN t_loc_ville ON beneficiaires.locville_id = t_loc_ville.locville_id LEFT OUTER JOIN t_pays ON t_loc_ville.Pays_id = t_pays.Pays_id INNER JOIN beneficier ON beneficier.ben_id = beneficiaires.ben_id")
        dtbenef = Query("SELECT beneficiaires.*, beneficier.con_id AS ben_con_id FROM beneficiaires INNER JOIN beneficier ON beneficier.ben_id = beneficiaires.ben_id")
        'AjouterColonneMasque(dtbenef)

        'datagridview tous bénéficiaires

        dvbenefs = New DataView(dtbenef)
        InitDgvBeneficiaires()
        DgvListeConcessionnaireBenef.DataSource = dvbenefs


        ' datagridview des bénéficiaires de la concession sélectionnée

        dvbenefsdeconcession = New DataView(dtbenef)
        InitDgvBeneficiairesDeConcession()
        FCDGBeneficiaire.DataSource = dvbenefsdeconcession

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

        Dim colonnesuppr = New DataGridViewButtonColumn
        colonnesuppr.Name = "suppr"
        colonnesuppr.HeaderText = ""
        colonnesuppr.FillWeight = 30
        FCDGBeneficiaire.Columns.Add(colonnesuppr)

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

    Sub DataTableDivers()
        dtville = GetTable("t_loc_ville")
        dtpays = GetTable("t_pays")
        dtcommentaires = GetTable("t_commentaire")
        dthistoires = GetTable("t_histoire")
        ChargerVillesPays()


    End Sub

    Sub DataTablePersContact()
        'dtPersContact = Query("SELECT * FROM personnes_contact LEFT OUTER JOIN t_loc_ville ON personnes_contact.locville_id = t_loc_ville.locville_id LEFT OUTER JOIN t_pays ON t_loc_ville.Pays_id = t_pays.Pays_id")
        dtPersContact = Query("SELECT * FROM personnes_contact")

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

    End Sub


    Private Sub DataTableConcessions()
        dtcons = Query("SELECT concessions.*, t_commentaire.com_commentaire, emplacements.empl_reference, CONCAT(csnr_prenom,' ',csnr_nom) AS csnr_nomcomplet FROM concessions INNER JOIN concessionnaires ON concessions.csnr_id = concessionnaires.csnr_id INNER JOIN emplacements ON emplacements.empl_id = concessions.empl_id LEFT OUTER JOIN t_commentaire ON t_commentaire.com_id = concessions.com_id ORDER BY con_date_fin ASC")

        ' liste principale des concessions
        dvcons = New DataView(dtcons)
        InitDgvConcessions()
        DgvConcessions.DataSource = dvcons

        ' liste des concessions de l'emplacement sélectionné
        dvconsdeempl = New DataView(dtcons)
        InitDgvConsDeEmpl()
        DgvCsnsDeEmpl.DataSource = dvconsdeempl

        ' contrôles
        DataBindConcessions()

    End Sub

    Private Sub InitDgvConcessions()
        Dim Col As New DataGridViewTextBoxColumn
        Col.Name = "con_id"
        Col.DataPropertyName = "con_id"
        Col.Visible = False
        DgvConcessions.Columns.Add(Col)

        Col = New DataGridViewTextBoxColumn
        Col.Name = "csnr_id"
        Col.DataPropertyName = "csnr_id"
        Col.Visible = False
        DgvConcessions.Columns.Add(Col)

        Col = New DataGridViewTextBoxColumn
        Col.Name = "csnr_nomcomplet"
        Col.DataPropertyName = "csnr_nomcomplet"
        Col.HeaderText = "Concessionnaire"
        Col.FillWeight = 120
        DgvConcessions.Columns.Add(Col)

        Col = New DataGridViewTextBoxColumn
        Col.Name = "con_date_debut"
        Col.DataPropertyName = "con_date_debut"
        Col.HeaderText = "Début"
        Col.FillWeight = 70
        DgvConcessions.Columns.Add(Col)

        Col = New DataGridViewTextBoxColumn
        Col.Name = "con_date_fin"
        Col.DataPropertyName = "con_date_fin"
        Col.HeaderText = "Fin"
        Col.FillWeight = 70
        DgvConcessions.Columns.Add(Col)

        Col = New DataGridViewTextBoxColumn
        Col.Name = "empl_reference"
        Col.DataPropertyName = "empl_reference"
        Col.HeaderText = "Emplacement"
        Col.FillWeight = 50
        DgvConcessions.Columns.Add(Col)

        DgvConcessions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvConcessions.AutoGenerateColumns = False

    End Sub


    Private Sub InitDgvConsDeEmpl()
        Dim Col As New DataGridViewTextBoxColumn
        Col.Name = "con_id"
        Col.DataPropertyName = "con_id"
        Col.Visible = False
        DgvCsnsDeEmpl.Columns.Add(Col)

        'Col = New DataGridViewTextBoxColumn
        'Col.Name = "empl_reference"
        'Col.DataPropertyName = "empl_reference"
        'Col.HeaderText = "Emplacement"
        'Col.FillWeight = 80
        'DgvCsnsDeEmpl.Columns.Add(Col)


        Col = New DataGridViewTextBoxColumn
        Col.Name = "csnr_nomcomplet"
        Col.DataPropertyName = "csnr_nomcomplet"
        Col.HeaderText = "Concessionnaire"
        Col.FillWeight = 170
        DgvCsnsDeEmpl.Columns.Add(Col)

        Col = New DataGridViewTextBoxColumn
        Col.Name = "con_date_debut"
        Col.DataPropertyName = "con_date_debut"
        Col.HeaderText = "Début"
        Col.FillWeight = 125
        DgvCsnsDeEmpl.Columns.Add(Col)

        Col = New DataGridViewTextBoxColumn
        Col.Name = "con_date_fin"
        Col.DataPropertyName = "con_date_fin"
        Col.HeaderText = "Fin"
        Col.FillWeight = 125
        DgvCsnsDeEmpl.Columns.Add(Col)

        Dim ColBtn = New DataGridViewButtonColumn
        ColBtn.Name = "lien"
        ColBtn.HeaderText = ""
        ColBtn.FillWeight = 60
        DgvCsnsDeEmpl.Columns.Add(ColBtn)

        DgvCsnsDeEmpl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvCsnsDeEmpl.AutoGenerateColumns = False

    End Sub


    Private Sub DataBindEmplInfos()
        CBMonumentClasse.DataBindings.Add("Checked", dvlisteempl, "empl_monum_classe")
        FCTBHistoire.DataBindings.Add("Text", dvlisteempl, "h_histoire")
        CBEmplType.DataBindings.Add("SelectedUnderlyingValue", dvlisteempl, "empl_type")
        FCTBNbPlaces.DataBindings.Add("Text", dvlisteempl, "empl_nb_places") ' à voir pour les dbnull
    End Sub

    Private Sub DataBindConcessions()
        FCTBDateFin.DataBindings.Add("DateValue", dvcons, "con_date_fin")
        FCTBDateDeb.DataBindings.Add("DateValue", dvcons, "con_date_debut")
        FCTBCommentaire.DataBindings.Add("Text", dvcons, "com_commentaire")
        FCTBMontantPaye.DataBindings.Add("Text", dvcons, "con_montant_paye")
        CBConEmpl.DataBindings.Add("EmplId", dvcons, "empl_id")
        LinkLabCsnVersCsnr.DataBindings.Add("Text", dvcons, "csnr_nomcomplet")
    End Sub

    Private Sub DataBindDefunt()
        FPTBNom.DataBindings.Add("Text", bslistedefunts, "def_nom")
        FPTBPrenom.DataBindings.Add("Text", bslistedefunts, "def_prenom")
        FPTBAdresse.DataBindings.Add("Text", bslistedefunts, "def_adresse")
        FPTBCode.DataBindings.Add("Text", bslistedefunts, "def_numero_lh")
        FPTBDateNaiss.DataBindings.Add("DateValue", bslistedefunts, "def_date_naiss")
        FPTBDateDeces.DataBindings.Add("DateValue", bslistedefunts, "def_date_deces")
        FPTBLieuNaiss.DataBindings.Add("Text", bslistedefunts, "def_lieu_naiss")
        CbDefEmplacement.DataBindings.Add("EmplId", bslistedefunts, "empl_id")
        CtrlEtatCivDef.DataBindings.Add("EtatCivil", bslistedefunts, "def_etat_civil")
        CtrlEtatCivDef.DataBindings.Add("EtatCivilDe", bslistedefunts, "def_etat_civil_de")
        CtrlLocVilleDef.DataBindings.Add("LocVilleId", bslistedefunts, "locville_id")
        LinkLabDeDefVersPcont.DataBindings.Add("Text", bslistedefunts, "pc_nomcomplet")
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

    Private Sub ClearPersDataBindings()
        For Each c As Control In {TBPersNom, TBPersPrenom, TBPersAdress, CtrlLocPersonne, TBPersDN, TBPersLienParente, TBPersTel, TBPersNumNational}
            c.DataBindings.Clear()
        Next
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
            bslistedefunts.Filter = ""
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
                Dim IdsEmpls = From r As DataRow In dtempls.Rows Where r("empl_reference").ToUpper Like "*" & TxtRech & "*" Select r("empl_id")
                FiltresChamps.Add(If(IdsEmpls.Count = 0, "False", "(empl_id In (" & String.Join(", ", IdsEmpls) & "))"))
            End If
        End If

        ' filtrage dates
        If DtpDefRechercherDateDecesApres.Checked Then
            FiltresDates.Add("(def_date_deces > #" & Format(dateapres, "M/d/yyyy") & " 00:00:00 AM#)")
        End If
        If DtpDefRechercherDateDecesAvant.Checked Then
            FiltresDates.Add("(def_date_deces < #" & Format(dateavant, "M/d/yyyy") & " 11:59:59 PM#)")
        End If
        Dim FiltresChampsEtDates As New List(Of String)
        If FiltresChamps.Count > 0 Then FiltresChampsEtDates.Add("(" & String.Join(" Or ", FiltresChamps) & ")")
        If FiltresDates.Count > 0 Then FiltresChampsEtDates.Add("(" & String.Join(" And ", FiltresDates) & ")")
        bslistedefunts.Filter = String.Join(" And ", FiltresChampsEtDates)
    End Sub

    Private Sub BtDefAnnulerRecherche_Click(sender As Object, e As EventArgs) Handles BtDefAnnulerRecherche.Click
        bslistedefunts.Filter = ""
        'TbDefChampRecherche.Text = ""
        'DtpDefRechercherDateDecesApres.Checked = False
        'DtpDefRechercherDateDecesAvant.Checked = False
    End Sub

    Private Sub PRBConcessionnaire_CheckedChanged(sender As RadioButton, e As EventArgs) Handles PRBConcessionnaire.CheckedChanged
        If Not sender.Checked Then Exit Sub

        DgvListeConcessionnaireBenef.Hide()
        DgvListeConcessionnairePersonneContact.Hide()
        DgvListeConcessionnaireConcess.Show()

        BSupGestionPers.Hide()

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

        ClearPersDataBindings()
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
        If user <> "User" Then BSupGestionPers.Show()

        LabPersDN.Hide()
        TBPersDN.Hide()
        LabPersTel.Show()
        TBPersTel.Show()
        LabPersNumNational.Hide()
        TBPersNumNational.Hide()
        LabPersLienParente.Hide()
        TBPersLienParente.Hide()

        ClearPersDataBindings()
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
        If user <> "User" Then BSupGestionPers.Show()

        LabPersDN.Show()
        TBPersDN.Show()
        LabPersTel.Hide()
        TBPersTel.Hide()
        LabPersNumNational.Hide()
        TBPersNumNational.Hide()
        LabPersLienParente.Show()
        TBPersLienParente.Show()

        ClearPersDataBindings()
        DataBindBenef()
    End Sub


    Private Sub DgvListeDefunts_SelectionChanged(sender As Object, e As EventArgs) Handles DgvListeDefunts.SelectionChanged
        BTDefAjoutPcont.Visible = DgvListeDefunts.SelectedRows.Count > 0 AndAlso IsDBNull(DgvListeDefunts.SelectedDataRow("pc_id"))
    End Sub

    Private Sub DgvEmplacements_SelectionChanged(sender As Object, e As EventArgs) Handles DgvEmplacements.SelectionChanged

        If DgvEmplacements.SelectedRows.Count > 0 Then
            Dim EmplSelect = CType(DgvEmplacements.SelectedRows(0).DataBoundItem, DataRowView).Row

            dvdefuntempl.RowFilter = "empl_id = " & EmplSelect("empl_id")
            dvconsdeempl.RowFilter = "empl_id = " & EmplSelect("empl_id")

            FCTBPlaceOccupe.Text = FCDGDefunt.RowCount  '- 1

            If FormPlan IsNot Nothing AndAlso Not FormPlan.IsDisposed Then
                Dim SelRow = DgvEmplacements.SelectedDataRow
                If SelRow Is Nothing Then
                    FormPlan.EmplSelect = Nothing
                Else
                    FormPlan.EmplSelect = SelRow
                End If

            End If

        Else
            '''''dvbenefsdeconcession.RowFilter = "False"
            dvdefuntempl.RowFilter = "False"
            dvconsdeempl.RowFilter = "False"
            FCTBPlaceOccupe.Text = ""

            'GBInfosConsRienAMontrer.Show()
            'GBInfosCsn.Hide()

        End If

    End Sub


    Private Sub DgvConcessions_SelectionChanged(sender As Object, e As EventArgs) Handles DgvConcessions.SelectionChanged
        If DgvConcessions.SelectedRows.Count = 0 Then
            dvbenefsdeconcession.RowFilter = "False"
        Else
            dvbenefsdeconcession.RowFilter = "ben_con_id = " & DgvConcessions.SelectedDataRow("con_id")
        End If
    End Sub



    Private Sub BtRechEmpl_Click(sender As Object, e As EventArgs) Handles BtRechEmpl.Click

        If Not CbRechEmplEmpl.Checked AndAlso Not CbRechEmplOccupants.Checked Then
            dvlisteempl.RowFilter = ""
            Exit Sub
        End If

        Dim Filtre As String = ""
        Dim FiltresChamps As New List(Of String)
        Dim TxtRech = FCTBRechercher.Text.Trim.ToUpper

        If CbRechEmplEmpl.Checked Then
            FiltresChamps.Add("(empl_reference Like '%" & TxtRech & "%')")
            'Dim IdsCsnrs = From r As DataRow In dtCsnr.Rows Where r("csnr_nom").ToUpper Like "*" & TxtRech & "*" OrElse r("csnr_prenom").ToUpper Like "*" & TxtRech & "*" Select r("csnr_id")
            'FiltresChamps.Add(If(IdsCsnrs.Count = 0, "False", "(csnr_id In (" & String.Join(",", IdsCsnrs) & "))"))
        End If
        If CbRechEmplOccupants.Checked Then
            ' regroupe les id des occupants pouvant correspondre
            Dim IdsOccs = (From r As DataRow In dtdefunt.Rows Where Not IsDBNull(r("empl_id")) AndAlso (r("def_nom").ToUpper Like "*" & TxtRech & "*" OrElse r("def_prenom").ToUpper Like "*" & TxtRech & "*") Select r("empl_id")).Distinct
            FiltresChamps.Add(If(IdsOccs.Count = 0, "False", "(empl_id In (" & String.Join(",", IdsOccs) & "))"))
        End If

        dvlisteempl.RowFilter = String.Join(" Or ", FiltresChamps)

    End Sub

    Private Sub BtCsnRechercher_Click() Handles BtCsnRechercher.Click
        If Not {CbRechCsnCsnr, CbRechCsnEmpl, DtpRechCsnFinApres, DtpRechCsnFinAvant}.Any(Function(c) c.checked) Then
            dvcons.RowFilter = ""
            Exit Sub
        End If

        Dim Filtre As String = ""
        Dim FiltresChamps As New List(Of String)
        Dim FiltresDates As New List(Of String)
        Dim TxtRech = TBRechCsn.Text.Trim.ToUpper

        ' filtrage champs (si au moins un champ est choisi)
        If CbRechCsnCsnr.Checked OrElse CbRechCsnEmpl.Checked Then
            If CbRechCsnEmpl.Checked Then
                FiltresChamps.Add("(empl_reference Like '%" & TxtRech & "%')")
            End If
            If CbRechCsnCsnr.Checked Then
                ' cherche les id des concessionnaires pouvant correspondre
                Dim IdsCsnrs = From r As DataRow In dtCsnr.Rows Where r("csnr_nom").ToUpper Like "*" & TxtRech & "*" OrElse r("csnr_prenom").ToUpper Like "*" & TxtRech & "*" Select r("csnr_id")
                FiltresChamps.Add(If(IdsCsnrs.Count = 0, "False", "(csnr_id In (" & String.Join(",", IdsCsnrs) & "))"))
            End If
        End If

        If DtpRechCsnFinAvant.Checked Then
            FiltresDates.Add("(con_date_fin < #" & Format(DtpRechCsnFinAvant.Value.Date, "M/d/yyyy") & " 11:59:59 PM#)")
        End If
        If DtpRechCsnFinApres.Checked Then
            FiltresDates.Add("(con_date_fin => #" & Format(DtpRechCsnFinApres.Value.Date, "M/d/yyyy") & " 00:00:00 AM#)")
        End If

        Dim FiltresChampsEtDates As New List(Of String)
        If FiltresChamps.Count > 0 Then FiltresChampsEtDates.Add("(" & String.Join(" Or ", FiltresChamps) & ")")
        If FiltresDates.Count > 0 Then FiltresChampsEtDates.Add("(" & String.Join(" And ", FiltresDates) & ")")

        dvcons.RowFilter = String.Join(" And ", FiltresChampsEtDates)

    End Sub

    Private Sub BTEmplAnnulerRecherche_Click(sender As Object, e As EventArgs) Handles BTEmplAnnulerRecherche.Click
        dvlisteempl.RowFilter = ""
    End Sub

    Private Sub BTCsnAnnulerRecherche_Click(sender As Object, e As EventArgs) Handles BTCsnAnnulerRecherche.Click
        dvcons.RowFilter = ""
    End Sub



    Private Sub FPBLienCons_Click(sender As Object, e As EventArgs) Handles BTLienDeDefVersEmpl.Click
        If Not DgvListeDefunts.SelectedRows.Count > 0 Then Exit Sub

        Dim Def = DgvListeDefunts.SelectedDataRow
        If IsDBNull(Def("empl_id")) Then Exit Sub

        TabControl1.SelectedTab = TabPageEmplacements
        BTEmplAnnulerRecherche_Click(Nothing, Nothing) ' annule le filtrage dans les concessions, celle qu'on veut doit être visible
        Dim ligneaselect = (From r As DataGridViewRow In DgvEmplacements.Rows Where r.Cells("empl_id").Value = Def("empl_id")).First
        ''ligneaselect.Selected = True       ' sélectionner la ligne comme ça ne met pas à jour les infos des contrôles liés (textbox, etc), il faut utiliser CurrentCell
        DgvEmplacements.CurrentCell = ligneaselect.Cells("empl_reference")
        DgvEmplacements.ScrollSelectedIntoView()

        ' sélectionne aussi le défunt dans la liste des défunts de l'emplacement

        ligneaselect = (From r As DataGridViewRow In FCDGDefunt.Rows Where r.Cells("def_id").Value = Def("def_id")).First
        FCDGDefunt.CurrentCell = ligneaselect.Cells("def_nom")
        FCDGDefunt.ScrollSelectedIntoView()

    End Sub


    ' lien vers défunt depuis l'onglet emplacements
    Private Sub FCDGDefunt_CellContentClick(sender As DataGridViewCustom, e As DataGridViewCellEventArgs) Handles FCDGDefunt.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        Dim def = CType(FCDGDefunt.Rows(e.RowIndex).DataBoundItem, DataRowView).Row

        'Dim def = FCDGDefunt.SelectedDataRow

        If sender.Columns(e.ColumnIndex).Name = "lien" Then
            TabControl1.SelectedTab = TabPageDefunts
            BtDefAnnulerRecherche_Click(Nothing, Nothing)
            Dim ligneaselect = (From r As DataGridViewRow In DgvListeDefunts.Rows Where r.Cells("def_id").Value = def("def_id")).First
            DgvListeDefunts.CurrentCell = ligneaselect.Cells("def_nom")
            DgvListeDefunts.ScrollSelectedIntoView()
        End If
    End Sub


    Private Sub FCDGBeneficiaire_CellContentClick(sender As DataGridViewCustom, e As DataGridViewCellEventArgs) Handles FCDGBeneficiaire.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        If sender.Columns(e.ColumnIndex).Name = "lien" Then

            'Dim ben = CType(FCDGBeneficiaire.Rows(e.RowIndex).DataBoundItem, DataRowView).Row
            Dim ben = FCDGBeneficiaire.SelectedDataRow
            BTAnnulerRechPers_Click(Nothing, Nothing)
            TabControl1.SelectedTab = TabPagePersonnes
            PRBBenef.Checked = True
            Dim ligneaselect = (From r As DataGridViewRow In DgvListeConcessionnaireBenef.Rows Where r.Cells("ben_id").Value = ben("ben_id")).First
            DgvListeConcessionnaireBenef.CurrentCell = ligneaselect.Cells("ben_nom")
            DgvListeConcessionnaireBenef.ScrollSelectedIntoView()

        ElseIf sender.Columns(e.ColumnIndex).name = "suppr" Then
            Dim ben = FCDGBeneficiaire.SelectedDataRow
            SupprimerBenef(ben)
        End If
    End Sub

    ' liens emplacement vers concession
    Private Sub DgvCsnsDeEmpl_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCsnsDeEmpl.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        If sender.Columns(e.ColumnIndex).Name <> "lien" Then Exit Sub

        Dim Csn = DgvCsnsDeEmpl.SelectedDataRow
        BTCsnAnnulerRecherche_Click(Nothing, Nothing)
        TabControl1.SelectedTab = TabPageCsns
        Dim ligneaselect = (From r As DataGridViewRow In DgvConcessions.Rows Where r.Cells("con_id").Value = Csn("con_id")).FirstOrDefault
        DgvConcessions.CurrentCell = ligneaselect.Cells("empl_reference")

        DgvConcessions.ScrollSelectedIntoView()

    End Sub


    Private Sub BTLienCsnrVersConcession_Click(sender As Object, e As EventArgs) Handles LinkLabLienCsnrVersCon.LinkClicked
        If DgvListeConcessionnaireConcess.SelectedRows.Count = 0 Then Exit Sub

        Dim Csnr = DgvListeConcessionnaireConcess.SelectedDataRow

        BTCsnAnnulerRecherche_Click(Nothing, Nothing)
        TabControl1.SelectedTab = TabPageCsns
        Dim ligneaselect = (From r As DataGridViewRow In DgvConcessions.Rows Where r.Cells("csnr_id").Value = Csnr("csnr_id")).FirstOrDefault
        If ligneaselect Is Nothing Then Exit Sub     ' ça ne devrait jamais arriver, mais il est techniquement possible qu'un csnr se trouve en bdd sans concession associée
        DgvConcessions.CurrentCell = ligneaselect.Cells("empl_reference")
        DgvConcessions.ScrollSelectedIntoView()
    End Sub

    Private Sub LinkLabCsnVersCsnr_Click() Handles LinkLabCsnVersCsnr.LinkClicked
        If DgvConcessions.SelectedRows.Count = 0 Then Exit Sub

        Dim Csn = DgvConcessions.SelectedDataRow

        BTAnnulerRechPers_Click(Nothing, Nothing)
        TabControl1.SelectedTab = TabPagePersonnes
        PRBConcessionnaire.Select()
        Dim ligneaselect = (From r As DataGridViewRow In DgvListeConcessionnaireConcess.Rows Where r.Cells("csnr_id").Value = Csn("csnr_id")).FirstOrDefault
        DgvListeConcessionnaireConcess.CurrentCell = ligneaselect.Cells("csnr_nom")
        DgvListeConcessionnaireConcess.ScrollSelectedIntoView()
    End Sub

    Private Sub BTLienCsnVersEmpl_Click(sender As Object, e As EventArgs) Handles BTLienCsnVersEmpl.Click
        If DgvConcessions.SelectedRows.Count = 0 Then Exit Sub

        Dim Csn = DgvConcessions.SelectedDataRow

        BTEmplAnnulerRecherche_Click(Nothing, Nothing)
        TabControl1.SelectedTab = TabPageEmplacements
        Dim ligneaselect = (From r As DataGridViewRow In DgvEmplacements.Rows Where r.Cells("empl_id").Value = Csn("empl_id")).FirstOrDefault
        DgvEmplacements.CurrentCell = ligneaselect.Cells("empl_reference")
        DgvEmplacements.ScrollSelectedIntoView()
    End Sub

    Private Sub LinkLabEmplVersCsnActu_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        ' À FAIRE
    End Sub



    Private Sub TextBoxEmplRO()
        For Each tb As Object In {FCTBNbPlaces, FCTBHistoire}
            tb.ReadOnly = True
            tb.Cursor = Cursors.No
            If tb.BackColor <> SystemColors.Window Then tb.BackColor = SystemColors.Window
        Next

        CBEmplType.Enabled = False
        CBEmplType.Cursor = Cursors.No

        CBMonumentClasse.Enabled = False
        CBMonumentClasse.Cursor = Cursors.No
    End Sub

    Private Sub TextBoxConcessRO()
        CBConEmpl.Enabled = False
        BTLienCsnVersEmpl.Enabled = True
        LinkLabCsnVersCsnr.Enabled = True
        For Each tb As Object In {FCTBDateDeb, FCTBDateFin, FCTBCommentaire, FCTBMontantPaye}
            tb.ReadOnly = True
            tb.Cursor = Cursors.No
            If tb.BackColor <> SystemColors.Window Then tb.BackColor = SystemColors.Window
        Next
    End Sub

    'Private Sub TextBoxBenefDeConsRO()
    '    For Each tb As Object In {TBconsBenefprenom, TBconsBenefnom, TBconsBenefadress, TBconsBenefdatenaiss}
    '        tb.ReadOnly = True
    '        tb.Cursor = Cursors.No
    '        If tb.BackColor <> SystemColors.Window Then tb.BackColor = SystemColors.Window
    '    Next
    '    CtrlLocBenefDeCons.LectureSeule = True
    'End Sub


    Private Sub TextBoxDefuntRO()

        For Each tb As Object In {FPTBNom, FPTBPrenom, FPTBAdresse, FPTBDateNaiss, FPTBDateDeces, FPTBLieuNaiss, FPTBCode}
            tb.ReadOnly = True
            tb.Cursor = Cursors.No
            If tb.BackColor <> SystemColors.Window Then tb.BackColor = SystemColors.Window
            BTLienDeDefVersEmpl.Enabled = True
        Next

        'CbDefEmplacement.LectureSeule = True
        CbDefEmplacement.Enabled = False
        CtrlEtatCivDef.LectureSeule = True
        CtrlLocVilleDef.Enabled = False
        'CbDefEmplacement.Cursor = Cursors.No
    End Sub

    Private Sub TextBoxPersRO()
        For Each tb As Object In {TBPersNom, TBPersPrenom, TBPersAdress, TBPersDN, TBPersLienParente, TBPersTel, TBPersNumNational}
            tb.ReadOnly = True
            tb.Cursor = Cursors.No
            If tb.BackColor <> SystemColors.Window Then tb.BackColor = SystemColors.Window
        Next
        CtrlLocPersonne.Enabled = False

        LinkLabLienBenVersCon.Enabled = True
        LinkLabLienCsnrVersCon.Enabled = True
        LinkLabLienPcontVersDef.Enabled = True
    End Sub

    Private Sub TextBoxPersUpd()
        For Each tb As Object In {TBPersNom, TBPersPrenom, TBPersAdress, TBPersDN, TBPersLienParente, TBPersTel, TBPersNumNational}
            tb.ReadOnly = False
            tb.Cursor = Cursors.IBeam
        Next

        CtrlLocPersonne.Enabled = True
        CtrlLocPersonne.Cursor = Cursors.Default

        LinkLabLienBenVersCon.Enabled = False
        LinkLabLienCsnrVersCon.Enabled = False
        LinkLabLienPcontVersDef.Enabled = False
    End Sub

    Private Sub TextBoxDefuntUpd()
        For Each tb As Object In {FPTBNom, FPTBPrenom, FPTBAdresse, FPTBDateNaiss, FPTBDateDeces, FPTBLieuNaiss, FPTBCode}
            tb.ReadOnly = False
            tb.Cursor = Cursors.IBeam
        Next

        'CbDefEmplacement.LectureSeule = False
        CbDefEmplacement.Enabled = True
        CbDefEmplacement.Cursor = Cursors.Default
        CtrlLocVilleDef.Enabled = True
        CtrlLocVilleDef.Cursor = Cursors.Default
        CtrlEtatCivDef.LectureSeule = False
        CtrlEtatCivDef.Cursor = Cursors.Default
        BTLienDeDefVersEmpl.Enabled = False
    End Sub

    Private Sub TextBoxConcessUpd()
        BTLienCsnVersEmpl.Enabled = False
        LinkLabCsnVersCsnr.Enabled = False

        CBConEmpl.Enabled = True
        For Each tb As Object In {FCTBDateDeb, FCTBDateFin, FCTBCommentaire, FCTBMontantPaye}
            tb.ReadOnly = False
            tb.Cursor = Cursors.IBeam
        Next
    End Sub

    Private Sub TextBoxEmplUpd()
        FCTBNbPlaces.ReadOnly = False
        FCTBNbPlaces.Cursor = Cursors.IBeam
        CBEmplType.Enabled = True
        CBEmplType.Cursor = Cursors.Default
        CBMonumentClasse.Enabled = True
        CBMonumentClasse.Cursor = Cursors.Default
        FCTBHistoire.ReadOnly = False
        FCTBHistoire.Cursor = Cursors.IBeam
    End Sub

    Private Sub TextBoxCsnUpd()
        ''''CbConEmpl.LectureSeule = False
        CBConEmpl.Enabled = True
        CBConEmpl.Cursor = Cursors.Default
        LinkLabCsnVersCsnr.Enabled = False
        For Each tb As Object In {FCTBDateDeb, FCTBDateFin, FCTBCommentaire, FCTBMontantPaye}
            tb.ReadOnly = False
            tb.Cursor = Cursors.IBeam
        Next
    End Sub


    Private Sub TabControl1_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles TabControl1.Selecting
        If ModeEdition Then
            e.Cancel = True
            ToolTip1.Show("Vous devez terminer d'abord l'édition en cours.", Me, Cursor.Position.X - Me.Location.X, Cursor.Position.Y - Me.Location.Y)
        End If
    End Sub


    Private Sub ClearDefControlsDataBindings()
        For Each c As Control In {FPTBNom, FPTBPrenom, FPTBAdresse, CtrlLocVilleDef, FPTBCode, CtrlEtatCivDef, FPTBDateNaiss, FPTBDateDeces, FPTBLieuNaiss, CbDefEmplacement, LinkLabDeDefVersPcont}
            c.DataBindings.Clear()
        Next
    End Sub

    Private Sub ClearConsControlsDataBindings()
        For Each c As Control In {CBConEmpl, LinkLabCsnVersCsnr, FCTBDateDeb, FCTBDateFin, FCTBCommentaire, FCTBMontantPaye}
            c.DataBindings.Clear()
        Next
    End Sub

    Private Sub ClearEmplsControlsDataBindings()
        For Each c As Control In {FCTBNbPlaces, CBMonumentClasse, FCTBHistoire, CBEmplType}
            c.DataBindings.Clear()
        Next
    End Sub

    Private Sub FPBModifier_Click(sender As Object, e As EventArgs) Handles FPBModifier.Click
        If DgvListeDefunts.SelectedRows.Count = 0 Then Exit Sub

        If Not ModeEdition Then

            'bslistedefunts.SuspendBinding()    ' marche pas terrible
            ClearDefControlsDataBindings()

            ModeEdition = True

            DgvListeDefunts.Enabled = False
            BtDefChercher.Enabled = False
            BtDefAnnulerRecherche.Enabled = False
            FPBSupprimer.Enabled = False
            FPBAjouter.Enabled = False

            TextBoxDefuntUpd()
            FPBModifier.Text = "Terminer l'édition"

        Else

            Dim result = MessageBox.Show("Enregistrer les modifications ?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then

                Dim RowDef = DgvListeDefunts.SelectedDataRow
                RowDef("def_nom") = FPTBNom.Text.Trim
                RowDef("def_prenom") = FPTBPrenom.Text.Trim
                RowDef("def_adresse") = FPTBAdresse.Text.Trim
                RowDef("locville_id") = If(CtrlLocVilleDef.LocVilleId = -1, DBNull.Value, CtrlLocVilleDef.LocVilleId)
                RowDef("def_etat_civil") = CtrlEtatCivDef.EtatCivil
                RowDef("def_etat_civil_de") = CtrlEtatCivDef.EtatCivilDe.Trim
                RowDef("def_date_naiss") = If(FPTBDateNaiss.DateEstValide And Not FPTBDateNaiss.DateEstVide, FPTBDateNaiss.DateValue, DBNull.Value)
                RowDef("def_date_deces") = If(FPTBDateDeces.DateEstValide And Not FPTBDateDeces.DateEstVide, FPTBDateDeces.DateValue, DBNull.Value)
                RowDef("def_numero_lh") = If(FPTBCode.Value.HasValue, FPTBCode.Value, DBNull.Value)
                RowDef("def_lieu_naiss") = FPTBLieuNaiss.Text.Trim
                RowDef("empl_id") = If(CbDefEmplacement.SelectedValue = -1, DBNull.Value, CbDefEmplacement.SelectedValue)

                Bdd.Update("defunts", RowDef)
                UpdateInfosDataTableDefunts(RowDef)

                'bslistedefunts.ResumeBinding()


            Else
                'bslistedefunts.ResetBindings(False)
                'bslistedefunts.ResumeBinding()
            End If

            TextBoxDefuntRO()
            DataBindDefunt()

            DgvListeDefunts.Enabled = True
            BtDefChercher.Enabled = True
            BtDefAnnulerRecherche.Enabled = True
            FPBSupprimer.Enabled = True
            FPBAjouter.Enabled = True
            ModeEdition = False
            FPBModifier.Text = "Modifier"

        End If
    End Sub


    Private Sub BTModifCons_Click(sender As Object, e As EventArgs) Handles BTModifCons.Click
        If DgvConcessions.SelectedRows.Count = 0 Then Exit Sub

        If Not ModeEdition Then
            ClearConsControlsDataBindings()
            ModeEdition = True

            For Each c As Control In {DgvConcessions, BtCsnRechercher, BTCsnAnnulerRecherche, BTSupprCons, BTConsAjout, BTConAjoutBen}
                c.Enabled = False
            Next

            TextBoxConcessUpd()
            BTModifCons.Text = "Terminer l'édition"

        Else

            Dim result = MessageBox.Show("Enregistrer les modifications ?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim RowCsn = DgvConcessions.SelectedDataRow
                If CBConEmpl.SelectedValue <> -1 Then RowCsn("empl_id") = CBConEmpl.SelectedValue
                RowCsn("con_date_debut") = If(FCTBDateDeb.DateEstValide AndAlso Not FCTBDateDeb.DateEstVide, FCTBDateDeb.DateValue, DBNull.Value)
                RowCsn("con_date_fin") = If(FCTBDateFin.DateEstValide AndAlso Not FCTBDateFin.DateEstVide, FCTBDateFin.DateValue, DBNull.Value)
                RowCsn("con_montant_paye") = If(FCTBMontantPaye.Value.HasValue, FCTBMontantPaye.Value, DBNull.Value)
                If CBConEmpl.EmplId <> -1 Then RowCsn("empl_id") = CBConEmpl.EmplId

                ' le commentaire est dans une table séparée, si il n'existe pas on le crée
                Dim PasDeCom As Boolean = False
                If IsDBNull(RowCsn("com_id")) Then
                    PasDeCom = True
                Else
                    Dim Coms = dtcommentaires.Select("com_id = " & RowCsn("com_id"))
                    If Coms.Count > 0 Then
                        Coms(0)("com_commentaire") = FCTBCommentaire.Text.Trim
                        Bdd.Update("t_commentaire", Coms(0))
                    Else
                        PasDeCom = True
                    End If
                End If

                If PasDeCom Then
                    Dim RowCom = dtcommentaires.NewRow
                    RowCom("com_commentaire") = FCTBCommentaire.Text.Trim
                    RowCom("com_id") = Bdd.Insert("t_commentaire", RowCom)
                    RowCsn("com_id") = RowCom("com_id")
                    dtcommentaires.Rows.Add(RowCom)
                End If

                Bdd.Update("concessions", RowCsn)

                ' met à jour le cache local
                UpdateInfosDataTableConcessions(RowCsn)
                UpdateInfosDataTableEmplacements(RowCsn("empl_id"))

            End If

            TextBoxConcessRO()
            DataBindConcessions()

            For Each c As Control In {DgvConcessions, BtCsnRechercher, BTCsnAnnulerRecherche, BTSupprCons, BTConsAjout, BTConAjoutBen}
                c.Enabled = True
            Next

            ModeEdition = False
            BTModifCons.Text = "Modifier"
        End If
    End Sub



    Private Sub BTModifEmpl_Click(sender As Object, e As EventArgs) Handles BTModifEmpl.Click
        If DgvEmplacements.SelectedRows.Count = 0 Then Exit Sub

        If Not ModeEdition Then
            ClearEmplsControlsDataBindings()
            ModeEdition = True

            DgvEmplacements.Enabled = False
            BtRechEmpl.Enabled = False
            BTEmplAnnulerRecherche.Enabled = False
            BTSupprEmpl.Enabled = False

            TextBoxEmplUpd()
            BTModifEmpl.Text = "Terminer l'édition"

        Else

            Dim result = MessageBox.Show("Enregistrer les modifications ?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim RowEmpl = DgvEmplacements.SelectedDataRow
                RowEmpl("empl_nb_places") = If(FCTBNbPlaces.Value.HasValue, FCTBNbPlaces.Value, DBNull.Value)
                RowEmpl("empl_monum_classe") = CBMonumentClasse.Checked
                RowEmpl("empl_type") = CBEmplType.SelectedValue

                Dim PasDeHist As Boolean = False
                If IsDBNull(RowEmpl("hist_id")) Then
                    PasDeHist = True
                Else
                    Dim Hists = dthistoires.Select("h_id = " & RowEmpl("hist_id"))
                    If Hists.Count > 0 Then
                        Hists(0)("h_histoire") = FCTBHistoire.Text.Trim
                        Bdd.Update("t_histoire", Hists(0))
                    Else
                        PasDeHist = True
                    End If
                End If

                If PasDeHist Then
                    Dim RowHist = dthistoires.NewRow
                    RowHist("h_histoire") = FCTBHistoire.Text.Trim
                    RowHist("h_id") = Bdd.Insert("t_histoire", RowHist)
                    RowEmpl("hist_id") = RowHist("h_id")
                    dthistoires.Rows.Add(RowHist)
                End If

                Bdd.Update("emplacements", RowEmpl)

                UpdateInfosDataTableEmplacements(RowEmpl)

            End If

            TextBoxEmplRO()
            DataBindEmplInfos()

            DgvEmplacements.Enabled = True
            BtRechEmpl.Enabled = True
            BTEmplAnnulerRecherche.Enabled = True
            BTSupprEmpl.Enabled = True

            ModeEdition = False
            BTModifEmpl.Text = "Modifier"
        End If
    End Sub






    '' À REVOIR
    'Private Sub BmodifConsBenef_Click(sender As Object, e As EventArgs) Handles BmodifConsBenef.Click
    '    If Not ModeEdition Then
    '        ModeEdition = True
    '        TextBoxConsBenefUpd()
    '        BmodifConsBenef.Text = "Sauvegarder"
    '        TabControl1.TabPages(0).Enabled = False
    '        TabControl1.TabPages(2).Enabled = False
    '    Else
    '        Dim result As Integer = MessageBox.Show("Etes-vous sur de vouloir effectuer cette modification ?", "Confirmation", MessageBoxButtons.YesNo)
    '        If result = DialogResult.No Then
    '            BmodifConsBenef.Text = "Modifier"
    '            ''TextBoxConsRO()
    '            'TextBoxBenefDeConsRO()
    '            TabControl1.TabPages(0).Enabled = True
    '            TabControl1.TabPages(2).Enabled = True
    '        ElseIf result = DialogResult.Yes Then
    '            BmodifConsBenef.Text = "Modifier"
    '            ''TextBoxConsRO()
    '            'TextBoxBenefDeConsRO()
    '            TabControl1.TabPages(0).Enabled = True
    '            TabControl1.TabPages(2).Enabled = True
    '        End If
    '        ModeEdition = False
    '    End If
    'End Sub

    Private Sub BModifGestionPers_Click(sender As Object, e As EventArgs) Handles BModifGestionPers.Click

        If PRBBenef.Checked Then
            If DgvListeConcessionnaireBenef.SelectedRows.Count = 0 Then Exit Sub
        ElseIf PRBConcessionnaire.Checked Then
            If DgvListeConcessionnaireConcess.SelectedRows.Count = 0 Then Exit Sub
        ElseIf PRBPersCon.Checked Then
            If DgvListeConcessionnairePersonneContact.SelectedRows.Count = 0 Then Exit Sub
        Else
            Exit Sub
        End If

        If Not ModeEdition Then
            ClearPersDataBindings()
            ModeEdition = True

            For Each c As Control In {BTAnnulerRechPers, BTChercherPersonne, DgvListeConcessionnaireBenef, DgvListeConcessionnaireConcess, DgvListeConcessionnairePersonneContact, PRBBenef, PRBConcessionnaire, PRBPersCon, BSupGestionPers}
                c.Enabled = False
            Next

            TextBoxPersUpd()
            BModifGestionPers.Text = "Terminer l'édition"

        Else

            Dim result = MessageBox.Show("Enregistrer les modifications ?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Select Case True
                    Case PRBBenef.Checked
                        TerminerModifBenef()
                    Case PRBConcessionnaire.Checked
                        TerminerModifCsnr()
                    Case PRBPersCon.Checked
                        TerminerModifPcont()
                End Select

            End If

            TextBoxPersRO()
            Dim databindpour = New Dictionary(Of RadioButton, Action) From {{PRBBenef, AddressOf DataBindBenef}, {PRBConcessionnaire, AddressOf DataBindConss}, {PRBPersCon, AddressOf DataBindPersContact}}
            databindpour(databindpour.Keys.First(Function(k) k.Checked))()

            For Each c As Control In {BTAnnulerRechPers, BTChercherPersonne, DgvListeConcessionnaireBenef, DgvListeConcessionnaireConcess, DgvListeConcessionnairePersonneContact, PRBBenef, PRBConcessionnaire, PRBPersCon, BSupGestionPers}
                c.Enabled = True
            Next
            ModeEdition = False
            BModifGestionPers.Text = "Modifier"
        End If

    End Sub


    Private Sub TerminerModifCsnr()
        Dim RowCsnr = DgvListeConcessionnaireConcess.SelectedDataRow
        RowCsnr("csnr_prenom") = TBPersPrenom.Text.Trim
        RowCsnr("csnr_nom") = TBPersNom.Text.Trim
        RowCsnr("csnr_adresse") = TBPersAdress.Text.Trim
        RowCsnr("locville_id") = If(CtrlLocPersonne.LocVilleId = -1, DBNull.Value, CtrlLocPersonne.LocVilleId)
        RowCsnr("csnr_date_naiss") = If(TBPersDN.DateEstValide AndAlso Not TBPersDN.DateEstVide, TBPersDN.DateValue, DBNull.Value)
        RowCsnr("csnr_tel") = TBPersTel.Text.Trim
        RowCsnr("csnr_no_registre") = If(TBPersNumNational.Value.HasValue, TBPersNumNational.Value, DBNull.Value)
        Bdd.Update("concessionnaires", RowCsnr)
    End Sub

    Private Sub TerminerModifBenef()
        Dim RowBen = DgvListeConcessionnaireBenef.SelectedDataRow
        RowBen("ben_nom") = TBPersNom.Text.Trim
        RowBen("ben_prenom") = TBPersPrenom.Text.Trim
        RowBen("ben_date_naiss") = If(TBPersDN.DateEstValide AndAlso Not TBPersDN.DateEstVide, TBPersDN.DateValue, DBNull.Value)
        RowBen("ben_lien_parente") = TBPersLienParente.Text.Trim
        RowBen("ben_adresse") = TBPersAdress.Text.Trim
        RowBen("locville_id") = If(CtrlLocPersonne.LocVilleId <> -1, CtrlLocPersonne.LocVilleId, DBNull.Value)
        Bdd.Update("beneficiaires", RowBen)
    End Sub

    Private Sub TerminerModifPcont()
        Dim RowPcont = DgvListeConcessionnairePersonneContact.SelectedDataRow
        RowPcont("pc_nom") = TBPersNom.Text.Trim
        RowPcont("pc_prenom") = TBPersPrenom.Text.Trim
        RowPcont("pc_adresse") = TBPersAdress.Text.Trim
        RowPcont("locville_id") = If(CtrlLocPersonne.LocVilleId <> -1, CtrlLocPersonne.LocVilleId, DBNull.Value)
        RowPcont("pc_tel") = TBPersTel.Text.Trim
        Bdd.Update("personnes_contact", RowPcont)
        UpdateInfosDataTableDefunts(dtdefunt.Select("pc_id = " & RowPcont("pc_id")).ToList)
    End Sub


    Private Sub BTDefAjoutPcont_Click(sender As Object, e As EventArgs) Handles BTDefAjoutPcont.Click
        Dim RowPcont = dtPersContact.NewRow
        RowPcont("pc_nom") = ""
        RowPcont("pc_prenom") = ""
        RowPcont("pc_tel") = ""
        RowPcont("locville_id") = DBNull.Value
        RowPcont("pc_adresse") = ""
        RowPcont("pc_id") = Bdd.Insert("personnes_contact", RowPcont)
        dtPersContact.Rows.Add(RowPcont)

        Dim RowDef = DgvListeDefunts.SelectedDataRow
        RowDef("pc_id") = RowPcont("pc_id")
        Bdd.Update("defunts", RowDef)
        UpdateInfosDataTableDefunts(RowDef)
        BTDefAjoutPcont.Hide()

        dvPersContact.RowFilter = ""
        TabControl1.SelectedTab = TabPagePersonnes
        PRBPersCon.Select()
        DgvListeConcessionnairePersonneContact.CurrentCell = (From r As DataGridViewRow In DgvListeConcessionnairePersonneContact.Rows Where r.Cells("pc_id").Value = RowPcont("pc_id")).First.Cells("pc_nom")

        BModifGestionPers_Click(Nothing, Nothing)
        TBPersPrenom.Select()
    End Sub


    Private Sub BTConAjoutBen_Click(sender As Object, e As EventArgs) Handles BTConAjoutBen.Click
        If DgvConcessions.SelectedRows.Count = 0 Then Exit Sub

        Dim RowBen = dtbenef.NewRow
        RowBen("ben_nom") = ""
        RowBen("ben_prenom") = ""
        RowBen("ben_adresse") = ""
        RowBen("ben_lien_parente") = ""
        RowBen("ben_id") = Bdd.Insert("beneficiaires", RowBen)
        RowBen("ben_con_id") = DgvConcessions.SelectedDataRow("con_id")
        dtbenef.Rows.Add(RowBen)

        ' jointure
        Dim RowJnt = Bdd.GetRowVide("beneficier")
        RowJnt("con_id") = RowBen("ben_con_id")
        RowJnt("ben_id") = RowBen("ben_id")
        Bdd.Insert("beneficier", RowJnt)

        ' édition du nouveau ben
        dvbenefs.RowFilter = ""
        PRBBenef.Select()
        TabControl1.SelectedTab = TabPagePersonnes
        DgvListeConcessionnaireBenef.CurrentCell = (From r As DataGridViewRow In DgvListeConcessionnaireBenef.Rows Where r.Cells("ben_id").value = RowBen("ben_id")).First.Cells("ben_nom")

        BModifGestionPers_Click(Nothing, Nothing)
        TBPersPrenom.Select()

    End Sub




    Private Sub FDBLinkToPersCon_Click(sender As Object, e As EventArgs) Handles LinkLabDeDefVersPcont.LinkClicked
        If Not DgvListeDefunts.SelectedRows.Count > 0 Then Exit Sub

        Dim Def = DgvListeDefunts.SelectedDataRow
        If IsDBNull(Def("pc_id")) Then Exit Sub

        BTAnnulerRechPers_Click(Nothing, Nothing)
        TabControl1.SelectedTab = TabPagePersonnes
        PRBPersCon.Select()

        Dim ligneaselect = (From r As DataGridViewRow In DgvListeConcessionnairePersonneContact.Rows Where r.Cells("pc_id").Value = Def("pc_id")).First
        DgvListeConcessionnairePersonneContact.CurrentCell = ligneaselect.Cells("pc_nom")
        DgvListeConcessionnairePersonneContact.ScrollSelectedIntoView()
    End Sub

    Private Sub FDBLinkToConcessionnaire_Click(sender As Object, e As EventArgs)
        If DgvEmplacements.SelectedRows.Count = 0 Then Exit Sub

        Dim Csn = DgvEmplacements.SelectedDataRow
        If IsDBNull(Csn("con_id")) Then Exit Sub

        BTAnnulerRechPers_Click(Nothing, Nothing)
        TabControl1.SelectedTab = TabPagePersonnes
        PRBConcessionnaire.Select()

        Dim ligneaselect = (From r As DataGridViewRow In DgvListeConcessionnaireConcess.Rows Where r.Cells("csnr_id").Value = Csn("csnr_id")).First
        DgvListeConcessionnaireConcess.CurrentCell = ligneaselect.Cells("csnr_nom")
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
        If DgvListeDefunts.SelectedRows.Count = 0 Then Exit Sub

        Dim RowDef = DgvListeDefunts.SelectedDataRow
        Dim result = MessageBox.Show("Supprimer le défunt " & RowDef("def_prenom") & "" & RowDef("def_nom") & " de la base de données ?", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            ' supprime aussi la personne de contact associée
            If Not IsDBNull(RowDef("pc_id")) Then
                Dim RowsPcont = dtPersContact.Select("pc_id = " & RowDef("pc_id"))
                If RowsPcont.Count > 0 Then
                    If 1 = Bdd.Delete("personnes_contact", RowsPcont(0)("pc_id")) Then   ' il ne devrait y avoir qu'une pers de contact par défunt
                        dtPersContact.Rows.Remove(RowsPcont(0))
                    Else
                        ' la ligne n'a pas été supprimée - afficher une erreur ?
                    End If
                End If
            End If

            If Bdd.Delete("defunts", RowDef("def_id")) = 1 Then
                ' adapte le cache local
                dtdefunt.Rows.Remove(RowDef)
            Else
                ' la ligne n'a pas été supprimée - afficher une erreur ?
            End If
        End If
    End Sub

    Private Sub BTSupprCons_Click(sender As Object, e As EventArgs) Handles BTSupprCons.Click
        If DgvConcessions.SelectedRows.Count = 0 Then Exit Sub

        Dim RowCsn = DgvConcessions.SelectedDataRow
        Dim result = MessageBox.Show("Supprimer cette location de la base de données ?", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then

            Dim IdEmpl = RowCsn("empl_id")

            ' supprime concessionnaire lié
            Bdd.NonQuery("DELETE From concessionnaires WHERE csnr_id = " & RowCsn("csnr_id"))
            Dim RowsCsnr = dtCsnr.Select("csnr_id = " & RowCsn("csnr_id"))
            If RowsCsnr.Count > 0 Then dtCsnr.Rows.Remove(RowsCsnr(0))
            ' supprime bénéficiaires
            Dim JntBenefs = Bdd.Query("SELECT * FROM beneficier WHERE con_id = " & RowCsn("con_id"))
            If JntBenefs.Rows.Count > 0 Then
                Bdd.NonQuery("DELETE FROM beneficier WHERE con_id = " & RowCsn("con_id"))
                Dim IdsBenefs As String = "(" & String.Join(",", (From r As DataRow In JntBenefs.Rows Select r("ben_id"))) & ")"
                Bdd.NonQuery("DELETE FROM beneficiaires WHERE ben_id IN " & IdsBenefs)
                dtbenef.Rows.RemoveRange(dtbenef.Select("ben_con_id = " & RowCsn("con_id")))
            End If
            ' supprime commentaire
            Bdd.NonQuery("DELETE FROM t_commentaire WHERE com_id = " & RowCsn("com_id"))
            dtcommentaires.Rows.RemoveRange(dtcommentaires.Select("com_id = " & RowCsn("com_id")))
            ' supprime concession
            Bdd.Delete("concessions", RowCsn("con_id"))
            dtcons.Rows.Remove(RowCsn)

            UpdateInfosDataTableEmplacements(IdEmpl)
        End If
    End Sub

    Private Sub BSupGestionPers_Click(sender As Object, e As EventArgs) Handles BSupGestionPers.Click
        If PRBBenef.Checked Then
            If DgvListeConcessionnaireBenef.SelectedRows.Count > 0 Then SupprimerBenef()
        ElseIf PRBConcessionnaire.Checked Then
            If DgvListeConcessionnaireConcess.SelectedRows.Count > 0 Then ToolTip1.Show("Impossible de supprimer un concessionnaire. Supprimez la concession associée.", BSupGestionPers)
        ElseIf PRBPersCon.Checked Then
            If DgvListeConcessionnairePersonneContact.SelectedRows.Count > 0 Then SupprimerPcont()
        End If
    End Sub

    Private Sub SupprimerBenef(Optional ben As DataRow = Nothing)
        Dim RowBen = If(ben, DgvListeConcessionnaireBenef.SelectedDataRow)
        Dim result = MessageBox.Show("Supprimer le bénéficiaire " & RowBen("ben_prenom") & " " & RowBen("ben_nom") & " ?", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            ' supprime la jointure
            Bdd.NonQuery("DELETE FROM beneficier WHERE ben_id = " & RowBen("ben_id"))
            ' supprime le bénef
            Bdd.Delete("beneficiaires", RowBen("ben_id"))
            dtbenef.Rows.Remove(RowBen)
        End If
    End Sub

    Private Sub SupprimerPcont()
        Dim RowPc = DgvListeConcessionnairePersonneContact.SelectedDataRow
        Dim result = MessageBox.Show("Supprimer la personne de contact " & RowPc("pc_prenom") & " " & RowPc("pc_nom") & " ?", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            ' supprime la fk du défunt
            Bdd.NonQuery("UPDATE defunts SET pc_id = NULL WHERE pc_id = " & RowPc("pc_id"))
            Dim RowsDef = dtdefunt.Select("pc_id = " & RowPc("pc_id"))
            For Each RDef In RowsDef
                RDef("pc_id") = DBNull.Value
            Next
            UpdateInfosDataTableDefunts(RowsDef)
            ' supprime la pc
            Bdd.Delete("personnes_contact", RowPc("pc_id"))
            dtPersContact.Rows.Remove(RowPc)
        End If
    End Sub


    Private Sub FPBAjouter_Click(sender As Object, e As EventArgs) Handles FPBAjouter.Click
        Dim RowDef = dtdefunt.NewRow
        RowDef("def_prenom") = ""
        RowDef("def_nom") = ""
        RowDef("def_adresse") = ""
        RowDef("def_etat_civil") = CType(TEtatCivil.NonPrecise, Integer)
        RowDef("def_etat_civil_de") = ""
        RowDef("def_lieu_naiss") = ""
        RowDef("def_lieu_deces") = ""
        RowDef("def_id") = Bdd.Insert("defunts", RowDef)
        dtdefunt.Rows.Add(RowDef)

        bslistedefunts.Filter = ""
        DgvListeDefunts.CurrentCell = (From r As DataGridViewRow In DgvListeDefunts.Rows Where r.Cells("def_id").Value = RowDef("def_id")).First.Cells("def_nom")

        FPBModifier_Click(Nothing, Nothing)
        FPTBNom.Select()
    End Sub

    Private Sub BTConsAjout_Click(sender As Object, e As EventArgs) Handles BTConsAjout.Click
        Using f As New FormReservation
            f.ShowDialog()
            If f.DialogResult = DialogResult.OK Then
                Dim RowCsn = dtcons.NewRow
                'RowCsn.ItemArray = f.RowCsn.ItemArray.Clone
                CopierColonnesCorrespondantes(f.RowCsn, RowCsn)
                dtcons.Rows.Add(RowCsn)

                Dim RowCsnr = dtCsnr.NewRow
                'RowCsnr.ItemArray = f.RowCsnr.ItemArray.Clone
                CopierColonnesCorrespondantes(f.RowCsnr, RowCsnr)
                dtCsnr.Rows.Add(RowCsnr)

                Dim RowCom = dtcommentaires.NewRow
                'RowCom.ItemArray = f.RowComCsn.ItemArray.Clone
                CopierColonnesCorrespondantes(f.RowComCsn, RowCom)
                dtcommentaires.Rows.Add(RowCom)

                Dim NvxBens(f.TblBenefs.Rows.Count - 1) As DataRow
                Dim i = 0
                For Each r As DataRow In f.TblBenefs.Rows
                    Dim RowBen = dtbenef.NewRow()
                    'RowBen.ItemArray = r.ItemArray.Clone
                    CopierColonnesCorrespondantes(r, RowBen)
                    RowBen("ben_id") = f.PremIdBen + i
                    RowBen("ben_con_id") = RowCsn("con_id")
                    dtbenef.Rows.Add(RowBen)
                    NvxBens(i) = RowBen
                    i += 1
                Next

                UpdateInfosDataTableConcessions(RowCsn)
                UpdateInfosDataTableEmplacements(RowCsn("empl_id"))

                dvcons.RowFilter = ""

                DgvConcessions.CurrentCell = (From r As DataGridViewRow In DgvConcessions.Rows Where r.Cells("con_id").value = RowCsn("con_id")).First.Cells("empl_reference")

            End If
        End Using
    End Sub




    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is TabPagePersonnes Then
            If Not (PRBBenef.Checked OrElse PRBConcessionnaire.Checked OrElse PRBPersCon.Checked) Then
                PRBConcessionnaire.Checked = True
            End If
        End If
    End Sub

    Private Sub BTLienPcontVersDef_Click(sender As Object, e As EventArgs) Handles LinkLabLienPcontVersDef.Click
        If DgvListeConcessionnairePersonneContact.SelectedRows.Count = 0 Then Exit Sub

        Dim Pcont = DgvListeConcessionnairePersonneContact.SelectedDataRow

        BtDefAnnulerRecherche_Click(Nothing, Nothing)
        TabControl1.SelectedTab = TabPageDefunts
        Dim ligneaselect = (From r As DataGridViewRow In DgvListeDefunts.Rows Where Not IsDBNull(r.Cells("pc_id").Value) AndAlso r.Cells("pc_id").Value = Pcont("pc_id")).FirstOrDefault
        If ligneaselect Is Nothing Then Exit Sub

        DgvListeDefunts.CurrentCell = ligneaselect.Cells("def_nom")
        DgvListeDefunts.ScrollSelectedIntoView()
    End Sub

    Private Sub BTLienBenefVersConcession_Click(sender As Object, e As EventArgs) Handles LinkLabLienBenVersCon.Click
        If Not DgvListeConcessionnaireBenef.SelectedRows.Count > 0 Then Exit Sub

        Dim ben = DgvListeConcessionnaireBenef.SelectedDataRow
        If IsDBNull(ben("ben_con_id")) Then Exit Sub      ' il ne devrait pas y avoir de bénéficiaires sans concession, mais c'est techniquement possible même si anormal

        BTCsnAnnulerRecherche_Click(Nothing, Nothing)
        TabControl1.SelectedTab = TabPageCsns
        Dim ligneaselect = (From r As DataGridViewRow In DgvConcessions.Rows Where Not IsDBNull(r.Cells("con_id").Value) AndAlso r.Cells("con_id").Value = ben("ben_con_id")).First
        DgvConcessions.CurrentCell = ligneaselect.Cells("empl_reference")
        DgvConcessions.ScrollSelectedIntoView()

        ' + sélection dans la liste des bénefs de la concession
        ligneaselect = (From r As DataGridViewRow In FCDGBeneficiaire.Rows Where r.Cells("ben_id").Value = ben("ben_id")).First
        FCDGBeneficiaire.CurrentCell = ligneaselect.Cells("ben_nom")
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


    Private Sub FCDGDefunt_CellPainting(sender As DataGridView, e As DataGridViewCellPaintingEventArgs) Handles FCDGDefunt.CellPainting, FCDGBeneficiaire.CellPainting, DgvConcessions.CellPainting, DgvCsnsDeEmpl.CellPainting
        ' https://stackoverflow.com/a/36253883

        If e.RowIndex < 0 Then Exit Sub             ' -1 = en-tête de colonne

        Dim Dessiner As Boolean = False

        Dim LaCol As DataGridViewColumn
        Dim NomCol As String
        LaCol = sender.Columns(e.ColumnIndex)
        NomCol = LaCol.Name

        If NomCol = "lien" OrElse NomCol = "suppr" Then
            Dim img As Bitmap
            If NomCol = "lien" Then
                img = My.Resources.Next_16xMD
            ElseIf NomCol = "suppr" Then
                img = My.Resources.Cancel_16x
            End If

            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim w = img.Width
            Dim h = img.Height
            Dim x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2
            Dim y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2

            e.Graphics.DrawImage(img, New Rectangle(x, y, w, h))
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
                Dim Empls = dtcons.Select("empl_id = " & Csns(0)("empl_id"))
                LinkLabLienCsnrVersCon.Text = Empls(0)("empl_reference")
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

    ' À FAIRE -- diriger vers l'onglet concessions
    Private Sub DgvListeConcessionnaireBenef_SelectionChanged(sender As Object, e As EventArgs) Handles DgvListeConcessionnaireBenef.SelectionChanged
        If Not DgvListeConcessionnaireBenef.Visible Then Exit Sub
        If DgvListeConcessionnaireBenef.SelectedRows.Count = 0 Then
            LinkLabLienBenVersCon.Text = "/"
        Else
            Dim Csns = dtcons.Select("con_id = " & DgvListeConcessionnaireBenef.SelectedDataRow("ben_con_id"))
            If Csns.Count = 0 Then
                LinkLabLienBenVersCon.Text = "/"
            Else
                Dim Empls = dtempls.Select("empl_id = " & Csns(0)("empl_id"))
                LinkLabLienBenVersCon.Text = Empls(0)("empl_reference")
            End If
        End If
    End Sub


    Private Sub FPersonneTbSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles FPersonneTbSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            BTChercherPersonne_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub FCTBRechercher_KeyDown(sender As Object, e As KeyEventArgs) Handles FCTBRechercher.KeyDown, CbRechEmplEmpl.KeyDown, CbRechEmplOccupants.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtRechEmpl_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub TbDefChampRecherche_KeyDown(sender As Object, e As KeyEventArgs) Handles TbDefChampRecherche.KeyDown, CBDefChercherNom.KeyDown, CBDefChercherEmplacement.KeyDown, DtpDefRechercherDateDecesApres.KeyDown, DtpDefRechercherDateDecesAvant.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtDefChercher_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub TbRechCsn_KeyDown(sender As Object, e As KeyEventArgs) Handles TBRechCsn.KeyDown, CbRechCsnEmpl.KeyDown, CbRechCsnCsnr.KeyDown, DtpRechCsnFinApres.KeyDown, DtpRechCsnFinAvant.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtCsnRechercher_Click()
        End If

    End Sub


    Private Sub DgvEmplacements_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvEmplacements.CellFormatting
        If DgvEmplacements.Columns(e.ColumnIndex).Name = "con_actuelle_id" Then
            e.Value = If(Not IsDBNull(e.Value), "OUI", "")
        ElseIf DgvEmplacements.Columns(e.ColumnIndex).Name = "empl_type" Then
            e.Value = TTypeEmplToString(e.Value)

        End If
    End Sub

    ''' <summary>
    ''' copie les colonnes d'une datarow à une autre, ignore celles qui sont de trop
    ''' </summary>
    Private Sub CopierColonnesCorrespondantes(src As DataRow, dest As DataRow)
        Dim NomsColsSrc = From c As DataColumn In src.Table.Columns Select c.ColumnName
        Dim NomsColsDest = From c As DataColumn In dest.Table.Columns Select c.ColumnName
        Dim ColsCommunes = NomsColsSrc.Intersect(NomsColsDest)
        For Each nomcol In ColsCommunes
            dest(nomcol) = src(nomcol)
        Next
    End Sub


    Private Sub BtMontrerFormPlancim_Click(sender As Object, e As EventArgs) Handles BtMontrerFormPlancim.Click, BtMontrerFormPlanCim2.Click, BtMontrerFormPlanCim3.Click, BtMontrerFormPlanCim4.Click
        If FormPlan Is Nothing OrElse FormPlan.IsDisposed Then
            FormPlan = New FormChoixEmplSurPlan(dtempls)
            FormPlan.Owner = Me
            FormPlan.Width = 725
            AddHandler FormPlan.SelectionChanged, AddressOf FormPlan_SelectionChanged
        End If
        FormPlan.Show()
    End Sub

    Private Sub FormPlan_SelectionChanged(empl As DataRow)
        Dim DgvR = (From r As DataGridViewRow In DgvEmplacements.Rows Where CType(r.DataBoundItem, DataRowView).Row Is empl).FirstOrDefault
        If DgvR Is Nothing Then
            DgvEmplacements.ClearSelection()
        Else
            DgvEmplacements.CurrentCell = DgvR.Cells("empl_reference")
            DgvEmplacements.ScrollSelectedIntoView()
        End If
    End Sub

    Private Sub FCDGDefunt_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles FCDGDefunt.CellContentClick

    End Sub


    'Private Sub FormHome_paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
    '    Dim hauteurdebutdegrade As Integer = Me.Height * 0.42
    '    Dim rectangledegrade = New Rectangle(0, hauteurdebutdegrade, Me.Width, Me.Height - hauteurdebutdegrade)
    '    'dim rectangledegrade as new rectangle(0, 0, 0, 0)
    '    ' - 6 au premier param parce que sinon il peut y avoir une ligne verte en haut du rectangle du dégradé, comme si le dégradé (re)commençait quelques pixels trop bas
    '    Dim vlineargradient As Drawing.Drawing2D.LinearGradientBrush =
    '                New Drawing.Drawing2D.LinearGradientBrush(New Drawing.Point(rectangledegrade.X, rectangledegrade.Y + rectangledegrade.Height - 6),
    '                                                New Drawing.Point(rectangledegrade.X, rectangledegrade.Y),
    '                                                Color.FromArgb(11, 160, 92),
    '                                                Color.White)


    '    Dim vgraphic As Drawing.Graphics = Me.CreateGraphics
    '    ' to tile the image background - using the same image background of the image
    '    'dim vtexture as new drawing.texturebrush(me.backgroundimage)

    '    vgraphic.FillRectangle(vlineargradient, rectangledegrade)
    '    'vgraphic.fillrectangle(vtexture, me.displayrectangle)

    '    vgraphic.Dispose() : vgraphic = Nothing ': vtexture.dispose() : vtexture = nothing
    'End Sub



    Private Sub Tabs_Paint(sender As Panel, e As PaintEventArgs) Handles TabPageCsns.Paint, TabPageDefunts.Paint, TabPageEmplacements.Paint, TabPagePersonnes.Paint
        Dim HauteurDebutDegrade As Integer = sender.Height * 0.42
        Dim RectangleDegrade = New Rectangle(0, HauteurDebutDegrade, sender.Width, sender.Height - HauteurDebutDegrade)
        ' - 6 au premier param parce que sinon il peut y avoir une ligne verte en haut du rectangle du dégradé, comme si le dégradé (re)commençait quelques pixels trop bas
        Dim vLinearGradient As Drawing.Drawing2D.LinearGradientBrush =
                    New Drawing.Drawing2D.LinearGradientBrush(New Drawing.Point(RectangleDegrade.X, RectangleDegrade.Y - 6),
                                                    New Drawing.Point(RectangleDegrade.X, RectangleDegrade.Y + RectangleDegrade.Height),
                                                    Color.White,
                                                    Color.FromArgb(11, 160, 92))

        Dim vGraphic = e.Graphics

        vGraphic.FillRectangle(vLinearGradient, RectangleDegrade)

        vGraphic.Dispose() : vGraphic = Nothing
    End Sub

    Private Sub FCDGDefunt_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles FCDGDefunt.CellPainting, FCDGBeneficiaire.CellPainting, DgvCsnsDeEmpl.CellPainting, DgvConcessions.CellPainting

    End Sub

    Private Sub FDBLinkToPersCon_Click(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabDeDefVersPcont.LinkClicked

    End Sub

    Private Sub LinkLabCsnVersCsnr_Click(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabCsnVersCsnr.LinkClicked

    End Sub

    Private Sub BtGererVilles_Click(sender As Object, e As EventArgs) Handles BtGererVilles.Click
        Using f As New GestionLocVille(dtville, dtpays)
            f.ShowDialog()
            ' retire les FKs chez les personnes dont les villes n'existent plus
            If f.IdsVillesSuppr.Count > 0 Then
                Dim Ids As String = "(" & String.Join(",", f.IdsVillesSuppr) & ")"
                For Each t As DataTable In {dtdefunt, dtCsnr, dtbenef, dtPersContact}           ' profite du fait que la prop s'appelle locville_id dans toutes les tables
                    Dim Rows = t.Select("locville_id In " & Ids)
                    For Each Row In Rows
                        Row("locville_id") = DBNull.Value
                    Next
                Next
            End If
            ' met à jour les listes combobox
            ChargerVillesPays()
            ' ce qui oblige à refaire les bindings
            CtrlLocVilleDef.DataBindings.Clear()
            CtrlLocPersonne.DataBindings.Clear()

            CtrlLocVilleDef.DataBindings.Add("LocVilleId", bslistedefunts, "locville_id")
            CtrlLocPersonne.DataBindings.Add("LocVilleId", dvCsnrs, "locville_id")

        End Using
    End Sub
End Class
