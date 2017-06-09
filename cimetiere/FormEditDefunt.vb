Public Class FormEditDefunt

    Private Property IdDef As Integer
    Public Property LeDefunt As DataRow

    Sub New(Optional id As Integer = -1)
        InitializeComponent() ' This call is required by the designer.
        IdDef = id
    End Sub

    Private Sub FormEditDéfunt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChargerDefunt(IdDef)
    End Sub

    Private Sub ChargerDefunt(id As Integer)
        If IdDef <> -1 Then
            LeDefunt = Bdd.GetRow("defunts", "def_id", IdDef)
            TbNom.Text = LeDefunt("def_nom")
            TbPrénom.Text = LeDefunt("def_prenom")
            TbintNumLh.Value = LeDefunt("def_numero_lh")
            TbintNumAnnée.Value = LeDefunt("def_numero_annee")
            TbAdresse.Text = LeDefunt("def_adresse")
            TbdDateDécès.DateValue = LeDefunt("def_date_deces")
            TbLieuDécès.Text = LeDefunt("def_lieu_deces")
            TbdDateNaiss.DateValue = LeDefunt("def_date_naiss")
            TbLieuNaiss.Text = LeDefunt("def_lieu_naiss")
            CtrlEtatCivil.EtatCivil = LeDefunt("def_etat_civil")
            CtrlEtatCivil.EtatCivilDe = LeDefunt("def_etat_civil_de")
            If Not IsDBNull(LeDefunt("empl_id")) Then CbEmplacement.SelectedValue = LeDefunt("empl_id")
            If Not IsDBNull(LeDefunt("locville_id")) Then
                CtrlLocVillePays1.CbLocVille.SelectedValue = LeDefunt("locville_id")
            End If
        Else
            LeDefunt = Bdd.GetRowVide("defunts")
            LeDefunt("def_id") = -1
        End If
    End Sub

    Private Sub BtAnnuler_Click(sender As Object, e As EventArgs) Handles BtAnnuler.Click

    End Sub

    Private Sub BtEnregistrer_Click() Handles BtEnregistrer.Click
        If ToutEstCorrect() Then
            LeDefunt("def_nom") = TbNom.Text
            LeDefunt("def_prenom") = TbPrénom.Text
            LeDefunt("def_numero_lh") = TbintNumLh.Value
            LeDefunt("def_numero_annee") = TbintNumAnnée.Value
            LeDefunt("def_date_deces") = TbdDateDécès.DateValue
            LeDefunt("def_date_naiss") = TbdDateNaiss.DateValue
            LeDefunt("def_lieu_deces") = TbLieuDécès.Text
            LeDefunt("def_lieu_naiss") = TbLieuNaiss.Text
            LeDefunt("def_adresse") = TbAdresse.Text
            LeDefunt("empl_id") = If(CbEmplacement.SelectedValue <> -1, CbEmplacement.SelectedValue, DBNull.Value)
            LeDefunt("def_etat_civil") = CtrlEtatCivil.EtatCivil
            LeDefunt("def_etat_civil_de") = CtrlEtatCivil.EtatCivilDe
            LeDefunt("locville_id") = If(CtrlLocVillePays1.LocVilleId <> -1, CtrlLocVillePays1.LocVilleId, DBNull.Value)

            If LeDefunt("def_id") <> -1 Then
                Bdd.Update("defunts", LeDefunt)
            Else
                LeDefunt("def_id") = Bdd.Insert("defunts", LeDefunt)
            End If

            DialogResult = DialogResult.OK
        Else
            ToolTip1.Show("Le formulaire contient des champs incorrects.", BtEnregistrer)
        End If


    End Sub

    Private Function ToutEstCorrect() As Boolean
        FaireValidation()
        Return _
            ErrorProvider1.GetError(TbNom) = "" _
    AndAlso ErrorProvider1.GetError(TbPrénom) = "" _
    AndAlso ErrorProvider1.GetError(TbdDateNaiss) = "" _
    AndAlso ErrorProvider1.GetError(TbdDateDécès) = ""
    End Function

    Private Sub FaireValidation()
        TbNom_Validating(Nothing, Nothing)
        TbPrénom_Validating(Nothing, Nothing)
        TbdDateDécès_Validating(Nothing, Nothing)
        TbdDateNaiss_Validating(Nothing, Nothing)
    End Sub

    Private Sub TbNom_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TbNom.Validating
        If TbNom.Text.Trim = "" Then
            ErrorProvider1.SetError(TbNom, "Veuillez entrer le nom du défunt")
        Else
            ErrorProvider1.SetError(TbNom, "")
        End If
    End Sub

    Private Sub TbPrénom_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TbPrénom.Validating
        If TbPrénom.Text.Trim = "" Then
            ErrorProvider1.SetError(TbPrénom, "Veuillez entrer le prénom du défunt")
        Else
            ErrorProvider1.SetError(TbPrénom, "")
        End If
    End Sub

    Private Sub TbdDateDécès_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TbdDateDécès.Validating
        If Not TbdDateDécès.DateEstValide Then
            ErrorProvider1.SetError(TbdDateDécès, "La date est incorrecte")
        Else
            ErrorProvider1.SetError(TbdDateDécès, "")
        End If
    End Sub

    Private Sub TbdDateNaiss_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TbdDateNaiss.Validating
        If Not TbdDateNaiss.DateEstValide Then
            ErrorProvider1.SetError(TbdDateNaiss, "La date est incorrecte")
        Else
            ErrorProvider1.SetError(TbdDateNaiss, "")
        End If
    End Sub

End Class