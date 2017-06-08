Imports cimetiere

Partial Public Class Histoire
    Implements IEntity

    Public Property Emplacement As Emplacement
        Get
            If Emplacements.Count > 0 Then
                Return Emplacements(0)
            Else
                Return Nothing
            End If
        End Get
        Set(value As Emplacement)
            Emplacements.Clear()
            If value IsNot Nothing Then Emplacements.Add(value)
        End Set
    End Property

    Private Property IEntity_Id As Integer Implements IEntity.Id
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Integer)
            Throw New NotImplementedException()
        End Set
    End Property
End Class
