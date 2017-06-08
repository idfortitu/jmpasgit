﻿' data gridview avec sélection d'une seule ligne, et quelques paramètres d'affichage

Public Class DataGridViewCustom
    Inherits DataGridView

    Public Sub New()
        InitializeComponent()
    End Sub

    ' si changement de datasource, remet l'ancienne sélection (en se basant sur la première colonne, qu'on suppose être un id)
    Public Overloads Property DataSource As DataTable
        Get
            Return CType(MyBase.DataSource, DataTable)
        End Get
        Set(value As DataTable)
            Dim Filtre As String
            Dim ValeurSelect
            If DataSource IsNot Nothing Then
                ValeurSelect = SelectedValue
                Filtre = DataSource.DefaultView.RowFilter
            Else
                ValeurSelect = Nothing
                Filtre = ""
            End If

            value.DefaultView.RowFilter = Filtre
            MyBase.DataSource = value

            ' remet l'ancienne sélection
            SelectedValue = ValeurSelect

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
                Dim Row As DataGridViewRow = (From r In Rows Where r.cells(0).value = value).SingleOrDefault
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