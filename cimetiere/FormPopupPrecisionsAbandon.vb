Public Class FormPopupPrecisionsAbandon

    Private IdSignal As Integer
    Private LaNotif As DataRow

    ' indique si l'utilisateur a supprimé la notif, pour que le form home actualise la liste
    Public Suppression As Boolean = False

    Public Sub New(IdSignal As Integer)
        InitializeComponent()
        Me.IdSignal = IdSignal
    End Sub


    Sub Me_Load() Handles Me.Load
        Me.LaNotif = Bdd.Query("SELECT notif_id,emplacements.empl_id,empl_reference,notif_commentaire,notif_photo FROM notifications LEFT OUTER JOIN emplacements ON emplacements.empl_id = notif_emplacement WHERE notif_id = " & Me.IdSignal)(0)
        TbCom.Text = Me.LaNotif("notif_commentaire")
        TbRefEmpl.Text = If(IsDBNull(Me.LaNotif("empl_reference")), "", Me.LaNotif("empl_reference"))
        If Not IsDBNull(Me.LaNotif("notif_photo")) Then
            Dim Img As Image = Nothing
            Dim Bytes = CType(Me.LaNotif("notif_photo"), Byte())
            Using Stream As New IO.MemoryStream(Bytes)
                If Bytes.GetUpperBound(0) > 0 Then
                    Img = Image.FromStream(Stream)
                Else
                    Img = Nothing
                End If
            End Using
            PictureBox1.Image = Img
            LabPasDimage.Hide()
        Else
            PictureBox1.Hide()
        End If
        If Not IsDBNull(Me.LaNotif("empl_id")) Then BtDetails.Enabled = True
    End Sub

    Private Sub BtDetails_Click(sender As Object, e As EventArgs) Handles BtDetails.Click
        Using f As New FormVoirDetailsEmpl(Me.LaNotif("empl_id"))
            f.ShowDialog()
        End Using
    End Sub

    Private Sub BtSupprimer_Click(sender As Object, e As EventArgs) Handles BtSupprimer.Click
        If DialogResult.Yes = MessageBox.Show("Supprimer la notification ?", "Confirmer la suppression", MessageBoxButtons.YesNo) Then
            Bdd.Supprimer("notifications", LaNotif("notif_id"))
            Me.Suppression = True
            Me.Close()
        End If

    End Sub
End Class