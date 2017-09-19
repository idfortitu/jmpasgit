<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtrlLocVilleCPPays
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
        Me.CbPays = New System.Windows.Forms.ComboBox()
        Me.CbLocVille = New System.Windows.Forms.ComboBox()
        Me.BtAjouterPays = New System.Windows.Forms.Button()
        Me.BtAjouterVille = New System.Windows.Forms.Button()
        Me.cbcp = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'CbPays
        '
        Me.CbPays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbPays.FormattingEnabled = True
        Me.CbPays.Location = New System.Drawing.Point(212, 38)
        Me.CbPays.Margin = New System.Windows.Forms.Padding(2)
        Me.CbPays.Name = "CbPays"
        Me.CbPays.Size = New System.Drawing.Size(152, 21)
        Me.CbPays.TabIndex = 69
        '
        'CbLocVille
        '
        Me.CbLocVille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbLocVille.FormattingEnabled = True
        Me.CbLocVille.Location = New System.Drawing.Point(2, 38)
        Me.CbLocVille.Margin = New System.Windows.Forms.Padding(2)
        Me.CbLocVille.Name = "CbLocVille"
        Me.CbLocVille.Size = New System.Drawing.Size(153, 21)
        Me.CbLocVille.TabIndex = 68
        '
        'BtAjouterPays
        '
        Me.BtAjouterPays.Image = Global.cimetiere.My.Resources.Resources.Add_16x
        Me.BtAjouterPays.Location = New System.Drawing.Point(365, 38)
        Me.BtAjouterPays.Margin = New System.Windows.Forms.Padding(2)
        Me.BtAjouterPays.Name = "BtAjouterPays"
        Me.BtAjouterPays.Size = New System.Drawing.Size(20, 21)
        Me.BtAjouterPays.TabIndex = 71
        Me.BtAjouterPays.UseVisualStyleBackColor = True
        '
        'BtAjouterVille
        '
        Me.BtAjouterVille.Image = Global.cimetiere.My.Resources.Resources.Add_16x
        Me.BtAjouterVille.Location = New System.Drawing.Point(154, 38)
        Me.BtAjouterVille.Margin = New System.Windows.Forms.Padding(2)
        Me.BtAjouterVille.Name = "BtAjouterVille"
        Me.BtAjouterVille.Size = New System.Drawing.Size(20, 21)
        Me.BtAjouterVille.TabIndex = 70
        Me.BtAjouterVille.UseVisualStyleBackColor = True
        '
        'cbcp
        '
        Me.cbcp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcp.FormattingEnabled = True
        Me.cbcp.Location = New System.Drawing.Point(212, 2)
        Me.cbcp.Margin = New System.Windows.Forms.Padding(2)
        Me.cbcp.Name = "cbcp"
        Me.cbcp.Size = New System.Drawing.Size(152, 21)
        Me.cbcp.TabIndex = 72
        '
        'CtrlLocVilleCPPays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cbcp)
        Me.Controls.Add(Me.BtAjouterPays)
        Me.Controls.Add(Me.BtAjouterVille)
        Me.Controls.Add(Me.CbPays)
        Me.Controls.Add(Me.CbLocVille)
        Me.Name = "CtrlLocVilleCPPays"
        Me.Size = New System.Drawing.Size(392, 61)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtAjouterPays As Button
    Friend WithEvents BtAjouterVille As Button
    Friend WithEvents CbPays As ComboBox
    Friend WithEvents CbLocVille As ComboBox
    Friend WithEvents cbcp As ComboBox
End Class
