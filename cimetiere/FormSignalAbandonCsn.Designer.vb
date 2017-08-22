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
        Me.TbCommentaire = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtAnnuler = New System.Windows.Forms.Button()
        Me.BtTerminer = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtMontrerFormPlancim = New System.Windows.Forms.Button()
        Me.TbRefEmpl = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'TbCommentaire
        '
        Me.TbCommentaire.Location = New System.Drawing.Point(151, 123)
        Me.TbCommentaire.Multiline = True
        Me.TbCommentaire.Name = "TbCommentaire"
        Me.TbCommentaire.Size = New System.Drawing.Size(360, 137)
        Me.TbCommentaire.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(149, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Description/commentaire"
        '
        'BtAnnuler
        '
        Me.BtAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtAnnuler.Location = New System.Drawing.Point(333, 335)
        Me.BtAnnuler.Name = "BtAnnuler"
        Me.BtAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.BtAnnuler.TabIndex = 2
        Me.BtAnnuler.Text = "Annuler"
        Me.BtAnnuler.UseVisualStyleBackColor = True
        '
        'BtTerminer
        '
        Me.BtTerminer.Location = New System.Drawing.Point(489, 307)
        Me.BtTerminer.Name = "BtTerminer"
        Me.BtTerminer.Size = New System.Drawing.Size(75, 23)
        Me.BtTerminer.TabIndex = 3
        Me.BtTerminer.Text = "Créer"
        Me.BtTerminer.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Référence emplacement :"
        '
        'BtMontrerFormPlancim
        '
        Me.BtMontrerFormPlancim.Image = Global.cimetiere.My.Resources.Resources.Note_16x
        Me.BtMontrerFormPlancim.Location = New System.Drawing.Point(299, 5)
        Me.BtMontrerFormPlancim.Name = "BtMontrerFormPlancim"
        Me.BtMontrerFormPlancim.Size = New System.Drawing.Size(34, 31)
        Me.BtMontrerFormPlancim.TabIndex = 178
        Me.ToolTip1.SetToolTip(Me.BtMontrerFormPlancim, "Voir le plan")
        Me.BtMontrerFormPlancim.UseVisualStyleBackColor = True
        '
        'TbRefEmpl
        '
        Me.TbRefEmpl.Location = New System.Drawing.Point(188, 9)
        Me.TbRefEmpl.Name = "TbRefEmpl"
        Me.TbRefEmpl.Size = New System.Drawing.Size(100, 22)
        Me.TbRefEmpl.TabIndex = 179
        '
        'FormSignalAbandonCsn
        '
        Me.AcceptButton = Me.BtTerminer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtAnnuler
        Me.ClientSize = New System.Drawing.Size(736, 445)
        Me.Controls.Add(Me.TbRefEmpl)
        Me.Controls.Add(Me.BtMontrerFormPlancim)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtTerminer)
        Me.Controls.Add(Me.BtAnnuler)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbCommentaire)
        Me.Name = "FormSignalAbandonCsn"
        Me.Text = "Signaler une concession à l'abandon"
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
End Class
