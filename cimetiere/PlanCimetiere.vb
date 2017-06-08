Public Class PlanCimetiere

    Public Event EmplClicked(sender As PlanCimetiere, e As PlanCimEventArgs)
    Public Event SelectionChanged(sender As Object, e As PlanCimEventArgs)
    Public Event EmplDoubleClicked(sender As PlanCimetiere, e As PlanCimEventArgs)
    ' Public Font As New Font("Courier New", 16)        ' existe déjà dans la classe Control


    ' à changer pour la vraie classe emplacement utilisée par le prog
    Public Class emplacementtresclasse
        Public Id As Integer
        Public Coords As Byte()
        Public reference As String
        Public nbplaces As Integer?
        Public nboccupants As Integer
        Public estloué As Boolean
    End Class

    Public CouleurVide As Color = Color.FromArgb(60, Color.White)
    Public CouleurPartiellementPlein As Color = Color.FromArgb(100, Color.MediumPurple)
    Public CouleurPlein As Color = Color.FromArgb(100, Color.Purple)
    Public CouleurBordureLoué As Color = Color.FromArgb(255, Color.Yellow)
    Public CouleurBordurePasLoué As Color = Color.Transparent



    'Public :
    ' Sub SetListeEmplacements(empls as List(Of emplacementtresclasse))
    ' ce n'est pas un data binding, les changements faits sur la liste ne changeront pas l'état du plan (ceux sur les emplacements oui puisque les objets restent les mêmes, mais sans garantie du résultat)

    ' Ne gère pas spécialement les emplacements sans id, ne prévoit pas qu'un emplacement puisse changer d'id (ni de n'importe quoi en fait)

    Private Const COORDS_ECHELLE_BASE = 2000       ' les coordonnées des emplacements sont interprétées comme si l'image faisait 2000x2000, puis sont mises à l'échelle

    ' le plan peut changer de taille pour garder les proportions de l'image, mais il doit retenir la taille originale comme taille maximum
    Private LargeurOrig As Integer
    Private HauteurOrig As Integer
    ' indique si la taille originale a déjà été enregistrée, déjà pour ne pas le faire plusieurs fois, ensuite pour ne pas changer le bg si ce n'est pas encore fait
    Private TailleAEtéDéfinie As Boolean = False

    Private TailleTexteEmplacement As Size    ' utilisé pour centrer le texte sur le polygone de l'emplacement
    Private FontVoulue As Font  ' la police réellement affichée sera mise à l'échelle et se base (comme pour les coordonnées des emplacements) sur des dimensions de 2000x2000

    Public Sub New()
        InitializeComponent() ' This call is required by the designer.
        CalculerLargeurTexteEmplacement()
    End Sub

    Private Sub CalculerLargeurTexteEmplacement()
        TailleTexteEmplacement = TextRenderer.MeasureText("A3000", Me.Font)
    End Sub

    Public Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(value As Font)
            MyBase.Font = value
            CalculerLargeurTexteEmplacement()
        End Set
    End Property

    Private Sub _changerImage(NouvelleImage As Image)
        If TailleAEtéDéfinie AndAlso NouvelleImage IsNot MyBase.BackgroundImage Then
            If NouvelleImage IsNot Nothing Then
                ' ajuste les dimensions du contrôle pour respecter le ratio de la nouvelle image
                Dim nvl = NouvelleImage.Width
                Dim nvh = NouvelleImage.Height
                Dim ratiol = nvl / LargeurOrig
                Dim ratioh = nvh / HauteurOrig
                'If ratiol > ratioh Then ratioh = ratiol Else ratiol = ratioh
                Dim ratio = If(ratiol > ratioh, ratiol, ratioh)
                nvl = nvl / ratio 'l
                nvh = nvh / ratio 'h
                Me.Height = nvh
                Me.Width = nvl
            End If
            Me.BackgroundImage = NouvelleImage
        End If
    End Sub

    ' Change l'image, mais garde les emplacements en les adaptant juste aux nouvelles dimensions (ce qui ne devrait généralement pas servir, les anciens emplacements ne collant probablement pas avec la nouvelle image)
    Public Sub ChangerImage(NvImg As Image)
        _changerImage(NvImg)
        MajListeCoordonnées()
    End Sub
    ' Accepte une nouvelle liste d'emplacements (cas le plus logique)
    Public Sub ChangerImage(NvImg As Image, NvListeEmpls As IEnumerable(Of emplacementtresclasse))
        _changerImage(NvImg)
        SetEmplacements(NvListeEmpls)
    End Sub
    ' retire les empls
    Public Sub ChangerImage(NvImage As Image, Optional ViderEmpls As Boolean = True)
        _changerImage(NvImage)
        If ViderEmpls Then ViderEmplacements()      ' ça devrait toujours être le cas, sinon autant ne pas mettre le paramètre
    End Sub

    ' Overloads pour accepter un nom de fichier plutôt qu'une Image
    Public Sub ChangerImage(NvImg As String)
        ChangerImage(Image.FromFile(NvImg))
    End Sub
    Public Sub ChangerImage(NvImg As String, NvListeEmpls As IEnumerable(Of emplacementtresclasse))
        ChangerImage(Image.FromFile(NvImg), NvListeEmpls)
    End Sub
    Public Sub ChangerImage(NvImg As String, Optional ViderEmpls As Boolean = True)
        ChangerImage(Image.FromFile(NvImg), ViderEmpls)
    End Sub




    Private PolygonesEmplacements As New List(Of Point())
    Private ListeEmplacements As New List(Of emplacementtresclasse)

    Private ttip As New TooltipL With {.AutoPopDelay = 1000000, .InitialDelay = 0, .ReshowDelay = 500, .ShowAlways = True}

    Private Property _emplSelect As emplacementtresclasse

    Public Property EmplSelect As emplacementtresclasse
        Get
            Return _emplSelect
        End Get
        Set(value As emplacementtresclasse)
            If value IsNot _emplSelect Then
                _emplSelect = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Public Property IdEmplSelect As Integer
        Get
            Return If(_emplSelect IsNot Nothing, EmplSelect.Id, -1)
        End Get
        Set(value As Integer)
            ' cherche l'index du ctrl demandé dans la liste
            Dim i As Integer = 0
            While i < ListeEmplacements.Count AndAlso ListeEmplacements(i).Id <> value
                i += 1
            End While
            If i < ListeEmplacements.Count Then     ' trouvé ?
                EmplSelect = ListeEmplacements(i)
            Else
                ' si l'id demandé n'est pas présent, on ne sélectionne rien
                EmplSelect = Nothing
            End If
            'End If
        End Set
    End Property

    ' il faut un évènement qui arrive une fois que les dimensions sont définies et qui ne se déclenchera plus après, ce qui n'est pas si évident ;
    ' ne conviennent pas : Load, New (dimensions pas encore définies), ParentChanged (se fait avant redimensionnement de Windows), Layout, SizeChanged (se redéclenchent quand le plan change sa taille pour garder les proportions de l'image)
    Private Sub NoterDimensionsOriginales() Handles Me.LocationChanged
        Me.LargeurOrig = Me.Width
        Me.HauteurOrig = Me.Height
        TailleAEtéDéfinie = True
    End Sub

    Public Class PlanCimEventArgs
        Inherits EventArgs
        Public Emplacement As emplacementtresclasse
        Sub New(empl As emplacementtresclasse)
            Me.Emplacement = empl
        End Sub
    End Class

    Sub Me_Click(sender As Object, e As MouseEventArgs) Handles Me.Click
        Dim EmplCliqué As emplacementtresclasse = EmplacementA(e.Location)
        If EmplCliqué IsNot Nothing Then RaiseEvent EmplClicked(Me, New PlanCimEventArgs(EmplCliqué))
        If EmplCliqué IsNot EmplSelect Then
            EmplSelect = EmplCliqué
            RaiseEvent SelectionChanged(Me, New PlanCimEventArgs(EmplCliqué))
        End If
    End Sub

    Private Sub Me_DoubleClick(sender As PlanCimetiere, e As MouseEventArgs) Handles Me.DoubleClick
        Dim EmplCliqué As emplacementtresclasse = EmplacementA(e.Location)
        If EmplCliqué IsNot Nothing Then RaiseEvent EmplDoubleClicked(Me, New PlanCimEventArgs(EmplCliqué))
    End Sub

    ' Renvoie l'emplacement qui est situé au point indiqué (celui d'un clic de souris par exemple)
    Private Function EmplacementA(p As Point) As emplacementtresclasse
        Dim LEmpl As emplacementtresclasse = Nothing
        For i = 0 To PolygonesEmplacements.Count - 1
            Dim Path = New Drawing2D.GraphicsPath
            Path.AddPolygon(PolygonesEmplacements(i))
            If Path.IsVisible(p) Then
                LEmpl = ListeEmplacements(i)
                Exit For
            End If
        Next
        'End If
        Return LEmpl
    End Function

    Public Sub ViderEmplacements()
        ListeEmplacements.Clear()
        PolygonesEmplacements.Clear()
        EmplSelect = Nothing
        'Me.Invalidate()    ' déjà déclenché par EmplSelect
    End Sub

    Public Sub SetEmplacements(empls As IEnumerable(Of emplacementtresclasse))
        ListeEmplacements.Clear()
        For Each empl In empls  ' tri : le plan ne prend que les emplacements qui ont des coordonnés
            If empl.Coords IsNot Nothing Then ListeEmplacements.Add(empl)
        Next
        MajListeCoordonnées()
        EmplSelect = Nothing
        'Me.Invalidate()    ' déjà déclenché par EmplSelect
    End Sub

    ' à faire éventuellement : mettre les coordonnées à jour au resize

    ' Met à jour la liste PolygonesEmplacements d'après le contenu de ListeEmplacements
    ' décortique les coordonnées, qui sont enregistrées sous la forme d'une suite d'octets, chaque groupe de 4 octets représentant un point : les 2 premiers octets pour la coordonnée X et les 2 autres pour Y (en little endian)
    ' ça pourrait être fait au moment de l'appel de OnPaint ; l'avantage serait que les changements sur les coordonnées des emplacements
    ' seraient visibles au lieu de rester une liste figée (mais ces changements ne devraient pas arriver), l'inconvénient serait un dessin
    ' sans doute un peu plus long à faire
    Private Sub MajListeCoordonnées()
        Dim rapport_l As Single = COORDS_ECHELLE_BASE / Me.Size.Width
        Dim rapport_h As Single = COORDS_ECHELLE_BASE / Me.Size.Height
        PolygonesEmplacements.Clear()

        For Each empl In ListeEmplacements
            Dim CoordsBinaireCetEmpl As Byte() = empl.Coords

            Dim i_coords As Integer = 0
            Dim NombrePointsCetEmpl As Integer = CoordsBinaireCetEmpl.Count \ 4
            Dim PolygoneCetEmpl(NombrePointsCetEmpl - 1) As Point
            Dim i_poly As Integer = 0
                While i_coords < empl.Coords.Count
                Dim tmpx As Single = empl.Coords(i_coords)  ' integer ?
                i_coords += 1
                tmpx += empl.Coords(i_coords) * &H100              ' cast ? memorystream ? 
                i_coords += 1
                tmpx /= rapport_l

                Dim tmpy As Single = empl.Coords(i_coords)
                i_coords += 1
                tmpy += empl.Coords(i_coords) * &H100
                i_coords += 1
                tmpy /= rapport_h

                PolygoneCetEmpl(i_poly) = New Point(tmpx, tmpy)
                i_poly += 1
                End While
                PolygonesEmplacements.Add(PolygoneCetEmpl)
        Next
        'End If
        Me.Invalidate()
    End Sub

    Private Function Milieu(poly As Point()) As Point    ' ou plutôt, centre du rectangle orthogonal englobant le polygone
        Dim minX = 2000.0F
        Dim maxX = -2000.0F
        Dim minY = 2000.0F
        Dim maxY = -2000.0F
        For Each p In poly
            If p.X < minX Then minX = p.X
            If p.X > maxX Then maxX = p.X
            If p.Y < minY Then minY = p.Y
            If p.Y > maxX Then maxY = p.Y
        Next
        Return New Point((maxX + minX) \ 2, (maxY + minY) \ 2)
    End Function

    Protected Overrides Sub OnPaint(pe As PaintEventArgs)
        MyBase.OnPaint(pe)
        ' Ici, varier le dessin des emplacements en fonction de leur type, location...
        Using BrosseEmplVide = New SolidBrush(CouleurVide),
              BrosseEmplVideSélect = New SolidBrush(Color.FromArgb(If(CouleurVide.A * 2 > 255, 255, CouleurVide.A * 2), CouleurVide)),        ' tester avec couleurvide.a*2 > 255
              BrosseEmplPartiellementPlein = New SolidBrush(CouleurPartiellementPlein),
              BrosseEmplPartiellementPleinSélect = New SolidBrush(Color.FromArgb(If(CouleurPartiellementPlein.A * 2 > 255, 255, CouleurPartiellementPlein.A * 2), CouleurPartiellementPlein)),
              BrosseEmplPlein = New SolidBrush(CouleurPlein),
              BrosseEmplPleinSélect = New SolidBrush(Color.FromArgb(If(CouleurPlein.A * 2 > 255, 255, CouleurPlein.A * 2), CouleurPlein)),
              PenContourLoué = New Pen(New SolidBrush(CouleurBordureLoué)) With {.Width = 1},
              PenContourLouéSélect As New Pen(New SolidBrush(Color.FromArgb(If(CouleurBordureLoué.A * 2 > 255, 255, CouleurBordureLoué.A * 2), CouleurBordureLoué))),
              PenContourPasLoué = New Pen(New SolidBrush(CouleurBordurePasLoué)) With {.Width = 1},
              PenContourPasLouéSélect = PenContourPasLoué,
              Stylo As New SolidBrush(Color.White)

            Dim Graph = pe.Graphics
            Dim BrosseRemplissage As SolidBrush
            Dim PenContour As Pen

            Dim brosses = {BrosseEmplVide, BrosseEmplVideSélect, BrosseEmplPartiellementPlein, BrosseEmplPartiellementPleinSélect, BrosseEmplPlein, BrosseEmplPleinSélect}
            Dim pens = {PenContourLoué, PenContourLouéSélect, PenContourPasLoué, PenContourPasLouéSélect}
            ' contour
            For i = 0 To ListeEmplacements.Count - 1
                Dim empl = ListeEmplacements(i)

                Dim n As Integer

                If empl.estloué Then n = Array.IndexOf(pens, PenContourLoué) Else n = Array.IndexOf(pens, PenContourPasLoué)
                If empl Is _emplSelect Then n += 1
                PenContour = pens(n)

                If empl.nboccupants = 0 Then
                    n = Array.IndexOf(brosses, BrosseEmplVide)
                ElseIf Not empl.nbplaces.HasValue OrElse empl.nbplaces > empl.nboccupants Then
                    n = Array.IndexOf(brosses, BrosseEmplPartiellementPlein)
                Else
                    n = Array.IndexOf(brosses, BrosseEmplPlein)
                End If
                If empl Is _emplSelect Then n += 1
                BrosseRemplissage = brosses(n)

                Graph.FillPolygon(BrosseRemplissage, PolygonesEmplacements(i))
                Graph.DrawPolygon(PenContour, PolygonesEmplacements(i))

                ' écrit la référence
                Dim MilieuZoneEmpl = Milieu(PolygonesEmplacements(i))
                Dim CoinHGTxt = New Point(MilieuZoneEmpl.X - TailleTexteEmplacement.Width / 2, MilieuZoneEmpl.Y - TailleTexteEmplacement.Height / 2)
                Graph.DrawString(ListeEmplacements(i).reference, Me.Font, Stylo, CoinHGTxt)
            Next
        End Using
    End Sub

    ' Tooltip personnalisé d'une taille de police plus grande
    Private Class TooltipL
        Inherits ToolTip

        Public myfont = New Font(SystemFonts.DefaultFont.FontFamily, 12)

        Sub New()
            MyBase.New()
            Me.OwnerDraw = True
        End Sub
        Public Sub New(ByVal Cont As System.ComponentModel.IContainer)
            MyBase.New(Cont)
            Me.OwnerDraw = True
        End Sub
        Private Sub OnPopup(sender As Object, e As PopupEventArgs) Handles Me.Popup
            Dim s As Size = Size.Round(e.AssociatedControl.CreateGraphics().MeasureString(Me.GetToolTip(e.AssociatedControl), myfont))
            s.Height += 4
            e.ToolTipSize = s
        End Sub

        Private Sub OnDraw(ByVal sender As Object, ByVal e As DrawToolTipEventArgs) Handles Me.Draw
            Dim newe = New DrawToolTipEventArgs(e.Graphics, e.AssociatedWindow, e.AssociatedControl, e.Bounds, e.ToolTipText, Me.BackColor, Me.ForeColor, myfont)
            newe.DrawBackground()
            newe.DrawBorder()
            newe.DrawText(TextFormatFlags.LeftAndRightPadding)
        End Sub

    End Class

End Class
