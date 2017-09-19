<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEditEmplacement
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TbRef = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbMonumClassé = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TbHistoire = New System.Windows.Forms.TextBox()
        Me.BtNvDef = New System.Windows.Forms.Button()
        Me.BtAjouterOccupant = New System.Windows.Forms.Button()
        Me.BtRetirerOccupant = New System.Windows.Forms.Button()
        Me.BtEnregistrer = New System.Windows.Forms.Button()
        Me.BtAnnuler = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DgvOccSrc = New cimetiere.DataGridViewCustom()
        Me.DgvSrcColId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOccSrcNumLh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOccSrcNumAnnée = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOccSrcNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOccSrcEmplacement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOccSrcDateDécès = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOccSrcLieuDécès = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvOccDest = New cimetiere.DataGridViewCustom()
        Me.DgvDestColId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOccDestNumLh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOccDestNumAnnée = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOccDestNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOccDestEmplacement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOccDestDateDécès = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOccDestLieuDécès = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbintNbPlaces = New cimetiere.TextBoxInt()
        Me.CbTypeEmpl = New cimetiere.ComboBoxTypeEmpl()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvOccSrc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvOccDest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TbRef
        '
        Me.TbRef.Location = New System.Drawing.Point(12, 12)
        Me.TbRef.Name = "TbRef"
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
        'BtNvDef
        '
        Me.BtNvDef.Location = New System.Drawing.Point(44, 420)
        Me.BtNvDef.Name = "BtNvDef"
        Me.BtNvDef.Size = New System.Drawing.Size(244, 42)
        Me.BtNvDef.TabIndex = 7
        Me.BtNvDef.Text = "Enregistrer un nouveau défunt"
        Me.BtNvDef.UseVisualStyleBackColor = True
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
        'BtEnregistrer
        '
        Me.BtEnregistrer.Location = New System.Drawing.Point(642, 475)
        Me.BtEnregistrer.Name = "BtEnregistrer"
        Me.BtEnregistrer.Size = New System.Drawing.Size(100, 35)
        Me.BtEnregistrer.TabIndex = 13
        Me.BtEnregistrer.Text = "Enregistrer"
        Me.BtEnregistrer.UseVisualStyleBackColor = True
        '
        'BtAnnuler
        '
        Me.BtAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtAnnuler.Location = New System.Drawing.Point(758, 476)
        Me.BtAnnuler.Name = "BtAnnuler"
        Me.BtAnnuler.Size = New System.Drawing.Size(100, 34)
        Me.BtAnnuler.TabIndex = 14
        Me.BtAnnuler.Text = "Annuler"
        Me.BtAnnuler.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'DgvOccSrc
        '
        Me.DgvOccSrc.AllowUserToAddRows = False
        Me.DgvOccSrc.AllowUserToDeleteRows = False
        Me.DgvOccSrc.AllowUserToOrderColumns = True
        Me.DgvOccSrc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvOccSrc.BackgroundColor = System.Drawing.Color.White
        Me.DgvOccSrc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvOccSrc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DgvSrcColId, Me.ColOccSrcNumLh, Me.ColOccSrcNumAnnée, Me.ColOccSrcNom, Me.ColOccSrcEmplacement, Me.ColOccSrcDateDécès, Me.ColOccSrcLieuDécès})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvOccSrc.DefaultCellStyle = DataGridViewCellStyle1
        Me.DgvOccSrc.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvOccSrc.Location = New System.Drawing.Point(327, 242)
        Me.DgvOccSrc.MultiSelect = False
        Me.DgvOccSrc.Name = "DgvOccSrc"
        Me.DgvOccSrc.ReadOnly = True
        Me.DgvOccSrc.RowHeadersVisible = False
        Me.DgvOccSrc.RowTemplate.Height = 24
        Me.DgvOccSrc.SelectedRow = Nothing
        Me.DgvOccSrc.SelectedRowIndex = -1
        Me.DgvOccSrc.SelectedValue = -1
        Me.DgvOccSrc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvOccSrc.Size = New System.Drawing.Size(543, 220)
        Me.DgvOccSrc.TabIndex = 11
        '
        'DgvSrcColId
        '
        Me.DgvSrcColId.DataPropertyName = "def_id"
        Me.DgvSrcColId.HeaderText = "Id"
        Me.DgvSrcColId.Name = "DgvSrcColId"
        Me.DgvSrcColId.ReadOnly = True
        Me.DgvSrcColId.Visible = False
        '
        'ColOccSrcNumLh
        '
        Me.ColOccSrcNumLh.DataPropertyName = "def_numero_lh"
        Me.ColOccSrcNumLh.HeaderText = "Code"
        Me.ColOccSrcNumLh.Name = "ColOccSrcNumLh"
        Me.ColOccSrcNumLh.ReadOnly = True
        Me.ColOccSrcNumLh.Width = 50
        '
        'ColOccSrcNumAnnée
        '
        Me.ColOccSrcNumAnnée.DataPropertyName = "def_numero_annee"
        Me.ColOccSrcNumAnnée.HeaderText = "Num. année"
        Me.ColOccSrcNumAnnée.Name = "ColOccSrcNumAnnée"
        Me.ColOccSrcNumAnnée.ReadOnly = True
        '
        'ColOccSrcNom
        '
        Me.ColOccSrcNom.DataPropertyName = "def_nom"
        Me.ColOccSrcNom.HeaderText = "Nom"
        Me.ColOccSrcNom.Name = "ColOccSrcNom"
        Me.ColOccSrcNom.ReadOnly = True
        '
        'ColOccSrcEmplacement
        '
        Me.ColOccSrcEmplacement.DataPropertyName = "empl_reference"
        Me.ColOccSrcEmplacement.HeaderText = "Empl."
        Me.ColOccSrcEmplacement.Name = "ColOccSrcEmplacement"
        Me.ColOccSrcEmplacement.ReadOnly = True
        '
        'ColOccSrcDateDécès
        '
        Me.ColOccSrcDateDécès.DataPropertyName = "def_date_deces"
        Me.ColOccSrcDateDécès.HeaderText = "Décédé le"
        Me.ColOccSrcDateDécès.Name = "ColOccSrcDateDécès"
        Me.ColOccSrcDateDécès.ReadOnly = True
        '
        'ColOccSrcLieuDécès
        '
        Me.ColOccSrcLieuDécès.DataPropertyName = "def_lieu_deces"
        Me.ColOccSrcLieuDécès.HeaderText = "Décédé à"
        Me.ColOccSrcLieuDécès.Name = "ColOccSrcLieuDécès"
        Me.ColOccSrcLieuDécès.ReadOnly = True
        '
        'DgvOccDest
        '
        Me.DgvOccDest.AllowUserToAddRows = False
        Me.DgvOccDest.AllowUserToDeleteRows = False
        Me.DgvOccDest.AllowUserToOrderColumns = True
        Me.DgvOccDest.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvOccDest.BackgroundColor = System.Drawing.Color.White
        Me.DgvOccDest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvOccDest.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DgvDestColId, Me.ColOccDestNumLh, Me.ColOccDestNumAnnée, Me.ColOccDestNom, Me.ColOccDestEmplacement, Me.ColOccDestDateDécès, Me.ColOccDestLieuDécès})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvOccDest.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvOccDest.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvOccDest.Location = New System.Drawing.Point(327, 12)
        Me.DgvOccDest.MultiSelect = False
        Me.DgvOccDest.Name = "DgvOccDest"
        Me.DgvOccDest.ReadOnly = True
        Me.DgvOccDest.RowHeadersVisible = False
        Me.DgvOccDest.RowTemplate.Height = 24
        Me.DgvOccDest.SelectedRow = Nothing
        Me.DgvOccDest.SelectedRowIndex = -1
        Me.DgvOccDest.SelectedValue = -1
        Me.DgvOccDest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvOccDest.Size = New System.Drawing.Size(543, 162)
        Me.DgvOccDest.TabIndex = 10
        '
        'DgvDestColId
        '
        Me.DgvDestColId.DataPropertyName = "def_id"
        Me.DgvDestColId.HeaderText = "Id"
        Me.DgvDestColId.Name = "DgvDestColId"
        Me.DgvDestColId.ReadOnly = True
        Me.DgvDestColId.Visible = False
        '
        'ColOccDestNumLh
        '
        Me.ColOccDestNumLh.DataPropertyName = "def_numero_lh"
        Me.ColOccDestNumLh.HeaderText = "Code"
        Me.ColOccDestNumLh.Name = "ColOccDestNumLh"
        Me.ColOccDestNumLh.ReadOnly = True
        Me.ColOccDestNumLh.Width = 50
        '
        'ColOccDestNumAnnée
        '
        Me.ColOccDestNumAnnée.DataPropertyName = "def_numero_annee"
        Me.ColOccDestNumAnnée.HeaderText = "Num. année"
        Me.ColOccDestNumAnnée.Name = "ColOccDestNumAnnée"
        Me.ColOccDestNumAnnée.ReadOnly = True
        '
        'ColOccDestNom
        '
        Me.ColOccDestNom.DataPropertyName = "def_nom"
        Me.ColOccDestNom.HeaderText = "Nom"
        Me.ColOccDestNom.Name = "ColOccDestNom"
        Me.ColOccDestNom.ReadOnly = True
        '
        'ColOccDestEmplacement
        '
        Me.ColOccDestEmplacement.DataPropertyName = "empl_reference"
        Me.ColOccDestEmplacement.HeaderText = "Empl."
        Me.ColOccDestEmplacement.Name = "ColOccDestEmplacement"
        Me.ColOccDestEmplacement.ReadOnly = True
        '
        'ColOccDestDateDécès
        '
        Me.ColOccDestDateDécès.DataPropertyName = "def_date_deces"
        Me.ColOccDestDateDécès.HeaderText = "Décédé le"
        Me.ColOccDestDateDécès.Name = "ColOccDestDateDécès"
        Me.ColOccDestDateDécès.ReadOnly = True
        '
        'ColOccDestLieuDécès
        '
        Me.ColOccDestLieuDécès.DataPropertyName = "def_lieu_deces"
        Me.ColOccDestLieuDécès.HeaderText = "Décédé à"
        Me.ColOccDestLieuDécès.Name = "ColOccDestLieuDécès"
        Me.ColOccDestLieuDécès.ReadOnly = True
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
        'FormEditEmplacement
        '
        Me.AcceptButton = Me.BtEnregistrer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.CancelButton = Me.BtAnnuler
        Me.ClientSize = New System.Drawing.Size(927, 528)
        Me.Controls.Add(Me.BtAnnuler)
        Me.Controls.Add(Me.BtEnregistrer)
        Me.Controls.Add(Me.DgvOccSrc)
        Me.Controls.Add(Me.DgvOccDest)
        Me.Controls.Add(Me.BtRetirerOccupant)
        Me.Controls.Add(Me.BtAjouterOccupant)
        Me.Controls.Add(Me.BtNvDef)
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
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BtNvDef As Button
    Friend WithEvents BtAjouterOccupant As Button
    Friend WithEvents BtRetirerOccupant As Button
    Friend WithEvents DgvOccDest As DataGridViewCustom
    Friend WithEvents DgvOccSrc As DataGridViewCustom
    Friend WithEvents DgvSrcColId As DataGridViewTextBoxColumn
    Friend WithEvents ColOccSrcNumLh As DataGridViewTextBoxColumn
    Friend WithEvents ColOccSrcNumAnnée As DataGridViewTextBoxColumn
    Friend WithEvents ColOccSrcNom As DataGridViewTextBoxColumn
    Friend WithEvents ColOccSrcEmplacement As DataGridViewTextBoxColumn
    Friend WithEvents ColOccSrcDateDécès As DataGridViewTextBoxColumn
    Friend WithEvents ColOccSrcLieuDécès As DataGridViewTextBoxColumn
    Friend WithEvents DgvDestColId As DataGridViewTextBoxColumn
    Friend WithEvents ColOccDestNumLh As DataGridViewTextBoxColumn
    Friend WithEvents ColOccDestNumAnnée As DataGridViewTextBoxColumn
    Friend WithEvents ColOccDestNom As DataGridViewTextBoxColumn
    Friend WithEvents ColOccDestEmplacement As DataGridViewTextBoxColumn
    Friend WithEvents ColOccDestDateDécès As DataGridViewTextBoxColumn
    Friend WithEvents ColOccDestLieuDécès As DataGridViewTextBoxColumn
    Friend WithEvents BtEnregistrer As Button
    Friend WithEvents BtAnnuler As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
End Class
