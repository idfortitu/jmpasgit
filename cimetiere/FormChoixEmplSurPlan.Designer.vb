<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormChoixEmplSurPlan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormChoixEmplSurPlan))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtFermer = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CbMonumClasse = New System.Windows.Forms.CheckBox()
        Me.TbReference = New System.Windows.Forms.TextBox()
        Me.GbReservation = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbDateFin = New System.Windows.Forms.TextBox()
        Me.TbDateDebut = New System.Windows.Forms.TextBox()
        Me.TbCsnr = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LbOccupants = New System.Windows.Forms.ListBox()
        Me.PanInfos = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PlanCimConteneur1 = New cimetiere.PlanCimConteneur()
        Me.PlanCimetiere1 = New cimetiere.PlanCimetiere()
        Me.GroupBox2.SuspendLayout()
        Me.GbReservation.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PanInfos.SuspendLayout()
        Me.PlanCimConteneur1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(1063, 436)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(158, 120)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Emplacement réservé par"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "du"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(152, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "au"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(732, 437)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(300, 135)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Réservation"
        '
        'BtFermer
        '
        Me.BtFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtFermer.Location = New System.Drawing.Point(782, 445)
        Me.BtFermer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtFermer.Name = "BtFermer"
        Me.BtFermer.Size = New System.Drawing.Size(62, 26)
        Me.BtFermer.TabIndex = 21
        Me.BtFermer.Text = "Fermer"
        Me.BtFermer.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 15)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Référence :"
        '
        'CbMonumClasse
        '
        Me.CbMonumClasse.AutoSize = True
        Me.CbMonumClasse.Enabled = False
        Me.CbMonumClasse.Location = New System.Drawing.Point(14, 40)
        Me.CbMonumClasse.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CbMonumClasse.Name = "CbMonumClasse"
        Me.CbMonumClasse.Size = New System.Drawing.Size(109, 17)
        Me.CbMonumClasse.TabIndex = 16
        Me.CbMonumClasse.Text = "Monument classé"
        Me.CbMonumClasse.UseVisualStyleBackColor = True
        '
        'TbReference
        '
        Me.TbReference.Location = New System.Drawing.Point(77, 14)
        Me.TbReference.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbReference.Name = "TbReference"
        Me.TbReference.Size = New System.Drawing.Size(78, 20)
        Me.TbReference.TabIndex = 19
        '
        'GbReservation
        '
        Me.GbReservation.Controls.Add(Me.Label6)
        Me.GbReservation.Controls.Add(Me.Label5)
        Me.GbReservation.Controls.Add(Me.Label4)
        Me.GbReservation.Controls.Add(Me.TbDateFin)
        Me.GbReservation.Controls.Add(Me.TbDateDebut)
        Me.GbReservation.Controls.Add(Me.TbCsnr)
        Me.GbReservation.Location = New System.Drawing.Point(7, 202)
        Me.GbReservation.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GbReservation.Name = "GbReservation"
        Me.GbReservation.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GbReservation.Size = New System.Drawing.Size(196, 120)
        Me.GbReservation.TabIndex = 18
        Me.GbReservation.TabStop = False
        Me.GbReservation.Text = "Réservation :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 19)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Réservé par"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 86)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "au"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 64)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "du"
        '
        'TbDateFin
        '
        Me.TbDateFin.Location = New System.Drawing.Point(32, 86)
        Me.TbDateFin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbDateFin.Name = "TbDateFin"
        Me.TbDateFin.ReadOnly = True
        Me.TbDateFin.Size = New System.Drawing.Size(84, 20)
        Me.TbDateFin.TabIndex = 2
        '
        'TbDateDebut
        '
        Me.TbDateDebut.Location = New System.Drawing.Point(33, 64)
        Me.TbDateDebut.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbDateDebut.Name = "TbDateDebut"
        Me.TbDateDebut.ReadOnly = True
        Me.TbDateDebut.Size = New System.Drawing.Size(82, 20)
        Me.TbDateDebut.TabIndex = 1
        '
        'TbCsnr
        '
        Me.TbCsnr.Location = New System.Drawing.Point(11, 37)
        Me.TbCsnr.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbCsnr.Name = "TbCsnr"
        Me.TbCsnr.ReadOnly = True
        Me.TbCsnr.Size = New System.Drawing.Size(153, 20)
        Me.TbCsnr.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LbOccupants)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 66)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(201, 128)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Occupants :"
        '
        'LbOccupants
        '
        Me.LbOccupants.FormattingEnabled = True
        Me.LbOccupants.IntegralHeight = False
        Me.LbOccupants.Location = New System.Drawing.Point(4, 16)
        Me.LbOccupants.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LbOccupants.Name = "LbOccupants"
        Me.LbOccupants.Size = New System.Drawing.Size(194, 106)
        Me.LbOccupants.TabIndex = 3
        '
        'PanInfos
        '
        Me.PanInfos.Controls.Add(Me.Label7)
        Me.PanInfos.Controls.Add(Me.GroupBox1)
        Me.PanInfos.Controls.Add(Me.GbReservation)
        Me.PanInfos.Controls.Add(Me.TbReference)
        Me.PanInfos.Controls.Add(Me.CbMonumClasse)
        Me.PanInfos.Location = New System.Drawing.Point(704, 10)
        Me.PanInfos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanInfos.Name = "PanInfos"
        Me.PanInfos.Size = New System.Drawing.Size(212, 412)
        Me.PanInfos.TabIndex = 22
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(331, 442)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(6, 6)
        Me.Panel1.TabIndex = 23
        '
        'PlanCimConteneur1
        '
        Me.PlanCimConteneur1.AutoScroll = True
        Me.PlanCimConteneur1.Controls.Add(Me.PlanCimetiere1)
        Me.PlanCimConteneur1.Location = New System.Drawing.Point(9, 10)
        Me.PlanCimConteneur1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PlanCimConteneur1.Name = "PlanCimConteneur1"
        Me.PlanCimConteneur1.Size = New System.Drawing.Size(691, 472)
        Me.PlanCimConteneur1.TabIndex = 24
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
        Me.PlanCimetiere1.RefSelect = "-1"
        Me.PlanCimetiere1.SelectionEmplAuClic = True
        Me.PlanCimetiere1.Size = New System.Drawing.Size(456, 975)
        Me.PlanCimetiere1.TabIndex = 15
        Me.PlanCimetiere1.Zoom = 1.0!
        Me.PlanCimetiere1.ZoomableAvecRoulette = True
        '
        'FormChoixEmplSurPlan
        '
        Me.AcceptButton = Me.BtFermer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtFermer
        Me.ClientSize = New System.Drawing.Size(925, 492)
        Me.Controls.Add(Me.PlanCimConteneur1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanInfos)
        Me.Controls.Add(Me.BtFermer)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FormChoixEmplSurPlan"
        Me.Text = "FormChoixEmplSurPlan"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GbReservation.ResumeLayout(False)
        Me.GbReservation.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.PanInfos.ResumeLayout(False)
        Me.PanInfos.PerformLayout()
        Me.PlanCimConteneur1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PlanCimetiere1 As PlanCimetiere
    Friend WithEvents BtFermer As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents CbMonumClasse As CheckBox
    Friend WithEvents TbReference As TextBox
    Friend WithEvents GbReservation As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TbDateFin As TextBox
    Friend WithEvents TbDateDebut As TextBox
    Friend WithEvents TbCsnr As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LbOccupants As ListBox
    Friend WithEvents PanInfos As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PlanCimConteneur1 As PlanCimConteneur
End Class
