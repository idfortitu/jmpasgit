Imports System.ComponentModel

Public Class PanBordure
    Inherits Panel

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

    <Category("Appearance")>
    Public Property CouleurBordure As Color = Color.SeaGreen

    <Category("Appearance")>
    Public Property EpaisseurBordure As Integer = 7

    Public Sub New()
        InitializeComponent()
        LeLabel.Location = New Point(EpaisseurBordure + 20, EpaisseurBordure + 3)
    End Sub


    Private Const EcartBordureCadre = 3
    Private Const PosXLabel = 15

    Private Sub Me_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

        Dim g As Graphics = e.Graphics
        Dim theRec = ClientRectangle

        ' dessine la bordure
        Dim BrushBordure As New SolidBrush(Me.CouleurBordure)

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
        Dim YHautBordure = LeLabel.Location.Y + LeLabel.Height \ 2
        Dim XDroiteBordure = theRec.Right - EpaisseurBordure - EcartBordureCadre
        Dim YBasBordure = theRec.Bottom - EpaisseurBordure - EcartBordureCadre
        Dim HauteurBordure = theRec.Height - YHautBordure - EpaisseurBordure - EcartBordureCadre
        Dim LargeurBordure = theRec.Width - XGaucheBordure - EpaisseurBordure - EcartBordureCadre


        g.DrawRectangle(thePen, XGaucheBordure, YHautBordure, LargeurBordure, HauteurBordure)

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
        Me.LeLabel.Location = New System.Drawing.Point(15, -1)
        Me.LeLabel.Name = "LeLabel"
        Me.LeLabel.TabIndex = 0
        Me.LeLabel.Text = "Label1"
        '
        'PanBordure
        '
        Me.BackColor = Color.White
        Me.Controls.Add(Me.LeLabel)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LeLabel As Label





    '<System.Diagnostics.DebuggerStepThrough()>
    'Private Sub InitializeComponent()
    '    Me.LeLabel = New System.Windows.Forms.Label()
    '    Me.SuspendLayout()
    '    '
    '    'LeLabel
    '    '
    '    Me.LeLabel.AutoSize = True
    '    Me.LeLabel.Location = New System.Drawing.Point(15, -1)
    '    Me.LeLabel.Name = "LeLabel"
    '    Me.LeLabel.TabIndex = 0
    '    Me.LeLabel.Text = "Label1"
    '    '
    '    'PanBordure
    '    '
    '    Me.Controls.Add(Me.LeLabel)
    '    Me.ResumeLayout(False)
    '    Me.PerformLayout()

    'End Sub

    'Friend WithEvents LeLabel As Label


End Class
