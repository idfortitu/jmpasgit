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
        Me.TbAnneesAjout = New cimetiere.TextBoxInt()
        Me.TbNouvDateFin = New cimetiere.TextBoxDate()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtViderFiltre = New System.Windows.Forms.Button()
        Me.ErProv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DgvCsns = New cimetiere.DataGridViewConcessions()
        Me.ColConId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvCsnsColOccupants = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtInfosCsnr = New System.Windows.Forms.Button()
        Me.TbDmdrDateNaiss = New cimetiere.TextBoxDate()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TbDmdrTel = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CtrlVilleDmdr = New cimetiere.CtrlLocVillePays()
        Me.TbDmdrNom = New System.Windows.Forms.TextBox()
        Me.TbDmdrAdresse = New System.Windows.Forms.TextBox()
        Me.TbDmdrPrenom = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TbRem = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.GbN.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GbO.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ErProv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvCsns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtTerminer
        '
        Me.BtTerminer.BackColor = System.Drawing.Color.SeaGreen
        Me.BtTerminer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtTerminer.ForeColor = System.Drawing.Color.Transparent
        Me.BtTerminer.Location = New System.Drawing.Point(605, 625)
        Me.BtTerminer.Name = "BtTerminer"
        Me.BtTerminer.Size = New System.Drawing.Size(116, 50)
        Me.BtTerminer.TabIndex = 135
        Me.BtTerminer.Text = "Prolonger"
        Me.BtTerminer.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Location = New System.Drawing.Point(380, 619)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(207, 62)
        Me.Panel3.TabIndex = 181
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.Window
        Me.Panel7.Controls.Add(Me.CbEnregPdfCsn)
        Me.Panel7.Location = New System.Drawing.Point(5, 6)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(199, 50)
        Me.Panel7.TabIndex = 0
        '
        'CbEnregPdfCsn
        '
        Me.CbEnregPdfCsn.AutoSize = True
        Me.CbEnregPdfCsn.Checked = True
        Me.CbEnregPdfCsn.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbEnregPdfCsn.Location = New System.Drawing.Point(4, 5)
        Me.CbEnregPdfCsn.Name = "CbEnregPdfCsn"
        Me.CbEnregPdfCsn.Size = New System.Drawing.Size(142, 17)
        Me.CbEnregPdfCsn.TabIndex = 8
        Me.CbEnregPdfCsn.Text = "Enregistrer le fichier PDF"
        Me.CbEnregPdfCsn.UseVisualStyleBackColor = True
        '
        'GbN
        '
        Me.GbN.BackColor = System.Drawing.Color.Transparent
        Me.GbN.Controls.Add(Me.LbOccupants)
        Me.GbN.Location = New System.Drawing.Point(14, 314)
        Me.GbN.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GbN.Name = "GbN"
        Me.GbN.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GbN.Size = New System.Drawing.Size(256, 115)
        Me.GbN.TabIndex = 182
        Me.GbN.TabStop = False
        Me.GbN.Text = "Défunts actuels"
        '
        'LbOccupants
        '
        Me.LbOccupants.FormattingEnabled = True
        Me.LbOccupants.IntegralHeight = False
        Me.LbOccupants.Location = New System.Drawing.Point(4, 17)
        Me.LbOccupants.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LbOccupants.Name = "LbOccupants"
        Me.LbOccupants.Size = New System.Drawing.Size(248, 94)
        Me.LbOccupants.TabIndex = 183
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.LbBenefs)
        Me.GroupBox3.Location = New System.Drawing.Point(275, 314)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(236, 115)
        Me.GroupBox3.TabIndex = 180
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Bénéficiaires"
        '
        'LbBenefs
        '
        Me.LbBenefs.FormattingEnabled = True
        Me.LbBenefs.IntegralHeight = False
        Me.LbBenefs.Location = New System.Drawing.Point(4, 17)
        Me.LbBenefs.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LbBenefs.Name = "LbBenefs"
        Me.LbBenefs.Size = New System.Drawing.Size(225, 94)
        Me.LbBenefs.TabIndex = 0
        '
        'TbCom
        '
        Me.TbCom.Location = New System.Drawing.Point(4, 17)
        Me.TbCom.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbCom.Multiline = True
        Me.TbCom.Name = "TbCom"
        Me.TbCom.ReadOnly = True
        Me.TbCom.Size = New System.Drawing.Size(193, 90)
        Me.TbCom.TabIndex = 183
        '
        'GbO
        '
        Me.GbO.BackColor = System.Drawing.Color.Transparent
        Me.GbO.Controls.Add(Me.TbCom)
        Me.GbO.Location = New System.Drawing.Point(516, 314)
        Me.GbO.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GbO.Name = "GbO"
        Me.GbO.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GbO.Size = New System.Drawing.Size(202, 114)
        Me.GbO.TabIndex = 184
        Me.GbO.TabStop = False
        Me.GbO.Text = "Commentaire"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(108, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 185
        Me.Label1.Text = "Filtre :"
        '
        'TbRecherche
        '
        Me.TbRecherche.Location = New System.Drawing.Point(110, 35)
        Me.TbRecherche.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbRecherche.Name = "TbRecherche"
        Me.TbRecherche.Size = New System.Drawing.Size(111, 20)
        Me.TbRecherche.TabIndex = 186
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 592)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(348, 113)
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
        Me.Panel1.Location = New System.Drawing.Point(4, 16)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(340, 91)
        Me.Panel1.TabIndex = 0
        '
        'TbDateFinAct
        '
        Me.TbDateFinAct.Location = New System.Drawing.Point(106, 26)
        Me.TbDateFinAct.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbDateFinAct.Name = "TbDateFinAct"
        Me.TbDateFinAct.ReadOnly = True
        Me.TbDateFinAct.Size = New System.Drawing.Size(78, 20)
        Me.TbDateFinAct.TabIndex = 12
        '
        'TbDateDebut
        '
        Me.TbDateDebut.Location = New System.Drawing.Point(14, 26)
        Me.TbDateDebut.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbDateDebut.Name = "TbDateDebut"
        Me.TbDateDebut.ReadOnly = True
        Me.TbDateDebut.Size = New System.Drawing.Size(72, 20)
        Me.TbDateDebut.TabIndex = 11
        '
        'BtAjouterAnnees
        '
        Me.BtAjouterAnnees.Location = New System.Drawing.Point(136, 62)
        Me.BtAjouterAnnees.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtAjouterAnnees.Name = "BtAjouterAnnees"
        Me.BtAjouterAnnees.Size = New System.Drawing.Size(56, 20)
        Me.BtAjouterAnnees.TabIndex = 8
        Me.BtAjouterAnnees.Text = "Ajouter"
        Me.BtAjouterAnnees.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(231, 65)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "ans"
        '
        'TbAnneesAjout
        '
        Me.TbAnneesAjout.Location = New System.Drawing.Point(196, 63)
        Me.TbAnneesAjout.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbAnneesAjout.Name = "TbAnneesAjout"
        Me.TbAnneesAjout.Size = New System.Drawing.Size(33, 20)
        Me.TbAnneesAjout.TabIndex = 6
        Me.TbAnneesAjout.Text = "5"
        Me.TbAnneesAjout.Value = 5
        '
        'TbNouvDateFin
        '
        Me.TbNouvDateFin.DateValue = Nothing
        Me.TbNouvDateFin.Location = New System.Drawing.Point(225, 26)
        Me.TbNouvDateFin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbNouvDateFin.Mask = "00/00/0000"
        Me.TbNouvDateFin.Name = "TbNouvDateFin"
        Me.TbNouvDateFin.Size = New System.Drawing.Size(72, 20)
        Me.TbNouvDateFin.TabIndex = 5
        Me.TbNouvDateFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(220, 6)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nouvelle date de fin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(103, 6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Date de fin actuelle"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 6)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Date de début"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label6.Location = New System.Drawing.Point(118, 40)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 26)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "↘"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label7.Location = New System.Drawing.Point(249, 40)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 26)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "↗"
        '
        'BtViderFiltre
        '
        Me.BtViderFiltre.Image = Global.cimetiere.My.Resources.Resources.Cancel_16x
        Me.BtViderFiltre.Location = New System.Drawing.Point(225, 32)
        Me.BtViderFiltre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtViderFiltre.Name = "BtViderFiltre"
        Me.BtViderFiltre.Size = New System.Drawing.Size(24, 24)
        Me.BtViderFiltre.TabIndex = 188
        Me.BtViderFiltre.UseVisualStyleBackColor = True
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
        Me.DgvCsns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvCsns.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvCsns.BackgroundColor = System.Drawing.Color.White
        Me.DgvCsns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCsns.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColConId, Me.Column1, Me.Column4, Me.Column3, Me.DgvCsnsColOccupants})
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
        Me.DgvCsns.Location = New System.Drawing.Point(14, 94)
        Me.DgvCsns.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DgvCsns.MultiSelect = False
        Me.DgvCsns.Name = "DgvCsns"
        Me.DgvCsns.ReadOnly = True
        Me.DgvCsns.RowHeadersVisible = False
        Me.DgvCsns.RowTemplate.Height = 24
        Me.DgvCsns.SelectedRow = Nothing
        Me.DgvCsns.SelectedRowIndex = -1
        Me.DgvCsns.SelectedValue = -1
        Me.DgvCsns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCsns.Size = New System.Drawing.Size(704, 206)
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
        Me.GroupBox4.Location = New System.Drawing.Point(16, 441)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(485, 124)
        Me.GroupBox4.TabIndex = 189
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Personne introduisant la demande"
        '
        'BtInfosCsnr
        '
        Me.BtInfosCsnr.Location = New System.Drawing.Point(226, -1)
        Me.BtInfosCsnr.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtInfosCsnr.Name = "BtInfosCsnr"
        Me.BtInfosCsnr.Size = New System.Drawing.Size(160, 41)
        Me.BtInfosCsnr.TabIndex = 11
        Me.BtInfosCsnr.Text = "BtInfosCsnr"
        Me.BtInfosCsnr.UseVisualStyleBackColor = True
        '
        'TbDmdrDateNaiss
        '
        Me.TbDmdrDateNaiss.DateValue = Nothing
        Me.TbDmdrDateNaiss.Location = New System.Drawing.Point(334, 101)
        Me.TbDmdrDateNaiss.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbDmdrDateNaiss.Mask = "00/00/0000"
        Me.TbDmdrDateNaiss.Name = "TbDmdrDateNaiss"
        Me.TbDmdrDateNaiss.Size = New System.Drawing.Size(76, 20)
        Me.TbDmdrDateNaiss.TabIndex = 10
        Me.TbDmdrDateNaiss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(224, 101)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Date de naissance"
        '
        'TbDmdrTel
        '
        Me.TbDmdrTel.Location = New System.Drawing.Point(70, 98)
        Me.TbDmdrTel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbDmdrTel.Name = "TbDmdrTel"
        Me.TbDmdrTel.Size = New System.Drawing.Size(108, 20)
        Me.TbDmdrTel.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 46)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Nom"
        '
        'CtrlVilleDmdr
        '
        Me.CtrlVilleDmdr.LectureSeule = False
        Me.CtrlVilleDmdr.Location = New System.Drawing.Point(230, 71)
        Me.CtrlVilleDmdr.LocVilleId = -1
        Me.CtrlVilleDmdr.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CtrlVilleDmdr.Name = "CtrlVilleDmdr"
        Me.CtrlVilleDmdr.osef = Nothing
        Me.CtrlVilleDmdr.Size = New System.Drawing.Size(237, 20)
        Me.CtrlVilleDmdr.TabIndex = 7
        '
        'TbDmdrNom
        '
        Me.TbDmdrNom.Location = New System.Drawing.Point(70, 46)
        Me.TbDmdrNom.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbDmdrNom.Name = "TbDmdrNom"
        Me.TbDmdrNom.Size = New System.Drawing.Size(108, 20)
        Me.TbDmdrNom.TabIndex = 0
        '
        'TbDmdrAdresse
        '
        Me.TbDmdrAdresse.Location = New System.Drawing.Point(70, 72)
        Me.TbDmdrAdresse.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbDmdrAdresse.Name = "TbDmdrAdresse"
        Me.TbDmdrAdresse.Size = New System.Drawing.Size(129, 20)
        Me.TbDmdrAdresse.TabIndex = 6
        '
        'TbDmdrPrenom
        '
        Me.TbDmdrPrenom.Location = New System.Drawing.Point(274, 46)
        Me.TbDmdrPrenom.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbDmdrPrenom.Name = "TbDmdrPrenom"
        Me.TbDmdrPrenom.Size = New System.Drawing.Size(108, 20)
        Me.TbDmdrPrenom.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 72)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Adresse"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(224, 46)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Prénom"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 98)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Téléphone"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TbRem)
        Me.GroupBox2.Location = New System.Drawing.Point(505, 441)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(214, 124)
        Me.GroupBox2.TabIndex = 190
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Remarque éventuelle sur la prolongation"
        '
        'TbRem
        '
        Me.TbRem.Location = New System.Drawing.Point(4, 17)
        Me.TbRem.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbRem.Multiline = True
        Me.TbRem.Name = "TbRem"
        Me.TbRem.Size = New System.Drawing.Size(206, 102)
        Me.TbRem.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-6, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 192
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel2.Location = New System.Drawing.Point(8, 86)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(719, 221)
        Me.Panel2.TabIndex = 193
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel4.Location = New System.Drawing.Point(8, 434)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(719, 145)
        Me.Panel4.TabIndex = 194
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel5.Location = New System.Drawing.Point(8, 583)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(719, 135)
        Me.Panel5.TabIndex = 195
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel6.Location = New System.Drawing.Point(8, 311)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(719, 119)
        Me.Panel6.TabIndex = 196
        '
        'FormProlong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.cimetiere.My.Resources.Resources.fondformulaire
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(729, 728)
        Me.Controls.Add(Me.PictureBox1)
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
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        CType(Me.DgvCsns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TbRem As TextBox
    Friend WithEvents BtInfosCsnr As Button
    Friend WithEvents ColConId As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents DgvCsnsColOccupants As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
End Class
