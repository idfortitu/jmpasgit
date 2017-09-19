Imports System.Data.Entity

Partial Public Class CimEntities

    'Sub New()
    '    MyBase.New("name=cimEntities")
    'End Sub
    Public Sub New(connstr As String)
        MyBase.New(connstr)
    End Sub


    ' transforme les strings à Nothing en strings vides "" pour les enregistrer
    ' car la bdd n'accepte pas les null pour les varchar (ça évite d'avoir des erreurs en faisant par exemple csnrnom.Trim alors que csnrnom est nothing)
    ' http://stackoverflow.com/a/1119737

    Private Const StringType As String = "String"
    Private Const SavingState As EntityState = EntityState.Added Or EntityState.Modified
    Public Overrides Function SaveChanges() As Integer

        Dim objectContext = CType(Me, System.Data.Entity.Infrastructure.IObjectContextAdapter).ObjectContext
        Dim savingEntries = objectContext.ObjectStateManager.GetObjectStateEntries(SavingState)

        For Each Entree In savingEntries

            Dim curValues = Entree.CurrentValues
            Dim fieldMetadata = curValues.DataRecordInfo.FieldMetadata
            Dim stringFields = fieldMetadata _
            .Where(Function(f) f.FieldType.TypeUsage.EdmType.Name = StringType)
            For Each stringField In stringFields
                Dim ordinal = stringField.Ordinal
                Dim curValue = TryCast(curValues(ordinal), String)
                If curValue Is Nothing Then
                    curValues.SetValue(ordinal, "")
                End If
            Next
        Next
        Return MyBase.SaveChanges()
    End Function



End Class
