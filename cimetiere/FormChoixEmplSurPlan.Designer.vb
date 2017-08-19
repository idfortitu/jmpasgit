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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormChoixEmplSurPlan))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.LbOccupants = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GbReservation = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbDateFin = New System.Windows.Forms.TextBox()
        Me.TbDateDebut = New System.Windows.Forms.TextBox()
        Me.TbCsnr = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgvEmpls = New cimetiere.DataGridViewCustom()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOccupants = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColMonumClasse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlanCimetiere1 = New cimetiere.PlanCimetiere()
        Me.GroupBox1.SuspendLayout()
        Me.GbReservation.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvEmpls, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'LbOccupants
        '
        Me.LbOccupants.FormattingEnabled = True
        Me.LbOccupants.IntegralHeight = False
        Me.LbOccupants.ItemHeight = 16
        Me.LbOccupants.Location = New System.Drawing.Point(6, 20)
        Me.LbOccupants.Name = "LbOccupants"
        Me.LbOccupants.Size = New System.Drawing.Size(258, 109)
        Me.LbOccupants.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LbOccupants)
        Me.GroupBox1.Location = New System.Drawing.Point(953, 437)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 135)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Occupants"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Emplacement réservé par"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "du"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(152, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "au"
        '
        'GbReservation
        '
        Me.GbReservation.Controls.Add(Me.Label6)
        Me.GbReservation.Controls.Add(Me.Label5)
        Me.GbReservation.Controls.Add(Me.Label4)
        Me.GbReservation.Controls.Add(Me.TbDateFin)
        Me.GbReservation.Controls.Add(Me.TbDateDebut)
        Me.GbReservation.Controls.Add(Me.TbCsnr)
        Me.GbReservation.Location = New System.Drawing.Point(732, 437)
        Me.GbReservation.Name = "GbReservation"
        Me.GbReservation.Size = New System.Drawing.Size(215, 135)
        Me.GbReservation.TabIndex = 11
        Me.GbReservation.TabStop = False
        Me.GbReservation.Text = "Réservation"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Réservé par"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "au"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "du"
        '
        'TbDateFin
        '
        Me.TbDateFin.Location = New System.Drawing.Point(33, 106)
        Me.TbDateFin.Name = "TbDateFin"
        Me.TbDateFin.ReadOnly = True
        Me.TbDateFin.Size = New System.Drawing.Size(110, 22)
        Me.TbDateFin.TabIndex = 2
        '
        'TbDateDebut
        '
        Me.TbDateDebut.Location = New System.Drawing.Point(35, 79)
        Me.TbDateDebut.Name = "TbDateDebut"
        Me.TbDateDebut.ReadOnly = True
        Me.TbDateDebut.Size = New System.Drawing.Size(108, 22)
        Me.TbDateDebut.TabIndex = 1
        '
        'TbCsnr
        '
        Me.TbCsnr.Location = New System.Drawing.Point(6, 46)
        Me.TbCsnr.Name = "TbCsnr"
        Me.TbCsnr.ReadOnly = True
        Me.TbCsnr.Size = New System.Drawing.Size(203, 22)
        Me.TbCsnr.TabIndex = 0
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
        'DgvEmpls
        '
        Me.DgvEmpls.AllowUserToAddRows = False
        Me.DgvEmpls.AllowUserToDeleteRows = False
        Me.DgvEmpls.AllowUserToOrderColumns = True
        Me.DgvEmpls.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvEmpls.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvEmpls.BackgroundColor = System.Drawing.Color.White
        Me.DgvEmpls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmpls.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.ColOccupants, Me.ColMonumClasse})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvEmpls.DefaultCellStyle = DataGridViewCellStyle1
        Me.DgvEmpls.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvEmpls.Location = New System.Drawing.Point(729, -1)
        Me.DgvEmpls.MultiSelect = False
        Me.DgvEmpls.Name = "DgvEmpls"
        Me.DgvEmpls.ReadOnly = True
        Me.DgvEmpls.RowHeadersVisible = False
        Me.DgvEmpls.RowTemplate.Height = 24
        Me.DgvEmpls.SelectedRow = Nothing
        Me.DgvEmpls.SelectedRowIndex = -1
        Me.DgvEmpls.SelectedValue = -1
        Me.DgvEmpls.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvEmpls.Size = New System.Drawing.Size(492, 432)
        Me.DgvEmpls.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "empl_reference"
        Me.Column1.HeaderText = "Réf."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'ColOccupants
        '
        Me.ColOccupants.HeaderText = "Occupants"
        Me.ColOccupants.Name = "ColOccupants"
        Me.ColOccupants.ReadOnly = True
        '
        'ColMonumClasse
        '
        Me.ColMonumClasse.DataPropertyName = "empl_monum_classe"
        Me.ColMonumClasse.HeaderText = "Classé"
        Me.ColMonumClasse.Name = "ColMonumClasse"
        Me.ColMonumClasse.ReadOnly = True
        '
        'PlanCimetiere1
        '
        Me.PlanCimetiere1.BackgroundImage = CType(resources.GetObject("PlanCimetiere1.BackgroundImage"), System.Drawing.Image)
        Me.PlanCimetiere1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlanCimetiere1.EmplSelect = Nothing
        Me.PlanCimetiere1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlanCimetiere1.IdEmplSelect = -1
        Me.PlanCimetiere1.Location = New System.Drawing.Point(11, -1)
        Me.PlanCimetiere1.Margin = New System.Windows.Forms.Padding(2)
        Me.PlanCimetiere1.Name = "PlanCimetiere1"
        Me.PlanCimetiere1.NomParcelleAffichee = "A1"
        Me.PlanCimetiere1.Size = New System.Drawing.Size(261, 515)
        Me.PlanCimetiere1.TabIndex = 0
        Me.PlanCimetiere1.Zoom = 1.0!
        '
        'FormChoixEmplSurPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1233, 605)
        Me.Controls.Add(Me.GbReservation)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgvEmpls)
        Me.Controls.Add(Me.PlanCimetiere1)
        Me.Name = "FormChoixEmplSurPlan"
        Me.Text = "FormChoixEmplSurPlan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GbReservation.ResumeLayout(False)
        Me.GbReservation.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DgvEmpls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PlanCimetiere1 As PlanCimetiere
    Friend WithEvents DgvEmpls As DataGridViewCustom
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents ColOccupants As DataGridViewTextBoxColumn
    Friend WithEvents ColMonumClasse As DataGridViewTextBoxColumn
    Friend WithEvents ListView1 As ListView
    Friend WithEvents LbOccupants As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GbReservation As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TbCsnr As TextBox
    Friend WithEvents TbDateDebut As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TbDateFin As TextBox
End Class
