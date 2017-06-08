<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelEditDéfunt
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CtrlEtatCivil = New cimetiere.CtrlEtatCivil()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TbintNoNat = New cimetiere.TextBoxInt64()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbAdresse = New System.Windows.Forms.TextBox()
        Me.TbVille = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbintCp = New cimetiere.TextBoxInt()
        Me.TbPays = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbNumAnnée = New System.Windows.Forms.TextBox()
        Me.TbNom = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TbPrénom = New System.Windows.Forms.TextBox()
        Me.TbNumLh = New cimetiere.TextBoxInt()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TbLieuNaiss = New System.Windows.Forms.TextBox()
        Me.TbLieuDécès = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbdateDateDécès = New cimetiere.TextBoxDate()
        Me.TbdateDateNaiss = New cimetiere.TextBoxDate()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CtrlEtatCivil)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.TbintNoNat)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Location = New System.Drawing.Point(466, 109)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(446, 100)
        Me.GroupBox4.TabIndex = 57
        Me.GroupBox4.TabStop = False
        '
        'CtrlEtatCivil
        '
        Me.CtrlEtatCivil.EtatCivil = cimetiere.TEtatCivil.NonPrecise
        Me.CtrlEtatCivil.EtatCivilDe = ""
        Me.CtrlEtatCivil.Location = New System.Drawing.Point(89, 24)
        Me.CtrlEtatCivil.Name = "CtrlEtatCivil"
        Me.CtrlEtatCivil.Size = New System.Drawing.Size(331, 24)
        Me.CtrlEtatCivil.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 17)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "État civil"
        '
        'TbintNoNat
        '
        Me.TbintNoNat.Location = New System.Drawing.Point(90, 60)
        Me.TbintNoNat.Name = "TbintNoNat"
        Me.TbintNoNat.Size = New System.Drawing.Size(123, 22)
        Me.TbintNoNat.TabIndex = 35
        Me.TbintNoNat.Value = Nothing
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 17)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "N° national"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TbAdresse)
        Me.GroupBox2.Controls.Add(Me.TbVille)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TbintCp)
        Me.GroupBox2.Controls.Add(Me.TbPays)
        Me.GroupBox2.Location = New System.Drawing.Point(466, -3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(446, 106)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
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
        'TbAdresse
        '
        Me.TbAdresse.Location = New System.Drawing.Point(77, 30)
        Me.TbAdresse.Name = "TbAdresse"
        Me.TbAdresse.Size = New System.Drawing.Size(132, 22)
        Me.TbAdresse.TabIndex = 21
        '
        'TbVille
        '
        Me.TbVille.Location = New System.Drawing.Point(77, 61)
        Me.TbVille.Name = "TbVille"
        Me.TbVille.Size = New System.Drawing.Size(132, 22)
        Me.TbVille.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 17)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Ville"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(251, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 17)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "CP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(238, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 17)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Pays"
        '
        'TbintCp
        '
        Me.TbintCp.Location = New System.Drawing.Point(283, 33)
        Me.TbintCp.Name = "TbintCp"
        Me.TbintCp.Size = New System.Drawing.Size(100, 22)
        Me.TbintCp.TabIndex = 32
        Me.TbintCp.Value = Nothing
        '
        'TbPays
        '
        Me.TbPays.Location = New System.Drawing.Point(283, 66)
        Me.TbPays.Name = "TbPays"
        Me.TbPays.Size = New System.Drawing.Size(132, 22)
        Me.TbPays.TabIndex = 34
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TbNumAnnée)
        Me.GroupBox1.Controls.Add(Me.TbNom)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.TbPrénom)
        Me.GroupBox1.Controls.Add(Me.TbNumLh)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Location = New System.Drawing.Point(0, -3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(446, 106)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
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
        'TbNumAnnée
        '
        Me.TbNumAnnée.Location = New System.Drawing.Point(302, 45)
        Me.TbNumAnnée.Name = "TbNumAnnée"
        Me.TbNumAnnée.Size = New System.Drawing.Size(132, 22)
        Me.TbNumAnnée.TabIndex = 49
        '
        'TbNom
        '
        Me.TbNom.Location = New System.Drawing.Point(96, 16)
        Me.TbNom.Name = "TbNom"
        Me.TbNom.Size = New System.Drawing.Size(132, 22)
        Me.TbNom.TabIndex = 20
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(211, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 17)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "Code année"
        '
        'TbPrénom
        '
        Me.TbPrénom.Location = New System.Drawing.Point(302, 16)
        Me.TbPrénom.Name = "TbPrénom"
        Me.TbPrénom.Size = New System.Drawing.Size(132, 22)
        Me.TbPrénom.TabIndex = 23
        '
        'TbNumLh
        '
        Me.TbNumLh.Location = New System.Drawing.Point(96, 45)
        Me.TbNumLh.Name = "TbNumLh"
        Me.TbNumLh.Size = New System.Drawing.Size(100, 22)
        Me.TbNumLh.TabIndex = 47
        Me.TbNumLh.Value = Nothing
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(239, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Prénom"
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(259, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 17)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "à"
        '
        'TbLieuNaiss
        '
        Me.TbLieuNaiss.Location = New System.Drawing.Point(291, 55)
        Me.TbLieuNaiss.Name = "TbLieuNaiss"
        Me.TbLieuNaiss.Size = New System.Drawing.Size(132, 22)
        Me.TbLieuNaiss.TabIndex = 45
        '
        'TbLieuDécès
        '
        Me.TbLieuDécès.Location = New System.Drawing.Point(291, 24)
        Me.TbLieuDécès.Name = "TbLieuDécès"
        Me.TbLieuDécès.Size = New System.Drawing.Size(132, 22)
        Me.TbLieuDécès.TabIndex = 41
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(259, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(16, 17)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "à"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(30, 60)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 17)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Né le"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TbdateDateDécès)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.TbLieuNaiss)
        Me.GroupBox3.Controls.Add(Me.TbLieuDécès)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.TbdateDateNaiss)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 104)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(446, 105)
        Me.GroupBox3.TabIndex = 56
        Me.GroupBox3.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 17)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Décédé le"
        '
        'TbdateDateDécès
        '
        Me.TbdateDateDécès.DateValue = Nothing
        Me.TbdateDateDécès.Location = New System.Drawing.Point(85, 26)
        Me.TbdateDateDécès.Mask = "00/00/0000"
        Me.TbdateDateDécès.Name = "TbdateDateDécès"
        Me.TbdateDateDécès.Size = New System.Drawing.Size(123, 22)
        Me.TbdateDateDécès.TabIndex = 33
        Me.TbdateDateDécès.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbdateDateNaiss
        '
        Me.TbdateDateNaiss.DateValue = Nothing
        Me.TbdateDateNaiss.Location = New System.Drawing.Point(85, 57)
        Me.TbdateDateNaiss.Mask = "00/00/0000"
        Me.TbdateDateNaiss.Name = "TbdateDateNaiss"
        Me.TbdateDateNaiss.Size = New System.Drawing.Size(123, 22)
        Me.TbdateDateNaiss.TabIndex = 43
        Me.TbdateDateNaiss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PanelEditDéfunt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "PanelEditDéfunt"
        Me.Size = New System.Drawing.Size(921, 217)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TbintNoNat As TextBoxInt64
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TbAdresse As TextBox
    Friend WithEvents TbVille As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TbintCp As TextBoxInt
    Friend WithEvents TbPays As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TbNumAnnée As TextBox
    Friend WithEvents TbNom As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TbPrénom As TextBox
    Friend WithEvents TbNumLh As TextBoxInt
    Friend WithEvents Label2 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TbLieuNaiss As TextBox
    Friend WithEvents TbLieuDécès As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TbdateDateNaiss As TextBoxDate
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TbdateDateDécès As TextBoxDate
    Friend WithEvents CtrlEtatCivil As CtrlEtatCivil
End Class
