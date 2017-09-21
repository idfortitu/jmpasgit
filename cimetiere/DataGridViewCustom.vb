' data gridview avec sélection d'une seule ligne, et quelques paramètres d'affichage

Public Class DataGridViewCustom
    Inherits DataGridView

    Public Sub New()
        InitializeComponent()
    End Sub

    ''''' si changement de datasource, remet l'ancienne sélection (en se basant sur la première colonne, qu'on suppose être un id)
    Public Overloads Property DataSource As Object
        Get
            Return MyBase.DataSource
        End Get
        Set(value As Object)
            If Not TypeOf value Is DataTable AndAlso Not TypeOf value Is DataView AndAlso Not TypeOf value Is BindingSource Then Throw New ArgumentException("Seules les DataTable, les DataView et les BindingSource sont acceptées comme source de données")
            Dim Vue = If(TypeOf value Is DataTable, CType(value, DataTable).DefaultView, If(TypeOf value Is BindingSource, CType(value, BindingSource), CType(value, DataView)))

            MyBase.DataSource = value

            ' remet l'ancienne sélection
            'SelectedValue = ValeurSelect

            ' et scrolle dessus si nécessaire
            ScrollSelectedIntoView()

        End Set
    End Property




    ' la dgv de base ne propose que la collection SelectedRows
    Public Property SelectedRow As DataGridViewRow
        Get
            If SelectedRows.Count > 0 Then
                Return SelectedRows(0)
            Else
                Return Nothing
            End If
        End Get
        Set(value As DataGridViewRow)
            If value IsNot Nothing Then
                value.Selected = True
            Else
                ClearSelection()
            End If
        End Set
    End Property

    ' renvoie une DataRow, qui permet un index, par exemple ladgv.SelectedDataRow("empl_id")
    Public ReadOnly Property SelectedDataRow As DataRow
        Get
            If Me.SelectedRows.Count > 0 Then
                Return CType(Me.SelectedRow.DataBoundItem, DataRowView).Row
            Else Return Nothing
            End If
            ' alternative :
            ' Return Me.DataSource.Rows(Me.CurrentRow.Index)
        End Get
    End Property

    ' se base sur la valeur de la première colonne (supposée l'id), à employer avec précaution
    Public Property SelectedValue
        Get
            If Rows.Count > 0 AndAlso Columns.Count > 0 Then
                Dim sl = SelectedRow
                If sl Is Nothing Then
                    Return -1
                Else
                    Return sl.Cells(0).Value
                End If
            Else
                Return -1
            End If
        End Get
        Set(value)
            If value = -1 Or Columns.Count <= 0 Then
                ClearSelection()
            Else
                Dim Row As DataGridViewRow = (From r As DataGridViewRow In Rows Where r.Cells(0) IsNot Nothing AndAlso Not IsDBNull(r.Cells(0)) AndAlso r.Cells(0).Value = value).FirstOrDefault
                If Row Is Nothing Then
                    ClearSelection()
                Else
                    Row.Selected = True
                End If
            End If
        End Set
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

    Public Sub ScrollSelectedIntoView()
        If SelectedRows.Count > 0 Then
            Dim ligne = SelectedRows(0)
            If Not ligne.Displayed _
             Or GetCellDisplayRectangle(0, ligne.Index, True).Height < GetCellDisplayRectangle(0, ligne.Index, False).Height Then
                FirstDisplayedScrollingRowIndex = ligne.Index
            End If
            ' alternative simple à tester peut-être - mais CurrenCell n'est peut-être pas modifié par autre chose qu'un clic ou un appel explicite
            ' Me.FirstDisplayedCell = Me.CurrentCell
        End If
    End Sub

    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewCustom
        '
        Me.AllowUserToAddRows = False
        Me.AllowUserToDeleteRows = False
        Me.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DefaultCellStyle = DataGridViewCellStyle2
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
