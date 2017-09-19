<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEditDefunt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditDefunt))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbPrénom = New System.Windows.Forms.TextBox()
        Me.TbAdresse = New System.Windows.Forms.TextBox()
        Me.TbNom = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TbLieuDécès = New System.Windows.Forms.TextBox()
        Me.TbLieuNaiss = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TbintNumAnnée = New cimetiere.TextBoxInt()
        Me.TbintNumLh = New cimetiere.TextBoxInt()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CtrlLocVillePays1 = New cimetiere.CtrlLocVillePays()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TbdDateDécès = New cimetiere.TextBoxDate()
        Me.TbdDateNaiss = New cimetiere.TextBoxDate()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CtrlEtatCivil = New cimetiere.CtrlEtatCivil()
        Me.BtAnnuler = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.CbEmplacement = New cimetiere.ComboBoxEmplacements()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtEnregistrer = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 17)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "État civil"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 17)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Adresse"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 17)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Décédé le"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(249, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Prénom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Nom"
        '
        'TbPrénom
        '
        Me.TbPrénom.Location = New System.Drawing.Point(312, 16)
        Me.TbPrénom.Name = "TbPrénom"
        Me.TbPrénom.Size = New System.Drawing.Size(132, 22)
        Me.TbPrénom.TabIndex = 23
        '
        'TbAdresse
        '
        Me.TbAdresse.Location = New System.Drawing.Point(77, 30)
        Me.TbAdresse.Name = "TbAdresse"
        Me.TbAdresse.Size = New System.Drawing.Size(225, 22)
        Me.TbAdresse.TabIndex = 21
        '
        'TbNom
        '
        Me.TbNom.Location = New System.Drawing.Point(96, 16)
        Me.TbNom.Name = "TbNom"
        Me.TbNom.Size = New System.Drawing.Size(132, 22)
        Me.TbNom.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(259, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 17)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "à"
        '
        'TbLieuDécès
        '
        Me.TbLieuDécès.Location = New System.Drawing.Point(291, 63)
        Me.TbLieuDécès.Name = "TbLieuDécès"
        Me.TbLieuDécès.Size = New System.Drawing.Size(132, 22)
        Me.TbLieuDécès.TabIndex = 41
        '
        'TbLieuNaiss
        '
        Me.TbLieuNaiss.Location = New System.Drawing.Point(291, 26)
        Me.TbLieuNaiss.Name = "TbLieuNaiss"
        Me.TbLieuNaiss.Size = New System.Drawing.Size(132, 22)
        Me.TbLieuNaiss.TabIndex = 45
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(259, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(16, 17)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "à"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 31)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 17)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Né le"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(5, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 17)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "Code défunt"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(221, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 17)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "Code année"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TbintNumAnnée)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TbNom)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.TbPrénom)
        Me.GroupBox1.Controls.Add(Me.TbintNumLh)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(471, 106)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        '
        'TbintNumAnnée
        '
        Me.TbintNumAnnée.Location = New System.Drawing.Point(312, 48)
        Me.TbintNumAnnée.Name = "TbintNumAnnée"
        Me.TbintNumAnnée.Size = New System.Drawing.Size(100, 22)
        Me.TbintNumAnnée.TabIndex = 49
        Me.TbintNumAnnée.Value = Nothing
        '
        'TbintNumLh
        '
        Me.TbintNumLh.Location = New System.Drawing.Point(96, 45)
        Me.TbintNumLh.Name = "TbintNumLh"
        Me.TbintNumLh.Size = New System.Drawing.Size(100, 22)
        Me.TbintNumLh.TabIndex = 47
        Me.TbintNumLh.Value = Nothing
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.CtrlLocVillePays1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TbAdresse)
        Me.GroupBox2.Location = New System.Drawing.Point(484, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(446, 155)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 17)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Ville"
        '
        'CtrlLocVillePays1
        '
        Me.CtrlLocVillePays1.Location = New System.Drawing.Point(77, 64)
        Me.CtrlLocVillePays1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CtrlLocVillePays1.Name = "CtrlLocVillePays1"
        Me.CtrlLocVillePays1.Size = New System.Drawing.Size(316, 25)
        Me.CtrlLocVillePays1.TabIndex = 32
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TbdDateDécès)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.TbLieuNaiss)
        Me.GroupBox3.Controls.Add(Me.TbLieuDécès)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.TbdDateNaiss)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 112)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(471, 105)
        Me.GroupBox3.TabIndex = 52
        Me.GroupBox3.TabStop = False
        '
        'TbdDateDécès
        '
        Me.TbdDateDécès.DateValue = Nothing
        Me.TbdDateDécès.Location = New System.Drawing.Point(85, 65)
        Me.TbdDateDécès.Mask = "00/00/0000"
        Me.TbdDateDécès.Name = "TbdDateDécès"
        Me.TbdDateDécès.Size = New System.Drawing.Size(123, 22)
        Me.TbdDateDécès.TabIndex = 33
        Me.TbdDateDécès.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbdDateNaiss
        '
        Me.TbdDateNaiss.DateValue = Nothing
        Me.TbdDateNaiss.Location = New System.Drawing.Point(85, 28)
        Me.TbdDateNaiss.Mask = "00/00/0000"
        Me.TbdDateNaiss.Name = "TbdDateNaiss"
        Me.TbdDateNaiss.Size = New System.Drawing.Size(123, 22)
        Me.TbdDateNaiss.TabIndex = 43
        Me.TbdDateNaiss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CtrlEtatCivil)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Location = New System.Drawing.Point(484, 162)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(446, 52)
        Me.GroupBox4.TabIndex = 53
        Me.GroupBox4.TabStop = False
        '
        'CtrlEtatCivil
        '
        Me.CtrlEtatCivil.EtatCivil = cimetiere.TEtatCivil.NonPrecise
        Me.CtrlEtatCivil.EtatCivilDe = ""
        Me.CtrlEtatCivil.Location = New System.Drawing.Point(72, 18)
        Me.CtrlEtatCivil.Name = "CtrlEtatCivil"
        Me.CtrlEtatCivil.Size = New System.Drawing.Size(368, 24)
        Me.CtrlEtatCivil.TabIndex = 37
        '
        'BtAnnuler
        '
        Me.BtAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtAnnuler.Location = New System.Drawing.Point(816, 238)
        Me.BtAnnuler.Name = "BtAnnuler"
        Me.BtAnnuler.Size = New System.Drawing.Size(99, 32)
        Me.BtAnnuler.TabIndex = 55
        Me.BtAnnuler.Text = "Annuler"
        Me.BtAnnuler.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CbEmplacement)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 223)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(471, 54)
        Me.GroupBox5.TabIndex = 56
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Emplacement"
        '
        'CbEmplacement
        '
        Me.CbEmplacement.DisplayMember = "empl_reference"
        Me.CbEmplacement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbEmplacement.FormattingEnabled = True
        Me.CbEmplacement.Location = New System.Drawing.Point(8, 21)
        Me.CbEmplacement.Name = "CbEmplacement"
        Me.CbEmplacement.Size = New System.Drawing.Size(121, 24)
        Me.CbEmplacement.TabIndex = 1
        Me.CbEmplacement.ValueMember = "empl_id"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'BtEnregistrer
        '
        Me.BtEnregistrer.Location = New System.Drawing.Point(663, 238)
        Me.BtEnregistrer.Name = "BtEnregistrer"
        Me.BtEnregistrer.Size = New System.Drawing.Size(96, 32)
        Me.BtEnregistrer.TabIndex = 57
        Me.BtEnregistrer.Text = "Enregistrer"
        Me.BtEnregistrer.UseVisualStyleBackColor = True
        '
        'FormEditDefunt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 289)
        Me.Controls.Add(Me.BtEnregistrer)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.BtAnnuler)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormEditDefunt"
        Me.Text = "Informations d'un défunt"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label9 As Label
    Friend WithEvents TbdDateDécès As TextBoxDate
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TbPrénom As TextBox
    Friend WithEvents TbAdresse As TextBox
    Friend WithEvents TbNom As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TbLieuDécès As TextBox
    Friend WithEvents TbLieuNaiss As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TbdDateNaiss As TextBoxDate
    Friend WithEvents Label13 As Label
    Friend WithEvents TbintNumLh As TextBoxInt
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BtAnnuler As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TbintNumAnnée As TextBoxInt
    Friend WithEvents CtrlEtatCivil As CtrlEtatCivil
    Friend WithEvents Label3 As Label
    Friend WithEvents CtrlLocVillePays1 As CtrlLocVillePays
    Friend WithEvents CbEmplacement As ComboBoxEmplacements
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtEnregistrer As Button
End Class
