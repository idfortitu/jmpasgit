Imports System.Data.Entity

Imports System.Configuration
Imports System.Configuration.ConfigurationManager

Public Class debug
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kroutonu As New FormEditEmplacement(1)
        kroutonu.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim raoijer As New FormEditDefunt()
        raoijer.ShowDialog()
    End Sub


    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Using ctx As New CimEntities
            'ctx.Défunts.Add(New Défunt With {.Nom = "Tartempion"})
            ctx.SaveChanges()
            Dim a = "kak"

        End Using
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Using ctx As New CimEntities
            Dim cul = (From em In ctx.Emplacements Take 350 Select New PlanCimetiere.emplacementtresclasse With {.Id = em.Id, .reference = em.Reference, .Coords = em.Coordonnees, .estloué = True, .nboccupants = 5, .nbplaces = 5}).ToList
            'PlanCimetiere1.SetEmplacements(cul)
            PlanCimetiere1.ChangerImage("09pfuz.jpg", cul)
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

    Private Sub planemplselchg(sender As Object, e As PlanCimetiere.PlanCimEventArgs) Handles PlanCimetiere1.SelectionChanged

    End Sub

    Private Sub nvcon_Click(sender As Object, e As EventArgs) Handles nvcon.Click
        Dim aer As New FormNouvelleConcession
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

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        Dim cn = "metadata=res://*/dmCimetiere.csdl|res://*/dmCimetiere.ssdl|res://*/dmCimetiere.msl;provider=MySql.Data.MySqlClient;provider connection string=""server=localhost;user id=fossoyeur;pwd=azerty;persistsecurityinfo=True;database=bddcime"""

        Dim bordeldechiasse = New CimEntities(cn)

        MessageBox.Show("putain de merde " & bordeldechiasse.Defunts.First.Nom)



        ''Dim pute As New 
        'Dim caca = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        ''caca.ConnectionStrings.ConnectionStrings("CimetiereEntities").ConnectionString = "metadata=res://*/dmCimetiere.csdl|res://*/dmCimetiere.ssdl|res://*/dmCimetiere.msl;provider=MySql.Data.MySqlClient;provider connection string=&quot;server=localhost;user id=root;persistsecurityinfo=True;database=cimetiere2&quot;"  '"server=localhost;user id=root;persistsecurityinfo=True;database=cimetiere2"
        'caca.ConnectionStrings.ConnectionStrings("CimetiereEntities").ConnectionString = "metadata=res://*/dmCimetiere.csdl|res://*/dmCimetiere.ssdl|res://*/dmCimetiere.msl;provider=MySql.Data.MySqlClient;provider connection string=&quot;server=localhost;user id=fossoyeur;password=azerty;persistsecurityinfo=True;database=cimetiere2&quot;"  '"server=localhost;user id=root;persistsecurityinfo=True;database=cimetiere2"
        'caca.Save(ConfigurationSaveMode.Modified)       ' à tester

        'ConfigurationManager.RefreshSection("appSettings")

        'Dim prout = New CimEntities
        'MessageBox.Show(prout.Defunts.First.Nom)


        '        config.ConnectionStrings.ConnectionStrings("cimetiere.Properties.Settings.cimetiereConString").ConnectionString = "metadata=res://*/dmCimetiere.csdl|res://*/dmCimetiere.ssdl|res://*/dmCimetiere.msl;provider=MySql.Data.MySqlClient;provider connection string=&quot;server=localhost;user id=root;persistsecurityinfo=True;database=cimetiere2&quot;"  '"server=localhost;user id=root;persistsecurityinfo=True;database=cimetiere2"
        'config.Save(ConfigurationSaveMode.Modified)

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'Dim ListeVilles = Bdd.GetTable_t_loc_ville("osef")
        'Dim a = ListeVilles.Rows(0)
        'Entites.t
        'Dim q = a.
        'Dim a = "appa."
        Dim krout = "a"

    End Sub
End Class
