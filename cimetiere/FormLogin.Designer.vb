<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.BtQuitter = New System.Windows.Forms.Button()
        Me.BtOk = New System.Windows.Forms.Button()
        Me.TbMdp = New System.Windows.Forms.TextBox()
        Me.TbNomUtilisateur = New System.Windows.Forms.TextBox()
        Me.LabMdp = New System.Windows.Forms.Label()
        Me.LabNomUtilisateur = New System.Windows.Forms.Label()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtQuitter
        '
        Me.BtQuitter.BackColor = System.Drawing.Color.Gainsboro
        Me.BtQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtQuitter.Location = New System.Drawing.Point(483, 150)
        Me.BtQuitter.Margin = New System.Windows.Forms.Padding(4)
        Me.BtQuitter.Name = "BtQuitter"
        Me.BtQuitter.Size = New System.Drawing.Size(125, 28)
        Me.BtQuitter.TabIndex = 21
        Me.BtQuitter.Text = "&Quitter"
        Me.BtQuitter.UseVisualStyleBackColor = False
        '
        'BtOk
        '
        Me.BtOk.BackColor = System.Drawing.Color.Gainsboro
        Me.BtOk.Location = New System.Drawing.Point(345, 150)
        Me.BtOk.Margin = New System.Windows.Forms.Padding(4)
        Me.BtOk.Name = "BtOk"
        Me.BtOk.Size = New System.Drawing.Size(125, 28)
        Me.BtOk.TabIndex = 20
        Me.BtOk.Text = "&OK"
        Me.BtOk.UseVisualStyleBackColor = False
        '
        'TbMdp
        '
        Me.TbMdp.BackColor = System.Drawing.SystemColors.Window
        Me.TbMdp.Location = New System.Drawing.Point(336, 112)
        Me.TbMdp.Margin = New System.Windows.Forms.Padding(4)
        Me.TbMdp.Name = "TbMdp"
        Me.TbMdp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbMdp.Size = New System.Drawing.Size(292, 22)
        Me.TbMdp.TabIndex = 19
        '
        'TbNomUtilisateur
        '
        Me.TbNomUtilisateur.Location = New System.Drawing.Point(336, 42)
        Me.TbNomUtilisateur.Margin = New System.Windows.Forms.Padding(4)
        Me.TbNomUtilisateur.Name = "TbNomUtilisateur"
        Me.TbNomUtilisateur.Size = New System.Drawing.Size(292, 22)
        Me.TbNomUtilisateur.TabIndex = 17
        '
        'LabMdp
        '
        Me.LabMdp.BackColor = System.Drawing.Color.Transparent
        Me.LabMdp.Location = New System.Drawing.Point(333, 85)
        Me.LabMdp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMdp.Name = "LabMdp"
        Me.LabMdp.Size = New System.Drawing.Size(293, 28)
        Me.LabMdp.TabIndex = 18
        Me.LabMdp.Text = "&Mot de passe"
        Me.LabMdp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabNomUtilisateur
        '
        Me.LabNomUtilisateur.BackColor = System.Drawing.Color.Transparent
        Me.LabNomUtilisateur.Location = New System.Drawing.Point(333, 15)
        Me.LabNomUtilisateur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabNomUtilisateur.Name = "LabNomUtilisateur"
        Me.LabNomUtilisateur.Size = New System.Drawing.Size(293, 28)
        Me.LabNomUtilisateur.TabIndex = 15
        Me.LabNomUtilisateur.Text = "Nom d'utilisateur"
        Me.LabNomUtilisateur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(9, 9)
        Me.LogoPictureBox.Margin = New System.Windows.Forms.Padding(4)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(316, 190)
        Me.LogoPictureBox.TabIndex = 16
        Me.LogoPictureBox.TabStop = False
        '
        'FormLogin
        '
        Me.AcceptButton = Me.BtOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.cimetiere.My.Resources.Resources.fondformulaire
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(676, 213)
        Me.Controls.Add(Me.BtQuitter)
        Me.Controls.Add(Me.BtOk)
        Me.Controls.Add(Me.TbMdp)
        Me.Controls.Add(Me.TbNomUtilisateur)
        Me.Controls.Add(Me.LabMdp)
        Me.Controls.Add(Me.LabNomUtilisateur)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLogin"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtQuitter As Button
    Friend WithEvents BtOk As Button
    Friend WithEvents TbMdp As TextBox
    Friend WithEvents TbNomUtilisateur As TextBox
    Friend WithEvents LabMdp As Label
    Friend WithEvents LabNomUtilisateur As Label
    Friend WithEvents LogoPictureBox As PictureBox
End Class
