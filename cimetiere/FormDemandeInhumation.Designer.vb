<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDemandeInhumation
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBoxDate2 = New cimetiere.TextBoxDate()
        Me.TextBoxDate1 = New cimetiere.TextBoxDate()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CtrlEtatCivil1 = New cimetiere.CtrlEtatCivil()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CtrlLocVillePays2 = New cimetiere.CtrlLocVillePays()
        Me.FPTBLieuNaiss = New System.Windows.Forms.TextBox()
        Me.FPLLieuNaiss = New System.Windows.Forms.Label()
        Me.FPTBCodePostal = New System.Windows.Forms.TextBox()
        Me.FPLCodePostal = New System.Windows.Forms.Label()
        Me.FPTBAdresse = New System.Windows.Forms.TextBox()
        Me.FPLAdresse = New System.Windows.Forms.Label()
        Me.FPTBPrenom = New System.Windows.Forms.TextBox()
        Me.FPLDateM = New System.Windows.Forms.Label()
        Me.FPLPrenom = New System.Windows.Forms.Label()
        Me.FPLDateNaiss = New System.Windows.Forms.Label()
        Me.FPTBNom = New System.Windows.Forms.TextBox()
        Me.FPLNom = New System.Windows.Forms.Label()
        Me.TbDateDeces = New cimetiere.TextBoxDate()
        Me.Panel4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel4.Controls.Add(Me.GroupBox2)
        Me.Panel4.Location = New System.Drawing.Point(25, 21)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(724, 294)
        Me.Panel4.TabIndex = 144
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.TextBoxDate2)
        Me.GroupBox2.Controls.Add(Me.TextBoxDate1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.CtrlEtatCivil1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.CtrlLocVillePays2)
        Me.GroupBox2.Controls.Add(Me.FPTBLieuNaiss)
        Me.GroupBox2.Controls.Add(Me.FPLLieuNaiss)
        Me.GroupBox2.Controls.Add(Me.FPTBCodePostal)
        Me.GroupBox2.Controls.Add(Me.FPLCodePostal)
        Me.GroupBox2.Controls.Add(Me.FPTBAdresse)
        Me.GroupBox2.Controls.Add(Me.FPLAdresse)
        Me.GroupBox2.Controls.Add(Me.FPTBPrenom)
        Me.GroupBox2.Controls.Add(Me.FPLDateM)
        Me.GroupBox2.Controls.Add(Me.FPLPrenom)
        Me.GroupBox2.Controls.Add(Me.FPLDateNaiss)
        Me.GroupBox2.Controls.Add(Me.FPTBNom)
        Me.GroupBox2.Controls.Add(Me.FPLNom)
        Me.GroupBox2.Controls.Add(Me.TbDateDeces)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 16)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(681, 259)
        Me.GroupBox2.TabIndex = 93
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informations du défunt"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(461, 182)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(201, 22)
        Me.TextBox1.TabIndex = 147
        '
        'TextBoxDate2
        '
        Me.TextBoxDate2.DateValue = Nothing
        Me.TextBoxDate2.Location = New System.Drawing.Point(159, 182)
        Me.TextBoxDate2.Mask = "00/00/0000"
        Me.TextBoxDate2.Name = "TextBoxDate2"
        Me.TextBoxDate2.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxDate2.TabIndex = 146
        Me.TextBoxDate2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxDate1
        '
        Me.TextBoxDate1.DateValue = Nothing
        Me.TextBoxDate1.Location = New System.Drawing.Point(159, 141)
        Me.TextBoxDate1.Mask = "00/00/0000"
        Me.TextBoxDate1.Name = "TextBoxDate1"
        Me.TextBoxDate1.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxDate1.TabIndex = 145
        Me.TextBoxDate1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 184)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 144
        Me.Label4.Text = "Décédé le :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 226)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 143
        Me.Label2.Text = "Etat civil :"
        '
        'CtrlEtatCivil1
        '
        Me.CtrlEtatCivil1.EtatCivil = cimetiere.TEtatCivil.NonPrecise
        Me.CtrlEtatCivil1.EtatCivilDe = ""
        Me.CtrlEtatCivil1.Location = New System.Drawing.Point(159, 223)
        Me.CtrlEtatCivil1.Name = "CtrlEtatCivil1"
        Me.CtrlEtatCivil1.Size = New System.Drawing.Size(369, 24)
        Me.CtrlEtatCivil1.TabIndex = 142
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 103)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 141
        Me.Label1.Text = "Ville :"
        '
        'CtrlLocVillePays2
        '
        Me.CtrlLocVillePays2.Location = New System.Drawing.Point(159, 99)
        Me.CtrlLocVillePays2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CtrlLocVillePays2.Name = "CtrlLocVillePays2"
        Me.CtrlLocVillePays2.Size = New System.Drawing.Size(316, 25)
        Me.CtrlLocVillePays2.TabIndex = 140
        '
        'FPTBLieuNaiss
        '
        Me.FPTBLieuNaiss.Location = New System.Drawing.Point(461, 141)
        Me.FPTBLieuNaiss.Margin = New System.Windows.Forms.Padding(4)
        Me.FPTBLieuNaiss.Name = "FPTBLieuNaiss"
        Me.FPTBLieuNaiss.Size = New System.Drawing.Size(201, 22)
        Me.FPTBLieuNaiss.TabIndex = 139
        '
        'FPLLieuNaiss
        '
        Me.FPLLieuNaiss.AutoSize = True
        Me.FPLLieuNaiss.Location = New System.Drawing.Point(404, 143)
        Me.FPLLieuNaiss.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FPLLieuNaiss.Name = "FPLLieuNaiss"
        Me.FPLLieuNaiss.Size = New System.Drawing.Size(46, 17)
        Me.FPLLieuNaiss.TabIndex = 138
        Me.FPLLieuNaiss.Text = "Né à :"
        '
        'FPTBCodePostal
        '
        Me.FPTBCodePostal.Location = New System.Drawing.Point(461, 62)
        Me.FPTBCodePostal.Margin = New System.Windows.Forms.Padding(4)
        Me.FPTBCodePostal.Name = "FPTBCodePostal"
        Me.FPTBCodePostal.Size = New System.Drawing.Size(201, 22)
        Me.FPTBCodePostal.TabIndex = 133
        '
        'FPLCodePostal
        '
        Me.FPLCodePostal.AutoSize = True
        Me.FPLCodePostal.Location = New System.Drawing.Point(369, 62)
        Me.FPLCodePostal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FPLCodePostal.Name = "FPLCodePostal"
        Me.FPLCodePostal.Size = New System.Drawing.Size(83, 17)
        Me.FPLCodePostal.TabIndex = 132
        Me.FPLCodePostal.Text = "Code postal"
        '
        'FPTBAdresse
        '
        Me.FPTBAdresse.Location = New System.Drawing.Point(159, 58)
        Me.FPTBAdresse.Margin = New System.Windows.Forms.Padding(4)
        Me.FPTBAdresse.Name = "FPTBAdresse"
        Me.FPTBAdresse.Size = New System.Drawing.Size(201, 22)
        Me.FPTBAdresse.TabIndex = 131
        '
        'FPLAdresse
        '
        Me.FPLAdresse.AutoSize = True
        Me.FPLAdresse.Location = New System.Drawing.Point(77, 62)
        Me.FPLAdresse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FPLAdresse.Name = "FPLAdresse"
        Me.FPLAdresse.Size = New System.Drawing.Size(68, 17)
        Me.FPLAdresse.TabIndex = 130
        Me.FPLAdresse.Text = "Adresse :"
        '
        'FPTBPrenom
        '
        Me.FPTBPrenom.Location = New System.Drawing.Point(461, 25)
        Me.FPTBPrenom.Margin = New System.Windows.Forms.Padding(4)
        Me.FPTBPrenom.Name = "FPTBPrenom"
        Me.FPTBPrenom.Size = New System.Drawing.Size(201, 22)
        Me.FPTBPrenom.TabIndex = 126
        '
        'FPLDateM
        '
        Me.FPLDateM.AutoSize = True
        Me.FPLDateM.Location = New System.Drawing.Point(373, 185)
        Me.FPLDateM.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FPLDateM.Name = "FPLDateM"
        Me.FPLDateM.Size = New System.Drawing.Size(77, 17)
        Me.FPLDateM.TabIndex = 123
        Me.FPLDateM.Text = "Décédé à :"
        '
        'FPLPrenom
        '
        Me.FPLPrenom.AutoSize = True
        Me.FPLPrenom.Location = New System.Drawing.Point(388, 25)
        Me.FPLPrenom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FPLPrenom.Name = "FPLPrenom"
        Me.FPLPrenom.Size = New System.Drawing.Size(65, 17)
        Me.FPLPrenom.TabIndex = 122
        Me.FPLPrenom.Text = "Prenom :"
        '
        'FPLDateNaiss
        '
        Me.FPLDateNaiss.AutoSize = True
        Me.FPLDateNaiss.Location = New System.Drawing.Point(95, 142)
        Me.FPLDateNaiss.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FPLDateNaiss.Name = "FPLDateNaiss"
        Me.FPLDateNaiss.Size = New System.Drawing.Size(49, 17)
        Me.FPLDateNaiss.TabIndex = 116
        Me.FPLDateNaiss.Text = "Né le :"
        '
        'FPTBNom
        '
        Me.FPTBNom.Location = New System.Drawing.Point(159, 17)
        Me.FPTBNom.Margin = New System.Windows.Forms.Padding(4)
        Me.FPTBNom.Name = "FPTBNom"
        Me.FPTBNom.Size = New System.Drawing.Size(201, 22)
        Me.FPTBNom.TabIndex = 115
        '
        'FPLNom
        '
        Me.FPLNom.AutoSize = True
        Me.FPLNom.Location = New System.Drawing.Point(87, 21)
        Me.FPLNom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FPLNom.Name = "FPLNom"
        Me.FPLNom.Size = New System.Drawing.Size(45, 17)
        Me.FPLNom.TabIndex = 114
        Me.FPLNom.Text = "Nom :"
        '
        'TbDateDeces
        '
        Me.TbDateDeces.DateValue = Nothing
        Me.TbDateDeces.Location = New System.Drawing.Point(1135, 498)
        Me.TbDateDeces.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TbDateDeces.Mask = "00/00/0000"
        Me.TbDateDeces.Name = "TbDateDeces"
        Me.TbDateDeces.Size = New System.Drawing.Size(100, 22)
        Me.TbDateDeces.TabIndex = 113
        Me.TbDateDeces.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FormDemandeInhumation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 337)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "FormDemandeInhumation"
        Me.Text = "FormDemandeInhumation"
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBoxDate2 As TextBoxDate
    Friend WithEvents TextBoxDate1 As TextBoxDate
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CtrlEtatCivil1 As CtrlEtatCivil
    Friend WithEvents Label1 As Label
    Friend WithEvents CtrlLocVillePays2 As CtrlLocVillePays
    Friend WithEvents FPTBLieuNaiss As TextBox
    Friend WithEvents FPLLieuNaiss As Label
    Friend WithEvents FPTBCodePostal As TextBox
    Friend WithEvents FPLCodePostal As Label
    Friend WithEvents FPTBAdresse As TextBox
    Friend WithEvents FPLAdresse As Label
    Friend WithEvents FPTBPrenom As TextBox
    Friend WithEvents FPLDateM As Label
    Friend WithEvents FPLPrenom As Label
    Friend WithEvents FPLDateNaiss As Label
    Friend WithEvents FPTBNom As TextBox
    Friend WithEvents FPLNom As Label
    Friend WithEvents TbDateDeces As TextBoxDate
End Class
