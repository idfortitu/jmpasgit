<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGestion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGestion))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DgvListeDefunts = New System.Windows.Forms.DataGridView()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.BtDefAnnulerRecherche = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtpDefRechercherDateDecesApres = New System.Windows.Forms.DateTimePicker()
        Me.DtpDefRechercherDateDecesAvant = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbDefChampRecherche = New System.Windows.Forms.TextBox()
        Me.CbDefChercherNom = New System.Windows.Forms.CheckBox()
        Me.CbDefChercherCode = New System.Windows.Forms.CheckBox()
        Me.CbDefChercherEmplacement = New System.Windows.Forms.CheckBox()
        Me.BtDefChercher = New System.Windows.Forms.Button()
        Me.FPBAjouter = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FPTBVille = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.FPTBLieuNaiss = New System.Windows.Forms.TextBox()
        Me.FPLLieuNaiss = New System.Windows.Forms.Label()
        Me.FPTBEtatCivil = New System.Windows.Forms.TextBox()
        Me.FPLEtatCivil = New System.Windows.Forms.Label()
        Me.FPTBPays = New System.Windows.Forms.TextBox()
        Me.FPLPays = New System.Windows.Forms.Label()
        Me.FPTBCodePostal = New System.Windows.Forms.TextBox()
        Me.FPLCodePostal = New System.Windows.Forms.Label()
        Me.FPTBAdresse = New System.Windows.Forms.TextBox()
        Me.FPLAdresse = New System.Windows.Forms.Label()
        Me.FPTBCodeLieu = New System.Windows.Forms.TextBox()
        Me.FPTBEmplacement = New System.Windows.Forms.TextBox()
        Me.FPTBDateM = New System.Windows.Forms.TextBox()
        Me.FPTBPrenom = New System.Windows.Forms.TextBox()
        Me.FPLCodeLieu = New System.Windows.Forms.Label()
        Me.FPLEmplacement = New System.Windows.Forms.Label()
        Me.FPLDateM = New System.Windows.Forms.Label()
        Me.FPLPrenom = New System.Windows.Forms.Label()
        Me.FPTBDateE = New System.Windows.Forms.TextBox()
        Me.FPTBSepulture = New System.Windows.Forms.TextBox()
        Me.FPTBDateNaiss = New System.Windows.Forms.TextBox()
        Me.FPLDateEnt = New System.Windows.Forms.Label()
        Me.FPLSepulture = New System.Windows.Forms.Label()
        Me.FPLDateNaiss = New System.Windows.Forms.Label()
        Me.FPTBNom = New System.Windows.Forms.TextBox()
        Me.FPLNom = New System.Windows.Forms.Label()
        Me.FPBSupprimer = New System.Windows.Forms.Button()
        Me.FPBModifier = New System.Windows.Forms.Button()
        Me.FPBDetails = New System.Windows.Forms.Button()
        Me.FPBLienCons = New System.Windows.Forms.Button()
        Me.FPTBLahulpe = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.FCDGDefunt = New System.Windows.Forms.DataGridView()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.FCDGBeneficiaire = New System.Windows.Forms.DataGridView()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TBconsBenefpays = New System.Windows.Forms.TextBox()
        Me.TBconsBenefville = New System.Windows.Forms.TextBox()
        Me.TBconsBenefdatenaiss = New System.Windows.Forms.TextBox()
        Me.TBconsBenefcodepostal = New System.Windows.Forms.TextBox()
        Me.TBconsBenefadress = New System.Windows.Forms.TextBox()
        Me.TBconsBenefnom = New System.Windows.Forms.TextBox()
        Me.TBconsBenefprenom = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.FCDGConss = New System.Windows.Forms.DataGridView()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.FCTBDateDeb = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.FCTBDateFin = New System.Windows.Forms.TextBox()
        Me.FCLDenomination = New System.Windows.Forms.Label()
        Me.FCTBnumero = New System.Windows.Forms.TextBox()
        Me.FCLEmplacement = New System.Windows.Forms.Label()
        Me.FCTBEmplacement = New System.Windows.Forms.TextBox()
        Me.FCLPlaceLibre = New System.Windows.Forms.Label()
        Me.FCTBPlaceLibre = New System.Windows.Forms.TextBox()
        Me.FCLPlaceOccupe = New System.Windows.Forms.Label()
        Me.FCTBPlaceOccupe = New System.Windows.Forms.TextBox()
        Me.FCTBMonumentClasse = New System.Windows.Forms.TextBox()
        Me.FCLCommentaire = New System.Windows.Forms.Label()
        Me.FCTBCommentaire = New System.Windows.Forms.TextBox()
        Me.FCLMonumentC = New System.Windows.Forms.Label()
        Me.FCLHistoire = New System.Windows.Forms.Label()
        Me.FCTBHistoire = New System.Windows.Forms.TextBox()
        Me.FCLType = New System.Windows.Forms.Label()
        Me.FCTBType = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.FCTBRechercher = New System.Windows.Forms.TextBox()
        Me.FCCBNom = New System.Windows.Forms.CheckBox()
        Me.FCCBEmplacement = New System.Windows.Forms.CheckBox()
        Me.FCCBType = New System.Windows.Forms.CheckBox()
        Me.FCBSupp = New System.Windows.Forms.Button()
        Me.FCBModifier = New System.Windows.Forms.Button()
        Me.FCBAjouter = New System.Windows.Forms.Button()
        Me.FCBLienDefunt = New System.Windows.Forms.Button()
        Me.FCBDetails = New System.Windows.Forms.Button()
        Me.FCPBlahulpe = New System.Windows.Forms.PictureBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.TBPersNumNational = New System.Windows.Forms.TextBox()
        Me.TBPersPays = New System.Windows.Forms.TextBox()
        Me.TBPersDN = New System.Windows.Forms.TextBox()
        Me.TBPersVille = New System.Windows.Forms.TextBox()
        Me.TBPersTel = New System.Windows.Forms.TextBox()
        Me.TBPersCodePostal = New System.Windows.Forms.TextBox()
        Me.TBPersAdress = New System.Windows.Forms.TextBox()
        Me.TBPersNom = New System.Windows.Forms.TextBox()
        Me.TBPersPrenom = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.PRBPersCon = New System.Windows.Forms.RadioButton()
        Me.PRBConcessionnaire = New System.Windows.Forms.RadioButton()
        Me.PRBBenef = New System.Windows.Forms.RadioButton()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.DgvListeConcessionnaire = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TbDateDeces = New cimetiere.TextBoxDate()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgvListeDefunts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.FPTBLahulpe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.FCDGDefunt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.FCDGBeneficiaire, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.FCDGConss, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.FCPBlahulpe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        CType(Me.DgvListeConcessionnaire, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(64, 32)
        Me.TabControl1.Location = New System.Drawing.Point(-4, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1270, 705)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.Panel10)
        Me.TabPage1.Controls.Add(Me.FPBAjouter)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.FPBSupprimer)
        Me.TabPage1.Controls.Add(Me.FPBModifier)
        Me.TabPage1.Controls.Add(Me.FPBDetails)
        Me.TabPage1.Controls.Add(Me.FPBLienCons)
        Me.TabPage1.Controls.Add(Me.FPTBLahulpe)
        Me.TabPage1.Location = New System.Drawing.Point(4, 36)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1262, 665)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Défunt"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel3.Controls.Add(Me.GroupBox3)
        Me.Panel3.Location = New System.Drawing.Point(274, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(403, 513)
        Me.Panel3.TabIndex = 97
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox3.Controls.Add(Me.DgvListeDefunts)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(381, 496)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'DgvListeDefunts
        '
        Me.DgvListeDefunts.AllowUserToAddRows = False
        Me.DgvListeDefunts.AllowUserToDeleteRows = False
        Me.DgvListeDefunts.AllowUserToOrderColumns = True
        Me.DgvListeDefunts.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DgvListeDefunts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvListeDefunts.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DgvListeDefunts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvListeDefunts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListeDefunts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvListeDefunts.EnableHeadersVisualStyles = False
        Me.DgvListeDefunts.GridColor = System.Drawing.Color.DarkGray
        Me.DgvListeDefunts.Location = New System.Drawing.Point(8, 15)
        Me.DgvListeDefunts.MultiSelect = False
        Me.DgvListeDefunts.Name = "DgvListeDefunts"
        Me.DgvListeDefunts.ReadOnly = True
        Me.DgvListeDefunts.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DgvListeDefunts.RowHeadersVisible = False
        Me.DgvListeDefunts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvListeDefunts.Size = New System.Drawing.Size(367, 476)
        Me.DgvListeDefunts.TabIndex = 48
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel10.Controls.Add(Me.GroupBox10)
        Me.Panel10.Location = New System.Drawing.Point(9, 87)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(242, 222)
        Me.Panel10.TabIndex = 96
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.White
        Me.GroupBox10.Controls.Add(Me.BtDefAnnulerRecherche)
        Me.GroupBox10.Controls.Add(Me.Label3)
        Me.GroupBox10.Controls.Add(Me.Label2)
        Me.GroupBox10.Controls.Add(Me.DtpDefRechercherDateDecesApres)
        Me.GroupBox10.Controls.Add(Me.DtpDefRechercherDateDecesAvant)
        Me.GroupBox10.Controls.Add(Me.Label1)
        Me.GroupBox10.Controls.Add(Me.TbDefChampRecherche)
        Me.GroupBox10.Controls.Add(Me.CbDefChercherNom)
        Me.GroupBox10.Controls.Add(Me.CbDefChercherCode)
        Me.GroupBox10.Controls.Add(Me.CbDefChercherEmplacement)
        Me.GroupBox10.Controls.Add(Me.BtDefChercher)
        Me.GroupBox10.Location = New System.Drawing.Point(14, 8)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(212, 204)
        Me.GroupBox10.TabIndex = 0
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Rechercher"
        '
        'BtDefAnnulerRecherche
        '
        Me.BtDefAnnulerRecherche.Location = New System.Drawing.Point(37, 172)
        Me.BtDefAnnulerRecherche.Name = "BtDefAnnulerRecherche"
        Me.BtDefAnnulerRecherche.Size = New System.Drawing.Size(68, 23)
        Me.BtDefAnnulerRecherche.TabIndex = 97
        Me.BtDefAnnulerRecherche.Text = "Annuler filtre"
        Me.BtDefAnnulerRecherche.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 14)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Décédé après :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 14)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "Décédé avant :"
        '
        'DtpDefRechercherDateDecesApres
        '
        Me.DtpDefRechercherDateDecesApres.Checked = False
        Me.DtpDefRechercherDateDecesApres.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDefRechercherDateDecesApres.Location = New System.Drawing.Point(93, 114)
        Me.DtpDefRechercherDateDecesApres.Name = "DtpDefRechercherDateDecesApres"
        Me.DtpDefRechercherDateDecesApres.ShowCheckBox = True
        Me.DtpDefRechercherDateDecesApres.Size = New System.Drawing.Size(113, 21)
        Me.DtpDefRechercherDateDecesApres.TabIndex = 94
        '
        'DtpDefRechercherDateDecesAvant
        '
        Me.DtpDefRechercherDateDecesAvant.Checked = False
        Me.DtpDefRechercherDateDecesAvant.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDefRechercherDateDecesAvant.Location = New System.Drawing.Point(93, 141)
        Me.DtpDefRechercherDateDecesAvant.Name = "DtpDefRechercherDateDecesAvant"
        Me.DtpDefRechercherDateDecesAvant.ShowCheckBox = True
        Me.DtpDefRechercherDateDecesAvant.Size = New System.Drawing.Size(113, 21)
        Me.DtpDefRechercherDateDecesAvant.TabIndex = 93
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 14)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Dans :"
        '
        'TbDefChampRecherche
        '
        Me.TbDefChampRecherche.Location = New System.Drawing.Point(10, 20)
        Me.TbDefChampRecherche.Name = "TbDefChampRecherche"
        Me.TbDefChampRecherche.Size = New System.Drawing.Size(150, 21)
        Me.TbDefChampRecherche.TabIndex = 40
        '
        'CbDefChercherNom
        '
        Me.CbDefChercherNom.AutoSize = True
        Me.CbDefChercherNom.Checked = True
        Me.CbDefChercherNom.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbDefChercherNom.Location = New System.Drawing.Point(10, 69)
        Me.CbDefChercherNom.Name = "CbDefChercherNom"
        Me.CbDefChercherNom.Size = New System.Drawing.Size(50, 18)
        Me.CbDefChercherNom.TabIndex = 45
        Me.CbDefChercherNom.Text = "Nom"
        Me.CbDefChercherNom.UseVisualStyleBackColor = True
        '
        'CbDefChercherCode
        '
        Me.CbDefChercherCode.AutoSize = True
        Me.CbDefChercherCode.Checked = True
        Me.CbDefChercherCode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbDefChercherCode.Location = New System.Drawing.Point(97, 88)
        Me.CbDefChercherCode.Name = "CbDefChercherCode"
        Me.CbDefChercherCode.Size = New System.Drawing.Size(53, 18)
        Me.CbDefChercherCode.TabIndex = 46
        Me.CbDefChercherCode.Text = "Code"
        Me.CbDefChercherCode.UseVisualStyleBackColor = True
        '
        'CbDefChercherEmplacement
        '
        Me.CbDefChercherEmplacement.AutoSize = True
        Me.CbDefChercherEmplacement.Checked = True
        Me.CbDefChercherEmplacement.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbDefChercherEmplacement.Location = New System.Drawing.Point(10, 88)
        Me.CbDefChercherEmplacement.Name = "CbDefChercherEmplacement"
        Me.CbDefChercherEmplacement.Size = New System.Drawing.Size(94, 18)
        Me.CbDefChercherEmplacement.TabIndex = 47
        Me.CbDefChercherEmplacement.Text = "Emplacement"
        Me.CbDefChercherEmplacement.UseVisualStyleBackColor = True
        '
        'BtDefChercher
        '
        Me.BtDefChercher.Location = New System.Drawing.Point(126, 172)
        Me.BtDefChercher.Name = "BtDefChercher"
        Me.BtDefChercher.Size = New System.Drawing.Size(73, 23)
        Me.BtDefChercher.TabIndex = 49
        Me.BtDefChercher.Text = "Rechercher"
        Me.BtDefChercher.UseVisualStyleBackColor = True
        '
        'FPBAjouter
        '
        Me.FPBAjouter.BackColor = System.Drawing.Color.SeaGreen
        Me.FPBAjouter.ForeColor = System.Drawing.Color.Transparent
        Me.FPBAjouter.Location = New System.Drawing.Point(749, 296)
        Me.FPBAjouter.Name = "FPBAjouter"
        Me.FPBAjouter.Size = New System.Drawing.Size(64, 23)
        Me.FPBAjouter.TabIndex = 88
        Me.FPBAjouter.Text = "Ajouter"
        Me.FPBAjouter.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(710, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(543, 266)
        Me.Panel1.TabIndex = 92
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.FPTBVille)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.FPTBLieuNaiss)
        Me.GroupBox1.Controls.Add(Me.FPLLieuNaiss)
        Me.GroupBox1.Controls.Add(Me.FPTBEtatCivil)
        Me.GroupBox1.Controls.Add(Me.FPLEtatCivil)
        Me.GroupBox1.Controls.Add(Me.FPTBPays)
        Me.GroupBox1.Controls.Add(Me.FPLPays)
        Me.GroupBox1.Controls.Add(Me.FPTBCodePostal)
        Me.GroupBox1.Controls.Add(Me.FPLCodePostal)
        Me.GroupBox1.Controls.Add(Me.FPTBAdresse)
        Me.GroupBox1.Controls.Add(Me.FPLAdresse)
        Me.GroupBox1.Controls.Add(Me.FPTBCodeLieu)
        Me.GroupBox1.Controls.Add(Me.FPTBEmplacement)
        Me.GroupBox1.Controls.Add(Me.FPTBDateM)
        Me.GroupBox1.Controls.Add(Me.FPTBPrenom)
        Me.GroupBox1.Controls.Add(Me.FPLCodeLieu)
        Me.GroupBox1.Controls.Add(Me.FPLEmplacement)
        Me.GroupBox1.Controls.Add(Me.FPLDateM)
        Me.GroupBox1.Controls.Add(Me.FPLPrenom)
        Me.GroupBox1.Controls.Add(Me.FPTBDateE)
        Me.GroupBox1.Controls.Add(Me.FPTBSepulture)
        Me.GroupBox1.Controls.Add(Me.FPTBDateNaiss)
        Me.GroupBox1.Controls.Add(Me.FPLDateEnt)
        Me.GroupBox1.Controls.Add(Me.FPLSepulture)
        Me.GroupBox1.Controls.Add(Me.FPLDateNaiss)
        Me.GroupBox1.Controls.Add(Me.FPTBNom)
        Me.GroupBox1.Controls.Add(Me.FPLNom)
        Me.GroupBox1.Controls.Add(Me.TbDateDeces)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(511, 240)
        Me.GroupBox1.TabIndex = 93
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informations du défunt"
        '
        'FPTBVille
        '
        Me.FPTBVille.Location = New System.Drawing.Point(359, 211)
        Me.FPTBVille.Name = "FPTBVille"
        Me.FPTBVille.Size = New System.Drawing.Size(126, 21)
        Me.FPTBVille.TabIndex = 141
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(295, 214)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 14)
        Me.Label15.TabIndex = 140
        Me.Label15.Text = "Ville :"
        '
        'FPTBLieuNaiss
        '
        Me.FPTBLieuNaiss.Location = New System.Drawing.Point(119, 177)
        Me.FPTBLieuNaiss.Name = "FPTBLieuNaiss"
        Me.FPTBLieuNaiss.Size = New System.Drawing.Size(152, 21)
        Me.FPTBLieuNaiss.TabIndex = 139
        '
        'FPLLieuNaiss
        '
        Me.FPLLieuNaiss.AutoSize = True
        Me.FPLLieuNaiss.Location = New System.Drawing.Point(9, 181)
        Me.FPLLieuNaiss.Name = "FPLLieuNaiss"
        Me.FPLLieuNaiss.Size = New System.Drawing.Size(104, 14)
        Me.FPLLieuNaiss.TabIndex = 138
        Me.FPLLieuNaiss.Text = "Lieu de Naissance :"
        '
        'FPTBEtatCivil
        '
        Me.FPTBEtatCivil.Location = New System.Drawing.Point(346, 85)
        Me.FPTBEtatCivil.Name = "FPTBEtatCivil"
        Me.FPTBEtatCivil.Size = New System.Drawing.Size(152, 21)
        Me.FPTBEtatCivil.TabIndex = 137
        '
        'FPLEtatCivil
        '
        Me.FPLEtatCivil.AutoSize = True
        Me.FPLEtatCivil.Location = New System.Drawing.Point(291, 88)
        Me.FPLEtatCivil.Name = "FPLEtatCivil"
        Me.FPLEtatCivil.Size = New System.Drawing.Size(57, 14)
        Me.FPLEtatCivil.TabIndex = 136
        Me.FPLEtatCivil.Text = "Etat Civil :"
        '
        'FPTBPays
        '
        Me.FPTBPays.Location = New System.Drawing.Point(119, 82)
        Me.FPTBPays.Name = "FPTBPays"
        Me.FPTBPays.Size = New System.Drawing.Size(152, 21)
        Me.FPTBPays.TabIndex = 135
        '
        'FPLPays
        '
        Me.FPLPays.AutoSize = True
        Me.FPLPays.Location = New System.Drawing.Point(71, 83)
        Me.FPLPays.Name = "FPLPays"
        Me.FPLPays.Size = New System.Drawing.Size(35, 14)
        Me.FPLPays.TabIndex = 134
        Me.FPLPays.Text = "Pays :"
        '
        'FPTBCodePostal
        '
        Me.FPTBCodePostal.Location = New System.Drawing.Point(346, 50)
        Me.FPTBCodePostal.Name = "FPTBCodePostal"
        Me.FPTBCodePostal.Size = New System.Drawing.Size(152, 21)
        Me.FPTBCodePostal.TabIndex = 133
        '
        'FPLCodePostal
        '
        Me.FPLCodePostal.AutoSize = True
        Me.FPLCodePostal.Location = New System.Drawing.Point(277, 50)
        Me.FPLCodePostal.Name = "FPLCodePostal"
        Me.FPLCodePostal.Size = New System.Drawing.Size(69, 14)
        Me.FPLCodePostal.TabIndex = 132
        Me.FPLCodePostal.Text = "Code postal"
        '
        'FPTBAdresse
        '
        Me.FPTBAdresse.Location = New System.Drawing.Point(119, 47)
        Me.FPTBAdresse.Name = "FPTBAdresse"
        Me.FPTBAdresse.Size = New System.Drawing.Size(152, 21)
        Me.FPTBAdresse.TabIndex = 131
        '
        'FPLAdresse
        '
        Me.FPLAdresse.AutoSize = True
        Me.FPLAdresse.Location = New System.Drawing.Point(58, 50)
        Me.FPLAdresse.Name = "FPLAdresse"
        Me.FPLAdresse.Size = New System.Drawing.Size(53, 14)
        Me.FPLAdresse.TabIndex = 130
        Me.FPLAdresse.Text = "Adresse :"
        '
        'FPTBCodeLieu
        '
        Me.FPTBCodeLieu.Location = New System.Drawing.Point(119, 114)
        Me.FPTBCodeLieu.Name = "FPTBCodeLieu"
        Me.FPTBCodeLieu.Size = New System.Drawing.Size(152, 21)
        Me.FPTBCodeLieu.TabIndex = 129
        '
        'FPTBEmplacement
        '
        Me.FPTBEmplacement.Location = New System.Drawing.Point(365, 177)
        Me.FPTBEmplacement.Name = "FPTBEmplacement"
        Me.FPTBEmplacement.Size = New System.Drawing.Size(133, 21)
        Me.FPTBEmplacement.TabIndex = 128
        '
        'FPTBDateM
        '
        Me.FPTBDateM.Location = New System.Drawing.Point(346, 113)
        Me.FPTBDateM.Name = "FPTBDateM"
        Me.FPTBDateM.Size = New System.Drawing.Size(152, 21)
        Me.FPTBDateM.TabIndex = 127
        '
        'FPTBPrenom
        '
        Me.FPTBPrenom.Location = New System.Drawing.Point(346, 20)
        Me.FPTBPrenom.Name = "FPTBPrenom"
        Me.FPTBPrenom.Size = New System.Drawing.Size(152, 21)
        Me.FPTBPrenom.TabIndex = 126
        '
        'FPLCodeLieu
        '
        Me.FPLCodeLieu.AutoSize = True
        Me.FPLCodeLieu.Location = New System.Drawing.Point(74, 117)
        Me.FPLCodeLieu.Name = "FPLCodeLieu"
        Me.FPLCodeLieu.Size = New System.Drawing.Size(27, 14)
        Me.FPLCodeLieu.TabIndex = 125
        Me.FPLCodeLieu.Text = "De :"
        '
        'FPLEmplacement
        '
        Me.FPLEmplacement.AutoSize = True
        Me.FPLEmplacement.Location = New System.Drawing.Point(277, 180)
        Me.FPLEmplacement.Name = "FPLEmplacement"
        Me.FPLEmplacement.Size = New System.Drawing.Size(81, 14)
        Me.FPLEmplacement.TabIndex = 124
        Me.FPLEmplacement.Text = "Emplacement :"
        '
        'FPLDateM
        '
        Me.FPLDateM.AutoSize = True
        Me.FPLDateM.Location = New System.Drawing.Point(310, 118)
        Me.FPLDateM.Name = "FPLDateM"
        Me.FPLDateM.Size = New System.Drawing.Size(31, 14)
        Me.FPLDateM.TabIndex = 123
        Me.FPLDateM.Text = "DM :"
        '
        'FPLPrenom
        '
        Me.FPLPrenom.AutoSize = True
        Me.FPLPrenom.Location = New System.Drawing.Point(291, 20)
        Me.FPLPrenom.Name = "FPLPrenom"
        Me.FPLPrenom.Size = New System.Drawing.Size(52, 14)
        Me.FPLPrenom.TabIndex = 122
        Me.FPLPrenom.Text = "Prenom :"
        '
        'FPTBDateE
        '
        Me.FPTBDateE.Location = New System.Drawing.Point(346, 145)
        Me.FPTBDateE.Name = "FPTBDateE"
        Me.FPTBDateE.Size = New System.Drawing.Size(152, 21)
        Me.FPTBDateE.TabIndex = 121
        '
        'FPTBSepulture
        '
        Me.FPTBSepulture.Location = New System.Drawing.Point(119, 211)
        Me.FPTBSepulture.Name = "FPTBSepulture"
        Me.FPTBSepulture.Size = New System.Drawing.Size(126, 21)
        Me.FPTBSepulture.TabIndex = 120
        '
        'FPTBDateNaiss
        '
        Me.FPTBDateNaiss.Location = New System.Drawing.Point(119, 145)
        Me.FPTBDateNaiss.Name = "FPTBDateNaiss"
        Me.FPTBDateNaiss.Size = New System.Drawing.Size(152, 21)
        Me.FPTBDateNaiss.TabIndex = 119
        '
        'FPLDateEnt
        '
        Me.FPLDateEnt.AutoSize = True
        Me.FPLDateEnt.Location = New System.Drawing.Point(310, 148)
        Me.FPLDateEnt.Name = "FPLDateEnt"
        Me.FPLDateEnt.Size = New System.Drawing.Size(27, 14)
        Me.FPLDateEnt.TabIndex = 118
        Me.FPLDateEnt.Text = "DE :"
        '
        'FPLSepulture
        '
        Me.FPLSepulture.AutoSize = True
        Me.FPLSepulture.Location = New System.Drawing.Point(55, 214)
        Me.FPLSepulture.Name = "FPLSepulture"
        Me.FPLSepulture.Size = New System.Drawing.Size(63, 14)
        Me.FPLSepulture.TabIndex = 117
        Me.FPLSepulture.Text = "Sepulture :"
        '
        'FPLDateNaiss
        '
        Me.FPLDateNaiss.AutoSize = True
        Me.FPLDateNaiss.Location = New System.Drawing.Point(77, 149)
        Me.FPLDateNaiss.Name = "FPLDateNaiss"
        Me.FPLDateNaiss.Size = New System.Drawing.Size(29, 14)
        Me.FPLDateNaiss.TabIndex = 116
        Me.FPLDateNaiss.Text = "DN :"
        '
        'FPTBNom
        '
        Me.FPTBNom.Location = New System.Drawing.Point(119, 14)
        Me.FPTBNom.Name = "FPTBNom"
        Me.FPTBNom.Size = New System.Drawing.Size(152, 21)
        Me.FPTBNom.TabIndex = 115
        '
        'FPLNom
        '
        Me.FPLNom.AutoSize = True
        Me.FPLNom.Location = New System.Drawing.Point(65, 17)
        Me.FPLNom.Name = "FPLNom"
        Me.FPLNom.Size = New System.Drawing.Size(37, 14)
        Me.FPLNom.TabIndex = 114
        Me.FPLNom.Text = "Nom :"
        '
        'FPBSupprimer
        '
        Me.FPBSupprimer.BackColor = System.Drawing.Color.SeaGreen
        Me.FPBSupprimer.ForeColor = System.Drawing.Color.Transparent
        Me.FPBSupprimer.Location = New System.Drawing.Point(917, 296)
        Me.FPBSupprimer.Name = "FPBSupprimer"
        Me.FPBSupprimer.Size = New System.Drawing.Size(74, 23)
        Me.FPBSupprimer.TabIndex = 90
        Me.FPBSupprimer.Text = "Supprimer"
        Me.FPBSupprimer.UseVisualStyleBackColor = False
        '
        'FPBModifier
        '
        Me.FPBModifier.BackColor = System.Drawing.Color.SeaGreen
        Me.FPBModifier.ForeColor = System.Drawing.Color.Transparent
        Me.FPBModifier.Location = New System.Drawing.Point(835, 296)
        Me.FPBModifier.Name = "FPBModifier"
        Me.FPBModifier.Size = New System.Drawing.Size(64, 23)
        Me.FPBModifier.TabIndex = 89
        Me.FPBModifier.Text = "Modifier"
        Me.FPBModifier.UseVisualStyleBackColor = False
        '
        'FPBDetails
        '
        Me.FPBDetails.BackColor = System.Drawing.Color.SeaGreen
        Me.FPBDetails.ForeColor = System.Drawing.Color.Transparent
        Me.FPBDetails.Location = New System.Drawing.Point(1149, 329)
        Me.FPBDetails.Name = "FPBDetails"
        Me.FPBDetails.Size = New System.Drawing.Size(99, 48)
        Me.FPBDetails.TabIndex = 87
        Me.FPBDetails.Text = "Détails"
        Me.FPBDetails.UseVisualStyleBackColor = False
        '
        'FPBLienCons
        '
        Me.FPBLienCons.BackColor = System.Drawing.Color.SeaGreen
        Me.FPBLienCons.ForeColor = System.Drawing.Color.Transparent
        Me.FPBLienCons.Location = New System.Drawing.Point(1099, 279)
        Me.FPBLienCons.Name = "FPBLienCons"
        Me.FPBLienCons.Size = New System.Drawing.Size(152, 48)
        Me.FPBLienCons.TabIndex = 86
        Me.FPBLienCons.Text = "Lien vers concession"
        Me.FPBLienCons.UseVisualStyleBackColor = False
        '
        'FPTBLahulpe
        '
        Me.FPTBLahulpe.Image = CType(resources.GetObject("FPTBLahulpe.Image"), System.Drawing.Image)
        Me.FPTBLahulpe.Location = New System.Drawing.Point(0, 3)
        Me.FPTBLahulpe.Name = "FPTBLahulpe"
        Me.FPTBLahulpe.Size = New System.Drawing.Size(111, 77)
        Me.FPTBLahulpe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FPTBLahulpe.TabIndex = 50
        Me.FPTBLahulpe.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.GhostWhite
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.Panel9)
        Me.TabPage2.Controls.Add(Me.Panel8)
        Me.TabPage2.Controls.Add(Me.Panel7)
        Me.TabPage2.Controls.Add(Me.Panel5)
        Me.TabPage2.Controls.Add(Me.Panel6)
        Me.TabPage2.Controls.Add(Me.Panel4)
        Me.TabPage2.Controls.Add(Me.FCBSupp)
        Me.TabPage2.Controls.Add(Me.FCBModifier)
        Me.TabPage2.Controls.Add(Me.FCBAjouter)
        Me.TabPage2.Controls.Add(Me.FCBLienDefunt)
        Me.TabPage2.Controls.Add(Me.FCBDetails)
        Me.TabPage2.Controls.Add(Me.FCPBlahulpe)
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1262, 665)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Concession"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel9.Controls.Add(Me.GroupBox9)
        Me.Panel9.Location = New System.Drawing.Point(303, 212)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(349, 200)
        Me.Panel9.TabIndex = 131
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.White
        Me.GroupBox9.Controls.Add(Me.FCDGDefunt)
        Me.GroupBox9.Location = New System.Drawing.Point(17, 14)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(312, 166)
        Me.GroupBox9.TabIndex = 0
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Défunt :"
        '
        'FCDGDefunt
        '
        Me.FCDGDefunt.BackgroundColor = System.Drawing.Color.White
        Me.FCDGDefunt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FCDGDefunt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FCDGDefunt.EnableHeadersVisualStyles = False
        Me.FCDGDefunt.Location = New System.Drawing.Point(0, 14)
        Me.FCDGDefunt.Name = "FCDGDefunt"
        Me.FCDGDefunt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FCDGDefunt.RowHeadersVisible = False
        Me.FCDGDefunt.Size = New System.Drawing.Size(312, 152)
        Me.FCDGDefunt.TabIndex = 92
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel8.Controls.Add(Me.GroupBox8)
        Me.Panel8.Location = New System.Drawing.Point(303, 418)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(349, 200)
        Me.Panel8.TabIndex = 131
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.White
        Me.GroupBox8.Controls.Add(Me.FCDGBeneficiaire)
        Me.GroupBox8.Location = New System.Drawing.Point(17, 14)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(312, 166)
        Me.GroupBox8.TabIndex = 0
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Bénéficiaire :"
        '
        'FCDGBeneficiaire
        '
        Me.FCDGBeneficiaire.BackgroundColor = System.Drawing.Color.White
        Me.FCDGBeneficiaire.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FCDGBeneficiaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FCDGBeneficiaire.EnableHeadersVisualStyles = False
        Me.FCDGBeneficiaire.Location = New System.Drawing.Point(0, 17)
        Me.FCDGBeneficiaire.Name = "FCDGBeneficiaire"
        Me.FCDGBeneficiaire.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FCDGBeneficiaire.RowHeadersVisible = False
        Me.FCDGBeneficiaire.Size = New System.Drawing.Size(312, 149)
        Me.FCDGBeneficiaire.TabIndex = 93
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel7.Controls.Add(Me.GroupBox7)
        Me.Panel7.Location = New System.Drawing.Point(694, 418)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(536, 200)
        Me.Panel7.TabIndex = 130
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Me.TBconsBenefpays)
        Me.GroupBox7.Controls.Add(Me.TBconsBenefville)
        Me.GroupBox7.Controls.Add(Me.TBconsBenefdatenaiss)
        Me.GroupBox7.Controls.Add(Me.TBconsBenefcodepostal)
        Me.GroupBox7.Controls.Add(Me.TBconsBenefadress)
        Me.GroupBox7.Controls.Add(Me.TBconsBenefnom)
        Me.GroupBox7.Controls.Add(Me.TBconsBenefprenom)
        Me.GroupBox7.Controls.Add(Me.Label14)
        Me.GroupBox7.Controls.Add(Me.Label16)
        Me.GroupBox7.Controls.Add(Me.Label18)
        Me.GroupBox7.Controls.Add(Me.Label19)
        Me.GroupBox7.Controls.Add(Me.Label20)
        Me.GroupBox7.Controls.Add(Me.Label21)
        Me.GroupBox7.Controls.Add(Me.Label22)
        Me.GroupBox7.Location = New System.Drawing.Point(17, 14)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(502, 166)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Infos Bénéficiaires"
        '
        'TBconsBenefpays
        '
        Me.TBconsBenefpays.Location = New System.Drawing.Point(319, 103)
        Me.TBconsBenefpays.Name = "TBconsBenefpays"
        Me.TBconsBenefpays.Size = New System.Drawing.Size(129, 21)
        Me.TBconsBenefpays.TabIndex = 72
        '
        'TBconsBenefville
        '
        Me.TBconsBenefville.Location = New System.Drawing.Point(321, 75)
        Me.TBconsBenefville.Name = "TBconsBenefville"
        Me.TBconsBenefville.Size = New System.Drawing.Size(129, 21)
        Me.TBconsBenefville.TabIndex = 71
        '
        'TBconsBenefdatenaiss
        '
        Me.TBconsBenefdatenaiss.Location = New System.Drawing.Point(125, 72)
        Me.TBconsBenefdatenaiss.Name = "TBconsBenefdatenaiss"
        Me.TBconsBenefdatenaiss.Size = New System.Drawing.Size(129, 21)
        Me.TBconsBenefdatenaiss.TabIndex = 70
        '
        'TBconsBenefcodepostal
        '
        Me.TBconsBenefcodepostal.Location = New System.Drawing.Point(356, 43)
        Me.TBconsBenefcodepostal.Name = "TBconsBenefcodepostal"
        Me.TBconsBenefcodepostal.Size = New System.Drawing.Size(129, 21)
        Me.TBconsBenefcodepostal.TabIndex = 69
        '
        'TBconsBenefadress
        '
        Me.TBconsBenefadress.Location = New System.Drawing.Point(125, 43)
        Me.TBconsBenefadress.Name = "TBconsBenefadress"
        Me.TBconsBenefadress.Size = New System.Drawing.Size(129, 21)
        Me.TBconsBenefadress.TabIndex = 68
        '
        'TBconsBenefnom
        '
        Me.TBconsBenefnom.Location = New System.Drawing.Point(321, 17)
        Me.TBconsBenefnom.Name = "TBconsBenefnom"
        Me.TBconsBenefnom.Size = New System.Drawing.Size(129, 21)
        Me.TBconsBenefnom.TabIndex = 67
        '
        'TBconsBenefprenom
        '
        Me.TBconsBenefprenom.Location = New System.Drawing.Point(125, 15)
        Me.TBconsBenefprenom.Name = "TBconsBenefprenom"
        Me.TBconsBenefprenom.Size = New System.Drawing.Size(129, 21)
        Me.TBconsBenefprenom.TabIndex = 66
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(73, 48)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 14)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "Adresse"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(20, 78)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 14)
        Me.Label16.TabIndex = 51
        Me.Label16.Text = "Date de naissance"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(285, 103)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(29, 14)
        Me.Label18.TabIndex = 48
        Me.Label18.Text = "Pays"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(285, 75)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(29, 14)
        Me.Label19.TabIndex = 46
        Me.Label19.Text = "Ville"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(282, 46)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 14)
        Me.Label20.TabIndex = 43
        Me.Label20.Text = "Code postal"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(281, 16)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(31, 14)
        Me.Label21.TabIndex = 41
        Me.Label21.Text = "Nom"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(73, 18)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(46, 14)
        Me.Label22.TabIndex = 39
        Me.Label22.Text = "Prénom"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel5.Controls.Add(Me.GroupBox5)
        Me.Panel5.Location = New System.Drawing.Point(303, 6)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(349, 200)
        Me.Panel5.TabIndex = 130
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.FCDGConss)
        Me.GroupBox5.Location = New System.Drawing.Point(17, 14)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(312, 166)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Concession :"
        '
        'FCDGConss
        '
        Me.FCDGConss.BackgroundColor = System.Drawing.Color.White
        Me.FCDGConss.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FCDGConss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FCDGConss.EnableHeadersVisualStyles = False
        Me.FCDGConss.Location = New System.Drawing.Point(0, 15)
        Me.FCDGConss.Name = "FCDGConss"
        Me.FCDGConss.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FCDGConss.RowHeadersVisible = False
        Me.FCDGConss.Size = New System.Drawing.Size(312, 151)
        Me.FCDGConss.TabIndex = 43
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel6.Controls.Add(Me.GroupBox6)
        Me.Panel6.Location = New System.Drawing.Point(694, 6)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(536, 200)
        Me.Panel6.TabIndex = 130
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.FCTBDateDeb)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.FCTBDateFin)
        Me.GroupBox6.Controls.Add(Me.FCLDenomination)
        Me.GroupBox6.Controls.Add(Me.FCTBnumero)
        Me.GroupBox6.Controls.Add(Me.FCLEmplacement)
        Me.GroupBox6.Controls.Add(Me.FCTBEmplacement)
        Me.GroupBox6.Controls.Add(Me.FCLPlaceLibre)
        Me.GroupBox6.Controls.Add(Me.FCTBPlaceLibre)
        Me.GroupBox6.Controls.Add(Me.FCLPlaceOccupe)
        Me.GroupBox6.Controls.Add(Me.FCTBPlaceOccupe)
        Me.GroupBox6.Controls.Add(Me.FCTBMonumentClasse)
        Me.GroupBox6.Controls.Add(Me.FCLCommentaire)
        Me.GroupBox6.Controls.Add(Me.FCTBCommentaire)
        Me.GroupBox6.Controls.Add(Me.FCLMonumentC)
        Me.GroupBox6.Controls.Add(Me.FCLHistoire)
        Me.GroupBox6.Controls.Add(Me.FCTBHistoire)
        Me.GroupBox6.Controls.Add(Me.FCLType)
        Me.GroupBox6.Controls.Add(Me.FCTBType)
        Me.GroupBox6.Location = New System.Drawing.Point(17, 14)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(502, 166)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Infos Concessions"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(36, 141)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 14)
        Me.Label12.TabIndex = 125
        Me.Label12.Text = "Date de debut"
        '
        'FCTBDateDeb
        '
        Me.FCTBDateDeb.Location = New System.Drawing.Point(123, 138)
        Me.FCTBDateDeb.Name = "FCTBDateDeb"
        Me.FCTBDateDeb.Size = New System.Drawing.Size(128, 21)
        Me.FCTBDateDeb.TabIndex = 126
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(289, 141)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 14)
        Me.Label13.TabIndex = 127
        Me.Label13.Text = "Date de fin"
        '
        'FCTBDateFin
        '
        Me.FCTBDateFin.Location = New System.Drawing.Point(359, 136)
        Me.FCTBDateFin.Name = "FCTBDateFin"
        Me.FCTBDateFin.Size = New System.Drawing.Size(128, 21)
        Me.FCTBDateFin.TabIndex = 128
        '
        'FCLDenomination
        '
        Me.FCLDenomination.AutoSize = True
        Me.FCLDenomination.Location = New System.Drawing.Point(63, 23)
        Me.FCLDenomination.Name = "FCLDenomination"
        Me.FCLDenomination.Size = New System.Drawing.Size(48, 14)
        Me.FCLDenomination.TabIndex = 64
        Me.FCLDenomination.Text = "Numero"
        '
        'FCTBnumero
        '
        Me.FCTBnumero.Location = New System.Drawing.Point(124, 22)
        Me.FCTBnumero.Name = "FCTBnumero"
        Me.FCTBnumero.Size = New System.Drawing.Size(129, 21)
        Me.FCTBnumero.TabIndex = 65
        '
        'FCLEmplacement
        '
        Me.FCLEmplacement.AutoSize = True
        Me.FCLEmplacement.Location = New System.Drawing.Point(277, 20)
        Me.FCLEmplacement.Name = "FCLEmplacement"
        Me.FCLEmplacement.Size = New System.Drawing.Size(81, 14)
        Me.FCLEmplacement.TabIndex = 66
        Me.FCLEmplacement.Text = "Emplacement :"
        '
        'FCTBEmplacement
        '
        Me.FCTBEmplacement.Location = New System.Drawing.Point(361, 20)
        Me.FCTBEmplacement.Name = "FCTBEmplacement"
        Me.FCTBEmplacement.Size = New System.Drawing.Size(128, 21)
        Me.FCTBEmplacement.TabIndex = 67
        '
        'FCLPlaceLibre
        '
        Me.FCLPlaceLibre.AutoSize = True
        Me.FCLPlaceLibre.Location = New System.Drawing.Point(53, 53)
        Me.FCLPlaceLibre.Name = "FCLPlaceLibre"
        Me.FCLPlaceLibre.Size = New System.Drawing.Size(65, 14)
        Me.FCLPlaceLibre.TabIndex = 68
        Me.FCLPlaceLibre.Text = "Place libre :"
        '
        'FCTBPlaceLibre
        '
        Me.FCTBPlaceLibre.Location = New System.Drawing.Point(125, 50)
        Me.FCTBPlaceLibre.Name = "FCTBPlaceLibre"
        Me.FCTBPlaceLibre.Size = New System.Drawing.Size(128, 21)
        Me.FCTBPlaceLibre.TabIndex = 69
        '
        'FCLPlaceOccupe
        '
        Me.FCLPlaceOccupe.AutoSize = True
        Me.FCLPlaceOccupe.Location = New System.Drawing.Point(279, 51)
        Me.FCLPlaceOccupe.Name = "FCLPlaceOccupe"
        Me.FCLPlaceOccupe.Size = New System.Drawing.Size(79, 14)
        Me.FCLPlaceOccupe.TabIndex = 70
        Me.FCLPlaceOccupe.Text = "Place occupé :"
        '
        'FCTBPlaceOccupe
        '
        Me.FCTBPlaceOccupe.Location = New System.Drawing.Point(361, 48)
        Me.FCTBPlaceOccupe.Name = "FCTBPlaceOccupe"
        Me.FCTBPlaceOccupe.Size = New System.Drawing.Size(128, 21)
        Me.FCTBPlaceOccupe.TabIndex = 71
        '
        'FCTBMonumentClasse
        '
        Me.FCTBMonumentClasse.Location = New System.Drawing.Point(124, 80)
        Me.FCTBMonumentClasse.Name = "FCTBMonumentClasse"
        Me.FCTBMonumentClasse.Size = New System.Drawing.Size(128, 21)
        Me.FCTBMonumentClasse.TabIndex = 95
        '
        'FCLCommentaire
        '
        Me.FCLCommentaire.AutoSize = True
        Me.FCLCommentaire.Location = New System.Drawing.Point(277, 81)
        Me.FCLCommentaire.Name = "FCLCommentaire"
        Me.FCLCommentaire.Size = New System.Drawing.Size(81, 14)
        Me.FCLCommentaire.TabIndex = 124
        Me.FCLCommentaire.Text = "Commentaire :"
        '
        'FCTBCommentaire
        '
        Me.FCTBCommentaire.Location = New System.Drawing.Point(361, 78)
        Me.FCTBCommentaire.Name = "FCTBCommentaire"
        Me.FCTBCommentaire.Size = New System.Drawing.Size(128, 21)
        Me.FCTBCommentaire.TabIndex = 97
        '
        'FCLMonumentC
        '
        Me.FCLMonumentC.AutoSize = True
        Me.FCLMonumentC.Location = New System.Drawing.Point(14, 83)
        Me.FCLMonumentC.Name = "FCLMonumentC"
        Me.FCLMonumentC.Size = New System.Drawing.Size(105, 14)
        Me.FCLMonumentC.TabIndex = 123
        Me.FCLMonumentC.Text = "Monument Classé :"
        '
        'FCLHistoire
        '
        Me.FCLHistoire.AutoSize = True
        Me.FCLHistoire.Location = New System.Drawing.Point(65, 112)
        Me.FCLHistoire.Name = "FCLHistoire"
        Me.FCLHistoire.Size = New System.Drawing.Size(53, 14)
        Me.FCLHistoire.TabIndex = 98
        Me.FCLHistoire.Text = "Histoire :"
        '
        'FCTBHistoire
        '
        Me.FCTBHistoire.Location = New System.Drawing.Point(125, 109)
        Me.FCTBHistoire.Name = "FCTBHistoire"
        Me.FCTBHistoire.Size = New System.Drawing.Size(128, 21)
        Me.FCTBHistoire.TabIndex = 99
        '
        'FCLType
        '
        Me.FCLType.AutoSize = True
        Me.FCLType.Location = New System.Drawing.Point(318, 110)
        Me.FCLType.Name = "FCLType"
        Me.FCLType.Size = New System.Drawing.Size(36, 14)
        Me.FCLType.TabIndex = 100
        Me.FCLType.Text = "Type :"
        '
        'FCTBType
        '
        Me.FCTBType.Location = New System.Drawing.Point(361, 107)
        Me.FCTBType.Name = "FCTBType"
        Me.FCTBType.Size = New System.Drawing.Size(128, 21)
        Me.FCTBType.TabIndex = 101
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel4.Controls.Add(Me.GroupBox4)
        Me.Panel4.Location = New System.Drawing.Point(19, 92)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(263, 138)
        Me.Panel4.TabIndex = 129
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.FCTBRechercher)
        Me.GroupBox4.Controls.Add(Me.FCCBNom)
        Me.GroupBox4.Controls.Add(Me.FCCBEmplacement)
        Me.GroupBox4.Controls.Add(Me.FCCBType)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 10)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(234, 113)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Rechercher :"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(5, 65)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 23)
        Me.Button2.TabIndex = 127
        Me.Button2.Text = "Annuler la recherche"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(145, 64)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 126
        Me.Button3.Text = "Rechercher"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FCTBRechercher
        '
        Me.FCTBRechercher.Location = New System.Drawing.Point(6, 14)
        Me.FCTBRechercher.Name = "FCTBRechercher"
        Me.FCTBRechercher.Size = New System.Drawing.Size(157, 21)
        Me.FCTBRechercher.TabIndex = 35
        '
        'FCCBNom
        '
        Me.FCCBNom.AutoSize = True
        Me.FCCBNom.Location = New System.Drawing.Point(8, 41)
        Me.FCCBNom.Name = "FCCBNom"
        Me.FCCBNom.Size = New System.Drawing.Size(50, 18)
        Me.FCCBNom.TabIndex = 40
        Me.FCCBNom.Text = "Nom"
        Me.FCCBNom.UseVisualStyleBackColor = True
        '
        'FCCBEmplacement
        '
        Me.FCCBEmplacement.AutoSize = True
        Me.FCCBEmplacement.Location = New System.Drawing.Point(62, 41)
        Me.FCCBEmplacement.Name = "FCCBEmplacement"
        Me.FCCBEmplacement.Size = New System.Drawing.Size(94, 18)
        Me.FCCBEmplacement.TabIndex = 42
        Me.FCCBEmplacement.Text = "Emplacement"
        Me.FCCBEmplacement.UseVisualStyleBackColor = True
        '
        'FCCBType
        '
        Me.FCCBType.AutoSize = True
        Me.FCCBType.Location = New System.Drawing.Point(162, 41)
        Me.FCCBType.Name = "FCCBType"
        Me.FCCBType.Size = New System.Drawing.Size(49, 18)
        Me.FCCBType.TabIndex = 125
        Me.FCCBType.Text = "Type"
        Me.FCCBType.UseVisualStyleBackColor = True
        '
        'FCBSupp
        '
        Me.FCBSupp.BackColor = System.Drawing.Color.SeaGreen
        Me.FCBSupp.ForeColor = System.Drawing.Color.Transparent
        Me.FCBSupp.Location = New System.Drawing.Point(175, 236)
        Me.FCBSupp.Name = "FCBSupp"
        Me.FCBSupp.Size = New System.Drawing.Size(74, 23)
        Me.FCBSupp.TabIndex = 128
        Me.FCBSupp.Text = "Supprimer"
        Me.FCBSupp.UseVisualStyleBackColor = False
        '
        'FCBModifier
        '
        Me.FCBModifier.BackColor = System.Drawing.Color.SeaGreen
        Me.FCBModifier.ForeColor = System.Drawing.Color.Transparent
        Me.FCBModifier.Location = New System.Drawing.Point(99, 236)
        Me.FCBModifier.Name = "FCBModifier"
        Me.FCBModifier.Size = New System.Drawing.Size(64, 23)
        Me.FCBModifier.TabIndex = 127
        Me.FCBModifier.Text = "Modifier"
        Me.FCBModifier.UseVisualStyleBackColor = False
        '
        'FCBAjouter
        '
        Me.FCBAjouter.BackColor = System.Drawing.Color.SeaGreen
        Me.FCBAjouter.ForeColor = System.Drawing.Color.Transparent
        Me.FCBAjouter.Location = New System.Drawing.Point(29, 235)
        Me.FCBAjouter.Name = "FCBAjouter"
        Me.FCBAjouter.Size = New System.Drawing.Size(64, 23)
        Me.FCBAjouter.TabIndex = 126
        Me.FCBAjouter.Text = "Ajouter"
        Me.FCBAjouter.UseVisualStyleBackColor = False
        '
        'FCBLienDefunt
        '
        Me.FCBLienDefunt.BackColor = System.Drawing.Color.SeaGreen
        Me.FCBLienDefunt.ForeColor = System.Drawing.Color.Transparent
        Me.FCBLienDefunt.Location = New System.Drawing.Point(932, 267)
        Me.FCBLienDefunt.Name = "FCBLienDefunt"
        Me.FCBLienDefunt.Size = New System.Drawing.Size(154, 57)
        Me.FCBLienDefunt.TabIndex = 91
        Me.FCBLienDefunt.Text = "Lien vers Défunt"
        Me.FCBLienDefunt.UseVisualStyleBackColor = False
        '
        'FCBDetails
        '
        Me.FCBDetails.BackColor = System.Drawing.Color.SeaGreen
        Me.FCBDetails.ForeColor = System.Drawing.Color.Transparent
        Me.FCBDetails.Location = New System.Drawing.Point(1144, 269)
        Me.FCBDetails.Name = "FCBDetails"
        Me.FCBDetails.Size = New System.Drawing.Size(86, 53)
        Me.FCBDetails.TabIndex = 90
        Me.FCBDetails.Text = "Détails"
        Me.FCBDetails.UseVisualStyleBackColor = False
        '
        'FCPBlahulpe
        '
        Me.FCPBlahulpe.BackColor = System.Drawing.Color.Transparent
        Me.FCPBlahulpe.Image = CType(resources.GetObject("FCPBlahulpe.Image"), System.Drawing.Image)
        Me.FCPBlahulpe.Location = New System.Drawing.Point(0, 2)
        Me.FCPBlahulpe.Name = "FCPBlahulpe"
        Me.FCPBlahulpe.Size = New System.Drawing.Size(111, 77)
        Me.FCPBlahulpe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FCPBlahulpe.TabIndex = 45
        Me.FCPBlahulpe.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.BackgroundImage = Global.cimetiere.My.Resources.Resources.fondformulaire
        Me.TabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage3.Controls.Add(Me.Panel13)
        Me.TabPage3.Controls.Add(Me.Panel2)
        Me.TabPage3.Controls.Add(Me.Panel15)
        Me.TabPage3.Controls.Add(Me.Button10)
        Me.TabPage3.Controls.Add(Me.Button11)
        Me.TabPage3.Controls.Add(Me.Button12)
        Me.TabPage3.Controls.Add(Me.PRBPersCon)
        Me.TabPage3.Controls.Add(Me.PRBConcessionnaire)
        Me.TabPage3.Controls.Add(Me.PRBBenef)
        Me.TabPage3.Controls.Add(Me.Panel12)
        Me.TabPage3.Controls.Add(Me.PictureBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 36)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1262, 665)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Personnes"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel13.Controls.Add(Me.GroupBox13)
        Me.Panel13.Location = New System.Drawing.Point(705, 31)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(531, 200)
        Me.Panel13.TabIndex = 138
        '
        'GroupBox13
        '
        Me.GroupBox13.BackColor = System.Drawing.Color.White
        Me.GroupBox13.Controls.Add(Me.TBPersNumNational)
        Me.GroupBox13.Controls.Add(Me.TBPersPays)
        Me.GroupBox13.Controls.Add(Me.TBPersDN)
        Me.GroupBox13.Controls.Add(Me.TBPersVille)
        Me.GroupBox13.Controls.Add(Me.TBPersTel)
        Me.GroupBox13.Controls.Add(Me.TBPersCodePostal)
        Me.GroupBox13.Controls.Add(Me.TBPersAdress)
        Me.GroupBox13.Controls.Add(Me.TBPersNom)
        Me.GroupBox13.Controls.Add(Me.TBPersPrenom)
        Me.GroupBox13.Controls.Add(Me.Button5)
        Me.GroupBox13.Controls.Add(Me.Button6)
        Me.GroupBox13.Controls.Add(Me.Label4)
        Me.GroupBox13.Controls.Add(Me.Label9)
        Me.GroupBox13.Controls.Add(Me.Label8)
        Me.GroupBox13.Controls.Add(Me.Label7)
        Me.GroupBox13.Controls.Add(Me.Label6)
        Me.GroupBox13.Controls.Add(Me.Label5)
        Me.GroupBox13.Controls.Add(Me.Label10)
        Me.GroupBox13.Controls.Add(Me.Label11)
        Me.GroupBox13.Controls.Add(Me.Label28)
        Me.GroupBox13.Location = New System.Drawing.Point(17, 14)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(500, 166)
        Me.GroupBox13.TabIndex = 0
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Infos Personnes"
        '
        'TBPersNumNational
        '
        Me.TBPersNumNational.Location = New System.Drawing.Point(87, 129)
        Me.TBPersNumNational.Name = "TBPersNumNational"
        Me.TBPersNumNational.Size = New System.Drawing.Size(100, 21)
        Me.TBPersNumNational.TabIndex = 146
        '
        'TBPersPays
        '
        Me.TBPersPays.Location = New System.Drawing.Point(260, 100)
        Me.TBPersPays.Name = "TBPersPays"
        Me.TBPersPays.Size = New System.Drawing.Size(100, 21)
        Me.TBPersPays.TabIndex = 145
        '
        'TBPersDN
        '
        Me.TBPersDN.Location = New System.Drawing.Point(119, 101)
        Me.TBPersDN.Name = "TBPersDN"
        Me.TBPersDN.Size = New System.Drawing.Size(100, 21)
        Me.TBPersDN.TabIndex = 144
        '
        'TBPersVille
        '
        Me.TBPersVille.Location = New System.Drawing.Point(269, 74)
        Me.TBPersVille.Name = "TBPersVille"
        Me.TBPersVille.Size = New System.Drawing.Size(100, 21)
        Me.TBPersVille.TabIndex = 143
        '
        'TBPersTel
        '
        Me.TBPersTel.Location = New System.Drawing.Point(80, 74)
        Me.TBPersTel.Name = "TBPersTel"
        Me.TBPersTel.Size = New System.Drawing.Size(100, 21)
        Me.TBPersTel.TabIndex = 142
        '
        'TBPersCodePostal
        '
        Me.TBPersCodePostal.Location = New System.Drawing.Point(297, 42)
        Me.TBPersCodePostal.Name = "TBPersCodePostal"
        Me.TBPersCodePostal.Size = New System.Drawing.Size(100, 21)
        Me.TBPersCodePostal.TabIndex = 141
        '
        'TBPersAdress
        '
        Me.TBPersAdress.Location = New System.Drawing.Point(75, 44)
        Me.TBPersAdress.Name = "TBPersAdress"
        Me.TBPersAdress.Size = New System.Drawing.Size(100, 21)
        Me.TBPersAdress.TabIndex = 140
        '
        'TBPersNom
        '
        Me.TBPersNom.Location = New System.Drawing.Point(269, 13)
        Me.TBPersNom.Name = "TBPersNom"
        Me.TBPersNom.Size = New System.Drawing.Size(100, 21)
        Me.TBPersNom.TabIndex = 139
        '
        'TBPersPrenom
        '
        Me.TBPersPrenom.Location = New System.Drawing.Point(75, 13)
        Me.TBPersPrenom.Name = "TBPersPrenom"
        Me.TBPersPrenom.Size = New System.Drawing.Size(100, 21)
        Me.TBPersPrenom.TabIndex = 138
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.SeaGreen
        Me.Button5.ForeColor = System.Drawing.Color.Transparent
        Me.Button5.Location = New System.Drawing.Point(403, 129)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(74, 23)
        Me.Button5.TabIndex = 137
        Me.Button5.Text = "Supprimer"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.SeaGreen
        Me.Button6.ForeColor = System.Drawing.Color.Transparent
        Me.Button6.Location = New System.Drawing.Point(403, 100)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(64, 23)
        Me.Button6.TabIndex = 136
        Me.Button6.Text = "Modifier"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 47)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 14)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Adresse"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 131)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 14)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "N° national"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 104)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 14)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Date de naissance"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 76)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 14)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Téléphone"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(226, 102)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 14)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Pays"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(226, 74)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 14)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Ville"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(223, 45)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 14)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Code postal"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(222, 15)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 14)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Nom"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(14, 17)
        Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(46, 14)
        Me.Label28.TabIndex = 21
        Me.Label28.Text = "Prénom"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Location = New System.Drawing.Point(20, 90)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(263, 138)
        Me.Panel2.TabIndex = 146
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button9)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(234, 113)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rechercher :"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(5, 65)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(127, 23)
        Me.Button4.TabIndex = 127
        Me.Button4.Text = "Annuler la recherche"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(145, 64)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 126
        Me.Button9.Text = "Rechercher"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 14)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(157, 21)
        Me.TextBox1.TabIndex = 35
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(8, 41)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(50, 18)
        Me.CheckBox1.TabIndex = 40
        Me.CheckBox1.Text = "Nom"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(62, 41)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(119, 18)
        Me.CheckBox2.TabIndex = 42
        Me.CheckBox2.Text = "Date de naissance"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel15.Controls.Add(Me.GroupBox15)
        Me.Panel15.Location = New System.Drawing.Point(705, 244)
        Me.Panel15.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(531, 200)
        Me.Panel15.TabIndex = 140
        '
        'GroupBox15
        '
        Me.GroupBox15.BackColor = System.Drawing.Color.White
        Me.GroupBox15.Controls.Add(Me.LinkLabel1)
        Me.GroupBox15.Controls.Add(Me.Button7)
        Me.GroupBox15.Controls.Add(Me.Button8)
        Me.GroupBox15.Location = New System.Drawing.Point(17, 15)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(500, 166)
        Me.GroupBox15.TabIndex = 0
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Infos bénéficiaires"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(32, 27)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(109, 14)
        Me.LinkLabel1.TabIndex = 138
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Emplacement A7262"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.SeaGreen
        Me.Button7.ForeColor = System.Drawing.Color.Transparent
        Me.Button7.Location = New System.Drawing.Point(393, 76)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(74, 23)
        Me.Button7.TabIndex = 137
        Me.Button7.Text = "Supprimer"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.SeaGreen
        Me.Button8.ForeColor = System.Drawing.Color.Transparent
        Me.Button8.Location = New System.Drawing.Point(403, 47)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(64, 23)
        Me.Button8.TabIndex = 136
        Me.Button8.Text = "Modifier"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.SeaGreen
        Me.Button10.ForeColor = System.Drawing.Color.Transparent
        Me.Button10.Location = New System.Drawing.Point(176, 234)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(74, 23)
        Me.Button10.TabIndex = 145
        Me.Button10.Text = "Supprimer"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.SeaGreen
        Me.Button11.ForeColor = System.Drawing.Color.Transparent
        Me.Button11.Location = New System.Drawing.Point(100, 234)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(64, 23)
        Me.Button11.TabIndex = 144
        Me.Button11.Text = "Modifier"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.SeaGreen
        Me.Button12.ForeColor = System.Drawing.Color.Transparent
        Me.Button12.Location = New System.Drawing.Point(30, 233)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(64, 23)
        Me.Button12.TabIndex = 143
        Me.Button12.Text = "Ajouter"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'PRBPersCon
        '
        Me.PRBPersCon.AutoSize = True
        Me.PRBPersCon.BackColor = System.Drawing.Color.Transparent
        Me.PRBPersCon.Location = New System.Drawing.Point(511, 8)
        Me.PRBPersCon.Name = "PRBPersCon"
        Me.PRBPersCon.Size = New System.Drawing.Size(130, 18)
        Me.PRBPersCon.TabIndex = 142
        Me.PRBPersCon.Text = "Personne de contact"
        Me.PRBPersCon.UseVisualStyleBackColor = False
        '
        'PRBConcessionnaire
        '
        Me.PRBConcessionnaire.AutoSize = True
        Me.PRBConcessionnaire.BackColor = System.Drawing.Color.Transparent
        Me.PRBConcessionnaire.Location = New System.Drawing.Point(399, 8)
        Me.PRBConcessionnaire.Name = "PRBConcessionnaire"
        Me.PRBConcessionnaire.Size = New System.Drawing.Size(110, 18)
        Me.PRBConcessionnaire.TabIndex = 141
        Me.PRBConcessionnaire.Text = "Concessionnaire"
        Me.PRBConcessionnaire.UseVisualStyleBackColor = False
        '
        'PRBBenef
        '
        Me.PRBBenef.AutoSize = True
        Me.PRBBenef.BackColor = System.Drawing.Color.Transparent
        Me.PRBBenef.Checked = True
        Me.PRBBenef.Location = New System.Drawing.Point(309, 8)
        Me.PRBBenef.Name = "PRBBenef"
        Me.PRBBenef.Size = New System.Drawing.Size(85, 18)
        Me.PRBBenef.TabIndex = 140
        Me.PRBBenef.TabStop = True
        Me.PRBBenef.Text = "Bénéficiaire"
        Me.PRBBenef.UseVisualStyleBackColor = False
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel12.Controls.Add(Me.GroupBox12)
        Me.Panel12.Location = New System.Drawing.Point(302, 31)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(349, 527)
        Me.Panel12.TabIndex = 137
        '
        'GroupBox12
        '
        Me.GroupBox12.BackColor = System.Drawing.Color.White
        Me.GroupBox12.Controls.Add(Me.DgvListeConcessionnaire)
        Me.GroupBox12.Location = New System.Drawing.Point(17, 14)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(312, 483)
        Me.GroupBox12.TabIndex = 0
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Acteurs"
        '
        'DgvListeConcessionnaire
        '
        Me.DgvListeConcessionnaire.BackgroundColor = System.Drawing.Color.White
        Me.DgvListeConcessionnaire.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvListeConcessionnaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListeConcessionnaire.EnableHeadersVisualStyles = False
        Me.DgvListeConcessionnaire.Location = New System.Drawing.Point(0, 15)
        Me.DgvListeConcessionnaire.Name = "DgvListeConcessionnaire"
        Me.DgvListeConcessionnaire.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DgvListeConcessionnaire.RowHeadersVisible = False
        Me.DgvListeConcessionnaire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvListeConcessionnaire.Size = New System.Drawing.Size(312, 470)
        Me.DgvListeConcessionnaire.TabIndex = 43
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 132
        Me.PictureBox1.TabStop = False
        '
        'TbDateDeces
        '
        Me.TbDateDeces.DateValue = Nothing
        Me.TbDateDeces.Location = New System.Drawing.Point(851, 405)
        Me.TbDateDeces.Margin = New System.Windows.Forms.Padding(2)
        Me.TbDateDeces.Mask = "00/00/0000"
        Me.TbDateDeces.Name = "TbDateDeces"
        Me.TbDateDeces.Size = New System.Drawing.Size(76, 21)
        Me.TbDateDeces.TabIndex = 113
        Me.TbDateDeces.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FormGestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 666)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(1270, 705)
        Me.MinimumSize = New System.Drawing.Size(1270, 705)
        Me.Name = "FormGestion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormGestion"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DgvListeDefunts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.FPTBLahulpe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.FCDGDefunt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.FCDGBeneficiaire, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.FCDGConss, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.FCPBlahulpe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        CType(Me.DgvListeConcessionnaire, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents FPBAjouter As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FPBSupprimer As Button
    Friend WithEvents FPBModifier As Button
    Friend WithEvents FPBDetails As Button
    Friend WithEvents FPBLienCons As Button
    Friend WithEvents FPTBLahulpe As PictureBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel9 As Panel
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents FCDGDefunt As DataGridView
    Friend WithEvents Panel8 As Panel
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents FCDGBeneficiaire As DataGridView
    Friend WithEvents Panel7 As Panel
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents FCDGConss As DataGridView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents FCTBDateDeb As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents FCTBDateFin As TextBox
    Friend WithEvents FCLDenomination As Label
    Friend WithEvents FCTBnumero As TextBox
    Friend WithEvents FCLEmplacement As Label
    Friend WithEvents FCTBEmplacement As TextBox
    Friend WithEvents FCLPlaceLibre As Label
    Friend WithEvents FCTBPlaceLibre As TextBox
    Friend WithEvents FCLPlaceOccupe As Label
    Friend WithEvents FCTBPlaceOccupe As TextBox
    Friend WithEvents FCTBMonumentClasse As TextBox
    Friend WithEvents FCLCommentaire As Label
    Friend WithEvents FCTBCommentaire As TextBox
    Friend WithEvents FCLMonumentC As Label
    Friend WithEvents FCLHistoire As Label
    Friend WithEvents FCTBHistoire As TextBox
    Friend WithEvents FCLType As Label
    Friend WithEvents FCTBType As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents FCTBRechercher As TextBox
    Friend WithEvents FCCBNom As CheckBox
    Friend WithEvents FCCBEmplacement As CheckBox
    Friend WithEvents FCCBType As CheckBox
    Friend WithEvents FCBSupp As Button
    Friend WithEvents FCBModifier As Button
    Friend WithEvents FCBAjouter As Button
    Friend WithEvents FCBLienDefunt As Button
    Friend WithEvents FCBDetails As Button
    Friend WithEvents FCPBlahulpe As PictureBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents PRBPersCon As RadioButton
    Friend WithEvents PRBConcessionnaire As RadioButton
    Friend WithEvents PRBBenef As RadioButton
    Friend WithEvents Panel13 As Panel
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Panel15 As Panel
    Friend WithEvents GroupBox15 As GroupBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Panel12 As Panel
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents DgvListeConcessionnaire As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents BtDefAnnulerRecherche As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DtpDefRechercherDateDecesApres As DateTimePicker
    Friend WithEvents DtpDefRechercherDateDecesAvant As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents TbDefChampRecherche As TextBox
    Friend WithEvents CbDefChercherNom As CheckBox
    Friend WithEvents CbDefChercherCode As CheckBox
    Friend WithEvents CbDefChercherEmplacement As CheckBox
    Friend WithEvents BtDefChercher As Button
    Friend WithEvents TbDateDeces As TextBoxDate
    Public WithEvents TabPage1 As TabPage
    Friend WithEvents FPTBVille As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents FPTBLieuNaiss As TextBox
    Friend WithEvents FPLLieuNaiss As Label
    Friend WithEvents FPTBEtatCivil As TextBox
    Friend WithEvents FPLEtatCivil As Label
    Friend WithEvents FPTBPays As TextBox
    Friend WithEvents FPLPays As Label
    Friend WithEvents FPTBCodePostal As TextBox
    Friend WithEvents FPLCodePostal As Label
    Friend WithEvents FPTBAdresse As TextBox
    Friend WithEvents FPLAdresse As Label
    Friend WithEvents FPTBCodeLieu As TextBox
    Friend WithEvents FPTBEmplacement As TextBox
    Friend WithEvents FPTBDateM As TextBox
    Friend WithEvents FPTBPrenom As TextBox
    Friend WithEvents FPLCodeLieu As Label
    Friend WithEvents FPLEmplacement As Label
    Friend WithEvents FPLDateM As Label
    Friend WithEvents FPLPrenom As Label
    Friend WithEvents FPTBDateE As TextBox
    Friend WithEvents FPTBSepulture As TextBox
    Friend WithEvents FPTBDateNaiss As TextBox
    Friend WithEvents FPLDateEnt As Label
    Friend WithEvents FPLSepulture As Label
    Friend WithEvents FPLDateNaiss As Label
    Friend WithEvents FPTBNom As TextBox
    Friend WithEvents FPLNom As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents TBconsBenefpays As TextBox
    Friend WithEvents TBconsBenefville As TextBox
    Friend WithEvents TBconsBenefdatenaiss As TextBox
    Friend WithEvents TBconsBenefcodepostal As TextBox
    Friend WithEvents TBconsBenefadress As TextBox
    Friend WithEvents TBconsBenefnom As TextBox
    Friend WithEvents TBconsBenefprenom As TextBox
    Friend WithEvents TBPersNumNational As TextBox
    Friend WithEvents TBPersPays As TextBox
    Friend WithEvents TBPersDN As TextBox
    Friend WithEvents TBPersVille As TextBox
    Friend WithEvents TBPersTel As TextBox
    Friend WithEvents TBPersCodePostal As TextBox
    Friend WithEvents TBPersAdress As TextBox
    Friend WithEvents TBPersNom As TextBox
    Friend WithEvents TBPersPrenom As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DgvListeDefunts As DataGridView
End Class
