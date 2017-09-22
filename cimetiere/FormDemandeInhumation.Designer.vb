<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDemandeInhumation
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDemandeInhumation))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.LabTitreP1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabP2ConExis = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BtPrécédentDeConExis = New System.Windows.Forms.Button()
        Me.BtTerminerConExis = New System.Windows.Forms.Button()
        Me.TabP2InhOrd = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BtPrecedentDeInhOrd = New System.Windows.Forms.Button()
        Me.BtTerminerInhOrd = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtPrécédentDeConExit = New System.Windows.Forms.Button()
        Me.Panel4 = New cimetiere.PanBordure()
        Me.TbNumAnnee = New cimetiere.TextBoxInt()
        Me.TbDefNumLh = New cimetiere.TextBoxInt()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbDefLieuDeces = New System.Windows.Forms.TextBox()
        Me.TbDefDateDeces = New cimetiere.TextBoxDate()
        Me.TbDefDateNaiss = New cimetiere.TextBoxDate()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CtrlDefEtatCiv = New cimetiere.CtrlEtatCivil()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CtrlDefLocvillepays = New cimetiere.CtrlLocVillePays()
        Me.TbDefLieuNaiss = New System.Windows.Forms.TextBox()
        Me.FPLLieuNaiss = New System.Windows.Forms.Label()
        Me.TbDefAdresse = New System.Windows.Forms.TextBox()
        Me.FPLAdresse = New System.Windows.Forms.Label()
        Me.TbDefPrenom = New System.Windows.Forms.TextBox()
        Me.FPLDateM = New System.Windows.Forms.Label()
        Me.FPLPrenom = New System.Windows.Forms.Label()
        Me.FPLDateNaiss = New System.Windows.Forms.Label()
        Me.TbDefNom = New System.Windows.Forms.TextBox()
        Me.FPLNom = New System.Windows.Forms.Label()
        Me.Panel1 = New cimetiere.PanBordure()
        Me.LbTypeInhOrd = New System.Windows.Forms.ListBox()
        Me.RbInhOrd = New System.Windows.Forms.RadioButton()
        Me.RbNouvelleCon = New System.Windows.Forms.RadioButton()
        Me.RbConcExis = New System.Windows.Forms.RadioButton()
        Me.Panel11 = New cimetiere.PanBordure()
        Me.TbDmdrTel = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CtrlVilleDmdr = New cimetiere.CtrlLocVillePays()
        Me.TbDmdrNom = New System.Windows.Forms.TextBox()
        Me.TbDmdrAdresse = New System.Windows.Forms.TextBox()
        Me.TbDmdrPrenom = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel13 = New cimetiere.PanBordure()
        Me.CbPCont = New System.Windows.Forms.CheckBox()
        Me.TbPcontTel = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CtrlLocPcont = New cimetiere.CtrlLocVillePays()
        Me.TbPcontNom = New System.Windows.Forms.TextBox()
        Me.TbPcontAdresse = New System.Windows.Forms.TextBox()
        Me.TbPcontPrenom = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel6 = New cimetiere.PanBordure()
        Me.CbEnregPdfP1 = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DtpDateSign = New System.Windows.Forms.DateTimePicker()
        Me.BtSuivant = New System.Windows.Forms.Button()
        Me.PanBordure1 = New cimetiere.PanBordure()
        Me.BtMontrerFormPlanCimCsnsExist = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LvCsnExisBenefs = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TbFiltreCsnsExist = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LvCsnExistOccupants = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtViderFiltreCsnsExist = New System.Windows.Forms.Button()
        Me.DgvCsnsExist = New cimetiere.DataGridViewConcessions()
        Me.DgvCsnsExistColEmplId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvCsnsExistColOccupants = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LbTypeInhCsnExis = New System.Windows.Forms.ListBox()
        Me.Panel7 = New cimetiere.PanBordure()
        Me.CbEnregPdfCsnExis = New System.Windows.Forms.CheckBox()
        Me.PanBordure2 = New cimetiere.PanBordure()
        Me.TbFiltreEmpls = New System.Windows.Forms.TextBox()
        Me.DgvEmplacementsPourInhOrd = New cimetiere.DataGridViewCustom()
        Me.DgvEmplsOrdColEmplId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvEmplsInhOrdOccupants = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvEmplsInhOrdClasse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtMontrerFormPlancimEmplOrd = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LvOccupantsInhOrdEmpl = New System.Windows.Forms.ListView()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtViderFiltreEmpls = New System.Windows.Forms.Button()
        Me.Panel8 = New cimetiere.PanBordure()
        Me.CbEnregPdfInhOrd = New System.Windows.Forms.CheckBox()
        Me.CtrlLocVillePays1 = New cimetiere.CtrlLocVillePays()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabP2ConExis.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabP2InhOrd.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.PanBordure1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvCsnsExist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.PanBordure2.SuspendLayout()
        CType(Me.DgvEmplacementsPourInhOrd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Controls.Add(Me.PictureBox3)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabTitreP1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel4)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel11)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel13)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel6)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1059, 820)
        Me.FlowLayoutPanel1.TabIndex = 146
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(148, 95)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 151
        Me.PictureBox3.TabStop = False
        '
        'LabTitreP1
        '
        Me.FlowLayoutPanel1.SetFlowBreak(Me.LabTitreP1, True)
        Me.LabTitreP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabTitreP1.Location = New System.Drawing.Point(156, 0)
        Me.LabTitreP1.Margin = New System.Windows.Forms.Padding(0)
        Me.LabTitreP1.Name = "LabTitreP1"
        Me.LabTitreP1.Size = New System.Drawing.Size(539, 99)
        Me.LabTitreP1.TabIndex = 152
        Me.LabTitreP1.Text = "Enregistrer une inhumation"
        Me.LabTitreP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabP2ConExis)
        Me.TabControl1.Controls.Add(Me.TabP2InhOrd)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(0, 0)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1067, 849)
        Me.TabControl1.TabIndex = 147
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.FlowLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1059, 820)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Début"
        '
        'TabP2ConExis
        '
        Me.TabP2ConExis.AutoScroll = True
        Me.TabP2ConExis.BackColor = System.Drawing.Color.White
        Me.TabP2ConExis.Controls.Add(Me.PictureBox1)
        Me.TabP2ConExis.Controls.Add(Me.Label15)
        Me.TabP2ConExis.Controls.Add(Me.BtPrécédentDeConExis)
        Me.TabP2ConExis.Controls.Add(Me.BtTerminerConExis)
        Me.TabP2ConExis.Controls.Add(Me.PanBordure1)
        Me.TabP2ConExis.Controls.Add(Me.Panel7)
        Me.TabP2ConExis.Location = New System.Drawing.Point(4, 25)
        Me.TabP2ConExis.Margin = New System.Windows.Forms.Padding(0)
        Me.TabP2ConExis.Name = "TabP2ConExis"
        Me.TabP2ConExis.Size = New System.Drawing.Size(1059, 820)
        Me.TabP2ConExis.TabIndex = 3
        Me.TabP2ConExis.Text = "fin concexis"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 7)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(148, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 192
        Me.PictureBox1.TabStop = False
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(159, 3)
        Me.Label15.Margin = New System.Windows.Forms.Padding(0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(539, 99)
        Me.Label15.TabIndex = 193
        Me.Label15.Text = "Enregistrer une inhumation"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtPrécédentDeConExis
        '
        Me.BtPrécédentDeConExis.BackColor = System.Drawing.Color.SeaGreen
        Me.BtPrécédentDeConExis.ForeColor = System.Drawing.Color.Transparent
        Me.BtPrécédentDeConExis.Location = New System.Drawing.Point(542, 827)
        Me.BtPrécédentDeConExis.Margin = New System.Windows.Forms.Padding(4)
        Me.BtPrécédentDeConExis.Name = "BtPrécédentDeConExis"
        Me.BtPrécédentDeConExis.Size = New System.Drawing.Size(132, 59)
        Me.BtPrécédentDeConExis.TabIndex = 182
        Me.BtPrécédentDeConExis.Text = "Précédent"
        Me.BtPrécédentDeConExis.UseVisualStyleBackColor = False
        '
        'BtTerminerConExis
        '
        Me.BtTerminerConExis.BackColor = System.Drawing.Color.SeaGreen
        Me.BtTerminerConExis.ForeColor = System.Drawing.Color.Transparent
        Me.BtTerminerConExis.Location = New System.Drawing.Point(712, 827)
        Me.BtTerminerConExis.Margin = New System.Windows.Forms.Padding(4)
        Me.BtTerminerConExis.Name = "BtTerminerConExis"
        Me.BtTerminerConExis.Size = New System.Drawing.Size(132, 59)
        Me.BtTerminerConExis.TabIndex = 172
        Me.BtTerminerConExis.Text = "Terminer"
        Me.BtTerminerConExis.UseVisualStyleBackColor = False
        '
        'TabP2InhOrd
        '
        Me.TabP2InhOrd.AutoScroll = True
        Me.TabP2InhOrd.BackColor = System.Drawing.Color.White
        Me.TabP2InhOrd.Controls.Add(Me.PanBordure2)
        Me.TabP2InhOrd.Controls.Add(Me.PictureBox2)
        Me.TabP2InhOrd.Controls.Add(Me.Label16)
        Me.TabP2InhOrd.Controls.Add(Me.BtPrecedentDeInhOrd)
        Me.TabP2InhOrd.Controls.Add(Me.BtTerminerInhOrd)
        Me.TabP2InhOrd.Controls.Add(Me.Panel8)
        Me.TabP2InhOrd.Location = New System.Drawing.Point(4, 25)
        Me.TabP2InhOrd.Margin = New System.Windows.Forms.Padding(0)
        Me.TabP2InhOrd.Name = "TabP2InhOrd"
        Me.TabP2InhOrd.Size = New System.Drawing.Size(1059, 820)
        Me.TabP2InhOrd.TabIndex = 4
        Me.TabP2InhOrd.Text = "TabP2InhOrd"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(7, 7)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(148, 95)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 192
        Me.PictureBox2.TabStop = False
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(159, 3)
        Me.Label16.Margin = New System.Windows.Forms.Padding(0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(539, 99)
        Me.Label16.TabIndex = 193
        Me.Label16.Text = "Enregistrer une inhumation"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtPrecedentDeInhOrd
        '
        Me.BtPrecedentDeInhOrd.BackColor = System.Drawing.Color.SeaGreen
        Me.BtPrecedentDeInhOrd.ForeColor = System.Drawing.Color.Transparent
        Me.BtPrecedentDeInhOrd.Location = New System.Drawing.Point(508, 660)
        Me.BtPrecedentDeInhOrd.Margin = New System.Windows.Forms.Padding(4)
        Me.BtPrecedentDeInhOrd.Name = "BtPrecedentDeInhOrd"
        Me.BtPrecedentDeInhOrd.Size = New System.Drawing.Size(132, 56)
        Me.BtPrecedentDeInhOrd.TabIndex = 186
        Me.BtPrecedentDeInhOrd.Text = "Précédent"
        Me.BtPrecedentDeInhOrd.UseVisualStyleBackColor = False
        '
        'BtTerminerInhOrd
        '
        Me.BtTerminerInhOrd.BackColor = System.Drawing.Color.SeaGreen
        Me.BtTerminerInhOrd.ForeColor = System.Drawing.Color.Transparent
        Me.BtTerminerInhOrd.Location = New System.Drawing.Point(706, 661)
        Me.BtTerminerInhOrd.Margin = New System.Windows.Forms.Padding(4)
        Me.BtTerminerInhOrd.Name = "BtTerminerInhOrd"
        Me.BtTerminerInhOrd.Size = New System.Drawing.Size(132, 55)
        Me.BtTerminerInhOrd.TabIndex = 184
        Me.BtTerminerInhOrd.Text = "Terminer"
        Me.BtTerminerInhOrd.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(337, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(171, 22)
        Me.TextBox1.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SeaGreen
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(543, 693)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 59)
        Me.Button1.TabIndex = 182
        Me.Button1.Text = "Précédent"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtPrécédentDeConExit
        '
        Me.BtPrécédentDeConExit.BackColor = System.Drawing.Color.SeaGreen
        Me.BtPrécédentDeConExit.ForeColor = System.Drawing.Color.Transparent
        Me.BtPrécédentDeConExit.Location = New System.Drawing.Point(543, 693)
        Me.BtPrécédentDeConExit.Margin = New System.Windows.Forms.Padding(4)
        Me.BtPrécédentDeConExit.Name = "BtPrécédentDeConExit"
        Me.BtPrécédentDeConExit.Size = New System.Drawing.Size(132, 59)
        Me.BtPrécédentDeConExit.TabIndex = 182
        Me.BtPrécédentDeConExit.Text = "Précédent"
        Me.BtPrécédentDeConExit.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.Controls.Add(Me.TbNumAnnee)
        Me.Panel4.Controls.Add(Me.TbDefNumLh)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.TbDefLieuDeces)
        Me.Panel4.Controls.Add(Me.TbDefDateDeces)
        Me.Panel4.Controls.Add(Me.TbDefDateNaiss)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.CtrlDefEtatCiv)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.CtrlDefLocvillepays)
        Me.Panel4.Controls.Add(Me.TbDefLieuNaiss)
        Me.Panel4.Controls.Add(Me.FPLLieuNaiss)
        Me.Panel4.Controls.Add(Me.TbDefAdresse)
        Me.Panel4.Controls.Add(Me.FPLAdresse)
        Me.Panel4.Controls.Add(Me.TbDefPrenom)
        Me.Panel4.Controls.Add(Me.FPLDateM)
        Me.Panel4.Controls.Add(Me.FPLPrenom)
        Me.Panel4.Controls.Add(Me.FPLDateNaiss)
        Me.Panel4.Controls.Add(Me.TbDefNom)
        Me.Panel4.Controls.Add(Me.FPLNom)
        Me.Panel4.CouleurBordure = System.Drawing.Color.SeaGreen
        Me.Panel4.EpaisseurBordure = 7
        Me.FlowLayoutPanel1.SetFlowBreak(Me.Panel4, True)
        Me.Panel4.Location = New System.Drawing.Point(4, 107)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(691, 341)
        Me.Panel4.TabIndex = 0
        Me.Panel4.Texte = "Informations du défunt"
        '
        'TbNumAnnee
        '
        Me.TbNumAnnee.Location = New System.Drawing.Point(428, 39)
        Me.TbNumAnnee.Name = "TbNumAnnee"
        Me.TbNumAnnee.Size = New System.Drawing.Size(129, 22)
        Me.TbNumAnnee.TabIndex = 2
        Me.TbNumAnnee.Value = Nothing
        Me.TbNumAnnee.Visible = False
        '
        'TbDefNumLh
        '
        Me.TbDefNumLh.Location = New System.Drawing.Point(126, 39)
        Me.TbDefNumLh.Name = "TbDefNumLh"
        Me.TbDefNumLh.Size = New System.Drawing.Size(133, 22)
        Me.TbDefNumLh.TabIndex = 0
        Me.TbDefNumLh.Value = Nothing
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(324, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 17)
        Me.Label5.TabIndex = 149
        Me.Label5.Text = "Num. année :"
        Me.Label5.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 17)
        Me.Label3.TabIndex = 148
        Me.Label3.Text = "Code défunt :"
        '
        'TbDefLieuDeces
        '
        Me.TbDefLieuDeces.Location = New System.Drawing.Point(428, 246)
        Me.TbDefLieuDeces.Margin = New System.Windows.Forms.Padding(4)
        Me.TbDefLieuDeces.Name = "TbDefLieuDeces"
        Me.TbDefLieuDeces.Size = New System.Drawing.Size(189, 22)
        Me.TbDefLieuDeces.TabIndex = 10
        '
        'TbDefDateDeces
        '
        Me.TbDefDateDeces.DateValue = Nothing
        Me.TbDefDateDeces.Location = New System.Drawing.Point(126, 246)
        Me.TbDefDateDeces.Mask = "00/00/0000"
        Me.TbDefDateDeces.Name = "TbDefDateDeces"
        Me.TbDefDateDeces.Size = New System.Drawing.Size(100, 22)
        Me.TbDefDateDeces.TabIndex = 9
        Me.TbDefDateDeces.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbDefDateNaiss
        '
        Me.TbDefDateNaiss.DateValue = Nothing
        Me.TbDefDateNaiss.Location = New System.Drawing.Point(126, 205)
        Me.TbDefDateNaiss.Mask = "00/00/0000"
        Me.TbDefDateNaiss.Name = "TbDefDateNaiss"
        Me.TbDefDateNaiss.Size = New System.Drawing.Size(100, 22)
        Me.TbDefDateNaiss.TabIndex = 7
        Me.TbDefDateNaiss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 248)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 144
        Me.Label4.Text = "Décédé le :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 290)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 143
        Me.Label2.Text = "Etat civil :"
        '
        'CtrlDefEtatCiv
        '
        Me.CtrlDefEtatCiv.EtatCivil = 0
        Me.CtrlDefEtatCiv.EtatCivilDe = ""
        Me.CtrlDefEtatCiv.LectureSeule = False
        Me.CtrlDefEtatCiv.Location = New System.Drawing.Point(126, 287)
        Me.CtrlDefEtatCiv.Name = "CtrlDefEtatCiv"
        Me.CtrlDefEtatCiv.osef = Nothing
        Me.CtrlDefEtatCiv.Size = New System.Drawing.Size(369, 24)
        Me.CtrlDefEtatCiv.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 167)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 141
        Me.Label1.Text = "Ville :"
        '
        'CtrlDefLocvillepays
        '
        Me.CtrlDefLocvillepays.LectureSeule = False
        Me.CtrlDefLocvillepays.Location = New System.Drawing.Point(126, 163)
        Me.CtrlDefLocvillepays.LocVilleId = -1
        Me.CtrlDefLocvillepays.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CtrlDefLocvillepays.Name = "CtrlDefLocvillepays"
        Me.CtrlDefLocvillepays.osef = Nothing
        Me.CtrlDefLocvillepays.Size = New System.Drawing.Size(316, 25)
        Me.CtrlDefLocvillepays.TabIndex = 6
        '
        'TbDefLieuNaiss
        '
        Me.TbDefLieuNaiss.Location = New System.Drawing.Point(428, 205)
        Me.TbDefLieuNaiss.Margin = New System.Windows.Forms.Padding(4)
        Me.TbDefLieuNaiss.Name = "TbDefLieuNaiss"
        Me.TbDefLieuNaiss.Size = New System.Drawing.Size(189, 22)
        Me.TbDefLieuNaiss.TabIndex = 8
        '
        'FPLLieuNaiss
        '
        Me.FPLLieuNaiss.AutoSize = True
        Me.FPLLieuNaiss.Location = New System.Drawing.Point(371, 207)
        Me.FPLLieuNaiss.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FPLLieuNaiss.Name = "FPLLieuNaiss"
        Me.FPLLieuNaiss.Size = New System.Drawing.Size(46, 17)
        Me.FPLLieuNaiss.TabIndex = 138
        Me.FPLLieuNaiss.Text = "Né à :"
        '
        'TbDefAdresse
        '
        Me.TbDefAdresse.Location = New System.Drawing.Point(126, 122)
        Me.TbDefAdresse.Margin = New System.Windows.Forms.Padding(4)
        Me.TbDefAdresse.Name = "TbDefAdresse"
        Me.TbDefAdresse.Size = New System.Drawing.Size(201, 22)
        Me.TbDefAdresse.TabIndex = 5
        '
        'FPLAdresse
        '
        Me.FPLAdresse.AutoSize = True
        Me.FPLAdresse.Location = New System.Drawing.Point(44, 126)
        Me.FPLAdresse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FPLAdresse.Name = "FPLAdresse"
        Me.FPLAdresse.Size = New System.Drawing.Size(68, 17)
        Me.FPLAdresse.TabIndex = 130
        Me.FPLAdresse.Text = "Adresse :"
        '
        'TbDefPrenom
        '
        Me.TbDefPrenom.Location = New System.Drawing.Point(428, 89)
        Me.TbDefPrenom.Margin = New System.Windows.Forms.Padding(4)
        Me.TbDefPrenom.Name = "TbDefPrenom"
        Me.TbDefPrenom.Size = New System.Drawing.Size(189, 22)
        Me.TbDefPrenom.TabIndex = 4
        '
        'FPLDateM
        '
        Me.FPLDateM.AutoSize = True
        Me.FPLDateM.Location = New System.Drawing.Point(340, 249)
        Me.FPLDateM.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FPLDateM.Name = "FPLDateM"
        Me.FPLDateM.Size = New System.Drawing.Size(77, 17)
        Me.FPLDateM.TabIndex = 123
        Me.FPLDateM.Text = "Décédé à :"
        '
        'FPLPrenom
        '
        Me.FPLPrenom.AutoSize = True
        Me.FPLPrenom.Location = New System.Drawing.Point(355, 89)
        Me.FPLPrenom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FPLPrenom.Name = "FPLPrenom"
        Me.FPLPrenom.Size = New System.Drawing.Size(65, 17)
        Me.FPLPrenom.TabIndex = 122
        Me.FPLPrenom.Text = "Prénom :"
        '
        'FPLDateNaiss
        '
        Me.FPLDateNaiss.AutoSize = True
        Me.FPLDateNaiss.Location = New System.Drawing.Point(62, 206)
        Me.FPLDateNaiss.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FPLDateNaiss.Name = "FPLDateNaiss"
        Me.FPLDateNaiss.Size = New System.Drawing.Size(49, 17)
        Me.FPLDateNaiss.TabIndex = 116
        Me.FPLDateNaiss.Text = "Né le :"
        '
        'TbDefNom
        '
        Me.TbDefNom.Location = New System.Drawing.Point(126, 81)
        Me.TbDefNom.Margin = New System.Windows.Forms.Padding(4)
        Me.TbDefNom.Name = "TbDefNom"
        Me.TbDefNom.Size = New System.Drawing.Size(201, 22)
        Me.TbDefNom.TabIndex = 3
        '
        'FPLNom
        '
        Me.FPLNom.AutoSize = True
        Me.FPLNom.Location = New System.Drawing.Point(54, 85)
        Me.FPLNom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FPLNom.Name = "FPLNom"
        Me.FPLNom.Size = New System.Drawing.Size(45, 17)
        Me.FPLNom.TabIndex = 114
        Me.FPLNom.Text = "Nom :"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.LbTypeInhOrd)
        Me.Panel1.Controls.Add(Me.RbInhOrd)
        Me.Panel1.Controls.Add(Me.RbNouvelleCon)
        Me.Panel1.Controls.Add(Me.RbConcExis)
        Me.Panel1.CouleurBordure = System.Drawing.Color.SeaGreen
        Me.Panel1.EpaisseurBordure = 7
        Me.FlowLayoutPanel1.SetFlowBreak(Me.Panel1, True)
        Me.Panel1.Location = New System.Drawing.Point(3, 455)
        Me.Panel1.MaximumSize = New System.Drawing.Size(692, 0)
        Me.Panel1.MinimumSize = New System.Drawing.Size(692, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10, 30, 10, 15)
        Me.Panel1.Size = New System.Drawing.Size(692, 160)
        Me.Panel1.TabIndex = 100
        Me.Panel1.Texte = ""
        '
        'LbTypeInhOrd
        '
        Me.LbTypeInhOrd.FormattingEnabled = True
        Me.LbTypeInhOrd.ItemHeight = 16
        Me.LbTypeInhOrd.Items.AddRange(New Object() {"Inhumation en pleine terre - cercueil", "Inhumation en pleine terre - urne", "Ouverture de caveau", "Urne en colombarium", "Dispersion des cendres"})
        Me.LbTypeInhOrd.Location = New System.Drawing.Point(22, 58)
        Me.LbTypeInhOrd.Name = "LbTypeInhOrd"
        Me.LbTypeInhOrd.Size = New System.Drawing.Size(313, 84)
        Me.LbTypeInhOrd.TabIndex = 104
        '
        'RbInhOrd
        '
        Me.RbInhOrd.AutoSize = True
        Me.RbInhOrd.Checked = True
        Me.RbInhOrd.Location = New System.Drawing.Point(31, 22)
        Me.RbInhOrd.Name = "RbInhOrd"
        Me.RbInhOrd.Size = New System.Drawing.Size(158, 21)
        Me.RbInhOrd.TabIndex = 101
        Me.RbInhOrd.TabStop = True
        Me.RbInhOrd.Text = "Inhumation ordinaire"
        Me.RbInhOrd.UseVisualStyleBackColor = True
        '
        'RbNouvelleCon
        '
        Me.RbNouvelleCon.AutoSize = True
        Me.RbNouvelleCon.Location = New System.Drawing.Point(436, 22)
        Me.RbNouvelleCon.Name = "RbNouvelleCon"
        Me.RbNouvelleCon.Size = New System.Drawing.Size(195, 21)
        Me.RbNouvelleCon.TabIndex = 103
        Me.RbNouvelleCon.Text = "Réserver un emplacement"
        Me.RbNouvelleCon.UseVisualStyleBackColor = True
        '
        'RbConcExis
        '
        Me.RbConcExis.AutoSize = True
        Me.RbConcExis.Location = New System.Drawing.Point(198, 22)
        Me.RbConcExis.Name = "RbConcExis"
        Me.RbConcExis.Size = New System.Drawing.Size(235, 21)
        Me.RbConcExis.TabIndex = 102
        Me.RbConcExis.Text = "Utiliser une concession existante"
        Me.RbConcExis.UseVisualStyleBackColor = True
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.SystemColors.Window
        Me.Panel11.Controls.Add(Me.TbDmdrTel)
        Me.Panel11.Controls.Add(Me.Label7)
        Me.Panel11.Controls.Add(Me.CtrlVilleDmdr)
        Me.Panel11.Controls.Add(Me.TbDmdrNom)
        Me.Panel11.Controls.Add(Me.TbDmdrAdresse)
        Me.Panel11.Controls.Add(Me.TbDmdrPrenom)
        Me.Panel11.Controls.Add(Me.Label10)
        Me.Panel11.Controls.Add(Me.Label8)
        Me.Panel11.Controls.Add(Me.Label9)
        Me.Panel11.CouleurBordure = System.Drawing.Color.SeaGreen
        Me.Panel11.EpaisseurBordure = 7
        Me.FlowLayoutPanel1.SetFlowBreak(Me.Panel11, True)
        Me.Panel11.Location = New System.Drawing.Point(3, 621)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(692, 159)
        Me.Panel11.TabIndex = 105
        Me.Panel11.Texte = "Personne introduisant la demande"
        '
        'TbDmdrTel
        '
        Me.TbDmdrTel.Location = New System.Drawing.Point(103, 100)
        Me.TbDmdrTel.Name = "TbDmdrTel"
        Me.TbDmdrTel.Size = New System.Drawing.Size(142, 22)
        Me.TbDmdrTel.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Nom"
        '
        'CtrlVilleDmdr
        '
        Me.CtrlVilleDmdr.LectureSeule = False
        Me.CtrlVilleDmdr.Location = New System.Drawing.Point(317, 66)
        Me.CtrlVilleDmdr.LocVilleId = -1
        Me.CtrlVilleDmdr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CtrlVilleDmdr.Name = "CtrlVilleDmdr"
        Me.CtrlVilleDmdr.osef = Nothing
        Me.CtrlVilleDmdr.Size = New System.Drawing.Size(316, 25)
        Me.CtrlVilleDmdr.TabIndex = 7
        '
        'TbDmdrNom
        '
        Me.TbDmdrNom.Location = New System.Drawing.Point(103, 35)
        Me.TbDmdrNom.Name = "TbDmdrNom"
        Me.TbDmdrNom.Size = New System.Drawing.Size(142, 22)
        Me.TbDmdrNom.TabIndex = 0
        '
        'TbDmdrAdresse
        '
        Me.TbDmdrAdresse.Location = New System.Drawing.Point(103, 67)
        Me.TbDmdrAdresse.Name = "TbDmdrAdresse"
        Me.TbDmdrAdresse.Size = New System.Drawing.Size(171, 22)
        Me.TbDmdrAdresse.TabIndex = 6
        '
        'TbDmdrPrenom
        '
        Me.TbDmdrPrenom.Location = New System.Drawing.Point(381, 35)
        Me.TbDmdrPrenom.Name = "TbDmdrPrenom"
        Me.TbDmdrPrenom.Size = New System.Drawing.Size(142, 22)
        Me.TbDmdrPrenom.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(31, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 17)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Adresse"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(309, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 17)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Prénom"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 17)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Téléphone"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.SystemColors.Window
        Me.Panel13.Controls.Add(Me.CbPCont)
        Me.Panel13.Controls.Add(Me.TbPcontTel)
        Me.Panel13.Controls.Add(Me.Label6)
        Me.Panel13.Controls.Add(Me.CtrlLocPcont)
        Me.Panel13.Controls.Add(Me.TbPcontNom)
        Me.Panel13.Controls.Add(Me.TbPcontAdresse)
        Me.Panel13.Controls.Add(Me.TbPcontPrenom)
        Me.Panel13.Controls.Add(Me.Label12)
        Me.Panel13.Controls.Add(Me.Label13)
        Me.Panel13.Controls.Add(Me.Label14)
        Me.Panel13.CouleurBordure = System.Drawing.Color.SeaGreen
        Me.Panel13.EpaisseurBordure = 7
        Me.FlowLayoutPanel1.SetFlowBreak(Me.Panel13, True)
        Me.Panel13.Location = New System.Drawing.Point(3, 786)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(692, 172)
        Me.Panel13.TabIndex = 200
        Me.Panel13.Texte = "Personne de contact"
        '
        'CbPCont
        '
        Me.CbPCont.AutoSize = True
        Me.CbPCont.Location = New System.Drawing.Point(23, 35)
        Me.CbPCont.Name = "CbPCont"
        Me.CbPCont.Size = New System.Drawing.Size(358, 21)
        Me.CbPCont.TabIndex = 201
        Me.CbPCont.Text = "Enregistrer une personne de contact pour ce défunt"
        Me.CbPCont.UseVisualStyleBackColor = True
        '
        'TbPcontTel
        '
        Me.TbPcontTel.Enabled = False
        Me.TbPcontTel.Location = New System.Drawing.Point(104, 132)
        Me.TbPcontTel.Name = "TbPcontTel"
        Me.TbPcontTel.Size = New System.Drawing.Size(142, 22)
        Me.TbPcontTel.TabIndex = 206
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Nom"
        '
        'CtrlLocPcont
        '
        Me.CtrlLocPcont.Enabled = False
        Me.CtrlLocPcont.LectureSeule = False
        Me.CtrlLocPcont.Location = New System.Drawing.Point(318, 98)
        Me.CtrlLocPcont.LocVilleId = -1
        Me.CtrlLocPcont.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CtrlLocPcont.Name = "CtrlLocPcont"
        Me.CtrlLocPcont.osef = Nothing
        Me.CtrlLocPcont.Size = New System.Drawing.Size(316, 25)
        Me.CtrlLocPcont.TabIndex = 205
        '
        'TbPcontNom
        '
        Me.TbPcontNom.Enabled = False
        Me.TbPcontNom.Location = New System.Drawing.Point(104, 67)
        Me.TbPcontNom.Name = "TbPcontNom"
        Me.TbPcontNom.Size = New System.Drawing.Size(142, 22)
        Me.TbPcontNom.TabIndex = 202
        '
        'TbPcontAdresse
        '
        Me.TbPcontAdresse.Enabled = False
        Me.TbPcontAdresse.Location = New System.Drawing.Point(104, 99)
        Me.TbPcontAdresse.Name = "TbPcontAdresse"
        Me.TbPcontAdresse.Size = New System.Drawing.Size(171, 22)
        Me.TbPcontAdresse.TabIndex = 204
        '
        'TbPcontPrenom
        '
        Me.TbPcontPrenom.Enabled = False
        Me.TbPcontPrenom.Location = New System.Drawing.Point(382, 67)
        Me.TbPcontPrenom.Name = "TbPcontPrenom"
        Me.TbPcontPrenom.Size = New System.Drawing.Size(142, 22)
        Me.TbPcontPrenom.TabIndex = 203
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(32, 99)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 17)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Adresse"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(310, 67)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 17)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Prénom"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(19, 132)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 17)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Téléphone"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Window
        Me.Panel6.Controls.Add(Me.CbEnregPdfP1)
        Me.Panel6.Controls.Add(Me.Label11)
        Me.Panel6.Controls.Add(Me.DtpDateSign)
        Me.Panel6.Controls.Add(Me.BtSuivant)
        Me.Panel6.CouleurBordure = System.Drawing.Color.SeaGreen
        Me.Panel6.EpaisseurBordure = 7
        Me.FlowLayoutPanel1.SetFlowBreak(Me.Panel6, True)
        Me.Panel6.Location = New System.Drawing.Point(3, 964)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(692, 94)
        Me.Panel6.TabIndex = 300
        Me.Panel6.Texte = ""
        '
        'CbEnregPdfP1
        '
        Me.CbEnregPdfP1.AutoSize = True
        Me.CbEnregPdfP1.Checked = True
        Me.CbEnregPdfP1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbEnregPdfP1.Location = New System.Drawing.Point(21, 56)
        Me.CbEnregPdfP1.Margin = New System.Windows.Forms.Padding(4)
        Me.CbEnregPdfP1.Name = "CbEnregPdfP1"
        Me.CbEnregPdfP1.Size = New System.Drawing.Size(188, 21)
        Me.CbEnregPdfP1.TabIndex = 302
        Me.CbEnregPdfP1.Text = "Enregistrer le fichier PDF"
        Me.CbEnregPdfP1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 17)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Fait le"
        '
        'DtpDateSign
        '
        Me.DtpDateSign.Location = New System.Drawing.Point(73, 24)
        Me.DtpDateSign.Name = "DtpDateSign"
        Me.DtpDateSign.ShowCheckBox = True
        Me.DtpDateSign.Size = New System.Drawing.Size(270, 22)
        Me.DtpDateSign.TabIndex = 301
        '
        'BtSuivant
        '
        Me.BtSuivant.BackColor = System.Drawing.Color.SeaGreen
        Me.BtSuivant.ForeColor = System.Drawing.Color.White
        Me.BtSuivant.Location = New System.Drawing.Point(551, 21)
        Me.BtSuivant.Name = "BtSuivant"
        Me.BtSuivant.Size = New System.Drawing.Size(113, 51)
        Me.BtSuivant.TabIndex = 303
        Me.BtSuivant.Text = "Suivant"
        Me.BtSuivant.UseVisualStyleBackColor = False
        '
        'PanBordure1
        '
        Me.PanBordure1.Controls.Add(Me.BtMontrerFormPlanCimCsnsExist)
        Me.PanBordure1.Controls.Add(Me.GroupBox3)
        Me.PanBordure1.Controls.Add(Me.TbFiltreCsnsExist)
        Me.PanBordure1.Controls.Add(Me.GroupBox1)
        Me.PanBordure1.Controls.Add(Me.BtViderFiltreCsnsExist)
        Me.PanBordure1.Controls.Add(Me.DgvCsnsExist)
        Me.PanBordure1.Controls.Add(Me.LbTypeInhCsnExis)
        Me.PanBordure1.CouleurBordure = System.Drawing.Color.SeaGreen
        Me.PanBordure1.EpaisseurBordure = 7
        Me.PanBordure1.Location = New System.Drawing.Point(7, 107)
        Me.PanBordure1.Name = "PanBordure1"
        Me.PanBordure1.Size = New System.Drawing.Size(1012, 704)
        Me.PanBordure1.TabIndex = 191
        Me.PanBordure1.Texte = "Choix de la concession existante..."
        '
        'BtMontrerFormPlanCimCsnsExist
        '
        Me.BtMontrerFormPlanCimCsnsExist.Image = Global.cimetiere.My.Resources.Resources.Note_16x
        Me.BtMontrerFormPlanCimCsnsExist.Location = New System.Drawing.Point(834, 35)
        Me.BtMontrerFormPlanCimCsnsExist.Name = "BtMontrerFormPlanCimCsnsExist"
        Me.BtMontrerFormPlanCimCsnsExist.Size = New System.Drawing.Size(34, 31)
        Me.BtMontrerFormPlanCimCsnsExist.TabIndex = 190
        Me.BtMontrerFormPlanCimCsnsExist.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LvCsnExisBenefs)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 497)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(843, 190)
        Me.GroupBox3.TabIndex = 179
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Bénéficiaires"
        '
        'LvCsnExisBenefs
        '
        Me.LvCsnExisBenefs.AllowColumnReorder = True
        Me.LvCsnExisBenefs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.LvCsnExisBenefs.FullRowSelect = True
        Me.LvCsnExisBenefs.Location = New System.Drawing.Point(6, 21)
        Me.LvCsnExisBenefs.Name = "LvCsnExisBenefs"
        Me.LvCsnExisBenefs.Size = New System.Drawing.Size(831, 163)
        Me.LvCsnExisBenefs.TabIndex = 176
        Me.LvCsnExisBenefs.UseCompatibleStateImageBehavior = False
        Me.LvCsnExisBenefs.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nom"
        Me.ColumnHeader1.Width = 122
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Prénom"
        Me.ColumnHeader2.Width = 133
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Date naiss."
        Me.ColumnHeader3.Width = 89
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Lien de parenté"
        Me.ColumnHeader4.Width = 112
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Adresse"
        Me.ColumnHeader5.Width = 202
        '
        'TbFiltreCsnsExist
        '
        Me.TbFiltreCsnsExist.Location = New System.Drawing.Point(31, 38)
        Me.TbFiltreCsnsExist.Name = "TbFiltreCsnsExist"
        Me.TbFiltreCsnsExist.Size = New System.Drawing.Size(190, 22)
        Me.TbFiltreCsnsExist.TabIndex = 183
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LvCsnExistOccupants)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 301)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(843, 190)
        Me.GroupBox1.TabIndex = 178
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Occupants actuels"
        '
        'LvCsnExistOccupants
        '
        Me.LvCsnExistOccupants.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.LvCsnExistOccupants.FullRowSelect = True
        Me.LvCsnExistOccupants.Location = New System.Drawing.Point(6, 21)
        Me.LvCsnExistOccupants.Name = "LvCsnExistOccupants"
        Me.LvCsnExistOccupants.Size = New System.Drawing.Size(831, 163)
        Me.LvCsnExistOccupants.TabIndex = 177
        Me.LvCsnExistOccupants.UseCompatibleStateImageBehavior = False
        Me.LvCsnExistOccupants.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Nom"
        Me.ColumnHeader6.Width = 180
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Prénom"
        Me.ColumnHeader7.Width = 188
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Date naiss."
        Me.ColumnHeader8.Width = 132
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Date décès"
        Me.ColumnHeader9.Width = 128
        '
        'BtViderFiltreCsnsExist
        '
        Me.BtViderFiltreCsnsExist.Image = Global.cimetiere.My.Resources.Resources.Cancel_16x
        Me.BtViderFiltreCsnsExist.Location = New System.Drawing.Point(227, 35)
        Me.BtViderFiltreCsnsExist.Name = "BtViderFiltreCsnsExist"
        Me.BtViderFiltreCsnsExist.Size = New System.Drawing.Size(32, 29)
        Me.BtViderFiltreCsnsExist.TabIndex = 189
        Me.BtViderFiltreCsnsExist.UseVisualStyleBackColor = True
        '
        'DgvCsnsExist
        '
        Me.DgvCsnsExist.AllowUserToAddRows = False
        Me.DgvCsnsExist.AllowUserToDeleteRows = False
        Me.DgvCsnsExist.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvCsnsExist.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvCsnsExist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvCsnsExist.BackgroundColor = System.Drawing.Color.White
        Me.DgvCsnsExist.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvCsnsExist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCsnsExist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DgvCsnsExistColEmplId, Me.Column1, Me.Column4, Me.Column2, Me.Column3, Me.DgvCsnsExistColOccupants})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvCsnsExist.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvCsnsExist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvCsnsExist.Location = New System.Drawing.Point(16, 75)
        Me.DgvCsnsExist.MultiSelect = False
        Me.DgvCsnsExist.Name = "DgvCsnsExist"
        Me.DgvCsnsExist.ReadOnly = True
        Me.DgvCsnsExist.RowHeadersVisible = False
        Me.DgvCsnsExist.RowTemplate.Height = 24
        Me.DgvCsnsExist.SelectedRow = Nothing
        Me.DgvCsnsExist.SelectedRowIndex = -1
        Me.DgvCsnsExist.SelectedValue = -1
        Me.DgvCsnsExist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCsnsExist.Size = New System.Drawing.Size(809, 220)
        Me.DgvCsnsExist.TabIndex = 173
        '
        'DgvCsnsExistColEmplId
        '
        Me.DgvCsnsExistColEmplId.DataPropertyName = "empl_id"
        Me.DgvCsnsExistColEmplId.HeaderText = "empl_id"
        Me.DgvCsnsExistColEmplId.Name = "DgvCsnsExistColEmplId"
        Me.DgvCsnsExistColEmplId.ReadOnly = True
        Me.DgvCsnsExistColEmplId.Visible = False
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "empl_reference"
        Me.Column1.HeaderText = "Emplacement"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "csnr_nom"
        Me.Column4.HeaderText = "Concessionnaire"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "con_date_debut"
        Me.Column2.HeaderText = "Début"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "con_date_fin"
        Me.Column3.HeaderText = "Fin"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'DgvCsnsExistColOccupants
        '
        Me.DgvCsnsExistColOccupants.HeaderText = "Occupants"
        Me.DgvCsnsExistColOccupants.Name = "DgvCsnsExistColOccupants"
        Me.DgvCsnsExistColOccupants.ReadOnly = True
        '
        'LbTypeInhCsnExis
        '
        Me.LbTypeInhCsnExis.FormattingEnabled = True
        Me.LbTypeInhCsnExis.ItemHeight = 16
        Me.LbTypeInhCsnExis.Items.AddRange(New Object() {"Urne", "Cercueil", "Pleine terre", "Caveau", "Cellule de colombarium", "Cavurne"})
        Me.LbTypeInhCsnExis.Location = New System.Drawing.Point(834, 75)
        Me.LbTypeInhCsnExis.Name = "LbTypeInhCsnExis"
        Me.LbTypeInhCsnExis.Size = New System.Drawing.Size(156, 212)
        Me.LbTypeInhCsnExis.TabIndex = 181
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.Window
        Me.Panel7.Controls.Add(Me.CbEnregPdfCsnExis)
        Me.Panel7.CouleurBordure = System.Drawing.Color.SeaGreen
        Me.Panel7.EpaisseurBordure = 7
        Me.Panel7.Location = New System.Drawing.Point(23, 827)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(431, 59)
        Me.Panel7.TabIndex = 0
        Me.Panel7.Texte = ""
        '
        'CbEnregPdfCsnExis
        '
        Me.CbEnregPdfCsnExis.AutoSize = True
        Me.CbEnregPdfCsnExis.Checked = True
        Me.CbEnregPdfCsnExis.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbEnregPdfCsnExis.Location = New System.Drawing.Point(30, 20)
        Me.CbEnregPdfCsnExis.Margin = New System.Windows.Forms.Padding(4)
        Me.CbEnregPdfCsnExis.Name = "CbEnregPdfCsnExis"
        Me.CbEnregPdfCsnExis.Size = New System.Drawing.Size(188, 21)
        Me.CbEnregPdfCsnExis.TabIndex = 8
        Me.CbEnregPdfCsnExis.Text = "Enregistrer le fichier PDF"
        Me.CbEnregPdfCsnExis.UseVisualStyleBackColor = True
        '
        'PanBordure2
        '
        Me.PanBordure2.Controls.Add(Me.TbFiltreEmpls)
        Me.PanBordure2.Controls.Add(Me.DgvEmplacementsPourInhOrd)
        Me.PanBordure2.Controls.Add(Me.BtMontrerFormPlancimEmplOrd)
        Me.PanBordure2.Controls.Add(Me.GroupBox5)
        Me.PanBordure2.Controls.Add(Me.BtViderFiltreEmpls)
        Me.PanBordure2.CouleurBordure = System.Drawing.Color.SeaGreen
        Me.PanBordure2.EpaisseurBordure = 7
        Me.PanBordure2.Location = New System.Drawing.Point(8, 109)
        Me.PanBordure2.Name = "PanBordure2"
        Me.PanBordure2.Size = New System.Drawing.Size(892, 539)
        Me.PanBordure2.TabIndex = 194
        Me.PanBordure2.Texte = "Choix de l'emplacement"
        '
        'TbFiltreEmpls
        '
        Me.TbFiltreEmpls.Location = New System.Drawing.Point(25, 36)
        Me.TbFiltreEmpls.Name = "TbFiltreEmpls"
        Me.TbFiltreEmpls.Size = New System.Drawing.Size(190, 22)
        Me.TbFiltreEmpls.TabIndex = 190
        '
        'DgvEmplacementsPourInhOrd
        '
        Me.DgvEmplacementsPourInhOrd.AllowUserToAddRows = False
        Me.DgvEmplacementsPourInhOrd.AllowUserToDeleteRows = False
        Me.DgvEmplacementsPourInhOrd.AllowUserToOrderColumns = True
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvEmplacementsPourInhOrd.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvEmplacementsPourInhOrd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvEmplacementsPourInhOrd.BackgroundColor = System.Drawing.Color.White
        Me.DgvEmplacementsPourInhOrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmplacementsPourInhOrd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DgvEmplsOrdColEmplId, Me.Column5, Me.DgvEmplsInhOrdOccupants, Me.DgvEmplsInhOrdClasse})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvEmplacementsPourInhOrd.DefaultCellStyle = DataGridViewCellStyle4
        Me.DgvEmplacementsPourInhOrd.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvEmplacementsPourInhOrd.Location = New System.Drawing.Point(24, 70)
        Me.DgvEmplacementsPourInhOrd.MultiSelect = False
        Me.DgvEmplacementsPourInhOrd.Name = "DgvEmplacementsPourInhOrd"
        Me.DgvEmplacementsPourInhOrd.ReadOnly = True
        Me.DgvEmplacementsPourInhOrd.RowHeadersVisible = False
        Me.DgvEmplacementsPourInhOrd.RowTemplate.Height = 24
        Me.DgvEmplacementsPourInhOrd.SelectedRow = Nothing
        Me.DgvEmplacementsPourInhOrd.SelectedRowIndex = -1
        Me.DgvEmplacementsPourInhOrd.SelectedValue = -1
        Me.DgvEmplacementsPourInhOrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvEmplacementsPourInhOrd.Size = New System.Drawing.Size(681, 256)
        Me.DgvEmplacementsPourInhOrd.TabIndex = 0
        '
        'DgvEmplsOrdColEmplId
        '
        Me.DgvEmplsOrdColEmplId.DataPropertyName = "empl_id"
        Me.DgvEmplsOrdColEmplId.HeaderText = "empl_id"
        Me.DgvEmplsOrdColEmplId.Name = "DgvEmplsOrdColEmplId"
        Me.DgvEmplsOrdColEmplId.ReadOnly = True
        Me.DgvEmplsOrdColEmplId.Visible = False
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "empl_reference"
        Me.Column5.HeaderText = "Référence"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'DgvEmplsInhOrdOccupants
        '
        Me.DgvEmplsInhOrdOccupants.HeaderText = "Occupants"
        Me.DgvEmplsInhOrdOccupants.Name = "DgvEmplsInhOrdOccupants"
        Me.DgvEmplsInhOrdOccupants.ReadOnly = True
        '
        'DgvEmplsInhOrdClasse
        '
        Me.DgvEmplsInhOrdClasse.DataPropertyName = "empl_monum_classe"
        Me.DgvEmplsInhOrdClasse.HeaderText = "Classé"
        Me.DgvEmplsInhOrdClasse.Name = "DgvEmplsInhOrdClasse"
        Me.DgvEmplsInhOrdClasse.ReadOnly = True
        '
        'BtMontrerFormPlancimEmplOrd
        '
        Me.BtMontrerFormPlancimEmplOrd.Image = Global.cimetiere.My.Resources.Resources.Note_16x
        Me.BtMontrerFormPlancimEmplOrd.Location = New System.Drawing.Point(671, 33)
        Me.BtMontrerFormPlancimEmplOrd.Name = "BtMontrerFormPlancimEmplOrd"
        Me.BtMontrerFormPlancimEmplOrd.Size = New System.Drawing.Size(34, 31)
        Me.BtMontrerFormPlancimEmplOrd.TabIndex = 179
        Me.BtMontrerFormPlancimEmplOrd.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.LvOccupantsInhOrdEmpl)
        Me.GroupBox5.Location = New System.Drawing.Point(29, 330)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(843, 190)
        Me.GroupBox5.TabIndex = 183
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Occupants actuels"
        '
        'LvOccupantsInhOrdEmpl
        '
        Me.LvOccupantsInhOrdEmpl.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.LvOccupantsInhOrdEmpl.FullRowSelect = True
        Me.LvOccupantsInhOrdEmpl.Location = New System.Drawing.Point(6, 21)
        Me.LvOccupantsInhOrdEmpl.Name = "LvOccupantsInhOrdEmpl"
        Me.LvOccupantsInhOrdEmpl.Size = New System.Drawing.Size(831, 163)
        Me.LvOccupantsInhOrdEmpl.TabIndex = 178
        Me.LvOccupantsInhOrdEmpl.UseCompatibleStateImageBehavior = False
        Me.LvOccupantsInhOrdEmpl.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Nom"
        Me.ColumnHeader10.Width = 179
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Prénom"
        Me.ColumnHeader11.Width = 240
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Date naiss."
        Me.ColumnHeader12.Width = 134
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Date décès"
        Me.ColumnHeader13.Width = 124
        '
        'BtViderFiltreEmpls
        '
        Me.BtViderFiltreEmpls.Image = Global.cimetiere.My.Resources.Resources.Cancel_16x
        Me.BtViderFiltreEmpls.Location = New System.Drawing.Point(221, 33)
        Me.BtViderFiltreEmpls.Name = "BtViderFiltreEmpls"
        Me.BtViderFiltreEmpls.Size = New System.Drawing.Size(32, 29)
        Me.BtViderFiltreEmpls.TabIndex = 191
        Me.BtViderFiltreEmpls.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.Window
        Me.Panel8.Controls.Add(Me.CbEnregPdfInhOrd)
        Me.Panel8.CouleurBordure = System.Drawing.Color.SeaGreen
        Me.Panel8.EpaisseurBordure = 7
        Me.Panel8.Location = New System.Drawing.Point(24, 660)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(402, 56)
        Me.Panel8.TabIndex = 185
        Me.Panel8.Texte = ""
        '
        'CbEnregPdfInhOrd
        '
        Me.CbEnregPdfInhOrd.AutoSize = True
        Me.CbEnregPdfInhOrd.Checked = True
        Me.CbEnregPdfInhOrd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbEnregPdfInhOrd.Location = New System.Drawing.Point(19, 19)
        Me.CbEnregPdfInhOrd.Margin = New System.Windows.Forms.Padding(4)
        Me.CbEnregPdfInhOrd.Name = "CbEnregPdfInhOrd"
        Me.CbEnregPdfInhOrd.Size = New System.Drawing.Size(188, 21)
        Me.CbEnregPdfInhOrd.TabIndex = 8
        Me.CbEnregPdfInhOrd.Text = "Enregistrer le fichier PDF"
        Me.CbEnregPdfInhOrd.UseVisualStyleBackColor = True
        '
        'CtrlLocVillePays1
        '
        Me.CtrlLocVillePays1.LectureSeule = False
        Me.CtrlLocVillePays1.Location = New System.Drawing.Point(337, 59)
        Me.CtrlLocVillePays1.LocVilleId = -1
        Me.CtrlLocVillePays1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CtrlLocVillePays1.Name = "CtrlLocVillePays1"
        Me.CtrlLocVillePays1.osef = Nothing
        Me.CtrlLocVillePays1.Size = New System.Drawing.Size(316, 25)
        Me.CtrlLocVillePays1.TabIndex = 7
        '
        'FormDemandeInhumation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1067, 849)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FormDemandeInhumation"
        Me.Text = "Enregistrer une inhumation"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabP2ConExis.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabP2InhOrd.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.PanBordure1.ResumeLayout(False)
        Me.PanBordure1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvCsnsExist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.PanBordure2.ResumeLayout(False)
        Me.PanBordure2.PerformLayout()
        CType(Me.DgvEmplacementsPourInhOrd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As PanBordure
    Friend WithEvents TbDefLieuDeces As TextBox
    Friend WithEvents TbDefDateDeces As TextBoxDate
    Friend WithEvents TbDefDateNaiss As TextBoxDate
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CtrlDefEtatCiv As CtrlEtatCivil
    Friend WithEvents Label1 As Label
    Friend WithEvents CtrlDefLocvillepays As CtrlLocVillePays
    Friend WithEvents TbDefLieuNaiss As TextBox
    Friend WithEvents FPLLieuNaiss As Label
    Friend WithEvents TbDefAdresse As TextBox
    Friend WithEvents FPLAdresse As Label
    Friend WithEvents TbDefPrenom As TextBox
    Friend WithEvents FPLDateM As Label
    Friend WithEvents FPLPrenom As Label
    Friend WithEvents FPLDateNaiss As Label
    Friend WithEvents TbDefNom As TextBox
    Friend WithEvents FPLNom As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TbNumAnnee As TextBoxInt
    Friend WithEvents TbDefNumLh As TextBoxInt
    Friend WithEvents Panel1 As PanBordure
    Friend WithEvents RbInhOrd As RadioButton
    Friend WithEvents RbNouvelleCon As RadioButton
    Friend WithEvents RbConcExis As RadioButton
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel6 As PanBordure
    Friend WithEvents BtSuivant As Button
    Friend WithEvents TabP2ConExis As TabPage
    Friend WithEvents BtTerminerConExis As Button
    Friend WithEvents DgvCsnsExist As DataGridViewConcessions
    Friend WithEvents LvCsnExisBenefs As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents LvCsnExistOccupants As ListView
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel7 As PanBordure
    Friend WithEvents CbEnregPdfCsnExis As CheckBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents LbTypeInhOrd As ListBox
    Friend WithEvents Panel11 As PanBordure
    Friend WithEvents Label8 As Label
    Friend WithEvents TbDmdrPrenom As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TbDmdrNom As TextBox
    Friend WithEvents TbDmdrAdresse As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TbDmdrTel As TextBox
    Friend WithEvents CtrlVilleDmdr As CtrlLocVillePays
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CtrlLocVillePays1 As CtrlLocVillePays
    Friend WithEvents Label11 As Label
    Friend WithEvents DtpDateSign As DateTimePicker
    Friend WithEvents LbTypeInhCsnExis As ListBox
    Friend WithEvents TabP2InhOrd As TabPage
    Friend WithEvents DgvEmplacementsPourInhOrd As DataGridViewCustom
    Friend WithEvents LvOccupantsInhOrdEmpl As ListView
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Panel8 As PanBordure
    Friend WithEvents CbEnregPdfInhOrd As CheckBox
    Friend WithEvents BtTerminerInhOrd As Button
    Friend WithEvents CbEnregPdfP1 As CheckBox
    Friend WithEvents BtPrécédentDeConExis As Button
    Friend WithEvents BtPrecedentDeInhOrd As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtPrécédentDeConExit As Button
    Friend WithEvents TbFiltreCsnsExist As TextBox
    Friend WithEvents BtViderFiltreCsnsExist As Button
    Friend WithEvents BtViderFiltreEmpls As Button
    Friend WithEvents TbFiltreEmpls As TextBox
    Friend WithEvents BtMontrerFormPlancimEmplOrd As Button
    Friend WithEvents BtMontrerFormPlanCimCsnsExist As Button
    Friend WithEvents DgvEmplsOrdColEmplId As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents DgvEmplsInhOrdOccupants As DataGridViewTextBoxColumn
    Friend WithEvents DgvEmplsInhOrdClasse As DataGridViewTextBoxColumn
    Friend WithEvents DgvCsnsExistColEmplId As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents DgvCsnsExistColOccupants As DataGridViewTextBoxColumn
    Friend WithEvents Panel13 As PanBordure
    Friend WithEvents TbPcontTel As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CtrlLocPcont As CtrlLocVillePays
    Friend WithEvents TbPcontNom As TextBox
    Friend WithEvents TbPcontAdresse As TextBox
    Friend WithEvents TbPcontPrenom As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents CbPCont As CheckBox
    Friend WithEvents PanBordure1 As PanBordure
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents LabTitreP1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents PanBordure2 As PanBordure
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label16 As Label
End Class
