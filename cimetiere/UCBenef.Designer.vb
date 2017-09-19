<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCBenef
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
        Me.TextBoxFloat3 = New cimetiere.TextBoxFloat()
        Me.DateNaiss = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxFloat7 = New cimetiere.TextBoxFloat()
        Me.TextBoxFloat1 = New cimetiere.TextBoxFloat()
        Me.TextBoxFloat6 = New cimetiere.TextBoxFloat()
        Me.TextBoxFloat2 = New cimetiere.TextBoxFloat()
        Me.TextBoxFloat5 = New cimetiere.TextBoxFloat()
        Me.TextBoxFloat4 = New cimetiere.TextBoxFloat()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxFloat3
        '
        Me.TextBoxFloat3.Location = New System.Drawing.Point(359, 3)
        Me.TextBoxFloat3.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxFloat3.Name = "TextBoxFloat3"
        Me.TextBoxFloat3.Size = New System.Drawing.Size(103, 20)
        Me.TextBoxFloat3.TabIndex = 18
        Me.TextBoxFloat3.Text = "0"
        Me.TextBoxFloat3.Value = 0!
        '
        'DateNaiss
        '
        Me.DateNaiss.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DateNaiss.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateNaiss.Location = New System.Drawing.Point(234, 3)
        Me.DateNaiss.Name = "DateNaiss"
        Me.DateNaiss.ShowCheckBox = True
        Me.DateNaiss.Size = New System.Drawing.Size(120, 20)
        Me.DateNaiss.TabIndex = 15
        '
        'TextBoxFloat7
        '
        Me.TextBoxFloat7.Location = New System.Drawing.Point(189, 27)
        Me.TextBoxFloat7.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxFloat7.Name = "TextBoxFloat7"
        Me.TextBoxFloat7.Size = New System.Drawing.Size(76, 20)
        Me.TextBoxFloat7.TabIndex = 22
        Me.TextBoxFloat7.Text = "0"
        Me.TextBoxFloat7.Value = 0!
        '
        'TextBoxFloat1
        '
        Me.TextBoxFloat1.Location = New System.Drawing.Point(4, 3)
        Me.TextBoxFloat1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxFloat1.Name = "TextBoxFloat1"
        Me.TextBoxFloat1.Size = New System.Drawing.Size(108, 20)
        Me.TextBoxFloat1.TabIndex = 16
        Me.TextBoxFloat1.Text = "0"
        Me.TextBoxFloat1.Value = 0!
        '
        'TextBoxFloat6
        '
        Me.TextBoxFloat6.Location = New System.Drawing.Point(276, 27)
        Me.TextBoxFloat6.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxFloat6.Name = "TextBoxFloat6"
        Me.TextBoxFloat6.Size = New System.Drawing.Size(76, 20)
        Me.TextBoxFloat6.TabIndex = 21
        Me.TextBoxFloat6.Text = "0"
        Me.TextBoxFloat6.Value = 0!
        '
        'TextBoxFloat2
        '
        Me.TextBoxFloat2.Location = New System.Drawing.Point(118, 3)
        Me.TextBoxFloat2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxFloat2.Name = "TextBoxFloat2"
        Me.TextBoxFloat2.Size = New System.Drawing.Size(107, 20)
        Me.TextBoxFloat2.TabIndex = 17
        Me.TextBoxFloat2.Text = "0"
        Me.TextBoxFloat2.Value = 0!
        '
        'TextBoxFloat5
        '
        Me.TextBoxFloat5.Location = New System.Drawing.Point(8, 27)
        Me.TextBoxFloat5.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxFloat5.Name = "TextBoxFloat5"
        Me.TextBoxFloat5.Size = New System.Drawing.Size(170, 20)
        Me.TextBoxFloat5.TabIndex = 20
        Me.TextBoxFloat5.Text = "0"
        Me.TextBoxFloat5.Value = 0!
        '
        'TextBoxFloat4
        '
        Me.TextBoxFloat4.Location = New System.Drawing.Point(359, 27)
        Me.TextBoxFloat4.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxFloat4.Name = "TextBoxFloat4"
        Me.TextBoxFloat4.Size = New System.Drawing.Size(102, 20)
        Me.TextBoxFloat4.TabIndex = 19
        Me.TextBoxFloat4.Text = "0"
        Me.TextBoxFloat4.Value = 0!
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.TextBoxFloat3)
        Me.Panel1.Controls.Add(Me.DateNaiss)
        Me.Panel1.Controls.Add(Me.TextBoxFloat7)
        Me.Panel1.Controls.Add(Me.TextBoxFloat1)
        Me.Panel1.Controls.Add(Me.TextBoxFloat6)
        Me.Panel1.Controls.Add(Me.TextBoxFloat2)
        Me.Panel1.Controls.Add(Me.TextBoxFloat5)
        Me.Panel1.Controls.Add(Me.TextBoxFloat4)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(464, 50)
        Me.Panel1.TabIndex = 25
        '
        'UCBenef
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UCBenef"
        Me.Size = New System.Drawing.Size(463, 47)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBoxFloat3 As TextBoxFloat
    Friend WithEvents DateNaiss As DateTimePicker
    Friend WithEvents TextBoxFloat7 As TextBoxFloat
    Friend WithEvents TextBoxFloat1 As TextBoxFloat
    Friend WithEvents TextBoxFloat6 As TextBoxFloat
    Friend WithEvents TextBoxFloat2 As TextBoxFloat
    Friend WithEvents TextBoxFloat5 As TextBoxFloat
    Friend WithEvents TextBoxFloat4 As TextBoxFloat
    Friend WithEvents Panel1 As Panel
End Class
