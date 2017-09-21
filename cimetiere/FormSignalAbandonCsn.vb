Imports System.IO

Public Class FormSignalAbandonCsn

    Private FormChoix As FormChoixEmplSurPlan

    Private Property _lesEmplacements As DataTable       
    Private ReadOnly Property LesEmplacements As DataTable
        Get
            If _lesEmplacements Is Nothing Then
                Me._lesEmplacements = Bdd.GetTable("emplacements")
            End If
            Return _lesEmplacements
        End Get
    End Property



    Private Sub BtMontrerFormPlancim_Click(sender As Object, e As EventArgs) Handles BtMontrerFormPlancim.Click
        If FormChoix Is Nothing OrElse FormChoix.IsDisposed Then
            FormChoix = New FormChoixEmplSurPlan(Me.LesEmplacements) With {.Owner = Me}         '', .Size = New Size(500, 1000)} ' n'a pas l'air de marcher
            FormChoix.Size = New Size(1000, 500)
            AddHandler FormChoix.SelectionChanged, AddressOf FormChoix_SelectionChanged
            'Dim EmplTb = Bdd.GetRow("emplacements", "empl_reference", TbRefEmpl.Text.Trim)
        End If
        If TbRefEmpl.Text.Trim <> "" Then
                Dim EmplTb = Me.LesEmplacements.Select("empl_reference = '" & TbRefEmpl.Text.Trim & "'")
                If EmplTb.Count > 0 Then
                    FormChoix.EmplSelect = EmplTb(0)
                End If
            End If
            FormChoix.Show()
        'End If
    End Sub


    Private Sub FormChoix_SelectionChanged(Empl As DataRow)
        If FormChoix.EmplSelect IsNot Nothing Then
            TbRefEmpl.Text = FormChoix.EmplSelect("empl_reference")
        End If
    End Sub



    Private Sub BtParcourir_Click(sender As Object, e As EventArgs) Handles BtParcourir.Click
        Dim Nomfic As String = ""
        Using OpenDlg As New OpenFileDialog
            With OpenDlg
                .Filter = "Fichiers image|*.bmp;*.jpg;*.jpeg;*.png;*.gif"
                .CheckFileExists = True
                .Multiselect = False
                .AddExtension = False
                .AutoUpgradeEnabled = True
                .CheckPathExists = True
                '.Title =       ' à voir
                .ValidateNames = True
            End With
            If (OpenDlg.ShowDialog = DialogResult.OK) Then
                TbCheminFicImg.Text = OpenDlg.FileName
            End If
        End Using
    End Sub



    Private Sub BtTerminer_Click(sender As Object, e As EventArgs) Handles BtTerminer.Click
        Dim IdEmpl As Integer? = Nothing

        ' vérification référence
        Dim RefOk As Boolean = True
        Dim TexteRef = TbRefEmpl.Text.Trim
        If TexteRef <> "" Then
            If LesEmplacements IsNot Nothing Then
                Dim EmplDeRef = Me.LesEmplacements.Select("empl_reference = '" & TbRefEmpl.Text.Trim & "'")
                If EmplDeRef.Count = 0 Then
                    RefOk = False
                Else
                    IdEmpl = EmplDeRef(0)("empl_id")
                End If
            Else
                Dim EmplDeRef = Bdd.GetRow("emplacements", "empl_reference", TexteRef)
                If EmplDeRef Is Nothing Then
                    RefOk = False
                Else
                    IdEmpl = EmplDeRef("empl_id")
                End If
            End If
        End If

        ErProv.SetError(TbRefEmpl, If(RefOk, "", "Aucun emplacement ayant cette référence n'a été trouvé"))

        ' il faut référence existante, ou photo, ou commentaire non vide
        Dim ContenuOk As Boolean = TbCommentaire.Text.Trim <> "" OrElse TbRefEmpl.Text.Trim <> "" OrElse TbCheminFicImg.Text <> ""
        ErProv.SetError(TbCommentaire, If(ContenuOk, "", "Veuillez indiquer au moins un renseignement !"))



        If RefOk AndAlso ContenuOk Then
            Bdd.InsertSignalCsnAband(IdEmpl, TbCommentaire.Text.Trim, If(TbCheminFicImg.Text = "", Nothing, Image.FromFile(TbCheminFicImg.Text)))
            Me.DialogResult = DialogResult.OK
        End If


    End Sub


    Sub Me_Closing() Handles Me.Closing
        If Me.FormChoix IsNot Nothing Then
            If Not Me.FormChoix.IsDisposed Then
                Me.FormChoix.Close()
                Me.FormChoix.Dispose()
            End If
        End If
    End Sub

    Private Sub FormSignalAbandonCsn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class