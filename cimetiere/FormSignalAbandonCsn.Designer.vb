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
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.ErProv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TbCommentaire
        '
        Me.TbCommentaire.Location = New System.Drawing.Point(11, 109)
        Me.TbCommentaire.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbCommentaire.Multiline = True
        Me.TbCommentaire.Name = "TbCommentaire"
        Me.TbCommentaire.Size = New System.Drawing.Size(380, 66)
        Me.TbCommentaire.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 91)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Description/commentaire : "
        '
        'BtAnnuler
        '
        Me.BtAnnuler.BackColor = System.Drawing.Color.SeaGreen
        Me.BtAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtAnnuler.ForeColor = System.Drawing.Color.White
        Me.BtAnnuler.Location = New System.Drawing.Point(97, 229)
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
        Me.BtTerminer.Location = New System.Drawing.Point(220, 229)
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
        Me.Label2.Location = New System.Drawing.Point(167, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Référence emplacement :"
        '
        'BtMontrerFormPlancim
        '
        Me.BtMontrerFormPlancim.Image = Global.cimetiere.My.Resources.Resources.Note_16x
        Me.BtMontrerFormPlancim.Location = New System.Drawing.Point(380, 1)
        Me.BtMontrerFormPlancim.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtMontrerFormPlancim.Name = "BtMontrerFormPlancim"
        Me.BtMontrerFormPlancim.Size = New System.Drawing.Size(26, 25)
        Me.BtMontrerFormPlancim.TabIndex = 178
        Me.ToolTip1.SetToolTip(Me.BtMontrerFormPlancim, "Voir le plan")
        Me.BtMontrerFormPlancim.UseVisualStyleBackColor = True
        '
        'TbRefEmpl
        '
        Me.TbRefEmpl.Location = New System.Drawing.Point(300, 4)
        Me.TbRefEmpl.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbRefEmpl.Name = "TbRefEmpl"
        Me.TbRefEmpl.Size = New System.Drawing.Size(76, 20)
        Me.TbRefEmpl.TabIndex = 179
        '
        'TbCheminFicImg
        '
        Me.TbCheminFicImg.Location = New System.Drawing.Point(105, 95)
        Me.TbCheminFicImg.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbCheminFicImg.Name = "TbCheminFicImg"
        Me.TbCheminFicImg.ReadOnly = True
        Me.TbCheminFicImg.Size = New System.Drawing.Size(209, 20)
        Me.TbCheminFicImg.TabIndex = 180
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 98)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 181
        Me.Label3.Text = "Joindre une image :"
        '
        'BtParcourir
        '
        Me.BtParcourir.Location = New System.Drawing.Point(316, 95)
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Location = New System.Drawing.Point(2, 84)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(400, 140)
        Me.Panel2.TabIndex = 194
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Controls.Add(Me.BtParcourir)
        Me.GroupBox1.Controls.Add(Me.TbCheminFicImg)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(388, 126)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'FormSignalAbandonCsn
        '
        Me.AcceptButton = Me.BtTerminer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.cimetiere.My.Resources.Resources.fondformulaire
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.BtAnnuler
        Me.ClientSize = New System.Drawing.Size(407, 275)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TbRefEmpl)
        Me.Controls.Add(Me.BtMontrerFormPlancim)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtTerminer)
        Me.Controls.Add(Me.BtAnnuler)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbCommentaire)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FormSignalAbandonCsn"
        Me.Text = "Signaler une concession à l'abandon"
        CType(Me.ErProv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbCommentaire As TextBox
    Friend WithEvents Label1 As Label
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
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
End Class
