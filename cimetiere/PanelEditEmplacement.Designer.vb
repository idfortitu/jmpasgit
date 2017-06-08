<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PanelEditEmplacement
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.TbEmplacement = New System.Windows.Forms.TextBox()
        Me.ComboBoxTypeEmpl1 = New cimetiere.ComboBoxTypeEmpl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbintPlaces = New cimetiere.TextBoxInt()
        Me.TbHistoire = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GbHistoire = New System.Windows.Forms.GroupBox()
        Me.DgvOccupants = New System.Windows.Forms.DataGridView()
        Me.ColNumLh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNumAnnée = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPrénom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAdresse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColVille = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ColPays = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ColEtatCivil = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ColEtatCivilDe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDateNaiss = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColLieuNaiss = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDateDécès = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColLieuDécès = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEmplacement = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ColUrneOuCercueil = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.BtCréerDef = New System.Windows.Forms.Button()
        Me.BtAjouterDefExistant = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GbHistoire.SuspendLayout()
        CType(Me.DgvOccupants, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TbEmplacement
        '
        Me.TbEmplacement.Location = New System.Drawing.Point(0, 0)
        Me.TbEmplacement.Name = "TbEmplacement"
        Me.TbEmplacement.ReadOnly = True
        Me.TbEmplacement.Size = New System.Drawing.Size(106, 22)
        Me.TbEmplacement.TabIndex = 0
        '
        'ComboBoxTypeEmpl1
        '
        Me.ComboBoxTypeEmpl1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTypeEmpl1.FormattingEnabled = True
        Me.ComboBoxTypeEmpl1.Location = New System.Drawing.Point(59, 41)
        Me.ComboBoxTypeEmpl1.Name = "ComboBoxTypeEmpl1"
        Me.ComboBoxTypeEmpl1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxTypeEmpl1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Places"
        '
        'TbintPlaces
        '
        Me.TbintPlaces.Location = New System.Drawing.Point(59, 81)
        Me.TbintPlaces.Name = "TbintPlaces"
        Me.TbintPlaces.Size = New System.Drawing.Size(54, 22)
        Me.TbintPlaces.TabIndex = 4
        Me.TbintPlaces.Value = Nothing
        '
        'TbHistoire
        '
        Me.TbHistoire.Location = New System.Drawing.Point(6, 21)
        Me.TbHistoire.Multiline = True
        Me.TbHistoire.Name = "TbHistoire"
        Me.TbHistoire.Size = New System.Drawing.Size(279, 172)
        Me.TbHistoire.TabIndex = 6
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(0, 123)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(140, 21)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Monument classé"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GbHistoire
        '
        Me.GbHistoire.Controls.Add(Me.TbHistoire)
        Me.GbHistoire.Location = New System.Drawing.Point(16, 164)
        Me.GbHistoire.Name = "GbHistoire"
        Me.GbHistoire.Size = New System.Drawing.Size(292, 199)
        Me.GbHistoire.TabIndex = 8
        Me.GbHistoire.TabStop = False
        Me.GbHistoire.Text = "Histoire"
        '
        'DgvOccupants
        '
        Me.DgvOccupants.AllowUserToAddRows = False
        Me.DgvOccupants.AllowUserToDeleteRows = False
        Me.DgvOccupants.AllowUserToOrderColumns = True
        Me.DgvOccupants.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvOccupants.BackgroundColor = System.Drawing.Color.White
        Me.DgvOccupants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvOccupants.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColNumLh, Me.ColNumAnnée, Me.ColPrénom, Me.ColNom, Me.ColAdresse, Me.ColVille, Me.ColPays, Me.ColEtatCivil, Me.ColEtatCivilDe, Me.ColDateNaiss, Me.ColLieuNaiss, Me.ColDateDécès, Me.ColLieuDécès, Me.ColEmplacement, Me.ColUrneOuCercueil})
        Me.DgvOccupants.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvOccupants.GridColor = System.Drawing.Color.White
        Me.DgvOccupants.Location = New System.Drawing.Point(331, 2)
        Me.DgvOccupants.MultiSelect = False
        Me.DgvOccupants.Name = "DgvOccupants"
        Me.DgvOccupants.ReadOnly = True
        Me.DgvOccupants.RowHeadersVisible = False
        Me.DgvOccupants.RowTemplate.Height = 24
        Me.DgvOccupants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvOccupants.Size = New System.Drawing.Size(628, 216)
        Me.DgvOccupants.TabIndex = 9
        '
        'ColNumLh
        '
        Me.ColNumLh.DataPropertyName = "NuméroLh"
        Me.ColNumLh.HeaderText = "Code"
        Me.ColNumLh.Name = "ColNumLh"
        Me.ColNumLh.ReadOnly = True
        '
        'ColNumAnnée
        '
        Me.ColNumAnnée.DataPropertyName = "NuméroAnnée"
        Me.ColNumAnnée.HeaderText = "Num. année"
        Me.ColNumAnnée.Name = "ColNumAnnée"
        Me.ColNumAnnée.ReadOnly = True
        '
        'ColPrénom
        '
        Me.ColPrénom.DataPropertyName = "Prénom"
        Me.ColPrénom.HeaderText = "Prénom"
        Me.ColPrénom.Name = "ColPrénom"
        Me.ColPrénom.ReadOnly = True
        '
        'ColNom
        '
        Me.ColNom.DataPropertyName = "Nom"
        Me.ColNom.HeaderText = "Nom"
        Me.ColNom.Name = "ColNom"
        Me.ColNom.ReadOnly = True
        '
        'ColAdresse
        '
        Me.ColAdresse.DataPropertyName = "Adresse"
        Me.ColAdresse.HeaderText = "Adresse"
        Me.ColAdresse.Name = "ColAdresse"
        Me.ColAdresse.ReadOnly = True
        '
        'ColVille
        '
        Me.ColVille.DataPropertyName = "Ville"
        Me.ColVille.HeaderText = "Ville"
        Me.ColVille.Name = "ColVille"
        Me.ColVille.ReadOnly = True
        '
        'ColPays
        '
        Me.ColPays.DataPropertyName = "Pays"
        Me.ColPays.HeaderText = "Pays"
        Me.ColPays.Name = "ColPays"
        Me.ColPays.ReadOnly = True
        '
        'ColEtatCivil
        '
        Me.ColEtatCivil.DataPropertyName = "EtatCivil"
        Me.ColEtatCivil.HeaderText = "État civil"
        Me.ColEtatCivil.Name = "ColEtatCivil"
        Me.ColEtatCivil.ReadOnly = True
        Me.ColEtatCivil.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColEtatCivil.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ColEtatCivilDe
        '
        Me.ColEtatCivilDe.DataPropertyName = "EtatCivilDe"
        Me.ColEtatCivilDe.HeaderText = "De"
        Me.ColEtatCivilDe.Name = "ColEtatCivilDe"
        Me.ColEtatCivilDe.ReadOnly = True
        '
        'ColDateNaiss
        '
        Me.ColDateNaiss.DataPropertyName = "DateNaiss"
        Me.ColDateNaiss.HeaderText = "Né le"
        Me.ColDateNaiss.Name = "ColDateNaiss"
        Me.ColDateNaiss.ReadOnly = True
        '
        'ColLieuNaiss
        '
        Me.ColLieuNaiss.DataPropertyName = "LieuNaiss"
        Me.ColLieuNaiss.HeaderText = "Né à"
        Me.ColLieuNaiss.Name = "ColLieuNaiss"
        Me.ColLieuNaiss.ReadOnly = True
        '
        'ColDateDécès
        '
        Me.ColDateDécès.DataPropertyName = "DateDécès"
        Me.ColDateDécès.HeaderText = "Décédé le"
        Me.ColDateDécès.Name = "ColDateDécès"
        Me.ColDateDécès.ReadOnly = True
        '
        'ColLieuDécès
        '
        Me.ColLieuDécès.DataPropertyName = "LieuDécès"
        Me.ColLieuDécès.HeaderText = "Décédé à"
        Me.ColLieuDécès.Name = "ColLieuDécès"
        Me.ColLieuDécès.ReadOnly = True
        '
        'ColEmplacement
        '
        Me.ColEmplacement.DataPropertyName = "Emplacement.Référence"
        Me.ColEmplacement.HeaderText = "Emplacement"
        Me.ColEmplacement.Name = "ColEmplacement"
        Me.ColEmplacement.ReadOnly = True
        Me.ColEmplacement.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ColUrneOuCercueil
        '
        Me.ColUrneOuCercueil.DataPropertyName = "TypeInh"
        Me.ColUrneOuCercueil.HeaderText = "Place"
        Me.ColUrneOuCercueil.Name = "ColUrneOuCercueil"
        Me.ColUrneOuCercueil.ReadOnly = True
        '
        'BtCréerDef
        '
        Me.BtCréerDef.Location = New System.Drawing.Point(496, 287)
        Me.BtCréerDef.Name = "BtCréerDef"
        Me.BtCréerDef.Size = New System.Drawing.Size(305, 23)
        Me.BtCréerDef.TabIndex = 10
        Me.BtCréerDef.Text = "Ajouter un nouveau défunt"
        Me.BtCréerDef.UseVisualStyleBackColor = True
        '
        'BtAjouterDefExistant
        '
        Me.BtAjouterDefExistant.Location = New System.Drawing.Point(361, 347)
        Me.BtAjouterDefExistant.Name = "BtAjouterDefExistant"
        Me.BtAjouterDefExistant.Size = New System.Drawing.Size(305, 23)
        Me.BtAjouterDefExistant.TabIndex = 11
        Me.BtAjouterDefExistant.Text = "Ajouter un défunt déjà enregistré"
        Me.BtAjouterDefExistant.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(404, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(258, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Obsolète - utiliser formeditemplacement"
        '
        'PanelEditEmplacement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtAjouterDefExistant)
        Me.Controls.Add(Me.BtCréerDef)
        Me.Controls.Add(Me.DgvOccupants)
        Me.Controls.Add(Me.GbHistoire)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TbintPlaces)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxTypeEmpl1)
        Me.Controls.Add(Me.TbEmplacement)
        Me.MinimumSize = New System.Drawing.Size(700, 400)
        Me.Name = "PanelEditEmplacement"
        Me.Size = New System.Drawing.Size(982, 478)
        Me.GbHistoire.ResumeLayout(False)
        Me.GbHistoire.PerformLayout()
        CType(Me.DgvOccupants, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbEmplacement As TextBox
    Friend WithEvents ComboBoxTypeEmpl1 As ComboBoxTypeEmpl
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TbintPlaces As TextBoxInt
    Friend WithEvents TbHistoire As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents GbHistoire As GroupBox
    Friend WithEvents DgvOccupants As DataGridView
    Friend WithEvents ColNumLh As DataGridViewTextBoxColumn
    Friend WithEvents ColNumAnnée As DataGridViewTextBoxColumn
    Friend WithEvents ColPrénom As DataGridViewTextBoxColumn
    Friend WithEvents ColNom As DataGridViewTextBoxColumn
    Friend WithEvents ColAdresse As DataGridViewTextBoxColumn
    Friend WithEvents ColVille As DataGridViewComboBoxColumn
    Friend WithEvents ColPays As DataGridViewComboBoxColumn
    Friend WithEvents ColEtatCivil As DataGridViewComboBoxColumn
    Friend WithEvents ColEtatCivilDe As DataGridViewTextBoxColumn
    Friend WithEvents ColDateNaiss As DataGridViewTextBoxColumn
    Friend WithEvents ColLieuNaiss As DataGridViewTextBoxColumn
    Friend WithEvents ColDateDécès As DataGridViewTextBoxColumn
    Friend WithEvents ColLieuDécès As DataGridViewTextBoxColumn
    Friend WithEvents ColEmplacement As DataGridViewComboBoxColumn
    Friend WithEvents ColUrneOuCercueil As DataGridViewComboBoxColumn
    Friend WithEvents BtCréerDef As Button
    Friend WithEvents BtAjouterDefExistant As Button
    Friend WithEvents Label3 As Label
End Class
