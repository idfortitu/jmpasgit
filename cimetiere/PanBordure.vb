Imports System.ComponentModel

Public Class PanBordure
    Inherits Panel

    ' devrait utiliser le padding pour marquer la zone intérieure, mais trop tard maintenant qu'il y en a dans tous les forms

    Private _texte As String
    <Category("Appearance")>
    Public Property Texte As String
        Get
            Return _texte
        End Get
        Set(value As String)
            _texte = value
            LeLabel.Text = value
        End Set
    End Property

    Private _couleurBordure As Color = Color.SeaGreen
    <Category("Appearance")>
    Public Property CouleurBordure As Color
        Get
            Return _couleurBordure
        End Get
        Set(value As Color)
            _couleurBordure = value
            Me.Invalidate()
        End Set
    End Property

    <Category("Appearance")>
    Public Property EpaisseurBordure As Integer = 7

    Public Sub New()
        InitializeComponent()
        'LeLabel.Location = New Point(Me.ClientRectangle.X + 8 + 2 + 5, 0 - 1)

        LeLabel.Location = New Point(EpaisseurBordure + 20, EpaisseurBordure + 6)
    End Sub

    Private Const EcartBordureCadre = 5
    Private Const PosXLabel = 15

    Private Sub Me_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

        Dim g As Graphics = e.Graphics
        Dim theRec = ClientRectangle

        ' dessine la bordure
        Dim BrushBordure As New SolidBrush(Me._couleurBordure)

        ' droite, haut, bas, gauche
        Dim RectsBordure As Rectangle() = {
            New Rectangle(theRec.X, theRec.Y, EpaisseurBordure, theRec.Height),
            New Rectangle(theRec.X + EpaisseurBordure, theRec.Y, theRec.Right, EpaisseurBordure),
            New Rectangle(theRec.X + EpaisseurBordure, theRec.Bottom - EpaisseurBordure, theRec.Width - EpaisseurBordure, EpaisseurBordure),
            New Rectangle(theRec.Right - EpaisseurBordure, theRec.Y + EpaisseurBordure, EpaisseurBordure, theRec.Height - EpaisseurBordure * 2)
        }

        g.FillRectangles(BrushBordure, RectsBordure)


        ' dessine le cadre

        Dim theEdgeGrayColor As Color = Color.FromKnownColor(KnownColor.Gray)
        Dim thePen As Pen = New Pen(theEdgeGrayColor)

        Dim TextSize = LeLabel.Width
        If TextSize < 1 Then
            TextSize = 1
        End If

        Dim XGaucheBordure = theRec.X + EpaisseurBordure + EcartBordureCadre
        'Dim YHautBordure = theRec.Y + EpaisseurBordure + EcartBordureCadre + (LeLabel.Height \ 2)
        Dim YHautBordure = LeLabel.Location.Y + If(LeLabel.Text <> "", LeLabel.Height \ 2 + 1, 0)
        Dim XDroiteBordure = theRec.Right - EpaisseurBordure - EcartBordureCadre
        Dim YBasBordure = theRec.Bottom - EpaisseurBordure - EcartBordureCadre
        Dim HauteurBordure = theRec.Height - YHautBordure - EpaisseurBordure - EcartBordureCadre
        'Dim LargeurBordure = theRec.Width - EpaisseurBordure * 2 - EcartBordureCadre * 2
        Dim LargeurBordure = theRec.Width - XGaucheBordure - EpaisseurBordure - EcartBordureCadre


        'Dim theEndPosition As Integer = LeLabel.Location.X + TextSize + 1


        g.DrawRectangle(thePen, XGaucheBordure, YHautBordure, LargeurBordure, HauteurBordure)

        '' haut
        ''g.DrawLine(thePen, XGaucheBordure, YHautBordure, LeLabel.Location.X + 100, YHautBordure)
        '' suite de la ligne à droite


        'g.DrawLine(thePen, theRec.X, theRec.Y + 5, theRec.X, theRec.Bottom - 2)
        'g.DrawLine(thePen, theRec.X, theRec.Bottom - 2, theRec.Right - 1, theRec.Bottom - 2)
        'g.DrawLine(thePen, theRec.Right - 2, theRec.Bottom - 2, theRec.Right - 2, theRec.Y + 5)

        'g.DrawLine(thePen, theRec.Right - 2, theRec.Y + 5, theRec.X + theEndPosition, theRec.Y + 5)
        ''g.DrawLine(thePen, theRec.Right - 2, theRec.Y + 5, theRec.X, theRec.Y + 5)


        'g.DrawLine(Pens.White, theRec.X + 8, theRec.Y + 6, theRec.X + 1, theRec.Y + 6)
        'g.DrawLine(Pens.White, theRec.X + 1, theRec.Y + 6, theRec.X + 1, theRec.Bottom - 3)
        'g.DrawLine(Pens.White, theRec.X, theRec.Bottom - 1, theRec.Right, theRec.Bottom - 1)
        'g.DrawLine(Pens.White, theRec.Right - 1, theRec.Bottom - 1, theRec.Right - 1, theRec.Y + 5)
        'g.DrawLine(Pens.White, theRec.Right - 3, theRec.Y + 6, theRec.X + theEndPosition, theRec.Y + 6)

        'Dim sf As StringFormat = New StringFormat()
        'Dim drawBrush As SolidBrush = New SolidBrush(Color.Black)

        'g.DrawString(Text, Font, drawBrush, theCaptionPosition, 0)
    End Sub



    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LeLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LeLabel
        '
        Me.LeLabel.AutoSize = True
        'Me.LeLabel.Location = New System.Drawing.Point(134, 125)
        Me.LeLabel.Location = New System.Drawing.Point(15, -1)
        Me.LeLabel.Name = "LeLabel"
        'Me.LeLabel.Size = New System.Drawing.Size(51, 17)
        Me.LeLabel.TabIndex = 0
        Me.LeLabel.Text = ""
        '
        'PanelCollapse
        '
        Me.Controls.Add(Me.LeLabel)
        'Me.Name = "PanBordure"
        'Me.Size = New System.Drawing.Size(504, 334)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        'Me.

    End Sub

    Friend WithEvents LeLabel As Label



End Class
