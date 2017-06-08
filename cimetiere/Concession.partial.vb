Imports cimetiere

Partial Public Class Concession
    Implements IEntity


    ' propriétés pour affichage dans datagridview
    ' suppose que les entités liées aient été chargées (ou soient disponibles via un contexte)

    Public ReadOnly Property NomCompletCsnr As String
        Get
            Return Me.Concessionnaire.NomComplet
        End Get
    End Property

    Public ReadOnly Property RefEmpl As String
        Get
            Return Emplacement.Reference
        End Get
    End Property

    Public ReadOnly Property NomsOccupants As String
        Get
            Dim val As String = ""
            Dim defs = Emplacement.Defunts
            If defs.Count > 0 Then
                Val &= defs(0).NomComplet
                If defs.Count > 1 Then
                    For i = 1 To defs.Count - 1
                        Val &= ", " & defs(i).Nom
                    Next
                End If
            End If
            Return val
        End Get
    End Property


    'occupants ?

    Private Property IEntity_Id As Integer Implements IEntity.Id
        Get
            Return Id
        End Get
        Set(value As Integer)
            Id = value
        End Set
    End Property
End Class
