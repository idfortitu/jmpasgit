Public Class CtrlEtatCivil
    Private VraieValeurEtatCivilDe As String       ' la valeur peut être retirée de la textbox TbEtatCivilDe, si l'état civil n'attend pas d'autre personne, mais il faut le retenir pour pouvoir le remettre si la sélection change à nouveau
    Private DesactMajValECD As Boolean = False ' à voir

    Public Sub New()
        InitializeComponent()   ' This call is required by the designer.    
        MajValECD()
        MajTbEtatCivilDe()
    End Sub

    Private _osef
    Property osef
        Get
            Return _osef
        End Get
        Set(value)
            _osef = value
        End Set
    End Property

    ' devenu integer pour les bindings (car integer en bdd)
    Public Property EtatCivil As Integer 'TEtatCivil
        Get
            'Return If(CbEtatCivil.SelectedValue IsNot Nothing AndAlso [Enum].IsDefined(GetType(TEtatCivil), CbEtatCivil.SelectedValue), CbEtatCivil.SelectedValue, TEtatCivil.NonPrecise)
            Return If(CbEtatCivil.SelectedValue IsNot Nothing AndAlso [Enum].IsDefined(GetType(TEtatCivil), CbEtatCivil.SelectedValue), CType(CbEtatCivil.SelectedValue, Integer), CType(TEtatCivil.NonPrecise, Integer))
        End Get
        Set(value As Integer) 'TEtatCivil)
            'CbEtatCivil.SelectedValue = value
            CbEtatCivil.SelectedValue = CType(value, TEtatCivil)
        End Set
    End Property

    Private _lectureSeule As Boolean
    Public Property LectureSeule As Boolean
        Get
            Return _lectureSeule
        End Get
        Set(value As Boolean)
            _lectureSeule = value
            TbEtatCivilDe.ReadOnly = value
            CbEtatCivil.Enabled = Not value
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
