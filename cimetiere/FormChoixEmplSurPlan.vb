Public Class FormChoixEmplSurPlan

		' Plus très à jour

    Private Emplacements As DataTable
    Private FuncFiltre As Func(Of DataRow, Boolean)


    ' à tester
    Private _emplSelect
    Public Property EmplSelect As DataRow
        Get
            Return _emplSelect
        End Get
        Set(value As DataRow)
            Dim EmplDejaSelect = If(DgvEmpls.SelectedRows.Count > 0, DgvEmpls.SelectedRows(0), Nothing)
            If EmplDejaSelect IsNot _emplSelect Then
                _emplSelect = value
                DgvEmpls_SelectionChanged(Nothing, Nothing)
            End If
        End Set
    End Property



    Public Event SelectionChanged(empl As DataRow)

    Public Sub New()
        InitializeComponent()        ' This call is required by the designer.
        DgvEmpls.AutoGenerateColumns = False
    End Sub

    ' permet de passer une table d'emplacements personnalisée, par exemple avec des champs supplémentaires pour le filtrage
    Public Sub New(Empls As DataTable, FuncFiltre As Func(Of DataRow, Boolean))
        InitializeComponent()
        DgvEmpls.AutoGenerateColumns = False
        Me.FuncFiltre = FuncFiltre
        Me.Emplacements = Empls
    End Sub

    Public Sub New(FuncFiltre As Func(Of DataRow, Boolean))
        InitializeComponent()
        DgvEmpls.AutoGenerateColumns = False
        Me.FuncFiltre = FuncFiltre
    End Sub

    Public Sub New(Empls As DataTable)
        InitializeComponent()
        DgvEmpls.AutoGenerateColumns = False
        Me.Emplacements = Empls
    End Sub



    Private Sub FormChoixEmplSurPlan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not DesignMode Then
            If Me.FuncFiltre IsNot Nothing Then PlanCimetiere1.FuncFiltre = Me.FuncFiltre
            If Me.Emplacements Is Nothing Then
                Me.Emplacements = Bdd.Query("SELECT emplacements.*, COUNT(def_id) AS empl_nb_defunts" &
                                    " FROM emplacements" &
                                    " LEFT OUTER JOIN defunts ON defunts.empl_id = emplacements.empl_id" &
                                    " GROUP BY empl_id")
            End If
            PlanCimetiere1.SetEmplacements(Me.Emplacements)

                DgvEmpls.DataSource = (From r In Me.Emplacements.AsEnumerable Where PlanCimetiere1.FuncFiltre(r)).AsDataView
            End If
    End Sub


    Private Sub DgvEmpls_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvEmpls.CellFormatting
        Dim LaCol = DgvEmpls.Columns(e.ColumnIndex)
        If LaCol.Name = "ColOccupants" Then
            Dim RowEmpl = CType(DgvEmpls.Rows(e.RowIndex).DataBoundItem, DataRowView).Row
            Dim Aff As String = RowEmpl("empl_nb_defunts")
            If Not IsDBNull(RowEmpl("empl_nb_places")) Then
                Aff &= "/" & RowEmpl("empl_nb_places")
                'If RowEmpl("empl_nb_places") < RowEmpl("empl_nb_defunts") Then e.CellStyle.BackColor = Color.Yellow
            End If
            e.Value = Aff
        ElseIf LaCol.Name = "ColMonumClasse" Then
            e.Value = If(e.Value = True, "Oui", "")
        End If

    End Sub

    Private Sub PlanCimetiere1_SelectionChanged(sender As Object, e As PlanCimetiere.PlanCimEventArgs) Handles PlanCimetiere1.SelectionChanged
        If e.Emplacement Is Nothing Then
            DgvEmpls.ClearSelection()
        Else
            Dim zerty = (From r As DataGridViewRow In DgvEmpls.Rows Where CType(r.DataBoundItem, DataRowView).row Is e.Emplacement).First
            zerty.Selected = True
            DgvEmpls.ScrollSelectedIntoView()
        End If
    End Sub

    Private Sub DgvEmpls_SelectionChanged(sender As Object, e As EventArgs) Handles DgvEmpls.SelectionChanged
        PlanCimetiere1.EmplSelect = DgvEmpls.SelectedDataRow
        LbOccupants.Items.Clear()
        Dim RowEmpl = Nothing

        If DgvEmpls.SelectedRows.Count > 0 Then
            RowEmpl = DgvEmpls.SelectedDataRow
            Dim InfosCsn = GetInfosCsn(RowEmpl("empl_id"))
            Dim Occupants = GetOccupants(RowEmpl("empl_id"))

            For Each Occ In Occupants.Rows
                LbOccupants.Items.Add(Uzineagaz.NomEtDatesDefunt(Occ))
            Next

            If InfosCsn Is Nothing Then
                GbReservation.Hide()
            Else
                GbReservation.Show()
                TbCsnr.Text = InfosCsn("csnr_nom")
                TbDateDebut.Text = If(IsDBNull(InfosCsn("con_date_debut")), "", InfosCsn("con_date_debut"))
                TbDateFin.Text = If(IsDBNull(InfosCsn("con_date_fin")), "", InfosCsn("con_date_fin"))
            End If
        End If
        Me._emplSelect = RowEmpl
        RaiseEvent SelectionChanged(RowEmpl)

    End Sub


    ' renvoie nothing si il n'y a pas de concession
    Private Function GetInfosCsn(empl_id As Integer) As DataRow
        If Not CacheInfosCsn.ContainsKey(empl_id) Then
            Dim Res = Bdd.Query("SELECT con_date_debut,con_date_fin,csnr_nom,csnr_prenom" &
                                " FROM concessions INNER JOIN concessionnaires ON concessionnaires.csnr_id = concessions.csnr_id " &
                                " WHERE concessions.empl_id = " & empl_id & " AND (con_date_debut < NOW() OR con_date_debut IS NULL) AND (con_date_fin > NOW() OR con_date_fin IS NULL) AND NOT(con_date_fin IS NULL AND con_date_debut IS NULL)")
            If Res.Rows.Count > 0 Then
                CacheInfosCsn.Add(empl_id, Res.Rows(0))
            Else
                CacheInfosCsn.Add(empl_id, Nothing)
            End If
        End If
        Return CacheInfosCsn(empl_id)
    End Function
    Private CacheInfosCsn As New Dictionary(Of Integer, DataRow)

    Private Function GetOccupants(empl_id As Integer) As DataTable
        If Not CacheOccupants.ContainsKey(empl_id) Then
            CacheOccupants.Add(empl_id, Bdd.Query("SELECT * FROM defunts WHERE empl_id = " & empl_id))
        End If
        Return Bdd.Query("SELECT * FROM defunts WHERE empl_id = " & empl_id)
    End Function

    Private CacheOccupants As New Dictionary(Of Integer, DataTable)

    Private Sub GbReservation_Enter(sender As Object, e As EventArgs) Handles GbReservation.Enter

    End Sub





    ' infos dgv : 
    ' réf
    ' occupants/places
    ' classé
    ' à sélect :
    ' occs
    ' infos location : 
    '  csnr
    '  dates

    ' prop du form :
    ' si seulement non loués
    ' si seulement vides ???
End Class