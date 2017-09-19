<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dev_formplancimedit
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
        Me.PlanCimEdit1 = New cimetiere.PlanCimEdit()
        Me.SuspendLayout()
        '
        'PlanCimEdit1
        '
        Me.PlanCimEdit1.AutoScroll = True
        Me.PlanCimEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlanCimEdit1.Location = New System.Drawing.Point(13, 13)
        Me.PlanCimEdit1.Margin = New System.Windows.Forms.Padding(4)
        Me.PlanCimEdit1.Name = "PlanCimEdit1"
        Me.PlanCimEdit1.Size = New System.Drawing.Size(1695, 1235)
        Me.PlanCimEdit1.TabIndex = 0
        '
        'dev_formplancimedit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1435, 1045)
        Me.Controls.Add(Me.PlanCimEdit1)
        Me.Name = "dev_formplancimedit"
        Me.Text = "dev_formplancimedit"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PlanCimEdit1 As PlanCimEdit
End Class
