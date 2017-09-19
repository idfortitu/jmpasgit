<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormReservation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReservation))
        Me.GbCsnr = New System.Windows.Forms.GroupBox()
        Me.CtrlLocVillePays1 = New cimetiere.CtrlLocVillePays()
        Me.TbCsnrNoRegistre = New System.Windows.Forms.MaskedTextBox()
        Me.TbCsnrTel = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TbdateCsnrDateNaiss = New cimetiere.TextBoxDate()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbCsnrAdresse = New System.Windows.Forms.TextBox()
        Me.TbCsnrNom = New System.Windows.Forms.TextBox()
        Me.TbCsnrPrenom = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TbCommentaire = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GBListBenef = New System.Windows.Forms.GroupBox()
        Me.CtrlListeBenefs1 = New cimetiere.CtrlListeBenefs()
        Me.BtAnnuler = New System.Windows.Forms.Button()
        Me.BtEnregistrer = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgvEmplacements = New cimetiere.DataGridViewCustom()
        Me.ColEmplId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEmplRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEmplType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEmplPlLibres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEmplPlTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEmplClasse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtMontrerFormPlancim = New System.Windows.Forms.Button()
        Me.TbDateFin = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DtpDateDebut = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbNbPlaces = New cimetiere.TextBoxInt()
        Me.CbTarifLh = New System.Windows.Forms.CheckBox()
        Me.LbTypeConcession = New System.Windows.Forms.ListBox()
        Me.TbMontant = New cimetiere.TextBoxFloat()
        Me.PanCbsPdf = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.DtpDateSign = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbEnregPdf = New System.Windows.Forms.CheckBox()
        Me.GbCsnr.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GBListBenef.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvEmplacements, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.PanCbsPdf.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbCsnr
        '
        Me.GbCsnr.BackColor = System.Drawing.SystemColors.Window
        Me.GbCsnr.Controls.Add(Me.CtrlLocVillePays1)
        Me.GbCsnr.Controls.Add(Me.TbCsnrNoRegistre)
        Me.GbCsnr.Controls.Add(Me.TbCsnrTel)
        Me.GbCsnr.Controls.Add(Me.Label7)
        Me.GbCsnr.Controls.Add(Me.Label9)
        Me.GbCsnr.Controls.Add(Me.Label6)
        Me.GbCsnr.Controls.Add(Me.Label10)
        Me.GbCsnr.Controls.Add(Me.TbdateCsnrDateNaiss)
        Me.GbCsnr.Controls.Add(Me.Label8)
        Me.GbCsnr.Controls.Add(Me.Label5)
        Me.GbCsnr.Controls.Add(Me.TbCsnrAdresse)
        Me.GbCsnr.Controls.Add(Me.TbCsnrNom)
        Me.GbCsnr.Controls.Add(Me.TbCsnrPrenom)
        Me.GbCsnr.Location = New System.Drawing.Point(8, 7)
        Me.GbCsnr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GbCsnr.Name = "GbCsnr"
        Me.GbCsnr.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GbCsnr.Size = New System.Drawing.Size(699, 200)
        Me.GbCsnr.TabIndex = 10
        Me.GbCsnr.TabStop = False
        Me.GbCsnr.Text = "Concessionnaire"
        '
        'CtrlLocVillePays1
        '
        Me.CtrlLocVillePays1.LectureSeule = False
        Me.CtrlLocVillePays1.Location = New System.Drawing.Point(277, 62)
        Me.CtrlLocVillePays1.LocVilleId = -1
        Me.CtrlLocVillePays1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CtrlLocVillePays1.Name = "CtrlLocVillePays1"
        Me.CtrlLocVillePays1.osef = Nothing
        Me.CtrlLocVillePays1.Size = New System.Drawing.Size(316, 26)
        Me.CtrlLocVillePays1.TabIndex = 65
        '
        'TbCsnrNoRegistre
        '
        Me.TbCsnrNoRegistre.Location = New System.Drawing.Point(419, 135)
        Me.TbCsnrNoRegistre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TbCsnrNoRegistre.Mask = "00\.00\.00-000\.00"
        Me.TbCsnrNoRegistre.Name = "TbCsnrNoRegistre"
        Me.TbCsnrNoRegistre.Size = New System.Drawing.Size(112, 22)
        Me.TbCsnrNoRegistre.TabIndex = 64
        Me.TbCsnrNoRegistre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TbCsnrNoRegistre.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'TbCsnrTel
        '
        Me.TbCsnrTel.Location = New System.Drawing.Point(88, 97)
        Me.TbCsnrTel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TbCsnrTel.Name = "TbCsnrTel"
        Me.TbCsnrTel.Size = New System.Drawing.Size(173, 22)
        Me.TbCsnrTel.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(300, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 17)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Numéro national"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 17)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Adresse"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Date de naissance"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 17)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Prénom"
        '
        'TbdateCsnrDateNaiss
        '
        Me.TbdateCsnrDateNaiss.DateValue = Nothing
        Me.TbdateCsnrDateNaiss.Location = New System.Drawing.Point(141, 135)
        Me.TbdateCsnrDateNaiss.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TbdateCsnrDateNaiss.Mask = "00/00/0000"
        Me.TbdateCsnrDateNaiss.Name = "TbdateCsnrDateNaiss"
        Me.TbdateCsnrDateNaiss.Size = New System.Drawing.Size(119, 22)
        Me.TbdateCsnrDateNaiss.TabIndex = 13
        Me.TbdateCsnrDateNaiss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Téléphone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(300, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Nom"
        '
        'TbCsnrAdresse
        '
        Me.TbCsnrAdresse.Location = New System.Drawing.Point(88, 63)
        Me.TbCsnrAdresse.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TbCsnrAdresse.Name = "TbCsnrAdresse"
        Me.TbCsnrAdresse.Size = New System.Drawing.Size(173, 22)
        Me.TbCsnrAdresse.TabIndex = 14
        '
        'TbCsnrNom
        '
        Me.TbCsnrNom.Location = New System.Drawing.Point(343, 23)
        Me.TbCsnrNom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TbCsnrNom.Name = "TbCsnrNom"
        Me.TbCsnrNom.Size = New System.Drawing.Size(177, 22)
        Me.TbCsnrNom.TabIndex = 11
        '
        'TbCsnrPrenom
        '
        Me.TbCsnrPrenom.Location = New System.Drawing.Point(88, 26)
        Me.TbCsnrPrenom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TbCsnrPrenom.Name = "TbCsnrPrenom"
        Me.TbCsnrPrenom.Size = New System.Drawing.Size(173, 22)
        Me.TbCsnrPrenom.TabIndex = 12
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'TbCommentaire
        '
        Me.TbCommentaire.Location = New System.Drawing.Point(5, 20)
        Me.TbCommentaire.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TbCommentaire.Multiline = True
        Me.TbCommentaire.Name = "TbCommentaire"
        Me.TbCommentaire.Size = New System.Drawing.Size(656, 129)
        Me.TbCommentaire.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Controls.Add(Me.TbCommentaire)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(700, 155)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Commentaire éventuel"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Controls.Add(Me.GbCsnr)
        Me.Panel1.Location = New System.Drawing.Point(16, 16)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(715, 214)
        Me.Panel1.TabIndex = 138
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Location = New System.Drawing.Point(739, 512)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(715, 172)
        Me.Panel2.TabIndex = 138
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel3.Controls.Add(Me.GBListBenef)
        Me.Panel3.Location = New System.Drawing.Point(739, 16)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(715, 488)
        Me.Panel3.TabIndex = 138
        '
        'GBListBenef
        '
        Me.GBListBenef.BackColor = System.Drawing.SystemColors.Window
        Me.GBListBenef.Controls.Add(Me.CtrlListeBenefs1)
        Me.GBListBenef.Location = New System.Drawing.Point(8, 7)
        Me.GBListBenef.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBListBenef.Name = "GBListBenef"
        Me.GBListBenef.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBListBenef.Size = New System.Drawing.Size(700, 473)
        Me.GBListBenef.TabIndex = 25
        Me.GBListBenef.TabStop = False
        Me.GBListBenef.Text = "Bénéficiaires"
        '
        'CtrlListeBenefs1
        '
        Me.CtrlListeBenefs1.AutoScroll = True
        Me.CtrlListeBenefs1.Location = New System.Drawing.Point(5, 28)
        Me.CtrlListeBenefs1.Name = "CtrlListeBenefs1"
        Me.CtrlListeBenefs1.Size = New System.Drawing.Size(689, 440)
        Me.CtrlListeBenefs1.TabIndex = 0
        '
        'BtAnnuler
        '
        Me.BtAnnuler.BackColor = System.Drawing.Color.SeaGreen
        Me.BtAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtAnnuler.ForeColor = System.Drawing.Color.Transparent
        Me.BtAnnuler.Location = New System.Drawing.Point(438, 697)
        Me.BtAnnuler.Margin = New System.Windows.Forms.Padding(4)
        Me.BtAnnuler.Name = "BtAnnuler"
        Me.BtAnnuler.Size = New System.Drawing.Size(132, 59)
        Me.BtAnnuler.TabIndex = 139
        Me.BtAnnuler.Text = "Annuler"
        Me.BtAnnuler.UseVisualStyleBackColor = False
        '
        'BtEnregistrer
        '
        Me.BtEnregistrer.BackColor = System.Drawing.Color.SeaGreen
        Me.BtEnregistrer.ForeColor = System.Drawing.Color.Transparent
        Me.BtEnregistrer.Location = New System.Drawing.Point(604, 697)
        Me.BtEnregistrer.Margin = New System.Windows.Forms.Padding(4)
        Me.BtEnregistrer.Name = "BtEnregistrer"
        Me.BtEnregistrer.Size = New System.Drawing.Size(132, 59)
        Me.BtEnregistrer.TabIndex = 142
        Me.BtEnregistrer.Text = "Terminer"
        Me.BtEnregistrer.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel5.Controls.Add(Me.GroupBox2)
        Me.Panel5.Location = New System.Drawing.Point(16, 237)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(715, 267)
        Me.Panel5.TabIndex = 144
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox2.Controls.Add(Me.DgvEmplacements)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(699, 251)
        Me.GroupBox2.TabIndex = 144
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Emplacements disponibles"
        '
        'DgvEmplacements
        '
        Me.DgvEmplacements.AllowUserToAddRows = False
        Me.DgvEmplacements.AllowUserToDeleteRows = False
        Me.DgvEmplacements.AllowUserToOrderColumns = True
        Me.DgvEmplacements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvEmplacements.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvEmplacements.BackgroundColor = System.Drawing.Color.White
        Me.DgvEmplacements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmplacements.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColEmplId, Me.ColEmplRef, Me.ColEmplType, Me.ColEmplPlLibres, Me.ColEmplPlTotal, Me.ColEmplClasse})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvEmplacements.DefaultCellStyle = DataGridViewCellStyle1
        Me.DgvEmplacements.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvEmplacements.Location = New System.Drawing.Point(8, 21)
        Me.DgvEmplacements.MultiSelect = False
        Me.DgvEmplacements.Name = "DgvEmplacements"
        Me.DgvEmplacements.ReadOnly = True
        Me.DgvEmplacements.RowHeadersVisible = False
        Me.DgvEmplacements.RowTemplate.Height = 24
        Me.DgvEmplacements.SelectedRow = Nothing
        Me.DgvEmplacements.SelectedRowIndex = -1
        Me.DgvEmplacements.SelectedValue = -1
        Me.DgvEmplacements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvEmplacements.Size = New System.Drawing.Size(685, 225)
        Me.DgvEmplacements.TabIndex = 143
        '
        'ColEmplId
        '
        Me.ColEmplId.DataPropertyName = "empl_id"
        Me.ColEmplId.HeaderText = "Id"
        Me.ColEmplId.Name = "ColEmplId"
        Me.ColEmplId.ReadOnly = True
        Me.ColEmplId.Visible = False
        '
        'ColEmplRef
        '
        Me.ColEmplRef.DataPropertyName = "empl_reference"
        Me.ColEmplRef.FillWeight = 70.0!
        Me.ColEmplRef.HeaderText = "Réf."
        Me.ColEmplRef.Name = "ColEmplRef"
        Me.ColEmplRef.ReadOnly = True
        '
        'ColEmplType
        '
        Me.ColEmplType.DataPropertyName = "empl_type"
        Me.ColEmplType.HeaderText = "Type"
        Me.ColEmplType.Name = "ColEmplType"
        Me.ColEmplType.ReadOnly = True
        '
        'ColEmplPlLibres
        '
        Me.ColEmplPlLibres.DataPropertyName = "places_libres"
        Me.ColEmplPlLibres.FillWeight = 50.0!
        Me.ColEmplPlLibres.HeaderText = "Places libres"
        Me.ColEmplPlLibres.Name = "ColEmplPlLibres"
        Me.ColEmplPlLibres.ReadOnly = True
        '
        'ColEmplPlTotal
        '
        Me.ColEmplPlTotal.DataPropertyName = "empl_nb_places"
        Me.ColEmplPlTotal.FillWeight = 50.0!
        Me.ColEmplPlTotal.HeaderText = "Places total"
        Me.ColEmplPlTotal.Name = "ColEmplPlTotal"
        Me.ColEmplPlTotal.ReadOnly = True
        '
        'ColEmplClasse
        '
        Me.ColEmplClasse.DataPropertyName = "empl_monum_classe"
        Me.ColEmplClasse.FillWeight = 50.0!
        Me.ColEmplClasse.HeaderText = "Classé"
        Me.ColEmplClasse.Name = "ColEmplClasse"
        Me.ColEmplClasse.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 17)
        Me.Label1.TabIndex = 165
        Me.Label1.Text = "Date de début"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(458, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 17)
        Me.Label3.TabIndex = 162
        Me.Label3.Text = "Montant à payer"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(677, 128)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 17)
        Me.Label11.TabIndex = 163
        Me.Label11.Text = "€"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel4.Controls.Add(Me.GroupBox3)
        Me.Panel4.Location = New System.Drawing.Point(16, 512)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(715, 170)
        Me.Panel4.TabIndex = 167
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox3.Controls.Add(Me.BtMontrerFormPlancim)
        Me.GroupBox3.Controls.Add(Me.TbDateFin)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.DtpDateDebut)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TbNbPlaces)
        Me.GroupBox3.Controls.Add(Me.CbTarifLh)
        Me.GroupBox3.Controls.Add(Me.LbTypeConcession)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TbMontant)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(699, 154)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Autres informations"
        '
        'BtMontrerFormPlancim
        '
        Me.BtMontrerFormPlancim.Image = Global.cimetiere.My.Resources.Resources.Note_16x
        Me.BtMontrerFormPlancim.Location = New System.Drawing.Point(647, 17)
        Me.BtMontrerFormPlancim.Name = "BtMontrerFormPlancim"
        Me.BtMontrerFormPlancim.Size = New System.Drawing.Size(32, 31)
        Me.BtMontrerFormPlancim.TabIndex = 177
        Me.BtMontrerFormPlancim.UseVisualStyleBackColor = True
        '
        'TbDateFin
        '
        Me.TbDateFin.Location = New System.Drawing.Point(461, 23)
        Me.TbDateFin.Name = "TbDateFin"
        Me.TbDateFin.ReadOnly = True
        Me.TbDateFin.Size = New System.Drawing.Size(159, 22)
        Me.TbDateFin.TabIndex = 176
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(377, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 17)
        Me.Label12.TabIndex = 175
        Me.Label12.Text = "Date de fin"
        '
        'DtpDateDebut
        '
        Me.DtpDateDebut.Location = New System.Drawing.Point(111, 23)
        Me.DtpDateDebut.Name = "DtpDateDebut"
        Me.DtpDateDebut.Size = New System.Drawing.Size(251, 22)
        Me.DtpDateDebut.TabIndex = 174
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(458, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 17)
        Me.Label2.TabIndex = 172
        Me.Label2.Text = "Nombre de places (si applicable) :"
        '
        'TbNbPlaces
        '
        Me.TbNbPlaces.Enabled = False
        Me.TbNbPlaces.Location = New System.Drawing.Point(461, 94)
        Me.TbNbPlaces.Name = "TbNbPlaces"
        Me.TbNbPlaces.Size = New System.Drawing.Size(100, 22)
        Me.TbNbPlaces.TabIndex = 171
        Me.TbNbPlaces.Value = Nothing
        '
        'CbTarifLh
        '
        Me.CbTarifLh.AutoSize = True
        Me.CbTarifLh.Checked = True
        Me.CbTarifLh.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbTarifLh.Location = New System.Drawing.Point(461, 50)
        Me.CbTarifLh.Name = "CbTarifLh"
        Me.CbTarifLh.Size = New System.Drawing.Size(123, 21)
        Me.CbTarifLh.TabIndex = 170
        Me.CbTarifLh.Text = "Tarif la hulpois"
        Me.CbTarifLh.UseVisualStyleBackColor = True
        '
        'LbTypeConcession
        '
        Me.LbTypeConcession.FormattingEnabled = True
        Me.LbTypeConcession.ItemHeight = 16
        Me.LbTypeConcession.Items.AddRange(New Object() {"Inhumation en pleine terre, concession de 15 ans (1 personne)", "Inhumation en pleine terre, concession de 15 ans (2 personnes)", "Caveau, concession de 30 ans (max. 3 places)", "Urne en colombarium, concession de 15 ans", "Urne en colombarium, concession de 30 ans", "Placement d'un cavurne communal, concession de 30 ans (max. 5 urnes)"})
        Me.LbTypeConcession.Location = New System.Drawing.Point(6, 50)
        Me.LbTypeConcession.Name = "LbTypeConcession"
        Me.LbTypeConcession.Size = New System.Drawing.Size(449, 100)
        Me.LbTypeConcession.TabIndex = 169
        '
        'TbMontant
        '
        Me.TbMontant.Location = New System.Drawing.Point(571, 126)
        Me.TbMontant.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TbMontant.Name = "TbMontant"
        Me.TbMontant.ReadOnly = True
        Me.TbMontant.Size = New System.Drawing.Size(100, 22)
        Me.TbMontant.TabIndex = 161
        Me.TbMontant.Value = Nothing
        '
        'PanCbsPdf
        '
        Me.PanCbsPdf.BackColor = System.Drawing.Color.SeaGreen
        Me.PanCbsPdf.Controls.Add(Me.Panel9)
        Me.PanCbsPdf.Location = New System.Drawing.Point(16, 691)
        Me.PanCbsPdf.Name = "PanCbsPdf"
        Me.PanCbsPdf.Size = New System.Drawing.Size(402, 76)
        Me.PanCbsPdf.TabIndex = 168
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.Window
        Me.Panel9.Controls.Add(Me.DtpDateSign)
        Me.Panel9.Controls.Add(Me.Label4)
        Me.Panel9.Controls.Add(Me.CbEnregPdf)
        Me.Panel9.Location = New System.Drawing.Point(8, 7)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(387, 62)
        Me.Panel9.TabIndex = 0
        '
        'DtpDateSign
        '
        Me.DtpDateSign.Location = New System.Drawing.Point(61, 7)
        Me.DtpDateSign.Name = "DtpDateSign"
        Me.DtpDateSign.ShowCheckBox = True
        Me.DtpDateSign.Size = New System.Drawing.Size(250, 22)
        Me.DtpDateSign.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Fait le"
        '
        'CbEnregPdf
        '
        Me.CbEnregPdf.AutoSize = True
        Me.CbEnregPdf.Checked = True
        Me.CbEnregPdf.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbEnregPdf.Location = New System.Drawing.Point(9, 37)
        Me.CbEnregPdf.Margin = New System.Windows.Forms.Padding(4)
        Me.CbEnregPdf.Name = "CbEnregPdf"
        Me.CbEnregPdf.Size = New System.Drawing.Size(188, 21)
        Me.CbEnregPdf.TabIndex = 8
        Me.CbEnregPdf.Text = "Enregistrer le fichier PDF"
        Me.CbEnregPdf.UseVisualStyleBackColor = True
        '
        'FormReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.BtAnnuler
        Me.ClientSize = New System.Drawing.Size(1491, 807)
        Me.Controls.Add(Me.PanCbsPdf)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.BtEnregistrer)
        Me.Controls.Add(Me.BtAnnuler)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormReservation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Réserver un emplacement"
        Me.GbCsnr.ResumeLayout(False)
        Me.GbCsnr.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GBListBenef.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgvEmplacements, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.PanCbsPdf.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GbCsnr As GroupBox
    Friend WithEvents TbCsnrNom As TextBox
    Friend WithEvents TbCsnrPrenom As TextBox
    Friend WithEvents TbdateCsnrDateNaiss As TextBoxDate
    Friend WithEvents TbCsnrAdresse As TextBox
    Friend WithEvents TbCsnrTel As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TbCsnrNoRegistre As MaskedTextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents CtrlLocVillePays1 As CtrlLocVillePays
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TbCommentaire As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GBListBenef As GroupBox
    Friend WithEvents BtAnnuler As Button
    Friend WithEvents BtEnregistrer As Button
    Friend WithEvents CtrlListeBenefs1 As CtrlListeBenefs
    Friend WithEvents Panel5 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DgvEmplacements As DataGridViewCustom
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TbMontant As TextBoxFloat
    Friend WithEvents Panel4 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PanCbsPdf As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents CbEnregPdf As CheckBox
    Friend WithEvents LbTypeConcession As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TbNbPlaces As TextBoxInt
    Friend WithEvents CbTarifLh As CheckBox
    Friend WithEvents ColEmplId As DataGridViewTextBoxColumn
    Friend WithEvents ColEmplRef As DataGridViewTextBoxColumn
    Friend WithEvents ColEmplType As DataGridViewTextBoxColumn
    Friend WithEvents ColEmplPlLibres As DataGridViewTextBoxColumn
    Friend WithEvents ColEmplPlTotal As DataGridViewTextBoxColumn
    Friend WithEvents ColEmplClasse As DataGridViewTextBoxColumn
    Friend WithEvents DtpDateDebut As DateTimePicker
    Friend WithEvents DtpDateSign As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TbDateFin As TextBox
    Friend WithEvents BtMontrerFormPlancim As Button
End Class
