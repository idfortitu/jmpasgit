<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditEmplacement
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
        Me.TbRef = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbMonumClassé = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TbHistoire = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtAjouterOccupant = New System.Windows.Forms.Button()
        Me.BtRetirerOccupant = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DgvOccSrc = New cimetiere.DataGridViewCustom()
        Me.DgvOccDest = New cimetiere.DataGridViewCustom()
        Me.TbintNbPlaces = New cimetiere.TextBoxInt()
        Me.CbTypeEmpl = New cimetiere.ComboBoxTypeEmpl()
        Me.ColOccDestNumLh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOccDestNumAnnée = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOccDestNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOccDestEmplacement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOccDestDateDécès = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOccDestLieuDécès = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOccDestAdresse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOccDestEtatCivil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOccDestDateNaiss = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOccDestLieuNaiss = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOccSrcNumLh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOccSrcNumAnnée = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOccSrcNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOccSrcEmplacement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOccSrcDateDécès = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOccSrcLieuDécès = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOccSrcAdresse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOccSrcEtatCivil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOccSrcDateNaiss = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOccSrcLieuNaiss = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvOccSrc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvOccDest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TbRef
        '
        Me.TbRef.Location = New System.Drawing.Point(12, 12)
        Me.TbRef.Name = "TbRef"
        Me.TbRef.ReadOnly = True
        Me.TbRef.Size = New System.Drawing.Size(100, 22)
        Me.TbRef.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Places"
        '
        'CbMonumClassé
        '
        Me.CbMonumClassé.AutoSize = True
        Me.CbMonumClassé.Location = New System.Drawing.Point(12, 119)
        Me.CbMonumClassé.Name = "CbMonumClassé"
        Me.CbMonumClassé.Size = New System.Drawing.Size(140, 21)
        Me.CbMonumClassé.TabIndex = 5
        Me.CbMonumClassé.Text = "Monument classé"
        Me.CbMonumClassé.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TbHistoire)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 155)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(282, 245)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Histoire"
        '
        'TbHistoire
        '
        Me.TbHistoire.Location = New System.Drawing.Point(6, 21)
        Me.TbHistoire.Multiline = True
        Me.TbHistoire.Name = "TbHistoire"
        Me.TbHistoire.Size = New System.Drawing.Size(270, 218)
        Me.TbHistoire.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(70, 420)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(244, 42)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Enregistrer un nouveau défunt"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtAjouterOccupant
        '
        Me.BtAjouterOccupant.Image = Global.cimetiere.My.Resources.Resources.StackUp_16x
        Me.BtAjouterOccupant.Location = New System.Drawing.Point(504, 187)
        Me.BtAjouterOccupant.Name = "BtAjouterOccupant"
        Me.BtAjouterOccupant.Size = New System.Drawing.Size(52, 36)
        Me.BtAjouterOccupant.TabIndex = 8
        Me.BtAjouterOccupant.UseVisualStyleBackColor = True
        '
        'BtRetirerOccupant
        '
        Me.BtRetirerOccupant.Image = Global.cimetiere.My.Resources.Resources.StackDown_16x
        Me.BtRetirerOccupant.Location = New System.Drawing.Point(634, 187)
        Me.BtRetirerOccupant.Name = "BtRetirerOccupant"
        Me.BtRetirerOccupant.Size = New System.Drawing.Size(52, 36)
        Me.BtRetirerOccupant.TabIndex = 9
        Me.BtRetirerOccupant.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(96, 482)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DgvOccSrc
        '
        Me.DgvOccSrc.AllowUserToAddRows = False
        Me.DgvOccSrc.AllowUserToDeleteRows = False
        Me.DgvOccSrc.AllowUserToOrderColumns = True
        Me.DgvOccSrc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvOccSrc.BackgroundColor = System.Drawing.Color.White
        Me.DgvOccSrc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvOccSrc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColOccSrcNumLh, Me.ColOccSrcNumAnnée, Me.ColOccSrcNom, Me.ColOccSrcEmplacement, Me.ColOccSrcDateDécès, Me.ColOccSrcLieuDécès, Me.ColOccSrcAdresse, Me.ColOccSrcEtatCivil, Me.ColOccSrcDateNaiss, Me.ColOccSrcLieuNaiss})
        Me.DgvOccSrc.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvOccSrc.Location = New System.Drawing.Point(327, 242)
        Me.DgvOccSrc.MultiSelect = False
        Me.DgvOccSrc.Name = "DgvOccSrc"
        Me.DgvOccSrc.ReadOnly = True
        Me.DgvOccSrc.RowHeadersVisible = False
        Me.DgvOccSrc.RowTemplate.Height = 24
        Me.DgvOccSrc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvOccSrc.Size = New System.Drawing.Size(543, 220)
        Me.DgvOccSrc.TabIndex = 11
        '
        'DgvOccDest
        '
        Me.DgvOccDest.AllowUserToAddRows = False
        Me.DgvOccDest.AllowUserToDeleteRows = False
        Me.DgvOccDest.AllowUserToOrderColumns = True
        Me.DgvOccDest.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvOccDest.BackgroundColor = System.Drawing.Color.White
        Me.DgvOccDest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvOccDest.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColOccDestNumLh, Me.ColOccDestNumAnnée, Me.ColOccDestNom, Me.ColOccDestEmplacement, Me.ColOccDestDateDécès, Me.ColOccDestLieuDécès, Me.ColOccDestAdresse, Me.ColOccDestEtatCivil, Me.ColOccDestDateNaiss, Me.ColOccDestLieuNaiss})
        Me.DgvOccDest.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvOccDest.Location = New System.Drawing.Point(327, 12)
        Me.DgvOccDest.MultiSelect = False
        Me.DgvOccDest.Name = "DgvOccDest"
        Me.DgvOccDest.ReadOnly = True
        Me.DgvOccDest.RowHeadersVisible = False
        Me.DgvOccDest.RowTemplate.Height = 24
        Me.DgvOccDest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvOccDest.Size = New System.Drawing.Size(543, 162)
        Me.DgvOccDest.TabIndex = 10
        '
        'TbintNbPlaces
        '
        Me.TbintNbPlaces.Location = New System.Drawing.Point(70, 86)
        Me.TbintNbPlaces.Name = "TbintNbPlaces"
        Me.TbintNbPlaces.Size = New System.Drawing.Size(61, 22)
        Me.TbintNbPlaces.TabIndex = 3
        Me.TbintNbPlaces.Value = Nothing
        '
        'CbTypeEmpl
        '
        Me.CbTypeEmpl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbTypeEmpl.FormattingEnabled = True
        Me.CbTypeEmpl.Location = New System.Drawing.Point(70, 51)
        Me.CbTypeEmpl.Name = "CbTypeEmpl"
        Me.CbTypeEmpl.Size = New System.Drawing.Size(121, 24)
        Me.CbTypeEmpl.TabIndex = 2
        '
        'ColOccDestNumLh
        '
        Me.ColOccDestNumLh.DataPropertyName = "NuméroLh"
        Me.ColOccDestNumLh.HeaderText = "Code"
        Me.ColOccDestNumLh.Name = "ColOccDestNumLh"
        Me.ColOccDestNumLh.ReadOnly = True
        Me.ColOccDestNumLh.Width = 50
        '
        'ColOccDestNumAnnée
        '
        Me.ColOccDestNumAnnée.DataPropertyName = "NuméroAnnée"
        Me.ColOccDestNumAnnée.HeaderText = "Num. année"
        Me.ColOccDestNumAnnée.Name = "ColOccDestNumAnnée"
        Me.ColOccDestNumAnnée.ReadOnly = True
        '
        'ColOccDestNom
        '
        Me.ColOccDestNom.DataPropertyName = "NomComplet"
        Me.ColOccDestNom.HeaderText = "Nom"
        Me.ColOccDestNom.Name = "ColOccDestNom"
        Me.ColOccDestNom.ReadOnly = True
        '
        'ColOccDestEmplacement
        '
        Me.ColOccDestEmplacement.DataPropertyName = "EmplComplet"
        Me.ColOccDestEmplacement.HeaderText = "Empl."
        Me.ColOccDestEmplacement.Name = "ColOccDestEmplacement"
        Me.ColOccDestEmplacement.ReadOnly = True
        '
        'ColOccDestDateDécès
        '
        Me.ColOccDestDateDécès.DataPropertyName = "DateDécès"
        Me.ColOccDestDateDécès.HeaderText = "Décédé le"
        Me.ColOccDestDateDécès.Name = "ColOccDestDateDécès"
        Me.ColOccDestDateDécès.ReadOnly = True
        '
        'ColOccDestLieuDécès
        '
        Me.ColOccDestLieuDécès.DataPropertyName = "LieuDécès"
        Me.ColOccDestLieuDécès.HeaderText = "Décédé à"
        Me.ColOccDestLieuDécès.Name = "ColOccDestLieuDécès"
        Me.ColOccDestLieuDécès.ReadOnly = True
        '
        'ColOccDestAdresse
        '
        Me.ColOccDestAdresse.DataPropertyName = "AdresseComplète"
        Me.ColOccDestAdresse.HeaderText = "Adresse"
        Me.ColOccDestAdresse.Name = "ColOccDestAdresse"
        Me.ColOccDestAdresse.ReadOnly = True
        '
        'ColOccDestEtatCivil
        '
        Me.ColOccDestEtatCivil.DataPropertyName = "EtatCivilComplet"
        Me.ColOccDestEtatCivil.HeaderText = "État civil"
        Me.ColOccDestEtatCivil.Name = "ColOccDestEtatCivil"
        Me.ColOccDestEtatCivil.ReadOnly = True
        '
        'ColOccDestDateNaiss
        '
        Me.ColOccDestDateNaiss.DataPropertyName = "DateNaiss"
        Me.ColOccDestDateNaiss.HeaderText = "Né le"
        Me.ColOccDestDateNaiss.Name = "ColOccDestDateNaiss"
        Me.ColOccDestDateNaiss.ReadOnly = True
        '
        'ColOccDestLieuNaiss
        '
        Me.ColOccDestLieuNaiss.DataPropertyName = "LieuNaiss"
        Me.ColOccDestLieuNaiss.HeaderText = "Né à"
        Me.ColOccDestLieuNaiss.Name = "ColOccDestLieuNaiss"
        Me.ColOccDestLieuNaiss.ReadOnly = True
        '
        'ColOccSrcNumLh
        '
        Me.ColOccSrcNumLh.DataPropertyName = "NuméroLh"
        Me.ColOccSrcNumLh.HeaderText = "Code"
        Me.ColOccSrcNumLh.Name = "ColOccSrcNumLh"
        Me.ColOccSrcNumLh.ReadOnly = True
        Me.ColOccSrcNumLh.Width = 50
        '
        'ColOccSrcNumAnnée
        '
        Me.ColOccSrcNumAnnée.DataPropertyName = "NuméroAnnée"
        Me.ColOccSrcNumAnnée.HeaderText = "Num. année"
        Me.ColOccSrcNumAnnée.Name = "ColOccSrcNumAnnée"
        Me.ColOccSrcNumAnnée.ReadOnly = True
        '
        'ColOccSrcNom
        '
        Me.ColOccSrcNom.DataPropertyName = "NomComplet"
        Me.ColOccSrcNom.HeaderText = "Nom"
        Me.ColOccSrcNom.Name = "ColOccSrcNom"
        Me.ColOccSrcNom.ReadOnly = True
        '
        'ColOccSrcEmplacement
        '
        Me.ColOccSrcEmplacement.DataPropertyName = "EmplComplet"
        Me.ColOccSrcEmplacement.HeaderText = "Empl."
        Me.ColOccSrcEmplacement.Name = "ColOccSrcEmplacement"
        Me.ColOccSrcEmplacement.ReadOnly = True
        '
        'ColOccSrcDateDécès
        '
        Me.ColOccSrcDateDécès.DataPropertyName = "DateDécès"
        Me.ColOccSrcDateDécès.HeaderText = "Décédé le"
        Me.ColOccSrcDateDécès.Name = "ColOccSrcDateDécès"
        Me.ColOccSrcDateDécès.ReadOnly = True
        '
        'ColOccSrcLieuDécès
        '
        Me.ColOccSrcLieuDécès.DataPropertyName = "LieuDécès"
        Me.ColOccSrcLieuDécès.HeaderText = "Décédé à"
        Me.ColOccSrcLieuDécès.Name = "ColOccSrcLieuDécès"
        Me.ColOccSrcLieuDécès.ReadOnly = True
        '
        'ColOccSrcAdresse
        '
        Me.ColOccSrcAdresse.DataPropertyName = "AdresseComplète"
        Me.ColOccSrcAdresse.HeaderText = "Adresse"
        Me.ColOccSrcAdresse.Name = "ColOccSrcAdresse"
        Me.ColOccSrcAdresse.ReadOnly = True
        '
        'ColOccSrcEtatCivil
        '
        Me.ColOccSrcEtatCivil.DataPropertyName = "EtatCivilComplet"
        Me.ColOccSrcEtatCivil.HeaderText = "État civil"
        Me.ColOccSrcEtatCivil.Name = "ColOccSrcEtatCivil"
        Me.ColOccSrcEtatCivil.ReadOnly = True
        '
        'ColOccSrcDateNaiss
        '
        Me.ColOccSrcDateNaiss.DataPropertyName = "DateNaiss"
        Me.ColOccSrcDateNaiss.HeaderText = "Né le"
        Me.ColOccSrcDateNaiss.Name = "ColOccSrcDateNaiss"
        Me.ColOccSrcDateNaiss.ReadOnly = True
        '
        'ColOccSrcLieuNaiss
        '
        Me.ColOccSrcLieuNaiss.DataPropertyName = "LieuNaiss"
        Me.ColOccSrcLieuNaiss.HeaderText = "Né à"
        Me.ColOccSrcLieuNaiss.Name = "ColOccSrcLieuNaiss"
        Me.ColOccSrcLieuNaiss.ReadOnly = True
        '
        'FormEditEmplacement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(927, 528)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DgvOccSrc)
        Me.Controls.Add(Me.DgvOccDest)
        Me.Controls.Add(Me.BtRetirerOccupant)
        Me.Controls.Add(Me.BtAjouterOccupant)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CbMonumClassé)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbintNbPlaces)
        Me.Controls.Add(Me.CbTypeEmpl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbRef)
        Me.MinimumSize = New System.Drawing.Size(900, 470)
        Me.Name = "FormEditEmplacement"
        Me.Text = "FormEditEmplacement"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvOccSrc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvOccDest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbRef As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CbTypeEmpl As ComboBoxTypeEmpl
    Friend WithEvents TbintNbPlaces As TextBoxInt
    Friend WithEvents Label2 As Label
    Friend WithEvents CbMonumClassé As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TbHistoire As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BtAjouterOccupant As Button
    Friend WithEvents BtRetirerOccupant As Button
    Friend WithEvents DgvOccDest As DataGridViewCustom
    Friend WithEvents DgvOccSrc As DataGridViewCustom
    Friend WithEvents Button2 As Button
    Friend WithEvents ColOccDestNumLh As DataGridViewTextBoxColumn
    Friend WithEvents ColOccDestNumAnnée As DataGridViewTextBoxColumn
    Friend WithEvents ColOccDestNom As DataGridViewTextBoxColumn
    Friend WithEvents ColOccDestEmplacement As DataGridViewTextBoxColumn
    Friend WithEvents ColOccDestDateDécès As DataGridViewTextBoxColumn
    Friend WithEvents ColOccDestLieuDécès As DataGridViewTextBoxColumn
    Friend WithEvents ColOccDestAdresse As DataGridViewTextBoxColumn
    Friend WithEvents ColOccDestEtatCivil As DataGridViewTextBoxColumn
    Friend WithEvents ColOccDestDateNaiss As DataGridViewTextBoxColumn
    Friend WithEvents ColOccDestLieuNaiss As DataGridViewTextBoxColumn
    Friend WithEvents ColOccSrcNumLh As DataGridViewTextBoxColumn
    Friend WithEvents ColOccSrcNumAnnée As DataGridViewTextBoxColumn
    Friend WithEvents ColOccSrcNom As DataGridViewTextBoxColumn
    Friend WithEvents ColOccSrcEmplacement As DataGridViewTextBoxColumn
    Friend WithEvents ColOccSrcDateDécès As DataGridViewTextBoxColumn
    Friend WithEvents ColOccSrcLieuDécès As DataGridViewTextBoxColumn
    Friend WithEvents ColOccSrcAdresse As DataGridViewTextBoxColumn
    Friend WithEvents ColOccSrcEtatCivil As DataGridViewTextBoxColumn
    Friend WithEvents ColOccSrcDateNaiss As DataGridViewTextBoxColumn
    Friend WithEvents ColOccSrcLieuNaiss As DataGridViewTextBoxColumn
End Class
