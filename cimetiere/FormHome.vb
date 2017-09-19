
Public Class FormHome

    Private _nombrenotifs
    Private Property NombreNotifs As Integer
        Get
            Return _nombrenotifs
        End Get
        Set(value As Integer)
            _nombrenotifs = value
            BtNotifsMontrer.Text = "Notifications" & If(Me.NombreNotifs > 0, " (" & Me.NombreNotifs & ")", "")
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
        DgvNotifsCsnsExp.AutoGenerateColumns = False
        DgvNotifsCsnsAb.AutoGenerateColumns = False
    End Sub

    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using FormLogin As New FormLogin
            Dim ResultatLogin = FormLogin.ShowDialog()
            If ResultatLogin <> DialogResult.OK Then
                Close()
                Exit Sub
            End If
        End Using
        LabWelkom.Text = "Bonjour " & user

        ChargerNotifs()


        ' possibilité pr servicepop ajouter info empl/éditer notif ??

    End Sub

    Private Sub ChargerNotifs()
        Dim CsnsExpirant = Bdd.Query("SELECT con_id,empl_reference,emplacements.empl_id,csnr_tel,CONCAT(csnr_prenom,' ',csnr_nom) AS csnr_nomcomplet, con_date_fin FROM concessions " &
                                " INNER JOIN concessionnaires ON concessionnaires.csnr_id = concessions.csnr_id" &
                                " INNER JOIN emplacements ON concessions.empl_id = emplacements.empl_id" &
                                " WHERE con_date_fin <= '" & DateAdd(DateInterval.Day, DUREE_PREVISION_EXPIRATION_CONCESSION, Today).ToString("yyyy-MM-dd") & "'" &
                                " AND con_date_fin >= CURDATE()" &
                                " ORDER BY con_date_fin ASC")
        DgvNotifsCsnsExp.DataSource = CsnsExpirant
        Dim NotifsAbandons = Bdd.Query("SELECT notif_id,emplacements.empl_id,empl_reference,CONCAT(csnr_prenom,' ',csnr_nom) AS csnr_nomcomplet,csnr_tel FROM notifications" &
                                   " LEFT OUTER JOIN emplacements ON notifications.notif_emplacement = emplacements.empl_id" &
                                   " LEFT OUTER JOIN concessions ON concessions.empl_id = emplacements.empl_id" &
                                   " LEFT OUTER JOIN concessionnaires ON concessions.csnr_id = concessionnaires.csnr_id")
        DgvNotifsCsnsAb.DataSource = NotifsAbandons
        Me.NombreNotifs = CsnsExpirant.Rows.Count + NotifsAbandons.Rows.Count
    End Sub



    '' les contrôles sont rendus en cache avant d'être affiché, ça peut éviter quelques scintillements mais en contrepartie ça retarde leur affichage
    '' Dans le cas présent, le fond a tendance à être noir pendant l'affichage, du coup c'est naze
    ' mais ça ça peut mieux fonctionner sur d'autres forms
    'Protected Overrides ReadOnly Property CreateParams() As CreateParams
    '    Get
    '        Dim cp As CreateParams = MyBase.CreateParams
    '        cp.ExStyle = cp.ExStyle Or &H2000000    ' WS_EX_COMPOSITED
    '        Return cp
    '    End Get
    'End Property 'CreateParams

    Private Sub BtNotifsMasquer_Click(sender As Object, e As EventArgs) Handles BtNotifsMasquer.Click
        ' contrairement à autosize, régler la taille avant de mettre les contrôles permet de donner une couleur de fond plus jolie que le noir de base pendant que les contrôles sont dessinés
        Me.Height = Me.Height - Me.ClientRectangle.Height + PanelToutSaufNotifs.Height      ' ajuste la zone client à la taille du panel ; comme on joue sur Me.Size il faut tenir compte de la barre de titre, etc.
        PanNotifs.Hide()
        BtNotifsMasquer.Hide()
        BtNotifsMontrer.Show()

    End Sub

    Private Sub BtNotifsMontrer_Click(sender As Object, e As EventArgs) Handles BtNotifsMontrer.Click
        Me.Height = Me.Height - Me.ClientRectangle.Height + PanelToutSaufNotifs.Height + PanNotifs.Height

        BtNotifsMontrer.Hide()
        BtNotifsMasquer.Show()
        PanNotifs.Show()
    End Sub

    Private Sub BtDéclarationDécès_Click(sender As Object, e As EventArgs) Handles BtDéclarationDécès.Click
        If user = "User" Then
            MessageBox.Show("Erreur d'autorisation", "Erreur")
        Else
            Dim aer As New FormDemandeInhumation
            aer.ShowDialog()
        End If
    End Sub

    Private Sub BtRéserverCon_Click(sender As Object, e As EventArgs) Handles BtRéserverCon.Click
        If user = "User" Then
            MessageBox.Show("Erreur d'autorisation", "Erreur")
        Else
            Dim res As New FormReservation
            res.ShowDialog()
        End If
    End Sub

    Private Sub BtProlongation_Click(sender As Object, e As EventArgs) Handles BtProlongation.Click
        If user = "User" Then
            MessageBox.Show("Erreur d'autorisation", "Erreur")
        Else
            Dim a As New FormProlong
            a.ShowDialog()
        End If
    End Sub


    Private Sub BtConsulterDonnées_Click(sender As Object, e As EventArgs) Handles BtConsulterDonnées.Click
        Dim f As New FormGestion
        f.ShowDialog()
    End Sub

    Private Sub BtSgnalAbCsn_Click(sender As Object, e As EventArgs) Handles BtSignalAbCsn.Click
        Using f As New FormSignalAbandonCsn
            f.ShowDialog()
            If f.DialogResult = DialogResult.OK Then
                ChargerNotifs()
            End If
        End Using
    End Sub

    Private Sub DgvNotifsCsnsExp_CellPainting(sender As DataGridView, e As DataGridViewCellPaintingEventArgs) Handles DgvNotifsCsnsExp.CellPainting, DgvNotifsCsnsAb.CellPainting
        ' https://stackoverflow.com/a/36253883

        If e.RowIndex < 0 Then Exit Sub             ' -1 = en-tête de colonne

        Dim Dessiner As Boolean = False

        Dim LaCol As DataGridViewColumn
        Dim NomCol As String
        If sender Is DgvNotifsCsnsExp OrElse sender Is DgvNotifsCsnsAb Then
            LaCol = sender.Columns(e.ColumnIndex)
            NomCol = LaCol.Name
        End If

        If sender Is DgvNotifsCsnsExp Then
            If NomCol = "DgvCsnsExpColBtDetails" Then
                Dessiner = True
            End If
        ElseIf sender Is DgvNotifsCsnsAb Then
            If NomCol = "DgvCsnsAbColBtDetails" Then
                Dessiner = True
            End If
        End If

        If Dessiner Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim w = My.Resources.ColumnDetail_16x.Width
            Dim h = My.Resources.ColumnDetail_16x.Height
            Dim x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2
            Dim y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2

            e.Graphics.DrawImage(My.Resources.ColumnDetail_16x, New Rectangle(x, y, w, h))
            e.Handled = True
        End If

    End Sub


    Private Sub DgvNotifsCsnsExp_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvNotifsCsnsExp.CellFormatting
        If DgvNotifsCsnsExp.Columns(e.ColumnIndex).Name = "DgvCsnsExpDateExp" Then
            e.CellStyle.BackColor = Color.Khaki
            If e.Value IsNot Nothing AndAlso Not IsDBNull(e.Value) Then      ' précaution inutile puisque les concessions sont prises sur le critère qu'elles ont une date de fin (et qui ne soit pas passée), mais soit
                Dim DateFin As Date = e.Value
                Dim TempsRestant = DateFin.Subtract(Today)
                Dim SemainesRestantes As Integer
                Dim JoursRestants As Integer
                If TempsRestant.Days <= 21 Then
                    SemainesRestantes = TempsRestant.Days \ 7
                    JoursRestants = TempsRestant.Days Mod 7
                Else
                    SemainesRestantes = Math.Round((TempsRestant.Days / 3.5) / 2, MidpointRounding.AwayFromZero)      ' comme on n'affiche pas les jours au-delà de 3 semaines, ceci permet d'arrondir par exemple "3 semaines et 6 jours" en "4 semaines" au lieu de tronquer les jours restants
                    JoursRestants = TempsRestant.Days - SemainesRestantes * 7       ' peut être négatif si le nombre de semaines a été arrondi vers le haut, de toute façon on ne les affichera pas
                End If
                Dim DateStr = DateFin.ToString("dd/MM/yyyy")
                If DateFin = Today Then
                    DateStr &= " (aujourd'hui)"
                Else


                    DateStr &= " (dans "
                    If SemainesRestantes > 0 Then
                        DateStr &= SemainesRestantes & " semaine" & If(SemainesRestantes > 1, "s", "")
                    End If
                    If JoursRestants > 0 AndAlso SemainesRestantes <= 2 Then
                        If SemainesRestantes > 0 Then DateStr &= " et "
                        DateStr &= JoursRestants & " jour" & If(JoursRestants > 1, "s", "")
                    End If
                    DateStr &= ")"
                End If
                e.Value = DateStr
                End If
            End If
    End Sub


    'Private Sub FormHome_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
    'Dim HauteurDebutDegrade As Integer = Me.Height * 0.42
    'Dim RectangleDegrade = New Rectangle(0, HauteurDebutDegrade, Me.Width, Me.Height - HauteurDebutDegrade)
    ''Dim rectangledegrade As New Rectangle(0, 0, 0, 0)
    '' - 6 au premier param parce que sinon il peut y avoir une ligne verte en haut du rectangle du dégradé, comme si le dégradé (re)commençait quelques pixels trop bas
    'Dim vLinearGradient As Drawing.Drawing2D.LinearGradientBrush =
    '            New Drawing.Drawing2D.LinearGradientBrush(New Drawing.Point(RectangleDegrade.X, RectangleDegrade.Y + RectangleDegrade.Height - 6),
    '                                            New Drawing.Point(RectangleDegrade.X, RectangleDegrade.Y),
    '                                            Color.FromArgb(11, 160, 92),
    '                                            Color.White)


    'Dim vGraphic As Drawing.Graphics = Me.CreateGraphics
    '' To tile the image background - Using the same image background of the image
    ''Dim vTexture As New Drawing.TextureBrush(Me.BackgroundImage)

    'vGraphic.FillRectangle(vLinearGradient, RectangleDegrade)
    ''vGraphic.FillRectangle(vTexture, Me.DisplayRectangle)

    'vGraphic.Dispose() : vGraphic = Nothing ': vTexture.Dispose() : vTexture = Nothing
    'End Sub


    Private Sub Panel1_Paint(sender As Panel, e As PaintEventArgs) Handles PanelToutSaufNotifs.Paint
        Dim HauteurDebutDegrade As Integer = sender.Height * 0.42
        Dim RectangleDegrade = New Rectangle(0, HauteurDebutDegrade, sender.Width, sender.Height - HauteurDebutDegrade)
        ' - 6 au premier param parce que sinon il peut y avoir une ligne verte en haut du rectangle du dégradé, comme si le dégradé (re)commençait quelques pixels trop bas
        Dim vLinearGradient As Drawing.Drawing2D.LinearGradientBrush =
                    New Drawing.Drawing2D.LinearGradientBrush(New Drawing.Point(RectangleDegrade.X, RectangleDegrade.Y - 6),
                                                    New Drawing.Point(RectangleDegrade.X, RectangleDegrade.Y + RectangleDegrade.Height),
                                                    Color.White,
                                                    Color.FromArgb(11, 160, 92))

        Dim vGraphic = e.Graphics

        vGraphic.FillRectangle(vLinearGradient, RectangleDegrade)

        vGraphic.Dispose() : vGraphic = Nothing
    End Sub

    Private Sub DgvNotifsCsnsExp_CellContentClick(sender As DataGridView, e As DataGridViewCellEventArgs) Handles DgvNotifsCsnsExp.CellContentClick, DgvNotifsCsnsAb.CellContentClick
            If e.RowIndex < 0 Then Exit Sub

        Dim LaCsn = CType(sender.Rows(e.RowIndex).DataBoundItem, DataRowView).Row

        Dim NomCol = sender.Columns(e.ColumnIndex).Name
        If NomCol = "DgvCsnsExpColBtDetails" OrElse NomCol = "DgvCsnsAbColBtDetails" Then
            ActivItemDgvSub(sender, LaCsn)
        End If
    End Sub

    Private Sub DgvNotifsCsnsExp_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvNotifsCsnsExp.CellDoubleClick, DgvNotifsCsnsAb.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub
        Dim LaCsn = CType(sender.Rows(e.RowIndex).DataBoundItem, DataRowView).Row
        ActivItemDgvSub(sender, LaCsn)
    End Sub


    Private Sub ActivItemDgvSub(sender As DataGridView, LaCsn As DataRow)
        If sender Is DgvNotifsCsnsExp Then
            If Not IsDBNull(LaCsn("empl_id")) Then
                Using f As New FormVoirDetailsEmpl(LaCsn("empl_id"), True)
                    f.ShowDialog()
                    If f.DialogResult = DialogResult.OK Then ChargerNotifs()
                End Using
            End If
        ElseIf sender Is DgvNotifsCsnsAb Then
            Using f As New FormPopupPrecisionsAbandon(LaCsn("notif_id"))
                f.ShowDialog()
                If f.Suppression Then ChargerNotifs()
            End Using
        End If
    End Sub

    Private Sub AGAGA(sender As Object, e As PaintEventArgs) Handles BtConsulterDonnées.Paint
        Dim borderRectangle As Rectangle = sender.ClientRectangle
        borderRectangle.Inflate(-10, -10)
        ControlPaint.DrawBorder3D(e.Graphics, borderRectangle,
            Border3DStyle.Raised)
        ControlPaint.DrawBorder(e.Graphics, borderRectangle, Color.Red, 10, ButtonBorderStyle.Solid, Color.Red, 10, ButtonBorderStyle.Solid, Color.Red, 10, ButtonBorderStyle.Solid, Color.Red, 10, ButtonBorderStyle.Solid)
    End Sub

    Private Sub DgvNotifsCsnsExp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvNotifsCsnsExp.CellContentClick, DgvNotifsCsnsAb.CellContentClick

    End Sub

    Private Sub DgvNotifsCsnsExp_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DgvNotifsCsnsExp.CellPainting, DgvNotifsCsnsAb.CellPainting

    End Sub
End Class
