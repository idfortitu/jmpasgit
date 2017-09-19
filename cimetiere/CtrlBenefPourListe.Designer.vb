<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtrlBenefPourListe
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbPrenom = New System.Windows.Forms.TextBox()
        Me.TbLienParente = New System.Windows.Forms.TextBox()
        Me.TbAdresse = New System.Windows.Forms.TextBox()
        Me.TbNom = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtRetirer = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.CtrlVille = New cimetiere.CtrlLocVillePays()
        Me.TbDateNaiss = New cimetiere.TextBoxDate()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Prénom"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(68, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 17)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Adresse"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(410, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nom"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Né le"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(339, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Lien de parenté"
        '
        'TbPrenom
        '
        Me.TbPrenom.Location = New System.Drawing.Point(134, 12)
        Me.TbPrenom.Name = "TbPrenom"
        Me.TbPrenom.Size = New System.Drawing.Size(153, 22)
        Me.TbPrenom.TabIndex = 17
        '
        'TbLienParente
        '
        Me.TbLienParente.Location = New System.Drawing.Point(453, 47)
        Me.TbLienParente.Name = "TbLienParente"
        Me.TbLienParente.Size = New System.Drawing.Size(166, 22)
        Me.TbLienParente.TabIndex = 18
        '
        'TbAdresse
        '
        Me.TbAdresse.Location = New System.Drawing.Point(134, 80)
        Me.TbAdresse.Name = "TbAdresse"
        Me.TbAdresse.Size = New System.Drawing.Size(163, 22)
        Me.TbAdresse.TabIndex = 19
        '
        'TbNom
        '
        Me.TbNom.Location = New System.Drawing.Point(455, 15)
        Me.TbNom.Name = "TbNom"
        Me.TbNom.Size = New System.Drawing.Size(164, 22)
        Me.TbNom.TabIndex = 21
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.BtRetirer)
        Me.Panel1.Controls.Add(Me.CtrlVille)
        Me.Panel1.Controls.Add(Me.TbDateNaiss)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TbNom)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TbAdresse)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TbLienParente)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TbPrenom)
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(649, 116)
        Me.Panel1.TabIndex = 22
        '
        'BtRetirer
        '
        Me.BtRetirer.Image = Global.cimetiere.My.Resources.Resources.moins
        Me.BtRetirer.Location = New System.Drawing.Point(8, 37)
        Me.BtRetirer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtRetirer.Name = "BtRetirer"
        Me.BtRetirer.Size = New System.Drawing.Size(27, 26)
        Me.BtRetirer.TabIndex = 69
        Me.BtRetirer.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'CtrlVille
        '
        Me.CtrlVille.Location = New System.Drawing.Point(303, 79)
        Me.CtrlVille.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CtrlVille.Name = "CtrlVille"
        Me.CtrlVille.Size = New System.Drawing.Size(316, 25)
        Me.CtrlVille.TabIndex = 23
        '
        'TbDateNaiss
        '
        Me.TbDateNaiss.DateValue = Nothing
        Me.TbDateNaiss.Location = New System.Drawing.Point(134, 46)
        Me.TbDateNaiss.Mask = "00/00/0000"
        Me.TbDateNaiss.Name = "TbDateNaiss"
        Me.TbDateNaiss.Size = New System.Drawing.Size(100, 22)
        Me.TbDateNaiss.TabIndex = 22
        Me.TbDateNaiss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CtrlBenefPourListe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CtrlBenefPourListe"
        Me.Size = New System.Drawing.Size(660, 127)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TbPrenom As TextBox
    Friend WithEvents TbLienParente As TextBox
    Friend WithEvents TbAdresse As TextBox
    Friend WithEvents TbNom As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CtrlVille As CtrlLocVillePays
    Friend WithEvents TbDateNaiss As TextBoxDate
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents BtRetirer As Button
End Class
