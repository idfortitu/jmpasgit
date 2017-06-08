Public MustInherit Class ComboBoxEnum(Of T)
    Inherits ComboBox

    Public Sub New()
        Me.DropDownStyle = ComboBoxStyle.DropDownList
        ' Initialise la la liste avec les valeurs possibles de l'énum
        ' le designer bugge salement avec le bind (ou j'ai raté un truc)
        ' DesignMode (bool) existe aussi mais ne fonctionne que si il est appelé depuis un form, pas un contrôle
        If Not System.Diagnostics.Process.GetCurrentProcess().ProcessName = "devenv" Then
            DisplayMember = "Texte"
            ValueMember = "Valeur"
            DataSource = BindListEnum(Of T)()
        End If
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'ComboBoxEnum
        '
        Me.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ResumeLayout(False)

    End Sub

End Class

' le designer a du mal avec les contrôles génériques
Public Class ComboBoxEtatCivil
    Inherits ComboBoxEnum(Of TEtatCivil)
End Class

Public Class ComboBoxTypeEmpl
    Inherits ComboBoxEnum(Of TTypeEmpl)
End Class