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
            Dim EmplDejaSelect = PlanCimetiere1.EmplSelect
            If EmplDejaSelect IsNot value Then
                _emplSelect = value
                PlanCimetiere1.EmplSelect = value
            End If
        End Set
    End Property



    Public Event SelectionChanged(empl As DataRow)

    Public Sub New()
        InitializeComponent()        ' This call is required by the designer.
    End Sub

    ' permet de passer une table d'emplacements personnalisée, par exemple avec des champs supplémentaires pour le filtrage
    Public Sub New(Empls As DataTable, FuncFiltre As Func(Of DataRow, Boolean))
        InitializeComponent()
        Me.FuncFiltre = FuncFiltre
        Me.Emplacements = Empls
    End Sub

    Public Sub New(FuncFiltre As Func(Of DataRow, Boolean))
        InitializeComponent()
        Me.FuncFiltre = FuncFiltre
    End Sub

    Public Sub New(Empls As DataTable)
        InitializeComponent()
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
        End If
    End Sub


    Private Sub PlanCimetiere1_SelectionChanged(sender As Object, e As PlanCimetiere.PlanCimEventArgs) Handles PlanCimetiere1.SelectionChanged
        Dim EmplSel = e.Emplacement

        LbOccupants.Items.Clear()

        If EmplSel IsNot Nothing Then
            Dim InfosCsn = GetInfosCsn(EmplSel("empl_id"))
            Dim Occupants = GetOccupants(EmplSel("empl_id"))
            LbOccupants.Items.AddRange((From Occ In Occupants.Rows Select Uzineagaz.NomEtDatesDefunt(Occ)).ToArray)
            If InfosCsn Is Nothing Then  ' si l'empl n'est pas réservé
                GbReservation.Hide()
            Else
                GbReservation.Show()
                TbCsnr.Text = InfosCsn("csnr_prenom") & " " & InfosCsn("csnr_nom")
                TbDateDebut.Text = If(IsDBNull(InfosCsn("con_date_debut")), "", InfosCsn("con_date_debut"))
                TbDateFin.Text = If(IsDBNull(InfosCsn("con_date_fin")), "", InfosCsn("con_date_fin"))
            End If
            CbMonumClasse.Checked = EmplSel("empl_monum_classe")
            TbReference.Text = EmplSel("empl_reference")
        Else
            CbMonumClasse.Checked = False
            TbReference.Text = ""
        End If

        Me._emplSelect = EmplSel
        RaiseEvent SelectionChanged(EmplSel)

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

    Private Sub BtFermer_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub FormChoixEmplSurPlan_Layout(sender As Object, e As EventArgs) Handles MyBase.Layout
        ' plan loc        Loc 939
        'Form clt  width 1233
        'écart 294
        'donc pos cltwidth-294
        PanInfos.Location = New Point(Me.ClientRectangle.Width - 224, PanInfos.Location.Y)

        ' plan taille x = pos panel - écart plan~panel - marge gauche 
        PlanCimConteneur1.Width = PanInfos.Location.X - 2 - 12

        PlanCimConteneur1.Height = Me.ClientRectangle.Height - 12 - 12

        BtFermer.Location = New Point(Me.ClientRectangle.Width - 25 - BtFermer.Width, Me.ClientRectangle.Height - 12 - BtFermer.Height)


    End Sub

    Private Sub BtFermer_Click_1(sender As Object, e As EventArgs) Handles BtFermer.Click
        Me.Close()
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