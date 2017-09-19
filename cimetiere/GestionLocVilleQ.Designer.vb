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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionLocVille))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DgvListeVilleCp = New System.Windows.Forms.DataGridView()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.FGLAnnulerRecherche = New System.Windows.Forms.Button()
        Me.FGLRecherche = New System.Windows.Forms.TextBox()
        Me.FGLChercher = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TbDateDeces = New cimetiere.TextBoxDate()
        Me.FPTBLahulpe = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FGLCTBVille = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.FGLCTBPays = New System.Windows.Forms.TextBox()
        Me.FPLPays = New System.Windows.Forms.Label()
        Me.FGLCTBCP = New System.Windows.Forms.TextBox()
        Me.FPLCodePostal = New System.Windows.Forms.Label()
        Me.FGLSupprimer = New System.Windows.Forms.Button()
        Me.FGLBModifier = New System.Windows.Forms.Button()
        Me.FGLBSelection = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgvListeVilleCp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.FPTBLahulpe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel3.Controls.Add(Me.GroupBox3)
        Me.Panel3.Location = New System.Drawing.Point(236, 14)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(323, 264)
        Me.Panel3.TabIndex = 101
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox3.Controls.Add(Me.DgvListeVilleCp)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(303, 244)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'DgvListeVilleCp
        '
        Me.DgvListeVilleCp.AllowUserToAddRows = False
        Me.DgvListeVilleCp.AllowUserToDeleteRows = False
        Me.DgvListeVilleCp.AllowUserToOrderColumns = True
        Me.DgvListeVilleCp.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DgvListeVilleCp.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvListeVilleCp.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DgvListeVilleCp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvListeVilleCp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListeVilleCp.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvListeVilleCp.EnableHeadersVisualStyles = False
        Me.DgvListeVilleCp.GridColor = System.Drawing.Color.DarkGray
        Me.DgvListeVilleCp.Location = New System.Drawing.Point(0, 16)
        Me.DgvListeVilleCp.MultiSelect = False
        Me.DgvListeVilleCp.Name = "DgvListeVilleCp"
        Me.DgvListeVilleCp.ReadOnly = True
        Me.DgvListeVilleCp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DgvListeVilleCp.RowHeadersVisible = False
        Me.DgvListeVilleCp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvListeVilleCp.Size = New System.Drawing.Size(303, 225)
        Me.DgvListeVilleCp.TabIndex = 48
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel10.Controls.Add(Me.GroupBox10)
        Me.Panel10.Location = New System.Drawing.Point(11, 83)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(214, 117)
        Me.Panel10.TabIndex = 100
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.White
        Me.GroupBox10.Controls.Add(Me.FGLAnnulerRecherche)
        Me.GroupBox10.Controls.Add(Me.FGLRecherche)
        Me.GroupBox10.Controls.Add(Me.FGLChercher)
        Me.GroupBox10.Location = New System.Drawing.Point(10, 15)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(195, 89)
        Me.GroupBox10.TabIndex = 0
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Rechercher"
        '
        'FGLAnnulerRecherche
        '
        Me.FGLAnnulerRecherche.Location = New System.Drawing.Point(16, 50)
        Me.FGLAnnulerRecherche.Name = "FGLAnnulerRecherche"
        Me.FGLAnnulerRecherche.Size = New System.Drawing.Size(68, 23)
        Me.FGLAnnulerRecherche.TabIndex = 97
        Me.FGLAnnulerRecherche.Text = "Annuler filtre"
        Me.FGLAnnulerRecherche.UseVisualStyleBackColor = True
        '
        'FGLRecherche
        '
        Me.FGLRecherche.Location = New System.Drawing.Point(13, 20)
        Me.FGLRecherche.Name = "FGLRecherche"
        Me.FGLRecherche.Size = New System.Drawing.Size(150, 20)
        Me.FGLRecherche.TabIndex = 40
        '
        'FGLChercher
        '
        Me.FGLChercher.Location = New System.Drawing.Point(105, 50)
        Me.FGLChercher.Name = "FGLChercher"
        Me.FGLChercher.Size = New System.Drawing.Size(73, 23)
        Me.FGLChercher.TabIndex = 49
        Me.FGLChercher.Text = "Rechercher"
        Me.FGLChercher.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(569, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(262, 146)
        Me.Panel1.TabIndex = 99
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.FGLCTBVille)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.FGLCTBPays)
        Me.GroupBox1.Controls.Add(Me.FPLPays)
        Me.GroupBox1.Controls.Add(Me.FGLCTBCP)
        Me.GroupBox1.Controls.Add(Me.FPLCodePostal)
        Me.GroupBox1.Controls.Add(Me.TbDateDeces)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(236, 128)
        Me.GroupBox1.TabIndex = 93
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informations "
        '
        'TbDateDeces
        '
        Me.TbDateDeces.DateValue = Nothing
        Me.TbDateDeces.Location = New System.Drawing.Point(1033, 410)
        Me.TbDateDeces.Margin = New System.Windows.Forms.Padding(2)
        Me.TbDateDeces.Mask = "00/00/0000"
        Me.TbDateDeces.Name = "TbDateDeces"
        Me.TbDateDeces.Size = New System.Drawing.Size(76, 20)
        Me.TbDateDeces.TabIndex = 113
        Me.TbDateDeces.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FPTBLahulpe
        '
        Me.FPTBLahulpe.Image = CType(resources.GetObject("FPTBLahulpe.Image"), System.Drawing.Image)
        Me.FPTBLahulpe.Location = New System.Drawing.Point(-217, -138)
        Me.FPTBLahulpe.Name = "FPTBLahulpe"
        Me.FPTBLahulpe.Size = New System.Drawing.Size(111, 77)
        Me.FPTBLahulpe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FPTBLahulpe.TabIndex = 98
        Me.FPTBLahulpe.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 102
        Me.PictureBox1.TabStop = False
        '
        'FGLCTBVille
        '
        Me.FGLCTBVille.Location = New System.Drawing.Point(67, 20)
        Me.FGLCTBVille.Name = "FGLCTBVille"
        Me.FGLCTBVille.Size = New System.Drawing.Size(152, 20)
        Me.FGLCTBVille.TabIndex = 147
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(29, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 13)
        Me.Label15.TabIndex = 146
        Me.Label15.Text = "Ville :"
        '
        'FGLCTBPays
        '
        Me.FGLCTBPays.Location = New System.Drawing.Point(67, 89)
        Me.FGLCTBPays.Name = "FGLCTBPays"
        Me.FGLCTBPays.Size = New System.Drawing.Size(152, 20)
        Me.FGLCTBPays.TabIndex = 145
        '
        'FPLPays
        '
        Me.FPLPays.AutoSize = True
        Me.FPLPays.Location = New System.Drawing.Point(25, 92)
        Me.FPLPays.Name = "FPLPays"
        Me.FPLPays.Size = New System.Drawing.Size(36, 13)
        Me.FPLPays.TabIndex = 144
        Me.FPLPays.Text = "Pays :"
        '
        'FGLCTBCP
        '
        Me.FGLCTBCP.Location = New System.Drawing.Point(67, 54)
        Me.FGLCTBCP.Name = "FGLCTBCP"
        Me.FGLCTBCP.Size = New System.Drawing.Size(152, 20)
        Me.FGLCTBCP.TabIndex = 143
        '
        'FPLCodePostal
        '
        Me.FPLCodePostal.AutoSize = True
        Me.FPLCodePostal.Location = New System.Drawing.Point(2, 57)
        Me.FPLCodePostal.Name = "FPLCodePostal"
        Me.FPLCodePostal.Size = New System.Drawing.Size(63, 13)
        Me.FPLCodePostal.TabIndex = 142
        Me.FPLCodePostal.Text = "Code postal"
        '
        'FGLSupprimer
        '
        Me.FGLSupprimer.BackColor = System.Drawing.Color.SeaGreen
        Me.FGLSupprimer.ForeColor = System.Drawing.Color.Transparent
        Me.FGLSupprimer.Location = New System.Drawing.Point(757, 164)
        Me.FGLSupprimer.Name = "FGLSupprimer"
        Me.FGLSupprimer.Size = New System.Drawing.Size(74, 23)
        Me.FGLSupprimer.TabIndex = 104
        Me.FGLSupprimer.Text = "Supprimer"
        Me.FGLSupprimer.UseVisualStyleBackColor = False
        '
        'FGLBModifier
        '
        Me.FGLBModifier.BackColor = System.Drawing.Color.SeaGreen
        Me.FGLBModifier.ForeColor = System.Drawing.Color.Transparent
        Me.FGLBModifier.Location = New System.Drawing.Point(687, 164)
        Me.FGLBModifier.Name = "FGLBModifier"
        Me.FGLBModifier.Size = New System.Drawing.Size(64, 23)
        Me.FGLBModifier.TabIndex = 103
        Me.FGLBModifier.Text = "Modifier"
        Me.FGLBModifier.UseVisualStyleBackColor = False
        '
        'FGLBSelection
        '
        Me.FGLBSelection.BackColor = System.Drawing.Color.SeaGreen
        Me.FGLBSelection.ForeColor = System.Drawing.Color.Transparent
        Me.FGLBSelection.Location = New System.Drawing.Point(126, 52)
        Me.FGLBSelection.Name = "FGLBSelection"
        Me.FGLBSelection.Size = New System.Drawing.Size(80, 23)
        Me.FGLBSelection.TabIndex = 105
        Me.FGLBSelection.Text = "Selectionner"
        Me.FGLBSelection.UseVisualStyleBackColor = False
        '
        'GestionLocVille
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.cimetiere.My.Resources.Resources.fondformulaire
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(844, 301)
        Me.Controls.Add(Me.FGLBSelection)
        Me.Controls.Add(Me.FGLSupprimer)
        Me.Controls.Add(Me.FGLBModifier)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FPTBLahulpe)
        Me.Name = "GestionLocVille"
        Me.Text = "GestionLocVille"
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DgvListeVilleCp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.FPTBLahulpe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DgvListeVilleCp As DataGridView
    Friend WithEvents Panel10 As Panel
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents FGLAnnulerRecherche As Button
    Friend WithEvents FGLRecherche As TextBox
    Friend WithEvents FGLChercher As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TbDateDeces As TextBoxDate
    Friend WithEvents FPTBLahulpe As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FGLCTBVille As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents FGLCTBPays As TextBox
    Friend WithEvents FPLPays As Label
    Friend WithEvents FGLCTBCP As TextBox
    Friend WithEvents FPLCodePostal As Label
    Friend WithEvents FGLSupprimer As Button
    Friend WithEvents FGLBModifier As Button
    Friend WithEvents FGLBSelection As Button
End Class
