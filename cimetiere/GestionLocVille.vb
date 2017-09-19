Public Class GestionLocVille
    Public dtlocville As DataTable
    Public dvlistelocville As DataView
    Private Sub GestionLocVille_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DataTableVillePayss

    End Sub

    Private Sub DataBindPaysVilleInfos()
        FGLCTBCP.DataBindings.Add("Text", dvlistelocville, "locville_ville")
        FGLCTBVille.DataBindings.Add("EmplId", dvlistelocville, "locville_cp")
        FGLCTBPays.DataBindings.Add("Checked", dvlistelocville, "Pays_nom")
    End Sub

    Sub DataTableVillePays()
        dtlocville = Bdd.Query("SELECT * FROM t_loc_ville LEFT OUTER JOIN t_pays ON t_pays.Pays_id = t_loc_ville.locville_id")
        dvlistelocville = New DataView(dtlocville)
        InitDgvVillePays()
        DgvListeVilleCp.DataSource = dvlistelocville
        DataBindPaysVilleInfos()
    End Sub

    Private Sub InitDgvVillePays()
        Dim DTGV_Id_Colonne = New DataGridViewTextBoxColumn()
        Dim ColonnePrenom = New DataGridViewTextBoxColumn()
        Dim colonneid = New DataGridViewTextBoxColumn()
        Dim colonnecsnr = New DataGridViewTextBoxColumn()
        Dim colonnedatefin = New DataGridViewTextBoxColumn()
        Dim colonneemplid = New DataGridViewTextBoxColumn()
        DTGV_Id_Colonne.DataPropertyName = "con_numero"
        DTGV_Id_Colonne.HeaderText = "numero"
        DTGV_Id_Colonne.Name = "con_numero"
        DgvListeVilleCp.Columns.Add(DTGV_Id_Colonne)
        ColonnePrenom.DataPropertyName = "empl_reference"
        ColonnePrenom.HeaderText = "emplacement"
        ColonnePrenom.Name = "empl_reference"
        DgvListeVilleCp.Columns.Add(ColonnePrenom)
        colonneid.DataPropertyName = "con_id"
        colonneid.HeaderText = "id"
        colonneid.Name = "con_id"
        DgvListeVilleCp.Columns.Add(colonneid)
        DgvListeVilleCp.Columns("con_id").Visible = False
        colonnecsnr.DataPropertyName = "csnr_id"
        colonnecsnr.HeaderText = "id"
        colonnecsnr.Name = "csnr_id"
        DgvListeVilleCp.Columns.Add(colonnecsnr)
        DgvListeVilleCp.Columns("csnr_id").Visible = False
        colonnedatefin.DataPropertyName = "con_date_fin"
        colonnedatefin.HeaderText = "con_date_fin"
        colonnedatefin.Name = "con_date_fin"
        DgvListeVilleCp.Columns.Add(colonnedatefin)
        DgvListeVilleCp.Columns("con_date_fin").Visible = False
        colonneemplid.DataPropertyName = "empl_id"
        colonneemplid.HeaderText = "empl_id"
        colonneemplid.Name = "empl_id"
        DgvListeVilleCp.Columns.Add(colonneemplid)
        DgvListeVilleCp.Columns("empl_id").Visible = False
        DgvListeVilleCp.AutoGenerateColumns = False
        DgvListeVilleCp.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvListeVilleCp.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

End Class