'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Emplacement
    Public Property Id As Integer
    Public Property Reference As String
    Public Property Type As Integer
    Public Property NbPlaces As Nullable(Of Integer)
    Public Property MonumClasse As Boolean
    Public Property Coordonnees As Byte()
    Public Property HistId As Nullable(Of Integer)

    Public Overridable Property Concessions As ICollection(Of Concession) = New HashSet(Of Concession)
    Public Overridable Property Defunts As ICollection(Of Defunt) = New HashSet(Of Defunt)
    Public Overridable Property Histoire As Histoire

End Class
