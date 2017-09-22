<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSignalAbandonCsn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSignalAbandonCsn))
        Me.TbCommentaire = New System.Windows.Forms.TextBox()
        Me.BtAnnuler = New System.Windows.Forms.Button()
        Me.BtTerminer = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtMontrerFormPlancim = New System.Windows.Forms.Button()
        Me.TbRefEmpl = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TbCheminFicImg = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtParcourir = New System.Windows.Forms.Button()
        Me.ErProv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanBordure1 = New cimetiere.PanBordure()
        CType(Me.ErProv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanBordure1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TbCommentaire
        '
        Me.TbCommentaire.Location = New System.Drawing.Point(14, 30)
        Me.TbCommentaire.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbCommentaire.Multiline = True
        Me.TbCommentaire.Name = "TbCommentaire"
        Me.TbCommentaire.Size = New System.Drawing.Size(376, 71)
        Me.TbCommentaire.TabIndex = 0
        '
        'BtAnnuler
        '
        Me.BtAnnuler.BackColor = System.Drawing.Color.SeaGreen
        Me.BtAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtAnnuler.ForeColor = System.Drawing.Color.White
        Me.BtAnnuler.Location = New System.Drawing.Point(191, 233)
        Me.BtAnnuler.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtAnnuler.Name = "BtAnnuler"
        Me.BtAnnuler.Size = New System.Drawing.Size(82, 35)
        Me.BtAnnuler.TabIndex = 2
        Me.BtAnnuler.Text = "Annuler"
        Me.BtAnnuler.UseVisualStyleBackColor = False
        '
        'BtTerminer
        '
        Me.BtTerminer.BackColor = System.Drawing.Color.SeaGreen
        Me.BtTerminer.ForeColor = System.Drawing.Color.White
        Me.BtTerminer.Location = New System.Drawing.Point(297, 233)
        Me.BtTerminer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtTerminer.Name = "BtTerminer"
        Me.BtTerminer.Size = New System.Drawing.Size(87, 35)
        Me.BtTerminer.TabIndex = 3
        Me.BtTerminer.Text = "Terminer"
        Me.BtTerminer.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(158, 51)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Référence emplacement :"
        '
        'BtMontrerFormPlancim
        '
        Me.BtMontrerFormPlancim.Image = Global.cimetiere.My.Resources.Resources.Note_16x
        Me.BtMontrerFormPlancim.Location = New System.Drawing.Point(370, 45)
        Me.BtMontrerFormPlancim.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtMontrerFormPlancim.Name = "BtMontrerFormPlancim"
        Me.BtMontrerFormPlancim.Size = New System.Drawing.Size(26, 25)
        Me.BtMontrerFormPlancim.TabIndex = 178
        Me.ToolTip1.SetToolTip(Me.BtMontrerFormPlancim, "Voir le plan")
        Me.BtMontrerFormPlancim.UseVisualStyleBackColor = True
        '
        'TbRefEmpl
        '
        Me.TbRefEmpl.Location = New System.Drawing.Point(290, 48)
        Me.TbRefEmpl.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbRefEmpl.Name = "TbRefEmpl"
        Me.TbRefEmpl.Size = New System.Drawing.Size(76, 20)
        Me.TbRefEmpl.TabIndex = 179
        '
        'TbCheminFicImg
        '
        Me.TbCheminFicImg.Location = New System.Drawing.Point(114, 110)
        Me.TbCheminFicImg.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbCheminFicImg.Name = "TbCheminFicImg"
        Me.TbCheminFicImg.ReadOnly = True
        Me.TbCheminFicImg.Size = New System.Drawing.Size(204, 20)
        Me.TbCheminFicImg.TabIndex = 180
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 111)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 181
        Me.Label3.Text = "Joindre une image :"
        '
        'BtParcourir
        '
        Me.BtParcourir.Location = New System.Drawing.Point(320, 110)
        Me.BtParcourir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtParcourir.Name = "BtParcourir"
        Me.BtParcourir.Size = New System.Drawing.Size(68, 20)
        Me.BtParcourir.TabIndex = 182
        Me.BtParcourir.Text = "Parcourir..."
        Me.BtParcourir.UseVisualStyleBackColor = True
        '
        'ErProv
        '
        Me.ErProv.ContainerControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-3, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 193
        Me.PictureBox1.TabStop = False
        '
        'PanBordure1
        '
        Me.PanBordure1.BackColor = System.Drawing.SystemColors.Window
        Me.PanBordure1.Controls.Add(Me.BtParcourir)
        Me.PanBordure1.Controls.Add(Me.TbCheminFicImg)
        Me.PanBordure1.Controls.Add(Me.TbCommentaire)
        Me.PanBordure1.Controls.Add(Me.Label3)
        Me.PanBordure1.CouleurBordure = System.Drawing.Color.SeaGreen
        Me.PanBordure1.EpaisseurBordure = 7
        Me.PanBordure1.Location = New System.Drawing.Point(2, 84)
        Me.PanBordure1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanBordure1.Name = "PanBordure1"
        Me.PanBordure1.Size = New System.Drawing.Size(403, 143)
        Me.PanBordure1.TabIndex = 195
        Me.PanBordure1.Texte = "Description/commentaire"
        '
        'FormSignalAbandonCsn
        '
        Me.AcceptButton = Me.BtTerminer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.cimetiere.My.Resources.Resources.fondformulaire
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.BtAnnuler
        Me.ClientSize = New System.Drawing.Size(407, 275)
        Me.Controls.Add(Me.PanBordure1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TbRefEmpl)
        Me.Controls.Add(Me.BtMontrerFormPlancim)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtTerminer)
        Me.Controls.Add(Me.BtAnnuler)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximumSize = New System.Drawing.Size(423, 314)
        Me.MinimumSize = New System.Drawing.Size(423, 314)
        Me.Name = "FormSignalAbandonCsn"
        Me.Text = "Signaler une concession à l'abandon"
        CType(Me.ErProv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanBordure1.ResumeLayout(False)
        Me.PanBordure1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbCommentaire As TextBox
    Friend WithEvents BtAnnuler As Button
    Friend WithEvents BtTerminer As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BtMontrerFormPlancim As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TbRefEmpl As TextBox
    Friend WithEvents TbCheminFicImg As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtParcourir As Button
    Friend WithEvents ErProv As ErrorProvider
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanBordure1 As PanBordure
End Class
