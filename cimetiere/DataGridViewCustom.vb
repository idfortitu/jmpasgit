' data gridview avec sélection d'une seule ligne, et quelques paramètres d'affichage

Public Class DataGridViewCustom
    Inherits DataGridView

    Public Sub New()
        InitializeComponent()
    End Sub


    Private Property _customFilterFunc As Func(Of Object, String, Boolean)
    Public Property CustomFilterFunc As Func(Of Object, String, Boolean)
        Set(value As Func(Of Object, String, Boolean))
            _customFilterFunc = value
            If Me.DataSource IsNot Nothing Then Me.DataSource.FilterFunc = value
        End Set
        Get
            Return _customFilterFunc
        End Get
    End Property

    Public Sub UpdateFilter()
        If DataSource IsNot Nothing Then DataSource.UpdateFilter()
    End Sub


    ' si changement de datasource, remet l'ancienne sélection
    ' expose une propriété de type objet pour éviter les erreurs de compilation "cannot convert list of acteur to list of ientityinterface"
    ' mais doit être de type SortableBindingList(Of IEntityInterface)
    Public Overloads Property DataSource As Object 'SortableBindingList(Of IEntityInterface)
        Get
            Return MyBase.DataSource
        End Get
        Set(value As Object) 'SortableBindingList(Of IEntityInterface))
            Dim IdSelect As Integer
            If SelectedRowIndex = -1 Then
                IdSelect = -1
            Else
                IdSelect = CType(SelectedRow.DataBoundItem, IEntity).Id
            End If
            ' re-filtre
            If CustomFilterFunc IsNot Nothing Then value.FilterFunc = _customFilterFunc
            MyBase.DataSource = value
            value.UpdateFilter()
            ' remet l'ancienne sélection
            Dim row As DataGridViewRow = (From r As DataGridViewRow In Me.Rows Where CType(r.DataBoundItem, IEntity).Id = IdSelect).SingleOrDefault
            If row IsNot Nothing Then row.Selected = True
            ' et scrolle dessus si nécessaire
            ScrollSelectedIntoView()

        End Set
    End Property


    ' la dgv de base ne propose que la collection de lignes sélectionnées SelectedRows

    Public ReadOnly Property SelectedRow As DataGridViewRow
        Get
            If SelectedRows.Count > 0 Then
                Return SelectedRows(0)
            Else
                Return Nothing
            End If
        End Get
    End Property



    Public Property SelectedRowIndex As Integer
        Get
            If SelectedRows.Count > 0 Then
                Return SelectedRows(0).Index
            Else
                Return -1
            End If
        End Get
        Set(value As Integer)
            If value = -1 Then
                ClearSelection()
            Else
                If value < Rows.Count Then Rows(value).Selected = True Else ClearSelection()
            End If
        End Set
    End Property


    Public Property SelectedItem As Object
        Get
            Return If(SelectedRows.Count > 0, SelectedRows(0).DataBoundItem, Nothing)
        End Get
        Set(value As Object)
            If value Is Nothing Then
                ClearSelection()
            Else
                Dim laligne = (From l As DataGridViewRow In Rows Where l.DataBoundItem Is value).FirstOrDefault
                If laligne IsNot Nothing Then
                    laligne.Selected = True
                Else
                    ClearSelection()
                End If
            End If
        End Set
    End Property


    Public Sub ScrollSelectedIntoView()
        If SelectedRows.Count > 0 Then
            Dim ligne = SelectedRows(0)
            If Not ligne.Displayed _
             Or GetCellDisplayRectangle(0, ligne.Index, True).Height < GetCellDisplayRectangle(0, ligne.Index, False).Height Then
                FirstDisplayedScrollingRowIndex = ligne.Index
            End If
        End If
    End Sub




    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewCustom
        '
        Me.AllowUserToAddRows = False
        Me.AllowUserToDeleteRows = False
        Me.AllowUserToOrderColumns = True
        Me.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DefaultCellStyle = DataGridViewCellStyle1
        Me.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.MultiSelect = False
        Me.ReadOnly = True
        Me.RowHeadersVisible = False
        Me.RowTemplate.Height = 24
        Me.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
End Class
