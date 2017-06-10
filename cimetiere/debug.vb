Imports System.Data.Entity

Public Class debug
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kroutonu As New FormEditEmplacement(41)
        kroutonu.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim raoijer As New FormEditDefunt(3)
        raoijer.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Using ctx As New CimEntities
            Dim listeemplsàremplacerparunedatatable = (From em In ctx.Emplacements Take 350 Select New PlanCimetiere.emplacementtresclasse With {.Id = em.Id, .reference = em.Reference, .Coords = em.Coordonnees, .estloué = True, .nboccupants = 5, .nbplaces = 5}).ToList
            PlanCimetiere1.ChangerImage("09pfuz.jpg", listeemplsàremplacerparunedatatable)
        End Using
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Using ctx As New CimEntities
            PlanCimetiere1.ChangerImage("107.jpg", True)
            'Dim cul = From em In ctx.Emplacements Skip 350 Take 350
        End Using
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PlanCimetiere1.ChangerImage(CType(Nothing, Image), True)
    End Sub


    Private Sub planemplclic(sender As PlanCimetiere, e As PlanCimetiere.PlanCimEventArgs) Handles PlanCimetiere1.EmplClicked
        MessageBox.Show("clic, sél = " & e.Emplacement.Id)
    End Sub

    Private Sub planempldbclic(sender As PlanCimetiere, e As PlanCimetiere.PlanCimEventArgs) Handles PlanCimetiere1.EmplDoubleClicked
        MessageBox.Show("dbl clic, sél = " & e.Emplacement.Id)
    End Sub

    Private Sub planemplselchg(sender As PlanCimetiere, e As PlanCimetiere.PlanCimEventArgs) Handles PlanCimetiere1.SelectionChanged
        MessageBox.Show("sel chg, sél = " & If(e.Emplacement IsNot Nothing, e.Emplacement.Id & " " & e.Emplacement.reference, "rien"))
    End Sub

    Private Sub nvcon_Click(sender As Object, e As EventArgs) Handles nvcon.Click
        Dim aer As New FormReservation
        aer.ShowDialog()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim f As New FormGestion
        f.ShowDialog()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim a As New FormProlong
        a.ShowDialog()
    End Sub


End Class
