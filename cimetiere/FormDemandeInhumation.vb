Public Class FormDemandeInhumation

    Public Sub New()
        InitializeComponent()
        DgvCsnsExist.AutoGenerateColumns = False

    End Sub

    Private Sub BtSuivant_Click(sender As Object, e As EventArgs) Handles BtSuivant.Click
        Select Case True
            Case RbInhOrd.Checked
                ChangerPage(TabP2InhSimple)
                'OngletInhSimpleSelectionne()
            Case RbNouvelleCon.Checked
                'ChangerPage(TabP2NvCon)
                'Dim f As New FormReservation
                'f.ShowDialog()
                BtSuivantNouvelleCon
                                '' a 
                'OngletNvConSelectionne()
            Case RbConcExis.Checked
                ChangerPage(TabP2ConExis)
                OngletCsnsExistantesSelectionne()
        End Select
    End Sub

    Public Function ValidePourBtSuivant() As Boolean
        ValiderRbChoix()
        ValiderNomDef()
        ValiderPrenomDef()
        ValiderDateNaissDef()
        ValiderDateDecesDef()

        Return ErrorProvider1.GetError(RbNouvelleCon) = "" _
            AndAlso ErrorProvider1.GetError(TbDefNom) = "" _
            AndAlso ErrorProvider1.GetError(TbDefPrenom) = "" _
            AndAlso ErrorProvider1.GetError(TbDefDateNaiss) = "" _
            AndAlso ErrorProvider1.GetError(TbDefDateDeces) = ""


        ' valid code défunt : ne doit pas déjà exister
        ' si non précisé, on le génèrera automatiquement
        ' la ville devrait être correcte ; si elle ne l'est pas, on la corrigera/supprimera sans avertissement 
        ' pareil état civil
    End Function

    Private Sub ValiderRbChoix()
        If Not (RbConcExis.Checked OrElse RbInhOrd.Checked OrElse RbNouvelleCon.Checked) Then
            ErrorProvider1.SetError(RbNouvelleCon, "Veuillez indiquer un choix")
        Else
            ErrorProvider1.SetError(RbNouvelleCon, "")
        End If
    End Sub
    Private Sub ValiderNomDef()
        If TbDefNom.Text.Trim = "" Then
            ErrorProvider1.SetError(TbDefNom, "Veuillez indiquer le nom du défunt")
        Else
            ErrorProvider1.SetError(TbDefNom, "")
        End If
    End Sub
    Private Sub ValiderPrenomDef()
        If TbDefPrenom.Text.Trim = "" Then
            ErrorProvider1.SetError(TbDefPrenom, "Veuillez indiquer le prénom du défunt")
        Else
            ErrorProvider1.SetError(TbDefPrenom, "")
        End If
    End Sub
    Private Sub ValiderDateNaissDef()
        If TbDefDateNaiss.DateEstValide Then
            ErrorProvider1.SetError(TbDefDateNaiss, "")
        Else
            ErrorProvider1.SetError(TbDefDateNaiss, "La date n'est pas valide")
        End If
    End Sub
    Private Sub ValiderDateDecesDef()
        If TbDefDateDeces.DateEstValide Then
            ErrorProvider1.SetError(TbDefDateDeces, "")
        Else
            ErrorProvider1.SetError(TbDefDateDeces, "La date n'est pas valide")
        End If
    End Sub




    ' on ne doit pas pouvoir changer d'onglet manuellement, seulement en cliquant sur suivant/précédent
    Private TabsBloqués As Boolean = True
    Private Sub TabControl1_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles TabControl1.Selecting
        If TabsBloqués Then
            e.Cancel = True
        End If
    End Sub
    Sub ChangerPage(page As TabPage)
        TabsBloqués = False
        TabControl1.SelectTab(page)
        TabsBloqués = True
    End Sub



#Region "Onglet concession existante"

    ' infos concessions existantes :
    ' - emplacement (réf)
    ' - concessionnaire
    ' - (type)
    ' - début
    ' - fin
    ' - (en bas) bénefs
    ' -   occupants

    Private Sub OngletCsnsExistantesSelectionne()
        If DgvCsnsExist.DataSource Is Nothing Then
            DgvCsnsExist.DataSource = GetListeConcessionsExistantes()
        End If
    End Sub



    Private TableConcessionsExistantes As DataTable
    Private Function GetListeConcessionsExistantes()
        If TableConcessionsExistantes Is Nothing Then
            TableConcessionsExistantes = Bdd.Query("SELECT con_id,emplacements.empl_id,empl_reference,con_date_debut,con_date_fin,CONCAT(UPPER(concessionnaires.csnr_nom),"" "",concessionnaires.csnr_prenom) AS csnr_nom,empl_nb_places,COUNT(defunts.def_id) AS empl_nb_defunts" &
                                                   " FROM concessions" &
                                                   " INNER JOIN emplacements ON concessions.empl_id = emplacements.empl_id" &
                                                   " INNER JOIN concessionnaires ON concessions.csnr_id = concessionnaires.csnr_id" &
                                                   " LEFT OUTER JOIN defunts ON defunts.empl_id = emplacements.empl_id" &
                                                   " /*WHERE concessions.con_date_fin > NOW()*/" &
                                                   " GROUP BY con_id")
        End If
        Return TableConcessionsExistantes
    End Function

    Private Function GetBenefsDeCsn(Id As Integer) As DataTable
        If CacheBenefsCsnExist.ContainsKey(Id) Then
            Return CacheBenefsCsnExist(Id)
        Else
            Dim res = Bdd.Query("SELECT * FROM beneficiaires INNER JOIN beneficier ON beneficier.ben_id = beneficiaires.ben_id" &
                                " INNER JOIN t_loc_ville ON t_loc_ville.locville_id = beneficiaires.locville_id" &
                                " WHERE beneficier.con_id = " & Id)
            CacheBenefsCsnExist.Add(Id, res)
            Return res
        End If
    End Function

    Private CacheBenefsCsnExist As New Dictionary(Of Integer, DataTable)


    Private Function GetOccupantsDeEmpl(Id As Integer) As DataTable
        If CacheOccupantsEmpl.ContainsKey(Id) Then
            Return CacheOccupantsEmpl(Id)
        Else
            Dim res = Bdd.Query("SELECT * FROM defunts WHERE empl_id = " & Id)
            CacheOccupantsEmpl.Add(Id, res)
            Return res
        End If
    End Function

    Private CacheOccupantsEmpl As New Dictionary(Of Integer, DataTable)

    Private Sub DgvCsnsExist_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvCsnsExist.CellFormatting
        Dim LaCol = DgvCsnsExist.Columns(e.ColumnIndex)
        If LaCol.Name = "DgvCsnsExistColOccupants" Then
            Dim RowCsn = CType(DgvCsnsExist.Rows(e.RowIndex).DataBoundItem, DataRowView).Row
            Dim Aff As String = RowCsn("empl_nb_defunts")
            If Not IsDBNull(RowCsn("empl_nb_places")) Then
                Aff &= "/" & RowCsn("empl_nb_places")
            End If
            e.Value = Aff
        End If
    End Sub


    Private Sub DgvCsnsExist_SelectionChanged(sender As Object, e As EventArgs) Handles DgvCsnsExist.SelectionChanged
        LvCsnExisBenefs.Items.Clear()
        LvCsnExistOccupants.Items.Clear()
        ' liste occupants
        If DgvCsnsExist.SelectedRows.Count > 0 Then
            Dim RowCsn = CType(DgvCsnsExist.SelectedRow.DataBoundItem, DataRowView).Row
            Dim TblBenefs = GetBenefsDeCsn(RowCsn("con_id"))
            For Each RowBen In TblBenefs.Rows
                LvCsnExisBenefs.Items.Add(New ListViewItem({RowBen("ben_nom"), RowBen("ben_prenom"), RowBen("ben_date_naiss"), RowBen("ben_lien_parente"), RowBen("ben_adresse") & " " & RowBen("locville_cp") & " " & RowBen("locville_ville")}))
            Next
            Dim TblOcc = GetOccupantsDeEmpl(RowCsn("empl_id"))
            For Each RowOcc In TblOcc.Rows
                LvCsnExistOccupants.Items.Add(New ListViewItem({RowOcc("def_nom"), RowOcc("def_prenom"), RowOcc("def_date_naiss"), RowOcc("def_date_deces")}))
            Next


        Else
            ' désélectionner
        End If
        'GetBenefsDeCsn()

        ' liste bénefs
    End Sub

    Private Sub BtTerminerConExis_Click(sender As Object, e As EventArgs) Handles BtTerminerConExis.Click
        ' À FAIRE valid & enreg
    End Sub



#End Region


#Region "Opération nouvelle concession"

    Private Sub BtSuivantNouvelleCon()
        ' validation
        If ValidePourBtSuivant() Then

            Me.Hide()

            Dim f As New FormReservation(FormReservation.TMode.Dependant)
            f.ShowDialog()
            If f.DialogResult = DialogResult.OK Then
                ' à ce stade la concession a été enregistrée
                ' -> enregistrer et mettre le défunt dans l'emplacement
                Dim RowDef = Bdd.GetRowVide("defunts")
                ' numéro LH
                If TbDefNumLh.Value IsNot Nothing Then
                    RowDef("def_numero_lh") = TbDefNumLh.Value
                Else
                    ' génère un numéro - celui suivant le plus élevé trouvé en bdd
                    Dim NumMaxBdd = Bdd.Query("SELECT MAX(def_numero_lh) from defunts").Rows(0)(0)
                    RowDef("def_numero_lh") = If(Not IsDBNull(NumMaxBdd), NumMaxBdd + 1, 1)
                End If
                ' numéro année ----- à faire
                RowDef("def_nom") = TbDefNom.Text.Trim
                RowDef("def_prenom") = TbDefPrenom.Text.Trim
                RowDef("def_adresse") = TbDefAdresse.Text.Trim
                If CtrlDefLocvillepays.LocVilleId > 0 Then
                    RowDef("locville_id") = CtrlDefLocvillepays.LocVilleId
                Else
                    RowDef("locville_id") = DBNull.Value
                End If
                RowDef("def_date_naiss") = If(TbDefDateNaiss.DateValue, DBNull.Value)
                RowDef("def_lieu_naiss") = TbDefLieuNaiss.Text.Trim
                RowDef("def_date_deces") = If(TbDefDateDeces.DateValue, DBNull.Value)
                RowDef("def_lieu_deces") = TbDefLieuDeces.Text.Trim
                RowDef("def_etat_civil") = CtrlDefEtatCiv.EtatCivil
                RowDef("def_etat_civil_de") = CtrlDefEtatCiv.EtatCivilDe

                ' emplacement qui vient d'être alloué
                RowDef("empl_id") = f.RowCsn("empl_id")

                Bdd.Insert("defunts", RowDef)

                ' pdf - À FAIRE

                Me.DialogResult = DialogResult.OK

            Else
                Me.Show()

            End If




        End If
    End Sub


#End Region


    ' possibilités :

    ' - choix d'une concession existante
    ' - réservation d'une concession
    ' - emplacement simple

    ' pcontact ?


    ' 1) infos du défunts
    '    choix si concession
    ' 1b) type emplacement simple si applicable
    '   - pleine terre cercueil/urne
    '   - urne en colomb
    '   - dispersion
    ' 2a) choix csn existante
    ' 2b) réservation
    ' x) personne de contact




End Class