Public Class GestionLocVille

    'permet à l'appelant (form gestion) de mettre ses données à jour
    Public IdsVillesSuppr As New List(Of Integer)

    Private DtVilles As DataTable
    Private DtPays As DataTable

    Private DvVilles As DataView
    Private DvPays As DataView

    Private EditMode As Boolean = False

    Public Sub New(DtVilles As DataTable, DtPays As DataTable)
        InitializeComponent()

        Me.DtVilles = DtVilles
        Me.DtPays = DtPays
        DvVilles = New DataView(DtVilles)
        DvPays = New DataView(DtPays)

        InitDgvVille()
        DgvListeVilleCp.DataSource = DvVilles
        DataBindVilleInfos()
        InfosVilleRO()

        InitDgvPays()
        DgvListePays.DataSource = DvPays
        DataBindPaysInfos()
        InfosPaysRO()

        ChargerCbPays(DtPays)

    End Sub

    Private Sub ChargerCbPays(dtpays As DataTable)
        Dim nvdtpays = dtpays.Copy
        Dim rowvide = nvdtpays.NewRow
        rowvide("Pays_id") = -1
        nvdtpays.Rows.InsertAt(rowvide, 0)
        CBVillePays.ValueMember = "Pays_id"
        CBVillePays.DisplayMember = "Pays_nom"
        CBVillePays.DataSource = nvdtpays
    End Sub


    Private Sub DataBindVilleInfos()
        TBVilleNom.DataBindings.Add("Text", DvVilles, "locville_ville")
        TBVilleCP.DataBindings.Add("Text", DvVilles, "locville_cp")
        CBVillePays.DataBindings.Add("SelectedValue", DvVilles, "Pays_id")
    End Sub

    Private Sub DataUnbindVilleInfos()
        TBVilleCP.DataBindings.Clear()
        TBVilleNom.DataBindings.Clear()
        CBVillePays.DataBindings.Clear()
    End Sub

    Private Sub DataBindPaysInfos()
        TBPaysNom.DataBindings.Add("Text", DvPays, "Pays_nom")
    End Sub

    Private Sub DataUnbindPaysInfos()
        TBPaysNom.DataBindings.Clear()
    End Sub


    Private Sub InfosVilleRW()
        TBVilleNom.ReadOnly = False
        TBVilleCP.ReadOnly = False
        CBVillePays.Enabled = True
    End Sub

    Private Sub InfosVilleRO()
        TBVilleNom.ReadOnly = True
        TBVilleNom.ReadOnly = True
        CBVillePays.Enabled = False
    End Sub

    Private Sub InfosPaysRw()
        TBPaysNom.ReadOnly = False
    End Sub

    Private Sub InfosPaysRO()
        TBPaysNom.ReadOnly = True
    End Sub


    Private Sub InitDgvVille()
        Dim col As DataGridViewTextBoxColumn

        col = New DataGridViewTextBoxColumn
        col.DataPropertyName = "locville_ville"
        col.HeaderText = "Ville"
        col.Name = "locville_ville"
        DgvListeVilleCp.Columns.Add(col)

        col = New DataGridViewTextBoxColumn
        col.DataPropertyName = "locville_cp"
        col.HeaderText = "CP"
        col.Name = "locville_cp"
        DgvListeVilleCp.Columns.Add(col)

        col = New DataGridViewTextBoxColumn
        col.DataPropertyName = "locville_id"
        col.Name = "locville_id"
        col.Visible = False
        DgvListeVilleCp.Columns.Add(col)

        DgvListeVilleCp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvListeVilleCp.AutoGenerateColumns = False
    End Sub

    Private Sub InitDgvPays()
        Dim col As DataGridViewTextBoxColumn

        col = New DataGridViewTextBoxColumn
        col.DataPropertyName = "Pays_nom"
        col.HeaderText = "Pays"
        col.Name = "Pays_nom"
        DgvListePays.Columns.Add(col)

        col = New DataGridViewTextBoxColumn
        col.DataPropertyName = "Pays_id"
        col.Name = "Pays_id"
        col.Visible = False
        DgvListePays.Columns.Add(col)

        DgvListePays.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvListePays.AutoGenerateColumns = False

    End Sub

    Private Sub BTPaysMod_Click(sender As Object, e As EventArgs) Handles BTPaysMod.Click
        If DgvListePays.SelectedRows.Count = 0 Then Exit Sub

        If Not EditMode Then
            EditMode = True

            For Each c As Control In {DgvListeVilleCp, DgvListePays, BTPaysSuppr, BTVilleMod, BTVilleSuppr}
                c.Enabled = False
            Next

            DataUnbindPaysInfos()

            InfosPaysRw()
            BTPaysMod.Text = "Terminer"

        Else

            Dim result = MessageBox.Show("Enregistrer les modifications ?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim RowPays = DgvListePays.SelectedDataRow
                RowPays("Pays_nom") = TBPaysNom.Text.Trim
                Bdd.Update("t_pays", RowPays)
                ChargerCbPays(DtPays)
            End If

            For Each c As Control In {DgvListeVilleCp, DgvListePays, BTPaysSuppr, BTVilleMod, BTVilleSuppr}
                c.Enabled = True
            Next

            EditMode = False
            InfosPaysRO()
            DataBindPaysInfos()

            BTPaysMod.Text = "Modifier"
        End If
    End Sub

    Private Sub BTPaysSuppr_Click(sender As Object, e As EventArgs) Handles BTPaysSuppr.Click
        If DgvListePays.SelectedRows.Count = 0 Then Exit Sub

        Dim RowPays = DgvListePays.SelectedDataRow

        Dim result = MessageBox.Show("Supprimer ce pays : " & RowPays("Pays_nom") & " ?", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim IdPays = RowPays("Pays_id")
            If DtVilles.Select("Pays_id = " & IdPays).Count > 0 Then
                MessageBox.Show("Impossible de supprimer un pays tant que des villes y sont liées.")
            Else
                Bdd.Delete("t_pays", IdPays)
                DtPays.Rows.Remove(RowPays)
                Dim VillesAUpd = DtVilles.Select("Pays_id = " & IdPays)
                For Each v In VillesAUpd
                    v("Pays_id") = DBNull.Value
                Next
                ChargerCbPays(DtPays)
            End If
        End If
    End Sub

    Private Sub BTVilleMod_Click(sender As Object, e As EventArgs) Handles BTVilleMod.Click
        If DgvListeVilleCp.SelectedRows.Count = 0 Then Exit Sub

        If Not EditMode Then

            EditMode = True

            For Each c As Control In {DgvListeVilleCp, DgvListePays, BTPaysSuppr, BTPaysMod, BTVilleSuppr}
                c.Enabled = False
            Next

            DataUnbindVilleInfos()

            InfosVilleRW()

            BTVilleMod.Text = "Terminer"

        Else

            Dim result = MessageBox.Show("Enregistrer les modifications ?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim RowVille = DgvListeVilleCp.SelectedDataRow()
                RowVille("locville_ville") = TBVilleNom.Text.Trim
                RowVille("locville_cp") = If(TBVilleCP.Value.HasValue, TBVilleCP.Value, DBNull.Value)
                RowVille("Pays_id") = If(CBVillePays.SelectedValue Is Nothing OrElse CBVillePays.SelectedValue = -1, DBNull.Value, CBVillePays.SelectedValue)
                Bdd.Update("t_loc_ville", RowVille)
            End If

            For Each c As Control In {DgvListeVilleCp, DgvListePays, BTPaysSuppr, BTPaysMod, BTVilleSuppr}
                c.Enabled = True
            Next

            EditMode = False
            InfosVilleRO()
            DataBindVilleInfos()

            BTVilleMod.Text = "Modifier"

        End If
    End Sub

    Private Sub BTVilleSuppr_Click(sender As Object, e As EventArgs) Handles BTVilleSuppr.Click
        If DgvListeVilleCp.SelectedRows.Count = 0 Then Exit Sub

        Dim RowVille = DgvListeVilleCp.SelectedDataRow

        Dim result = MessageBox.Show("Supprimer cette ville : " & RowVille("locville_ville") & " ?", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim IdVille = RowVille("locville_id")
            Bdd.Delete("t_loc_ville", IdVille)
            DtVilles.Rows.Remove(RowVille)
            IdsVillesSuppr.Add(IdVille)
        End If

    End Sub

    Private Sub BtFermer_Click(sender As Object, e As EventArgs) Handles BtFermer.Click
        Me.Close()
    End Sub

    Private Sub Me_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim HauteurDebutDegrade As Integer = Me.Height * 0.42
        Dim RectangleDegrade = New Rectangle(0, HauteurDebutDegrade, Me.Width, Me.Height - HauteurDebutDegrade)
        Dim vLinearGradient As Drawing.Drawing2D.LinearGradientBrush =
                    New Drawing.Drawing2D.LinearGradientBrush(New Drawing.Point(RectangleDegrade.X, RectangleDegrade.Y + RectangleDegrade.Height - 0),
                                                    New Drawing.Point(RectangleDegrade.X, RectangleDegrade.Y - 1),
                                                    Color.FromArgb(11, 160, 92),
                                                    Color.White)


        Dim vGraphic As Drawing.Graphics = Me.CreateGraphics

        vGraphic.FillRectangle(vLinearGradient, RectangleDegrade)

        vGraphic.Dispose()
        vGraphic = Nothing
    End Sub




End Class