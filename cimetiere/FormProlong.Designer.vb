<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormProlong
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProlong))
        Me.GbCsnr = New System.Windows.Forms.GroupBox()
        Me.CtrlLocVillePays1 = New cimetiere.CtrlLocVillePays()
        Me.FprolongTBNoRegistre = New System.Windows.Forms.MaskedTextBox()
        Me.FprolongTbTel = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.FprolongTBDateNaiss = New cimetiere.TextBoxDate()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FprolongTbAdresse = New System.Windows.Forms.TextBox()
        Me.FprolongTBNom = New System.Windows.Forms.TextBox()
        Me.FprolongTBPrenom = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.FprolongDGConss = New System.Windows.Forms.DataGridView()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.FprolongDGBeneficiaire = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.FprolongBannule = New System.Windows.Forms.Button()
        Me.FprolongBRecherche = New System.Windows.Forms.Button()
        Me.FprolongTBRechercher = New System.Windows.Forms.TextBox()
        Me.FprolongCBNom = New System.Windows.Forms.CheckBox()
        Me.FCCBEmplacement = New System.Windows.Forms.CheckBox()
        Me.FPTBLahulpe = New System.Windows.Forms.PictureBox()
        Me.FprolongBProlong = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.GbCsnr.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.FprolongDGConss, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.FprolongDGBeneficiaire, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.FPTBLahulpe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbCsnr
        '
        Me.GbCsnr.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GbCsnr.Controls.Add(Me.CtrlLocVillePays1)
        Me.GbCsnr.Controls.Add(Me.FprolongTBNoRegistre)
        Me.GbCsnr.Controls.Add(Me.FprolongTbTel)
        Me.GbCsnr.Controls.Add(Me.Label7)
        Me.GbCsnr.Controls.Add(Me.Label9)
        Me.GbCsnr.Controls.Add(Me.Label6)
        Me.GbCsnr.Controls.Add(Me.Label10)
        Me.GbCsnr.Controls.Add(Me.FprolongTBDateNaiss)
        Me.GbCsnr.Controls.Add(Me.Label8)
        Me.GbCsnr.Controls.Add(Me.Label5)
        Me.GbCsnr.Controls.Add(Me.FprolongTbAdresse)
        Me.GbCsnr.Controls.Add(Me.FprolongTBNom)
        Me.GbCsnr.Controls.Add(Me.FprolongTBPrenom)
        Me.GbCsnr.Location = New System.Drawing.Point(13, 14)
        Me.GbCsnr.Margin = New System.Windows.Forms.Padding(2)
        Me.GbCsnr.Name = "GbCsnr"
        Me.GbCsnr.Padding = New System.Windows.Forms.Padding(2)
        Me.GbCsnr.Size = New System.Drawing.Size(451, 147)
        Me.GbCsnr.TabIndex = 11
        Me.GbCsnr.TabStop = False
        Me.GbCsnr.Text = "Concessionnaire"
        '
        'CtrlLocVillePays1
        '
        Me.CtrlLocVillePays1.Location = New System.Drawing.Point(208, 53)
        Me.CtrlLocVillePays1.Margin = New System.Windows.Forms.Padding(2)
        Me.CtrlLocVillePays1.Name = "CtrlLocVillePays1"
        Me.CtrlLocVillePays1.Size = New System.Drawing.Size(244, 21)
        Me.CtrlLocVillePays1.TabIndex = 65
        '
        'FprolongTBNoRegistre
        '
        Me.FprolongTBNoRegistre.Location = New System.Drawing.Point(314, 116)
        Me.FprolongTBNoRegistre.Margin = New System.Windows.Forms.Padding(2)
        Me.FprolongTBNoRegistre.Mask = "00\.00\.00-000\.00"
        Me.FprolongTBNoRegistre.Name = "FprolongTBNoRegistre"
        Me.FprolongTBNoRegistre.Size = New System.Drawing.Size(85, 20)
        Me.FprolongTBNoRegistre.TabIndex = 64
        Me.FprolongTBNoRegistre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.FprolongTBNoRegistre.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'FprolongTbTel
        '
        Me.FprolongTbTel.Location = New System.Drawing.Point(66, 82)
        Me.FprolongTbTel.Margin = New System.Windows.Forms.Padding(2)
        Me.FprolongTbTel.Name = "FprolongTbTel"
        Me.FprolongTbTel.Size = New System.Drawing.Size(131, 20)
        Me.FprolongTbTel.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(225, 119)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Numéro national"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 56)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Adresse"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 119)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Date de naissance"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 22)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Prénom"
        '
        'FprolongTBDateNaiss
        '
        Me.FprolongTBDateNaiss.DateValue = Nothing
        Me.FprolongTBDateNaiss.Location = New System.Drawing.Point(106, 116)
        Me.FprolongTBDateNaiss.Margin = New System.Windows.Forms.Padding(2)
        Me.FprolongTBDateNaiss.Mask = "00/00/0000"
        Me.FprolongTBDateNaiss.Name = "FprolongTBDateNaiss"
        Me.FprolongTBDateNaiss.Size = New System.Drawing.Size(90, 20)
        Me.FprolongTBDateNaiss.TabIndex = 13
        Me.FprolongTBDateNaiss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 85)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Téléphone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(225, 22)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Nom"
        '
        'FprolongTbAdresse
        '
        Me.FprolongTbAdresse.Location = New System.Drawing.Point(66, 54)
        Me.FprolongTbAdresse.Margin = New System.Windows.Forms.Padding(2)
        Me.FprolongTbAdresse.Name = "FprolongTbAdresse"
        Me.FprolongTbAdresse.Size = New System.Drawing.Size(131, 20)
        Me.FprolongTbAdresse.TabIndex = 14
        '
        'FprolongTBNom
        '
        Me.FprolongTBNom.Location = New System.Drawing.Point(257, 20)
        Me.FprolongTBNom.Margin = New System.Windows.Forms.Padding(2)
        Me.FprolongTBNom.Name = "FprolongTBNom"
        Me.FprolongTBNom.Size = New System.Drawing.Size(134, 20)
        Me.FprolongTBNom.TabIndex = 11
        '
        'FprolongTBPrenom
        '
        Me.FprolongTBPrenom.Location = New System.Drawing.Point(66, 22)
        Me.FprolongTBPrenom.Margin = New System.Windows.Forms.Padding(2)
        Me.FprolongTBPrenom.Name = "FprolongTBPrenom"
        Me.FprolongTBPrenom.Size = New System.Drawing.Size(131, 20)
        Me.FprolongTBPrenom.TabIndex = 12
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel5.Controls.Add(Me.GroupBox5)
        Me.Panel5.Location = New System.Drawing.Point(22, 252)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(676, 200)
        Me.Panel5.TabIndex = 131
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox5.Controls.Add(Me.FprolongDGConss)
        Me.GroupBox5.Location = New System.Drawing.Point(17, 14)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(640, 166)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Concession :"
        '
        'FprolongDGConss
        '
        Me.FprolongDGConss.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.FprolongDGConss.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FprolongDGConss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FprolongDGConss.EnableHeadersVisualStyles = False
        Me.FprolongDGConss.Location = New System.Drawing.Point(0, 15)
        Me.FprolongDGConss.Name = "FprolongDGConss"
        Me.FprolongDGConss.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FprolongDGConss.RowHeadersVisible = False
        Me.FprolongDGConss.Size = New System.Drawing.Size(656, 151)
        Me.FprolongDGConss.TabIndex = 43
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel8.Controls.Add(Me.GroupBox8)
        Me.Panel8.Location = New System.Drawing.Point(22, 464)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(349, 200)
        Me.Panel8.TabIndex = 132
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox8.Controls.Add(Me.FprolongDGBeneficiaire)
        Me.GroupBox8.Location = New System.Drawing.Point(17, 14)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(312, 166)
        Me.GroupBox8.TabIndex = 0
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Bénéficiaire :"
        '
        'FprolongDGBeneficiaire
        '
        Me.FprolongDGBeneficiaire.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.FprolongDGBeneficiaire.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FprolongDGBeneficiaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FprolongDGBeneficiaire.EnableHeadersVisualStyles = False
        Me.FprolongDGBeneficiaire.Location = New System.Drawing.Point(0, 17)
        Me.FprolongDGBeneficiaire.Name = "FprolongDGBeneficiaire"
        Me.FprolongDGBeneficiaire.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FprolongDGBeneficiaire.RowHeadersVisible = False
        Me.FprolongDGBeneficiaire.Size = New System.Drawing.Size(312, 149)
        Me.FprolongDGBeneficiaire.TabIndex = 93
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel4.Controls.Add(Me.GroupBox4)
        Me.Panel4.Location = New System.Drawing.Point(12, 104)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(186, 138)
        Me.Panel4.TabIndex = 133
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox4.Controls.Add(Me.FprolongBannule)
        Me.GroupBox4.Controls.Add(Me.FprolongBRecherche)
        Me.GroupBox4.Controls.Add(Me.FprolongTBRechercher)
        Me.GroupBox4.Controls.Add(Me.FprolongCBNom)
        Me.GroupBox4.Controls.Add(Me.FCCBEmplacement)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 10)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(164, 113)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Rechercher :"
        '
        'FprolongBannule
        '
        Me.FprolongBannule.Location = New System.Drawing.Point(6, 84)
        Me.FprolongBannule.Name = "FprolongBannule"
        Me.FprolongBannule.Size = New System.Drawing.Size(127, 23)
        Me.FprolongBannule.TabIndex = 127
        Me.FprolongBannule.Text = "Annuler la recherche"
        Me.FprolongBannule.UseVisualStyleBackColor = True
        '
        'FprolongBRecherche
        '
        Me.FprolongBRecherche.Location = New System.Drawing.Point(8, 58)
        Me.FprolongBRecherche.Name = "FprolongBRecherche"
        Me.FprolongBRecherche.Size = New System.Drawing.Size(75, 23)
        Me.FprolongBRecherche.TabIndex = 126
        Me.FprolongBRecherche.Text = "Rechercher"
        Me.FprolongBRecherche.UseVisualStyleBackColor = True
        '
        'FprolongTBRechercher
        '
        Me.FprolongTBRechercher.Location = New System.Drawing.Point(6, 14)
        Me.FprolongTBRechercher.Name = "FprolongTBRechercher"
        Me.FprolongTBRechercher.Size = New System.Drawing.Size(98, 20)
        Me.FprolongTBRechercher.TabIndex = 35
        '
        'FprolongCBNom
        '
        Me.FprolongCBNom.AutoSize = True
        Me.FprolongCBNom.Location = New System.Drawing.Point(8, 41)
        Me.FprolongCBNom.Name = "FprolongCBNom"
        Me.FprolongCBNom.Size = New System.Drawing.Size(48, 17)
        Me.FprolongCBNom.TabIndex = 40
        Me.FprolongCBNom.Text = "Nom"
        Me.FprolongCBNom.UseVisualStyleBackColor = True
        '
        'FCCBEmplacement
        '
        Me.FCCBEmplacement.AutoSize = True
        Me.FCCBEmplacement.Location = New System.Drawing.Point(62, 41)
        Me.FCCBEmplacement.Name = "FCCBEmplacement"
        Me.FCCBEmplacement.Size = New System.Drawing.Size(90, 17)
        Me.FCCBEmplacement.TabIndex = 42
        Me.FCCBEmplacement.Text = "Emplacement"
        Me.FCCBEmplacement.UseVisualStyleBackColor = True
        '
        'FPTBLahulpe
        '
        Me.FPTBLahulpe.BackColor = System.Drawing.Color.Transparent
        Me.FPTBLahulpe.Image = CType(resources.GetObject("FPTBLahulpe.Image"), System.Drawing.Image)
        Me.FPTBLahulpe.Location = New System.Drawing.Point(0, 0)
        Me.FPTBLahulpe.Name = "FPTBLahulpe"
        Me.FPTBLahulpe.Size = New System.Drawing.Size(156, 98)
        Me.FPTBLahulpe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FPTBLahulpe.TabIndex = 134
        Me.FPTBLahulpe.TabStop = False
        '
        'FprolongBProlong
        '
        Me.FprolongBProlong.BackColor = System.Drawing.Color.SeaGreen
        Me.FprolongBProlong.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FprolongBProlong.ForeColor = System.Drawing.Color.Transparent
        Me.FprolongBProlong.Location = New System.Drawing.Point(546, 542)
        Me.FprolongBProlong.Name = "FprolongBProlong"
        Me.FprolongBProlong.Size = New System.Drawing.Size(123, 57)
        Me.FprolongBProlong.TabIndex = 135
        Me.FprolongBProlong.Text = "Prolonger"
        Me.FprolongBProlong.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel6.Controls.Add(Me.GbCsnr)
        Me.Panel6.Location = New System.Drawing.Point(219, 8)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(479, 184)
        Me.Panel6.TabIndex = 136
        '
        'FormProlong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.cimetiere.My.Resources.Resources.fondformulaire
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(716, 693)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.FprolongBProlong)
        Me.Controls.Add(Me.FPTBLahulpe)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormProlong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormProlong"
        Me.GbCsnr.ResumeLayout(False)
        Me.GbCsnr.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.FprolongDGConss, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.FprolongDGBeneficiaire, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.FPTBLahulpe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GbCsnr As GroupBox
    Friend WithEvents CtrlLocVillePays1 As CtrlLocVillePays
    Friend WithEvents FprolongTBNoRegistre As MaskedTextBox
    Friend WithEvents FprolongTbTel As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents FprolongTBDateNaiss As TextBoxDate
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents FprolongTbAdresse As TextBox
    Friend WithEvents FprolongTBNom As TextBox
    Friend WithEvents FprolongTBPrenom As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents FprolongDGConss As DataGridView
    Friend WithEvents Panel8 As Panel
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents FprolongDGBeneficiaire As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents FprolongBannule As Button
    Friend WithEvents FprolongBRecherche As Button
    Friend WithEvents FprolongTBRechercher As TextBox
    Friend WithEvents FprolongCBNom As CheckBox
    Friend WithEvents FCCBEmplacement As CheckBox
    Friend WithEvents FPTBLahulpe As PictureBox
    Friend WithEvents FprolongBProlong As Button
    Friend WithEvents Panel6 As Panel
End Class
