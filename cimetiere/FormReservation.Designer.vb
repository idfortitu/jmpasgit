<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReservation
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
        Me.components = New System.ComponentModel.Container()
        Me.BtEnregistrer = New System.Windows.Forms.Button()
        Me.FPBLienCons = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GBListBenef = New System.Windows.Forms.GroupBox()
        Me.btRetirerBeneficiaire = New System.Windows.Forms.Button()
        Me.UcBenef1 = New cimetiere.UCBenef()
        Me.btAjoutBenef = New System.Windows.Forms.Button()
        Me.TbfloatMontantPaye = New cimetiere.TextBoxFloat()
        Me.CtrlLocVillePays1 = New cimetiere.CtrlLocVillePays()
        Me.TbdateCsnrDateNaiss = New cimetiere.TextBoxDate()
        Me.TbCsnrNoRegistre = New System.Windows.Forms.MaskedTextBox()
        Me.TbCsnrTel = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbCsnrAdresse = New System.Windows.Forms.TextBox()
        Me.TbCsnrNom = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.RbTypeEmpl1a = New System.Windows.Forms.RadioButton()
        Me.RbTypeEmpl4a = New System.Windows.Forms.RadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.RbTypeEmpl3a = New System.Windows.Forms.RadioButton()
        Me.RbTypeEmpl1b = New System.Windows.Forms.RadioButton()
        Me.RbTypeEmpl2a = New System.Windows.Forms.RadioButton()
        Me.RbTypeEmpl4b = New System.Windows.Forms.RadioButton()
        Me.cbCaveauCom = New System.Windows.Forms.CheckBox()
        Me.RbTypeEmpl3b = New System.Windows.Forms.RadioButton()
        Me.RbTypeEmpl2b = New System.Windows.Forms.RadioButton()
        Me.RbTypeEmpl5 = New System.Windows.Forms.RadioButton()
        Me.RbTypeEmpl6 = New System.Windows.Forms.RadioButton()
        Me.RbTypeEmpl10 = New System.Windows.Forms.RadioButton()
        Me.RbTypeEmpl7 = New System.Windows.Forms.RadioButton()
        Me.RbTypeEmpl9 = New System.Windows.Forms.RadioButton()
        Me.RbTypeEmpl8 = New System.Windows.Forms.RadioButton()
        Me.GbCsnr = New System.Windows.Forms.GroupBox()
        Me.TbCsnrPrenom = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.GBListBenef.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GbCsnr.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtEnregistrer
        '
        Me.BtEnregistrer.BackColor = System.Drawing.Color.SeaGreen
        Me.BtEnregistrer.ForeColor = System.Drawing.Color.Transparent
        Me.BtEnregistrer.Location = New System.Drawing.Point(507, 450)
        Me.BtEnregistrer.Name = "BtEnregistrer"
        Me.BtEnregistrer.Size = New System.Drawing.Size(99, 48)
        Me.BtEnregistrer.TabIndex = 149
        Me.BtEnregistrer.Text = "Terminer"
        Me.BtEnregistrer.UseVisualStyleBackColor = False
        '
        'FPBLienCons
        '
        Me.FPBLienCons.BackColor = System.Drawing.Color.SeaGreen
        Me.FPBLienCons.ForeColor = System.Drawing.Color.Transparent
        Me.FPBLienCons.Location = New System.Drawing.Point(383, 450)
        Me.FPBLienCons.Name = "FPBLienCons"
        Me.FPBLienCons.Size = New System.Drawing.Size(99, 48)
        Me.FPBLienCons.TabIndex = 148
        Me.FPBLienCons.Text = "Annuler"
        Me.FPBLienCons.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel3.Controls.Add(Me.GBListBenef)
        Me.Panel3.Location = New System.Drawing.Point(12, 190)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(536, 114)
        Me.Panel3.TabIndex = 145
        '
        'GBListBenef
        '
        Me.GBListBenef.BackColor = System.Drawing.SystemColors.Window
        Me.GBListBenef.Controls.Add(Me.btRetirerBeneficiaire)
        Me.GBListBenef.Controls.Add(Me.UcBenef1)
        Me.GBListBenef.Controls.Add(Me.btAjoutBenef)
        Me.GBListBenef.Location = New System.Drawing.Point(17, 19)
        Me.GBListBenef.Margin = New System.Windows.Forms.Padding(2)
        Me.GBListBenef.Name = "GBListBenef"
        Me.GBListBenef.Padding = New System.Windows.Forms.Padding(2)
        Me.GBListBenef.Size = New System.Drawing.Size(502, 78)
        Me.GBListBenef.TabIndex = 25
        Me.GBListBenef.TabStop = False
        Me.GBListBenef.Text = "Bénéficiaire"
        '
        'btRetirerBeneficiaire
        '
        Me.btRetirerBeneficiaire.Image = Global.cimetiere.My.Resources.Resources.moins
        Me.btRetirerBeneficiaire.Location = New System.Drawing.Point(5, 45)
        Me.btRetirerBeneficiaire.Name = "btRetirerBeneficiaire"
        Me.btRetirerBeneficiaire.Size = New System.Drawing.Size(24, 24)
        Me.btRetirerBeneficiaire.TabIndex = 24
        Me.btRetirerBeneficiaire.UseVisualStyleBackColor = True
        '
        'UcBenef1
        '
        Me.UcBenef1.Location = New System.Drawing.Point(35, 18)
        Me.UcBenef1.Name = "UcBenef1"
        Me.UcBenef1.Size = New System.Drawing.Size(467, 50)
        Me.UcBenef1.TabIndex = 2
        '
        'btAjoutBenef
        '
        Me.btAjoutBenef.Image = Global.cimetiere.My.Resources.Resources.Add_16x
        Me.btAjoutBenef.Location = New System.Drawing.Point(5, 18)
        Me.btAjoutBenef.Margin = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btAjoutBenef.Name = "btAjoutBenef"
        Me.btAjoutBenef.Size = New System.Drawing.Size(24, 24)
        Me.btAjoutBenef.TabIndex = 1
        Me.btAjoutBenef.UseVisualStyleBackColor = True
        '
        'TbfloatMontantPaye
        '
        Me.TbfloatMontantPaye.Location = New System.Drawing.Point(403, 326)
        Me.TbfloatMontantPaye.Margin = New System.Windows.Forms.Padding(2)
        Me.TbfloatMontantPaye.Name = "TbfloatMontantPaye"
        Me.TbfloatMontantPaye.Size = New System.Drawing.Size(76, 20)
        Me.TbfloatMontantPaye.TabIndex = 6
        Me.TbfloatMontantPaye.Value = Nothing
        '
        'CtrlLocVillePays1
        '
        Me.CtrlLocVillePays1.Location = New System.Drawing.Point(208, 50)
        Me.CtrlLocVillePays1.Margin = New System.Windows.Forms.Padding(2)
        Me.CtrlLocVillePays1.Name = "CtrlLocVillePays1"
        Me.CtrlLocVillePays1.Size = New System.Drawing.Size(237, 21)
        Me.CtrlLocVillePays1.TabIndex = 65
        '
        'TbdateCsnrDateNaiss
        '
        Me.TbdateCsnrDateNaiss.DateValue = Nothing
        Me.TbdateCsnrDateNaiss.Location = New System.Drawing.Point(106, 110)
        Me.TbdateCsnrDateNaiss.Margin = New System.Windows.Forms.Padding(2)
        Me.TbdateCsnrDateNaiss.Mask = "00/00/0000"
        Me.TbdateCsnrDateNaiss.Name = "TbdateCsnrDateNaiss"
        Me.TbdateCsnrDateNaiss.Size = New System.Drawing.Size(90, 20)
        Me.TbdateCsnrDateNaiss.TabIndex = 13
        Me.TbdateCsnrDateNaiss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbCsnrNoRegistre
        '
        Me.TbCsnrNoRegistre.Location = New System.Drawing.Point(314, 110)
        Me.TbCsnrNoRegistre.Margin = New System.Windows.Forms.Padding(2)
        Me.TbCsnrNoRegistre.Mask = "00\.00\.00-000\.00"
        Me.TbCsnrNoRegistre.Name = "TbCsnrNoRegistre"
        Me.TbCsnrNoRegistre.Size = New System.Drawing.Size(85, 20)
        Me.TbCsnrNoRegistre.TabIndex = 64
        Me.TbCsnrNoRegistre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TbCsnrNoRegistre.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'TbCsnrTel
        '
        Me.TbCsnrTel.Location = New System.Drawing.Point(66, 79)
        Me.TbCsnrTel.Margin = New System.Windows.Forms.Padding(2)
        Me.TbCsnrTel.Name = "TbCsnrTel"
        Me.TbCsnrTel.Size = New System.Drawing.Size(131, 20)
        Me.TbCsnrTel.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(225, 113)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Numéro national"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 53)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Adresse"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 113)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Date de naissance"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 21)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Prénom"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 82)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Téléphone"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(486, 330)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "€"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(225, 21)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Nom"
        '
        'TbCsnrAdresse
        '
        Me.TbCsnrAdresse.Location = New System.Drawing.Point(66, 51)
        Me.TbCsnrAdresse.Margin = New System.Windows.Forms.Padding(2)
        Me.TbCsnrAdresse.Name = "TbCsnrAdresse"
        Me.TbCsnrAdresse.Size = New System.Drawing.Size(131, 20)
        Me.TbCsnrAdresse.TabIndex = 14
        '
        'TbCsnrNom
        '
        Me.TbCsnrNom.Location = New System.Drawing.Point(257, 19)
        Me.TbCsnrNom.Margin = New System.Windows.Forms.Padding(2)
        Me.TbCsnrNom.Name = "TbCsnrNom"
        Me.TbCsnrNom.Size = New System.Drawing.Size(134, 20)
        Me.TbCsnrNom.TabIndex = 11
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel6.Controls.Add(Me.GroupBox4)
        Me.Panel6.Location = New System.Drawing.Point(555, 10)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(536, 379)
        Me.Panel6.TabIndex = 144
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.TbfloatMontantPaye)
        Me.GroupBox4.Controls.Add(Me.RbTypeEmpl1a)
        Me.GroupBox4.Controls.Add(Me.RbTypeEmpl4a)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.RbTypeEmpl3a)
        Me.GroupBox4.Controls.Add(Me.RbTypeEmpl1b)
        Me.GroupBox4.Controls.Add(Me.RbTypeEmpl2a)
        Me.GroupBox4.Controls.Add(Me.RbTypeEmpl4b)
        Me.GroupBox4.Controls.Add(Me.cbCaveauCom)
        Me.GroupBox4.Controls.Add(Me.RbTypeEmpl3b)
        Me.GroupBox4.Controls.Add(Me.RbTypeEmpl2b)
        Me.GroupBox4.Controls.Add(Me.RbTypeEmpl5)
        Me.GroupBox4.Controls.Add(Me.RbTypeEmpl6)
        Me.GroupBox4.Controls.Add(Me.RbTypeEmpl10)
        Me.GroupBox4.Controls.Add(Me.RbTypeEmpl7)
        Me.GroupBox4.Controls.Add(Me.RbTypeEmpl9)
        Me.GroupBox4.Controls.Add(Me.RbTypeEmpl8)
        Me.GroupBox4.Location = New System.Drawing.Point(17, 13)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(502, 351)
        Me.GroupBox4.TabIndex = 158
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Type d'emplacement demandé"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(2, 25)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(172, 13)
        Me.Label12.TabIndex = 158
        Me.Label12.Text = "Inhumation ordinaire en pleine terre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(318, 329)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Montant à payer"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(2, 72)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(312, 13)
        Me.Label13.TabIndex = 157
        Me.Label13.Text = "Inhumation en pleine terre (1 personne)  –  concession de 15 ans"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(2, 116)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(317, 13)
        Me.Label14.TabIndex = 156
        Me.Label14.Text = "Inhumation en pleine terre (2 personnes)  –  concession de 15 ans"
        '
        'RbTypeEmpl1a
        '
        Me.RbTypeEmpl1a.AutoSize = True
        Me.RbTypeEmpl1a.Location = New System.Drawing.Point(27, 45)
        Me.RbTypeEmpl1a.Name = "RbTypeEmpl1a"
        Me.RbTypeEmpl1a.Size = New System.Drawing.Size(63, 17)
        Me.RbTypeEmpl1a.TabIndex = 1
        Me.RbTypeEmpl1a.TabStop = True
        Me.RbTypeEmpl1a.Text = "Cercueil"
        Me.RbTypeEmpl1a.UseVisualStyleBackColor = True
        '
        'RbTypeEmpl4a
        '
        Me.RbTypeEmpl4a.AutoSize = True
        Me.RbTypeEmpl4a.Location = New System.Drawing.Point(28, 180)
        Me.RbTypeEmpl4a.Name = "RbTypeEmpl4a"
        Me.RbTypeEmpl4a.Size = New System.Drawing.Size(63, 17)
        Me.RbTypeEmpl4a.TabIndex = 7
        Me.RbTypeEmpl4a.TabStop = True
        Me.RbTypeEmpl4a.Text = "Cercueil"
        Me.RbTypeEmpl4a.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(2, 160)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(240, 13)
        Me.Label15.TabIndex = 155
        Me.Label15.Text = "Placement d'un caveau  –  concession de 30 ans"
        '
        'RbTypeEmpl3a
        '
        Me.RbTypeEmpl3a.AutoSize = True
        Me.RbTypeEmpl3a.Location = New System.Drawing.Point(28, 136)
        Me.RbTypeEmpl3a.Name = "RbTypeEmpl3a"
        Me.RbTypeEmpl3a.Size = New System.Drawing.Size(63, 17)
        Me.RbTypeEmpl3a.TabIndex = 5
        Me.RbTypeEmpl3a.TabStop = True
        Me.RbTypeEmpl3a.Text = "Cercueil"
        Me.RbTypeEmpl3a.UseVisualStyleBackColor = True
        '
        'RbTypeEmpl1b
        '
        Me.RbTypeEmpl1b.AutoSize = True
        Me.RbTypeEmpl1b.Location = New System.Drawing.Point(92, 45)
        Me.RbTypeEmpl1b.Name = "RbTypeEmpl1b"
        Me.RbTypeEmpl1b.Size = New System.Drawing.Size(48, 17)
        Me.RbTypeEmpl1b.TabIndex = 2
        Me.RbTypeEmpl1b.TabStop = True
        Me.RbTypeEmpl1b.Text = "Urne"
        Me.RbTypeEmpl1b.UseVisualStyleBackColor = True
        '
        'RbTypeEmpl2a
        '
        Me.RbTypeEmpl2a.AutoSize = True
        Me.RbTypeEmpl2a.Location = New System.Drawing.Point(27, 91)
        Me.RbTypeEmpl2a.Name = "RbTypeEmpl2a"
        Me.RbTypeEmpl2a.Size = New System.Drawing.Size(63, 17)
        Me.RbTypeEmpl2a.TabIndex = 3
        Me.RbTypeEmpl2a.TabStop = True
        Me.RbTypeEmpl2a.Text = "Cercueil"
        Me.RbTypeEmpl2a.UseVisualStyleBackColor = True
        '
        'RbTypeEmpl4b
        '
        Me.RbTypeEmpl4b.AutoSize = True
        Me.RbTypeEmpl4b.Location = New System.Drawing.Point(93, 180)
        Me.RbTypeEmpl4b.Name = "RbTypeEmpl4b"
        Me.RbTypeEmpl4b.Size = New System.Drawing.Size(48, 17)
        Me.RbTypeEmpl4b.TabIndex = 8
        Me.RbTypeEmpl4b.TabStop = True
        Me.RbTypeEmpl4b.Text = "Urne"
        Me.RbTypeEmpl4b.UseVisualStyleBackColor = True
        '
        'cbCaveauCom
        '
        Me.cbCaveauCom.AutoSize = True
        Me.cbCaveauCom.Location = New System.Drawing.Point(160, 181)
        Me.cbCaveauCom.Name = "cbCaveauCom"
        Me.cbCaveauCom.Size = New System.Drawing.Size(239, 17)
        Me.cbCaveauCom.TabIndex = 9
        Me.cbCaveauCom.Text = "Emplacement pourvu d'un caveau communal"
        Me.cbCaveauCom.UseVisualStyleBackColor = True
        '
        'RbTypeEmpl3b
        '
        Me.RbTypeEmpl3b.AutoSize = True
        Me.RbTypeEmpl3b.Location = New System.Drawing.Point(93, 136)
        Me.RbTypeEmpl3b.Name = "RbTypeEmpl3b"
        Me.RbTypeEmpl3b.Size = New System.Drawing.Size(48, 17)
        Me.RbTypeEmpl3b.TabIndex = 6
        Me.RbTypeEmpl3b.TabStop = True
        Me.RbTypeEmpl3b.Text = "Urne"
        Me.RbTypeEmpl3b.UseVisualStyleBackColor = True
        '
        'RbTypeEmpl2b
        '
        Me.RbTypeEmpl2b.AutoSize = True
        Me.RbTypeEmpl2b.Location = New System.Drawing.Point(92, 91)
        Me.RbTypeEmpl2b.Name = "RbTypeEmpl2b"
        Me.RbTypeEmpl2b.Size = New System.Drawing.Size(48, 17)
        Me.RbTypeEmpl2b.TabIndex = 4
        Me.RbTypeEmpl2b.TabStop = True
        Me.RbTypeEmpl2b.Text = "Urne"
        Me.RbTypeEmpl2b.UseVisualStyleBackColor = True
        '
        'RbTypeEmpl5
        '
        Me.RbTypeEmpl5.AutoSize = True
        Me.RbTypeEmpl5.Location = New System.Drawing.Point(4, 208)
        Me.RbTypeEmpl5.Name = "RbTypeEmpl5"
        Me.RbTypeEmpl5.Size = New System.Drawing.Size(400, 17)
        Me.RbTypeEmpl5.TabIndex = 10
        Me.RbTypeEmpl5.TabStop = True
        Me.RbTypeEmpl5.Text = "Ouverture de caveau uniquement si travail du Fossoyeur (ouverture par chemin)"
        Me.RbTypeEmpl5.UseVisualStyleBackColor = True
        '
        'RbTypeEmpl6
        '
        Me.RbTypeEmpl6.AutoSize = True
        Me.RbTypeEmpl6.Location = New System.Drawing.Point(4, 231)
        Me.RbTypeEmpl6.Name = "RbTypeEmpl6"
        Me.RbTypeEmpl6.Size = New System.Drawing.Size(385, 17)
        Me.RbTypeEmpl6.TabIndex = 11
        Me.RbTypeEmpl6.TabStop = True
        Me.RbTypeEmpl6.Text = "Une urne mise en columbarium - place ordinaire (cell. 1 place prioritairement) "
        Me.RbTypeEmpl6.UseVisualStyleBackColor = True
        '
        'RbTypeEmpl10
        '
        Me.RbTypeEmpl10.AutoSize = True
        Me.RbTypeEmpl10.Location = New System.Drawing.Point(4, 323)
        Me.RbTypeEmpl10.Name = "RbTypeEmpl10"
        Me.RbTypeEmpl10.Size = New System.Drawing.Size(135, 17)
        Me.RbTypeEmpl10.TabIndex = 15
        Me.RbTypeEmpl10.TabStop = True
        Me.RbTypeEmpl10.Text = "Dispersion des cendres"
        Me.RbTypeEmpl10.UseVisualStyleBackColor = True
        '
        'RbTypeEmpl7
        '
        Me.RbTypeEmpl7.AutoSize = True
        Me.RbTypeEmpl7.Location = New System.Drawing.Point(4, 254)
        Me.RbTypeEmpl7.Name = "RbTypeEmpl7"
        Me.RbTypeEmpl7.Size = New System.Drawing.Size(291, 17)
        Me.RbTypeEmpl7.TabIndex = 12
        Me.RbTypeEmpl7.TabStop = True
        Me.RbTypeEmpl7.Text = "Une urne mise en colombarium  –  concession de 15 ans"
        Me.RbTypeEmpl7.UseVisualStyleBackColor = True
        '
        'RbTypeEmpl9
        '
        Me.RbTypeEmpl9.AutoSize = True
        Me.RbTypeEmpl9.Location = New System.Drawing.Point(4, 300)
        Me.RbTypeEmpl9.Name = "RbTypeEmpl9"
        Me.RbTypeEmpl9.Size = New System.Drawing.Size(378, 17)
        Me.RbTypeEmpl9.TabIndex = 14
        Me.RbTypeEmpl9.TabStop = True
        Me.RbTypeEmpl9.Text = "Placement d'un cavurne communal  –  concession de 30 ans (max 5 urnes)"
        Me.RbTypeEmpl9.UseVisualStyleBackColor = True
        '
        'RbTypeEmpl8
        '
        Me.RbTypeEmpl8.AutoSize = True
        Me.RbTypeEmpl8.Location = New System.Drawing.Point(4, 277)
        Me.RbTypeEmpl8.Name = "RbTypeEmpl8"
        Me.RbTypeEmpl8.Size = New System.Drawing.Size(291, 17)
        Me.RbTypeEmpl8.TabIndex = 13
        Me.RbTypeEmpl8.TabStop = True
        Me.RbTypeEmpl8.Text = "Une urne mise en colombarium  –  concession de 30 ans"
        Me.RbTypeEmpl8.UseVisualStyleBackColor = True
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
        Me.GbCsnr.Location = New System.Drawing.Point(17, 14)
        Me.GbCsnr.Margin = New System.Windows.Forms.Padding(2)
        Me.GbCsnr.Name = "GbCsnr"
        Me.GbCsnr.Padding = New System.Windows.Forms.Padding(2)
        Me.GbCsnr.Size = New System.Drawing.Size(502, 141)
        Me.GbCsnr.TabIndex = 10
        Me.GbCsnr.TabStop = False
        Me.GbCsnr.Text = "Concessionnaire"
        '
        'TbCsnrPrenom
        '
        Me.TbCsnrPrenom.Location = New System.Drawing.Point(66, 21)
        Me.TbCsnrPrenom.Margin = New System.Windows.Forms.Padding(2)
        Me.TbCsnrPrenom.Name = "TbCsnrPrenom"
        Me.TbCsnrPrenom.Size = New System.Drawing.Size(131, 20)
        Me.TbCsnrPrenom.TabIndex = 12
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Controls.Add(Me.GbCsnr)
        Me.Panel1.Location = New System.Drawing.Point(12, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(536, 174)
        Me.Panel1.TabIndex = 147
        '
        'FormReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.cimetiere.My.Resources.Resources.fondformulaire
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1088, 504)
        Me.Controls.Add(Me.BtEnregistrer)
        Me.Controls.Add(Me.FPBLienCons)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormReservation"
        Me.Text = "FormReservation"
        Me.Panel3.ResumeLayout(False)
        Me.GBListBenef.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GbCsnr.ResumeLayout(False)
        Me.GbCsnr.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtEnregistrer As Button
    Friend WithEvents FPBLienCons As Button
    Friend WithEvents btRetirerBeneficiaire As Button
    Friend WithEvents btAjoutBenef As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GBListBenef As GroupBox
    Friend WithEvents UcBenef1 As UCBenef
    Friend WithEvents TbfloatMontantPaye As TextBoxFloat
    Friend WithEvents CtrlLocVillePays1 As CtrlLocVillePays
    Friend WithEvents TbdateCsnrDateNaiss As TextBoxDate
    Friend WithEvents TbCsnrNoRegistre As MaskedTextBox
    Friend WithEvents TbCsnrTel As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Panel6 As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents RbTypeEmpl1a As RadioButton
    Friend WithEvents RbTypeEmpl4a As RadioButton
    Friend WithEvents Label15 As Label
    Friend WithEvents RbTypeEmpl3a As RadioButton
    Friend WithEvents RbTypeEmpl1b As RadioButton
    Friend WithEvents RbTypeEmpl2a As RadioButton
    Friend WithEvents RbTypeEmpl4b As RadioButton
    Friend WithEvents cbCaveauCom As CheckBox
    Friend WithEvents RbTypeEmpl3b As RadioButton
    Friend WithEvents RbTypeEmpl2b As RadioButton
    Friend WithEvents RbTypeEmpl5 As RadioButton
    Friend WithEvents RbTypeEmpl6 As RadioButton
    Friend WithEvents RbTypeEmpl10 As RadioButton
    Friend WithEvents RbTypeEmpl7 As RadioButton
    Friend WithEvents RbTypeEmpl9 As RadioButton
    Friend WithEvents RbTypeEmpl8 As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GbCsnr As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TbCsnrAdresse As TextBox
    Friend WithEvents TbCsnrNom As TextBox
    Friend WithEvents TbCsnrPrenom As TextBox
End Class
