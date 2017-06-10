<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class corbeille
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
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxDate1 = New cimetiere.TextBoxDate()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TbfloatMontantPaye = New cimetiere.TextBoxFloat()
        Me.Rb1pers15ansCerc = New System.Windows.Forms.RadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.RbTypeEmpl3a = New System.Windows.Forms.RadioButton()
        Me.Rb2pers15ansCerc = New System.Windows.Forms.RadioButton()
        Me.RbTypeEmpl4b = New System.Windows.Forms.RadioButton()
        Me.cbCaveauCom = New System.Windows.Forms.CheckBox()
        Me.Rb2pers15ansUrne = New System.Windows.Forms.RadioButton()
        Me.RbTypeEmpl6 = New System.Windows.Forms.RadioButton()
        Me.RbTypeEmpl7 = New System.Windows.Forms.RadioButton()
        Me.RbTypeEmpl9 = New System.Windows.Forms.RadioButton()
        Me.RbTypeEmpl8 = New System.Windows.Forms.RadioButton()
        Me.Panel6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel6.Controls.Add(Me.GroupBox4)
        Me.Panel6.Location = New System.Drawing.Point(67, 9)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(715, 410)
        Me.Panel6.TabIndex = 138
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.TextBoxDate1)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.TbfloatMontantPaye)
        Me.GroupBox4.Controls.Add(Me.Rb1pers15ansCerc)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.RbTypeEmpl3a)
        Me.GroupBox4.Controls.Add(Me.Rb2pers15ansCerc)
        Me.GroupBox4.Controls.Add(Me.RbTypeEmpl4b)
        Me.GroupBox4.Controls.Add(Me.cbCaveauCom)
        Me.GroupBox4.Controls.Add(Me.Rb2pers15ansUrne)
        Me.GroupBox4.Controls.Add(Me.RbTypeEmpl6)
        Me.GroupBox4.Controls.Add(Me.RbTypeEmpl7)
        Me.GroupBox4.Controls.Add(Me.RbTypeEmpl9)
        Me.GroupBox4.Controls.Add(Me.RbTypeEmpl8)
        Me.GroupBox4.Location = New System.Drawing.Point(23, 16)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(669, 373)
        Me.GroupBox4.TabIndex = 158
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Type d'emplacement demandé"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(542, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 17)
        Me.Label1.TabIndex = 160
        Me.Label1.Text = "Date de début"
        '
        'TextBoxDate1
        '
        Me.TextBoxDate1.DateValue = Nothing
        Me.TextBoxDate1.Location = New System.Drawing.Point(553, 302)
        Me.TextBoxDate1.Mask = "00/00/0000"
        Me.TextBoxDate1.Name = "TextBoxDate1"
        Me.TextBoxDate1.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxDate1.TabIndex = 159
        Me.TextBoxDate1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(581, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 158
        Me.Button1.Text = "lstbens"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(279, 336)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Montant à payer"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(85, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(417, 17)
        Me.Label13.TabIndex = 157
        Me.Label13.Text = "Inhumation en pleine terre (1 personne)  –  concession de 15 ans"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(504, 337)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 17)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "€"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 87)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(424, 17)
        Me.Label14.TabIndex = 156
        Me.Label14.Text = "Inhumation en pleine terre (2 personnes)  –  concession de 15 ans"
        '
        'TbfloatMontantPaye
        '
        Me.TbfloatMontantPaye.Location = New System.Drawing.Point(392, 335)
        Me.TbfloatMontantPaye.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TbfloatMontantPaye.Name = "TbfloatMontantPaye"
        Me.TbfloatMontantPaye.Size = New System.Drawing.Size(100, 22)
        Me.TbfloatMontantPaye.TabIndex = 6
        Me.TbfloatMontantPaye.Value = Nothing
        '
        'Rb1pers15ansCerc
        '
        Me.Rb1pers15ansCerc.AutoSize = True
        Me.Rb1pers15ansCerc.Location = New System.Drawing.Point(8, 31)
        Me.Rb1pers15ansCerc.Margin = New System.Windows.Forms.Padding(4)
        Me.Rb1pers15ansCerc.Name = "Rb1pers15ansCerc"
        Me.Rb1pers15ansCerc.Size = New System.Drawing.Size(80, 21)
        Me.Rb1pers15ansCerc.TabIndex = 7
        Me.Rb1pers15ansCerc.TabStop = True
        Me.Rb1pers15ansCerc.Text = "Cercueil"
        Me.Rb1pers15ansCerc.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 141)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(313, 17)
        Me.Label15.TabIndex = 155
        Me.Label15.Text = "Placement d'un caveau  –  concession de 30 ans"
        '
        'RbTypeEmpl3a
        '
        Me.RbTypeEmpl3a.AutoSize = True
        Me.RbTypeEmpl3a.Location = New System.Drawing.Point(37, 167)
        Me.RbTypeEmpl3a.Margin = New System.Windows.Forms.Padding(4)
        Me.RbTypeEmpl3a.Name = "RbTypeEmpl3a"
        Me.RbTypeEmpl3a.Size = New System.Drawing.Size(80, 21)
        Me.RbTypeEmpl3a.TabIndex = 5
        Me.RbTypeEmpl3a.TabStop = True
        Me.RbTypeEmpl3a.Text = "Cercueil"
        Me.RbTypeEmpl3a.UseVisualStyleBackColor = True
        '
        'Rb2pers15ansCerc
        '
        Me.Rb2pers15ansCerc.AutoSize = True
        Me.Rb2pers15ansCerc.Location = New System.Drawing.Point(36, 112)
        Me.Rb2pers15ansCerc.Margin = New System.Windows.Forms.Padding(4)
        Me.Rb2pers15ansCerc.Name = "Rb2pers15ansCerc"
        Me.Rb2pers15ansCerc.Size = New System.Drawing.Size(80, 21)
        Me.Rb2pers15ansCerc.TabIndex = 3
        Me.Rb2pers15ansCerc.TabStop = True
        Me.Rb2pers15ansCerc.Text = "Cercueil"
        Me.Rb2pers15ansCerc.UseVisualStyleBackColor = True
        '
        'RbTypeEmpl4b
        '
        Me.RbTypeEmpl4b.AutoSize = True
        Me.RbTypeEmpl4b.Location = New System.Drawing.Point(124, 166)
        Me.RbTypeEmpl4b.Margin = New System.Windows.Forms.Padding(4)
        Me.RbTypeEmpl4b.Name = "RbTypeEmpl4b"
        Me.RbTypeEmpl4b.Size = New System.Drawing.Size(60, 21)
        Me.RbTypeEmpl4b.TabIndex = 8
        Me.RbTypeEmpl4b.TabStop = True
        Me.RbTypeEmpl4b.Text = "Urne"
        Me.RbTypeEmpl4b.UseVisualStyleBackColor = True
        '
        'cbCaveauCom
        '
        Me.cbCaveauCom.AutoSize = True
        Me.cbCaveauCom.Location = New System.Drawing.Point(213, 167)
        Me.cbCaveauCom.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCaveauCom.Name = "cbCaveauCom"
        Me.cbCaveauCom.Size = New System.Drawing.Size(312, 21)
        Me.cbCaveauCom.TabIndex = 9
        Me.cbCaveauCom.Text = "Emplacement pourvu d'un caveau communal"
        Me.cbCaveauCom.UseVisualStyleBackColor = True
        '
        'Rb2pers15ansUrne
        '
        Me.Rb2pers15ansUrne.AutoSize = True
        Me.Rb2pers15ansUrne.Location = New System.Drawing.Point(124, 111)
        Me.Rb2pers15ansUrne.Margin = New System.Windows.Forms.Padding(4)
        Me.Rb2pers15ansUrne.Name = "Rb2pers15ansUrne"
        Me.Rb2pers15ansUrne.Size = New System.Drawing.Size(60, 21)
        Me.Rb2pers15ansUrne.TabIndex = 6
        Me.Rb2pers15ansUrne.TabStop = True
        Me.Rb2pers15ansUrne.Text = "Urne"
        Me.Rb2pers15ansUrne.UseVisualStyleBackColor = True
        '
        'RbTypeEmpl6
        '
        Me.RbTypeEmpl6.AutoSize = True
        Me.RbTypeEmpl6.Location = New System.Drawing.Point(5, 207)
        Me.RbTypeEmpl6.Margin = New System.Windows.Forms.Padding(4)
        Me.RbTypeEmpl6.Name = "RbTypeEmpl6"
        Me.RbTypeEmpl6.Size = New System.Drawing.Size(520, 21)
        Me.RbTypeEmpl6.TabIndex = 11
        Me.RbTypeEmpl6.TabStop = True
        Me.RbTypeEmpl6.Text = "Une urne mise en columbarium - place ordinaire (cell. 1 place prioritairement) "
        Me.RbTypeEmpl6.UseVisualStyleBackColor = True
        '
        'RbTypeEmpl7
        '
        Me.RbTypeEmpl7.AutoSize = True
        Me.RbTypeEmpl7.Location = New System.Drawing.Point(5, 236)
        Me.RbTypeEmpl7.Margin = New System.Windows.Forms.Padding(4)
        Me.RbTypeEmpl7.Name = "RbTypeEmpl7"
        Me.RbTypeEmpl7.Size = New System.Drawing.Size(383, 21)
        Me.RbTypeEmpl7.TabIndex = 12
        Me.RbTypeEmpl7.TabStop = True
        Me.RbTypeEmpl7.Text = "Une urne mise en colombarium  –  concession de 15 ans"
        Me.RbTypeEmpl7.UseVisualStyleBackColor = True
        '
        'RbTypeEmpl9
        '
        Me.RbTypeEmpl9.AutoSize = True
        Me.RbTypeEmpl9.Location = New System.Drawing.Point(5, 292)
        Me.RbTypeEmpl9.Margin = New System.Windows.Forms.Padding(4)
        Me.RbTypeEmpl9.Name = "RbTypeEmpl9"
        Me.RbTypeEmpl9.Size = New System.Drawing.Size(498, 21)
        Me.RbTypeEmpl9.TabIndex = 14
        Me.RbTypeEmpl9.TabStop = True
        Me.RbTypeEmpl9.Text = "Placement d'un cavurne communal  –  concession de 30 ans (max 5 urnes)"
        Me.RbTypeEmpl9.UseVisualStyleBackColor = True
        '
        'RbTypeEmpl8
        '
        Me.RbTypeEmpl8.AutoSize = True
        Me.RbTypeEmpl8.Location = New System.Drawing.Point(5, 264)
        Me.RbTypeEmpl8.Margin = New System.Windows.Forms.Padding(4)
        Me.RbTypeEmpl8.Name = "RbTypeEmpl8"
        Me.RbTypeEmpl8.Size = New System.Drawing.Size(383, 21)
        Me.RbTypeEmpl8.TabIndex = 13
        Me.RbTypeEmpl8.TabStop = True
        Me.RbTypeEmpl8.Text = "Une urne mise en colombarium  –  concession de 30 ans"
        Me.RbTypeEmpl8.UseVisualStyleBackColor = True
        '
        'corbeille
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 429)
        Me.Controls.Add(Me.Panel6)
        Me.Name = "corbeille"
        Me.Text = "corbeille"
        Me.Panel6.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel6 As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxDate1 As TextBoxDate
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TbfloatMontantPaye As TextBoxFloat
    Friend WithEvents Rb1pers15ansCerc As RadioButton
    Friend WithEvents Label15 As Label
    Friend WithEvents RbTypeEmpl3a As RadioButton
    Friend WithEvents Rb2pers15ansCerc As RadioButton
    Friend WithEvents RbTypeEmpl4b As RadioButton
    Friend WithEvents cbCaveauCom As CheckBox
    Friend WithEvents Rb2pers15ansUrne As RadioButton
    Friend WithEvents RbTypeEmpl6 As RadioButton
    Friend WithEvents RbTypeEmpl7 As RadioButton
    Friend WithEvents RbTypeEmpl9 As RadioButton
    Friend WithEvents RbTypeEmpl8 As RadioButton
End Class
