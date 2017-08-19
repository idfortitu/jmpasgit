Imports iTextSharp.text.pdf
Imports itextsharp.text
Imports System.IO
Public Class ExporteurPdf

    Private _pdf As Document
    Private ReadOnly Property pdf As Document
        Get
            If _pdf Is Nothing Then
                _pdf = New Document(PageSize.A4, 50, 40, 30, 20)
                _pdfwrite = PdfWriter.GetInstance(_pdf, New FileStream(NomFic, FileMode.Create))
                _pdf.Open()
            End If
            Return _pdf
        End Get
    End Property
    Private _pdfwrite As PdfWriter
    Private ReadOnly Property pdfwrite As PdfWriter
        Get
            If _pdfwrite Is Nothing Then
                _pdf = New Document(PageSize.A4, 50, 40, 30, 40)
                Dim kroutt = NomFic
                _pdfwrite = PdfWriter.GetInstance(_pdf, New FileStream(NomFic, FileMode.Create))
                _pdf.Open()
            End If
            Return _pdfwrite
        End Get
    End Property
    Private _NomFic As String
    Public Property NomFic As String
        Get
            If _NomFic Is Nothing Then _NomFic = Format(Now.Year, "0000") & "-" & Format(Now.Month, "00") & "-" & Format(Now.Day, "00") & "_" & Format(Now.Hour, "00") & Format(Now.Minute, "00") & Format(Now.Second, "00") & ".pdf"
            Return _NomFic
        End Get
        Set(value As String)
            If _pdfwrite IsNot Nothing Then
                Throw New Exception("Le nom du fichier ne peut plus être changé une fois que l'écriture a commencé.")
            Else
                _NomFic = value
            End If
        End Set
    End Property

    Dim fNormal, fNormalL, fNormalXL, fNormalS, fSouligne, fSouligneS, fSouligneL, fGras, fGrasL, fGrasS, fGrasItalique, fGrasSouligne, fItalique, fItaliqueXS, fItaliqueS, fItaliqueL, fItaliqueSouligne, fItaliqueSouligneXS, fItaliqueSouligneS, fBarre, fSpecial1, fSpecial1Gras, fSpecial1S, fSpecial1L As Font
    Dim Logo As itextsharp.text.Image

    Const CASE_COCHEE = ChrW(&H2612), CASE_VIDE = ChrW(9744), EURO = ChrW(8364)

    Public Sub New()
        InitFonts()
        Logo = Image.GetInstance("logo.png")
        'pdf = New Document()
        'pdfwrite = PdfWriter.GetInstance(pdf, New FileStream(Format(Now.Year, "0000") & "_" & Format(Now.Month, "00") & "_" & Format(Now.Day, "00") & "_" & Format(Now.Hour, "00") & Format(Now.Minute, "00") & Format(Now.Second, "00") & ".pdf", FileMode.Create))
        'pdf.Open()
    End Sub

    ' renvoie true si nomfic obtenu
    Public Function GetNomficViaSaveDialog() As Boolean
        Dim SavDlg As New SaveFileDialog()
        With SavDlg
            .AddExtension = True
            .DefaultExt = "pdf"
            .AutoUpgradeEnabled = True
            .CheckPathExists = True
            '.InitialDirectory =    ' à adapter selon config
            .OverwritePrompt = True
            '.Title =       ' à voir
            .ValidateNames = True
            .Filter = "Document pdf (*.pdf)|*.pdf"
            ' nom du fichier par défaut
            .FileName = Format(Now.Year, "0000") & "_" & Format(Now.Month, "00") & "_" & Format(Now.Day, "00") & "_" & Format(Now.Hour, "00") & Format(Now.Minute, "00") & Format(Now.Second, "00") & ".pdf"
        End With
        If (SavDlg.ShowDialog = DialogResult.OK) Then
            Me.NomFic = SavDlg.FileName
            Return True
        Else
            Return False
        End If
    End Function


    'à adapter pour datatables

    Public Sub CreerPdfInhum(Optional Defunt As DataRow = Nothing, Optional Demandeur As DataRow = Nothing, Optional TypeCsnInhSollic As TTypeCsnInh = TTypeCsnInh.NonPrecise, Optional TypeInhCsnExis As TTypeInhCsnExistante = TTypeInhCsnExistante.NonPrecise, Optional DateSign As Date? = Nothing, Optional RefEmplCsnExistante As String = "", Optional DefuntsDeja As DataTable = Nothing, Optional Concessionnaire As DataRow = Nothing, Optional Beneficiaires As DataTable = Nothing)         '(Optional LeForm As DemandeInhumation = Nothing)
        ' valeurs par défaut pour les paramètres optionnels, pour ne pas devoir se demander si tel paramètre est présent ou pas
        If Defunt Is Nothing Then
            Defunt = Bdd.GetRowVide("defunts)")
            Defunt("def_prenom") = ""
            Defunt("def_nom") = ""
            Defunt("def_adresse") = ""
            Defunt("def_etat_civil") = TEtatCivil.NonPrecise
            Defunt("def_lieu_naiss") = ""
            Defunt("def_lieu_deces") = ""
        End If
        Dim VilleDefunt As DataRow
        If Not IsDBNull(Defunt("locville_id")) AndAlso Defunt("locville_id") > 0 Then
            VilleDefunt = Bdd.GetRow("t_loc_ville", Defunt("locville_id"))
        Else
            VilleDefunt = Bdd.GetRowVide("t_loc_ville")
            VilleDefunt("locville_ville") = ""
        End If
        Dim PaysDefunt As DataRow
        If Not IsDBNull(VilleDefunt("Pays_id")) Then
            PaysDefunt = Bdd.GetRow("t_pays", VilleDefunt("Pays_id"))
        Else
            PaysDefunt = Bdd.GetRowVide("t_pays")
            PaysDefunt("Pays_nom") = ""
        End If
        If Demandeur Is Nothing Then
            Demandeur = Bdd.GetRowDmdrVide
        End If

        If DefuntsDeja Is Nothing Then DefuntsDeja = Bdd.GetTableVide("defunts")
        If Concessionnaire Is Nothing Then
            Concessionnaire = Bdd.GetRowVide("concessionnaires")
            ' les strings ne peuvent pas être dbnull
            Concessionnaire("csnr_prenom") = ""
            Concessionnaire("csnr_nom") = ""
            Concessionnaire("csnr_tel") = ""
            Concessionnaire("csnr_adresse") = ""
        End If
        Dim VilleCsnr As DataRow
        If Not IsDBNull(Concessionnaire("locville_id")) AndAlso Concessionnaire("locville_id") > 0 Then
            VilleCsnr = Bdd.GetRow("t_loc_ville", Concessionnaire("locville_id"))
        Else
            VilleCsnr = Bdd.GetRowVide("t_loc_ville")
            VilleCsnr("locville_ville") = ""
        End If
        Dim PaysCsnr As DataRow
        If Not IsDBNull(VilleCsnr("Pays_id")) Then
            PaysCsnr = Bdd.GetRow("t_pays", VilleCsnr("Pays_id"))
        Else
            PaysCsnr = Bdd.GetRowVide("t_pays")
            PaysCsnr("Pays_nom") = ""
        End If

        If Beneficiaires Is Nothing Then Beneficiaires = Bdd.GetTableVide("beneficiaires")


        Dim p As Paragraph
        Dim pdf = Me.pdf        ' économise l'accès à la propriété à chaque utilisation



        ' encadré en haut à droite
        Colonne("Cimetière communal de la hulpe", 440, 150, 700, 809, fGras)
        RectangleGras(445, 744, 115, 45)

        Logo.ScaleToFit(50, 50)
        Logo.SetAbsolutePosition(455, 750)
        pdf.Add(Logo)

        Colonne(If(Not IsDBNull(Defunt("def_numero_lh")), Defunt("def_numero_lh"), ".............."), 512, 150, 700, 790, fGrasS)           ' si dbnull, est nothing ?
        Colonne(If(Not IsDBNull(Defunt("def_numero_annee")), Defunt("def_numero_annee"), "........"), 507, 150, 700, 770, fGrasS)     ' idem
        Colonne(Today.Year, 535, 150, 700, 770)

        p = New Paragraph("À compléter en MAJUSCULES", fGras)
        p.Alignment = Element.ALIGN_CENTER
        pdf.Add(p)

        Dim t As New PdfPTable(1) With {.WidthPercentage = 18, .HorizontalAlignment = Rectangle.ALIGN_LEFT}
        t.AddCell(New PdfPCell(New Phrase("Personne défunte : ", fGras)))
        pdf.Add(t)

        pdf.Add(New Paragraph(Champ("Nom : ", Defunt("def_nom"), ".........................................................................................................................................................")))
        pdf.Add(New Paragraph(Champ("Prénom(s) : ", Defunt("def_prenom"), "................................................................................................................................................")))

        pdf.Add(New Paragraph(ChampAdresse(Defunt("def_adresse"), VilleDefunt("locville_ville"), If(Not IsDBNull(VilleDefunt("locville_cp")), VilleDefunt("locville_cp"), Nothing), PaysDefunt("Pays_nom"))))

        p = New Paragraph
        p.Add(Champ("Né(e) à ", Defunt("def_lieu_naiss"), "........................................................................................."))
        p.Add(Champ(" le ", If(Not IsDBNull(Defunt("def_date_naiss")), CType(Defunt("def_date_naiss"), Date).ToString("dd/MM/yyyy"), Nothing), "......................................................................."))
        pdf.Add(p)

        p = New Paragraph
        p.Add(Champ("Décédé(e) à ", Defunt("def_lieu_deces"), ".................................................................................."))
        p.Add(Champ(" le ", If(Not IsDBNull(Defunt("def_date_deces")), CType(Defunt("def_date_deces"), Date).ToString("dd/MM/yyyy"), Nothing), "......................................................................."))
        pdf.Add(p)

        pdf.Add(New Paragraph(Champ("État civil : ", If(Not IsDBNull(Defunt("def_etat_civil")), Uzineagaz.TEtatCivilToString(Defunt("def_etat_civil")), Nothing), "......................")))
        If Not IsDBNull(Defunt("def_etat_civil")) AndAlso Uzineagaz.EtatCivilAttendNom(Defunt("def_etat_civil")) Then
            pdf.Add(New Paragraph(Champ("      De ", Defunt("def_etat_civil_de"), "...............................")))
        End If

        pdf.Add(New Paragraph(vbCrLf))
        LigneHoriz()


        t = New PdfPTable(1) With {.WidthPercentage = 18, .HorizontalAlignment = Rectangle.ALIGN_LEFT}
        t.AddCell(New PdfPCell(New Phrase("Personne mandatée :", fGras)))
        pdf.Add(t)

        ' Partie demandeur

        p = New Paragraph
        p.Add(Champ("Je soussigné(e), ", Demandeur("dmdr_nomcomplet"), "............................................................"))
        p.Add(Champ(" –  Tél. : ", Demandeur("dmdr_tel"), "....................................................................................................."))
        pdf.Add(p)
        ' la conversion explicite du CP en integer nullable est là pour que le If renvoie une valeur type Integer?, ce qui évite que le Nothing soit transformé en 0
        pdf.Add(New Paragraph(ChampAdresse(Demandeur("dmdr_adresse"), Demandeur("dmdr_nomville"), If(IsDBNull(Demandeur("dmdr_cp")), Nothing, New Integer?(Convert.ToInt32(Demandeur("dmdr_cp")))), Demandeur("dmdr_nompays"))))



        pdf.Add(New Paragraph("Sollicite au nom de la famille :", fNormal))
        pdf.Add(New Paragraph(Cse(TypeCsnInhSollic <> TTypeCsnInh.NonPrecise AndAlso TypeCsnInhSollic <> TTypeCsnInh.CsnExistante AndAlso TypeCsnInhSollic <> TTypeCsnInh.Prolong) & " a) l'obtention d'un emplacement suivant :", fGrasS))
        'pdf.Add(New Paragraph(CASE_VIDE & " b) la prolongation d'un emplacement existant de type :", fNormal))

        InsererTableauTypeEmplacement(TypeCsnInhSollic)

        ' À FAIRE :  voir si les cases existantes - "urne" etc sont encore pertinentes
        p = New Paragraph
        p.Add(New Phrase(Cse(TypeCsnInhSollic = TTypeCsnInh.CsnExistante) & " b) l'inhumation en concession existante : ", fGrasS))
        p.Add(New Phrase(Cse(TypeInhCsnExis = TTypeInhCsnExistante.Urne) & " urne - " & Cse(TypeInhCsnExis = TTypeInhCsnExistante.Cercueil) & " cercueil / " & Cse(TypeInhCsnExis = TTypeInhCsnExistante.PleineTerre) & " pleine terre - " & Cse(TypeInhCsnExis = TTypeInhCsnExistante.Caveau) & " caveau - " & Cse(TypeInhCsnExis = TTypeInhCsnExistante.CelluleColombarium) & " cellule de columbarium - " & Cse(TypeInhCsnExis = TTypeInhCsnExistante.Cavurne) & " cavurne", fNormal))
        pdf.Add(p)
        'pdf.Add(New Paragraph(Cse(.ConcSollic = "existante") & " b) l'inhumation en concession existante : " & CASE_VIDE & " urne - " & CASE_VIDE & " cercueil / " & CASE_VIDE & " pleine terre - " & CASE_VIDE & " caveau - " & CASE_VIDE & " cellule de columbarium - " & CASE_VIDE & " cavurne", fGrasS))
        pdf.Add(New Paragraph(Champ("                          Référence de l'emplacement : ", RefEmplCsnExistante, ".............................................")))
        pdf.Add(New Paragraph(Champ("                          Références des éventuels autres défunts dans la sépulture  : ",
                                    String.Join(", ", From def As DataRow In DefuntsDeja.Rows Select def("def_prenom") & " " & def("def_nom")),
                                    ".............................................")))

        pdf.Add(New Phrase("Le paiement de la redevance doit être exécuté par la personne qui demande l'emplacement et est payable au comptant ", fItaliqueXS))
        pdf.Add(New Phrase("au moment", fItaliqueSouligneXS))
        pdf.Add(New Phrase(" de la demande.", fItaliqueXS))
        pdf.Add(New Paragraph(vbCrLf & "             En cas de choix d'une concession, merci de compléter le verso du présent document.", fGrasS))
        pdf.Add(New Phrase("Je déclare avoir pris connaissance du réglement du cimetière (et redevances y afférentes).", fNormalS))
        pdf.Add(New Phrase("" & vbCrLf & "Je m'engage à respecter les dispositions de ce règlement.", fNormalS))

        pdf.Add(New Phrase(vbCrLf))
        pdf.Add(New Phrase(Champ("Date : ", If(DateSign IsNot Nothing, DateSign.Value.ToString("dd/MM/yyyy"), Nothing))))

        pdf.Add(New Phrase("                                                                Signature de la personne mandatée", fNormal))

        ' À FAIRE : ajout cadre "avis du fossoyeur"

        pdf.Add(New Phrase("" & vbCrLf & "" & vbCrLf & "" & vbCrLf & "  Réservé à l'Administration :", fGras))

        Dim admin As New PdfPTable(3)
        admin.WidthPercentage = 100
        'admin.WidthPercentage = 88
        admin.SetWidths({35, 35, 30})
        admin.HorizontalAlignment = 3


        Dim cellule As New PdfPCell(New Paragraph("Cimetière : Date : .................................... Heure : ..................................." & vbCrLf & "" & vbCrLf & "Eglise : Date - heure : ................................................. — Incinération : Lieu - heure : ......................................" & vbCrLf & "   ", fNormal))
        cellule.Colspan = 3
        admin.AddCell(cellule)
        admin.AddCell(New Paragraph("Reçu le montant de : " & EURO & " ........................." & vbCrLf & "" & vbCrLf & "" & ChrW(9744) & " Liquide - " & ChrW(9744) & " Virement - " & ChrW(9744) & " Bancontact" & vbCrLf & "     ", fNormal))
        p = New Paragraph("Taxe sur les inhumations, dispersions des cendres et mises en colombarium :" & vbCrLf & CASE_VIDE & " " & EURO & " 100" & vbCrLf & CASE_VIDE & " Dispense : motif ...................................." & vbCrLf & vbCrLf & ".....................................................................", fNormal)
        admin.AddCell(p)



        admin.AddCell(New Paragraph("Directeur financier : vérification faite " & CASE_VIDE & " oui - " & CASE_VIDE & " non" & vbCrLf & "" & vbCrLf & "Date : ................................" & vbCrLf & vbCrLf & "Signature," & vbCrLf & vbCrLf & vbCrLf, fNormal))

        pdf.Add(admin)

        Dim bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, False)
        pdf.Add(New Phrase(vbCrLf, New Font(BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1252, False), 3)))
        Dim Permis As New PdfPTable(1)
        Dim encadre As New PdfPCell(New Paragraph("Permis " & CASE_VIDE & " d'INHUMER / " & CASE_VIDE & " de TRANSPORT / " & CASE_VIDE & " de DISPERSION DES CENDRES " & vbCrLf & "" & vbCrLf & " délivré à La Hulpe, le ........................         Signature de l'Officier de l'État civil ou de son représentant," & vbCrLf & "         " & vbCrLf & "     " & vbCrLf & "     ", fNormal))
        encadre.HorizontalAlignment = 3
        Permis.WidthPercentage = 100

        Permis.HorizontalAlignment = 3
        Permis.AddCell(encadre)

        pdf.Add(Permis)


        '  PARTIE NOUVELLE CONCESSION

        pdf.NewPage()



        'logo.Alignment = Image.ALIGN_CENTER
        Logo.SetAbsolutePosition(50, 775)
        '           Logo.SetAbsolutePosition(455, 750)
        '
        pdf.Add(Logo)

        Dim titre As String = "DOCUMENT A COMPLETER EN CAS DE NOUVELLE CONCESSION"
        Dim para As New Paragraph(titre)
        para.Alignment = Element.ALIGN_CENTER
        pdf.Add(para)

        pdf.Add(New Paragraph(" "))
        pdf.Add(New Paragraph("Pour toute demande d'une concession relative au défunt mentionné au recto de la présente page. les bénéficiaires de la concession doivent être mentionnés ci-dessous (à défaut d'indiquer les bénéficiaires, veuillez lire le point b) en bas de page.)", fNormal))
        pdf.Add(New Paragraph("La personne qui sollicite la concession est le concessionnaire.", fNormal))
        pdf.Add(New Paragraph(" "))
        pdf.Add(New Paragraph(Champ("Nom et prénom du concessionnaire : ", If(Concessionnaire("csnr_nom") <> "" Or Concessionnaire("csnr_prenom") <> "", Concessionnaire("csnr_nom") & ", " & Concessionnaire("csnr_prenom"), Nothing), ".....................................................")))
        p = New Paragraph
        p.Add(Champ("Date de naissance : ", If(Not IsDBNull(Concessionnaire("csnr_date_naiss")), CType(Concessionnaire("csnr_date_naiss"), Date).ToString("dd/MM/yyyy"), Nothing), "........................................................ "))
        p.Add(Champ(" – n° de registre national : ", If(Not IsDBNull(Concessionnaire("csnr_no_registre")), Concessionnaire("csnr_no_registre").ToString, ""), "........................................................."))
        pdf.Add(p)

        pdf.Add(New Paragraph(ChampAdresse(Concessionnaire("csnr_adresse"), VilleCsnr("locville_ville"), If(Not IsDBNull(VilleCsnr("locville_cp")), VilleCsnr("locville_cp"), Nothing), PaysCsnr("Pays_nom"))))
        pdf.Add(New Paragraph(Champ("Téléphone : ", Concessionnaire("csnr_tel"), ".......................................................................................................................................")))
        pdf.Add(New Paragraph(" "))

        Dim table As New PdfPTable(4)
        table.WidthPercentage = 100
        table.AddCell(New Paragraph("Nom(s) du/des) bénéficiaires(s):", fNormalL))
        table.AddCell(New Paragraph("Prénom(s)", fNormalL))
        table.AddCell(New Paragraph("Date(s) de naissance", fNormalL))
        table.AddCell(New Paragraph("Lien(s) de parenté", fNormalL))
        Dim i As Integer = 0
        Dim nbrben As Integer = Beneficiaires.Rows.Count
        While i < nbrben Or i < 4
            Dim ben As DataRow
            If i < nbrben Then ben = Beneficiaires.Rows(i)
            table.AddCell(New Phrase(If(i < nbrben, ben("ben_nom"), " "), fNormal))
            table.AddCell(New Phrase(If(i < nbrben, ben("ben_prenom"), " "), fNormal))
            table.AddCell(New Phrase(If(i < nbrben AndAlso Not IsDBNull(ben("ben_date_naiss")), CType(ben("ben_date_naiss"), Date).ToString("dd/MM/yyyy"), " "), fNormal))
            table.AddCell(New Phrase(If(i < nbrben, ben("ben_lien_parente"), " "), fNormal))
            i += 1
        End While
        pdf.Add(table)

        pdf.Add(New Paragraph("Date et signature du concessionnaire :", fNormal))        'If(Not .SigneParPmand, fNormal, fBarre)))
        pdf.Add(New Paragraph("Date, signature et identité de la personne mandatée :", fNormal))      'If(.SigneParPmand, fNormal, fBarre)))
        pdf.Add(New Phrase("BIFFEZ LA MENTION INUTILE, S.V.P.", fItaliqueL))
        pdf.Add(New Paragraph(" "))
        pdf.Add(New Paragraph(" "))
        pdf.Add(New Paragraph(" "))
        pdf.Add(New Phrase("Personne mandatée :", fSouligne))
        pdf.Add(New Paragraph("La personne qui effectue la présente déclaration doit obligatoirement signer ce document. S'il s'agit d'une personne", fNormal))
        pdf.Add(New Paragraph("mandatée par la famille qui se trouve dans l'incapacité de signer, il lui incombe alors de faire remplir un formulaire de", fNormal))
        pdf.Add(New Paragraph("demande de concession par la famille (le concessionnaire) et de retourner ce document à l'administration communale de La Hulpe le plus rapidement possible.", fNormal))

        pdf.Add(New Phrase("IMPORTANT:    ", fGrasL))
        pdf.Add(New Phrase("À défaut, la présente déclaration n'est pas valable", fSouligne))
        pdf.Add(New Phrase(" car incomplète.", fNormalL))
        pdf.Add(New Paragraph(" "))
        pdf.Add(New Paragraph(" "))

        Dim paragr As New Paragraph("Règlement du 20/12/04 de police et d'administration du cimetière", fSouligne)
        paragr.Alignment = Element.ALIGN_CENTER
        pdf.Add(paragr)
        pdf.Add(New Paragraph(""))

        Dim cinquantehuit As New Paragraph("Article 58 traitant des concessions :", fSouligne)
        cinquantehuit.Alignment = Element.ALIGN_CENTER
        pdf.Add(cinquantehuit)
        pdf.Add(New Paragraph(""))

        Dim Article58 As New List(False, True, 20.0F)
        Article58.IsLowercase = True
        Article58.Add(New ListItem(New Phrase("Les demandes de concessions indiquent l'identité des bénéficiaires.", fNormal)))
        Article58.Add(New ListItem(New Phrase("À défaut d'indiquer l'identité du ou des bénéficiaire(s), tous les membres de la famille du concessionnaire sont " _
                                    & "bénéficiaires, à concurrence du nombre de places, sans que, entre eux, il existe des priorités ; seule la chronologie des " _
                                    & "décès détermine le rang.", fNormal)))
        Article58.Add(New ListItem(New Phrase("Le concessionnaire peut, à tout moment, modifier ou compléter la liste des bénéficiaires soit par lettre portant sa " _
                                                  & "signature légalisée, adressée à l'Officier de l'État civil et spécifiant les modifications apportées, soit par un acte " _
                                                  & "satisfaisant aux conditions de capacité et de forme des actes testamentaires.", fNormal)))
        Dim ItemListe As New ListItem("Après le décès du concessionnaire, ", fNormal)
        ItemListe.Add(New Chunk("aucune modification ", fSouligne))
        ItemListe.Add(New Chunk("de l'état de la concession (transformation d'une concession pleine terre en caveau, agrandissement " _
                                    & "ou approfondissement de la concession ou du caveau, transfert de l'urne) "))
        ItemListe.Add(New Chunk("n'est autorisée", fSouligne))
        ItemListe.Add(New Chunk(".", fNormal))
        Article58.Add(ItemListe)

        Article58.Add(New ListItem(New Phrase("Dans le cas où les bénéficiaires sont les membres d'une ou de plusieurs communautés religieuses, " _
                                                  & "l'identité de ceux-ci sera reprise au moment de l'inhumation. Aucune déclaration de volonté " _
                                                  & "de la part des membres de la communauté ne sera requise.", fNormal)))

        pdf.Add(Article58)



        'pdf.Close()
        pdf.Close()
        pdfwrite.Close()
        'pdfwrite.Dispose()

    End Sub


    Sub CreePdfReservation(Optional Csnr As DataRow = Nothing, Optional ChoixTypeReservation As TTypeCsnInh = TTypeCsnInh.NonPrecise, Optional Beneficiaires As DataTable = Nothing, Optional Commentaire As String = "", Optional datesign As Date? = Nothing)
        If Csnr Is Nothing Then
            Csnr = Bdd.GetRowVide("concessionnaires")
            ' champs not null
            Csnr("csnr_nom") = ""
            Csnr("csnr_prenom") = ""
            Csnr("csnr_adresse") = ""
            Csnr("csnr_tel") = ""
        End If
        Dim VilleCsnr As DataRow
        If Not IsDBNull(Csnr("locville_id")) AndAlso Csnr("locville_id") > 0 Then
            VilleCsnr = Bdd.GetRow("t_loc_ville", "locville_id", Csnr("locville_id"))
        Else
            VilleCsnr = Bdd.GetRowVide("t_loc_ville")
            VilleCsnr("locville_ville") = ""
        End If
        Dim PaysCsnr As DataRow
        If Not IsDBNull(VilleCsnr("Pays_id")) AndAlso VilleCsnr("Pays_id") > 0 Then
            PaysCsnr = Bdd.GetRow("t_pays", "Pays_id", VilleCsnr("Pays_id"))
        Else
            PaysCsnr = Bdd.GetRowVide("t_pays")
            PaysCsnr("Pays_nom") = ""
        End If

        If Beneficiaires Is Nothing Then Beneficiaires = Bdd.GetTableVide("beneficiaires")


        Dim pdf = Me.pdf

        Dim p As Paragraph

        ' mettre "Version du document : 2014" ?

        FaireGrosEnTete("Formulaire de demande de réservation d'une concession")

        pdf.Add(New Paragraph("Ce formulaire vaut pour une demande d'obtention pour un emplacement concédé au cimetière de La Hulpe. Cette demande " &
                    "sera examinée par le Collège communal qui donnera une réponse écrite. Si cette réponse est favorable, le paiement de " &
                    "l'éventuelle redevance applicable devra être exécuté (à ce stade, le demandeur peut encore renoncer). Après réponse " &
                    "favorable et paiement, une confirmation écrite concernant la réservation de la concession sera délivrée.", fNormal))

        ' "Identité du demandeur" : ici, on utilise les infos du concessionnaire, ça pourrait changer par la suite
        FaireTableauIdentiteDuDemandeur(Uzineagaz.NomComplet(Csnr("csnr_prenom"), Csnr("csnr_nom")), If(Not IsDBNull(Csnr("csnr_date_naiss")), Csnr("csnr_date_naiss"), Nothing), Uzineagaz.AdresseComplete(Csnr("csnr_adresse"), if(not IsDBNull(VilleCsnr("locville_cp")),VilleCsnr("locville_cp"),nothing), VilleCsnr("locville_ville"), PaysCsnr("Pays_nom")), Csnr("csnr_tel"), "Identité du demandeur :      (sauf mention contraire, le demandeur sera le concessionnaire)")

        InsererTableauTypeEmplacement(ChoixTypeReservation)

        pdf.Add(New Paragraph("Cet emplacement est destiné aux personnes suivantes :", fNormal))
        pdf.Add(New Paragraph(" ", fNormal))

        Dim table As New PdfPTable(4)
        table.WidthPercentage = 100
        table.AddCell(New Paragraph("Nom(s)", fNormal))
        table.AddCell(New Paragraph("Prénom(s)", fNormal))
        table.AddCell(New Paragraph("Date(s) de naissance", fNormal))
        table.AddCell(New Paragraph("Domicile (si différent du demandeur)", fNormal))
        Dim i As Integer = 0
        Dim nbrben As Integer = Beneficiaires.Rows.Count
        While i < nbrben Or i < 4
            Dim ben As DataRow
            If i < nbrben Then ben = Beneficiaires.Rows(i)
            table.AddCell(New Phrase(If(i < nbrben, ben("ben_nom"), vbCrLf & vbCrLf), fNormal))
            table.AddCell(New Phrase(If(i < nbrben, ben("ben_prenom"), vbCrLf & vbCrLf), fNormal))

            table.AddCell(New Phrase(If(i < nbrben AndAlso Not IsDBNull(ben("ben_date_naiss")), CType(ben("ben_date_naiss"), Date).ToString("dd/MM/yyyy"), vbCrLf & vbCrLf), fNormal))
            Dim RowBenVille As DataRow
            If i < nbrben Then
                Dim TbBenVille = Bdd.Query("SELECT t_loc_ville.locville_ville,locville_cp,Pays_nom FROM t_loc_ville LEFT OUTER JOIN t_pays ON t_loc_ville.Pays_id = t_pays.Pays_id WHERE locville_id = " & If(Not IsDBNull(ben("locville_id")), ben("locville_id"), -1))
                RowBenVille = If(TbBenVille.Rows.Count > 0, TbBenVille.Rows(0), TbBenVille.NewRow)
            End If
            table.AddCell(New Phrase(If(i < nbrben, Uzineagaz.AdresseComplete(if(not IsDBNull(ben("ben_adresse")),ben("ben_adresse"),nothing), If(IsDBNull(RowBenVille("locville_cp")), Nothing, RowBenVille("locville_cp")), if(isdbnull(RowBenVille("locville_ville")),Nothing,RowBenVille("locville_ville")), if(IsDBNull(RowBenVille("Pays_nom")),Nothing,RowBenVille("Pays_nom"))), vbCrLf & vbCrLf), fNormal))
            i += 1
        End While
        pdf.Add(table)

        p = New Paragraph("Remarque éventuelle :   ", fNormal)
        p.SetLeading(0, 1.8)
        pdf.Add(p)
        p = New Paragraph(If(Commentaire <> "", Commentaire,
                          "............................................................................................................." & vbCrLf &
                          "............................................................................................................." & vbCrLf), fItaliqueL)
        p.SetLeading(0, If(Commentaire <> "", 1.4, 1.8))
        pdf.Add(p)

        p = New Paragraph("Fait à .................................................................................. , " &
                          "le " & If(datesign.HasValue, datesign.Value.ToString("dd/MM/yyyy"), "................................."), fNormalL)
        p.SetLeading(0, 1.8)
        pdf.Add(p)
        pdf.Add(New Paragraph(" ", fNormalS))
        pdf.Add(New Paragraph("Signature : ", fNormalL))


        pdf.NewPage()
        Logo.SetAbsolutePosition(50, 775)
        pdf.Add(Logo)

        'Dim col As New ColumnText(pdfwrite.DirectContent)
        p = New Paragraph
        p.Add(New Phrase("Extrait du règlement du 20/12/2004 du cimetière de La Hulpe (relatif aux concessions)", fGrasS))
        'col.SetSimpleColumn(140, 0, 800, 815) 'Droite / ? / espacement / hauteur
        'col.AddText(p)
        'col.Go()
        p.Alignment = Element.ALIGN_CENTER
        pdf.Add(p)

        pdf.Add(New Paragraph(vbCrLf & vbCrLf, fNormalS))

        pdf.Add(New Paragraph("Article 56", fSouligne))
        pdf.Add(New Paragraph(" ", fNormalS))

        pdf.Add(New Paragraph("      Les concessions", fGrasS))

        Dim liste As New List(False, True, 20.0F)
        liste.IsLowercase = True
        liste.Add(New ListItem(New Phrase("en pleine terre ou avec caveaux", fGrasS)))
        liste.Add(New ListItem(New Phrase("pour l'inhumation  des cercueils ou des urnes cinéraires", fGrasS)))
        liste.Add(New ListItem(New Phrase("pour le placement des urnes cinéraires", fGrasS)))
        pdf.Add(liste)

        pdf.Add(New Paragraph("sont accordées aussi longtemps que les possibilités en terrains et/ou en installations le permettent par le Collège des Bourgmestre et Echevins.", fGrasS))
        pdf.Add(New Paragraph(" ", fNormalS))
        pdf.Add(New Paragraph("Pour ce faire, la personne qui sollicite la concession de sépulture devra, au moment de la demande :", fGrasS))
        pdf.Add(New Paragraph(" ", fNormalS))

        liste = New List(True, False, 20.0F)
        liste.Add(New ListItem(New Phrase("être âgée de 65 ans accomplis", fGrasS)))
        liste.Add(New ListItem(New Phrase("être désignée comme bénéficiaire ou parmi les bénéficiaires de la concession, sans préjudice des dispositions de l'article 6 de la loi du 20 juillet 1971", fGrasS)))
        liste.Add(New ListItem(New Phrase("être domiciliée depuis plus de 6 mois sur le territoire de la commune : la date d'inscription dans les registres de la population et/ou des étrangers et/ou d'attente faisant foi", fGrasS)))
        pdf.Add(liste)

        pdf.Add(New Paragraph(" ", fNormalS))

        Dim ph As New Phrase("ATTENTION : les trois conditions précitées sont cumulatives et doivent obligatoirement être réunies au moment de la" &
                              " demande. A défaut d'être réunies toutes les trois, la concession ne pourra être accordée qu'après le décès d'une personne, et" &
                              " au bénéfice de celle-ci ainsi que, si le demandeur le souhaite, au bénéfice d'autres personnes désignées par ce dernier" &
                              " conformément à la loi. Toutefois, pour une cellule de columbarium, la possibilité est laissée au survivant de solliciter ", fGrasS)
        Dim chunque As New Chunk("pour lui-même", fGrasS)
        chunque.SetUnderline(1, -2)
        ph.Add(chunque)
        ph.Add(New Chunk(" la concession d'une cellule voisine de celle de son conjoint, parent ou compagnon, ", fNormalS))

        chunque = New Chunk("et cela dès le décès de ce dernier", fGrasS)
        chunque.SetUnderline(1, -2)
        ph.Add(chunque)
        ph.Add(New Chunk(". L'octroi d'une concession ne confère aucun droit de propriété sur le terrain concédé mais uniquement un droit de jouissance et d'usage avec" &
               " affectation spéciale et nominative. En accordant une concession de sépulture, l'autorité communale ne procède ni à un louage ni à une vente. Les concessions" &
               " et sépultures sont incessibles et inaliénables.", fGrasS))
        pdf.Add(ph)

        pdf.Add(New Paragraph(" ", fNormalS))

        pdf.Add(New Paragraph("Article 57", fSouligne))
        pdf.Add(New Paragraph(" ", fNormalS))

        pdf.Add(New Paragraph("Il ne peut être conclu de contrat de concession pour plusieurs personnes même unies par des liens de parenté ou d'alliance : " &
                              "l'Administration ne connaît qu'un seul concessionnaire par contrat.", fNormalS))
        pdf.Add(New Paragraph(" ", fNormalS))
        pdf.Add(New Paragraph("Une même sépulture concédée peut recevoir :", fNormalS))

        liste = New List(False, True, 20.0F)
        liste.Add(New ListItem(New Phrase("soit les restes mortels du demandeur, de son conjoint, de ses parents et de ses alliés", fNormalS)))
        liste.Add(New ListItem(New Phrase("soit les restes mortels des membres d'une ou plusieurs communautés religieuses", fNormalS)))
        liste.Add(New ListItem(New Phrase("soit les restes de personnes ayant chacune exprimé auprès de l'administration communale leur volonté de bénéficier d'une sépulture commune", fNormalS)))
        liste.Add(New ListItem(New Phrase("soit les restes mortels de personnes qui ont été désignées par le titulaire de la concession", fNormalS)))
        liste.Add(New ListItem(New Phrase("à défaut d'avoir exprimé chacun leur volonté de leur vivant, en cas de constitution d'un ménage de fait, le survivant d'un tel ménage peut" &
                                          " demander l'octroi d'une concession pour lui-même et le décédé. Il appartient à l'autorité communale de vérifier la réalité de l'existence" &
                                          "d'un tel ménage de fait.", fNormalS)))
        pdf.Add(New Paragraph("", fNormalS))
        pdf.Add(New Paragraph("Si un différend surgit entre le demandeur de la concession et les ayants droit de la personne décédée, il appartiendra à la partie la plus diligente" &
                              " de le soumettre à l'appréciation des juridictions compétentes.", fNormalS))
        pdf.Add(New Paragraph("", fNormalS))
        pdf.Add(New Paragraph("Une demande de concession peut être introduite au bénéfice d'un tiers et de sa famille. Dans ce cas, le demandeur est le seul" &
                              " concessionnaire, le tiers et sa famille ayant seulement la qualité de bénéficiaires.", fGrasS))

        pdf.Add(New Paragraph(" ", fNormalS))
        pdf.Add(New Paragraph("Article 58", fSouligne))
        pdf.Add(New Paragraph(" ", fNormalS))

        liste = New List(True, False, 20.0F)
        liste.Add(New ListItem(New Phrase("les demandes de concession indiquent l'identité des bénéficiaires", fNormalS)))
        liste.Add(New ListItem(New Phrase("à défaut d'indiquer l'identité du ou des bénéficiaire(s), tous les membres de la famille du concessionnaire sont bénéficiaires," &
                                          " à concurrence du nombre de places, sans que, entre eux, il existe des priorités ; seule la chronologie des décès détermine le rang.", fNormalS)))
        liste.Add(New ListItem(New Phrase("le concessionnaire peut, à tout moment, modifier ou compléter la liste des bénéficiaires soit par lettre portant sa signature légalisée, adressée à" &
                                          " l'Officier de l'État civil et spécifiant les modifications apportées, soit par un acte satisfaisant aux conditions de capacité et de forme" &
                                          " des actes testamentaires.", fNormalS)))
        ph = New Phrase("après le décès du concessionnaire, ", fNormalS)
        chunque = New Chunk("aucune modification", fSouligneS)
        ph.Add(chunque)
        ph.Add(New Chunk(" de l'état de la concession (transformation d'une concession pleine terre en caveau, agrandissement ou appronfondissement de la concession" &
               "ou du caveau, transfert de l'urne) ", fNormalS))
        chunque = New Chunk("n 'est autorisée", fSouligneS)
        ph.Add(chunque)
        ph.Add(".")
        liste.Add(New ListItem(ph))
        liste.Add(New ListItem(New Phrase("dans le cas où les bénéficiaires sont les membres d'un ou de plusieurs communautés religieuses, l'identité" &
                                          " de ceux-ci sera reprise au moment de l'inhumation. Aucune déclaration de volonté de la part des membres de la" &
                                          " communauté ne sera requise.", fNormalS)))

        Dim litem As New ListItem(New Phrase("dans une concession caveau ou pleine terre complète, le placement d'un maximum de 3 urnes supplémentaires ne pourra" &
                                              "être admis que moyennant le respect de l'ensemble des clauses ci-après:", fNormalS))
        Dim liste2 As New List(True, False, 20.0F)
        liste2.Add(New ListItem(New Phrase("l'espace intérieur du caveau ou de la tombe concernée permettra un placement aisé des urnes", fNormalS)))
        liste2.Add(New ListItem(New Phrase("le paiement préalable au moment de la déclaration du décès de la redevance prévue dans le réglement-taxe d'application", fNormalS)))
        liste2.Add(New ListItem(New Phrase("par assimilation aux dispositions de l'article 58 c, pour chaque cas, une demande écrite du bénéficiaire ou" &
                                           " de ses ayants droit ainsi qu'un accord écrit du concessionnaire (écrits datés, signés, légalisés).", fNormalS)))
        litem.Add(liste2)
        liste.Add(litem)
        pdf.Add(liste)

        pdf.Close()

    End Sub

    Sub CreePdfProlongation()

        Dim pdf = Me.pdf

        FaireGrosEnTete("Formulaire relatif aux sépultures existantes, faisant l'objet d'une concession, en vue d'une prolongation")

        pdf.Add(New Paragraph(" "))

        pdf.Add(New Paragraph("Je soussignée(e), ............................................., souhaite obtenir la prolongation d'une" &
                              " concession existante (remplir les indications relatives à la sépulture au verso du présent document", fNormalL))
        pdf.Add(New Paragraph(" ", fNormalS))

        pdf.Add(New Paragraph("Ce formulaire, dûment complété et signé, sera examiné par le Collège communal qui adressera une réponse écrite au demandeur." &
                              " Ce formulaire n'engage ni le demandeur ni la Commune à une modification de la concession existante.", fNormalL))
        pdf.Add(New Paragraph("La concession ne sera prolongée qu'après décision formelle du Collège communal et perception" &
                              " par la Commune de la redevance en vigueur.", fNormalL))
        pdf.Add(New Paragraph("Nous attirons votre attention sur l'obligation qui vous est faite d'entretenir la concession sous" &
                              " peine de la voir faire l'objet d'un avis de constat d'abandon de sépulture et revenir après un an" &
                              " d'affichage à la Commune (Code de la démocratie locale et de la décentralisation, article L-1232-12.", fNormalL))

        pdf.Add(New Paragraph(" "))
        pdf.Add(New Paragraph("Fait à..................................................................................  le .............................", fNormalL))
        pdf.Add(New Paragraph(" "))
        pdf.Add(New Paragraph("Signature : ", fNormalL))

        pdf.NewPage()

        Dim t As New PdfPTable(2)
        Dim c As PdfPCell
        t.WidthPercentage = 90
        t.HorizontalAlignment = Element.ALIGN_RIGHT
        t.SetWidths({6, 12})

        c = New PdfPCell(New Phrase("Description de la sépulture existante", fNormal))
        t.AddCell(c)
        c = New PdfPCell(New Phrase("il est souhaitable de renseigner un maximum d'informations", fItalique))
        c.Border = Rectangle.NO_BORDER
        c.PaddingLeft = 12
        t.AddCell(c)
        pdf.Add(t)

        pdf.Add(New Paragraph(" "))

        Dim L1 As List
        'Dim L2 As List
        Dim litem As ListItem

        L1 = New List(True, False, 20.0F)

        litem = New ListItem(New Phrase("", fNormal))   ' phrase vide pour que le 1. prenne la police normale
        litem.Add(New Phrase("Type de sépulture :", fSouligne))
        litem.Add(New Paragraph(" "))
        litem.Add(New Paragraph("      ○ emplacement en pleine terre", fNormal))
        litem.Add(New Paragraph("      ○ emplacement en caveau", fNormal))
        litem.Add(New Paragraph("      ○ emplacement en colombarium", fNormal))
        litem.Add(New Paragraph(" "))
        L1.Add(litem)

        litem = New ListItem(New Phrase("", fNormal))
        litem.Add(New Phrase("Dans cette sépulture reposent les restes mortels de la (des) personne(s) suivante(s) :", fSouligne))
        t = New PdfPTable(5)
        t.WidthPercentage = 100
        t.SetWidths({4, 4, 3, 3, 4})
        t.AddCell(New Phrase("Nom(s)", fNormal))
        t.AddCell(New Phrase("Prénom(s)", fNormal))
        t.AddCell(New Phrase("Date(s) de naissance", fNormal))
        t.AddCell(New Phrase("Date(s) de décès", fNormal))
        t.AddCell(New Phrase("Lien(s) de parenté", fNormal))

        ' à adapter façon tableau bénefs quand le form prolongation sera fait
        For i As Integer = 0 To 25
            t.AddCell(New Paragraph(vbCrLf & vbCrLf, fNormal))
        Next
        litem.Add(t)
        litem.Add(New Paragraph(" "))
        L1.Add(litem)

        ''pdf.Add(New Paragraph("Lien(s) de parenté avec le demandeur :"))
        ''pdf.Add(New Paragraph("............................................................................................................................................................"))
        ''pdf.Add(New Paragraph("............................................................................................................................................................"))

        litem = New ListItem(New Phrase("Situation approximative de l'endroit où se trouve la sépulture :", fNormal))
        litem.Add(New Paragraph("..............................................................................................................................................."))
        litem.Add(New Paragraph("..............................................................................................................................................."))
        litem.Add(New Paragraph(" "))
        L1.Add(litem)

        litem = New ListItem(New Phrase("Remarques éventuelles : ", fNormal))
        litem.Add(New Paragraph("..............................................................................................................................................."))
        litem.Add(New Paragraph("..............................................................................................................................................."))
        litem.Add(New Paragraph("..............................................................................................................................................."))
        L1.Add(litem)

        pdf.Add(L1)

        pdf.Close()
    End Sub

    Private Sub InitFonts()
        Dim ArialFontPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIALUNI.TTF")
        Dim bfBaseFont As BaseFont
        bfBaseFont = BaseFont.CreateFont(ArialFontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED)

        fNormal = New Font(bfBaseFont, 9)
        fNormalL = New Font(bfBaseFont, 10)
        fNormalXL = New Font(bfBaseFont, 18)
        fNormalS = New Font(bfBaseFont, 8.5, Font.NORMAL)
        fSouligne = New Font(bfBaseFont, 9, Font.UNDERLINE)
        fSouligneS = New Font(bfBaseFont, 8.5, Font.UNDERLINE)
        fSouligneL = New Font(bfBaseFont, 10, Font.UNDERLINE)
        fGras = New Font(bfBaseFont, 9, Font.BOLD)
        fGrasL = New Font(bfBaseFont, 10.0, Font.BOLD)
        fGrasS = New Font(bfBaseFont, 8.5, Font.BOLD)
        fGrasItalique = New Font(bfBaseFont, 9, Font.BOLDITALIC)
        fGrasSouligne = New Font(bfBaseFont, 9, Font.BOLDITALIC & Font.UNDERLINE)
        fItalique = New Font(bfBaseFont, 9, Font.ITALIC)
        fItaliqueXS = New Font(bfBaseFont, 7, Font.ITALIC)
        fItaliqueS = New Font(bfBaseFont, 8.5, Font.ITALIC)
        fItaliqueL = New Font(bfBaseFont, 10, Font.ITALIC)
        fItaliqueSouligne = New Font(bfBaseFont, 9, Font.ITALIC Or Font.UNDERLINE)
        fItaliqueSouligneS = New Font(bfBaseFont, 7, Font.ITALIC Or Font.UNDERLINE)
        fBarre = New Font(bfBaseFont, 9)

        ' Texte de l'en-tête, au-dessus du logo
        Dim bfSpecial1 As BaseFont = BaseFont.CreateFont("COPRGTL.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED)
        fSpecial1 = New Font(bfSpecial1, 9, Font.NORMAL)
        fSpecial1Gras = New Font(bfSpecial1, 9, Font.BOLD)
        fSpecial1S = New Font(bfSpecial1, 8, Font.BOLD)
        fSpecial1L = New Font(bfSpecial1, 10, Font.BOLD)

    End Sub

    ' Utilitaires

    Sub RectangleGras(x As Integer, y As Integer, w As Integer, h As Integer)
        Dim cb As PdfContentByte = pdfwrite.DirectContent
        cb.SaveState()
        cb.Rectangle(x, y, w, h)
        'cb.MoveTo(200, 0)
        cb.Stroke()
        cb.RestoreState()
    End Sub

    Sub Colonne(texte As String, x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer, Optional f As Font = Nothing)        ' pas sûr pour w,l
        If f Is Nothing Then f = fNormal
        Dim cb As PdfContentByte = pdfwrite.DirectContent
        Dim Col As New ColumnText(cb)
        Col.SetSimpleColumn(x1, y1, x2, y2)
        Dim p As New Paragraph
        p.Add(New Phrase(texte, f))
        Col.AddText(p)
        Col.Go()
    End Sub

    Sub ImageAbs(img As Image, x As Integer, y As Integer)
        img.SetAbsolutePosition(x, y)
        pdf.Add(img)
    End Sub

    ' "simule" une ligne horizontale avec un tableau vide
    Sub LigneHoriz()
        Dim tabl As New PdfPTable(1)
        tabl.WidthPercentage = 100
        Dim cel As New PdfPCell()
        cel.Border = 0
        cel.BorderColorBottom = New BaseColor(System.Drawing.Color.Black)
        cel.BorderWidthBottom = 0.75F
        tabl.AddCell(cel)
        pdf.Add(tabl)
    End Sub

    Function Champ(label As String, texte As String, Optional remplacement As String = "", Optional f As Font = Nothing) As Phrase
        Dim p As New Phrase
        p.Add(New Phrase(label, If(f, fNormal)))
        p.Add(New Phrase(If(texte <> "", texte.ToUpper, remplacement), If(f, fNormal)))
        'pdf.Add(p)
        Return p
    End Function

    Function ChampAdresse(adr As String, ville As String, cp As Integer?, pays As String) As Phrase
        Dim p As New Phrase
        p.Add(New Chunk("Domicile : ", fNormal))
        'If adr <> "" Then p.Add(New Chunk(adr.ToUpper & ", ", fNormal))
        p.Add(New Chunk(If(adr <> "", adr.ToUpper & ", ", "................................"), fNormal))
        p.Add(New Chunk(If(cp IsNot Nothing, cp & " ", "...................."), fNormal))
        p.Add(New Chunk(If(ville <> "", ville.ToUpper, "..........................."), fNormal))
        If pays <> "" Then
            p.Add(New Chunk(If(String.Compare(pays, "Belgique", True) = 0 Or pays = "", "", " (" & pays.ToUpper & ")"), fNormal))
        Else p.Add(New Chunk("..........................", fNormal))
        End If
        Return p
    End Function

    Function StringAdresseSansLabel(adr As String, ville As String, cp As Integer?, pays As String) As String
        'If adr <> "" Then p.Add(New Chunk(adr.ToUpper & ", ", fNormal))
        Dim s As String = ""
        s += If(adr <> "", adr.ToUpper & ", ", "................................")
        s += If(cp IsNot Nothing, cp & " ", "....................")
        s += If(ville <> "", ville.ToUpper, "...........................")
        If pays <> "" Then
            s += If(String.Compare(pays, "Belgique", True) = 0 Or pays = "", "", " (" & pays.ToUpper & ")")
        Else s += ".........................."
        End If
        Return s
    End Function

    ' renvoie une case cochée ou vide selon que l'argument est vrai ou faux
    Function Cse(a As Boolean, Optional sioui As String = CASE_COCHEE, Optional sinon As String = CASE_VIDE) As String
        Return If(a, sioui, sinon)
    End Function


    ' à adaptery pour datatables
    Sub InsererTableauTypeEmplacement(Optional typecon As TTypeCsnInh = TTypeCsnInh.NonPrecise)

        Dim p As Paragraph

        Dim prix As New PdfPTable(2)
        'Dim cell As New PdfPCell(New Paragraph("Montants des redevances", fNormal))
        'cell.Colspan = 2
        'cell.HorizontalAlignment = 1
        prix.WidthPercentage = 25

        prix.HorizontalAlignment = 2
        'prix.AddCell(cell)
        prix.AddCell(New Paragraph("La Hulpois : ", fGrasS))
        prix.AddCell(New Paragraph("Autres :", fGrasS))

        pdf.Add(prix)

        'P.Add(New Phrase("Indiquez le type d'emplacement souhaité", fGrasL))
        'Col.SetSimpleColumn(200, 150, 800, 590)          ' deplacehorizon , ? , largeur , hauteur
        'Add the paragraph to the ColumnText
        'Col.AddText(P)
        'Call to stupid Go() method which actually writes the content to the stream.
        'Col.Go()
        'P.Clear()

        Dim tableau As New PdfPTable(4)
        Dim intTblWidth() As Integer = {1, 33.5, 6.25, 6.25}

        tableau.WidthPercentage = 97
        tableau.SetWidths(intTblWidth)
        tableau.HorizontalAlignment = 2
        tableau.AddCell(New Paragraph(Cse(typecon = TTypeCsnInh.OrdinaireCercueil OrElse typecon = TTypeCsnInh.OrdinaireUrne, "X", " "), fNormal))
        tableau.AddCell(New Paragraph("Inhumation ordinaire en pleine terre ( " & Cse(typecon = TTypeCsnInh.OrdinaireCercueil) & " cercueil ou " & Cse(typecon = TTypeCsnInh.OrdinaireUrne) & " urne)", fNormal))
        tableau.AddCell(New Paragraph("Gratuit", fNormal))
        tableau.AddCell(New Paragraph("750 " & EURO & "", fNormal))

        'tableau.AddCell(New Paragraph(" ", fNormal))
        tableau.AddCell(New Paragraph(Cse(typecon = TTypeCsnInh.Cercueil1Pers15Ans OrElse typecon = TTypeCsnInh.Urne1Pers15Ans, "X", " "), fNormal))
        tableau.AddCell(New Paragraph("Inhumation en pleine terre (1 personne) - concession de 15 ans - " & Cse(typecon = TTypeCsnInh.Cercueil1Pers15Ans) & " cercueil - " & Cse(typecon = TTypeCsnInh.Urne1Pers15Ans) & " urne", fNormal))
        tableau.AddCell(New Paragraph("250 " & EURO & "", fNormal))
        tableau.AddCell(New Paragraph("1.800 " & EURO & "", fNormal))

        tableau.AddCell(New Paragraph(Cse(typecon = TTypeCsnInh.Cercueil2Pers15Ans OrElse typecon = TTypeCsnInh.Urne2Pers15Ans, "X", " "), fNormal))
        tableau.AddCell(New Paragraph("Inhumation en pleine terre (2 personnes) - concession de 15 ans - " & Cse(typecon = TTypeCsnInh.Cercueil2Pers15Ans) & " cercueil - " & Cse(typecon = TTypeCsnInh.Urne2Pers15Ans) & " urne", fNormal))
        tableau.AddCell(New Paragraph("500 " & EURO & "", fNormal))
        tableau.AddCell(New Paragraph("3.600 " & EURO & "", fNormal))


        tableau.AddCell(New Paragraph(Cse({TTypeCsnInh.Caveau30AnsCercueil, TTypeCsnInh.Caveau30AnsCercueilCavCom, TTypeCsnInh.Caveau30AnsUrne, TTypeCsnInh.Caveau30AnsUrneCavCom}.Contains(typecon), "X", " "), fNormal))
        p = New Paragraph
        p.Add(New Phrase("Placement d'un caveau - concession de 30 ans - " & Cse(typecon = TTypeCsnInh.Caveau30AnsCercueil OrElse typecon = TTypeCsnInh.Caveau30AnsCercueilCavCom) & " cercueil - " & Cse(typecon = TTypeCsnInh.Caveau30AnsUrne OrElse typecon = TTypeCsnInh.Caveau30AnsUrneCavCom) & " urne  " & vbCrLf, fNormal))
        p.Add(New Phrase("les cercueils sont placés horizontalement dans un alignement vertical, en profondeur (maximum 3 places)", fItaliqueXS))
        p.Add(New Phrase(vbCrLf & Cse(typecon = TTypeCsnInh.Caveau30AnsCercueilCavCom OrElse typecon = TTypeCsnInh.Caveau30AnsUrneCavCom) & " Emplacement pourvu d'un caveau communal", fGrasS))
        tableau.AddCell(p)
        tableau.AddCell(New Paragraph("400 " & EURO & " " & vbCrLf & "par pers." & vbCrLf & "+ " & EURO & " 500", fNormal))
        tableau.AddCell(New Paragraph("1.800 " & EURO & " " & vbCrLf & "par caveau." & vbCrLf & "+ " & EURO & " 500", fNormal))

        tableau.AddCell(New Paragraph(Cse(typecon = TTypeCsnInh.OuvertureCaveau, "X", " "), fNormal))
        tableau.AddCell(New Paragraph("Ouverture de caveau uniquement si travail du Fossoyeur (ouverture par chemin)", fNormal))
        tableau.AddCell(New Paragraph("100 " & EURO, fNormal))
        tableau.AddCell(New Paragraph("100 " & EURO, fNormal))

        tableau.AddCell(New Paragraph(Cse(typecon = TTypeCsnInh.UrneColombOrdinaire, "X", " "), fNormal))
        tableau.AddCell(New Paragraph("Une urne mise en columbarium - place ordinaire (cell. 1 place prioritairement)", fNormal))
        tableau.AddCell(New Paragraph("gratuit", fNormal))
        tableau.AddCell(New Paragraph("750 " & EURO & "", fNormal))


        tableau.AddCell(New Paragraph(Cse(typecon = TTypeCsnInh.UrneColomb15Ans, "X", " "), fNormal))
        tableau.AddCell(New Paragraph("Une urne mise en columbarium - concession de 15 ans", fNormal))
        tableau.AddCell(New Paragraph("250 " & EURO & "", fNormal))
        tableau.AddCell(New Paragraph("1800 " & EURO & "", fNormal))

        tableau.AddCell(New Paragraph(Cse(typecon = TTypeCsnInh.UrneColomb30Ans, "X", " "), fNormal))
        tableau.AddCell(New Paragraph("Une urne mise en columbarium - concession de 30 ans", fNormal))
        tableau.AddCell(New Paragraph("400 " & EURO & "", fNormal))
        tableau.AddCell(New Paragraph("2500 " & EURO & "", fNormal))

        tableau.AddCell(New Paragraph(Cse(typecon = TTypeCsnInh.CavurneCommunal, "X", " "), fNormal))
        tableau.AddCell(New Paragraph("Placement d'un cavurne communal - concession de 30 ans (max. 5 urnes)", fNormal))
        tableau.AddCell(New Paragraph("250 " & EURO & vbCrLf & "par urne", fNormal))
        tableau.AddCell(New Paragraph("500 " & EURO & vbCrLf & "par urne", fNormal))

        tableau.AddCell(New Paragraph(Cse(typecon = TTypeCsnInh.DispersionCendres, "X", " "), fNormal))
        tableau.AddCell(New Paragraph("Dispersion des cendres", fNormal))
        tableau.AddCell(New Paragraph("gratuit", fNormal))
        tableau.AddCell(New Paragraph("gratuit", fNormal))
        pdf.Add(tableau)
    End Sub

    Sub FaireGrosEnTete(texte As String)
        Dim t As New PdfPTable(2)
        t.WidthPercentage = 100
        t.SetWidths({30, 70})
        t.DefaultCell.Border = Rectangle.NO_BORDER

        Dim c1 As New PdfPCell
        Dim c2 As New PdfPCell
        c1.Border = Rectangle.NO_BORDER
        c2.Border = Rectangle.NO_BORDER

        Dim p = New Paragraph("Province du Brabant Wallon" & vbCrLf & "Arrondissement de Nivelles", fSpecial1S)
        p.Alignment = Element.ALIGN_CENTER
        p.SetLeading(0.0, 1.2)
        c1.AddElement(p)
        p = New Paragraph("COMMUNE" & vbCrLf & "DE", fSpecial1S)
        p.Alignment = Element.ALIGN_CENTER
        p.SetLeading(0.0, 1.35)
        c1.AddElement(p)
        p = New Paragraph("LA HULPE", fSpecial1Gras)
        p.Alignment = Element.ALIGN_CENTER
        p.SetLeading(0.0, 1.35)
        c1.AddElement(p)
        p = New Paragraph(" ")
        p.SetLeading(0, 0.5)
        c1.AddElement(p)
        Logo.ScaleToFit(50, 50)
        Logo.Alignment = Image.ALIGN_CENTER
        c1.AddElement(Logo)
        p = New Paragraph(" ")
        p.SetLeading(0, 0.5)
        c1.AddElement(p)
        p = New Paragraph("Rue des Combattants 59" & vbCrLf & "B – 1310 La Hulpe" & vbCrLf & "Cimetière : 02/652.20.53" & vbCrLf & "Service cimetière : 02/634.30.92 " & vbCrLf & "Fax. : 02/652.24.55" & vbCrLf & "nathalie.alhadeff@lahulpe.be", fNormalS)
        p.Alignment = Element.ALIGN_CENTER
        p.SetLeading(0, 1.2)
        c1.AddElement(p)

        p = New Paragraph("Cimetière communal" & vbCrLf & vbCrLf & texte, fNormalXL) ' font ?
        p.Alignment = Element.ALIGN_CENTER
        p.SetLeading(0.0, 1.2)
        c2.AddElement(p)
        p = New Paragraph(vbCrLf & vbCrLf & "Document à retourner à l’administration communale" & vbCrLf & "Service cimetière – Nathalie Alhadeff", fItaliqueL) ' font ?
        p.Alignment = Element.ALIGN_CENTER
        c2.AddElement(p)

        t.AddCell(c1)
        t.AddCell(c2)

        pdf.Add(t)

        p = New Paragraph(" ", fNormalS)
        p.SetLeading(0, 0.5)
        pdf.Add(p)

    End Sub

    Sub FaireTableauIdentiteDuDemandeur(nomcomplet As String, datenaiss As Date?, domicile As String, telephone As String, Optional caption As String = "Identité du demandeur")
        Dim t = New PdfPTable(2)
        t.WidthPercentage = 90
        t.HorizontalAlignment = Element.ALIGN_RIGHT
        t.SetWidths({3, 10})
        t.DefaultCell.Border = Rectangle.NO_BORDER

        Dim c As PdfPCell

        c = New PdfPCell
        c.Colspan = 2
        c.Border = Rectangle.NO_BORDER
        c.PaddingBottom = 12
        Dim p = New Paragraph(caption, fSouligneL)
        p.SetLeading(0, 1.8)
        c.AddElement(p)
        t.AddCell(c)

        c = New PdfPCell(New Phrase("Nom et prénom :", fNormalL))
        c.Border = Rectangle.NO_BORDER
        c.Padding = 4
        t.AddCell(c)

        'Dim n As String = Acteur.StaticNomComplet(.CsnrPrenom, .CsnrNom)
        c = New PdfPCell(New Phrase(If(nomcomplet <> "", nomcomplet, "................................................................................................................."), fNormalL))
        c.Border = Rectangle.NO_BORDER
        c.Padding = 4
        t.AddCell(c)

        c = New PdfPCell(New Phrase("Date de naissance :", fNormalL))
        c.Border = Rectangle.NO_BORDER
        c.Padding = 4
        t.AddCell(c)

        c = New PdfPCell(New Phrase(If(datenaiss.HasValue, datenaiss.Value.ToString("dd/MM/yyyy"), "................................................................................................................."), fNormalL))
        c.Border = Rectangle.NO_BORDER
        c.Padding = 4
        t.AddCell(c)

        c = New PdfPCell(New Phrase("Domicile :", fNormalL))
        c.Border = Rectangle.NO_BORDER
        c.Padding = 4
        t.AddCell(c)

        c = New PdfPCell(New Phrase(If(domicile <> "", domicile,
                                        "................................................................................................................." & vbCrLf &
                                        "                                  ................................................................................................................."), fNormalL))
        c.Border = Rectangle.NO_BORDER
        c.Padding = 4
        t.AddCell(c)

        c = New PdfPCell(New Phrase("Téléphone", fNormalL))
        c.Border = Rectangle.NO_BORDER
        c.Padding = 4
        t.AddCell(c)

        c = New PdfPCell(New Phrase(If(telephone <> "", telephone, "................................................................................................................."), fNormalL))
        c.Border = Rectangle.NO_BORDER
        c.Padding = 4
        t.AddCell(c)

        pdf.Add(t)

    End Sub

End Class
