Imports System.Data.Entity

Public Class debug
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim raoijer As New FormEditDefunt(9)
        raoijer.ShowDialog()
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
        'pdf.CreePdfReservation(Bdd.GetRow("concessionnaires", "csnr_id", 27), TTypeCsnInh.UrneColomb30Ans, Bdd.Query("SELECT * FROM beneficiaires WHERE ben_id > 15 LIMIT 3"), "Orienté sud si possible", Today)
        pdf.CreePdfReservation()
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


        p.CreerPdfInhum(def, dmdr, typecsnsollic, datesign, refemplcsnexis, defsdeja, csnr, benefs)
    End Sub

    Private Sub debug_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PlanCimetiere1.Font = New Font("Calibri", 6)
        PlanCimetiere1.FuncFiltre = AddressOf emplactifplan
    End Sub
    Function emplactifplan(empl As DataRow) As Boolean
        Return empl("empl_reference") = "A1010" Or empl("empl_reference") = "A1011" Or empl("empl_reference") = "A1012"
    End Function
    Sub emplclic(s As PlanCimetiere, osef As PlanCimetiere.PlanCimEventArgs) Handles PlanCimetiere1.EmplClicked
        MessageBox.Show("clic")
    End Sub
    Sub empldclic(s As Object, osef As PlanCimetiere.PlanCimEventArgs) Handles PlanCimetiere1.EmplDoubleClicked
        MessageBox.Show("dbl")
    End Sub
    Sub emplsc(s As Object, osef As PlanCimetiere.PlanCimEventArgs) Handles PlanCimetiere1.SelectionChanged
        MessageBox.Show("selch")
    End Sub


    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        PlanCimetiere1.NomParcelleAffichee = "A1"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        PlanCimetiere1.NomParcelleAffichee = "A2"
    End Sub
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        PlanCimetiere1.NomParcelleAffichee = "A3"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        PlanCimetiere1.SetEmplacements(Bdd.GetTable("emplacements"))

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        PlanCimetiere1.Font = New Font("Calibri", 18)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim f As New dev_formplancimedit
        f.ShowDialog()

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        ' choix empl
        Dim f As New FormChoixEmplSurPlan(Function(empl) empl("empl_reference") <> "A1057")
        f.ShowDialog()
    End Sub


    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        'PlanCimetiere1.Size = New Size(PlanCimetiere1.Width * 0.9, PlanCimetiere1.Height * 0.9)
        PlanCimetiere1.Zoom += 0.1
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs)
        PlanCimetiere1.MettreALEchelleCoordsEmplacements()
    End Sub


    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        PlanCimetiere1.Zoom -= 0.1
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        PlanCimetiere1.Zoom = 1
    End Sub

    Private Sub empldclic(sender As PlanCimetiere, e As PlanCimetiere.PlanCimEventArgs) Handles PlanCimetiere1.EmplDoubleClicked

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim f As New FormSignalAbandonCsn
        f.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Bdd.InsertSignalCsnAband(33, "rien à ajouter", Image.FromFile("C:\Users\BlastBast\Documents\cimetiere6\jmpasgit\cimetiere\bin\Debug\logo.png"))
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim f As New FormVoirDetailsEmpl(34)
        f.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim t = Bdd.GetTableVide("emplacements")
        t.Columns.Add("infossuppl", GetType(String))
        Dim nrow = t.NewRow
        Dim a = Bdd.GetRow("emplacements", 36)
        For i = 0 To a.ItemArray.Count - 1
            nrow(t.Columns(i).Caption) = a(i)
        Next
        nrow("infossuppl") = "apapapa"
        nrow("empl_nb_places")=9
        Bdd.Update("emplacements", nrow)
    End Sub
End Class

