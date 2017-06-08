<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHome))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BtDéclarationDécès = New System.Windows.Forms.Button()
        Me.BtRéserverCon = New System.Windows.Forms.Button()
        Me.BtProlongation = New System.Windows.Forms.Button()
        Me.BtConstatAbandon = New System.Windows.Forms.Button()
        Me.BtConsulterDonnées = New System.Windows.Forms.Button()
        Me.PanNotifs = New System.Windows.Forms.Panel()
        Me.BtNotifsMontrer = New System.Windows.Forms.Button()
        Me.BtNotifsMasquer = New System.Windows.Forms.Button()
        Me.LabNotifs = New System.Windows.Forms.Label()
        Me.LabWelkom = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.PanNotifs.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.SeaGreen
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FlowLayoutPanel1.Controls.Add(Me.BtDéclarationDécès)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtRéserverCon)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtProlongation)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtConstatAbandon)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtConsulterDonnées)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(56, 115)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(651, 227)
        Me.FlowLayoutPanel1.TabIndex = 69
        '
        'BtDéclarationDécès
        '
        Me.BtDéclarationDécès.BackColor = System.Drawing.Color.SeaGreen
        Me.BtDéclarationDécès.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtDéclarationDécès.ForeColor = System.Drawing.Color.Transparent
        Me.BtDéclarationDécès.Location = New System.Drawing.Point(3, 3)
        Me.BtDéclarationDécès.Name = "BtDéclarationDécès"
        Me.BtDéclarationDécès.Size = New System.Drawing.Size(209, 101)
        Me.BtDéclarationDécès.TabIndex = 0
        Me.BtDéclarationDécès.Text = "Déclaration de décès"
        Me.BtDéclarationDécès.UseVisualStyleBackColor = False
        '
        'BtRéserverCon
        '
        Me.BtRéserverCon.BackColor = System.Drawing.Color.SeaGreen
        Me.BtRéserverCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.BtRéserverCon.ForeColor = System.Drawing.Color.Transparent
        Me.BtRéserverCon.Location = New System.Drawing.Point(218, 3)
        Me.BtRéserverCon.Name = "BtRéserverCon"
        Me.BtRéserverCon.Size = New System.Drawing.Size(209, 104)
        Me.BtRéserverCon.TabIndex = 1
        Me.BtRéserverCon.Text = "Réservation concession"
        Me.BtRéserverCon.UseVisualStyleBackColor = False
        '
        'BtProlongation
        '
        Me.BtProlongation.BackColor = System.Drawing.Color.SeaGreen
        Me.BtProlongation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.BtProlongation.ForeColor = System.Drawing.Color.Transparent
        Me.BtProlongation.Location = New System.Drawing.Point(433, 3)
        Me.BtProlongation.Name = "BtProlongation"
        Me.BtProlongation.Size = New System.Drawing.Size(209, 104)
        Me.BtProlongation.TabIndex = 2
        Me.BtProlongation.Text = "Prolongation de concession"
        Me.BtProlongation.UseVisualStyleBackColor = False
        '
        'BtConstatAbandon
        '
        Me.BtConstatAbandon.BackColor = System.Drawing.Color.SeaGreen
        Me.BtConstatAbandon.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.BtConstatAbandon.ForeColor = System.Drawing.Color.Transparent
        Me.BtConstatAbandon.Location = New System.Drawing.Point(90, 113)
        Me.BtConstatAbandon.Margin = New System.Windows.Forms.Padding(90, 3, 3, 3)
        Me.BtConstatAbandon.Name = "BtConstatAbandon"
        Me.BtConstatAbandon.Size = New System.Drawing.Size(209, 104)
        Me.BtConstatAbandon.TabIndex = 3
        Me.BtConstatAbandon.Text = "Accéder au Plan"
        Me.BtConstatAbandon.UseVisualStyleBackColor = False
        '
        'BtConsulterDonnées
        '
        Me.BtConsulterDonnées.BackColor = System.Drawing.Color.SeaGreen
        Me.BtConsulterDonnées.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.BtConsulterDonnées.ForeColor = System.Drawing.Color.Transparent
        Me.BtConsulterDonnées.Location = New System.Drawing.Point(342, 113)
        Me.BtConsulterDonnées.Margin = New System.Windows.Forms.Padding(40, 3, 3, 3)
        Me.BtConsulterDonnées.Name = "BtConsulterDonnées"
        Me.BtConsulterDonnées.Size = New System.Drawing.Size(209, 104)
        Me.BtConsulterDonnées.TabIndex = 4
        Me.BtConsulterDonnées.Text = "Consulter données"
        Me.BtConsulterDonnées.UseVisualStyleBackColor = False
        '
        'PanNotifs
        '
        Me.PanNotifs.BackColor = System.Drawing.Color.SeaGreen
        Me.PanNotifs.Controls.Add(Me.BtNotifsMontrer)
        Me.PanNotifs.Controls.Add(Me.BtNotifsMasquer)
        Me.PanNotifs.Controls.Add(Me.LabNotifs)
        Me.PanNotifs.Location = New System.Drawing.Point(-1, 407)
        Me.PanNotifs.Name = "PanNotifs"
        Me.PanNotifs.Size = New System.Drawing.Size(776, 100)
        Me.PanNotifs.TabIndex = 68
        '
        'BtNotifsMontrer
        '
        Me.BtNotifsMontrer.Location = New System.Drawing.Point(695, 74)
        Me.BtNotifsMontrer.Name = "BtNotifsMontrer"
        Me.BtNotifsMontrer.Size = New System.Drawing.Size(73, 23)
        Me.BtNotifsMontrer.TabIndex = 6
        Me.BtNotifsMontrer.Text = "Notifications"
        Me.BtNotifsMontrer.UseVisualStyleBackColor = True
        Me.BtNotifsMontrer.Visible = False
        '
        'BtNotifsMasquer
        '
        Me.BtNotifsMasquer.Location = New System.Drawing.Point(695, 5)
        Me.BtNotifsMasquer.Name = "BtNotifsMasquer"
        Me.BtNotifsMasquer.Size = New System.Drawing.Size(73, 23)
        Me.BtNotifsMasquer.TabIndex = 5
        Me.BtNotifsMasquer.Text = "Masquer"
        Me.BtNotifsMasquer.UseVisualStyleBackColor = True
        '
        'LabNotifs
        '
        Me.LabNotifs.AutoSize = True
        Me.LabNotifs.BackColor = System.Drawing.Color.Transparent
        Me.LabNotifs.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.LabNotifs.ForeColor = System.Drawing.Color.Transparent
        Me.LabNotifs.Location = New System.Drawing.Point(3, 6)
        Me.LabNotifs.Name = "LabNotifs"
        Me.LabNotifs.Size = New System.Drawing.Size(98, 18)
        Me.LabNotifs.TabIndex = 0
        Me.LabNotifs.Text = "Notifications :"
        '
        'LabWelkom
        '
        Me.LabWelkom.AutoSize = True
        Me.LabWelkom.BackColor = System.Drawing.Color.Transparent
        Me.LabWelkom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabWelkom.Location = New System.Drawing.Point(613, 1)
        Me.LabWelkom.Name = "LabWelkom"
        Me.LabWelkom.Size = New System.Drawing.Size(100, 18)
        Me.LabWelkom.TabIndex = 71
        Me.LabWelkom.Text = "Welkom User"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(716, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 50)
        Me.PictureBox1.TabIndex = 70
        Me.PictureBox1.TabStop = False
        '
        'FormHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.cimetiere.My.Resources.Resources.home3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(769, 504)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.PanNotifs)
        Me.Controls.Add(Me.LabWelkom)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(785, 543)
        Me.MinimumSize = New System.Drawing.Size(785, 543)
        Me.Name = "FormHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.PanNotifs.ResumeLayout(False)
        Me.PanNotifs.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents BtDéclarationDécès As Button
    Friend WithEvents BtRéserverCon As Button
    Friend WithEvents BtProlongation As Button
    Friend WithEvents BtConstatAbandon As Button
    Friend WithEvents BtConsulterDonnées As Button
    Friend WithEvents PanNotifs As Panel
    Public WithEvents BtNotifsMasquer As Button
    Friend WithEvents LabNotifs As Label
    Friend WithEvents LabWelkom As Label
    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents BtNotifsMontrer As Button
End Class
