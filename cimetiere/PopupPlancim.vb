
Public Class PopupPlancim
    Private Emplacements As DataTable

    Private _emplSelect As DataRow
    Public Property EmplSelect As DataRow
        Get
            Return PlanCimetiere1.EmplSelect
        End Get
        Set(value As DataRow)
            PlanCimetiere1.EmplSelect = value
        End Set
    End Property

    Public Event SelectionChanged(empl As DataRow)


    Public Sub New(Empls As DataTable, Optional FuncFiltre As Func(Of DataRow, Boolean) = Nothing)
        InitializeComponent()
        If FuncFiltre IsNot Nothing Then PlanCimetiere1.FuncFiltre = FuncFiltre
        PlanCimetiere1.SetEmplacements(Empls)
    End Sub

    Private Sub PlanCimetiere1_SelectionChanged(sender As Object, e As PlanCimetiere.PlanCimEventArgs) Handles PlanCimetiere1.SelectionChanged
        RaiseEvent SelectionChanged(e.Emplacement)
    End Sub







End Class