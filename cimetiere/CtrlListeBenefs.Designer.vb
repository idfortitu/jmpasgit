<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtrlListeBenefs
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
        Me.PanelInterieur = New System.Windows.Forms.FlowLayoutPanel()
        Me.BtAjoutBenef = New System.Windows.Forms.Button()
        Me.PanelInterieur.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelInterieur
        '
        Me.PanelInterieur.AutoSize = True
        Me.PanelInterieur.Controls.Add(Me.BtAjoutBenef)
        Me.PanelInterieur.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.PanelInterieur.Location = New System.Drawing.Point(0, 0)
        Me.PanelInterieur.Name = "PanelInterieur"
        Me.PanelInterieur.Size = New System.Drawing.Size(556, 138)
        Me.PanelInterieur.TabIndex = 0
        '
        'BtAjoutBenef
        '
        Me.BtAjoutBenef.Image = Global.cimetiere.My.Resources.Resources.Add_16x
        Me.BtAjoutBenef.Location = New System.Drawing.Point(3, 2)
        Me.BtAjoutBenef.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtAjoutBenef.Name = "BtAjoutBenef"
        Me.BtAjoutBenef.Size = New System.Drawing.Size(27, 26)
        Me.BtAjoutBenef.TabIndex = 68
        Me.BtAjoutBenef.UseVisualStyleBackColor = True
        '
        'CtrlListeBenefs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.PanelInterieur)
        Me.Name = "CtrlListeBenefs"
        Me.Size = New System.Drawing.Size(556, 138)
        Me.PanelInterieur.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelInterieur As FlowLayoutPanel
    Friend WithEvents BtAjoutBenef As Button
End Class
