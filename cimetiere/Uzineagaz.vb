Imports System.Globalization


Module Uzineagaz

    ' une notification sera affichée si une concession va se finir dans x jours
    Public Const DUREE_PREVISION_EXPIRATION_CONCESSION = 60


    ' renvoie une liste à partir d'un type enum, du genre  {  {.Texte="Fosse ordinaire", .Valeur = TTypeEmpl.FosseOrdinaire}, ...  } pour présentation dans une combobox (ou autre contrôle bindable)
    Function BindListEnum(Of T)() As List(Of BindListElement(Of T))
        Dim TypeT = GetType(T)
        Dim Identifiants = System.Enum.GetNames(TypeT)
        Dim Valeurs As Array = System.Enum.GetValues(TypeT)
        Dim Choix = New List(Of BindListElement(Of T))
        Dim MaxIndex = Identifiants.Count - 1
        If TypeT Is GetType(TEtatCivil) Then
            For i = 0 To MaxIndex
                Choix.Add(New BindListElement(Of T) With {.Texte = TEtatCivilToString(Valeurs(i)), .Valeur = CType(Valeurs(i), T)})
            Next

        ElseIf TypeT Is GetType(TTypeEmpl) Then
            For i = 0 To MaxIndex
                Choix.Add(New BindListElement(Of T) With {.Texte = TTypeEmplToString(Valeurs(i)), .Valeur = CType(Valeurs(i), T)})
            Next

        Else Throw New ArgumentException("Type non supporté.")
        End If
        Return Choix
    End Function

    Function EtatCivilAttendNom(Etat As TEtatCivil) As Boolean
        Return {TEtatCivil.Epoux, TEtatCivil.Veuf, TEtatCivil.Divorce, TEtatCivil.Enfant}.Contains(Etat)
    End Function

    ' par ex "Veuf de Machin-Bidule
    Public Function EtatCivilComplet(def As DataRow) As String
        Return TEtatCivilToString(def("def_etat_civil")) & If(EtatCivilAttendNom(def("def_etat_civil")) AndAlso (def("def_etat_civil_de").trim <> ""), " de " & def("def_etat_civil_de"), "")
    End Function



    Public Function TTypeEmplToString(TypeEmpl As TTypeEmpl) As String
        Select Case TypeEmpl
            Case TTypeEmpl.NonPrecise
                Return ""
            Case TTypeEmpl.Caveau
                Return "Caveau"
            Case TTypeEmpl.Concession
                Return "Concession"
            Case TTypeEmpl.Fosse
                Return "Fosse"
            Case TTypeEmpl.Urne
                Return "Urne en colombarium"
            Case Else
                Throw New ArgumentException("Valeur inconnue.")
        End Select
    End Function

    Public Function TEtatCivilToString(Etat As TEtatCivil) As String
        Select Case Etat
            Case TEtatCivil.NonPrecise
                Return "(non précisé)"
            Case TEtatCivil.Celibataire
                Return "Célibataire"    ' les identifiants sont pareils que les noms "humains" donc Return System.Enum.GetName(GetType(TEtatCivil), Etat) serait plus compact ; mais osef
            Case TEtatCivil.Epoux
                Return "Époux"
            Case TEtatCivil.Veuf
                Return "Veuf"
            Case TEtatCivil.Divorce
                Return "Divorcé"
            Case TEtatCivil.Enfant
                Return "Enfant"
            Case Else
                Throw New ArgumentException("Valeur inconnue.")
        End Select
    End Function

    ' http://stackoverflow.com/a/11620625
    Function RetirerDiacritiques(s As String) As String
        Dim sDecomp As String = s.Normalize(System.Text.NormalizationForm.FormD)
        Dim res As String = ""
        Dim uc As UnicodeCategory
        For i As Integer = 0 To sDecomp.Length - 1
            uc = CharUnicodeInfo.GetUnicodeCategory(sDecomp(i))
            If Not {UnicodeCategory.NonSpacingMark,
                    UnicodeCategory.SpacingCombiningMark,
                    UnicodeCategory.EnclosingMark}.Contains(uc) Then
                res += sDecomp(i)
            End If
        Next
        Return res
    End Function


    ' enlève la ponctuation, les espaces, les accents... pour les recherches
    Function ReduireString(s As String) As String
        s = RetirerDiacritiques(s).ToUpper
        Dim res As String = ""
        For Each c In s
            If (c >= "A" And c <= "Z") Or (c >= "0" And c <= "9") Then res += c
        Next
        Return res
    End Function


    ' Renvoie une seule string du style "13 avenue de la rue, 1415 Trouperdu (France)"
    Public Function AdresseComplete(Adresse As String, Cp As Integer?, Ville As String, Pays As String, Optional ForcerPays As Boolean = False) As String
        Dim Texte As String = ""
        If Adresse <> "" Then
            Texte = Adresse
        End If
        Dim CpEtVille As String = ""
        If Cp.HasValue Then
            CpEtVille = Cp.Value
            If Ville <> "" Then CpEtVille &= " "
        End If
        CpEtVille &= Ville
        If CpEtVille <> "" Then
            If Texte <> "" Then Texte &= ", "
            Texte &= CpEtVille
        End If
        If Pays <> "" AndAlso (ForcerPays = True Or Pays <> "Belgique") Then
            If Texte <> "" Then
                Texte &= " (" & Pays & ")"
            Else
                Texte &= Pays
            End If
        End If
        Return Texte
    End Function

    ' renvoie un truc du genre "DUPONT Albert"
    Public Function NomComplet(prenom As String, nom As String, Optional SignalerAbsence As Boolean = False) As String
        If nom <> Nothing And prenom <> Nothing Then
            'Return nom & ", " & prenom
            Return nom.ToUpper & " " & prenom
        ElseIf nom <> Nothing And prenom = Nothing Then
            'Return If(SignalerAbsence, nom & ", (prénom non précisé)", nom)
            Return If(SignalerAbsence, nom.ToUpper & " (prénom absent)", nom.ToUpper)
        ElseIf nom = Nothing And prenom <> Nothing Then
            Return If(SignalerAbsence, prenom & " (nom de famille absent)", prenom)
        Else
            Return If(SignalerAbsence, "(nom absent)", Nothing)
        End If
    End Function


    ' pour créer des listes d'un type anonyme
    Public Function ListeDeType(Of T)(ElemTemplate As T) As List(Of T)
        Return New List(Of T)
    End Function


    ' sert à initialiser les combobox, un DisplayMember et un ValueMember
    Public Class BindListElement(Of T)
        Public Property Texte As String
        Public Property Valeur As T
    End Class

    Public Function NomEtDatesDefunt(def As DataRow) As String
        Dim res As String = def("def_prenom") & " " & def("def_nom")
        If Not IsDBNull(def("def_date_naiss")) OrElse Not IsDBNull(def("def_date_deces")) Then
            res &= " ("
            res &= If(Not IsDBNull(def("def_date_naiss")), CType(def("def_date_naiss"), Date).Year, "?")
            res &= " - "
            res &= If(Not IsDBNull(def("def_date_deces")), CType(def("def_date_deces"), Date).Year, "?")
            res &= ")"
        End If
        Return res
    End Function


End Module

Public Enum TTypeCsnInh
    NonPrecise
    OrdinaireCercueil
    OrdinaireUrne
    Cercueil1Pers15Ans
    Urne1Pers15Ans
    Cercueil2Pers15Ans
    Urne2Pers15Ans
    Caveau30AnsCercueil
    Caveau30AnsCercueilCavCom
    Caveau30AnsUrne
    Caveau30AnsUrneCavCom
    UrneColombOrdinaire
    UrneColomb15Ans
    UrneColomb30Ans
    Urne30Ans
    CavurneCommunal
    OuvertureCaveau
    DispersionCendres
    CsnExistante
    Prolong
End Enum


Public Enum TEtatCivil As Integer
    NonPrecise = 0
    Celibataire = 1
    Epoux = 2
    Veuf = 3
    Divorce = 4
    Enfant = 5
End Enum

Public Enum TTypeInhCsnExistante
    NonPrecise
    Urne
    Cercueil
    PleineTerre
    Caveau
    CelluleColombarium
    Cavurne
End Enum

' le mettre dans le module uzineagaz provoque des problèmes d'accès
Public Enum TTypeEmpl
    NonPrecise = 0
    Caveau = 1
    Concession = 2
    Fosse = 3
    Urne = 4
End Enum
