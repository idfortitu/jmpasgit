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
        Me.TbCsnrNoRegistre = New System.Windows.Forms.MaskedTextBox()
        Me.TbCsnrTel = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
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
        Me.FPBLienCons = New System.Windows.Forms.Button()
        Me.BtEnregistrer = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Rb30Ans = New System.Windows.Forms.RadioButton()
        Me.Rb15Ans = New System.Windows.Forms.RadioButton()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Rb2Pers = New System.Windows.Forms.RadioButton()
        Me.Rb1Pers = New System.Windows.Forms.RadioButton()
        Me.TbfloatMontantPaye = New cimetiere.TextBoxFloat()
        Me.TbdDateDebut = New cimetiere.TextBoxDate()
        Me.DgvEmplacements = New cimetiere.DataGridViewCustom()
        Me.ColEmplId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEmplRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEmplType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEmplDateFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEmplPlLibres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEmplPlTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEmplClasse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CtrlListeBenefs1 = New cimetiere.CtrlListeBenefs()
        Me.CtrlLocVillePays1 = New cimetiere.CtrlLocVillePays()
        Me.TbdateCsnrDateNaiss = New cimetiere.TextBoxDate()
        Me.GbCsnr.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GBListBenef.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.DgvEmplacements, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'FPBLienCons
        '
        Me.FPBLienCons.BackColor = System.Drawing.Color.SeaGreen
        Me.FPBLienCons.ForeColor = System.Drawing.Color.Transparent
        Me.FPBLienCons.Location = New System.Drawing.Point(438, 687)
        Me.FPBLienCons.Margin = New System.Windows.Forms.Padding(4)
        Me.FPBLienCons.Name = "FPBLienCons"
        Me.FPBLienCons.Size = New System.Drawing.Size(132, 59)
        Me.FPBLienCons.TabIndex = 139
        Me.FPBLienCons.Text = "Annuler"
        Me.FPBLienCons.UseVisualStyleBackColor = False
        '
        'BtEnregistrer
        '
        Me.BtEnregistrer.BackColor = System.Drawing.Color.SeaGreen
        Me.BtEnregistrer.ForeColor = System.Drawing.Color.Transparent
        Me.BtEnregistrer.Location = New System.Drawing.Point(604, 687)
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
        Me.Label3.Location = New System.Drawing.Point(420, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 17)
        Me.Label3.TabIndex = 162
        Me.Label3.Text = "Montant à payer"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(643, 99)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 17)
        Me.Label11.TabIndex = 163
        Me.Label11.Text = "€"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(770, 705)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 166
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel4.Controls.Add(Me.GroupBox3)
        Me.Panel4.Location = New System.Drawing.Point(16, 512)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(715, 157)
        Me.Panel4.TabIndex = 167
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox3.Controls.Add(Me.CheckBox2)
        Me.GroupBox3.Controls.Add(Me.CheckBox1)
        Me.GroupBox3.Controls.Add(Me.Panel7)
        Me.GroupBox3.Controls.Add(Me.Panel6)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TbfloatMontantPaye)
        Me.GroupBox3.Controls.Add(Me.TbdDateDebut)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(699, 140)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Autres informations"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(449, 57)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(250, 21)
        Me.CheckBox2.TabIndex = 174
        Me.CheckBox2.Text = "Placement d'un cavurne communal"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(269, 57)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(177, 21)
        Me.CheckBox1.TabIndex = 173
        Me.CheckBox1.Text = "Placement d'un caveau"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Rb30Ans)
        Me.Panel7.Controls.Add(Me.Rb15Ans)
        Me.Panel7.Location = New System.Drawing.Point(269, 21)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(213, 29)
        Me.Panel7.TabIndex = 172
        '
        'Rb30Ans
        '
        Me.Rb30Ans.AutoSize = True
        Me.Rb30Ans.Location = New System.Drawing.Point(105, 5)
        Me.Rb30Ans.Name = "Rb30Ans"
        Me.Rb30Ans.Size = New System.Drawing.Size(72, 21)
        Me.Rb30Ans.TabIndex = 170
        Me.Rb30Ans.TabStop = True
        Me.Rb30Ans.Text = "30 ans"
        Me.Rb30Ans.UseVisualStyleBackColor = True
        '
        'Rb15Ans
        '
        Me.Rb15Ans.AutoSize = True
        Me.Rb15Ans.Location = New System.Drawing.Point(7, 5)
        Me.Rb15Ans.Name = "Rb15Ans"
        Me.Rb15Ans.Size = New System.Drawing.Size(72, 21)
        Me.Rb15Ans.TabIndex = 169
        Me.Rb15Ans.TabStop = True
        Me.Rb15Ans.Text = "15 ans"
        Me.Rb15Ans.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Rb2Pers)
        Me.Panel6.Controls.Add(Me.Rb1Pers)
        Me.Panel6.Location = New System.Drawing.Point(12, 52)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(254, 29)
        Me.Panel6.TabIndex = 171
        '
        'Rb2Pers
        '
        Me.Rb2Pers.AutoSize = True
        Me.Rb2Pers.Location = New System.Drawing.Point(114, 4)
        Me.Rb2Pers.Name = "Rb2Pers"
        Me.Rb2Pers.Size = New System.Drawing.Size(108, 21)
        Me.Rb2Pers.TabIndex = 168
        Me.Rb2Pers.TabStop = True
        Me.Rb2Pers.Text = "2 personnes"
        Me.Rb2Pers.UseVisualStyleBackColor = True
        '
        'Rb1Pers
        '
        Me.Rb1Pers.AutoSize = True
        Me.Rb1Pers.Location = New System.Drawing.Point(3, 4)
        Me.Rb1Pers.Name = "Rb1Pers"
        Me.Rb1Pers.Size = New System.Drawing.Size(101, 21)
        Me.Rb1Pers.TabIndex = 166
        Me.Rb1Pers.TabStop = True
        Me.Rb1Pers.Text = "1 personne"
        Me.Rb1Pers.UseVisualStyleBackColor = True
        '
        'TbfloatMontantPaye
        '
        Me.TbfloatMontantPaye.Location = New System.Drawing.Point(537, 97)
        Me.TbfloatMontantPaye.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TbfloatMontantPaye.Name = "TbfloatMontantPaye"
        Me.TbfloatMontantPaye.Size = New System.Drawing.Size(100, 22)
        Me.TbfloatMontantPaye.TabIndex = 161
        Me.TbfloatMontantPaye.Value = Nothing
        '
        'TbdDateDebut
        '
        Me.TbdDateDebut.DateValue = Nothing
        Me.TbdDateDebut.Location = New System.Drawing.Point(120, 24)
        Me.TbdDateDebut.Mask = "00/00/0000"
        Me.TbdDateDebut.Name = "TbdDateDebut"
        Me.TbdDateDebut.Size = New System.Drawing.Size(100, 22)
        Me.TbdDateDebut.TabIndex = 164
        Me.TbdDateDebut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.DgvEmplacements.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColEmplId, Me.ColEmplRef, Me.ColEmplType, Me.ColEmplDateFin, Me.ColEmplPlLibres, Me.ColEmplPlTotal, Me.ColEmplClasse})
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
        Me.DgvEmplacements.Size = New System.Drawing.Size(685, 224)
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
        'ColEmplDateFin
        '
        Me.ColEmplDateFin.DataPropertyName = "con_date_fin"
        Me.ColEmplDateFin.HeaderText = "Loué"
        Me.ColEmplDateFin.Name = "ColEmplDateFin"
        Me.ColEmplDateFin.ReadOnly = True
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
        'CtrlListeBenefs1
        '
        Me.CtrlListeBenefs1.AutoScroll = True
        Me.CtrlListeBenefs1.Location = New System.Drawing.Point(5, 28)
        Me.CtrlListeBenefs1.Name = "CtrlListeBenefs1"
        Me.CtrlListeBenefs1.Size = New System.Drawing.Size(689, 440)
        Me.CtrlListeBenefs1.TabIndex = 0
        '
        'CtrlLocVillePays1
        '
        Me.CtrlLocVillePays1.Location = New System.Drawing.Point(277, 62)
        Me.CtrlLocVillePays1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CtrlLocVillePays1.Name = "CtrlLocVillePays1"
        Me.CtrlLocVillePays1.Size = New System.Drawing.Size(316, 26)
        Me.CtrlLocVillePays1.TabIndex = 65
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
        'FormReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = Global.cimetiere.My.Resources.Resources.fondformulaire
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1491, 807)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.BtEnregistrer)
        Me.Controls.Add(Me.FPBLienCons)
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
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.DgvEmplacements, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents FPBLienCons As Button
    Friend WithEvents BtEnregistrer As Button
    Friend WithEvents CtrlListeBenefs1 As CtrlListeBenefs
    Friend WithEvents Panel5 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DgvEmplacements As DataGridViewCustom
    Friend WithEvents Label1 As Label
    Friend WithEvents TbdDateDebut As TextBoxDate
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TbfloatMontantPaye As TextBoxFloat
    Friend WithEvents Button1 As Button
    Friend WithEvents ColEmplId As DataGridViewTextBoxColumn
    Friend WithEvents ColEmplRef As DataGridViewTextBoxColumn
    Friend WithEvents ColEmplType As DataGridViewTextBoxColumn
    Friend WithEvents ColEmplDateFin As DataGridViewTextBoxColumn
    Friend WithEvents ColEmplPlLibres As DataGridViewTextBoxColumn
    Friend WithEvents ColEmplPlTotal As DataGridViewTextBoxColumn
    Friend WithEvents ColEmplClasse As DataGridViewTextBoxColumn
    Friend WithEvents Panel4 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Rb30Ans As RadioButton
    Friend WithEvents Rb15Ans As RadioButton
    Friend WithEvents Rb2Pers As RadioButton
    Friend WithEvents Rb1Pers As RadioButton
    Friend WithEvents Panel7 As Panel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
End Class
