Partial Public Class PersonneContact
    Implements IPersonne, IEntity

#Region "Interfaces IPersonne & IEntity"

    Public Property IdInterface As Integer Implements IPersonne.Id, IEntity.Id
        Get
            Return Id
        End Get
        Set(value As Integer)
            Id = value
        End Set
    End Property

    Public Property NomInterface As String Implements IPersonne.Nom
        Get
            Return Nom
        End Get
        Set(value As String)
            Nom = value
        End Set
    End Property

    Public Property PrenomInterface As String Implements IPersonne.Prenom
        Get
            Return Prenom
        End Get
        Set(value As String)
            Prenom = value
        End Set
    End Property

    Private Property AdresseInterface As String Implements IPersonne.Adresse
        Get
            Return Adresse
        End Get
        Set(value As String)
            Adresse = value
        End Set
    End Property

    Public Property LocVilleInterface As LocVille Implements IPersonne.LocVille
        Get
            Return LocVille
        End Get
        Set(value As LocVille)
            LocVille = value
        End Set
    End Property

    Public Property NomVille As String Implements IPersonne.NomVille
        Get
            If LocVille IsNot Nothing Then Return LocVille.Ville Else Return ""
        End Get
        Set(value As String)
            If LocVille Is Nothing Then LocVille = New LocVille
            LocVille.Ville = value
        End Set
    End Property

    Public Property Pays As Pays Implements IPersonne.Pays
        Get
            If LocVille IsNot Nothing Then Return LocVille.Pays Else Return Nothing
        End Get
        Set(value As Pays)
            If LocVille Is Nothing Then LocVille = New LocVille
            LocVille.Pays = value
        End Set
    End Property

    Public Property Cp As Integer? Implements IPersonne.Cp
        Get
            If LocVille IsNot Nothing Then Return LocVille.Cp Else Return Nothing
        End Get
        Set(value As Integer?)
            If LocVille Is Nothing Then LocVille = New LocVille
            LocVille.Cp = value
        End Set
    End Property

    Public Property NomPays As String Implements IPersonne.NomPays
        Get
            If LocVille IsNot Nothing AndAlso LocVille.Pays IsNot Nothing Then Return LocVille.Pays.Nom Else Return ""
        End Get
        Set(value As String)
            If LocVille Is Nothing Then LocVille = New LocVille
            If LocVille.Pays Is Nothing Then LocVille.Pays = New Pays
            LocVille.Pays.Nom = value
        End Set
    End Property

    Public ReadOnly Property AdresseComplete As String Implements IPersonne.AdresseComplete
        Get
            Return Uzineagaz.AdresseComplète(Adresse, Cp, NomVille, NomPays)
        End Get
    End Property

    Public ReadOnly Property NomComplet As String Implements IPersonne.NomComplet
        Get
            Return Uzineagaz.NomComplet(Prenom, Nom)
        End Get
    End Property
#End Region

End Class
