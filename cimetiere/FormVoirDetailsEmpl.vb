Public Class FormVoirDetailsEmpl

    Private IdEmpl As Integer

    Private LEmplacement As DataRow
    Private LesOccupants As DataTable
    Private LesBeneficiaires As DataTable

    Private LesEmplacements As DataTable


    Sub New(IdEmpl As Integer, Optional ProposerProlong As Boolean = False)
        InitializeComponent()
        Me.IdEmpl = IdEmpl
        BtRenouveler.Visible = ProposerProlong AndAlso user <> "User"
    End Sub

    Private Sub FormDetailsNotifCsnAbandon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TblLemplacement = Bdd.Query("SELECT * FROM emplacements" &
                                    " LEFT OUTER JOIN concessions ON concessions.empl_id = emplacements.empl_id" &
                                    " LEFT OUTER JOIN concessionnaires ON concessionnaires.csnr_id = concessions.csnr_id" &
                                    " LEFT OUTER JOIN t_commentaire ON concessions.com_id = t_commentaire.com_id" &
                                    " LEFT OUTER JOIN t_histoire ON emplacements.hist_id = t_histoire.h_id" &
                                    " LEFT OUTER JOIN t_loc_ville ON t_loc_ville.locville_id = concessionnaires.locville_id" &
                                    " LEFT OUTER JOIN t_Pays on t_Pays.Pays_id = t_loc_ville.Pays_id" &
                                    " WHERE emplacements.empl_id = " & Me.IdEmpl) '(0)
        Me.LEmplacement = TblLemplacement(0)
        For i = 0 To TblLemplacement.Columns.Count - 1
            If TblLemplacement.Columns(i).DataType Is GetType(String) AndAlso IsDBNull(Me.LEmplacement.ItemArray(i)) Then
                Me.LEmplacement(i) = ""
            End If
        Next


        If IsDBNull(LEmplacement("con_id")) Then
            PanelInfosConcession.Hide()
            PlanCimConteneur1.Size = New Size(PlanCimConteneur1.Location.X + PlanCimConteneur1.Width - PanelInfosConcession.Location.X, PanDefunts.Location.Y - 2 - PanelInfosConcession.Location.Y + 121)       ' 121 pour agrandir un peu, vu qu'il y a de la place
            PlanCimConteneur1.Location = New Point(PanelInfosConcession.Location.X, PanelInfosConcession.Location.Y)
            PanDefunts.Location = New Point(PanelInfosConcession.Location.X, PanDefunts.Location.Y + 121)
            LabTitre.Text = "Situation de l'emplacement"
        End If

        Me.Text = "Emplacement " & LEmplacement("empl_reference")


        If Not IsDBNull(LEmplacement("con_id")) Then
            Me.LesOccupants = Bdd.Query("SELECT * FROM defunts WHERE empl_id = " & Me.LEmplacement("empl_id"))
            Me.LesBeneficiaires = Bdd.Query("SELECT * FROM beneficier INNER JOIN beneficiaires ON beneficier.ben_id = beneficiaires.ben_id" &
                                        " WHERE beneficier.con_id = " & LEmplacement("con_id"))
        Else
            Me.LesOccupants = Bdd.GetTableVide("defunts")
            Me.LesBeneficiaires = Bdd.GetTableVide("beneficiaires")
        End If


        ' pas besoin du plan si on n'a pas les coordonnées de l'emplacement ; de plus, montrer une parcelle où il ne se trouve pas pourrait être trompeur
        If Not IsDBNull(LEmplacement("empl_coords")) OrElse Not CType(LEmplacement("empl_reference"), String).Substring(0, 2) Like "[A-Za-z]#" Then
            PlanCimetiere1.SetEmplacements(Bdd.GetTable("emplacements"))
            PlanCimetiere1.NomParcelleAffichee = CType(LEmplacement("empl_reference"), String).Substring(0, 2)
            PlanCimetiere1.IdEmplSelect = Me.LEmplacement("empl_id")
        End If

        ' infos concession
        LabRefEmpl.Text = LEmplacement("empl_reference")
        TbDateDebut.Text = If(IsDBNull(LEmplacement("con_date_debut")), "", CType(LEmplacement("con_date_debut"), Date).ToString("dd/MM/yyyy"))
        TbDateFin.Text = If(IsDBNull(LEmplacement("con_date_fin")), "", CType(LEmplacement("con_date_fin"), Date).ToString("dd/MM/yyyy"))
        If Not IsDBNull(LEmplacement("con_date_fin")) AndAlso DateAdd(DateInterval.Day, -DUREE_PREVISION_EXPIRATION_CONCESSION, LEmplacement("con_date_fin")) < Today Then
            TbDateFin.BackColor = Color.Khaki
        End If

        If LEmplacement("com_commentaire") <> "" Then
            TbCsnCom.Text = LEmplacement("com_commentaire")
        Else
            GbCsnCom.Hide()
        End If

        ' infos concessionnaire
        TbCsnrNom.Text = LEmplacement("csnr_nom")
        TbCsnrPrenom.Text = LEmplacement("csnr_prenom")
        TbCsnrTel.Text = LEmplacement("csnr_tel")

        TbCsnrAdresse.Text = Uzineagaz.AdresseComplete(LEmplacement("csnr_adresse"),
                                                  If(IsDBNull(LEmplacement("locville_cp")), Nothing, LEmplacement("locville_cp")),
                                                  If(IsDBNull(LEmplacement("locville_ville")), Nothing, LEmplacement("locville_ville")),
                                                  If(IsDBNull(LEmplacement("Pays_nom")), Nothing, LEmplacement("Pays_nom"))
                                                  )


        ' infos occupants
        For Each RowOcc As DataRow In Me.LesOccupants.Rows
            DgvOccupants.Rows.Add({Uzineagaz.NomEtDatesDefunt(RowOcc), Uzineagaz.EtatCivilComplet(RowOcc), RowOcc("def_numero_lh"), RowOcc("def_numero_annee")})
        Next

        If Not IsDBNull(LEmplacement("h_histoire")) AndAlso LEmplacement("h_histoire") <> "" Then
            TbEmplHistoire.Text = LEmplacement("h_histoire")
        Else
            PanEmplHistoire.Hide()
        End If

        ' infos bénefs
        For Each RowBen As DataRow In Me.LesBeneficiaires.Rows
            DgvBenefs.Rows.Add({RowBen("ben_prenom") & " " & RowBen("ben_nom"), RowBen("ben_lien_parente")})
        Next

    End Sub


    ' pas besoin de sélection, juste affichage
    Private Sub DataGridViewCustom1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvOccupants.CellContentClick
        DgvOccupants.ClearSelection()
    End Sub


    Private Sub BtRenouveler_Click(sender As Object, e As EventArgs) Handles BtRenouveler.Click
        Using f As New FormProlong(Me.LEmplacement("con_id"))
            f.ShowDialog()
            If f.DialogResult = DialogResult.OK Then
                TbDateFin.Text = If(f.NouvelleDate.HasValue, f.NouvelleDate.Value.ToString("dd/MM/yyyy"), "")
                If f.NouvelleDate.HasValue AndAlso DateAdd(DateInterval.Day, -DUREE_PREVISION_EXPIRATION_CONCESSION, f.NouvelleDate.Value) < Today Then
                    TbDateFin.BackColor = Color.Khaki
                Else
                    TbDateFin.BackColor = SystemColors.Control
                End If
                Me.DialogResult = DialogResult.OK         ' ferme le form, suppose que ce qui devait être fait a été fait ; l'appelant (form home) aura dialogresult.ok pour indiquer que la liste des notifs doit être updatée
            End If
        End Using
    End Sub

    Private Sub Me_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim HauteurDebutDegrade As Integer = Me.Height * 0.42
        Dim RectangleDegrade = New Rectangle(0, HauteurDebutDegrade, Me.Width, Me.Height - HauteurDebutDegrade)
        ' - 6 au premier param parce que sinon il peut y avoir une ligne verte en haut du rectangle du dégradé, comme si le dégradé (re)commençait quelques pixels trop bas
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