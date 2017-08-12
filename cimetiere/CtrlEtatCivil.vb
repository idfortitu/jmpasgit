Public Class CtrlEtatCivil
    Private VraieValeurEtatCivilDe As String       ' la valeur peut être retirée de la textbox TbEtatCivilDe, si l'état civil n'attend pas d'autre personne, mais il faut le retenir pour pouvoir le remettre si la sélection change à nouveau
    Private DesactMajValECD As Boolean = False ' à voir

    Public Sub New()
        InitializeComponent()   ' This call is required by the designer.    
        MajValECD()
        MajTbEtatCivilDe()
    End Sub

    Public Property EtatCivil As TEtatCivil
        Get
            Return If([Enum].IsDefined(GetType(TEtatCivil), CbEtatCivil.SelectedValue), CbEtatCivil.SelectedValue, TEtatCivil.NonPrecise)
        End Get
        Set(value As TEtatCivil)
            CbEtatCivil.SelectedValue = value
        End Set
    End Property

    Public Property EtatCivilDe As String
        Get
            Return VraieValeurEtatCivilDe
        End Get
        Set(value As String)
            VraieValeurEtatCivilDe = value
            If TbEtatCivilDe.Enabled Then TbEtatCivilDe.Text = VraieValeurEtatCivilDe
        End Set
    End Property

    Public Sub MajValECD() Handles TbEtatCivilDe.TextChanged
        If Not DesactMajValECD Then VraieValeurEtatCivilDe = TbEtatCivilDe.Text
    End Sub

    ' disable la textbox étatcivilde si elle n'est pas applicable, la vide, mais sauve le texte avant
    Private Sub MajTbEtatCivilDe() Handles CbEtatCivil.SelectedIndexChanged
        If EtatCivilAttendNom(CbEtatCivil.SelectedValue) Then
            If Not TbEtatCivilDe.Enabled Then
                TbEtatCivilDe.Text = VraieValeurEtatCivilDe
                TbEtatCivilDe.Enabled = True
            End If
        Else
            If TbEtatCivilDe.Enabled Then
                TbEtatCivilDe.Enabled = False
                VraieValeurEtatCivilDe = TbEtatCivilDe.Text
                DesactMajValECD = True     ' on ne veut pas que ce changement de texte déclenche l'évènement TextChanged
                TbEtatCivilDe.Text = ""
                DesactMajValECD = False
            End If
        End If
    End Sub

End Class
