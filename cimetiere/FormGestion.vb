Imports System.IO
Public Class FormGestion
    Public dtPersonnes As DataTable
    Public dtcons As DataTable
    Public dtbenef As DataTable
    Public dtdefunt As DataTable
    Public dtCsnr As DataTable
    Public dtPersContact As DataTable
    Public dtBeneficiaireForm As DataTable
    Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
    Dim boutongestion = 0


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        If user = "User" Then
                FPBAjouter.Hide()
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
        DataBindDefunt()
        ProgressBar.Increment(25)
        Lchargementdonnee.Text = "Chargement des données ."
        Threading.Thread.Sleep(500)
        DataTableConcess() '2
        ProgressBar.Increment(40)
        Lchargementdonnee.Text = "Chargement des données . ."
        Threading.Thread.Sleep(500)
        DataTableConcession() '2
        ProgressBar.Increment(55)
        Lchargementdonnee.Text = "Chargement des données . . ."
        Threading.Thread.Sleep(500)
        DataTablePersContact()
        ProgressBar.Increment(70)
        Threading.Thread.Sleep(500)
        DataTableBeneficiaire()
        ProgressBar.Increment(85)
        Threading.Thread.Sleep(500)
        DgvListeConcessionnaireBenef.Show()
        DgvListeConcessionnairePersonneContact.Hide()
        DgvListeConcessionnaireConcess.Hide()
        ProgressBar.Increment(100)
        Threading.Thread.Sleep(500)
        ProgressBar.Hide()
        Me.Size = New Size(1270, 705)
        Me.Left = (screenWidth - Me.Width) / 2
        Me.Top = (screenHeight - Me.Height) / 2
        Panel10.Show()
        Panel3.Show()
        Panel1.Show()
        Lchargementdonnee.Hide()
        TabControl1.Show()

    End Sub


    Sub DataTableDefunt() '1
        dtdefunt = Bdd.Query("select * FROM defunts INNER JOIN t_loc_ville ON defunts.locville_id = t_loc_ville.locville_id INNER JOIN t_pays on t_loc_ville.locville_id = t_pays.Pays_id INNER JOIN emplacements on defunts.empl_id = emplacements.empl_id")
        Dim DTGV_Id_Colonne = New DataGridViewTextBoxColumn()
        Dim ColonnePrenom = New DataGridViewTextBoxColumn()
        Dim colonneid = New DataGridViewTextBoxColumn()
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
        DgvListeDefunts.AutoGenerateColumns = False
        DgvListeDefunts.DataSource = dtdefunt
        DgvListeDefunts.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvListeDefunts.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Sub DataTableConsBeneficiaire(ByRef Optional empl As Integer = 0)
        If empl = 0 Then
            dtbenef = Query("SELECT * FROM beneficiaires INNER JOIN beneficier ON beneficiaires.ben_id = beneficier.ben_id where beneficier.con_id = " & dtcons.Rows(FCDGConss.CurrentRow.Index())("con_id") & "")
        Else
            dtbenef = Query("SELECT * FROM beneficiaires INNER JOIN beneficier ON beneficiaires.ben_id = beneficier.ben_id where beneficier.con_id = " & empl & "")

        End If
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
        FCDGBeneficiaire.AutoGenerateColumns = False
        FCDGBeneficiaire.DataSource = dtbenef
        FCDGBeneficiaire.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        FCDGBeneficiaire.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Sub DataTableConcess() '2
        dtCsnr = Bdd.Query("select * FROM concessionnaires INNER JOIN t_loc_ville ON concessionnaires.locville_id = t_loc_ville.locville_id INNER JOIN t_pays ON t_loc_ville.Pays_id = t_pays.Pays_id")
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
        DgvListeConcessionnaireConcess.DataSource = dtCsnr
        DgvListeConcessionnaireConcess.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvListeConcessionnaireConcess.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub



    Sub DataTableConcession() '2
        dtcons = Bdd.Query("SELECT * FROM concessions INNER JOIN emplacements ON concessions.empl_id = emplacements.empl_id INNER JOIN t_histoire ON concessions.h_id = t_histoire.h_id INNER JOIN t_commentaire ON concessions.com_id = t_commentaire.com_id")
        Dim DTGV_Id_Colonne = New DataGridViewTextBoxColumn()
        Dim ColonnePrenom = New DataGridViewTextBoxColumn()
        Dim colonneid = New DataGridViewTextBoxColumn()
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
        FCDGConss.AutoGenerateColumns = False
        FCDGConss.DataSource = dtcons
        FCDGConss.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        FCDGConss.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub


    Sub DataTableDefuntCons(ByRef Optional empl As Integer = 0)
        If empl = 0 Then

        Else
            dtcons.Rows(FCDGConss.CurrentRow.Index())("empl_id") = empl
        End If

        dtdefunt = Bdd.Query("SELECT * FROM defunts WHERE empl_id = " & dtcons.Rows(FCDGConss.CurrentRow.Index())("empl_id") & "")
        Dim DTGV_Id_Colonne_def = New DataGridViewTextBoxColumn()
        Dim Colonne = New DataGridViewTextBoxColumn()
        Dim colonneid = New DataGridViewTextBoxColumn()
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
        FCDGDefunt.AutoGenerateColumns = False
        FCDGDefunt.DataSource = dtdefunt
        FCDGDefunt.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        FCDGDefunt.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Sub DataTableBeneficiaire()
        dtBeneficiaireForm = Bdd.Query("select * FROM beneficiaires INNER JOIN t_loc_ville ON beneficiaires.locville_id = t_loc_ville.locville_id INNER JOIN t_pays ON t_loc_ville.Pays_id = t_pays.Pays_id")
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
        DgvListeConcessionnaireBenef.DataSource = dtBeneficiaireForm
        DgvListeConcessionnaireBenef.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvListeConcessionnaireBenef.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Sub DataTablePersContact()
        dtPersContact = Bdd.Query("select * FROM personnes_contact INNER JOIN t_loc_ville ON personnes_contact.locville_id = t_loc_ville.locville_id INNER JOIN t_pays ON t_loc_ville.Pays_id = t_pays.Pays_id")
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
        DgvListeConcessionnairePersonneContact.DataSource = dtPersContact
        DgvListeConcessionnairePersonneContact.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvListeConcessionnairePersonneContact.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub


    Private Sub DataBindConsDefunt()
        FCTBnumero.DataBindings.Add("Text", dtcons, "con_numero")
        FCTBEmplacement.DataBindings.Add("Text", dtcons, "empl_reference")
        FCTBMonumentClasse.DataBindings.Add("Text", dtcons, "empl_monum_classe")
        FCTBCommentaire.DataBindings.Add("Text", dtcons, "com_commentaire")
        FCTBHistoire.DataBindings.Add("Text", dtcons, "h_histoire")
        FCTBType.DataBindings.Add("Text", dtcons, "empl_type")
        FCTBDateDeb.DataBindings.Add("Text", dtcons, "con_date_debut")
        FCTBDateFin.DataBindings.Add("Text", dtcons, "con_date_fin")
    End Sub
    Private Sub DataBindConsbenef()
        TBconsBenefnom.DataBindings.Add("Text", dtbenef, "ben_nom")
        TBconsBenefprenom.DataBindings.Add("Text", dtbenef, "ben_prenom")
        TBconsBenefadress.DataBindings.Add("Text", dtbenef, "ben_adresse")
        TBconsBenefdatenaiss.DataBindings.Add("Text", dtbenef, "ben_date_naiss")
    End Sub
    Private Sub DataBindDefunt()
        FPTBNom.DataBindings.Add("Text", dtdefunt, "def_nom")
        FPTBPrenom.DataBindings.Add("Text", dtdefunt, "def_prenom")
        FPTBDateNaiss.DataBindings.Add("Text", dtdefunt, "def_date_naiss")
        FPTBDateE.DataBindings.Add("Text", dtdefunt, "Date_debut")
        FPTBSepulture.DataBindings.Add("Text", dtdefunt, "empl_id")
        FPTBEtatCivil.DataBindings.Add("Text", dtdefunt, "def_etat_civil")
        FPTBAdresse.DataBindings.Add("Text", dtdefunt, "def_adresse")
        FPTBDateM.DataBindings.Add("Text", dtdefunt, "def_date_deces")
        FPTBLieuNaiss.DataBindings.Add("Text", dtdefunt, "def_lieu_naiss")
        FPTBCodeLieu.DataBindings.Add("Text", dtdefunt, "def_etat_civil_de")
        FPTBCodePostal.DataBindings.Add("Text", dtdefunt, "locville_cp")
        FPTBPays.DataBindings.Add("Text", dtdefunt, "Pays_nom")
        FPTBVille.DataBindings.Add("Text", dtdefunt, "locville_ville")
        FPTBEmplacement.DataBindings.Add("Text", dtdefunt, "empl_reference")
    End Sub



    Private Sub DataBindConss()
        TBPersNom.DataBindings.Add("Text", dtCsnr, "csnr_nom")
        TBPersPrenom.DataBindings.Add("Text", dtCsnr, "csnr_prenom")
        TBPersTel.DataBindings.Add("Text", dtCsnr, "csnr_tel")
        TBPersDN.DataBindings.Add("Text", dtCsnr, "csnr_date_naiss")
        TBPersAdress.DataBindings.Add("Text", dtCsnr, "csnr_adresse")
        TBPersCodePostal.DataBindings.Add("Text", dtCsnr, "locville_cp")
        TBPersVille.DataBindings.Add("Text", dtCsnr, "locville_ville")
        TBPersPays.DataBindings.Add("Text", dtCsnr, "Pays_nom")
        TBPersNumNational.DataBindings.Add("Text", dtCsnr, "csnr_no_registre")
    End Sub

    Private Sub DataBindBenef()
        TBPersNom.DataBindings.Add("Text", dtBeneficiaireForm, "ben_nom")
        TBPersPrenom.DataBindings.Add("Text", dtBeneficiaireForm, "ben_prenom")
        TBPersDN.DataBindings.Add("Text", dtBeneficiaireForm, "ben_date_naiss")
        TBPersAdress.DataBindings.Add("Text", dtBeneficiaireForm, "ben_adresse")
        TBPersNumNational.DataBindings.Add("Text", dtBeneficiaireForm, "ben_lien_parente")
        TBPersCodePostal.DataBindings.Add("Text", dtBeneficiaireForm, "locville_cp")
        TBPersVille.DataBindings.Add("Text", dtBeneficiaireForm, "locville_ville")
        TBPersPays.DataBindings.Add("Text", dtBeneficiaireForm, "Pays_nom")
    End Sub

    Private Sub DataBindPersContact()
        TBPersNom.DataBindings.Add("Text", dtPersContact, "pc_nom")
        TBPersPrenom.DataBindings.Add("Text", dtPersContact, "pc_prenom")
        TBPersTel.DataBindings.Add("Text", dtPersContact, "pc_tel")
        TBPersAdress.DataBindings.Add("Text", dtPersContact, "pc_adresse")
        TBPersCodePostal.DataBindings.Add("Text", dtPersContact, "locville_cp")
        TBPersVille.DataBindings.Add("Text", dtPersContact, "locville_ville")
        TBPersPays.DataBindings.Add("Text", dtPersContact, "Pays_nom")
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

    Private Sub DataBindClearConcessions()
        FCTBnumero.DataBindings.Clear()
        FCTBEmplacement.DataBindings.Clear()
        FCTBMonumentClasse.DataBindings.Clear()
        FCTBType.DataBindings.Clear()
        FCTBCommentaire.DataBindings.Clear()
        FCTBHistoire.DataBindings.Clear()
        FCTBDateDeb.DataBindings.Clear()
        FCTBDateFin.DataBindings.Clear()
    End Sub

    Private Sub DataBindClearConcessionsBeneficiaire()
        TBconsBenefnom.DataBindings.Clear()
        TBconsBenefprenom.DataBindings.Clear()
        TBconsBenefadress.DataBindings.Clear()
        TBconsBenefdatenaiss.DataBindings.Clear()
    End Sub

    Private Sub DataBindClearBeneficiaire()
        FPTBNom.DataBindings.Clear()
        FPTBPrenom.DataBindings.Clear()
        FPTBDateNaiss.DataBindings.Clear()
        FPTBDateE.DataBindings.Clear()
        FPTBEtatCivil.DataBindings.Clear()
        FPTBSepulture.DataBindings.Clear()
        FPTBDateM.DataBindings.Clear()
        FPTBEtatCivil.DataBindings.Clear()
        FPTBAdresse.DataBindings.Clear()
        FPTBEmplacement.DataBindings.Clear()
        FPTBLieuNaiss.DataBindings.Clear()
        FPTBCodePostal.DataBindings.Clear()
        FPTBPays.DataBindings.Clear()
        FPTBVille.DataBindings.Clear()
    End Sub

    Private Sub FPBDetails_Click(sender As Object, e As EventArgs) Handles FPBDetails.Click
        Dim FDetails As New FDetails
        FDetails.ShowDialog()
    End Sub

    Private Sub FCBDetails_Click(sender As Object, e As EventArgs) Handles FCBDetails.Click
        Dim FDetails As New FDetails
        FDetails.ShowDialog()
    End Sub

    Private Sub FPBAjouter_Click(sender As Object, e As EventArgs) Handles FPBAjouter.Click
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
        Dim Source As New BindingSource()
        Source.DataSource = Me.DgvListeDefunts.DataSource
        Source.Filter = "def_nom Like '%" & TbDefChampRecherche.Text & "%'"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtDefAnnulerRecherche.Click
        Dim Source As New BindingSource()
        Source.DataSource = Me.DgvListeDefunts.DataSource
        Source.Filter = "def_nom like '%'"
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
        DataBindClearConcessions()
        FCDGBeneficiaire.DataBindings.Clear()
        FCDGBeneficiaire.Columns.Clear()
        FCDGDefunt.DataBindings.Clear()
        FCDGDefunt.Columns.Clear()
        DataTableDefuntCons()
        DataTableConsBeneficiaire()
        DataBindConsDefunt()
        FCTBPlaceOccupe.Text = FCDGDefunt.RowCount - 1
        FCTBPlaceLibre.Text = dtcons.Rows(FCDGConss.CurrentRow.Index())("empl_nb_places") - (FCDGDefunt.RowCount - 1)
        Try
            TBconsBenefcodepostal.Text = GetValeurSql("SELECT * FROM t_loc_ville where locville_id = " & dtbenef.Rows(FCDGBeneficiaire.CurrentRow.Index())("locville_id") & "", "locville_cp")
            TBconsBenefville.Text = GetValeurSql("SELECT * FROM t_loc_ville where locville_id = " & dtbenef.Rows(FCDGBeneficiaire.CurrentRow.Index())("locville_id") & "", "locville_ville")
            TBconsBenefpays.Text = GetValeurSql("Select * From t_loc_ville INNER Join t_pays On t_loc_ville.locville_id = t_pays.Pays_id Where locville_id = " & dtbenef.Rows(FCDGBeneficiaire.CurrentRow.Index())("locville_id") & "", "Pays_nom")

        Catch ex As Exception
            TBconsBenefnom.Text = ""
            TBconsBenefprenom.Text = ""
            TBconsBenefadress.Text = ""
            TBconsBenefdatenaiss.Text = ""
        End Try

    End Sub

    Private Sub FCDGBeneficiaire_SelectionChanged(sender As Object, e As EventArgs) Handles FCDGBeneficiaire.SelectionChanged
        DataBindClearConcessionsBeneficiaire()
        DataBindConsbenef()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Source As New BindingSource()
        Source.DataSource = Me.FCDGConss.DataSource
        Source.Filter = "empl_reference Like '%" & FCTBRechercher.Text & "%'"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Source As New BindingSource()
        Source.DataSource = Me.FCDGConss.DataSource
        Source.Filter = "empl_reference like '%'"
        Dim NbLigne = Me.FCDGConss.CurrentRow.Index
        Dim Nbcolonne = 0
        Dim Val As String = Me.FCDGConss(1, 0).Value

        FCDGDefunt.DataBindings.Clear()
        FCDGDefunt.Columns.Clear()
        DataTableDefuntCons(Bdd.GetValeurSql("select * FROM emplacements where empl_reference = '" & Val & "'", "empl_id"))



    End Sub

    Private Sub FPBLienCons_Click(sender As Object, e As EventArgs) Handles FPBLienCons.Click
        TabControl1.SelectedIndex = 1
        'Dim defuntid = dtPersonnes.Rows(DgvListeDefunts.CurrentRow.Index())("def_id").ToString
        Dim defuntid = Me.DgvListeDefunts(0, 0).Value.ToString
        MsgBox(defuntid)
        Dim id = Bdd.GetValeurSql("select * FROM concessions INNER JOIN emplacements on concessions.empl_id = emplacements.empl_id INNER JOIN defunts ON defunts.empl_id = emplacements.empl_id where defunts.def_id = '" & defuntid & "'", "con_id")
        Dim Source As New BindingSource()
        Source.DataSource = Me.FCDGConss.DataSource
        Source.Filter = "convert([con_id],'System.String') LIKE '" & id & "'"
        Dim NbLigne2 = Me.FCDGConss.CurrentRow.Index

        FCDGDefunt.DataBindings.Clear()
        FCDGDefunt.Columns.Clear()
        DataTableDefuntCons(Bdd.GetValeurSql("select * FROM concessions INNER JOIN emplacements on concessions.empl_id = emplacements.empl_id INNER JOIN defunts ON defunts.empl_id = emplacements.empl_id where defunts.def_id = '" & defuntid & "'", "empl_id"))

        Dim Nbcolonne2 = 0
        Dim Val2 As String = Me.FCDGConss(0, 0).Value
        MsgBox(Val2)

        FCDGBeneficiaire.DataBindings.Clear()
        FCDGBeneficiaire.Columns.Clear()


        DataTableConsBeneficiaire(Bdd.GetValeurSql("select * FROM concessions where con_numero = '" & Val2 & "'", "con_id"))



    End Sub

    Private Sub FCBLienDefunt_Click(sender As Object, e As EventArgs) Handles FCBLienDefunt.Click
        TabControl1.SelectedIndex = 0
        Dim id As String = dtdefunt.Rows(FCDGDefunt.CurrentRow.Index())("def_id").ToString
        Dim Source As New BindingSource()
        Source.DataSource = Me.DgvListeDefunts.DataSource
        Source.Filter = "convert([def_id],'System.String') LIKE '" & id & "'"
    End Sub

    Private Sub TextBoxConsRO()
        FCTBnumero.ReadOnly = True
        FCTBnumero.Cursor = Cursors.No
        If FCTBnumero.BackColor <> SystemColors.Window Then FCTBnumero.BackColor = SystemColors.Window
        FCTBPlaceLibre.ReadOnly = True
        FCTBPlaceLibre.Cursor = Cursors.No
        If FCTBPlaceLibre.BackColor <> SystemColors.Window Then FCTBPlaceLibre.BackColor = SystemColors.Window
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
        TBconsBenefcodepostal.ReadOnly = True
        TBconsBenefcodepostal.Cursor = Cursors.No
        If TBconsBenefcodepostal.BackColor <> SystemColors.Window Then TBconsBenefcodepostal.BackColor = SystemColors.Window
        TBconsBenefdatenaiss.ReadOnly = True
        TBconsBenefdatenaiss.Cursor = Cursors.No
        If TBconsBenefdatenaiss.BackColor <> SystemColors.Window Then TBconsBenefdatenaiss.BackColor = SystemColors.Window
        TBconsBenefnom.ReadOnly = True
        TBconsBenefnom.Cursor = Cursors.No
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
        FPTBPays.ReadOnly = True
        FPTBPays.Cursor = Cursors.No
        If FPTBPays.BackColor <> SystemColors.Window Then FPTBPays.BackColor = SystemColors.Window
        FPTBPrenom.ReadOnly = True
        FPTBPrenom.Cursor = Cursors.No
        If FPTBPrenom.BackColor <> SystemColors.Window Then FPTBPrenom.BackColor = SystemColors.Window
        FPTBSepulture.ReadOnly = True
        FPTBSepulture.Cursor = Cursors.No
        If FPTBSepulture.BackColor <> SystemColors.Window Then FPTBSepulture.BackColor = SystemColors.Window
        FPTBVille.ReadOnly = True
        FPTBVille.Cursor = Cursors.No
        If FPTBVille.BackColor <> SystemColors.Window Then FPTBVille.BackColor = SystemColors.Window
        FPTBLieuNaiss.ReadOnly = True
        FPTBLieuNaiss.Cursor = Cursors.No
        If FPTBLieuNaiss.BackColor <> SystemColors.Window Then FPTBLieuNaiss.BackColor = SystemColors.Window
        FPTBEtatCivil.ReadOnly = True
        FPTBEtatCivil.Cursor = Cursors.No
        If FPTBEtatCivil.BackColor <> SystemColors.Window Then FPTBEtatCivil.BackColor = SystemColors.Window
        FPTBEmplacement.ReadOnly = True
        FPTBEmplacement.Cursor = Cursors.No
        If FPTBEmplacement.BackColor <> SystemColors.Window Then FPTBEmplacement.BackColor = SystemColors.Window
        FPTBDateNaiss.ReadOnly = True
        FPTBDateNaiss.Cursor = Cursors.No
        If FPTBDateNaiss.BackColor <> SystemColors.Window Then FPTBDateNaiss.BackColor = SystemColors.Window
        FPTBDateM.ReadOnly = True
        FPTBDateM.Cursor = Cursors.No
        If FPTBDateM.BackColor <> SystemColors.Window Then FPTBDateM.BackColor = SystemColors.Window
        FPTBDateE.ReadOnly = True
        FPTBDateE.Cursor = Cursors.No
        If FPTBDateE.BackColor <> SystemColors.Window Then FPTBDateE.BackColor = SystemColors.Window
        FPTBCodePostal.ReadOnly = True
        FPTBCodePostal.Cursor = Cursors.No
        If FPTBCodePostal.BackColor <> SystemColors.Window Then FPTBCodePostal.BackColor = SystemColors.Window
        FPTBCodeLieu.ReadOnly = True
        FPTBCodeLieu.Cursor = Cursors.No
        If FPTBCodeLieu.BackColor <> SystemColors.Window Then FPTBCodeLieu.BackColor = SystemColors.Window
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
        FPTBPays.ReadOnly = False
        FPTBPays.Cursor = Cursors.IBeam
        FPTBPrenom.ReadOnly = False
        FPTBPrenom.Cursor = Cursors.IBeam
        FPTBSepulture.ReadOnly = False
        FPTBSepulture.Cursor = Cursors.IBeam
        FPTBVille.ReadOnly = False
        FPTBVille.Cursor = Cursors.IBeam
        FPTBLieuNaiss.ReadOnly = False
        FPTBLieuNaiss.Cursor = Cursors.IBeam
        FPTBEtatCivil.ReadOnly = False
        FPTBEtatCivil.Cursor = Cursors.IBeam
        FPTBEmplacement.ReadOnly = False
        FPTBEmplacement.Cursor = Cursors.IBeam
        FPTBDateNaiss.ReadOnly = False
        FPTBDateNaiss.Cursor = Cursors.IBeam
        FPTBDateM.ReadOnly = False
        FPTBDateM.Cursor = Cursors.IBeam
        FPTBDateE.ReadOnly = False
        FPTBDateE.Cursor = Cursors.IBeam
        FPTBCodePostal.ReadOnly = False
        FPTBCodePostal.Cursor = Cursors.IBeam
        FPTBCodeLieu.ReadOnly = False
        FPTBCodeLieu.Cursor = Cursors.IBeam
        FPTBAdresse.ReadOnly = False
        FPTBAdresse.Cursor = Cursors.IBeam
    End Sub

    Private Sub TextBoxConsUpd()
        FCTBnumero.ReadOnly = False
        FCTBnumero.Cursor = Cursors.IBeam
        FCTBPlaceLibre.ReadOnly = False
        FCTBPlaceLibre.Cursor = Cursors.IBeam
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
        TBconsBenefcodepostal.ReadOnly = False
        TBconsBenefcodepostal.Cursor = Cursors.IBeam
        TBconsBenefdatenaiss.ReadOnly = False
        TBconsBenefdatenaiss.Cursor = Cursors.IBeam
        TBconsBenefnom.ReadOnly = False
        TBconsBenefnom.Cursor = Cursors.IBeam
        TBconsBenefpays.ReadOnly = False
        TBconsBenefpays.Cursor = Cursors.IBeam
        TBconsBenefprenom.ReadOnly = False
        TBconsBenefprenom.Cursor = Cursors.IBeam
        TBconsBenefville.ReadOnly = False
        TBconsBenefville.Cursor = Cursors.IBeam
    End Sub

    Private Sub FPBModifier_Click(sender As Object, e As EventArgs) Handles FPBModifier.Click
        If boutongestion = 0 Then
            TextBoxDefuntUpd()
            boutongestion = 1
            FPBModifier.Text = "Sauvegarder"
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
                boutongestion = 0
                FPBModifier.Text = "Modifier"
                TextBoxDefuntRO()
                TabControl1.TabPages(1).Enabled = True
                TabControl1.TabPages(2).Enabled = True
            End If
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
End Class
