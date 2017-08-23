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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TbCom = New System.Windows.Forms.TextBox()
        Me.TbRefEmpl = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabPasDimage = New System.Windows.Forms.Label()
        Me.BtDetails = New System.Windows.Forms.Button()
        Me.BtSupprimer = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(379, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(453, 419)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TbCom
        '
        Me.TbCom.Location = New System.Drawing.Point(17, 68)
        Me.TbCom.Multiline = True
        Me.TbCom.Name = "TbCom"
        Me.TbCom.ReadOnly = True
        Me.TbCom.Size = New System.Drawing.Size(335, 162)
        Me.TbCom.TabIndex = 1
        '
        'TbRefEmpl
        '
        Me.TbRefEmpl.Location = New System.Drawing.Point(216, 9)
        Me.TbRefEmpl.Name = "TbRefEmpl"
        Me.TbRefEmpl.ReadOnly = True
        Me.TbRefEmpl.Size = New System.Drawing.Size(136, 22)
        Me.TbRefEmpl.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Référence de l'emplacement :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Commentaire éventuel :"
        '
        'LabPasDimage
        '
        Me.LabPasDimage.AutoSize = True
        Me.LabPasDimage.Location = New System.Drawing.Point(557, 198)
        Me.LabPasDimage.Name = "LabPasDimage"
        Me.LabPasDimage.Size = New System.Drawing.Size(96, 17)
        Me.LabPasDimage.TabIndex = 5
        Me.LabPasDimage.Text = "Pas de photo."
        '
        'BtDetails
        '
        Me.BtDetails.Enabled = False
        Me.BtDetails.Location = New System.Drawing.Point(95, 245)
        Me.BtDetails.Name = "BtDetails"
        Me.BtDetails.Size = New System.Drawing.Size(257, 40)
        Me.BtDetails.TabIndex = 6
        Me.BtDetails.Text = "Voir les détails de l'emplacement"
        Me.BtDetails.UseVisualStyleBackColor = True
        '
        'BtSupprimer
        '
        Me.BtSupprimer.Image = Global.cimetiere.My.Resources.Resources.Cancel_16x
        Me.BtSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtSupprimer.Location = New System.Drawing.Point(128, 399)
        Me.BtSupprimer.Name = "BtSupprimer"
        Me.BtSupprimer.Size = New System.Drawing.Size(224, 32)
        Me.BtSupprimer.TabIndex = 7
        Me.BtSupprimer.Text = "   Supprimer cette notification "
        Me.BtSupprimer.UseVisualStyleBackColor = True
        '
        'FormPopupPrecisionsAbandon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 474)
        Me.Controls.Add(Me.BtSupprimer)
        Me.Controls.Add(Me.BtDetails)
        Me.Controls.Add(Me.LabPasDimage)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbRefEmpl)
        Me.Controls.Add(Me.TbCom)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormPopupPrecisionsAbandon"
        Me.Text = "FormPopupPrecisionsAbandon"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
