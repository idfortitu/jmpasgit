<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormVoirDetailsEmpl
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVoirDetailsEmpl))
        Me.LabTitre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbDateDebut = New System.Windows.Forms.TextBox()
        Me.TbDateFin = New System.Windows.Forms.TextBox()
        Me.LabRefEmpl = New System.Windows.Forms.Label()
        Me.TbCsnCom = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TbCsnrNom = New System.Windows.Forms.TextBox()
        Me.TbCsnrAdresse = New System.Windows.Forms.TextBox()
        Me.TbCsnrTel = New System.Windows.Forms.TextBox()
        Me.TbCsnrPrenom = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GbDefunts = New System.Windows.Forms.GroupBox()
        Me.DgvOccupants = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DgvBenefs = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbEmplHistoire = New System.Windows.Forms.TextBox()
        Me.GbCsnCom = New System.Windows.Forms.GroupBox()
        Me.GbEmplHistoire = New System.Windows.Forms.GroupBox()
        Me.BtRenouveler = New System.Windows.Forms.Button()
        Me.PanelInfosConcession = New System.Windows.Forms.Panel()
        Me.PlanCimConteneur1 = New cimetiere.PlanCimConteneur()
        Me.PlanCimetiere1 = New cimetiere.PlanCimetiere()
        Me.GroupBox1.SuspendLayout()
        Me.GbDefunts.SuspendLayout()
        CType(Me.DgvOccupants, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgvBenefs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbCsnCom.SuspendLayout()
        Me.GbEmplHistoire.SuspendLayout()
        Me.PanelInfosConcession.SuspendLayout()
        Me.PlanCimConteneur1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabTitre
        '
        Me.LabTitre.AutoSize = True
        Me.LabTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.8!)
        Me.LabTitre.Location = New System.Drawing.Point(48, 11)
        Me.LabTitre.Name = "LabTitre"
        Me.LabTitre.Size = New System.Drawing.Size(261, 18)
        Me.LabTitre.TabIndex = 1
        Me.LabTitre.Text = "Réservation portant sur l'emplacement"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Entamée le"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Et prenant fin le"
        '
        'TbDateDebut
        '
        Me.TbDateDebut.Location = New System.Drawing.Point(133, 9)
        Me.TbDateDebut.Name = "TbDateDebut"
        Me.TbDateDebut.ReadOnly = True
        Me.TbDateDebut.Size = New System.Drawing.Size(100, 22)
        Me.TbDateDebut.TabIndex = 4
        '
        'TbDateFin
        '
        Me.TbDateFin.Location = New System.Drawing.Point(133, 43)
        Me.TbDateFin.Name = "TbDateFin"
        Me.TbDateFin.ReadOnly = True
        Me.TbDateFin.Size = New System.Drawing.Size(100, 22)
        Me.TbDateFin.TabIndex = 5
        '
        'LabRefEmpl
        '
        Me.LabRefEmpl.AutoSize = True
        Me.LabRefEmpl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabRefEmpl.Location = New System.Drawing.Point(104, 39)
        Me.LabRefEmpl.Name = "LabRefEmpl"
        Me.LabRefEmpl.Size = New System.Drawing.Size(101, 25)
        Me.LabRefEmpl.TabIndex = 6
        Me.LabRefEmpl.Text = "Référence"
        '
        'TbCsnCom
        '
        Me.TbCsnCom.Location = New System.Drawing.Point(5, 23)
        Me.TbCsnCom.Multiline = True
        Me.TbCsnCom.Name = "TbCsnCom"
        Me.TbCsnCom.ReadOnly = True
        Me.TbCsnCom.Size = New System.Drawing.Size(388, 105)
        Me.TbCsnCom.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TbCsnrNom)
        Me.GroupBox1.Controls.Add(Me.TbCsnrAdresse)
        Me.GroupBox1.Controls.Add(Me.TbCsnrTel)
        Me.GroupBox1.Controls.Add(Me.TbCsnrPrenom)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(398, 177)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Concessionnaire"
        '
        'TbCsnrNom
        '
        Me.TbCsnrNom.Location = New System.Drawing.Point(128, 58)
        Me.TbCsnrNom.Name = "TbCsnrNom"
        Me.TbCsnrNom.ReadOnly = True
        Me.TbCsnrNom.Size = New System.Drawing.Size(264, 22)
        Me.TbCsnrNom.TabIndex = 7
        '
        'TbCsnrAdresse
        '
        Me.TbCsnrAdresse.Location = New System.Drawing.Point(128, 116)
        Me.TbCsnrAdresse.Multiline = True
        Me.TbCsnrAdresse.Name = "TbCsnrAdresse"
        Me.TbCsnrAdresse.ReadOnly = True
        Me.TbCsnrAdresse.Size = New System.Drawing.Size(264, 50)
        Me.TbCsnrAdresse.TabIndex = 6
        '
        'TbCsnrTel
        '
        Me.TbCsnrTel.Location = New System.Drawing.Point(128, 88)
        Me.TbCsnrTel.Name = "TbCsnrTel"
        Me.TbCsnrTel.ReadOnly = True
        Me.TbCsnrTel.Size = New System.Drawing.Size(264, 22)
        Me.TbCsnrTel.TabIndex = 5
        '
        'TbCsnrPrenom
        '
        Me.TbCsnrPrenom.Location = New System.Drawing.Point(128, 30)
        Me.TbCsnrPrenom.Name = "TbCsnrPrenom"
        Me.TbCsnrPrenom.ReadOnly = True
        Me.TbCsnrPrenom.Size = New System.Drawing.Size(264, 22)
        Me.TbCsnrPrenom.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 17)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Nom de famille"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Adresse"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Téléphone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Prénom"
        '
        'GbDefunts
        '
        Me.GbDefunts.Controls.Add(Me.DgvOccupants)
        Me.GbDefunts.Location = New System.Drawing.Point(430, 412)
        Me.GbDefunts.Name = "GbDefunts"
        Me.GbDefunts.Size = New System.Drawing.Size(644, 172)
        Me.GbDefunts.TabIndex = 9
        Me.GbDefunts.TabStop = False
        Me.GbDefunts.Text = "Défunts"
        '
        'DgvOccupants
        '
        Me.DgvOccupants.AllowUserToAddRows = False
        Me.DgvOccupants.AllowUserToDeleteRows = False
        Me.DgvOccupants.AllowUserToOrderColumns = True
        Me.DgvOccupants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvOccupants.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvOccupants.BackgroundColor = System.Drawing.Color.White
        Me.DgvOccupants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvOccupants.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column4, Me.Column1, Me.Column2})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvOccupants.DefaultCellStyle = DataGridViewCellStyle1
        Me.DgvOccupants.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvOccupants.Location = New System.Drawing.Point(6, 22)
        Me.DgvOccupants.MultiSelect = False
        Me.DgvOccupants.Name = "DgvOccupants"
        Me.DgvOccupants.ReadOnly = True
        Me.DgvOccupants.RowHeadersVisible = False
        Me.DgvOccupants.RowTemplate.Height = 24
        Me.DgvOccupants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvOccupants.Size = New System.Drawing.Size(632, 141)
        Me.DgvOccupants.TabIndex = 0
        '
        'Column3
        '
        Me.Column3.FillWeight = 120.0!
        Me.Column3.HeaderText = "Nom"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "État civil"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.FillWeight = 50.0!
        Me.Column1.HeaderText = "Code déf."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.FillWeight = 50.0!
        Me.Column2.HeaderText = "N° ordre"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DgvBenefs)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 344)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(398, 172)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Bénéficiaires"
        '
        'DgvBenefs
        '
        Me.DgvBenefs.AllowUserToAddRows = False
        Me.DgvBenefs.AllowUserToDeleteRows = False
        Me.DgvBenefs.AllowUserToOrderColumns = True
        Me.DgvBenefs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvBenefs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvBenefs.BackgroundColor = System.Drawing.Color.White
        Me.DgvBenefs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBenefs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column6})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvBenefs.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvBenefs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvBenefs.Location = New System.Drawing.Point(6, 22)
        Me.DgvBenefs.MultiSelect = False
        Me.DgvBenefs.Name = "DgvBenefs"
        Me.DgvBenefs.ReadOnly = True
        Me.DgvBenefs.RowHeadersVisible = False
        Me.DgvBenefs.RowTemplate.Height = 24
        Me.DgvBenefs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvBenefs.Size = New System.Drawing.Size(386, 141)
        Me.DgvBenefs.TabIndex = 1
        '
        'Column5
        '
        Me.Column5.HeaderText = "Nom"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Lien de parenté"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'TbEmplHistoire
        '
        Me.TbEmplHistoire.Location = New System.Drawing.Point(5, 21)
        Me.TbEmplHistoire.Multiline = True
        Me.TbEmplHistoire.Name = "TbEmplHistoire"
        Me.TbEmplHistoire.ReadOnly = True
        Me.TbEmplHistoire.Size = New System.Drawing.Size(634, 110)
        Me.TbEmplHistoire.TabIndex = 11
        '
        'GbCsnCom
        '
        Me.GbCsnCom.Controls.Add(Me.TbCsnCom)
        Me.GbCsnCom.Location = New System.Drawing.Point(5, 522)
        Me.GbCsnCom.Name = "GbCsnCom"
        Me.GbCsnCom.Size = New System.Drawing.Size(398, 135)
        Me.GbCsnCom.TabIndex = 12
        Me.GbCsnCom.TabStop = False
        Me.GbCsnCom.Text = "Commentaire éventuel sur la réservation"
        '
        'GbEmplHistoire
        '
        Me.GbEmplHistoire.Controls.Add(Me.TbEmplHistoire)
        Me.GbEmplHistoire.Location = New System.Drawing.Point(430, 590)
        Me.GbEmplHistoire.Name = "GbEmplHistoire"
        Me.GbEmplHistoire.Size = New System.Drawing.Size(644, 137)
        Me.GbEmplHistoire.TabIndex = 1
        Me.GbEmplHistoire.TabStop = False
        Me.GbEmplHistoire.Text = "Informations supplémentaires"
        '
        'BtRenouveler
        '
        Me.BtRenouveler.Location = New System.Drawing.Point(249, 20)
        Me.BtRenouveler.Name = "BtRenouveler"
        Me.BtRenouveler.Size = New System.Drawing.Size(154, 45)
        Me.BtRenouveler.TabIndex = 13
        Me.BtRenouveler.Text = "Renouveler maintenant"
        Me.BtRenouveler.UseVisualStyleBackColor = True
        '
        'PanelInfosConcession
        '
        Me.PanelInfosConcession.Controls.Add(Me.BtRenouveler)
        Me.PanelInfosConcession.Controls.Add(Me.Label2)
        Me.PanelInfosConcession.Controls.Add(Me.Label3)
        Me.PanelInfosConcession.Controls.Add(Me.GbCsnCom)
        Me.PanelInfosConcession.Controls.Add(Me.TbDateDebut)
        Me.PanelInfosConcession.Controls.Add(Me.GroupBox3)
        Me.PanelInfosConcession.Controls.Add(Me.TbDateFin)
        Me.PanelInfosConcession.Controls.Add(Me.GroupBox1)
        Me.PanelInfosConcession.Location = New System.Drawing.Point(10, 68)
        Me.PanelInfosConcession.Name = "PanelInfosConcession"
        Me.PanelInfosConcession.Size = New System.Drawing.Size(412, 653)
        Me.PanelInfosConcession.TabIndex = 14
        '
        'PlanCimConteneur1
        '
        Me.PlanCimConteneur1.AutoScroll = True
        Me.PlanCimConteneur1.BackColor = System.Drawing.SystemColors.Window
        Me.PlanCimConteneur1.Controls.Add(Me.PlanCimetiere1)
        Me.PlanCimConteneur1.Location = New System.Drawing.Point(430, 0)
        Me.PlanCimConteneur1.Name = "PlanCimConteneur1"
        Me.PlanCimConteneur1.Size = New System.Drawing.Size(638, 410)
        Me.PlanCimConteneur1.TabIndex = 0
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
        Me.PlanCimetiere1.SelectionEmplAuClic = False
        Me.PlanCimetiere1.Size = New System.Drawing.Size(290, 573)
        Me.PlanCimetiere1.TabIndex = 0
        Me.PlanCimetiere1.Zoom = 1.0!
        Me.PlanCimetiere1.ZoomableAvecRoulette = True
        '
        'FormVoirDetailsEmpl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 764)
        Me.Controls.Add(Me.GbEmplHistoire)
        Me.Controls.Add(Me.GbDefunts)
        Me.Controls.Add(Me.LabRefEmpl)
        Me.Controls.Add(Me.LabTitre)
        Me.Controls.Add(Me.PlanCimConteneur1)
        Me.Controls.Add(Me.PanelInfosConcession)
        Me.Name = "FormVoirDetailsEmpl"
        Me.Text = " "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GbDefunts.ResumeLayout(False)
        CType(Me.DgvOccupants, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DgvBenefs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbCsnCom.ResumeLayout(False)
        Me.GbCsnCom.PerformLayout()
        Me.GbEmplHistoire.ResumeLayout(False)
        Me.GbEmplHistoire.PerformLayout()
        Me.PanelInfosConcession.ResumeLayout(False)
        Me.PanelInfosConcession.PerformLayout()
        Me.PlanCimConteneur1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PlanCimConteneur1 As PlanCimConteneur
    Friend WithEvents PlanCimetiere1 As PlanCimetiere
    Friend WithEvents LabTitre As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TbDateDebut As TextBox
    Friend WithEvents TbDateFin As TextBox
    Friend WithEvents LabRefEmpl As Label
    Friend WithEvents TbCsnCom As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TbCsnrNom As TextBox
    Friend WithEvents TbCsnrAdresse As TextBox
    Friend WithEvents TbCsnrTel As TextBox
    Friend WithEvents TbCsnrPrenom As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GbDefunts As GroupBox
    Friend WithEvents DgvOccupants As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DgvBenefs As DataGridView
    Friend WithEvents TbEmplHistoire As TextBox
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents GbCsnCom As GroupBox
    Friend WithEvents GbEmplHistoire As GroupBox
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents BtRenouveler As Button
    Friend WithEvents PanelInfosConcession As Panel
End Class
