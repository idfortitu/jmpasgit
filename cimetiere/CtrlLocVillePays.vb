Public Class CtrlLocVillePays


    ' <> -1 si la ville est choisie (auquel cas l'enregistrement LocVille existe)
    ' -1 si aucune ville n'est choisie, auquel cas le locville existe peut-être en tant que ville vide + pays sélectionné, ou pas et dans ce cas il faut le créer
    Public Property LocVilleId As Object 'Integer
        Get
            Return If(CbLocVille.SelectedValue Is Nothing, -1, CbLocVille.SelectedValue)
        End Get
        Set(value As Object) 'Integer)
            If value Is Nothing OrElse isdbnull(value) OrElse value = -1 Then
                CbLocVille.SelectedIndex = -1
            Else
                CbLocVille.SelectedValue = value
            End If
        End Set
    End Property

    Private _osef
    Property osef
        Get
            Return _osef
        End Get
        Set(value)
            _osef = value
        End Set
    End Property

    Public ReadOnly Property PaysId As Integer
        Get
            Return If(CbPays.SelectedValue Is Nothing, -1, CbPays.SelectedValue)
        End Get
    End Property

    Private TbV As TextBox = New TextBox With {.ReadOnly = True, .Visible = False, .BackColor = SystemColors.Window}
    Private TbP As TextBox = New TextBox With {.ReadOnly = True, .Visible = False, .BackColor = SystemColors.Window}

    Private _lectureSeule As Boolean = False
    Public Property LectureSeule As Boolean
        Get
            Return _lectureSeule
        End Get
        Set(value As Boolean)
            _lectureSeule = value
            BtAjouterPays.Enabled = Not value
            BtAjouterVille.Enabled = Not value

            If value = True Then
                TbV.Text = CbLocVille.Text
                TbP.Text = CbPays.Text
                CbLocVille.Hide()
                CbPays.Hide()
                TbV.Show()
                TbP.Show()
            Else
                TbV.Hide()
                TbP.Hide()
                CbLocVille.Show()
                CbPays.Show()
            End If
        End Set
    End Property
    Private Sub bla() Handles Me.Layout
        Me.TbV.size = CbLocVille.Size
        Me.TbV.location = CbLocVille.Location
        Me.TbP.size = CbPays.Size
        Me.TbP.Location = CbPays.Location
    End Sub


    Public Sub New()
        InitializeComponent()       ' This call is required by the designer.
        If Not System.Diagnostics.Process.GetCurrentProcess().ProcessName = "devenv" Then
            'ChargerComboboxLocVille()
            'ChargerComboboxPays()
        End If
        Me.Controls.Add(TbV)
        Me.Controls.Add(TbP)
        TbV.BringToFront()
        TbP.BringToFront()
    End Sub


    Private Sub BtAjouterPays_Click(sender As Object, e As EventArgs) Handles BtAjouterPays.Click
        Dim f As New FormNouveauPays
        If f.ShowDialog = DialogResult.OK Then
            ChargerComboboxPays()
            CbLocVille.SelectedIndex = 0  ' ville vide
            CbPays.SelectedValue = f.PaysFait("Pays_id")
        End If
    End Sub

    Private Sub BtAjouterVille_Click(sender As Object, e As EventArgs) Handles BtAjouterVille.Click
        ' en cas d'ajout de ville, il faut aussi recharger la liste des pays, vu que la dlgbox d'ajout de ville permet de créer des pays
        Dim f As New FormNouvelleVille(CbPays.SelectedValue)
        If f.ShowDialog = DialogResult.OK Then
            ChargerComboboxLocVille()
            ChargerComboboxPays()
            CbLocVille.SelectedValue = f.VilleFaite("locville_id")
            CbLocVille_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub

    ' si on change de ville, le pays doit être changé pour correspondre, et il ne peut être changé par l'utilisateur que si aucune ville n'est sélectionnée
    Private Sub CbLocVille_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbLocVille.SelectedIndexChanged
        If CbLocVille.SelectedItem IsNot Nothing AndAlso Not IsDBNull(CbLocVille.SelectedItem("Pays_id")) Then
            CbPays.SelectedValue = CbLocVille.SelectedItem("Pays_id")
            CbPays.Enabled = False
        Else
            CbPays.SelectedIndex = -1
            CbPays.Enabled = True
        End If
        If Me._lectureSeule Then
            TbV.Text = CbLocVille.Text
            TbP.Text = CbPays.Text
        End If
    End Sub



    Private Sub ChargerComboboxLocVille()
        Dim DtLocVilles = Bdd.Query("SELECT * from t_loc_ville WHERE locville_ville <> """"")
        Dim rowvide = DtLocVilles.NewRow
        rowvide("locville_id") = -1
        DtLocVilles.Rows.InsertAt(rowvide, 0)

        CbLocVille.DisplayMember = "locville_ville"
        CbLocVille.ValueMember = "locville_id"
        CbLocVille.DataSource = DtLocVilles
    End Sub

    Private Sub ChargerComboboxPays()
        Dim DtPays = Bdd.GetTable("t_pays")
        Dim rowvide = DtPays.NewRow
        rowvide("Pays_id") = -1
        DtPays.Rows.InsertAt(rowvide, 0)

        CbPays.DisplayMember = "Pays_nom"
        CbPays.ValueMember = "Pays_id"
        CbPays.DataSource = DtPays
    End Sub

    ''' <summary>
    ''' attention : crée une copie de la liste fournie (et de ses éléments), n'utilise pas les datarows originales
    ''' </summary>
    ''' <param name="tpays"></param>
    Public Sub ChargerComboboxPays(tpays As DataTable)
        Dim nvtpays = tpays.Copy
        If Not (From r As DataRow In nvtpays.Rows Where r("Pays_id") = -1).Any Then
            Dim rowvide = nvtpays.NewRow
            rowvide("Pays_id") = -1
            nvtpays.Rows.InsertAt(rowvide, 0)
        End If

        CbPays.DisplayMember = "Pays_nom"
        CbPays.ValueMember = "Pays_id"
        CbPays.DataSource = nvtpays

    End Sub
    Public Sub chargercomboboxville(tville As DataTable)
        Dim nvtville = tville.Copy
        'RowCsn.ItemArray = f.RowCsn.ItemArray.Clone
        'If tville.Rows.Find(-1) Is Nothing Then
        If Not (From r As DataRow In nvtville Where r("locville_id") = -1).Any Then
            Dim rowvide = nvtville.NewRow
            rowvide("locville_id") = -1
            nvtville.Rows.InsertAt(rowvide, 0)
        End If

        CbLocVille.DisplayMember = "locville_ville"
        CbLocVille.ValueMember = "locville_id"
        CbLocVille.DataSource = nvtville

    End Sub

    Public Sub Rafraichir(Optional ClearSelect As Boolean = False)
        If CbLocVille.DataSource IsNot Nothing Then CType(CbLocVille.DataSource, IDisposable).Dispose()
        If CbPays.DataSource IsNot Nothing Then CType(CbLocVille.DataSource, IDisposable).Dispose()
        Dim LocvilSelect = CbLocVille.SelectedValue
        Dim PaysSelect = CbPays.SelectedValue
        ChargerComboboxLocVille()
        ChargerComboboxPays()
        If Not ClearSelect Then
            CbLocVille.SelectedValue = LocvilSelect
            CbPays.SelectedValue = PaysSelect
        End If
    End Sub

End Class
