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

    Private Sub planemplselchg(sender As Object, e As PlanCimetiere.PlanCimEventArgs) Handles PlanCimetiere1.SelectionChanged

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim pdf As New ExporteurPdf
        pdf.CreePdfReservation(Bdd.GetRow("concessionnaires", "csnr_id", 27), Bdd.GetRow("t_loc_ville", "locville_id", "4"), Bdd.GetRow("t_pays", "Pays_id", 5), TTypeCsnInh.UrneColomb30Ans, Bdd.Query("SELECT * FROM beneficiaires WHERE ben_id > 15 LIMIT 3"), "Orienté sud si possible", Today)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim p As New ExporteurPdf

        ' avec valeurs (peut-être pas toutes)
        'Dim def = Bdd.GetRow("defunts", "def_id", 10)
        'Dim villedef = Bdd.GetRow("t_loc_ville", "locville_id", def("locville_id"))
        'Dim paysdef = Bdd.GetRow("t_pays", "Pays_id", villedef("Pays_id"))
        'Dim tdm = New DataTable()
        'tdm.Columns.AddRange({New DataColumn("dmdr_nomcomplet"), New DataColumn("dmdr_tel"), New DataColumn("dmdr_adresse"), New DataColumn("dmdr_nomville"), New DataColumn("dmdr_cp"), New DataColumn("dmdr_nompays")})
        'tdm.Rows.Add("José Pazihalé", "02 428", "Rue des fênes 13", "Ouagadougou", 1310, "Vietnam")
        'Dim dmdr = tdm.Rows(0)
        'Dim typecsnsollic = TTypeCsnInh.Cercueil1Pers15Ans
        'Dim datesign = Today
        'Dim refemplcsnexis = "C9765"
        'Dim defsdeja = Bdd.Query("select * from defunts where def_id > 15 limit 4")
        'Dim csnr = Bdd.GetRow("concessionnaires", "csnr_id", 27)
        'Dim villecsnr = Bdd.GetRow("t_loc_ville", "locville_id", 4)
        'Dim payscsnr = Bdd.GetRow("t_pays", "Pays_id", 5)
        'Dim benefs = Bdd.Query("select * from beneficiaires order by ben_id asc limit 3")

        'sans valeurs

        Dim def = Bdd.GetRowVide("defunts")
        ' les strings ne doivent jamais être dbnull
        def("def_nom") = ""
        def("def_prenom") = ""
        def("def_adresse") = ""
        def("def_etat_civil_de") = ""
        def("def_lieu_deces") = ""
        def("def_lieu_naiss") = ""
        def("def_etat_civil") = TEtatCivil.NonPrecise   ' not null aussi

        Dim villedef = Bdd.GetRowVide("t_loc_ville")
        villedef("locville_ville") = ""
        Dim paysdef = Bdd.GetRowVide("t_pays")
        paysdef("Pays_nom") = ""
        Dim tdm = New DataTable()
        tdm.Columns.AddRange({New DataColumn("dmdr_nomcomplet"), New DataColumn("dmdr_tel"), New DataColumn("dmdr_adresse"), New DataColumn("dmdr_nomville"), New DataColumn("dmdr_cp"), New DataColumn("dmdr_nompays")})
        Dim dmdr = tdm.NewRow
        dmdr("dmdr_nomcomplet") = ""
        dmdr("dmdr_tel") = ""
        dmdr("dmdr_adresse") = ""
        dmdr("dmdr_nomville") = ""
        dmdr("dmdr_nompays") = ""
        Dim typecsnsollic As TTypeCsnInh = TTypeCsnInh.NonPrecise
        Dim datesign = Nothing
        Dim refemplcsnexis = ""
        Dim defsdeja = Nothing
        Dim csnr = Nothing
        Dim villecsnr = Nothing
        Dim payscsnr = Nothing
        Dim benefs = Nothing


        p.CreePdfInhum(def, villedef, paysdef, dmdr, typecsnsollic, datesign, refemplcsnexis, defsdeja, csnr, villecsnr, payscsnr, benefs)
    End Sub
End Class

