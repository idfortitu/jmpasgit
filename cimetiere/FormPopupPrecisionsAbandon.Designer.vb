﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.PanBordure1 = New cimetiere.PanBordure()
        Me.PanBordure2 = New cimetiere.PanBordure()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FCPBlahulpe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanBordure1.SuspendLayout()
        Me.PanBordure2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(15, 17)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(419, 391)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TbCom
        '
        Me.TbCom.Location = New System.Drawing.Point(23, 75)
        Me.TbCom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TbCom.Multiline = True
        Me.TbCom.Name = "TbCom"
        Me.TbCom.ReadOnly = True
        Me.TbCom.Size = New System.Drawing.Size(335, 153)
        Me.TbCom.TabIndex = 1
        '
        'TbRefEmpl
        '
        Me.TbRefEmpl.Location = New System.Drawing.Point(222, 22)
        Me.TbRefEmpl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TbRefEmpl.Name = "TbRefEmpl"
        Me.TbRefEmpl.ReadOnly = True
        Me.TbRefEmpl.Size = New System.Drawing.Size(136, 22)
        Me.TbRefEmpl.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Référence de l'emplacement :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Commentaire éventuel :"
        '
        'LabPasDimage
        '
        Me.LabPasDimage.AutoSize = True
        Me.LabPasDimage.Location = New System.Drawing.Point(167, 201)
        Me.LabPasDimage.Name = "LabPasDimage"
        Me.LabPasDimage.Size = New System.Drawing.Size(96, 17)
        Me.LabPasDimage.TabIndex = 5
        Me.LabPasDimage.Text = "Pas de photo."
        '
        'BtDetails
        '
        Me.BtDetails.BackColor = System.Drawing.Color.SeaGreen
        Me.BtDetails.Enabled = False
        Me.BtDetails.ForeColor = System.Drawing.Color.White
        Me.BtDetails.Location = New System.Drawing.Point(112, 353)
        Me.BtDetails.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtDetails.Name = "BtDetails"
        Me.BtDetails.Size = New System.Drawing.Size(257, 39)
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
        Me.BtSupprimer.Location = New System.Drawing.Point(112, 399)
        Me.BtSupprimer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtSupprimer.Name = "BtSupprimer"
        Me.BtSupprimer.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.BtSupprimer.Size = New System.Drawing.Size(259, 35)
        Me.BtSupprimer.TabIndex = 7
        Me.BtSupprimer.Text = "   Supprimer cette notification "
        Me.BtSupprimer.UseVisualStyleBackColor = False
        '
        'FCPBlahulpe
        '
        Me.FCPBlahulpe.BackColor = System.Drawing.Color.Transparent
        Me.FCPBlahulpe.Image = CType(resources.GetObject("FCPBlahulpe.Image"), System.Drawing.Image)
        Me.FCPBlahulpe.Location = New System.Drawing.Point(-1, -1)
        Me.FCPBlahulpe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FCPBlahulpe.Name = "FCPBlahulpe"
        Me.FCPBlahulpe.Size = New System.Drawing.Size(148, 95)
        Me.FCPBlahulpe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FCPBlahulpe.TabIndex = 46
        Me.FCPBlahulpe.TabStop = False
        '
        'PanBordure1
        '
        Me.PanBordure1.BackColor = System.Drawing.SystemColors.Window
        Me.PanBordure1.Controls.Add(Me.Label1)
        Me.PanBordure1.Controls.Add(Me.TbCom)
        Me.PanBordure1.Controls.Add(Me.TbRefEmpl)
        Me.PanBordure1.Controls.Add(Me.Label2)
        Me.PanBordure1.CouleurBordure = System.Drawing.Color.SeaGreen
        Me.PanBordure1.EpaisseurBordure = 7
        Me.PanBordure1.Location = New System.Drawing.Point(-1, 98)
        Me.PanBordure1.Name = "PanBordure1"
        Me.PanBordure1.Size = New System.Drawing.Size(383, 248)
        Me.PanBordure1.TabIndex = 132
        Me.PanBordure1.Texte = Nothing
        '
        'PanBordure2
        '
        Me.PanBordure2.Controls.Add(Me.LabPasDimage)
        Me.PanBordure2.Controls.Add(Me.PictureBox1)
        Me.PanBordure2.CouleurBordure = System.Drawing.Color.SeaGreen
        Me.PanBordure2.EpaisseurBordure = 7
        Me.PanBordure2.Location = New System.Drawing.Point(388, 12)
        Me.PanBordure2.Name = "PanBordure2"
        Me.PanBordure2.Size = New System.Drawing.Size(448, 422)
        Me.PanBordure2.TabIndex = 133
        Me.PanBordure2.Texte = Nothing
        '
        'FormPopupPrecisionsAbandon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.cimetiere.My.Resources.Resources.fondformulaire
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(844, 447)
        Me.Controls.Add(Me.PanBordure2)
        Me.Controls.Add(Me.PanBordure1)
        Me.Controls.Add(Me.FCPBlahulpe)
        Me.Controls.Add(Me.BtSupprimer)
        Me.Controls.Add(Me.BtDetails)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormPopupPrecisionsAbandon"
        Me.Text = "FormPopupPrecisionsAbandon"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FCPBlahulpe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanBordure1.ResumeLayout(False)
        Me.PanBordure1.PerformLayout()
        Me.PanBordure2.ResumeLayout(False)
        Me.PanBordure2.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents PanBordure1 As PanBordure
    Friend WithEvents PanBordure2 As PanBordure
End Class
