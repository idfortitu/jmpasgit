<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PopupPlancim
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PopupPlancim))
        Me.PlanCimetiere1 = New cimetiere.PlanCimetiere()
        Me.PlanCimConteneur1 = New cimetiere.PlanCimConteneur()
        Me.PlanCimConteneur1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PlanCimetiere1
        '
        Me.PlanCimetiere1.BackgroundImage = CType(resources.GetObject("PlanCimetiere1.BackgroundImage"), System.Drawing.Image)
        Me.PlanCimetiere1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlanCimetiere1.EmplSelect = Nothing
        Me.PlanCimetiere1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlanCimetiere1.IdEmplSelect = -1
        Me.PlanCimetiere1.Location = New System.Drawing.Point(0, 0)
        Me.PlanCimetiere1.Margin = New System.Windows.Forms.Padding(2)
        Me.PlanCimetiere1.Name = "PlanCimetiere1"
        Me.PlanCimetiere1.NomParcelleAffichee = "A1"
        Me.PlanCimetiere1.Size = New System.Drawing.Size(261, 515)
        Me.PlanCimetiere1.TabIndex = 1
        Me.PlanCimetiere1.TabStop = False
        Me.PlanCimetiere1.Zoom = 1.0!
        Me.PlanCimetiere1.ZoomableAvecRoulette = True
        '
        'PlanCimConteneur1
        '
        Me.PlanCimConteneur1.AutoScroll = True
        Me.PlanCimConteneur1.Controls.Add(Me.PlanCimetiere1)
        Me.PlanCimConteneur1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlanCimConteneur1.Location = New System.Drawing.Point(0, 0)
        Me.PlanCimConteneur1.Name = "PlanCimConteneur1"
        Me.PlanCimConteneur1.Size = New System.Drawing.Size(303, 253)
        Me.PlanCimConteneur1.TabIndex = 2
        '
        'PopupPlancim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 253)
        Me.Controls.Add(Me.PlanCimConteneur1)
        Me.Name = "PopupPlancim"
        Me.PlanCimConteneur1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PlanCimetiere1 As PlanCimetiere
    Friend WithEvents PlanCimConteneur1 As PlanCimConteneur
End Class
