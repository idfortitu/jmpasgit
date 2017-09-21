<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHome
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHome))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BtDéclarationDécès = New System.Windows.Forms.Button()
        Me.BtRéserverCon = New System.Windows.Forms.Button()
        Me.BtProlongation = New System.Windows.Forms.Button()
        Me.BtPlan = New System.Windows.Forms.Button()
        Me.BtConsulterDonnées = New System.Windows.Forms.Button()
        Me.PanNotifs = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvNotifsCsnsExp = New cimetiere.DataGridViewCustom()
        Me.DgvCsnsExpRefEmpl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvCsnsExpDateExp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvCsnsExpCsnrTel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvCsnsExpColInfos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvCsnsExpColBtDetails = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DgvNotifsCsnsAb = New cimetiere.DataGridViewCustom()
        Me.DgvCsnsAbColRefEmpl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvCsnsAbColNomCsnr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvCsnsAbColTelCsnr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvCsnsAbColBtDetails = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BtNotifsMasquer = New System.Windows.Forms.Button()
        Me.BtNotifsMontrer = New System.Windows.Forms.Button()
        Me.LabWelkom = New System.Windows.Forms.Label()
        Me.BtSignalAbCsn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelToutSaufNotifs = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.PanNotifs.SuspendLayout()
        CType(Me.DgvNotifsCsnsExp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvNotifsCsnsAb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelToutSaufNotifs.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.SeaGreen
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FlowLayoutPanel1.Controls.Add(Me.BtDéclarationDécès)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtRéserverCon)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtProlongation)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtPlan)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtConsulterDonnées)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(75, 144)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(867, 278)
        Me.FlowLayoutPanel1.TabIndex = 69
        '
        'BtDéclarationDécès
        '
        Me.BtDéclarationDécès.BackColor = System.Drawing.Color.SeaGreen
        Me.BtDéclarationDécès.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtDéclarationDécès.ForeColor = System.Drawing.Color.Transparent
        Me.BtDéclarationDécès.Location = New System.Drawing.Point(4, 4)
        Me.BtDéclarationDécès.Margin = New System.Windows.Forms.Padding(4)
        Me.BtDéclarationDécès.Name = "BtDéclarationDécès"
        Me.BtDéclarationDécès.Size = New System.Drawing.Size(279, 124)
        Me.BtDéclarationDécès.TabIndex = 0
        Me.BtDéclarationDécès.Text = "Déclaration de décès"
        Me.BtDéclarationDécès.UseVisualStyleBackColor = False
        '
        'BtRéserverCon
        '
        Me.BtRéserverCon.BackColor = System.Drawing.Color.SeaGreen
        Me.BtRéserverCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.BtRéserverCon.ForeColor = System.Drawing.Color.Transparent
        Me.BtRéserverCon.Location = New System.Drawing.Point(291, 4)
        Me.BtRéserverCon.Margin = New System.Windows.Forms.Padding(4)
        Me.BtRéserverCon.Name = "BtRéserverCon"
        Me.BtRéserverCon.Size = New System.Drawing.Size(279, 128)
        Me.BtRéserverCon.TabIndex = 1
        Me.BtRéserverCon.Text = "Réservation concession"
        Me.BtRéserverCon.UseVisualStyleBackColor = False
        '
        'BtProlongation
        '
        Me.BtProlongation.BackColor = System.Drawing.Color.SeaGreen
        Me.BtProlongation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.BtProlongation.ForeColor = System.Drawing.Color.Transparent
        Me.BtProlongation.Location = New System.Drawing.Point(578, 4)
        Me.BtProlongation.Margin = New System.Windows.Forms.Padding(4)
        Me.BtProlongation.Name = "BtProlongation"
        Me.BtProlongation.Size = New System.Drawing.Size(279, 128)
        Me.BtProlongation.TabIndex = 2
        Me.BtProlongation.Text = "Prolongation de concession"
        Me.BtProlongation.UseVisualStyleBackColor = False
        '
        'BtPlan
        '
        Me.BtPlan.BackColor = System.Drawing.Color.SeaGreen
        Me.BtPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.BtPlan.ForeColor = System.Drawing.Color.Transparent
        Me.BtPlan.Location = New System.Drawing.Point(120, 140)
        Me.BtPlan.Margin = New System.Windows.Forms.Padding(120, 4, 4, 4)
        Me.BtPlan.Name = "BtPlan"
        Me.BtPlan.Size = New System.Drawing.Size(279, 128)
        Me.BtPlan.TabIndex = 3
        Me.BtPlan.Text = "Accéder au Plan"
        Me.BtPlan.UseVisualStyleBackColor = False
        '
        'BtConsulterDonnées
        '
        Me.BtConsulterDonnées.BackColor = System.Drawing.Color.SeaGreen
        Me.BtConsulterDonnées.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.BtConsulterDonnées.ForeColor = System.Drawing.Color.Transparent
        Me.BtConsulterDonnées.Location = New System.Drawing.Point(456, 140)
        Me.BtConsulterDonnées.Margin = New System.Windows.Forms.Padding(53, 4, 4, 4)
        Me.BtConsulterDonnées.Name = "BtConsulterDonnées"
        Me.BtConsulterDonnées.Size = New System.Drawing.Size(279, 128)
        Me.BtConsulterDonnées.TabIndex = 4
        Me.BtConsulterDonnées.Text = "Consulter données"
        Me.BtConsulterDonnées.UseVisualStyleBackColor = False
        '
        'PanNotifs
        '
        Me.PanNotifs.BackColor = System.Drawing.Color.SeaGreen
        Me.PanNotifs.Controls.Add(Me.Label2)
        Me.PanNotifs.Controls.Add(Me.Label1)
        Me.PanNotifs.Controls.Add(Me.DgvNotifsCsnsExp)
        Me.PanNotifs.Controls.Add(Me.DgvNotifsCsnsAb)
        Me.PanNotifs.Location = New System.Drawing.Point(0, 470)
        Me.PanNotifs.Margin = New System.Windows.Forms.Padding(4)
        Me.PanNotifs.Name = "PanNotifs"
        Me.PanNotifs.Size = New System.Drawing.Size(1025, 212)
        Me.PanNotifs.TabIndex = 68
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(568, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 20)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Concessions à l'abandon"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 20)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Concessions expirant bientôt"
        '
        'DgvNotifsCsnsExp
        '
        Me.DgvNotifsCsnsExp.AllowUserToAddRows = False
        Me.DgvNotifsCsnsExp.AllowUserToDeleteRows = False
        Me.DgvNotifsCsnsExp.AllowUserToOrderColumns = True
        Me.DgvNotifsCsnsExp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvNotifsCsnsExp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvNotifsCsnsExp.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DgvNotifsCsnsExp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvNotifsCsnsExp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DgvCsnsExpRefEmpl, Me.DgvCsnsExpDateExp, Me.DgvCsnsExpCsnrTel, Me.DgvCsnsExpColInfos, Me.DgvCsnsExpColBtDetails})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvNotifsCsnsExp.DefaultCellStyle = DataGridViewCellStyle1
        Me.DgvNotifsCsnsExp.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvNotifsCsnsExp.Location = New System.Drawing.Point(4, 38)
        Me.DgvNotifsCsnsExp.MultiSelect = False
        Me.DgvNotifsCsnsExp.Name = "DgvNotifsCsnsExp"
        Me.DgvNotifsCsnsExp.ReadOnly = True
        Me.DgvNotifsCsnsExp.RowHeadersVisible = False
        Me.DgvNotifsCsnsExp.RowTemplate.Height = 24
        Me.DgvNotifsCsnsExp.SelectedRow = Nothing
        Me.DgvNotifsCsnsExp.SelectedRowIndex = -1
        Me.DgvNotifsCsnsExp.SelectedValue = -1
        Me.DgvNotifsCsnsExp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvNotifsCsnsExp.Size = New System.Drawing.Size(543, 170)
        Me.DgvNotifsCsnsExp.TabIndex = 72
        '
        'DgvCsnsExpRefEmpl
        '
        Me.DgvCsnsExpRefEmpl.DataPropertyName = "empl_reference"
        Me.DgvCsnsExpRefEmpl.HeaderText = "Empl."
        Me.DgvCsnsExpRefEmpl.Name = "DgvCsnsExpRefEmpl"
        Me.DgvCsnsExpRefEmpl.ReadOnly = True
        '
        'DgvCsnsExpDateExp
        '
        Me.DgvCsnsExpDateExp.DataPropertyName = "con_date_fin"
        Me.DgvCsnsExpDateExp.FillWeight = 120.0!
        Me.DgvCsnsExpDateExp.HeaderText = "Fin"
        Me.DgvCsnsExpDateExp.Name = "DgvCsnsExpDateExp"
        Me.DgvCsnsExpDateExp.ReadOnly = True
        '
        'DgvCsnsExpCsnrTel
        '
        Me.DgvCsnsExpCsnrTel.DataPropertyName = "csnr_tel"
        Me.DgvCsnsExpCsnrTel.FillWeight = 90.0!
        Me.DgvCsnsExpCsnrTel.HeaderText = "Téléphone"
        Me.DgvCsnsExpCsnrTel.Name = "DgvCsnsExpCsnrTel"
        Me.DgvCsnsExpCsnrTel.ReadOnly = True
        '
        'DgvCsnsExpColInfos
        '
        Me.DgvCsnsExpColInfos.DataPropertyName = "csnr_nomcomplet"
        Me.DgvCsnsExpColInfos.FillWeight = 120.0!
        Me.DgvCsnsExpColInfos.HeaderText = "Concessionnaire"
        Me.DgvCsnsExpColInfos.Name = "DgvCsnsExpColInfos"
        Me.DgvCsnsExpColInfos.ReadOnly = True
        '
        'DgvCsnsExpColBtDetails
        '
        Me.DgvCsnsExpColBtDetails.FillWeight = 30.0!
        Me.DgvCsnsExpColBtDetails.HeaderText = "Plus"
        Me.DgvCsnsExpColBtDetails.Name = "DgvCsnsExpColBtDetails"
        Me.DgvCsnsExpColBtDetails.ReadOnly = True
        Me.DgvCsnsExpColBtDetails.Text = ""
        Me.DgvCsnsExpColBtDetails.UseColumnTextForButtonValue = True
        '
        'DgvNotifsCsnsAb
        '
        Me.DgvNotifsCsnsAb.AllowUserToAddRows = False
        Me.DgvNotifsCsnsAb.AllowUserToDeleteRows = False
        Me.DgvNotifsCsnsAb.AllowUserToOrderColumns = True
        Me.DgvNotifsCsnsAb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvNotifsCsnsAb.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvNotifsCsnsAb.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DgvNotifsCsnsAb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvNotifsCsnsAb.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DgvCsnsAbColRefEmpl, Me.DgvCsnsAbColNomCsnr, Me.DgvCsnsAbColTelCsnr, Me.DgvCsnsAbColBtDetails})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvNotifsCsnsAb.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvNotifsCsnsAb.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvNotifsCsnsAb.Location = New System.Drawing.Point(550, 37)
        Me.DgvNotifsCsnsAb.MultiSelect = False
        Me.DgvNotifsCsnsAb.Name = "DgvNotifsCsnsAb"
        Me.DgvNotifsCsnsAb.ReadOnly = True
        Me.DgvNotifsCsnsAb.RowHeadersVisible = False
        Me.DgvNotifsCsnsAb.RowTemplate.Height = 24
        Me.DgvNotifsCsnsAb.SelectedRow = Nothing
        Me.DgvNotifsCsnsAb.SelectedRowIndex = -1
        Me.DgvNotifsCsnsAb.SelectedValue = -1
        Me.DgvNotifsCsnsAb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvNotifsCsnsAb.Size = New System.Drawing.Size(471, 171)
        Me.DgvNotifsCsnsAb.TabIndex = 73
        '
        'DgvCsnsAbColRefEmpl
        '
        Me.DgvCsnsAbColRefEmpl.DataPropertyName = "empl_reference"
        Me.DgvCsnsAbColRefEmpl.FillWeight = 50.0!
        Me.DgvCsnsAbColRefEmpl.HeaderText = "Empl."
        Me.DgvCsnsAbColRefEmpl.Name = "DgvCsnsAbColRefEmpl"
        Me.DgvCsnsAbColRefEmpl.ReadOnly = True
        '
        'DgvCsnsAbColNomCsnr
        '
        Me.DgvCsnsAbColNomCsnr.DataPropertyName = "csnr_nomcomplet"
        Me.DgvCsnsAbColNomCsnr.FillWeight = 120.0!
        Me.DgvCsnsAbColNomCsnr.HeaderText = "Concessionnaire"
        Me.DgvCsnsAbColNomCsnr.Name = "DgvCsnsAbColNomCsnr"
        Me.DgvCsnsAbColNomCsnr.ReadOnly = True
        '
        'DgvCsnsAbColTelCsnr
        '
        Me.DgvCsnsAbColTelCsnr.DataPropertyName = "csnr_tel"
        Me.DgvCsnsAbColTelCsnr.HeaderText = "Téléphone"
        Me.DgvCsnsAbColTelCsnr.Name = "DgvCsnsAbColTelCsnr"
        Me.DgvCsnsAbColTelCsnr.ReadOnly = True
        '
        'DgvCsnsAbColBtDetails
        '
        Me.DgvCsnsAbColBtDetails.FillWeight = 30.0!
        Me.DgvCsnsAbColBtDetails.HeaderText = "Plus"
        Me.DgvCsnsAbColBtDetails.Name = "DgvCsnsAbColBtDetails"
        Me.DgvCsnsAbColBtDetails.ReadOnly = True
        '
        'BtNotifsMasquer
        '
        Me.BtNotifsMasquer.Location = New System.Drawing.Point(81, 429)
        Me.BtNotifsMasquer.Margin = New System.Windows.Forms.Padding(4)
        Me.BtNotifsMasquer.Name = "BtNotifsMasquer"
        Me.BtNotifsMasquer.Size = New System.Drawing.Size(119, 28)
        Me.BtNotifsMasquer.TabIndex = 5
        Me.BtNotifsMasquer.Text = "Masquer"
        Me.BtNotifsMasquer.UseVisualStyleBackColor = True
        '
        'BtNotifsMontrer
        '
        Me.BtNotifsMontrer.Location = New System.Drawing.Point(81, 430)
        Me.BtNotifsMontrer.Margin = New System.Windows.Forms.Padding(4)
        Me.BtNotifsMontrer.Name = "BtNotifsMontrer"
        Me.BtNotifsMontrer.Size = New System.Drawing.Size(119, 27)
        Me.BtNotifsMontrer.TabIndex = 6
        Me.BtNotifsMontrer.Text = "Notifications"
        Me.BtNotifsMontrer.UseVisualStyleBackColor = True
        Me.BtNotifsMontrer.Visible = False
        '
        'LabWelkom
        '
        Me.LabWelkom.AutoSize = True
        Me.LabWelkom.BackColor = System.Drawing.Color.Transparent
        Me.LabWelkom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabWelkom.Location = New System.Drawing.Point(813, 13)
        Me.LabWelkom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabWelkom.Name = "LabWelkom"
        Me.LabWelkom.Size = New System.Drawing.Size(123, 24)
        Me.LabWelkom.TabIndex = 71
        Me.LabWelkom.Text = "Welkom User"
        '
        'BtSignalAbCsn
        '
        Me.BtSignalAbCsn.Location = New System.Drawing.Point(655, 430)
        Me.BtSignalAbCsn.Name = "BtSignalAbCsn"
        Me.BtSignalAbCsn.Size = New System.Drawing.Size(279, 27)
        Me.BtSignalAbCsn.TabIndex = 7
        Me.BtSignalAbCsn.Text = "Signaler une concession à l'abandon"
        Me.BtSignalAbCsn.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.cimetiere.My.Resources.Resources.logolh
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(180, 113)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 72
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(955, 3)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 62)
        Me.PictureBox1.TabIndex = 70
        Me.PictureBox1.TabStop = False
        '
        'PanelToutSaufNotifs
        '
        Me.PanelToutSaufNotifs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelToutSaufNotifs.Controls.Add(Me.PictureBox2)
        Me.PanelToutSaufNotifs.Controls.Add(Me.PictureBox1)
        Me.PanelToutSaufNotifs.Controls.Add(Me.BtNotifsMontrer)
        Me.PanelToutSaufNotifs.Controls.Add(Me.LabWelkom)
        Me.PanelToutSaufNotifs.Controls.Add(Me.FlowLayoutPanel1)
        Me.PanelToutSaufNotifs.Controls.Add(Me.BtNotifsMasquer)
        Me.PanelToutSaufNotifs.Controls.Add(Me.BtSignalAbCsn)
        Me.PanelToutSaufNotifs.Location = New System.Drawing.Point(0, 0)
        Me.PanelToutSaufNotifs.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelToutSaufNotifs.Name = "PanelToutSaufNotifs"
        Me.PanelToutSaufNotifs.Size = New System.Drawing.Size(1025, 470)
        Me.PanelToutSaufNotifs.TabIndex = 73
        '
        'FormHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1023, 680)
        Me.Controls.Add(Me.PanelToutSaufNotifs)
        Me.Controls.Add(Me.PanNotifs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cimetière"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.PanNotifs.ResumeLayout(False)
        Me.PanNotifs.PerformLayout()
        CType(Me.DgvNotifsCsnsExp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvNotifsCsnsAb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelToutSaufNotifs.ResumeLayout(False)
        Me.PanelToutSaufNotifs.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents BtDéclarationDécès As Button
    Friend WithEvents BtRéserverCon As Button
    Friend WithEvents BtProlongation As Button
    Friend WithEvents BtPlan As Button
    Friend WithEvents BtConsulterDonnées As Button
    Friend WithEvents PanNotifs As Panel
    Public WithEvents BtNotifsMasquer As Button
    Friend WithEvents LabWelkom As Label
    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents BtNotifsMontrer As Button
    Friend WithEvents BtSignalAbCsn As Button
    Friend WithEvents DgvNotifsCsnsExp As DataGridViewCustom
    Friend WithEvents DgvNotifsCsnsAb As DataGridViewCustom
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvCsnsAbColRefEmpl As DataGridViewTextBoxColumn
    Friend WithEvents DgvCsnsAbColNomCsnr As DataGridViewTextBoxColumn
    Friend WithEvents DgvCsnsAbColTelCsnr As DataGridViewTextBoxColumn
    Friend WithEvents DgvCsnsAbColBtDetails As DataGridViewButtonColumn
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PanelToutSaufNotifs As Panel
    Friend WithEvents DgvCsnsExpRefEmpl As DataGridViewTextBoxColumn
    Friend WithEvents DgvCsnsExpDateExp As DataGridViewTextBoxColumn
    Friend WithEvents DgvCsnsExpCsnrTel As DataGridViewTextBoxColumn
    Friend WithEvents DgvCsnsExpColInfos As DataGridViewTextBoxColumn
    Friend WithEvents DgvCsnsExpColBtDetails As DataGridViewButtonColumn
End Class
