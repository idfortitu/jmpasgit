Public Class ComboBoxEmplacements
    Inherits ComboBox
    Public Sub New()

        Dim Empls = Bdd.GetTable("emplacements")
        Dim rowvide = Empls.NewRow
        rowvide("empl_id") = -1
        Empls.Rows.InsertAt(rowvide, 0)

        DisplayMember = "empl_reference"
        ValueMember = "empl_id"
        DataSource = Empls

    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'ComboBoxEmplacements
        '
        Me.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FormattingEnabled = True
        Me.ResumeLayout(False)

    End Sub
End Class
