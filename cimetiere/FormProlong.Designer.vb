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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProlong))
        Me.BtTerminer = New System.Windows.Forms.Button()
        Me.ErProv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DgvCsns = New cimetiere.DataGridViewConcessions()
        Me.ColConId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvCsnsColOccupants = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanBordure4 = New cimetiere.PanBordure()
        Me.TbRem = New System.Windows.Forms.TextBox()
        Me.PanBordure3 = New cimetiere.PanBordure()
        Me.TbDateFinAct = New System.Windows.Forms.TextBox()
        Me.TbDateDebut = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtAjouterAnnees = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbAnneesAjout = New cimetiere.TextBoxInt()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbNouvDateFin = New cimetiere.TextBoxDate()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanBordure2 = New cimetiere.PanBordure()
        Me.BtInfosCsnr = New System.Windows.Forms.Button()
        Me.TbDmdrDateNaiss = New cimetiere.TextBoxDate()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TbDmdrTel = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CtrlVilleDmdr = New cimetiere.CtrlLocVillePays()
        Me.TbDmdrPrenom = New System.Windows.Forms.TextBox()
        Me.TbDmdrNom = New System.Windows.Forms.TextBox()
        Me.TbDmdrAdresse = New System.Windows.Forms.TextBox()
        Me.PanBordure1 = New cimetiere.PanBordure()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtViderFiltre = New System.Windows.Forms.Button()
        Me.GbN = New System.Windows.Forms.GroupBox()
        Me.LbOccupants = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LbBenefs = New System.Windows.Forms.ListBox()
        Me.TbRecherche = New System.Windows.Forms.TextBox()
        Me.GbO = New System.Windows.Forms.GroupBox()
        Me.TbCom = New System.Windows.Forms.TextBox()
        Me.CbEnregPdfCsn = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New cimetiere.PanBordure()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.ErProv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvCsns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanBordure4.SuspendLayout()
        Me.PanBordure3.SuspendLayout()
        Me.PanBordure2.SuspendLayout()
        Me.PanBordure1.SuspendLayout()
        Me.GbN.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GbO.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtTerminer
        '
        Me.BtTerminer.BackColor = System.Drawing.Color.SeaGreen
        Me.BtTerminer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtTerminer.ForeColor = System.Drawing.Color.Transparent
        Me.BtTerminer.Location = New System.Drawing.Point(783, 790)
        Me.BtTerminer.Margin = New System.Windows.Forms.Padding(4)
        Me.BtTerminer.Name = "BtTerminer"
        Me.BtTerminer.Size = New System.Drawing.Size(154, 62)
        Me.BtTerminer.TabIndex = 135
        Me.BtTerminer.Text = "Prolonger"
        Me.BtTerminer.UseVisualStyleBackColor = False
        '
        'ErProv
        '
        Me.ErProv.ContainerControl = Me
        '
        'DgvCsns
        '
        Me.DgvCsns.AllowUserToAddRows = False
        Me.DgvCsns.AllowUserToDeleteRows = False
        Me.DgvCsns.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvCsns.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvCsns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvCsns.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvCsns.BackgroundColor = System.Drawing.Color.White
        Me.DgvCsns.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvCsns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCsns.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColConId, Me.Column1, Me.Column4, Me.Column3, Me.DgvCsnsColOccupants})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvCsns.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvCsns.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.ErProv.SetIconPadding(Me.DgvCsns, -30)
        Me.DgvCsns.Location = New System.Drawing.Point(16, 71)
        Me.DgvCsns.MultiSelect = False
        Me.DgvCsns.Name = "DgvCsns"
        Me.DgvCsns.ReadOnly = True
        Me.DgvCsns.RowHeadersVisible = False
        Me.DgvCsns.RowTemplate.Height = 24
        Me.DgvCsns.SelectedRow = Nothing
        Me.DgvCsns.SelectedRowIndex = -1
        Me.DgvCsns.SelectedValue = -1
        Me.DgvCsns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCsns.Size = New System.Drawing.Size(912, 239)
        Me.DgvCsns.TabIndex = 174
        '
        'ColConId
        '
        Me.ColConId.DataPropertyName = "con_id"
        Me.ColConId.HeaderText = "id csn"
        Me.ColConId.Name = "ColConId"
        Me.ColConId.ReadOnly = True
        Me.ColConId.Visible = False
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
        'PanBordure4
        '
        Me.PanBordure4.BackColor = System.Drawing.SystemColors.Window
        Me.PanBordure4.Controls.Add(Me.TbRem)
        Me.PanBordure4.CouleurBordure = System.Drawing.Color.SeaGreen
        Me.PanBordure4.EpaisseurBordure = 7
        Me.PanBordure4.Location = New System.Drawing.Point(655, 582)
        Me.PanBordure4.Name = "PanBordure4"
        Me.PanBordure4.Size = New System.Drawing.Size(295, 195)
        Me.PanBordure4.TabIndex = 193
        Me.PanBordure4.Texte = "Remarque sur la prolongation"
        '
        'TbRem
        '
        Me.TbRem.Location = New System.Drawing.Point(19, 34)
        Me.TbRem.Multiline = True
        Me.TbRem.Name = "TbRem"
        Me.TbRem.Size = New System.Drawing.Size(257, 145)
        Me.TbRem.TabIndex = 0
        '
        'PanBordure3
        '
        Me.PanBordure3.BackColor = System.Drawing.SystemColors.Window
        Me.PanBordure3.Controls.Add(Me.TbDateFinAct)
        Me.PanBordure3.Controls.Add(Me.TbDateDebut)
        Me.PanBordure3.Controls.Add(Me.Label2)
        Me.PanBordure3.Controls.Add(Me.BtAjouterAnnees)
        Me.PanBordure3.Controls.Add(Me.Label7)
        Me.PanBordure3.Controls.Add(Me.Label5)
        Me.PanBordure3.Controls.Add(Me.Label6)
        Me.PanBordure3.Controls.Add(Me.TbAnneesAjout)
        Me.PanBordure3.Controls.Add(Me.Label3)
        Me.PanBordure3.Controls.Add(Me.TbNouvDateFin)
        Me.PanBordure3.Controls.Add(Me.Label4)
        Me.PanBordure3.CouleurBordure = System.Drawing.Color.SeaGreen
        Me.PanBordure3.EpaisseurBordure = 7
        Me.PanBordure3.Location = New System.Drawing.Point(5, 783)
        Me.PanBordure3.Name = "PanBordure3"
        Me.PanBordure3.Size = New System.Drawing.Size(495, 142)
        Me.PanBordure3.TabIndex = 193
        Me.PanBordure3.Texte = "Durée"
        '
        'TbDateFinAct
        '
        Me.TbDateFinAct.Location = New System.Drawing.Point(163, 54)
        Me.TbDateFinAct.Name = "TbDateFinAct"
        Me.TbDateFinAct.ReadOnly = True
        Me.TbDateFinAct.Size = New System.Drawing.Size(103, 22)
        Me.TbDateFinAct.TabIndex = 12
        '
        'TbDateDebut
        '
        Me.TbDateDebut.Location = New System.Drawing.Point(41, 54)
        Me.TbDateDebut.Name = "TbDateDebut"
        Me.TbDateDebut.ReadOnly = True
        Me.TbDateDebut.Size = New System.Drawing.Size(95, 22)
        Me.TbDateDebut.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Date de début"
        '
        'BtAjouterAnnees
        '
        Me.BtAjouterAnnees.Location = New System.Drawing.Point(203, 98)
        Me.BtAjouterAnnees.Name = "BtAjouterAnnees"
        Me.BtAjouterAnnees.Size = New System.Drawing.Size(75, 25)
        Me.BtAjouterAnnees.TabIndex = 8
        Me.BtAjouterAnnees.Text = "Ajouter"
        Me.BtAjouterAnnees.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label7.Location = New System.Drawing.Point(358, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 27)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "↗"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(330, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "ans"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label6.Location = New System.Drawing.Point(179, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 31)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "↘"
        '
        'TbAnneesAjout
        '
        Me.TbAnneesAjout.Location = New System.Drawing.Point(284, 100)
        Me.TbAnneesAjout.Name = "TbAnneesAjout"
        Me.TbAnneesAjout.Size = New System.Drawing.Size(43, 22)
        Me.TbAnneesAjout.TabIndex = 6
        Me.TbAnneesAjout.Text = "5"
        Me.TbAnneesAjout.Value = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(159, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Date de fin actuelle"
        '
        'TbNouvDateFin
        '
        Me.TbNouvDateFin.DateValue = Nothing
        Me.TbNouvDateFin.Location = New System.Drawing.Point(322, 54)
        Me.TbNouvDateFin.Mask = "00/00/0000"
        Me.TbNouvDateFin.Name = "TbNouvDateFin"
        Me.TbNouvDateFin.Size = New System.Drawing.Size(95, 22)
        Me.TbNouvDateFin.TabIndex = 5
        Me.TbNouvDateFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(316, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nouvelle date de fin"
        '
        'PanBordure2
        '
        Me.PanBordure2.BackColor = System.Drawing.SystemColors.Window
        Me.PanBordure2.Controls.Add(Me.BtInfosCsnr)
        Me.PanBordure2.Controls.Add(Me.TbDmdrDateNaiss)
        Me.PanBordure2.Controls.Add(Me.Label12)
        Me.PanBordure2.Controls.Add(Me.Label11)
        Me.PanBordure2.Controls.Add(Me.TbDmdrTel)
        Me.PanBordure2.Controls.Add(Me.Label9)
        Me.PanBordure2.Controls.Add(Me.Label8)
        Me.PanBordure2.Controls.Add(Me.Label10)
        Me.PanBordure2.Controls.Add(Me.CtrlVilleDmdr)
        Me.PanBordure2.Controls.Add(Me.TbDmdrPrenom)
        Me.PanBordure2.Controls.Add(Me.TbDmdrNom)
        Me.PanBordure2.Controls.Add(Me.TbDmdrAdresse)
        Me.PanBordure2.CouleurBordure = System.Drawing.Color.SeaGreen
        Me.PanBordure2.EpaisseurBordure = 7
        Me.PanBordure2.Location = New System.Drawing.Point(5, 582)
        Me.PanBordure2.Name = "PanBordure2"
        Me.PanBordure2.Size = New System.Drawing.Size(644, 195)
        Me.PanBordure2.TabIndex = 192
        Me.PanBordure2.Texte = "Personne introduisant la demande"
        '
        'BtInfosCsnr
        '
        Me.BtInfosCsnr.Location = New System.Drawing.Point(307, 29)
        Me.BtInfosCsnr.Name = "BtInfosCsnr"
        Me.BtInfosCsnr.Size = New System.Drawing.Size(214, 51)
        Me.BtInfosCsnr.TabIndex = 11
        Me.BtInfosCsnr.Text = "BtInfosCsnr"
        Me.BtInfosCsnr.UseVisualStyleBackColor = True
        '
        'TbDmdrDateNaiss
        '
        Me.TbDmdrDateNaiss.DateValue = Nothing
        Me.TbDmdrDateNaiss.Location = New System.Drawing.Point(450, 154)
        Me.TbDmdrDateNaiss.Mask = "00/00/0000"
        Me.TbDmdrDateNaiss.Name = "TbDmdrDateNaiss"
        Me.TbDmdrDateNaiss.Size = New System.Drawing.Size(100, 22)
        Me.TbDmdrDateNaiss.TabIndex = 10
        Me.TbDmdrDateNaiss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(304, 154)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 17)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Date de naissance"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 151)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 17)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Téléphone"
        '
        'TbDmdrTel
        '
        Me.TbDmdrTel.Location = New System.Drawing.Point(98, 151)
        Me.TbDmdrTel.Name = "TbDmdrTel"
        Me.TbDmdrTel.Size = New System.Drawing.Size(142, 22)
        Me.TbDmdrTel.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(304, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 17)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Prénom"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 17)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Nom"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 118)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 17)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Adresse"
        '
        'CtrlVilleDmdr
        '
        Me.CtrlVilleDmdr.LectureSeule = False
        Me.CtrlVilleDmdr.Location = New System.Drawing.Point(312, 117)
        Me.CtrlVilleDmdr.LocVilleId = -1
        Me.CtrlVilleDmdr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CtrlVilleDmdr.Name = "CtrlVilleDmdr"
        Me.CtrlVilleDmdr.osef = Nothing
        Me.CtrlVilleDmdr.Size = New System.Drawing.Size(316, 25)
        Me.CtrlVilleDmdr.TabIndex = 7
        '
        'TbDmdrPrenom
        '
        Me.TbDmdrPrenom.Location = New System.Drawing.Point(371, 86)
        Me.TbDmdrPrenom.Name = "TbDmdrPrenom"
        Me.TbDmdrPrenom.Size = New System.Drawing.Size(142, 22)
        Me.TbDmdrPrenom.TabIndex = 2
        '
        'TbDmdrNom
        '
        Me.TbDmdrNom.Location = New System.Drawing.Point(98, 86)
        Me.TbDmdrNom.Name = "TbDmdrNom"
        Me.TbDmdrNom.Size = New System.Drawing.Size(142, 22)
        Me.TbDmdrNom.TabIndex = 0
        '
        'TbDmdrAdresse
        '
        Me.TbDmdrAdresse.Location = New System.Drawing.Point(98, 118)
        Me.TbDmdrAdresse.Name = "TbDmdrAdresse"
        Me.TbDmdrAdresse.Size = New System.Drawing.Size(171, 22)
        Me.TbDmdrAdresse.TabIndex = 6
        '
        'PanBordure1
        '
        Me.PanBordure1.BackColor = System.Drawing.SystemColors.Window
        Me.PanBordure1.Controls.Add(Me.Label1)
        Me.PanBordure1.Controls.Add(Me.DgvCsns)
        Me.PanBordure1.Controls.Add(Me.BtViderFiltre)
        Me.PanBordure1.Controls.Add(Me.GbN)
        Me.PanBordure1.Controls.Add(Me.GroupBox3)
        Me.PanBordure1.Controls.Add(Me.TbRecherche)
        Me.PanBordure1.Controls.Add(Me.GbO)
        Me.PanBordure1.CouleurBordure = System.Drawing.Color.SeaGreen
        Me.PanBordure1.EpaisseurBordure = 7
        Me.PanBordure1.Location = New System.Drawing.Point(5, 115)
        Me.PanBordure1.Name = "PanBordure1"
        Me.PanBordure1.Size = New System.Drawing.Size(945, 464)
        Me.PanBordure1.TabIndex = 191
        Me.PanBordure1.Texte = "Choisir la concession"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(21, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 17)
        Me.Label1.TabIndex = 185
        Me.Label1.Text = "Filtre"
        '
        'BtViderFiltre
        '
        Me.BtViderFiltre.Image = Global.cimetiere.My.Resources.Resources.Cancel_16x
        Me.BtViderFiltre.Location = New System.Drawing.Point(227, 36)
        Me.BtViderFiltre.Name = "BtViderFiltre"
        Me.BtViderFiltre.Size = New System.Drawing.Size(32, 29)
        Me.BtViderFiltre.TabIndex = 188
        Me.BtViderFiltre.UseVisualStyleBackColor = True
        '
        'GbN
        '
        Me.GbN.BackColor = System.Drawing.Color.Transparent
        Me.GbN.Controls.Add(Me.LbOccupants)
        Me.GbN.Location = New System.Drawing.Point(18, 313)
        Me.GbN.Name = "GbN"
        Me.GbN.Size = New System.Drawing.Size(342, 134)
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
        Me.LbOccupants.Size = New System.Drawing.Size(330, 106)
        Me.LbOccupants.TabIndex = 183
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.LbBenefs)
        Me.GroupBox3.Location = New System.Drawing.Point(366, 313)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(315, 134)
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
        Me.LbBenefs.Size = New System.Drawing.Size(299, 107)
        Me.LbBenefs.TabIndex = 0
        '
        'TbRecherche
        '
        Me.TbRecherche.Location = New System.Drawing.Point(74, 39)
        Me.TbRecherche.Name = "TbRecherche"
        Me.TbRecherche.Size = New System.Drawing.Size(147, 22)
        Me.TbRecherche.TabIndex = 186
        '
        'GbO
        '
        Me.GbO.BackColor = System.Drawing.Color.Transparent
        Me.GbO.Controls.Add(Me.TbCom)
        Me.GbO.Location = New System.Drawing.Point(687, 314)
        Me.GbO.Name = "GbO"
        Me.GbO.Size = New System.Drawing.Size(241, 133)
        Me.GbO.TabIndex = 184
        Me.GbO.TabStop = False
        Me.GbO.Text = "Commentaire"
        '
        'TbCom
        '
        Me.TbCom.Location = New System.Drawing.Point(6, 21)
        Me.TbCom.Multiline = True
        Me.TbCom.Name = "TbCom"
        Me.TbCom.ReadOnly = True
        Me.TbCom.Size = New System.Drawing.Size(232, 105)
        Me.TbCom.TabIndex = 183
        '
        'CbEnregPdfCsn
        '
        Me.CbEnregPdfCsn.AutoSize = True
        Me.CbEnregPdfCsn.Checked = True
        Me.CbEnregPdfCsn.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbEnregPdfCsn.Location = New System.Drawing.Point(20, 23)
        Me.CbEnregPdfCsn.Margin = New System.Windows.Forms.Padding(4)
        Me.CbEnregPdfCsn.Name = "CbEnregPdfCsn"
        Me.CbEnregPdfCsn.Size = New System.Drawing.Size(188, 21)
        Me.CbEnregPdfCsn.TabIndex = 8
        Me.CbEnregPdfCsn.Text = "Enregistrer le fichier PDF"
        Me.CbEnregPdfCsn.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Window
        Me.Panel3.Controls.Add(Me.CbEnregPdfCsn)
        Me.Panel3.CouleurBordure = System.Drawing.Color.SeaGreen
        Me.Panel3.EpaisseurBordure = 7
        Me.Panel3.Location = New System.Drawing.Point(503, 790)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(276, 76)
        Me.Panel3.TabIndex = 181
        Me.Panel3.Texte = Nothing
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(5, 13)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(148, 95)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 194
        Me.PictureBox2.TabStop = False
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(157, 9)
        Me.Label16.Margin = New System.Windows.Forms.Padding(0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(539, 99)
        Me.Label16.TabIndex = 195
        Me.Label16.Text = "Prolonger une concession"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormProlong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(962, 853)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.PanBordure4)
        Me.Controls.Add(Me.PanBordure3)
        Me.Controls.Add(Me.PanBordure2)
        Me.Controls.Add(Me.PanBordure1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.BtTerminer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormProlong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prolonger une concession"
        CType(Me.ErProv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvCsns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanBordure4.ResumeLayout(False)
        Me.PanBordure4.PerformLayout()
        Me.PanBordure3.ResumeLayout(False)
        Me.PanBordure3.PerformLayout()
        Me.PanBordure2.ResumeLayout(False)
        Me.PanBordure2.PerformLayout()
        Me.PanBordure1.ResumeLayout(False)
        Me.PanBordure1.PerformLayout()
        Me.GbN.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GbO.ResumeLayout(False)
        Me.GbO.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtTerminer As Button
    Friend WithEvents DgvCsns As DataGridViewConcessions
    Friend WithEvents GbN As GroupBox
    Friend WithEvents LbOccupants As ListBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TbCom As TextBox
    Friend WithEvents GbO As GroupBox
    Friend WithEvents LbBenefs As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TbRecherche As TextBox
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
    Friend WithEvents TbRem As TextBox
    Friend WithEvents BtInfosCsnr As Button
    Friend WithEvents ColConId As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents DgvCsnsColOccupants As DataGridViewTextBoxColumn
    Friend WithEvents PanBordure1 As PanBordure
    Friend WithEvents PanBordure4 As PanBordure
    Friend WithEvents PanBordure3 As PanBordure
    Friend WithEvents PanBordure2 As PanBordure
    Friend WithEvents Panel3 As PanBordure
    Friend WithEvents CbEnregPdfCsn As CheckBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label16 As Label
End Class
