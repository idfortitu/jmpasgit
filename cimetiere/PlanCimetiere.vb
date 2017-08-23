Imports System.ComponentModel
Imports System.Runtime.InteropServices


Public Class PlanCimetiere

    ' charger les emplacements :
    '  Dim TblEmpls = Bdd.GetTable("emplacements")
    '  PlanCimetiere1.SetEmplacements(TblEmpls)
    ' (se base sur la référence de l'emplacement pour déterminer à quelle parcelle il appartient, par exemple "A20100" = parcelle A2)

    ' changer la parcelle affichée :
    '  PlanCimetiere1.NomParcelleAffichee="A2"

    ' récupérer la row de l'emplacement sélectionné :
    '  Dim EmplacementSelectionne As DataRow = PlanCimetiere1.EmplSelect

    ' id de l'empl sélectionné : PlanCimetiere1.IdEmplSelect (pas testé à fond)

    ' évènements :
    ' un emplacement a été cliqué :
    ' Sub PlanCimetiere1_EmplClicked(sender as PlanCimetiere, e As PlanCimEventArgs) Handles PlanCimetiere1.EmplClicked
    '   e.Emplacement donne la datarow de l'emplacement concerné
    ' End Sub
    ' double clic sur emplacement :
    '  Sub PlanCimetiere1_EmplDoubleClicked(sender as PlanCimetiere, e As PlanCimEventArgs) Handles PlanCimetiere1.EmplDoubleClicked
    ' sélection d'un emplacement :
    '  Sub PlanCimetiere1_SelectionChanged(sender as PlanCimetiere, e As PlanCimEventArgs) Handles PlanCimetiere1.SelectionChanged



    Private Class InfosParcelle
        Public NomFicImg As String
        Public IdsEmpls As New List(Of Integer)
        Public CoordsXOriginales As New List(Of List(Of Integer))
        Public CoordsYOriginales As New List(Of List(Of Integer))
        Public CoordsX As New List(Of List(Of Integer))
        Public CoordsY As New List(Of List(Of Integer))
        Public RefsEmpls As New List(Of String)
        Public Emplacements As New List(Of DataRow)     ' on tient aussi une liste des datarows représentant les emplacements, pour les transmettre à l'appelant si il en a besoin
        Private CacheBgImg As Image = Nothing
        Public ReadOnly Property BgImage As Image
            Get
                If CacheBgImg Is Nothing Then
                    CacheBgImg = Image.FromFile(Me.NomFicImg)
                End If
                Return CacheBgImg
            End Get
        End Property
        Public Enableds As New List(Of Boolean)


    End Class

    ' - chargement : datatable emplacements
    ' - si coords absentes, ne pas montrer, peut-être griser dans la dgv associée ??
    ' - images des parcelles prédéfinies, peut-être propriétés publique (mais valeur par défaut)
    ' - fonctions publiques pour changer de parcelle (ce qui entraîne changement d'image et repositionnement des emplacements)
    ' - évènements publics pour sélectionchangée, clic & double clic sur emplacement
    ' - fonction publique pour recharger les données (pas les coords qui ne devraient pas changer), à défaut de faire un contrôle databound


    Private Const COORDS_ECHELLE_BASE = 2000       ' les coordonnées des emplacements sont interprétées comme si l'image faisait 2000x2000, puis sont mises à l'échelle de la taille du contrôle

    Private InfosParcelles As Dictionary(Of String, InfosParcelle) = New Dictionary(Of String, InfosParcelle) From {
        {"A1", New InfosParcelle With {.NomFicImg = "planA1.JPG"}},
        {"A2", New InfosParcelle With {.NomFicImg = "planA2.JPG"}},
        {"A3", New InfosParcelle With {.NomFicImg = "planA3.JPG"}}
     }


    Private _nomParcelleAffichee As String = "A1"
    Public Property NomParcelleAffichee As String
        Get
            Return _nomParcelleAffichee
        End Get
        Set(value As String)
            If _nomParcelleAffichee = value Then Exit Property
            If Not InfosParcelles.ContainsKey(value) Then Throw New ArgumentException("Nom de parcelle non reconnu")
            Me._nomParcelleAffichee = value
            Me.ParcelleAffichee = InfosParcelles(value)
            Me.EmplSelect = Nothing
            ChangerImage(ParcelleAffichee.BgImage)
            Me.Zoom = Me.Zoom
            Me.Invalidate()
        End Set
    End Property

    Private ParcelleAffichee As InfosParcelle = InfosParcelles(_nomParcelleAffichee)

    Private _zoom As Single = 1
    ' change en fait la taille du contrôle, il faut que le plan soit mis dans un panel avec scrolling pour que le truc soit raisonnablement utilisable
    <Category("Appearance")>
    Public Property Zoom As Single
        Get
            Return _zoom
        End Get
        Set(value As Single)
            If Not TailleAEteDefinie Then Exit Property            ' ne pas mettre ça entraîne un redimensionnement du contrôle à 0x0 ("taille originale" tant que celle-ci n'a pas été mesurée), dimensions qui seront par la suite ensuite officialisées en tant que taille originale, condamnant le contrôle à toujours faire 0x0
            _zoom = value
            Dim LargeurImg = ParcelleAffichee.BgImage.Width
            Dim HauteurImg = ParcelleAffichee.BgImage.Height
            Dim ratiol = LargeurImg / (LargeurOrig * _zoom)
            Dim ratioh = HauteurImg / (HauteurOrig * _zoom)
            'Dim ratiol = LargeurImg / LargeurOrig
            'Dim ratioh = HauteurImg / HauteurOrig
            Dim ratio = Math.Max(ratiol, ratioh)
            LargeurImg /= ratio
            HauteurImg /= ratio
            PasToucheDimensionsOriginales = True
            Me.Width = LargeurImg
            Me.Height = HauteurImg
            PasToucheDimensionsOriginales = False
            Me.Invalidate()        ' nécess ?
        End Set
    End Property

    <Category("Behavior)")>
    Public Property ZoomableAvecRoulette As Boolean = True

    Private Sub Me_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
        If My.Computer.Keyboard.CtrlKeyDown AndAlso Not My.Computer.Keyboard.ShiftKeyDown Then
            If ZoomableAvecRoulette Then
                If e.Delta > 0 Then
                    Zoom += 0.1
                Else
                    Zoom -= 0.1
                End If
            End If
            CType(e, HandledMouseEventArgs).Handled = True
        End If
    End Sub
    Public PRATOUKU = False

    <Category("Behavior)")>
    Public Property SelectionEmplAuClic As Boolean = True

    Private Property _emplSelect As DataRow
    Public Property EmplSelect As DataRow
        Get
            Return _emplSelect
        End Get
        Set(value As DataRow)
            If value IsNot _emplSelect Then
                _emplSelect = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Public Property IdEmplSelect As Integer
        Get
            Return If(_emplSelect IsNot Nothing, EmplSelect("empl_id"), -1)
        End Get
        Set(value As Integer)
            ' trouve l'index du ctrl demandé dans la liste
            Dim RowEmplASelect = (From e In ParcelleAffichee.Emplacements Where e("empl_id") = value).FirstOrDefault
            If RowEmplASelect IsNot Nothing Then
                EmplSelect = RowEmplASelect
            Else
                EmplSelect = Nothing
            End If
        End Set
    End Property

    Public Class PlanCimEventArgs
        Inherits EventArgs
        Public Emplacement As DataRow
        Sub New(empl As DataRow)
            Me.Emplacement = empl
        End Sub
    End Class


    Public Event EmplClicked(sender As PlanCimetiere, e As PlanCimEventArgs)

    Sub Me_Clicked(sender As Object, e As MouseEventArgs) Handles Me.Click
        Dim IndexEmplClique As Integer?
        Dim EmplClique As DataRow = EmplacementA(e.Location, IndexEmplClique)

        'Dim EmplInactifClique As Boolean = EmplClique IsNot Nothing AndAlso ParcelleAffichee.Enableds(IndexEmplClique) = False

        If Not (EmplClique IsNot Nothing AndAlso ParcelleAffichee.Enableds(IndexEmplClique) = False) Then     ' à moins qu'on ait cliqué sur un empl non activé (auquel cas on ne fait rien)
            RaiseEvent EmplClicked(Me, New PlanCimEventArgs(EmplClique))
            If Me.SelectionEmplAuClic Then
                If EmplClique IsNot Me.EmplSelect Then
                    Me.EmplSelect = EmplClique
                    RaiseEvent SelectionChanged(Me, New PlanCimEventArgs(EmplClique))
                End If
            End If
        End If



        'If EmplClique IsNot Nothing AndAlso ParcelleAffichee.Enableds(IndexEmplClique) = True Then
        '    RaiseEvent EmplClicked(Me, New PlanCimEventArgs(EmplClique))
        '    If EmplClique IsNot EmplSelect Then
        '        Me.EmplSelect = EmplClique
        '        RaiseEvent SelectionChanged(Me, New PlanCimEventArgs(EmplClique))
        '    End If
        'End If
    End Sub

    Public Event EmplDoubleClicked(sender As PlanCimetiere, e As PlanCimEventArgs)

    Private Sub Me_DoubleClicked(sender As PlanCimetiere, e As MouseEventArgs) Handles Me.DoubleClick
        Dim IndexEmplClique As Integer?
        Dim EmplClique As DataRow = EmplacementA(e.Location, IndexEmplClique)
        If EmplClique IsNot Nothing AndAlso ParcelleAffichee.Enableds(IndexEmplClique) Then
            RaiseEvent EmplDoubleClicked(Me, New PlanCimEventArgs(EmplClique))     ' le SelectionChanged est déjà appelé par l'evt click qui se déclenche aussi
        End If
    End Sub

    Public Event SelectionChanged(sender As Object, e As PlanCimEventArgs)

    ' mettre la font dans le designer ne marche pas, un code extérieur la remet à 5.8 (peut-être qu'il vise MyBase.Font ; essayer de rendre cet prop visible dans le designer pour voir si ça change quelque chose
    ' on peut la changer après ou pendant le Load
    Public Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(value As Font)
            MyBase.Font = value
            CalculerLargeurTexteEmplacement()
        End Set
    End Property

    ' la plupart sont pas utilisées
    Public CouleurBase As Color = Color.FromArgb(100, Color.Purple)
    Public CouleurSelect As Color = Color.FromArgb(180, Color.Red)
    Public CouleurDesact As Color = Color.FromArgb(120, Color.Gray)
    Public CouleurTexteReference As Color = Color.White

    ' fonction décidant quels emplacements sont actifs ou pas (inactif = grisé &  pas sélectionnable)

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>       ' bugs avec le designer, blablabla not serializable
    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    <System.ComponentModel.Localizable(False)>
    Public Property FuncFiltre As Func(Of DataRow, Boolean)

    Private LargeurOrig As Integer
    Private HauteurOrig As Integer


    Private TailleTexteEmplacement As Size    ' utilisé en interne pour centrer le texte sur le polygone de l'emplacement, calculé selon la font
    Private TailleAEteDefinie As Boolean = False     ' interne, indique si la taille originale a déjà été enregistrée, déjà pour ne pas le faire plusieurs fois, ensuite pour ne pas changer le bg si ce n'est pas encore fait


    ' lit les infos des emplacements, les divise en parcelles, sépare leurs données en listes parallèles pour accélérer les opérations en série
    Public Sub SetEmplacements(empls As DataTable)
        If Not DesignMode Then      ' DesignMode ne foncionne sans doute pas avec les contrôles de toute façon
            For Each p In InfosParcelles.Values
                p.IdsEmpls.Clear()
                p.CoordsX.Clear()
                p.CoordsY.Clear()
                p.CoordsXOriginales.Clear()
                p.CoordsYOriginales.Clear()
                p.RefsEmpls.Clear()
                p.Emplacements.Clear()
            Next

            'Dim rapport_l As Single = COORDS_ECHELLE_BASE / Me.Size.Width
            'Dim rapport_h As Single = COORDS_ECHELLE_BASE / Me.Size.Height

            For Each empl As DataRow In empls.Rows
                Dim RefEmpl As String = empl("empl_reference")

                If RefEmpl.Count < 2 Then Continue For      ' ignorera les emplacements dont la parcelle n'est pas reconnue (d'après les deux premiers caractères de la référence)
                Dim NomParcelle = RefEmpl.Substring(0, 2)
                If Not InfosParcelles.ContainsKey(NomParcelle) Then Continue For

                Dim crds = empl("empl_coords")
                If IsDBNull(crds) Then Continue For      ' ignorera aussi les emplacements qui n'ont pas de coordonnées
                Dim CoordsBinaire As Byte() = empl("empl_coords")

                Dim CetteParcelle = InfosParcelles(NomParcelle)


                ' traduit les coordonnées binaires en deux listes d'entiers (coords x et y)
                Dim NbrPtsCetEmpl As Integer = CoordsBinaire.Count \ 4
                Dim i_coords As Integer = 0
                Dim CoordsXCePoint As New List(Of Integer)
                Dim CoordsYCePoint As New List(Of Integer)
                While i_coords < CType(empl("empl_coords"), Byte()).Count
                    Dim tmpx As Integer = CoordsBinaire(i_coords)
                    i_coords += 1
                    tmpx += CoordsBinaire(i_coords) * &H100              ' cast ? memorystream ?
                    i_coords += 1

                    Dim tmpy As Integer = CoordsBinaire(i_coords)
                    i_coords += 1
                    tmpy += CoordsBinaire(i_coords) * &H100
                    i_coords += 1

                    CoordsXCePoint.Add(tmpx)
                    CoordsYCePoint.Add(tmpy)
                End While

                CetteParcelle.CoordsXOriginales.Add(CoordsXCePoint)
                CetteParcelle.CoordsYOriginales.Add(CoordsYCePoint)
                CetteParcelle.CoordsX.Add(New List(Of Integer)(CoordsXCePoint.Count))
                CetteParcelle.CoordsY.Add(New List(Of Integer)(CoordsYCePoint.Count))   ' comme ça, les listes redim existent et on le bon nombre d'items même si il faut encore les mettre à l'échelle

                CetteParcelle.IdsEmpls.Add(empl("empl_id"))
                CetteParcelle.RefsEmpls.Add(RefEmpl)
                CetteParcelle.Enableds.Add(FuncFiltre(empl))
                CetteParcelle.Emplacements.Add(empl)
            Next
            MettreALEchelleCoordsEmplacements()
        End If
        Me.Invalidate()
    End Sub


    Public Sub MettreALEchelleCoordsEmplacements()
        Dim rapport_l As Single = COORDS_ECHELLE_BASE / Me.Size.Width
        Dim rapport_h As Single = COORDS_ECHELLE_BASE / Me.Size.Height

        For Each Parcelle In InfosParcelles.Values
            For NumEmpl = 0 To Parcelle.CoordsXOriginales.Count - 1
                Dim CoordsXOrigEmpl = Parcelle.CoordsXOriginales(NumEmpl)
                Dim CoordsYOrigEmpl = Parcelle.CoordsYOriginales(NumEmpl)
                Dim CoordsXRedim = Parcelle.CoordsX(NumEmpl)
                Dim CoordsYRedim = Parcelle.CoordsY(NumEmpl)
                CoordsXRedim.Clear()
                CoordsYRedim.Clear()
                For NumCoord = 0 To CoordsXOrigEmpl.Count - 1
                    CoordsXRedim.Add(CoordsXOrigEmpl(NumCoord) / rapport_l)
                    CoordsYRedim.Add(CoordsYOrigEmpl(NumCoord) / rapport_h)
                Next
            Next
        Next
        Me.Invalidate()
    End Sub



    Private Sub ChangerImage(NouvelleImage As Image)
        If TailleAEteDefinie AndAlso NouvelleImage IsNot MyBase.BackgroundImage Then
            If NouvelleImage IsNot Nothing Then
                ' ajuste les dimensions du contrôle pour respecter le ratio de la nouvelle image
                Dim nvl = NouvelleImage.Width
                Dim nvh = NouvelleImage.Height
                Dim ratiol = nvl / LargeurOrig
                Dim ratioh = nvh / HauteurOrig
                'If ratiol > ratioh Then ratioh = ratiol Else ratiol = ratioh
                'Dim ratio = If(ratiol > ratioh, ratiol, ratioh)
                Dim ratio = Math.Max(ratiol, ratioh)
                nvl = nvl / ratio 'l
                nvh = nvh / ratio 'h
                PasToucheDimensionsOriginales = True
                Me.Height = nvh
                Me.Width = nvl
                PasToucheDimensionsOriginales = False
            End If
            Me.BackgroundImage = NouvelleImage
        End If
    End Sub


    Private ttip As New TooltipL With {.AutoPopDelay = 1000000, .InitialDelay = 0, .ReshowDelay = 500, .ShowAlways = True}



    Sub Me_Load() Handles Me.Load
        ''Me.BackgroundImage = ParcelleAffichee.BgImage
        ChangerImage(ParcelleAffichee.BgImage)

        CalculerLargeurTexteEmplacement()
        If Not DesignMode Then
            If Me.FuncFiltre Is Nothing Then Me.FuncFiltre = AddressOf FiltreDefaut      ' pour une raison que j'ignore, le designer l'initialise à nothing, donc l'initialiser dans la déclaration de la propriété ou dans le new ne fonctionne pas. De plus, il est possible que mettre une fonction anonyme ici provoque des bugs avec le designer
        End If
    End Sub
    Private Function FiltreDefaut(empl As DataRow) As Boolean
        Return True
    End Function


    Private Sub CalculerLargeurTexteEmplacement()
        TailleTexteEmplacement = TextRenderer.MeasureText("A3000", Me.Font)
    End Sub



    Private PasToucheDimensionsOriginales As Boolean = False
    ' il faudrait un évènement qui arrive une fois que les dimensions sont définies et qui ne se déclenchera plus après, ce qui n'est pas si évident ;
    ' ne conviennent pas : Load, New (dimensions zéro), ParentChanged (se fait avant redimensionnement par Windows), Layout, SizeChanged (se déclenchent plusieurs fois au chargement et avec des tailles différentes)
    ' LocationChanged serait correct sauf qu'il ne se déclenche pas quand le contrôle est à la position 0;0 (ce qui pourrait arriver souvent, si il est dans un panel pour le zoom/scroll)
    ' et qu'accessoirement, un changement de Location va redéfinir les dimensions "originales" d'après celles réduites pour afficher l'image
    ' au final, on  gèrera resize, en mettant un flag pour empêcher les dimensions originales d'être redéfinie quand on modifie nous-même en fonction du zoom ou du changement d'image
    Private Sub NoterDimensionsOriginales() Handles Me.Resize
        'If Not TailleAEteDefinie Then
        If Not PasToucheDimensionsOriginales Then
            Me.LargeurOrig = Me.Width
            Me.HauteurOrig = Me.Height
            TailleAEteDefinie = True
        End If
    End Sub


    ' IndexEmpl permet de renvoyer l'index de l'empl dans l'InfosParcelle actif
    Private Function EmplacementA(p As Point, Optional ByRef IndexEmpl As Integer? = Nothing) As DataRow
        Dim lempl As DataRow = Nothing
        With ParcelleAffichee
            For i = 0 To .CoordsX.Count - 1
                Dim NbCoordsCetEmpl As Integer = .CoordsX(i).Count
                Dim poly(NbCoordsCetEmpl) As PointF
                For j = 0 To NbCoordsCetEmpl - 1
                    poly(j) = New Point(.CoordsX(i)(j), .CoordsY(i)(j))
                Next
                Dim path = New System.Drawing.Drawing2D.GraphicsPath
                path.AddPolygon(poly)
                If path.IsVisible(p) Then
                    lempl = .Emplacements(i)
                    IndexEmpl = i
                    Exit For
                End If
            Next
        End With
        Return lempl
    End Function


    Protected Overrides Sub OnPaint(pe As PaintEventArgs)
        MyBase.OnPaint(pe)
        Dim InfosParcelle = InfosParcelles(NomParcelleAffichee)

        Using brosse As New System.Drawing.SolidBrush(Me.CouleurBase),
              brosseselect As New System.Drawing.SolidBrush(Me.CouleurSelect),
              brossedisabled = New System.Drawing.SolidBrush(Me.CouleurDesact),
              Stylo As New SolidBrush(CouleurTexteReference)

            Dim graph = pe.Graphics
            For i = 0 To InfosParcelle.CoordsX.Count - 1
                With InfosParcelle
                    Dim CoordsXCetEmpl = .CoordsX(i)
                    Dim CoordsYCetEmpl = .CoordsY(i)
                    Dim poly(CoordsXCetEmpl.Count - 1) As Point
                    For j = 0 To CoordsXCetEmpl.Count - 1
                        poly(j) = New Point(CoordsXCetEmpl(j), CoordsYCetEmpl(j))
                    Next
                    If Not .Enableds(i) Then
                        graph.FillPolygon(brossedisabled, poly)
                    ElseIf .Emplacements(i) Is _emplSelect Then
                        graph.FillPolygon(brosseselect, poly)
                    Else
                        graph.FillPolygon(brosse, poly)
                    End If
                    ' écrit la référence
                    Dim MilieuZoneEmpl = Milieu(poly)
                    Dim CoinHGTxt = New Point(MilieuZoneEmpl.X - TailleTexteEmplacement.Width / 2, MilieuZoneEmpl.Y - TailleTexteEmplacement.Height / 2)
                    graph.DrawString(.Emplacements(i)("empl_reference"), Me.Font, Stylo, CoinHGTxt)
                End With
            Next
            'End Using
        End Using
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
            If p.Y > maxY Then maxY = p.Y
        Next
        Return New Point((maxX + minX) \ 2, (maxY + minY) \ 2)
    End Function




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
            Dim newe = New DrawToolTipEventArgs(e.Graphics, e.AssociatedWindow, e.AssociatedControl, e.Bounds, e.ToolTipText, Me.BackColor, Me.ForeColor,
                                            myfont)
            newe.DrawBackground()
            newe.DrawBorder()
            newe.DrawText(TextFormatFlags.LeftAndRightPadding)
        End Sub

    End Class

    Private Sub PlanCimetiere_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Me.MettreALEchelleCoordsEmplacements()
        Me.Invalidate()
    End Sub
End Class
