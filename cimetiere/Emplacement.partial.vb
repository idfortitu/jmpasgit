Partial Public Class Emplacement
    Implements IEntity

    Private Property IEntity_Id As Integer Implements IEntity.Id
        Get
            Return Id
        End Get
        Set(value As Integer)
            Id = value
        End Set
    End Property

    Public Property Concession As Concession
        Get
            If Concessions.Count > 0 Then
                Return Concessions(0)
            Else
                Return Nothing
            End If
        End Get
        Set(value As Concession)
            Concessions.Clear()
            If value IsNot Nothing Then Concessions.Add(value)
        End Set
    End Property
End Class
