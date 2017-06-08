<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtrlLocVillePays
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.BtAjouterPays = New System.Windows.Forms.Button()
        Me.BtAjouterVille = New System.Windows.Forms.Button()
        Me.CbPays = New System.Windows.Forms.ComboBox()
        Me.CbLocVille = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'BtAjouterPays
        '
        Me.BtAjouterPays.Image = Global.cimetiere.My.Resources.Resources.Add_16x
        Me.BtAjouterPays.Location = New System.Drawing.Point(218, -1)
        Me.BtAjouterPays.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtAjouterPays.Name = "BtAjouterPays"
        Me.BtAjouterPays.Size = New System.Drawing.Size(20, 21)
        Me.BtAjouterPays.TabIndex = 67
        Me.BtAjouterPays.UseVisualStyleBackColor = True
        '
        'BtAjouterVille
        '
        Me.BtAjouterVille.Image = Global.cimetiere.My.Resources.Resources.Add_16x
        Me.BtAjouterVille.Location = New System.Drawing.Point(96, -1)
        Me.BtAjouterVille.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtAjouterVille.Name = "BtAjouterVille"
        Me.BtAjouterVille.Size = New System.Drawing.Size(20, 21)
        Me.BtAjouterVille.TabIndex = 66
        Me.BtAjouterVille.UseVisualStyleBackColor = True
        '
        'CbPays
        '
        Me.CbPays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbPays.FormattingEnabled = True
        Me.CbPays.Location = New System.Drawing.Point(128, 0)
        Me.CbPays.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CbPays.Name = "CbPays"
        Me.CbPays.Size = New System.Drawing.Size(89, 21)
        Me.CbPays.TabIndex = 65
        '
        'CbLocVille
        '
        Me.CbLocVille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbLocVille.FormattingEnabled = True
        Me.CbLocVille.Location = New System.Drawing.Point(0, 0)
        Me.CbLocVille.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CbLocVille.Name = "CbLocVille"
        Me.CbLocVille.Size = New System.Drawing.Size(96, 21)
        Me.CbLocVille.TabIndex = 64
        '
        'CtrlLocVillePays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BtAjouterPays)
        Me.Controls.Add(Me.BtAjouterVille)
        Me.Controls.Add(Me.CbPays)
        Me.Controls.Add(Me.CbLocVille)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "CtrlLocVillePays"
        Me.Size = New System.Drawing.Size(237, 20)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtAjouterPays As Button
    Friend WithEvents BtAjouterVille As Button
    Friend WithEvents CbPays As ComboBox
    Friend WithEvents CbLocVille As ComboBox
End Class
