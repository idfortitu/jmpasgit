<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelEditBénéficiaire
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TbTel = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbdateDateNaiss = New cimetiere.TextBoxDate()
        Me.TbintNoNat = New cimetiere.TextBoxInt64()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbAdresse = New System.Windows.Forms.TextBox()
        Me.TbVille = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbPays = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbintCp = New cimetiere.TextBoxInt()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbNom = New System.Windows.Forms.TextBox()
        Me.TbPrénom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.TbTel)
        Me.GroupBox4.Location = New System.Drawing.Point(5, 174)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(438, 59)
        Me.GroupBox4.TabIndex = 63
        Me.GroupBox4.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 17)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Téléphone"
        '
        'TbTel
        '
        Me.TbTel.Location = New System.Drawing.Point(88, 25)
        Me.TbTel.Name = "TbTel"
        Me.TbTel.Size = New System.Drawing.Size(116, 22)
        Me.TbTel.TabIndex = 19
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TbdateDateNaiss)
        Me.GroupBox3.Controls.Add(Me.TbintNoNat)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 239)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(438, 88)
        Me.GroupBox3.TabIndex = 62
        Me.GroupBox3.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Date de naissance"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(54, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "N° national"
        '
        'TbdateDateNaiss
        '
        Me.TbdateDateNaiss.DateValue = Nothing
        Me.TbdateDateNaiss.Location = New System.Drawing.Point(147, 48)
        Me.TbdateDateNaiss.Mask = "00/00/0000"
        Me.TbdateDateNaiss.Name = "TbdateDateNaiss"
        Me.TbdateDateNaiss.Size = New System.Drawing.Size(123, 22)
        Me.TbdateDateNaiss.TabIndex = 14
        Me.TbdateDateNaiss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbintNoNat
        '
        Me.TbintNoNat.Location = New System.Drawing.Point(147, 20)
        Me.TbintNoNat.Name = "TbintNoNat"
        Me.TbintNoNat.Size = New System.Drawing.Size(123, 22)
        Me.TbintNoNat.TabIndex = 17
        Me.TbintNoNat.Value = Nothing
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TbAdresse)
        Me.GroupBox2.Controls.Add(Me.TbVille)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TbPays)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TbintCp)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(440, 90)
        Me.GroupBox2.TabIndex = 61
        Me.GroupBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 17)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Adresse"
        '
        'TbAdresse
        '
        Me.TbAdresse.Location = New System.Drawing.Point(72, 18)
        Me.TbAdresse.Name = "TbAdresse"
        Me.TbAdresse.Size = New System.Drawing.Size(132, 22)
        Me.TbAdresse.TabIndex = 1
        '
        'TbVille
        '
        Me.TbVille.Location = New System.Drawing.Point(72, 49)
        Me.TbVille.Name = "TbVille"
        Me.TbVille.Size = New System.Drawing.Size(132, 22)
        Me.TbVille.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Ville"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(257, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "CP"
        '
        'TbPays
        '
        Me.TbPays.Location = New System.Drawing.Point(294, 54)
        Me.TbPays.Name = "TbPays"
        Me.TbPays.Size = New System.Drawing.Size(132, 22)
        Me.TbPays.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(244, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Pays"
        '
        'TbintCp
        '
        Me.TbintCp.Location = New System.Drawing.Point(294, 21)
        Me.TbintCp.Name = "TbintCp"
        Me.TbintCp.Size = New System.Drawing.Size(100, 22)
        Me.TbintCp.TabIndex = 13
        Me.TbintCp.Value = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TbNom)
        Me.GroupBox1.Controls.Add(Me.TbPrénom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 69)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nom"
        '
        'TbNom
        '
        Me.TbNom.Location = New System.Drawing.Point(49, 25)
        Me.TbNom.Name = "TbNom"
        Me.TbNom.Size = New System.Drawing.Size(132, 22)
        Me.TbNom.TabIndex = 0
        '
        'TbPrénom
        '
        Me.TbPrénom.Location = New System.Drawing.Point(271, 25)
        Me.TbPrénom.Name = "TbPrénom"
        Me.TbPrénom.Size = New System.Drawing.Size(132, 22)
        Me.TbPrénom.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(203, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Prénom"
        '
        'PanelEditBénéficiaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PanelEditBénéficiaire"
        Me.Size = New System.Drawing.Size(449, 332)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TbTel As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TbdateDateNaiss As TextBoxDate
    Friend WithEvents TbintNoNat As TextBoxInt64
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TbAdresse As TextBox
    Friend WithEvents TbVille As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TbPays As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TbintCp As TextBoxInt
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TbNom As TextBox
    Friend WithEvents TbPrénom As TextBox
    Friend WithEvents Label2 As Label
End Class
