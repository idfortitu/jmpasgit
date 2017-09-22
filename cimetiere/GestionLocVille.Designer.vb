<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionLocVille
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionLocVille))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.FPTBLahulpe = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTVilleSuppr = New System.Windows.Forms.Button()
        Me.BTVilleMod = New System.Windows.Forms.Button()
        Me.BTPaysSuppr = New System.Windows.Forms.Button()
        Me.BTPaysMod = New System.Windows.Forms.Button()
        Me.BtFermer = New System.Windows.Forms.Button()
        Me.PanBordure6 = New cimetiere.PanBordure()
        Me.TBPaysNom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pan = New cimetiere.PanBordure()
        Me.DgvListePays = New cimetiere.DataGridViewCustom()
        Me.PanBordure3 = New cimetiere.PanBordure()
        Me.TBVilleCP = New cimetiere.TextBoxInt()
        Me.CBVillePays = New System.Windows.Forms.ComboBox()
        Me.TBVilleNom = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.FPLCodePostal = New System.Windows.Forms.Label()
        Me.FPLPays = New System.Windows.Forms.Label()
        Me.PanBordure1 = New cimetiere.PanBordure()
        Me.DgvListeVilleCp = New cimetiere.DataGridViewCustom()
        CType(Me.FPTBLahulpe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanBordure6.SuspendLayout()
        Me.Pan.SuspendLayout()
        CType(Me.DgvListePays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanBordure3.SuspendLayout()
        Me.PanBordure1.SuspendLayout()
        CType(Me.DgvListeVilleCp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FPTBLahulpe
        '
        Me.FPTBLahulpe.Image = CType(resources.GetObject("FPTBLahulpe.Image"), System.Drawing.Image)
        Me.FPTBLahulpe.Location = New System.Drawing.Point(-289, -170)
        Me.FPTBLahulpe.Margin = New System.Windows.Forms.Padding(4)
        Me.FPTBLahulpe.Name = "FPTBLahulpe"
        Me.FPTBLahulpe.Size = New System.Drawing.Size(148, 95)
        Me.FPTBLahulpe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FPTBLahulpe.TabIndex = 98
        Me.FPTBLahulpe.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(148, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 102
        Me.PictureBox1.TabStop = False
        '
        'BTVilleSuppr
        '
        Me.BTVilleSuppr.BackColor = System.Drawing.Color.SeaGreen
        Me.BTVilleSuppr.ForeColor = System.Drawing.Color.Transparent
        Me.BTVilleSuppr.Location = New System.Drawing.Point(838, 193)
        Me.BTVilleSuppr.Margin = New System.Windows.Forms.Padding(4)
        Me.BTVilleSuppr.Name = "BTVilleSuppr"
        Me.BTVilleSuppr.Size = New System.Drawing.Size(99, 28)
        Me.BTVilleSuppr.TabIndex = 104
        Me.BTVilleSuppr.Text = "Supprimer"
        Me.BTVilleSuppr.UseVisualStyleBackColor = False
        '
        'BTVilleMod
        '
        Me.BTVilleMod.BackColor = System.Drawing.Color.SeaGreen
        Me.BTVilleMod.ForeColor = System.Drawing.Color.Transparent
        Me.BTVilleMod.Location = New System.Drawing.Point(745, 193)
        Me.BTVilleMod.Margin = New System.Windows.Forms.Padding(4)
        Me.BTVilleMod.Name = "BTVilleMod"
        Me.BTVilleMod.Size = New System.Drawing.Size(85, 28)
        Me.BTVilleMod.TabIndex = 103
        Me.BTVilleMod.Text = "Modifier"
        Me.BTVilleMod.UseVisualStyleBackColor = False
        '
        'BTPaysSuppr
        '
        Me.BTPaysSuppr.BackColor = System.Drawing.Color.SeaGreen
        Me.BTPaysSuppr.ForeColor = System.Drawing.Color.Transparent
        Me.BTPaysSuppr.Location = New System.Drawing.Point(843, 377)
        Me.BTPaysSuppr.Margin = New System.Windows.Forms.Padding(4)
        Me.BTPaysSuppr.Name = "BTPaysSuppr"
        Me.BTPaysSuppr.Size = New System.Drawing.Size(99, 28)
        Me.BTPaysSuppr.TabIndex = 150
        Me.BTPaysSuppr.Text = "Supprimer"
        Me.BTPaysSuppr.UseVisualStyleBackColor = False
        '
        'BTPaysMod
        '
        Me.BTPaysMod.BackColor = System.Drawing.Color.SeaGreen
        Me.BTPaysMod.ForeColor = System.Drawing.Color.Transparent
        Me.BTPaysMod.Location = New System.Drawing.Point(750, 377)
        Me.BTPaysMod.Margin = New System.Windows.Forms.Padding(4)
        Me.BTPaysMod.Name = "BTPaysMod"
        Me.BTPaysMod.Size = New System.Drawing.Size(85, 28)
        Me.BTPaysMod.TabIndex = 149
        Me.BTPaysMod.Text = "Modifier"
        Me.BTPaysMod.UseVisualStyleBackColor = False
        '
        'BtFermer
        '
        Me.BtFermer.BackColor = System.Drawing.Color.SeaGreen
        Me.BtFermer.ForeColor = System.Drawing.Color.Transparent
        Me.BtFermer.Location = New System.Drawing.Point(710, 449)
        Me.BtFermer.Margin = New System.Windows.Forms.Padding(4)
        Me.BtFermer.Name = "BtFermer"
        Me.BtFermer.Size = New System.Drawing.Size(227, 71)
        Me.BtFermer.TabIndex = 151
        Me.BtFermer.Text = "Fermer"
        Me.BtFermer.UseVisualStyleBackColor = False
        '
        'PanBordure6
        '
        Me.PanBordure6.BackColor = System.Drawing.SystemColors.Window
        Me.PanBordure6.Controls.Add(Me.TBPaysNom)
        Me.PanBordure6.Controls.Add(Me.Label1)
        Me.PanBordure6.CouleurBordure = System.Drawing.Color.SeaGreen
        Me.PanBordure6.EpaisseurBordure = 7
        Me.PanBordure6.Location = New System.Drawing.Point(592, 273)
        Me.PanBordure6.Name = "PanBordure6"
        Me.PanBordure6.Size = New System.Drawing.Size(350, 92)
        Me.PanBordure6.TabIndex = 148
        Me.PanBordure6.Texte = "Informations"
        '
        'TBPaysNom
        '
        Me.TBPaysNom.Location = New System.Drawing.Point(108, 38)
        Me.TBPaysNom.Margin = New System.Windows.Forms.Padding(4)
        Me.TBPaysNom.Name = "TBPaysNom"
        Me.TBPaysNom.Size = New System.Drawing.Size(201, 22)
        Me.TBPaysNom.TabIndex = 147
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 17)
        Me.Label1.TabIndex = 146
        Me.Label1.Text = "Nom"
        '
        'Pan
        '
        Me.Pan.BackColor = System.Drawing.SystemColors.Window
        Me.Pan.Controls.Add(Me.DgvListePays)
        Me.Pan.CouleurBordure = System.Drawing.Color.SeaGreen
        Me.Pan.EpaisseurBordure = 7
        Me.Pan.Location = New System.Drawing.Point(151, 273)
        Me.Pan.Name = "Pan"
        Me.Pan.Size = New System.Drawing.Size(430, 247)
        Me.Pan.TabIndex = 107
        Me.Pan.Texte = "Pays"
        '
        'DgvListePays
        '
        Me.DgvListePays.AllowUserToAddRows = False
        Me.DgvListePays.AllowUserToDeleteRows = False
        Me.DgvListePays.AllowUserToOrderColumns = True
        Me.DgvListePays.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DgvListePays.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvListePays.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvListePays.BackgroundColor = System.Drawing.Color.White
        Me.DgvListePays.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvListePays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvListePays.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvListePays.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvListePays.EnableHeadersVisualStyles = False
        Me.DgvListePays.GridColor = System.Drawing.Color.DarkGray
        Me.DgvListePays.Location = New System.Drawing.Point(16, 35)
        Me.DgvListePays.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvListePays.MultiSelect = False
        Me.DgvListePays.Name = "DgvListePays"
        Me.DgvListePays.ReadOnly = True
        Me.DgvListePays.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DgvListePays.RowHeadersVisible = False
        Me.DgvListePays.SelectedRow = Nothing
        Me.DgvListePays.SelectedRowIndex = -1
        Me.DgvListePays.SelectedValue = -1
        Me.DgvListePays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvListePays.Size = New System.Drawing.Size(399, 201)
        Me.DgvListePays.TabIndex = 49
        '
        'PanBordure3
        '
        Me.PanBordure3.BackColor = System.Drawing.SystemColors.Window
        Me.PanBordure3.Controls.Add(Me.TBVilleCP)
        Me.PanBordure3.Controls.Add(Me.CBVillePays)
        Me.PanBordure3.Controls.Add(Me.TBVilleNom)
        Me.PanBordure3.Controls.Add(Me.Label15)
        Me.PanBordure3.Controls.Add(Me.FPLCodePostal)
        Me.PanBordure3.Controls.Add(Me.FPLPays)
        Me.PanBordure3.CouleurBordure = System.Drawing.Color.SeaGreen
        Me.PanBordure3.EpaisseurBordure = 7
        Me.PanBordure3.Location = New System.Drawing.Point(587, 5)
        Me.PanBordure3.Name = "PanBordure3"
        Me.PanBordure3.Size = New System.Drawing.Size(350, 176)
        Me.PanBordure3.TabIndex = 108
        Me.PanBordure3.Texte = "Informations"
        '
        'TBVilleCP
        '
        Me.TBVilleCP.Location = New System.Drawing.Point(108, 83)
        Me.TBVilleCP.Name = "TBVilleCP"
        Me.TBVilleCP.Size = New System.Drawing.Size(201, 22)
        Me.TBVilleCP.TabIndex = 151
        Me.TBVilleCP.Value = Nothing
        '
        'CBVillePays
        '
        Me.CBVillePays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBVillePays.FormattingEnabled = True
        Me.CBVillePays.Location = New System.Drawing.Point(108, 124)
        Me.CBVillePays.Name = "CBVillePays"
        Me.CBVillePays.Size = New System.Drawing.Size(201, 24)
        Me.CBVillePays.TabIndex = 148
        '
        'TBVilleNom
        '
        Me.TBVilleNom.Location = New System.Drawing.Point(108, 38)
        Me.TBVilleNom.Margin = New System.Windows.Forms.Padding(4)
        Me.TBVilleNom.Name = "TBVilleNom"
        Me.TBVilleNom.Size = New System.Drawing.Size(201, 22)
        Me.TBVilleNom.TabIndex = 147
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(58, 41)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 17)
        Me.Label15.TabIndex = 146
        Me.Label15.Text = "Ville :"
        '
        'FPLCodePostal
        '
        Me.FPLCodePostal.AutoSize = True
        Me.FPLCodePostal.Location = New System.Drawing.Point(22, 83)
        Me.FPLCodePostal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FPLCodePostal.Name = "FPLCodePostal"
        Me.FPLCodePostal.Size = New System.Drawing.Size(83, 17)
        Me.FPLCodePostal.TabIndex = 142
        Me.FPLCodePostal.Text = "Code postal"
        '
        'FPLPays
        '
        Me.FPLPays.AutoSize = True
        Me.FPLPays.Location = New System.Drawing.Point(52, 126)
        Me.FPLPays.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FPLPays.Name = "FPLPays"
        Me.FPLPays.Size = New System.Drawing.Size(47, 17)
        Me.FPLPays.TabIndex = 144
        Me.FPLPays.Text = "Pays :"
        '
        'PanBordure1
        '
        Me.PanBordure1.BackColor = System.Drawing.SystemColors.Window
        Me.PanBordure1.Controls.Add(Me.DgvListeVilleCp)
        Me.PanBordure1.CouleurBordure = System.Drawing.Color.SeaGreen
        Me.PanBordure1.EpaisseurBordure = 7
        Me.PanBordure1.Location = New System.Drawing.Point(151, 5)
        Me.PanBordure1.Name = "PanBordure1"
        Me.PanBordure1.Size = New System.Drawing.Size(430, 250)
        Me.PanBordure1.TabIndex = 106
        Me.PanBordure1.Texte = "Villes"
        '
        'DgvListeVilleCp
        '
        Me.DgvListeVilleCp.AllowUserToAddRows = False
        Me.DgvListeVilleCp.AllowUserToDeleteRows = False
        Me.DgvListeVilleCp.AllowUserToOrderColumns = True
        Me.DgvListeVilleCp.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DgvListeVilleCp.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvListeVilleCp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvListeVilleCp.BackgroundColor = System.Drawing.Color.White
        Me.DgvListeVilleCp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvListeVilleCp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvListeVilleCp.DefaultCellStyle = DataGridViewCellStyle4
        Me.DgvListeVilleCp.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvListeVilleCp.EnableHeadersVisualStyles = False
        Me.DgvListeVilleCp.GridColor = System.Drawing.Color.DarkGray
        Me.DgvListeVilleCp.Location = New System.Drawing.Point(16, 35)
        Me.DgvListeVilleCp.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvListeVilleCp.MultiSelect = False
        Me.DgvListeVilleCp.Name = "DgvListeVilleCp"
        Me.DgvListeVilleCp.ReadOnly = True
        Me.DgvListeVilleCp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DgvListeVilleCp.RowHeadersVisible = False
        Me.DgvListeVilleCp.SelectedRow = Nothing
        Me.DgvListeVilleCp.SelectedRowIndex = -1
        Me.DgvListeVilleCp.SelectedValue = -1
        Me.DgvListeVilleCp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvListeVilleCp.Size = New System.Drawing.Size(399, 204)
        Me.DgvListeVilleCp.TabIndex = 48
        '
        'GestionLocVille
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(983, 570)
        Me.Controls.Add(Me.BtFermer)
        Me.Controls.Add(Me.BTPaysSuppr)
        Me.Controls.Add(Me.BTPaysMod)
        Me.Controls.Add(Me.PanBordure6)
        Me.Controls.Add(Me.Pan)
        Me.Controls.Add(Me.PanBordure3)
        Me.Controls.Add(Me.PanBordure1)
        Me.Controls.Add(Me.BTVilleSuppr)
        Me.Controls.Add(Me.BTVilleMod)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.FPTBLahulpe)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "GestionLocVille"
        Me.Text = "GestionLocVille"
        CType(Me.FPTBLahulpe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanBordure6.ResumeLayout(False)
        Me.PanBordure6.PerformLayout()
        Me.Pan.ResumeLayout(False)
        Me.Pan.PerformLayout()
        CType(Me.DgvListePays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanBordure3.ResumeLayout(False)
        Me.PanBordure3.PerformLayout()
        Me.PanBordure1.ResumeLayout(False)
        Me.PanBordure1.PerformLayout()
        CType(Me.DgvListeVilleCp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvListeVilleCp As DataGridViewCustom
    Friend WithEvents FPTBLahulpe As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TBVilleNom As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents FPLPays As Label
    Friend WithEvents FPLCodePostal As Label
    Friend WithEvents BTVilleSuppr As Button
    Friend WithEvents BTVilleMod As Button
    Friend WithEvents PanBordure1 As PanBordure
    Friend WithEvents PanBordure3 As PanBordure
    Friend WithEvents Pan As PanBordure
    Friend WithEvents DgvListePays As DataGridViewCustom
    Friend WithEvents PanBordure6 As PanBordure
    Friend WithEvents TBPaysNom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTPaysSuppr As Button
    Friend WithEvents BTPaysMod As Button
    Friend WithEvents CBVillePays As ComboBox
    Friend WithEvents TBVilleCP As TextBoxInt
    Friend WithEvents BtFermer As Button
End Class
