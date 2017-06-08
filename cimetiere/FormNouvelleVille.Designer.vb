<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormNouvelleVille
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
        Me.TbNom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbintCp = New cimetiere.TextBoxInt()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbPays = New System.Windows.Forms.ComboBox()
        Me.BtAjouterPays = New System.Windows.Forms.Button()
        Me.BtAnnuler = New System.Windows.Forms.Button()
        Me.BtEnregistrer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TbNom
        '
        Me.TbNom.Location = New System.Drawing.Point(121, 8)
        Me.TbNom.Name = "TbNom"
        Me.TbNom.Size = New System.Drawing.Size(134, 22)
        Me.TbNom.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nom de la ville :"
        '
        'TbintCp
        '
        Me.TbintCp.Location = New System.Drawing.Point(121, 37)
        Me.TbintCp.Name = "TbintCp"
        Me.TbintCp.Size = New System.Drawing.Size(134, 22)
        Me.TbintCp.TabIndex = 2
        Me.TbintCp.Value = Nothing
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Code postal :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(268, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Pays :"
        '
        'CbPays
        '
        Me.CbPays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbPays.FormattingEnabled = True
        Me.CbPays.Location = New System.Drawing.Point(317, 8)
        Me.CbPays.Name = "CbPays"
        Me.CbPays.Size = New System.Drawing.Size(149, 24)
        Me.CbPays.TabIndex = 5
        '
        'BtAjouterPays
        '
        Me.BtAjouterPays.Image = Global.cimetiere.My.Resources.Resources.Add_16x
        Me.BtAjouterPays.Location = New System.Drawing.Point(469, 7)
        Me.BtAjouterPays.Name = "BtAjouterPays"
        Me.BtAjouterPays.Size = New System.Drawing.Size(27, 25)
        Me.BtAjouterPays.TabIndex = 61
        Me.BtAjouterPays.UseVisualStyleBackColor = True
        '
        'BtAnnuler
        '
        Me.BtAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtAnnuler.Location = New System.Drawing.Point(381, 71)
        Me.BtAnnuler.Name = "BtAnnuler"
        Me.BtAnnuler.Size = New System.Drawing.Size(99, 31)
        Me.BtAnnuler.TabIndex = 62
        Me.BtAnnuler.Text = "&Annuler"
        Me.BtAnnuler.UseVisualStyleBackColor = True
        '
        'BtEnregistrer
        '
        Me.BtEnregistrer.Location = New System.Drawing.Point(271, 71)
        Me.BtEnregistrer.Name = "BtEnregistrer"
        Me.BtEnregistrer.Size = New System.Drawing.Size(100, 31)
        Me.BtEnregistrer.TabIndex = 63
        Me.BtEnregistrer.Text = "&Enregistrer"
        Me.BtEnregistrer.UseVisualStyleBackColor = True
        '
        'FormNouvelleVille
        '
        Me.AcceptButton = Me.BtEnregistrer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtAnnuler
        Me.ClientSize = New System.Drawing.Size(505, 116)
        Me.Controls.Add(Me.BtEnregistrer)
        Me.Controls.Add(Me.BtAnnuler)
        Me.Controls.Add(Me.BtAjouterPays)
        Me.Controls.Add(Me.CbPays)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbintCp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbNom)
        Me.Name = "FormNouvelleVille"
        Me.Text = "FormNouvelleVille"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbNom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TbintCp As TextBoxInt
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CbPays As ComboBox
    Friend WithEvents BtAjouterPays As Button
    Friend WithEvents BtAnnuler As Button
    Friend WithEvents BtEnregistrer As Button
End Class
