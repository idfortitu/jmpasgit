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


    End Class

    ' - chargement : datatable emplacements
    ' - si coords absentes, ne pas montrer, peut-être griser dans la dgv associée ??
    ' - images des parcelles prédéfinies, peut-être propriétés publique (mais valeur par défaut)
    ' - fonctions publiques pour changer de parcelle (ce qui entraîne changement d'image et repositionnement des emplacements)
    ' - évènements publics pour sélectionchangée, clic & double clic sur emplacement
    ' - fonction publique pour recharger les données (pas les coords qui ne devraient pas changer), à défaut de faire un contrôle databound


    Const COORDS_ECHELLE_BASE = 2000       ' les coordonnées des emplacements sont interprétées comme si l'image faisait 2000x2000, puis sont mises à l'échelle de la taille du contrôle

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
            Me.Invalidate()
        End Set
    End Property

    Private ParcelleAffichee As InfosParcelle = InfosParcelles(_nomParcelleAffichee)

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
        Dim EmplClique As DataRow = EmplacementA(e.Location)
        If EmplClique IsNot Nothing Then RaiseEvent EmplClicked(Me, New PlanCimEventArgs(EmplClique))
        If EmplClique IsNot EmplSelect Then
            Me.EmplSelect = EmplClique
            RaiseEvent SelectionChanged(Me, New PlanCimEventArgs(EmplClique))
        End If
    End Sub

    Public Event EmplDoubleClicked(sender As PlanCimetiere, e As PlanCimEventArgs)

    Private Sub Me_DoubleClicked(sender As PlanCimetiere, e As MouseEventArgs) Handles Me.DoubleClick
        Dim EmplClique As DataRow = EmplacementA(e.Location)
        If EmplClique IsNot Nothing Then RaiseEvent EmplDoubleClicked(Me, New PlanCimEventArgs(EmplClique))     ' le SelectionChanged est déjà appelé par l'evt click qui se déclenche aussi
    End Sub

    Public Event SelectionChanged(sender As Object, e As PlanCimEventArgs)

    ' mettre la font dans le designer ne marche pas, un code extérieur la remet à 5.8
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

    Public CouleurVide As Color = Color.FromArgb(60, Color.White)
    Public CouleurPartiellementPlein As Color = Color.FromArgb(100, Color.MediumPurple)
    Public CouleurPlein As Color = Color.FromArgb(100, Color.Purple)
    Public CouleurBordureLoué As Color = Color.FromArgb(255, Color.Yellow)
    Public CouleurBordurePasLoué As Color = Color.Transparent
    Public CouleurTexteReference As Color = Color.White

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
                p.RefsEmpls.Clear()
                p.Emplacements.Clear()
            Next

            Dim rapport_l As Single = COORDS_ECHELLE_BASE / Me.Size.Width
            Dim rapport_h As Single = COORDS_ECHELLE_BASE / Me.Size.Height

            For Each empl As DataRow In empls.Rows
                Dim RefEmpl As String = empl("empl_reference")
                'If empl("empl_reference") = "A200" Then
                'End If

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
                    tmpx /= rapport_l

                    Dim tmpy As Integer = CoordsBinaire(i_coords)
                    i_coords += 1
                    tmpy += CoordsBinaire(i_coords) * &H100
                    i_coords += 1
                    tmpy /= rapport_h

                    CoordsXCePoint.Add(tmpx)
                    CoordsYCePoint.Add(tmpy)
                End While

                CetteParcelle.CoordsX.Add(CoordsXCePoint)
                CetteParcelle.CoordsY.Add(CoordsYCePoint)

                CetteParcelle.IdsEmpls.Add(empl("empl_id"))
                CetteParcelle.RefsEmpls.Add(RefEmpl)
                CetteParcelle.Emplacements.Add(empl)
            Next
        End If
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
                Me.Height = nvh
                Me.Width = nvl
            End If
            Me.BackgroundImage = NouvelleImage
        End If
    End Sub


    Private ttip As New TooltipL With {.AutoPopDelay = 1000000, .InitialDelay = 0, .ReshowDelay = 500, .ShowAlways = True}



    Sub Me_Load() Handles Me.Load
        Me.BackgroundImage = ParcelleAffichee.BgImage
        CalculerLargeurTexteEmplacement()
    End Sub


    Private Sub CalculerLargeurTexteEmplacement()
        TailleTexteEmplacement = TextRenderer.MeasureText("A3000", Me.Font)
    End Sub



    ' il faut un évènement qui arrive une fois que les dimensions sont définies et qui ne se déclenchera plus après, ce qui n'est pas si évident ;
    ' ne conviennent pas : Load, New (dimensions zéro), ParentChanged (se fait avant redimensionnement de Windows), Layout, SizeChanged (se redéclenchent quand le plan change sa taille pour garder les proportions de l'image)
    ' même comme ça, il reste qu'un changement de Location va redéfinir les dimensions "originales" sur celles réduites pour afficher l'image ; tant pis
    Private Sub NoterDimensionsOriginales() Handles Me.LocationChanged
        Me.LargeurOrig = Me.Width
        Me.HauteurOrig = Me.Height
        TailleAEteDefinie = True
    End Sub


    Private Function EmplacementA(p As Point) As DataRow
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
                    Exit For
                End If
            Next
        End With
        Return lempl
    End Function





    Protected Overrides Sub OnPaint(pe As PaintEventArgs)
        MyBase.OnPaint(pe)
        Dim InfosParcelle = InfosParcelles(NomParcelleAffichee)

        Using brosse As New System.Drawing.SolidBrush(Color.FromArgb(100, Color.Purple)),
              brosseselect As New System.Drawing.SolidBrush(Color.FromArgb(180, Color.Purple)),
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
                    If .Emplacements(i) Is _emplSelect Then
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



    '''''  test
    ' à faire éventuellement : mettre à jour la position et forme des contrôles emplacements au resize


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



End Class
