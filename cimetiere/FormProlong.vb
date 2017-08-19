Public Class FormProlong

    Private ListeConcessions As DataTable

    Public Sub New()
        InitializeComponent()
        DgvCsns.AutoGenerateColumns = False

    End Sub

    Private Sub FormProlong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ListeConcessions = Bdd.Query("SELECT concessions.con_id,emplacements.empl_id,empl_reference,con_date_debut,con_date_fin,CONCAT(UPPER(concessionnaires.csnr_nom),"" "",concessionnaires.csnr_prenom) AS csnr_nom,COUNT(defunts.def_id) AS empl_nb_defunts,com_commentaire,GROUP_CONCAT(CONCAT(ben_prenom,"" "",ben_nom) SEPARATOR "", "") AS noms_benefs" &
        '                              " FROM concessions" &
        '                              " INNER JOIN emplacements ON concessions.empl_id = emplacements.empl_id" &
        '                              " INNER JOIN concessionnaires ON concessions.csnr_id = concessionnaires.csnr_id" &
        '                              " LEFT OUTER JOIN beneficier ON beneficier.con_id = concessions.con_id" &
        '                              " INNER JOIN beneficiaires ON beneficier.ben_id = beneficiaires.ben_id" &
        '                              " LEFT OUTER JOIN defunts ON defunts.empl_id = emplacements.empl_id" &
        '                              " LEFT OUTER JOIN t_commentaire ON concessions.com_id = t_commentaire.com_id" &
        '                              " WHERE concessions.con_date_fin > DATE_SUB(NOW(),INTERVAL 2 MONTH)" &
        '                              " GROUP BY con_id")


        ' on présente aussi les concessions qui ont expiré il y a moins de 2 mois, valeur un peu arbitraire


        ' ramène les noms des défunts et des bénéficiaires ensembles (group_concat), avec le séparateur "¤" - j'ose espérer que personne n'a ça dans son nom
        ListeConcessions = Bdd.Query("SELECT concessions.con_id,emplacements.empl_id,empl_reference,con_date_fin,com_commentaire,CONCAT(csnr_prenom,' ',csnr_nom) AS csnr_nom" &
                                     ", COUNT(distinct defunts.def_id) AS empl_nb_defunts,GROUP_CONCAT(DISTINCT ben_prenom, ' ', ben_nom SEPARATOR '¤') AS noms_benefs" &
                                     ", GROUP_CONCAT(DISTINCT def_prenom,' ',def_nom ORDER BY def_date_deces ASC SEPARATOR '¤') AS noms_defunts" &
                                     " FROM concessions" &
                                     " INNER JOIN beneficier ON beneficier.con_id = concessions.con_id" &
                                     " INNER JOIN beneficiaires ON beneficiaires.ben_id = beneficier.ben_id" &
                                     " INNER JOIN emplacements ON emplacements.empl_id = concessions.empl_id" &
                                     " LEFT OUTER JOIN defunts ON defunts.empl_id = emplacements.empl_id" &
                                     " INNER JOIN t_commentaire ON t_commentaire.com_id = concessions.com_id" &
                                     " INNER JOIN concessionnaires ON concessionnaires.csnr_id = concessions.con_id" &
                                     " GROUP BY concessions.con_id")

        DgvCsns.DataSource = ListeConcessions


    End Sub


    Private Sub DgvCsns_SelectionChanged(sender As Object, e As EventArgs) Handles DgvCsns.SelectionChanged
        LbBenefs.Items.Clear()
        LbOccupants.Items.Clear()
        Dim RowCsn = DgvCsns.SelectedDataRow
        If RowCsn IsNot Nothing Then
            'LbBenefs.Items.AddRange((From r In GetBenefsDeCsn(RowCsn("con_id")).Rows Select r("ben_nom")).ToArray)
            'LbBenefs.Items.Add(RowCsn("noms_benefs"))
            'LbOccupants.Items.AddRange((From r In GetOccupantsDeEmpl(RowCsn("empl_id")).Rows Select Uzineagaz.NomEtDatesDefunt(r)).ToArray)

            If Not IsDBNull(RowCsn("noms_benefs")) Then LbBenefs.Items.AddRange(CType(RowCsn("noms_benefs"), String).Split("¤").ToArray)
            If Not IsDBNull(RowCsn("noms_defunts")) Then LbOccupants.Items.AddRange(CType(RowCsn("noms_defunts"), String).Split("¤").ToArray)
            TbCom.Text = RowCsn("com_commentaire")
        Else
            TbCom.Text = ""
        End If
    End Sub




    Private Function GetBenefsDeCsn(Id As Integer) As DataTable
        Static CacheBenefsCsnExist As New Dictionary(Of Integer, DataTable)
        If CacheBenefsCsnExist.ContainsKey(Id) Then
            Return CacheBenefsCsnExist(Id)
        Else
            Dim res = Bdd.Query("SELECT CONCAT(ben_prenom,"" "",ben_nom) AS ben_nom FROM beneficiaires INNER JOIN beneficier ON beneficier.ben_id = beneficiaires.ben_id" &
                                " WHERE beneficier.con_id = " & Id)
            CacheBenefsCsnExist.Add(Id, res)
            Return res
        End If
    End Function

    Private Function GetOccupantsDeEmpl(Id As Integer) As DataTable
        Static CacheOccupantsEmpl As New Dictionary(Of Integer, DataTable)
        If CacheOccupantsEmpl.ContainsKey(Id) Then
            Return CacheOccupantsEmpl(Id)
        Else
            Dim res = Bdd.Query("SELECT * FROM defunts WHERE empl_id = " & Id)
            CacheOccupantsEmpl.Add(Id, res)
            Return res
        End If
    End Function

    Private Sub BtTerminer_Click(sender As Object, e As EventArgs) Handles BtTerminer.Click

    End Sub







    ' choix concession (aff liste)
    ' choix durée avec auto +30 et +15
    ' montant payé

    ' infos suppl :
    ' bénefs
    ' commentaire
    ' infos csnr
    ' infos défunt(s)




End Class