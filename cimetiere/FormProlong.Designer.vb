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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProlong))
        Me.BtTerminer = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.CbEnregPdfCsnExis = New System.Windows.Forms.CheckBox()
        Me.GbN = New System.Windows.Forms.GroupBox()
        Me.LbOccupants = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LbBenefs = New System.Windows.Forms.ListBox()
        Me.TbCom = New System.Windows.Forms.TextBox()
        Me.GbO = New System.Windows.Forms.GroupBox()
        Me.DgvCsns = New cimetiere.DataGridViewConcessions()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvCsnsExistColOccupants = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.GbN.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GbO.SuspendLayout()
        CType(Me.DgvCsns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtTerminer
        '
        Me.BtTerminer.BackColor = System.Drawing.Color.SeaGreen
        Me.BtTerminer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtTerminer.ForeColor = System.Drawing.Color.Transparent
        Me.BtTerminer.Location = New System.Drawing.Point(789, 460)
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
        Me.Panel3.Location = New System.Drawing.Point(506, 453)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(276, 76)
        Me.Panel3.TabIndex = 181
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.Window
        Me.Panel7.Controls.Add(Me.CbEnregPdfCsnExis)
        Me.Panel7.Location = New System.Drawing.Point(6, 7)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(265, 62)
        Me.Panel7.TabIndex = 0
        '
        'CbEnregPdfCsnExis
        '
        Me.CbEnregPdfCsnExis.AutoSize = True
        Me.CbEnregPdfCsnExis.Checked = True
        Me.CbEnregPdfCsnExis.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbEnregPdfCsnExis.Location = New System.Drawing.Point(6, 6)
        Me.CbEnregPdfCsnExis.Margin = New System.Windows.Forms.Padding(4)
        Me.CbEnregPdfCsnExis.Name = "CbEnregPdfCsnExis"
        Me.CbEnregPdfCsnExis.Size = New System.Drawing.Size(188, 21)
        Me.CbEnregPdfCsnExis.TabIndex = 8
        Me.CbEnregPdfCsnExis.Text = "Enregistrer le fichier PDF"
        Me.CbEnregPdfCsnExis.UseVisualStyleBackColor = True
        '
        'GbN
        '
        Me.GbN.BackColor = System.Drawing.Color.Transparent
        Me.GbN.Controls.Add(Me.LbOccupants)
        Me.GbN.Location = New System.Drawing.Point(12, 272)
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
        Me.GroupBox3.Location = New System.Drawing.Point(360, 274)
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
        Me.GbO.Location = New System.Drawing.Point(681, 275)
        Me.GbO.Name = "GbO"
        Me.GbO.Size = New System.Drawing.Size(269, 166)
        Me.GbO.TabIndex = 184
        Me.GbO.TabStop = False
        Me.GbO.Text = "Commentaire"
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
        Me.DgvCsns.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column4, Me.Column3, Me.DgvCsnsExistColOccupants})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvCsns.DefaultCellStyle = DataGridViewCellStyle1
        Me.DgvCsns.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvCsns.Location = New System.Drawing.Point(12, 12)
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
        'DgvCsnsExistColOccupants
        '
        Me.DgvCsnsExistColOccupants.FillWeight = 130.0!
        Me.DgvCsnsExistColOccupants.HeaderText = "Occupants"
        Me.DgvCsnsExistColOccupants.Name = "DgvCsnsExistColOccupants"
        Me.DgvCsnsExistColOccupants.ReadOnly = True
        '
        'FormProlong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.cimetiere.My.Resources.Resources.fondformulaire
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(962, 853)
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
        CType(Me.DgvCsns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtTerminer As Button
    Friend WithEvents DgvCsns As DataGridViewConcessions
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents CbEnregPdfCsnExis As CheckBox
    Friend WithEvents GbN As GroupBox
    Friend WithEvents LbOccupants As ListBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents DgvCsnsExistColOccupants As DataGridViewTextBoxColumn
    Friend WithEvents TbCom As TextBox
    Friend WithEvents GbO As GroupBox
    Friend WithEvents LbBenefs As ListBox
End Class
