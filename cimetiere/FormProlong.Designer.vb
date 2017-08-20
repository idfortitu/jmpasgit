<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormProlong
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProlong))
        Me.BtTerminer = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.CbEnregPdfCsn = New System.Windows.Forms.CheckBox()
        Me.GbN = New System.Windows.Forms.GroupBox()
        Me.LbOccupants = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LbBenefs = New System.Windows.Forms.ListBox()
        Me.TbCom = New System.Windows.Forms.TextBox()
        Me.GbO = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbRecherche = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TbDateFinAct = New System.Windows.Forms.TextBox()
        Me.TbDateDebut = New System.Windows.Forms.TextBox()
        Me.BtAjouterAnnees = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtViderFiltre = New System.Windows.Forms.Button()
        Me.ErProv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TbDmdrTel = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbDmdrNom = New System.Windows.Forms.TextBox()
        Me.TbDmdrAdresse = New System.Windows.Forms.TextBox()
        Me.TbDmdrPrenom = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TbRem = New System.Windows.Forms.TextBox()
        Me.BtInfosCsnr = New System.Windows.Forms.Button()
        Me.TbDmdrDateNaiss = New cimetiere.TextBoxDate()
        Me.CtrlVilleDmdr = New cimetiere.CtrlLocVillePays()
        Me.TbAnneesAjout = New cimetiere.TextBoxInt()
        Me.TbNouvDateFin = New cimetiere.TextBoxDate()
        Me.DgvCsns = New cimetiere.DataGridViewConcessions()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvCsnsColOccupants = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.GbN.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GbO.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ErProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvCsns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtTerminer
        '
        Me.BtTerminer.BackColor = System.Drawing.Color.SeaGreen
        Me.BtTerminer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtTerminer.ForeColor = System.Drawing.Color.Transparent
        Me.BtTerminer.Location = New System.Drawing.Point(783, 679)
        Me.BtTerminer.Margin = New System.Windows.Forms.Padding(4)
        Me.BtTerminer.Name = "BtTerminer"
        Me.BtTerminer.Size = New System.Drawing.Size(154, 62)
        Me.BtTerminer.TabIndex = 135
        Me.BtTerminer.Text = "Prolonger"
        Me.BtTerminer.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Location = New System.Drawing.Point(500, 672)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(276, 76)
        Me.Panel3.TabIndex = 181
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.Window
        Me.Panel7.Controls.Add(Me.CbEnregPdfCsn)
        Me.Panel7.Location = New System.Drawing.Point(6, 7)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(265, 62)
        Me.Panel7.TabIndex = 0
        '
        'CbEnregPdfCsn
        '
        Me.CbEnregPdfCsn.AutoSize = True
        Me.CbEnregPdfCsn.Checked = True
        Me.CbEnregPdfCsn.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbEnregPdfCsn.Location = New System.Drawing.Point(6, 6)
        Me.CbEnregPdfCsn.Margin = New System.Windows.Forms.Padding(4)
        Me.CbEnregPdfCsn.Name = "CbEnregPdfCsn"
        Me.CbEnregPdfCsn.Size = New System.Drawing.Size(188, 21)
        Me.CbEnregPdfCsn.TabIndex = 8
        Me.CbEnregPdfCsn.Text = "Enregistrer le fichier PDF"
        Me.CbEnregPdfCsn.UseVisualStyleBackColor = True
        '
        'GbN
        '
        Me.GbN.BackColor = System.Drawing.Color.Transparent
        Me.GbN.Controls.Add(Me.LbOccupants)
        Me.GbN.Location = New System.Drawing.Point(12, 304)
        Me.GbN.Name = "GbN"
        Me.GbN.Size = New System.Drawing.Size(342, 169)
        Me.GbN.TabIndex = 182
        Me.GbN.TabStop = False
        Me.GbN.Text = "Défunts actuels"
        '
        'LbOccupants
        '
        Me.LbOccupants.FormattingEnabled = True
        Me.LbOccupants.IntegralHeight = False
        Me.LbOccupants.ItemHeight = 16
        Me.LbOccupants.Location = New System.Drawing.Point(6, 21)
        Me.LbOccupants.Name = "LbOccupants"
        Me.LbOccupants.Size = New System.Drawing.Size(330, 141)
        Me.LbOccupants.TabIndex = 183
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.LbBenefs)
        Me.GroupBox3.Location = New System.Drawing.Point(360, 306)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(315, 167)
        Me.GroupBox3.TabIndex = 180
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Bénéficiaires"
        '
        'LbBenefs
        '
        Me.LbBenefs.FormattingEnabled = True
        Me.LbBenefs.IntegralHeight = False
        Me.LbBenefs.ItemHeight = 16
        Me.LbBenefs.Location = New System.Drawing.Point(6, 21)
        Me.LbBenefs.Name = "LbBenefs"
        Me.LbBenefs.Size = New System.Drawing.Size(299, 139)
        Me.LbBenefs.TabIndex = 0
        '
        'TbCom
        '
        Me.TbCom.Location = New System.Drawing.Point(6, 21)
        Me.TbCom.Multiline = True
        Me.TbCom.Name = "TbCom"
        Me.TbCom.ReadOnly = True
        Me.TbCom.Size = New System.Drawing.Size(256, 138)
        Me.TbCom.TabIndex = 183
        '
        'GbO
        '
        Me.GbO.BackColor = System.Drawing.Color.Transparent
        Me.GbO.Controls.Add(Me.TbCom)
        Me.GbO.Location = New System.Drawing.Point(681, 307)
        Me.GbO.Name = "GbO"
        Me.GbO.Size = New System.Drawing.Size(269, 166)
        Me.GbO.TabIndex = 184
        Me.GbO.TabStop = False
        Me.GbO.Text = "Commentaire"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(15, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 185
        Me.Label1.Text = "Filtre :"
        '
        'TbRecherche
        '
        Me.TbRecherche.Location = New System.Drawing.Point(68, 12)
        Me.TbRecherche.Name = "TbRecherche"
        Me.TbRecherche.Size = New System.Drawing.Size(147, 22)
        Me.TbRecherche.TabIndex = 186
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 641)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 139)
        Me.GroupBox1.TabIndex = 187
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Durée"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.TbDateFinAct)
        Me.Panel1.Controls.Add(Me.TbDateDebut)
        Me.Panel1.Controls.Add(Me.BtAjouterAnnees)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TbAnneesAjout)
        Me.Panel1.Controls.Add(Me.TbNouvDateFin)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(6, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(454, 112)
        Me.Panel1.TabIndex = 0
        '
        'TbDateFinAct
        '
        Me.TbDateFinAct.Location = New System.Drawing.Point(141, 32)
        Me.TbDateFinAct.Name = "TbDateFinAct"
        Me.TbDateFinAct.ReadOnly = True
        Me.TbDateFinAct.Size = New System.Drawing.Size(103, 22)
        Me.TbDateFinAct.TabIndex = 12
        '
        'TbDateDebut
        '
        Me.TbDateDebut.Location = New System.Drawing.Point(19, 32)
        Me.TbDateDebut.Name = "TbDateDebut"
        Me.TbDateDebut.ReadOnly = True
        Me.TbDateDebut.Size = New System.Drawing.Size(95, 22)
        Me.TbDateDebut.TabIndex = 11
        '
        'BtAjouterAnnees
        '
        Me.BtAjouterAnnees.Location = New System.Drawing.Point(181, 77)
        Me.BtAjouterAnnees.Name = "BtAjouterAnnees"
        Me.BtAjouterAnnees.Size = New System.Drawing.Size(75, 23)
        Me.BtAjouterAnnees.TabIndex = 8
        Me.BtAjouterAnnees.Text = "Ajouter"
        Me.BtAjouterAnnees.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(308, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "ans"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(294, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nouvelle date de fin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(137, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Date de fin actuelle"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Date de début"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label6.Location = New System.Drawing.Point(157, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 31)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "↘"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label7.Location = New System.Drawing.Point(332, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 31)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "↗"
        '
        'BtViderFiltre
        '
        Me.BtViderFiltre.Image = Global.cimetiere.My.Resources.Resources.Cancel_16x
        Me.BtViderFiltre.Location = New System.Drawing.Point(221, 9)
        Me.BtViderFiltre.Name = "BtViderFiltre"
        Me.BtViderFiltre.Size = New System.Drawing.Size(32, 29)
        Me.BtViderFiltre.TabIndex = 188
        Me.BtViderFiltre.UseVisualStyleBackColor = True
        '
        'ErProv
        '
        Me.ErProv.ContainerControl = Me
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.BtInfosCsnr)
        Me.GroupBox4.Controls.Add(Me.TbDmdrDateNaiss)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.TbDmdrTel)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.CtrlVilleDmdr)
        Me.GroupBox4.Controls.Add(Me.TbDmdrNom)
        Me.GroupBox4.Controls.Add(Me.TbDmdrAdresse)
        Me.GroupBox4.Controls.Add(Me.TbDmdrPrenom)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 483)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(633, 152)
        Me.GroupBox4.TabIndex = 189
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Personne introduisant la demande"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(299, 124)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 17)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Date de naissance"
        '
        'TbDmdrTel
        '
        Me.TbDmdrTel.Location = New System.Drawing.Point(93, 121)
        Me.TbDmdrTel.Name = "TbDmdrTel"
        Me.TbDmdrTel.Size = New System.Drawing.Size(142, 22)
        Me.TbDmdrTel.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 17)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Nom"
        '
        'TbDmdrNom
        '
        Me.TbDmdrNom.Location = New System.Drawing.Point(93, 56)
        Me.TbDmdrNom.Name = "TbDmdrNom"
        Me.TbDmdrNom.Size = New System.Drawing.Size(142, 22)
        Me.TbDmdrNom.TabIndex = 0
        '
        'TbDmdrAdresse
        '
        Me.TbDmdrAdresse.Location = New System.Drawing.Point(93, 88)
        Me.TbDmdrAdresse.Name = "TbDmdrAdresse"
        Me.TbDmdrAdresse.Size = New System.Drawing.Size(171, 22)
        Me.TbDmdrAdresse.TabIndex = 6
        '
        'TbDmdrPrenom
        '
        Me.TbDmdrPrenom.Location = New System.Drawing.Point(366, 56)
        Me.TbDmdrPrenom.Name = "TbDmdrPrenom"
        Me.TbDmdrPrenom.Size = New System.Drawing.Size(142, 22)
        Me.TbDmdrPrenom.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 17)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Adresse"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(299, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 17)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Prénom"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 121)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 17)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Téléphone"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TbRem)
        Me.GroupBox2.Location = New System.Drawing.Point(651, 485)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(286, 150)
        Me.GroupBox2.TabIndex = 190
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Remarque éventuelle"
        '
        'TbRem
        '
        Me.TbRem.Location = New System.Drawing.Point(6, 21)
        Me.TbRem.Multiline = True
        Me.TbRem.Name = "TbRem"
        Me.TbRem.Size = New System.Drawing.Size(274, 123)
        Me.TbRem.TabIndex = 0
        '
        'BtInfosCsnr
        '
        Me.BtInfosCsnr.Location = New System.Drawing.Point(302, -1)
        Me.BtInfosCsnr.Name = "BtInfosCsnr"
        Me.BtInfosCsnr.Size = New System.Drawing.Size(214, 51)
        Me.BtInfosCsnr.TabIndex = 11
        Me.BtInfosCsnr.Text = "BtInfosCsnr"
        Me.BtInfosCsnr.UseVisualStyleBackColor = True
        '
        'TbDmdrDateNaiss
        '
        Me.TbDmdrDateNaiss.DateValue = Nothing
        Me.TbDmdrDateNaiss.Location = New System.Drawing.Point(445, 124)
        Me.TbDmdrDateNaiss.Mask = "00/00/0000"
        Me.TbDmdrDateNaiss.Name = "TbDmdrDateNaiss"
        Me.TbDmdrDateNaiss.Size = New System.Drawing.Size(100, 22)
        Me.TbDmdrDateNaiss.TabIndex = 10
        Me.TbDmdrDateNaiss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CtrlVilleDmdr
        '
        Me.CtrlVilleDmdr.Location = New System.Drawing.Point(307, 87)
        Me.CtrlVilleDmdr.LocVilleId = -1
        Me.CtrlVilleDmdr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CtrlVilleDmdr.Name = "CtrlVilleDmdr"
        Me.CtrlVilleDmdr.Size = New System.Drawing.Size(316, 25)
        Me.CtrlVilleDmdr.TabIndex = 7
        '
        'TbAnneesAjout
        '
        Me.TbAnneesAjout.Location = New System.Drawing.Point(262, 78)
        Me.TbAnneesAjout.Name = "TbAnneesAjout"
        Me.TbAnneesAjout.Size = New System.Drawing.Size(43, 22)
        Me.TbAnneesAjout.TabIndex = 6
        Me.TbAnneesAjout.Text = "5"
        Me.TbAnneesAjout.Value = 5
        '
        'TbNouvDateFin
        '
        Me.TbNouvDateFin.DateValue = Nothing
        Me.TbNouvDateFin.Location = New System.Drawing.Point(300, 32)
        Me.TbNouvDateFin.Mask = "00/00/0000"
        Me.TbNouvDateFin.Name = "TbNouvDateFin"
        Me.TbNouvDateFin.Size = New System.Drawing.Size(95, 22)
        Me.TbNouvDateFin.TabIndex = 5
        Me.TbNouvDateFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DgvCsns
        '
        Me.DgvCsns.AllowUserToAddRows = False
        Me.DgvCsns.AllowUserToDeleteRows = False
        Me.DgvCsns.AllowUserToOrderColumns = True
        Me.DgvCsns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvCsns.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvCsns.BackgroundColor = System.Drawing.Color.White
        Me.DgvCsns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCsns.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column4, Me.Column3, Me.DgvCsnsColOccupants})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvCsns.DefaultCellStyle = DataGridViewCellStyle1
        Me.DgvCsns.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.ErProv.SetIconPadding(Me.DgvCsns, -30)
        Me.DgvCsns.Location = New System.Drawing.Point(12, 44)
        Me.DgvCsns.MultiSelect = False
        Me.DgvCsns.Name = "DgvCsns"
        Me.DgvCsns.ReadOnly = True
        Me.DgvCsns.RowHeadersVisible = False
        Me.DgvCsns.RowTemplate.Height = 24
        Me.DgvCsns.SelectedRow = Nothing
        Me.DgvCsns.SelectedRowIndex = -1
        Me.DgvCsns.SelectedValue = -1
        Me.DgvCsns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCsns.Size = New System.Drawing.Size(938, 254)
        Me.DgvCsns.TabIndex = 174
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "empl_reference"
        Me.Column1.FillWeight = 50.0!
        Me.Column1.HeaderText = "Emplacement"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "csnr_nom"
        Me.Column4.HeaderText = "Concessionnaire"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "con_date_fin"
        Me.Column3.FillWeight = 60.0!
        Me.Column3.HeaderText = "Fin"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'DgvCsnsColOccupants
        '
        Me.DgvCsnsColOccupants.DataPropertyName = "noms_defunts"
        Me.DgvCsnsColOccupants.FillWeight = 130.0!
        Me.DgvCsnsColOccupants.HeaderText = "Occupants"
        Me.DgvCsnsColOccupants.Name = "DgvCsnsColOccupants"
        Me.DgvCsnsColOccupants.ReadOnly = True
        '
        'FormProlong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.cimetiere.My.Resources.Resources.fondformulaire
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(962, 853)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.BtViderFiltre)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TbRecherche)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GbO)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GbN)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.DgvCsns)
        Me.Controls.Add(Me.BtTerminer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormProlong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prolonger une concession"
        Me.Panel3.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.GbN.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GbO.ResumeLayout(False)
        Me.GbO.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DgvCsns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtTerminer As Button
    Friend WithEvents DgvCsns As DataGridViewConcessions
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents CbEnregPdfCsn As CheckBox
    Friend WithEvents GbN As GroupBox
    Friend WithEvents LbOccupants As ListBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TbCom As TextBox
    Friend WithEvents GbO As GroupBox
    Friend WithEvents LbBenefs As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TbRecherche As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtViderFiltre As Button
    Friend WithEvents BtAjouterAnnees As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TbAnneesAjout As TextBoxInt
    Friend WithEvents TbNouvDateFin As TextBoxDate
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TbDateDebut As TextBox
    Friend WithEvents TbDateFinAct As TextBox
    Friend WithEvents ErProv As ErrorProvider
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TbDmdrTel As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CtrlVilleDmdr As CtrlLocVillePays
    Friend WithEvents TbDmdrNom As TextBox
    Friend WithEvents TbDmdrAdresse As TextBox
    Friend WithEvents TbDmdrPrenom As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TbDmdrDateNaiss As TextBoxDate
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents DgvCsnsColOccupants As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TbRem As TextBox
    Friend WithEvents BtInfosCsnr As Button
End Class
