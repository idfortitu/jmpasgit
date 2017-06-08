<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelEditPersonneContact
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
        Me.TbTel = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TbPays = New System.Windows.Forms.TextBox()
        Me.TbintCp = New cimetiere.TextBoxInt()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbPrénom = New System.Windows.Forms.TextBox()
        Me.TbVille = New System.Windows.Forms.TextBox()
        Me.TbAdresse = New System.Windows.Forms.TextBox()
        Me.TbNom = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TbTel
        '
        Me.TbTel.Location = New System.Drawing.Point(88, 22)
        Me.TbTel.Name = "TbTel"
        Me.TbTel.Size = New System.Drawing.Size(134, 22)
        Me.TbTel.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 17)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Téléphone"
        '
        'TbPays
        '
        Me.TbPays.Location = New System.Drawing.Point(294, 64)
        Me.TbPays.Name = "TbPays"
        Me.TbPays.Size = New System.Drawing.Size(132, 22)
        Me.TbPays.TabIndex = 34
        '
        'TbintCp
        '
        Me.TbintCp.Location = New System.Drawing.Point(294, 20)
        Me.TbintCp.Name = "TbintCp"
        Me.TbintCp.Size = New System.Drawing.Size(100, 22)
        Me.TbintCp.TabIndex = 32
        Me.TbintCp.Value = Nothing
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 17)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Adresse"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(244, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 17)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Pays"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(257, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 17)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "CP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 17)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Ville"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(229, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Prénom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Nom"
        '
        'TbPrénom
        '
        Me.TbPrénom.Location = New System.Drawing.Point(297, 25)
        Me.TbPrénom.Name = "TbPrénom"
        Me.TbPrénom.Size = New System.Drawing.Size(132, 22)
        Me.TbPrénom.TabIndex = 23
        '
        'TbVille
        '
        Me.TbVille.Location = New System.Drawing.Point(72, 59)
        Me.TbVille.Name = "TbVille"
        Me.TbVille.Size = New System.Drawing.Size(132, 22)
        Me.TbVille.TabIndex = 22
        '
        'TbAdresse
        '
        Me.TbAdresse.Location = New System.Drawing.Point(72, 17)
        Me.TbAdresse.Name = "TbAdresse"
        Me.TbAdresse.Size = New System.Drawing.Size(132, 22)
        Me.TbAdresse.TabIndex = 21
        '
        'TbNom
        '
        Me.TbNom.Location = New System.Drawing.Point(75, 25)
        Me.TbNom.Name = "TbNom"
        Me.TbNom.Size = New System.Drawing.Size(132, 22)
        Me.TbNom.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TbNom)
        Me.GroupBox1.Controls.Add(Me.TbPrénom)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(451, 69)
        Me.GroupBox1.TabIndex = 58
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TbAdresse)
        Me.GroupBox2.Controls.Add(Me.TbVille)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TbPays)
        Me.GroupBox2.Controls.Add(Me.TbintCp)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(448, 102)
        Me.GroupBox2.TabIndex = 59
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TbTel)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 186)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(444, 100)
        Me.GroupBox3.TabIndex = 60
        Me.GroupBox3.TabStop = False
        '
        'PanelEditPersonneContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PanelEditPersonneContact"
        Me.Size = New System.Drawing.Size(462, 291)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TbTel As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TbPays As TextBox
    Friend WithEvents TbintCp As TextBoxInt
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TbPrénom As TextBox
    Friend WithEvents TbVille As TextBox
    Friend WithEvents TbAdresse As TextBox
    Friend WithEvents TbNom As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
