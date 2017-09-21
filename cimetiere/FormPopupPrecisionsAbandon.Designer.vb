<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPopupPrecisionsAbandon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPopupPrecisionsAbandon))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TbCom = New System.Windows.Forms.TextBox()
        Me.TbRefEmpl = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabPasDimage = New System.Windows.Forms.Label()
        Me.BtDetails = New System.Windows.Forms.Button()
        Me.BtSupprimer = New System.Windows.Forms.Button()
        Me.FCPBlahulpe = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FCPBlahulpe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(295, 8)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(329, 340)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TbCom
        '
        Me.TbCom.Location = New System.Drawing.Point(13, 138)
        Me.TbCom.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbCom.Multiline = True
        Me.TbCom.Name = "TbCom"
        Me.TbCom.ReadOnly = True
        Me.TbCom.Size = New System.Drawing.Size(252, 132)
        Me.TbCom.TabIndex = 1
        '
        'TbRefEmpl
        '
        Me.TbRefEmpl.Location = New System.Drawing.Point(162, 95)
        Me.TbRefEmpl.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbRefEmpl.Name = "TbRefEmpl"
        Me.TbRefEmpl.ReadOnly = True
        Me.TbRefEmpl.Size = New System.Drawing.Size(103, 20)
        Me.TbRefEmpl.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 95)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Référence de l'emplacement :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 120)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Commentaire éventuel :"
        '
        'LabPasDimage
        '
        Me.LabPasDimage.AutoSize = True
        Me.LabPasDimage.Location = New System.Drawing.Point(418, 161)
        Me.LabPasDimage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabPasDimage.Name = "LabPasDimage"
        Me.LabPasDimage.Size = New System.Drawing.Size(73, 13)
        Me.LabPasDimage.TabIndex = 5
        Me.LabPasDimage.Text = "Pas de photo."
        '
        'BtDetails
        '
        Me.BtDetails.BackColor = System.Drawing.Color.SeaGreen
        Me.BtDetails.Enabled = False
        Me.BtDetails.ForeColor = System.Drawing.Color.White
        Me.BtDetails.Location = New System.Drawing.Point(84, 287)
        Me.BtDetails.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtDetails.Name = "BtDetails"
        Me.BtDetails.Size = New System.Drawing.Size(193, 32)
        Me.BtDetails.TabIndex = 6
        Me.BtDetails.Text = "Voir les détails de l'emplacement"
        Me.BtDetails.UseVisualStyleBackColor = False
        '
        'BtSupprimer
        '
        Me.BtSupprimer.BackColor = System.Drawing.Color.SeaGreen
        Me.BtSupprimer.ForeColor = System.Drawing.Color.White
        Me.BtSupprimer.Image = Global.cimetiere.My.Resources.Resources.Cancel_16x
        Me.BtSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtSupprimer.Location = New System.Drawing.Point(110, 324)
        Me.BtSupprimer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtSupprimer.Name = "BtSupprimer"
        Me.BtSupprimer.Size = New System.Drawing.Size(168, 26)
        Me.BtSupprimer.TabIndex = 7
        Me.BtSupprimer.Text = "   Supprimer cette notification "
        Me.BtSupprimer.UseVisualStyleBackColor = False
        '
        'FCPBlahulpe
        '
        Me.FCPBlahulpe.BackColor = System.Drawing.Color.Transparent
        Me.FCPBlahulpe.Image = CType(resources.GetObject("FCPBlahulpe.Image"), System.Drawing.Image)
        Me.FCPBlahulpe.Location = New System.Drawing.Point(-1, -1)
        Me.FCPBlahulpe.Name = "FCPBlahulpe"
        Me.FCPBlahulpe.Size = New System.Drawing.Size(111, 77)
        Me.FCPBlahulpe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FCPBlahulpe.TabIndex = 46
        Me.FCPBlahulpe.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel4.Controls.Add(Me.GroupBox9)
        Me.Panel4.Location = New System.Drawing.Point(0, 82)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(280, 200)
        Me.Panel4.TabIndex = 130
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Location = New System.Drawing.Point(290, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(341, 351)
        Me.Panel1.TabIndex = 131
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.White
        Me.GroupBox9.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(274, 190)
        Me.GroupBox9.TabIndex = 132
        Me.GroupBox9.TabStop = False
        '
        'FormPopupPrecisionsAbandon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.cimetiere.My.Resources.Resources.fondformulaire
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(633, 363)
        Me.Controls.Add(Me.FCPBlahulpe)
        Me.Controls.Add(Me.BtSupprimer)
        Me.Controls.Add(Me.BtDetails)
        Me.Controls.Add(Me.LabPasDimage)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbRefEmpl)
        Me.Controls.Add(Me.TbCom)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FormPopupPrecisionsAbandon"
        Me.Text = "FormPopupPrecisionsAbandon"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FCPBlahulpe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TbCom As TextBox
    Friend WithEvents TbRefEmpl As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabPasDimage As Label
    Friend WithEvents BtDetails As Button
    Friend WithEvents BtSupprimer As Button
    Friend WithEvents FCPBlahulpe As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox9 As GroupBox
End Class
