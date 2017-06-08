Public Class FormEditDefunt

    Public Property IdDef As Integer?

    Private Property LeDefunt As Defunt

    Sub New(Optional id As Integer = -1)
        InitializeComponent() ' This call is required by the designer.
        If id <> -1 Then
            IdDef = id
        End If
    End Sub

    Private Sub FormEditDéfunt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Using ctx As New CimEntities
            If IdDef <> -1 Then
                ' SI ID PRECISE
                LeDefunt = ctx.Defunts.Include("LocVille.Pays").Single(Function(def) def.Id = IdDef)
                TbNom.Text = LeDefunt.Nom
                TbPrénom.Text = LeDefunt.Prenom
                TbIntNumLh.Value = LeDefunt.NumeroLh
                TbintNumAnnée.Value = LeDefunt.NumeroAnnee
                TbAdresse.Text = LeDefunt.Adresse
                TbdateDateDécès.DateValue = LeDefunt.DateDeces
                TbLieuDécès.Text = LeDefunt.LieuDeces
                TbdateDateNaiss.DateValue = LeDefunt.DateNaiss
                TbLieuNaiss.Text = LeDefunt.LieuNaiss
                CtrlEtatCivil.EtatCivil = LeDefunt.EtatCivil
                CtrlEtatCivil.EtatCivilDe = LeDefunt.EtatCivilDe
            Else LeDefunt = New Defunt
            End If

            ChargerListboxLocVille(ctx, LeDefunt.LocVille)
            ChargerListboxPays(ctx, LeDefunt.Pays)
            ChargerComboboxEmpl(ctx, LeDefunt.Emplacement)

        End Using


    End Sub



    Private Sub ChargerListboxLocVille(contexte As CimEntities, Optional EtSélectionnerId As Integer = -1)
        Dim ctx = If(contexte, New CimEntities)
        Try
            Dim ListeVilles As New List(Of LocVille)({New LocVille With {.Id = -1, .Ville = ""}})
            ListeVilles = ListeVilles.Concat(From v In ctx.LocVilles.Include("Pays") Order By v.Ville).ToList     ' on charge aussi les pays pour pouvoir faire correspondre les éléments de la listbox des villes (Uneville.Pays) à ceux de la listbox des pays au changement de sélection de la ville

            LbVille.DisplayMember = "NomEtCp"
            LbVille.ValueMember = "Id"
            LbVille.DataSource = ListeVilles
            If EtSélectionnerId <> -1 Then LbVille.SelectedValue = EtSélectionnerId
        Finally
            If contexte Is Nothing Then ctx.Dispose()
        End Try
    End Sub

    Private Sub ChargerListboxLocVille(contexte As CimEntities, EtSélectionner As LocVille)
        ChargerListboxLocVille(contexte, If(EtSélectionner IsNot Nothing, EtSélectionner.Id, -1))
    End Sub


    Private Sub ChargerListboxPays(contexte As CimEntities, Optional EtSélectionnerId As Integer = -1)
        Dim ctx = If(contexte, New CimEntities)
        Try
            Dim ListePays As New List(Of Pays)({New Pays With {.Id = -1, .Nom = ""}})
            ListePays = ListePays.Concat(From p In ctx.Pays.Include("LocVilles") Order By p.Nom).ToList

            LbPays.DisplayMember = "Nom"
            LbPays.ValueMember = "Id"
            LbPays.DataSource = ListePays
            If EtSélectionnerId <> -1 Then LbPays.SelectedValue = EtSélectionnerId
        Finally
            If contexte Is Nothing Then ctx.Dispose()
        End Try
    End Sub

    Private Sub ChargerListboxPays(contexte As CimEntities, EtSélectionner As Pays)
        ChargerListboxPays(contexte, If(EtSélectionner IsNot Nothing, EtSélectionner.Id, -1))

        Dim ListePays As New List(Of Pays)({New Pays With {.Id = -1, .Nom = ""}})
    End Sub

    Private Sub ChargerComboboxEmpl(contexte As CimEntities, Optional EtSélectionnerId As Integer = -1)
        Dim ctx = If(contexte, New CimEntities)
        Try
            Dim ListeEmpls As New List(Of Emplacement)({New Emplacement With {.Id = -1, .Reference = ""}})      ' élément vide
            ListeEmpls = ListeEmpls.Concat(From e In ctx.Emplacements Order By e.Reference).ToList

            CbEmplacement.DisplayMember = "Reference"
            CbEmplacement.ValueMember = "Id"
            CbEmplacement.DataSource = ListeEmpls
            CbEmplacement.SelectedValue = EtSélectionnerId
        Finally
            If contexte Is Nothing Then ctx.Dispose()
        End Try
    End Sub


    Private Sub ChargerComboboxEmpl(contexte As CimEntities, EtSélectionnerItem As Emplacement)
        ChargerComboboxEmpl(contexte, If(EtSélectionnerItem IsNot Nothing, EtSélectionnerItem.Id, -1))
    End Sub


    Private Sub BtAjouterVille_Click(sender As Object, e As EventArgs) Handles BtAjouterVille.Click
        ' en cas d'ajout de ville, il faut aussi recharger la liste des pays, la dlgbox d'ajout de ville permettant de créer des pays
        Dim f As New FormNouvelleVille
        If f.ShowDialog = DialogResult.OK Then
            Using ctx As New CimEntities
                'Dim IdVilleSelect As Integer = If(LbVille.SelectedItem IsNot Nothing, LbVille.SelectedItem.Id, -1)
                '                Dim IdPaysSelect As Integer = If(LbPays.SelectedItem IsNot Nothing, LbPays.SelectedItem.Id, -1)
                ChargerListboxLocVille(ctx, f.VilleFaite.Id)
                ChargerListboxPays(ctx)
                LbVille_SelectedIndexChanged(Nothing, Nothing)
            End Using
        End If
    End Sub

    Private Sub BtAjouterPays_Click(sender As Object, e As EventArgs) Handles BtAjouterPays.Click
        Dim f As New FormNouveauPays
        If f.ShowDialog = DialogResult.OK Then
            Using ctx As New CimEntities
                Dim IdVilleSelect As Integer = If(LbVille.SelectedItem IsNot Nothing, LbVille.SelectedItem.Id, -1)
                'Dim IdNouveauPays As Integer = f.PaysFait.Id      ' le contexte qui a chargé ces objets était différent, donc on ne peut pas compter sur les références d'objet pour reconnaître les entités
                ChargerListboxLocVille(ctx)
                ChargerListboxPays(ctx)
                LbVille.SelectedValue = IdVilleSelect
                'LbPays.SelectedValue = IdNouveauPays
            End Using
        End If
    End Sub

    Private Sub BtAnnuler_Click(sender As Object, e As EventArgs) Handles BtAnnuler.Click

    End Sub


    Private Sub BtEnregistrer_Click() Handles BtEnregistrer.Click
        Using ctx As New CimEntities
            'If le Then
            'nom
            'prénom
            'numlh
            'numannée
            'datedécès
            'datenaiss
            'lieudécès
            'lieunaiss
            'adresse
            'emplacement
            'étatcivil & de
            'ville
            'si la ville n'a pas de pays et qu'un pays est indiqué, on l'ajoute par la même occasion
        End Using
        DialogResult = DialogResult.OK
    End Sub


    Private Sub LbVille_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LbVille.SelectedIndexChanged
        ' si on change de ville, le pays doit être changé pour correspondre, et il ne peut être changé par l'utilisateur que si aucune ville n'est sélectionnée
        If LbVille.SelectedItem IsNot Nothing AndAlso CType(LbVille.SelectedItem, LocVille).Pays IsNot Nothing AndAlso CType(LbVille.SelectedItem, LocVille).Id <> -1 Then
            LbPays.SelectedItem = (CType(LbVille.SelectedItem, LocVille).Pays)
            LbPays.Enabled = False
        Else
            LbPays.SelectedItem = Nothing
            LbPays.Enabled = True
        End If
    End Sub


End Class