﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LbTypeInhOrd = New System.Windows.Forms.ListBox()
        Me.RbInhOrd = New System.Windows.Forms.RadioButton()
        Me.RbNouvelleCon = New System.Windows.Forms.RadioButton()
        Me.RbConcExis = New System.Windows.Forms.RadioButton()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TbDmdrTel = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CtrlVilleDmdr = New cimetiere.CtrlLocVillePays()
        Me.TbDmdrNom = New System.Windows.Forms.TextBox()
        Me.TbDmdrAdresse = New System.Windows.Forms.TextBox()
        Me.TbDmdrPrenom = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TbPcontTel = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CtrlLocPcont = New cimetiere.CtrlLocVillePays()
        Me.TbPcontNom = New System.Windows.Forms.TextBox()
        Me.TbPcontAdresse = New System.Windows.Forms.TextBox()
        Me.TbPcontPrenom = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.CbEnregPdfP1 = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DtpDateSign = New System.Windows.Forms.DateTimePicker()
        Me.BtSuivant = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabP2ConExis = New System.Windows.Forms.TabPage()
        Me.BtMontrerFormPlanCimCsnsExist = New System.Windows.Forms.Button()
        Me.BtViderFiltreCsnsExist = New System.Windows.Forms.Button()
        Me.TbFiltreCsnsExist = New System.Windows.Forms.TextBox()
        Me.BtPrécédentDeConExis = New System.Windows.Forms.Button()
        Me.LbTypeInhCsnExis = New System.Windows.Forms.ListBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.CbEnregPdfCsnExis = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LvCsnExisBenefs = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LvCsnExistOccupants = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtTerminerConExis = New System.Windows.Forms.Button()
        Me.DgvCsnsExist = New cimetiere.DataGridViewConcessions()
        Me.DgvCsnsExistColEmplId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvCsnsExistColOccupants = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabP2InhOrd = New System.Windows.Forms.TabPage()
        Me.BtMontrerFormPlancimEmplOrd = New System.Windows.Forms.Button()
        Me.BtViderFiltreEmpls = New System.Windows.Forms.Button()
        Me.TbFiltreEmpls = New System.Windows.Forms.TextBox()
        Me.BtPrecedentDeInhOrd = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.CbEnregPdfInhOrd = New System.Windows.Forms.CheckBox()
        Me.BtTerminerInhOrd = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LvOccupantsInhOrdEmpl = New System.Windows.Forms.ListView()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DgvEmplacementsPourInhOrd = New cimetiere.DataGridViewCustom()
        Me.DgvEmplsOrdColEmplId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvEmplsInhOrdOccupants = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvEmplsInhOrdClasse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtPrécédentDeConExit = New System.Windows.Forms.Button()
        Me.CtrlLocVillePays1 = New cimetiere.CtrlLocVillePays()
        Me.CbPCont = New System.Windows.Forms.CheckBox()
        Me.Panel4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabP2ConExis.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvCsnsExist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabP2InhOrd.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DgvEmplacementsPourInhOrd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel4.Controls.Add(Me.GroupBox2)
        Me.FlowLayoutPanel1.SetFlowBreak(Me.Panel4, True)
        Me.Panel4.Location = New System.Drawing.Point(4, 4)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(714, 341)
        Me.Panel4.TabIndex = 144
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.TbNumAnnee)
        Me.GroupBox2.Controls.Add(Me.TbDefNumLh)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TbDefLieuDeces)
        Me.GroupBox2.Controls.Add(Me.TbDefDateDeces)
        Me.GroupBox2.Controls.Add(Me.TbDefDateNaiss)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.CtrlDefEtatCiv)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.CtrlDefLocvillepays)
        Me.GroupBox2.Controls.Add(Me.TbDefLieuNaiss)
        Me.GroupBox2.Controls.Add(Me.FPLLieuNaiss)
        Me.GroupBox2.Controls.Add(Me.TbDefAdresse)
        Me.GroupBox2.Controls.Add(Me.FPLAdresse)
        Me.GroupBox2.Controls.Add(Me.TbDefPrenom)
        Me.GroupBox2.Controls.Add(Me.FPLDateM)
        Me.GroupBox2.Controls.Add(Me.FPLPrenom)
        Me.GroupBox2.Controls.Add(Me.FPLDateNaiss)
        Me.GroupBox2.Controls.Add(Me.TbDefNom)
        Me.GroupBox2.Controls.Add(Me.FPLNom)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 16)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(681, 312)
        Me.GroupBox2.TabIndex = 93
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informations du défunt"
        '
        'TbNumAnnee
        '
        Me.TbNumAnnee.Location = New System.Drawing.Point(460, 22)
        Me.TbNumAnnee.Name = "TbNumAnnee"
        Me.TbNumAnnee.Size = New System.Drawing.Size(129, 22)
        Me.TbNumAnnee.TabIndex = 151
        Me.TbNumAnnee.Value = Nothing
        '
        'TbDefNumLh
        '
        Me.TbDefNumLh.Location = New System.Drawing.Point(158, 22)
        Me.TbDefNumLh.Name = "TbDefNumLh"
        Me.TbDefNumLh.Size = New System.Drawing.Size(133, 22)
        Me.TbDefNumLh.TabIndex = 150
        Me.TbDefNumLh.Value = Nothing
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(356, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 17)
        Me.Label5.TabIndex = 149
        Me.Label5.Text = "Num. année :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 17)
        Me.Label3.TabIndex = 148
        Me.Label3.Text = "Code défunt :"
        '
        'TbDefLieuDeces
        '
        Me.TbDefLieuDeces.Location = New System.Drawing.Point(460, 229)
        Me.TbDefLieuDeces.Margin = New System.Windows.Forms.Padding(4)
        Me.TbDefLieuDeces.Name = "TbDefLieuDeces"
        Me.TbDefLieuDeces.Size = New System.Drawing.Size(189, 22)
        Me.TbDefLieuDeces.TabIndex = 147
        '
        'TbDefDateDeces
        '
        Me.TbDefDateDeces.DateValue = Nothing
        Me.TbDefDateDeces.Location = New System.Drawing.Point(158, 229)
        Me.TbDefDateDeces.Mask = "00/00/0000"
        Me.TbDefDateDeces.Name = "TbDefDateDeces"
        Me.TbDefDateDeces.Size = New System.Drawing.Size(100, 22)
        Me.TbDefDateDeces.TabIndex = 146
        Me.TbDefDateDeces.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbDefDateNaiss
        '
        Me.TbDefDateNaiss.DateValue = Nothing
        Me.TbDefDateNaiss.Location = New System.Drawing.Point(158, 188)
        Me.TbDefDateNaiss.Mask = "00/00/0000"
        Me.TbDefDateNaiss.Name = "TbDefDateNaiss"
        Me.TbDefDateNaiss.Size = New System.Drawing.Size(100, 22)
        Me.TbDefDateNaiss.TabIndex = 145
        Me.TbDefDateNaiss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 231)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 144
        Me.Label4.Text = "Décédé le :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 273)
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
        Me.CtrlDefEtatCiv.Location = New System.Drawing.Point(158, 270)
        Me.CtrlDefEtatCiv.Name = "CtrlDefEtatCiv"
        Me.CtrlDefEtatCiv.osef = Nothing
        Me.CtrlDefEtatCiv.Size = New System.Drawing.Size(369, 24)
        Me.CtrlDefEtatCiv.TabIndex = 142
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 150)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 141
        Me.Label1.Text = "Ville :"
        '
        'CtrlDefLocvillepays
        '
        Me.CtrlDefLocvillepays.LectureSeule = False
        Me.CtrlDefLocvillepays.Location = New System.Drawing.Point(158, 146)
        Me.CtrlDefLocvillepays.LocVilleId = -1
        Me.CtrlDefLocvillepays.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CtrlDefLocvillepays.Name = "CtrlDefLocvillepays"
        Me.CtrlDefLocvillepays.osef = Nothing
        Me.CtrlDefLocvillepays.Size = New System.Drawing.Size(316, 25)
        Me.CtrlDefLocvillepays.TabIndex = 140
        '
        'TbDefLieuNaiss
        '
        Me.TbDefLieuNaiss.Location = New System.Drawing.Point(460, 188)
        Me.TbDefLieuNaiss.Margin = New System.Windows.Forms.Padding(4)
        Me.TbDefLieuNaiss.Name = "TbDefLieuNaiss"
        Me.TbDefLieuNaiss.Size = New System.Drawing.Size(189, 22)
        Me.TbDefLieuNaiss.TabIndex = 139
        '
        'FPLLieuNaiss
        '
        Me.FPLLieuNaiss.AutoSize = True
        Me.FPLLieuNaiss.Location = New System.Drawing.Point(403, 190)
        Me.FPLLieuNaiss.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FPLLieuNaiss.Name = "FPLLieuNaiss"
        Me.FPLLieuNaiss.Size = New System.Drawing.Size(46, 17)
        Me.FPLLieuNaiss.TabIndex = 138
        Me.FPLLieuNaiss.Text = "Né à :"
        '
        'TbDefAdresse
        '
        Me.TbDefAdresse.Location = New System.Drawing.Point(158, 105)
        Me.TbDefAdresse.Margin = New System.Windows.Forms.Padding(4)
        Me.TbDefAdresse.Name = "TbDefAdresse"
        Me.TbDefAdresse.Size = New System.Drawing.Size(201, 22)
        Me.TbDefAdresse.TabIndex = 131
        '
        'FPLAdresse
        '
        Me.FPLAdresse.AutoSize = True
        Me.FPLAdresse.Location = New System.Drawing.Point(76, 109)
        Me.FPLAdresse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FPLAdresse.Name = "FPLAdresse"
        Me.FPLAdresse.Size = New System.Drawing.Size(68, 17)
        Me.FPLAdresse.TabIndex = 130
        Me.FPLAdresse.Text = "Adresse :"
        '
        'TbDefPrenom
        '
        Me.TbDefPrenom.Location = New System.Drawing.Point(460, 72)
        Me.TbDefPrenom.Margin = New System.Windows.Forms.Padding(4)
        Me.TbDefPrenom.Name = "TbDefPrenom"
        Me.TbDefPrenom.Size = New System.Drawing.Size(189, 22)
        Me.TbDefPrenom.TabIndex = 126
        '
        'FPLDateM
        '
        Me.FPLDateM.AutoSize = True
        Me.FPLDateM.Location = New System.Drawing.Point(372, 232)
        Me.FPLDateM.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FPLDateM.Name = "FPLDateM"
        Me.FPLDateM.Size = New System.Drawing.Size(77, 17)
        Me.FPLDateM.TabIndex = 123
        Me.FPLDateM.Text = "Décédé à :"
        '
        'FPLPrenom
        '
        Me.FPLPrenom.AutoSize = True
        Me.FPLPrenom.Location = New System.Drawing.Point(387, 72)
        Me.FPLPrenom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FPLPrenom.Name = "FPLPrenom"
        Me.FPLPrenom.Size = New System.Drawing.Size(65, 17)
        Me.FPLPrenom.TabIndex = 122
        Me.FPLPrenom.Text = "Prenom :"
        '
        'FPLDateNaiss
        '
        Me.FPLDateNaiss.AutoSize = True
        Me.FPLDateNaiss.Location = New System.Drawing.Point(94, 189)
        Me.FPLDateNaiss.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FPLDateNaiss.Name = "FPLDateNaiss"
        Me.FPLDateNaiss.Size = New System.Drawing.Size(49, 17)
        Me.FPLDateNaiss.TabIndex = 116
        Me.FPLDateNaiss.Text = "Né le :"
        '
        'TbDefNom
        '
        Me.TbDefNom.Location = New System.Drawing.Point(158, 64)
        Me.TbDefNom.Margin = New System.Windows.Forms.Padding(4)
        Me.TbDefNom.Name = "TbDefNom"
        Me.TbDefNom.Size = New System.Drawing.Size(201, 22)
        Me.TbDefNom.TabIndex = 115
        '
        'FPLNom
        '
        Me.FPLNom.AutoSize = True
        Me.FPLNom.Location = New System.Drawing.Point(86, 68)
        Me.FPLNom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FPLNom.Name = "FPLNom"
        Me.FPLNom.Size = New System.Drawing.Size(45, 17)
        Me.FPLNom.TabIndex = 114
        Me.FPLNom.Text = "Nom :"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel1.SetFlowBreak(Me.Panel1, True)
        Me.Panel1.Location = New System.Drawing.Point(3, 352)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(620, 140)
        Me.Panel1.TabIndex = 145
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.Panel2.Controls.Add(Me.LbTypeInhOrd)
        Me.Panel2.Controls.Add(Me.RbInhOrd)
        Me.Panel2.Controls.Add(Me.RbNouvelleCon)
        Me.Panel2.Controls.Add(Me.RbConcExis)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(614, 134)
        Me.Panel2.TabIndex = 0
        '
        'LbTypeInhOrd
        '
        Me.LbTypeInhOrd.FormattingEnabled = True
        Me.LbTypeInhOrd.ItemHeight = 16
        Me.LbTypeInhOrd.Items.AddRange(New Object() {"Inhumation en pleine terre - cercueil", "Inhumation en pleine terre - urne", "Ouverture de caveau", "Urne en colombarium", "Dispersion des cendres"})
        Me.LbTypeInhOrd.Location = New System.Drawing.Point(9, 40)
        Me.LbTypeInhOrd.Name = "LbTypeInhOrd"
        Me.LbTypeInhOrd.Size = New System.Drawing.Size(285, 84)
        Me.LbTypeInhOrd.TabIndex = 3
        '
        'RbInhOrd
        '
        Me.RbInhOrd.AutoSize = True
        Me.RbInhOrd.Checked = True
        Me.RbInhOrd.Location = New System.Drawing.Point(11, 10)
        Me.RbInhOrd.Name = "RbInhOrd"
        Me.RbInhOrd.Size = New System.Drawing.Size(158, 21)
        Me.RbInhOrd.TabIndex = 2
        Me.RbInhOrd.TabStop = True
        Me.RbInhOrd.Text = "Inhumation ordinaire"
        Me.RbInhOrd.UseVisualStyleBackColor = True
        '
        'RbNouvelleCon
        '
        Me.RbNouvelleCon.AutoSize = True
        Me.RbNouvelleCon.Location = New System.Drawing.Point(416, 10)
        Me.RbNouvelleCon.Name = "RbNouvelleCon"
        Me.RbNouvelleCon.Size = New System.Drawing.Size(195, 21)
        Me.RbNouvelleCon.TabIndex = 1
        Me.RbNouvelleCon.Text = "Réserver un emplacement"
        Me.RbNouvelleCon.UseVisualStyleBackColor = True
        '
        'RbConcExis
        '
        Me.RbConcExis.AutoSize = True
        Me.RbConcExis.Location = New System.Drawing.Point(175, 10)
        Me.RbConcExis.Name = "RbConcExis"
        Me.RbConcExis.Size = New System.Drawing.Size(235, 21)
        Me.RbConcExis.TabIndex = 0
        Me.RbConcExis.Text = "Utiliser une concession existante"
        Me.RbConcExis.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BackgroundImage = Global.cimetiere.My.Resources.Resources.fondformulaire
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel4)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel10)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel12)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel5)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1046, 814)
        Me.FlowLayoutPanel1.TabIndex = 146
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel10.Controls.Add(Me.Panel11)
        Me.FlowLayoutPanel1.SetFlowBreak(Me.Panel10, True)
        Me.Panel10.Location = New System.Drawing.Point(3, 498)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(789, 165)
        Me.Panel10.TabIndex = 148
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.SystemColors.Window
        Me.Panel11.Controls.Add(Me.GroupBox4)
        Me.Panel11.Location = New System.Drawing.Point(3, 3)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(783, 159)
        Me.Panel11.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TbDmdrTel)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.CtrlVilleDmdr)
        Me.GroupBox4.Controls.Add(Me.TbDmdrNom)
        Me.GroupBox4.Controls.Add(Me.TbDmdrAdresse)
        Me.GroupBox4.Controls.Add(Me.TbDmdrPrenom)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(737, 152)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Personne introduisant la demande"
        '
        'TbDmdrTel
        '
        Me.TbDmdrTel.Location = New System.Drawing.Point(93, 94)
        Me.TbDmdrTel.Name = "TbDmdrTel"
        Me.TbDmdrTel.Size = New System.Drawing.Size(142, 22)
        Me.TbDmdrTel.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Nom"
        '
        'CtrlVilleDmdr
        '
        Me.CtrlVilleDmdr.LectureSeule = False
        Me.CtrlVilleDmdr.Location = New System.Drawing.Point(307, 60)
        Me.CtrlVilleDmdr.LocVilleId = -1
        Me.CtrlVilleDmdr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CtrlVilleDmdr.Name = "CtrlVilleDmdr"
        Me.CtrlVilleDmdr.osef = Nothing
        Me.CtrlVilleDmdr.Size = New System.Drawing.Size(316, 25)
        Me.CtrlVilleDmdr.TabIndex = 7
        '
        'TbDmdrNom
        '
        Me.TbDmdrNom.Location = New System.Drawing.Point(93, 29)
        Me.TbDmdrNom.Name = "TbDmdrNom"
        Me.TbDmdrNom.Size = New System.Drawing.Size(142, 22)
        Me.TbDmdrNom.TabIndex = 0
        '
        'TbDmdrAdresse
        '
        Me.TbDmdrAdresse.Location = New System.Drawing.Point(93, 61)
        Me.TbDmdrAdresse.Name = "TbDmdrAdresse"
        Me.TbDmdrAdresse.Size = New System.Drawing.Size(171, 22)
        Me.TbDmdrAdresse.TabIndex = 6
        '
        'TbDmdrPrenom
        '
        Me.TbDmdrPrenom.Location = New System.Drawing.Point(371, 29)
        Me.TbDmdrPrenom.Name = "TbDmdrPrenom"
        Me.TbDmdrPrenom.Size = New System.Drawing.Size(142, 22)
        Me.TbDmdrPrenom.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 17)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Adresse"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(299, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 17)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Prénom"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 17)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Téléphone"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel12.Controls.Add(Me.Panel13)
        Me.FlowLayoutPanel1.SetFlowBreak(Me.Panel12, True)
        Me.Panel12.Location = New System.Drawing.Point(3, 669)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(789, 165)
        Me.Panel12.TabIndex = 149
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.SystemColors.Window
        Me.Panel13.Controls.Add(Me.GroupBox6)
        Me.Panel13.Location = New System.Drawing.Point(3, 3)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(783, 159)
        Me.Panel13.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.CbPCont)
        Me.GroupBox6.Controls.Add(Me.TbPcontTel)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.CtrlLocPcont)
        Me.GroupBox6.Controls.Add(Me.TbPcontNom)
        Me.GroupBox6.Controls.Add(Me.TbPcontAdresse)
        Me.GroupBox6.Controls.Add(Me.TbPcontPrenom)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Location = New System.Drawing.Point(7, 4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(737, 152)
        Me.GroupBox6.TabIndex = 8
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Personne de contact"
        '
        'TbPcontTel
        '
        Me.TbPcontTel.Enabled = False
        Me.TbPcontTel.Location = New System.Drawing.Point(93, 118)
        Me.TbPcontTel.Name = "TbPcontTel"
        Me.TbPcontTel.Size = New System.Drawing.Size(142, 22)
        Me.TbPcontTel.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Nom"
        '
        'CtrlLocPcont
        '
        Me.CtrlLocPcont.Enabled = False
        Me.CtrlLocPcont.LectureSeule = False
        Me.CtrlLocPcont.Location = New System.Drawing.Point(307, 84)
        Me.CtrlLocPcont.LocVilleId = -1
        Me.CtrlLocPcont.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CtrlLocPcont.Name = "CtrlLocPcont"
        Me.CtrlLocPcont.osef = Nothing
        Me.CtrlLocPcont.Size = New System.Drawing.Size(316, 25)
        Me.CtrlLocPcont.TabIndex = 7
        '
        'TbPcontNom
        '
        Me.TbPcontNom.Enabled = False
        Me.TbPcontNom.Location = New System.Drawing.Point(93, 53)
        Me.TbPcontNom.Name = "TbPcontNom"
        Me.TbPcontNom.Size = New System.Drawing.Size(142, 22)
        Me.TbPcontNom.TabIndex = 0
        '
        'TbPcontAdresse
        '
        Me.TbPcontAdresse.Enabled = False
        Me.TbPcontAdresse.Location = New System.Drawing.Point(93, 85)
        Me.TbPcontAdresse.Name = "TbPcontAdresse"
        Me.TbPcontAdresse.Size = New System.Drawing.Size(171, 22)
        Me.TbPcontAdresse.TabIndex = 6
        '
        'TbPcontPrenom
        '
        Me.TbPcontPrenom.Enabled = False
        Me.TbPcontPrenom.Location = New System.Drawing.Point(371, 53)
        Me.TbPcontPrenom.Name = "TbPcontPrenom"
        Me.TbPcontPrenom.Size = New System.Drawing.Size(142, 22)
        Me.TbPcontPrenom.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(21, 85)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 17)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Adresse"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(299, 53)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 17)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Prénom"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 118)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 17)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Téléphone"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.FlowLayoutPanel1.SetFlowBreak(Me.Panel5, True)
        Me.Panel5.Location = New System.Drawing.Point(3, 840)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(633, 100)
        Me.Panel5.TabIndex = 147
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Window
        Me.Panel6.Controls.Add(Me.CbEnregPdfP1)
        Me.Panel6.Controls.Add(Me.Label11)
        Me.Panel6.Controls.Add(Me.DtpDateSign)
        Me.Panel6.Controls.Add(Me.BtSuivant)
        Me.Panel6.Location = New System.Drawing.Point(3, 12)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(611, 64)
        Me.Panel6.TabIndex = 0
        '
        'CbEnregPdfP1
        '
        Me.CbEnregPdfP1.AutoSize = True
        Me.CbEnregPdfP1.Checked = True
        Me.CbEnregPdfP1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbEnregPdfP1.Location = New System.Drawing.Point(15, 37)
        Me.CbEnregPdfP1.Margin = New System.Windows.Forms.Padding(4)
        Me.CbEnregPdfP1.Name = "CbEnregPdfP1"
        Me.CbEnregPdfP1.Size = New System.Drawing.Size(188, 21)
        Me.CbEnregPdfP1.TabIndex = 9
        Me.CbEnregPdfP1.Text = "Enregistrer le fichier PDF"
        Me.CbEnregPdfP1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 17)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Fait le"
        '
        'DtpDateSign
        '
        Me.DtpDateSign.Location = New System.Drawing.Point(86, 5)
        Me.DtpDateSign.Name = "DtpDateSign"
        Me.DtpDateSign.ShowCheckBox = True
        Me.DtpDateSign.Size = New System.Drawing.Size(270, 22)
        Me.DtpDateSign.TabIndex = 1
        '
        'BtSuivant
        '
        Me.BtSuivant.BackColor = System.Drawing.Color.SeaGreen
        Me.BtSuivant.ForeColor = System.Drawing.Color.White
        Me.BtSuivant.Location = New System.Drawing.Point(479, 6)
        Me.BtSuivant.Name = "BtSuivant"
        Me.BtSuivant.Size = New System.Drawing.Size(113, 51)
        Me.BtSuivant.TabIndex = 0
        Me.BtSuivant.Text = "Suivant"
        Me.BtSuivant.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabP2ConExis)
        Me.TabControl1.Controls.Add(Me.TabP2InhOrd)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1060, 849)
        Me.TabControl1.TabIndex = 147
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.FlowLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1052, 820)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Début"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabP2ConExis
        '
        Me.TabP2ConExis.Controls.Add(Me.BtMontrerFormPlanCimCsnsExist)
        Me.TabP2ConExis.Controls.Add(Me.BtViderFiltreCsnsExist)
        Me.TabP2ConExis.Controls.Add(Me.TbFiltreCsnsExist)
        Me.TabP2ConExis.Controls.Add(Me.BtPrécédentDeConExis)
        Me.TabP2ConExis.Controls.Add(Me.LbTypeInhCsnExis)
        Me.TabP2ConExis.Controls.Add(Me.Panel3)
        Me.TabP2ConExis.Controls.Add(Me.GroupBox3)
        Me.TabP2ConExis.Controls.Add(Me.GroupBox1)
        Me.TabP2ConExis.Controls.Add(Me.BtTerminerConExis)
        Me.TabP2ConExis.Controls.Add(Me.DgvCsnsExist)
        Me.TabP2ConExis.Location = New System.Drawing.Point(4, 25)
        Me.TabP2ConExis.Name = "TabP2ConExis"
        Me.TabP2ConExis.Size = New System.Drawing.Size(1052, 820)
        Me.TabP2ConExis.TabIndex = 3
        Me.TabP2ConExis.Text = "fin concexis"
        Me.TabP2ConExis.UseVisualStyleBackColor = True
        '
        'BtMontrerFormPlanCimCsnsExist
        '
        Me.BtMontrerFormPlanCimCsnsExist.Image = Global.cimetiere.My.Resources.Resources.Note_16x
        Me.BtMontrerFormPlanCimCsnsExist.Location = New System.Drawing.Point(817, 9)
        Me.BtMontrerFormPlanCimCsnsExist.Name = "BtMontrerFormPlanCimCsnsExist"
        Me.BtMontrerFormPlanCimCsnsExist.Size = New System.Drawing.Size(34, 31)
        Me.BtMontrerFormPlanCimCsnsExist.TabIndex = 190
        Me.BtMontrerFormPlanCimCsnsExist.UseVisualStyleBackColor = True
        '
        'BtViderFiltreCsnsExist
        '
        Me.BtViderFiltreCsnsExist.Image = Global.cimetiere.My.Resources.Resources.Cancel_16x
        Me.BtViderFiltreCsnsExist.Location = New System.Drawing.Point(210, 9)
        Me.BtViderFiltreCsnsExist.Name = "BtViderFiltreCsnsExist"
        Me.BtViderFiltreCsnsExist.Size = New System.Drawing.Size(32, 29)
        Me.BtViderFiltreCsnsExist.TabIndex = 189
        Me.BtViderFiltreCsnsExist.UseVisualStyleBackColor = True
        '
        'TbFiltreCsnsExist
        '
        Me.TbFiltreCsnsExist.Location = New System.Drawing.Point(14, 12)
        Me.TbFiltreCsnsExist.Name = "TbFiltreCsnsExist"
        Me.TbFiltreCsnsExist.Size = New System.Drawing.Size(190, 22)
        Me.TbFiltreCsnsExist.TabIndex = 183
        '
        'BtPrécédentDeConExis
        '
        Me.BtPrécédentDeConExis.BackColor = System.Drawing.Color.SeaGreen
        Me.BtPrécédentDeConExis.ForeColor = System.Drawing.Color.Transparent
        Me.BtPrécédentDeConExis.Location = New System.Drawing.Point(543, 723)
        Me.BtPrécédentDeConExis.Margin = New System.Windows.Forms.Padding(4)
        Me.BtPrécédentDeConExis.Name = "BtPrécédentDeConExis"
        Me.BtPrécédentDeConExis.Size = New System.Drawing.Size(132, 59)
        Me.BtPrécédentDeConExis.TabIndex = 182
        Me.BtPrécédentDeConExis.Text = "Précédent"
        Me.BtPrécédentDeConExis.UseVisualStyleBackColor = False
        '
        'LbTypeInhCsnExis
        '
        Me.LbTypeInhCsnExis.FormattingEnabled = True
        Me.LbTypeInhCsnExis.ItemHeight = 16
        Me.LbTypeInhCsnExis.Items.AddRange(New Object() {"Urne", "Cercueil", "Pleine terre", "Caveau", "Cellule de colombarium", "Cavurne"})
        Me.LbTypeInhCsnExis.Location = New System.Drawing.Point(857, 49)
        Me.LbTypeInhCsnExis.Name = "LbTypeInhCsnExis"
        Me.LbTypeInhCsnExis.Size = New System.Drawing.Size(156, 212)
        Me.LbTypeInhCsnExis.TabIndex = 181
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Location = New System.Drawing.Point(28, 716)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(402, 76)
        Me.Panel3.TabIndex = 180
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.Window
        Me.Panel7.Controls.Add(Me.CbEnregPdfCsnExis)
        Me.Panel7.Location = New System.Drawing.Point(8, 7)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(387, 62)
        Me.Panel7.TabIndex = 0
        '
        'CbEnregPdfCsnExis
        '
        Me.CbEnregPdfCsnExis.AutoSize = True
        Me.CbEnregPdfCsnExis.Checked = True
        Me.CbEnregPdfCsnExis.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbEnregPdfCsnExis.Location = New System.Drawing.Point(6, 6)
        Me.CbEnregPdfCsnExis.Margin = New System.Windows.Forms.Padding(4)
        Me.CbEnregPdfCsnExis.Name = "CbEnregPdfCsnExis"
        Me.CbEnregPdfCsnExis.Size = New System.Drawing.Size(188, 21)
        Me.CbEnregPdfCsnExis.TabIndex = 8
        Me.CbEnregPdfCsnExis.Text = "Enregistrer le fichier PDF"
        Me.CbEnregPdfCsnExis.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LvCsnExisBenefs)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 520)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LvCsnExistOccupants)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 324)
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
        'BtTerminerConExis
        '
        Me.BtTerminerConExis.BackColor = System.Drawing.Color.SeaGreen
        Me.BtTerminerConExis.ForeColor = System.Drawing.Color.Transparent
        Me.BtTerminerConExis.Location = New System.Drawing.Point(713, 723)
        Me.BtTerminerConExis.Margin = New System.Windows.Forms.Padding(4)
        Me.BtTerminerConExis.Name = "BtTerminerConExis"
        Me.BtTerminerConExis.Size = New System.Drawing.Size(132, 59)
        Me.BtTerminerConExis.TabIndex = 172
        Me.BtTerminerConExis.Text = "Terminer"
        Me.BtTerminerConExis.UseVisualStyleBackColor = False
        '
        'DgvCsnsExist
        '
        Me.DgvCsnsExist.AllowUserToAddRows = False
        Me.DgvCsnsExist.AllowUserToDeleteRows = False
        Me.DgvCsnsExist.AllowUserToOrderColumns = True
        Me.DgvCsnsExist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvCsnsExist.BackgroundColor = System.Drawing.Color.White
        Me.DgvCsnsExist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCsnsExist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DgvCsnsExistColEmplId, Me.Column1, Me.Column4, Me.Column2, Me.Column3, Me.DgvCsnsExistColOccupants})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvCsnsExist.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvCsnsExist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvCsnsExist.Location = New System.Drawing.Point(8, 49)
        Me.DgvCsnsExist.MultiSelect = False
        Me.DgvCsnsExist.Name = "DgvCsnsExist"
        Me.DgvCsnsExist.ReadOnly = True
        Me.DgvCsnsExist.RowHeadersVisible = False
        Me.DgvCsnsExist.RowTemplate.Height = 24
        Me.DgvCsnsExist.SelectedRow = Nothing
        Me.DgvCsnsExist.SelectedRowIndex = -1
        Me.DgvCsnsExist.SelectedValue = -1
        Me.DgvCsnsExist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCsnsExist.Size = New System.Drawing.Size(843, 257)
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
        'TabP2InhOrd
        '
        Me.TabP2InhOrd.Controls.Add(Me.BtMontrerFormPlancimEmplOrd)
        Me.TabP2InhOrd.Controls.Add(Me.BtViderFiltreEmpls)
        Me.TabP2InhOrd.Controls.Add(Me.TbFiltreEmpls)
        Me.TabP2InhOrd.Controls.Add(Me.BtPrecedentDeInhOrd)
        Me.TabP2InhOrd.Controls.Add(Me.Panel8)
        Me.TabP2InhOrd.Controls.Add(Me.BtTerminerInhOrd)
        Me.TabP2InhOrd.Controls.Add(Me.GroupBox5)
        Me.TabP2InhOrd.Controls.Add(Me.DgvEmplacementsPourInhOrd)
        Me.TabP2InhOrd.Location = New System.Drawing.Point(4, 25)
        Me.TabP2InhOrd.Name = "TabP2InhOrd"
        Me.TabP2InhOrd.Size = New System.Drawing.Size(1052, 820)
        Me.TabP2InhOrd.TabIndex = 4
        Me.TabP2InhOrd.Text = "TabP2InhOrd"
        Me.TabP2InhOrd.UseVisualStyleBackColor = True
        '
        'BtMontrerFormPlancimEmplOrd
        '
        Me.BtMontrerFormPlancimEmplOrd.Image = Global.cimetiere.My.Resources.Resources.Note_16x
        Me.BtMontrerFormPlancimEmplOrd.Location = New System.Drawing.Point(660, 10)
        Me.BtMontrerFormPlancimEmplOrd.Name = "BtMontrerFormPlancimEmplOrd"
        Me.BtMontrerFormPlancimEmplOrd.Size = New System.Drawing.Size(34, 31)
        Me.BtMontrerFormPlancimEmplOrd.TabIndex = 179
        Me.BtMontrerFormPlancimEmplOrd.UseVisualStyleBackColor = True
        '
        'BtViderFiltreEmpls
        '
        Me.BtViderFiltreEmpls.Image = Global.cimetiere.My.Resources.Resources.Cancel_16x
        Me.BtViderFiltreEmpls.Location = New System.Drawing.Point(210, 10)
        Me.BtViderFiltreEmpls.Name = "BtViderFiltreEmpls"
        Me.BtViderFiltreEmpls.Size = New System.Drawing.Size(32, 29)
        Me.BtViderFiltreEmpls.TabIndex = 191
        Me.BtViderFiltreEmpls.UseVisualStyleBackColor = True
        '
        'TbFiltreEmpls
        '
        Me.TbFiltreEmpls.Location = New System.Drawing.Point(14, 13)
        Me.TbFiltreEmpls.Name = "TbFiltreEmpls"
        Me.TbFiltreEmpls.Size = New System.Drawing.Size(190, 22)
        Me.TbFiltreEmpls.TabIndex = 190
        '
        'BtPrecedentDeInhOrd
        '
        Me.BtPrecedentDeInhOrd.BackColor = System.Drawing.Color.SeaGreen
        Me.BtPrecedentDeInhOrd.ForeColor = System.Drawing.Color.Transparent
        Me.BtPrecedentDeInhOrd.Location = New System.Drawing.Point(508, 533)
        Me.BtPrecedentDeInhOrd.Margin = New System.Windows.Forms.Padding(4)
        Me.BtPrecedentDeInhOrd.Name = "BtPrecedentDeInhOrd"
        Me.BtPrecedentDeInhOrd.Size = New System.Drawing.Size(132, 59)
        Me.BtPrecedentDeInhOrd.TabIndex = 186
        Me.BtPrecedentDeInhOrd.Text = "Précédent"
        Me.BtPrecedentDeInhOrd.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Location = New System.Drawing.Point(24, 520)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(402, 76)
        Me.Panel8.TabIndex = 185
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.Window
        Me.Panel9.Controls.Add(Me.CbEnregPdfInhOrd)
        Me.Panel9.Location = New System.Drawing.Point(8, 7)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(387, 62)
        Me.Panel9.TabIndex = 0
        '
        'CbEnregPdfInhOrd
        '
        Me.CbEnregPdfInhOrd.AutoSize = True
        Me.CbEnregPdfInhOrd.Checked = True
        Me.CbEnregPdfInhOrd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbEnregPdfInhOrd.Location = New System.Drawing.Point(6, 6)
        Me.CbEnregPdfInhOrd.Margin = New System.Windows.Forms.Padding(4)
        Me.CbEnregPdfInhOrd.Name = "CbEnregPdfInhOrd"
        Me.CbEnregPdfInhOrd.Size = New System.Drawing.Size(188, 21)
        Me.CbEnregPdfInhOrd.TabIndex = 8
        Me.CbEnregPdfInhOrd.Text = "Enregistrer le fichier PDF"
        Me.CbEnregPdfInhOrd.UseVisualStyleBackColor = True
        '
        'BtTerminerInhOrd
        '
        Me.BtTerminerInhOrd.BackColor = System.Drawing.Color.SeaGreen
        Me.BtTerminerInhOrd.ForeColor = System.Drawing.Color.Transparent
        Me.BtTerminerInhOrd.Location = New System.Drawing.Point(706, 532)
        Me.BtTerminerInhOrd.Margin = New System.Windows.Forms.Padding(4)
        Me.BtTerminerInhOrd.Name = "BtTerminerInhOrd"
        Me.BtTerminerInhOrd.Size = New System.Drawing.Size(132, 59)
        Me.BtTerminerInhOrd.TabIndex = 184
        Me.BtTerminerInhOrd.Text = "Terminer"
        Me.BtTerminerInhOrd.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.LvOccupantsInhOrdEmpl)
        Me.GroupBox5.Location = New System.Drawing.Point(18, 307)
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
        'DgvEmplacementsPourInhOrd
        '
        Me.DgvEmplacementsPourInhOrd.AllowUserToAddRows = False
        Me.DgvEmplacementsPourInhOrd.AllowUserToDeleteRows = False
        Me.DgvEmplacementsPourInhOrd.AllowUserToOrderColumns = True
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
        Me.DgvEmplacementsPourInhOrd.Location = New System.Drawing.Point(13, 47)
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
        'CbPCont
        '
        Me.CbPCont.AutoSize = True
        Me.CbPCont.Location = New System.Drawing.Point(12, 21)
        Me.CbPCont.Name = "CbPCont"
        Me.CbPCont.Size = New System.Drawing.Size(358, 21)
        Me.CbPCont.TabIndex = 9
        Me.CbPCont.Text = "Enregistrer une personne de contact pour ce défunt"
        Me.CbPCont.UseVisualStyleBackColor = True
        '
        'FormDemandeInhumation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1060, 849)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FormDemandeInhumation"
        Me.Text = "FormDemandeInhumation"
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabP2ConExis.ResumeLayout(False)
        Me.TabP2ConExis.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvCsnsExist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabP2InhOrd.ResumeLayout(False)
        Me.TabP2InhOrd.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DgvEmplacementsPourInhOrd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents GroupBox2 As GroupBox
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RbInhOrd As RadioButton
    Friend WithEvents RbNouvelleCon As RadioButton
    Friend WithEvents RbConcExis As RadioButton
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
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
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents CbEnregPdfCsnExis As CheckBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents LbTypeInhOrd As ListBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents TbDmdrPrenom As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TbDmdrNom As TextBox
    Friend WithEvents TbDmdrAdresse As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox4 As GroupBox
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
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
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
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents GroupBox6 As GroupBox
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
End Class
