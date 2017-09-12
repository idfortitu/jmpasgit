Imports System.ComponentModel
#Const AvecLectureSeule = False
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

#If AvecLectureSeule Then
        _textbox = New TextBox()
#End If

    End Sub

    Public Property EmplId As Object
        Get
            Return SelectedValue
        End Get
        Set(value As Object)
            SelectedValue = If(value IsNot Nothing AndAlso Not IsDBNull(value), value, -1)
        End Set
    End Property

#If AvecLectureSeule Then
#Region "propriété LectureSeule, mais positionnement un peu foireux"
    Private _textbox As TextBox

    Private _isReadOnly As Boolean

    Private _visible As Boolean = True


    <Browsable(True)>
    <DefaultValue(False)>
    <Category("Behavior")>
    Public Property LectureSeule As Boolean
        Get
            Return _isReadOnly
        End Get
        Set(value As Boolean)
            If value <> _isReadOnly Then
                _isReadOnly = value
                ShowControl()
            End If
        End Set
    End Property

    Public Overloads Property Visible As Boolean
        Get
            Return _visible
        End Get
        Set
            _visible = Value
            ShowControl()
        End Set
    End Property

    Public Overloads Sub Hide()
        Visible = False
    End Sub

    Public Overloads Sub Show()
        Visible = True
    End Sub

    Private Sub AddTextbox()
        _textbox.ReadOnly = True
        _textbox.Location = Me.Location
        _textbox.Size = Me.Size
        _textbox.Dock = Me.Dock
        _textbox.Anchor = Me.Anchor
        _textbox.Enabled = MyBase.Enabled
        _textbox.Visible = Me.Visible
        _textbox.RightToLeft = Me.RightToLeft
        _textbox.Font = Me.Font
        _textbox.Text = Me.Text
        _textbox.TabStop = Me.TabStop
        _textbox.TabIndex = Me.TabIndex
    End Sub

    Private Sub ShowControl()
        If _isReadOnly Then
            _textbox.Visible = _visible And Me.Enabled
            MyBase.Visible = _visible And Not Me.Enabled
            _textbox.Text = Me.Text
        Else
            _textbox.Visible = False
            MyBase.Visible = _visible
        End If
    End Sub

    Protected Overrides Sub OnParentChanged(e As EventArgs)
        MyBase.OnParentChanged(e)
        If Parent IsNot Nothing Then
            AddTextbox()
            '_textbox.Parent = Me.Parent
            Me.Parent.Controls.Add(_textbox)
        End If
    End Sub

    Public Overrides Property BackColor As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(value As Color)
            MyBase.BackColor = value
            _textbox.BackColor = value
        End Set
    End Property

    Protected Overrides Sub OnSelectedIndexChanged(e As EventArgs)
        MyBase.OnSelectedIndexChanged(e)
        If Me.SelectedItem Is Nothing Then
            _textbox.Clear()
        Else
            _textbox.Text = Me.Text 'SelectedItem.ToString()
        End If
    End Sub

    Protected Overrides Sub OnDropDownStyleChanged(e As EventArgs)
        MyBase.OnDropDownStyleChanged(e)
        _textbox.Text = Me.Text
    End Sub

    Protected Overrides Sub OnFontChanged(e As EventArgs)
        MyBase.OnFontChanged(e)
        _textbox.Font = Me.Font
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        _textbox.Size = Me.Size
    End Sub

    Protected Overrides Sub OnDockChanged(e As EventArgs)
        MyBase.OnDockChanged(e)
        _textbox.Dock = Me.Dock
    End Sub

    Protected Overrides Sub OnEnabledChanged(e As EventArgs)
        MyBase.OnEnabledChanged(e)
        ShowControl()
    End Sub

    Protected Overrides Sub OnRightToLeftChanged(e As EventArgs)
        MyBase.OnRightToLeftChanged(e)
        _textbox.RightToLeft = Me.RightToLeft
    End Sub

    Protected Overrides Sub OnTextChanged(e As EventArgs)
        MyBase.OnTextChanged(e)
        _textbox.Text = Me.Text
    End Sub

    Protected Overrides Sub OnLocationChanged(e As EventArgs)
        MyBase.OnLocationChanged(e)
        _textbox.Location = Me.Location
    End Sub

    Protected Overrides Sub OnTabIndexChanged(e As EventArgs)
        MyBase.OnTabIndexChanged(e)
        _textbox.TabIndex = Me.TabIndex
    End Sub
#End Region
#End If


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
