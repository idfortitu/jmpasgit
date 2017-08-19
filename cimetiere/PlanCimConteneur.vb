Imports System.Runtime.InteropServices

Public Class PlanCimConteneur
    Inherits Panel

    Private MonPlanCim As PlanCimetiere

    Public Sub New()
        Me.AutoScroll = True
    End Sub

    Public Sub Me_Load() Handles Me.ControlAdded, Me.ControlRemoved
        MonPlanCim = (From c In Me.Controls Where TypeOf c Is PlanCimetiere).FirstOrDefault
    End Sub

    ' empêche le panel de scroller quand on clique sur un de ses contrôles qui n'est que partiellement visible
    ' utilisé pour le plan cimetière
    Protected Overrides Function ScrollToControl(activeControl As Control) As Point
        Return Me.AutoScrollPosition
    End Function


    Private PasMouseWheel As Boolean = False

    Protected Overrides Sub OnMouseWheel(e As MouseEventArgs)
        If MonPlanCim Is Nothing Then Exit Sub

        If My.Computer.Keyboard.ShiftKeyDown Then
            If e.Delta < 0 Then
                Me.HorizontalScroll.Value = Math.Min(Me.HorizontalScroll.Value + 10, Me.HorizontalScroll.Maximum)
            Else
                Me.HorizontalScroll.Value = Math.Max(Me.HorizontalScroll.Value - 10, Me.HorizontalScroll.Minimum)
            End If
        Else
            MyBase.OnMouseWheel(e)
            ' sinon on laisse le plancim gérer l'évènement
            If Not PasMouseWheel Then       ' ceci évite un appel récursif où le plancim retransmet MouseWheel à ce formulaire
                PasMouseWheel = True
                SendMessage(MonPlanCim.Handle, &H20A, If(e.Delta <> 0, (e.Delta \ Math.Abs(e.Delta)), 0) << 16, 0)       ' &H20A = WM_MOUSEWHEEL
                PasMouseWheel = False
            End If
        End If
    End Sub


    '' le form intercepte un scroll qui aurait lieu hors du plancim (l'inconvénient du plan étant qu'il peut être dézoomé jusqu'à être laisser une zone vide dans son conteneur, dans laquelle les évènements ne lui sont pas transmis)
    'Private Sub Me_MouseWheel(sender As Object, e As MouseEventArgs) 'Handles Me.MouseWheel
    '    ' scrolling horizontal avec shift+roulette
    '    ' étant donné que le scrolling se fait dans le conteneur et pas dans le plan, il faut le gérer ici
    '    If My.Computer.Keyboard.ShiftKeyDown Then
    '        'If Me.VScroll = True Then
    '        If Me.VScroll = True Then
    '            If e.Delta > 0 Then
    '                Me.VScroll = False
    '                Me.VerticalScroll.Enabled = False
    '                'Me.HorizontalScroll.Value = Math.Min(Me.HorizontalScroll.Value + 10, Me.HorizontalScroll.Maximum)
    '                MyBase.OnMouseWheel(e)
    '                Me.VScroll = True
    '                Me.VerticalScroll.Enabled = True
    '            Else
    '                Me.VScroll = False
    '                Me.VerticalScroll.Enabled = False
    '                'Me.HorizontalScroll.Value = Math.Max(Me.HorizontalScroll.Value - 10, Me.HorizontalScroll.Minimum)
    '                MyBase.OnMouseWheel(e)
    '                Me.VScroll = True
    '                Me.VerticalScroll.Enabled = True
    '                'Dim NouvellePosScrollHoriz = 0 'Math.Max(Me.HorizontalScroll.Value - 10, Me.HorizontalScroll.Minimum)
    '                'Me.AutoScrollPosition = New Point(NouvellePosScrollHoriz, Me.AutoScrollPosition.Y)
    '                'Me.HorizontalScroll.Value = Me.HorizontalScroll.Maximum
    '            End If
    '            'CType(e, HandledMouseEventArgs).Handled = True
    '        End If
    '    Else
    '        ' sinon on laisse le plancim gérer l'évènement
    '        If Not PasMouseWheel Then       ' ceci évite un appel récursif où le plancim retransmet MouseWheel à ce formulaire
    '            PasMouseWheel = True
    '            SendMessage(PlanCimetiere1.Handle, &H20A, If(e.Delta <> 0, (e.Delta \ Math.Abs(e.Delta)), 0) << 16, 0)       ' &H20A = WM_MOUSEWHEEL
    '            PasMouseWheel = False
    '        End If
    '    End If
    ' End Sub



    <DllImport("USER32.DLL", EntryPoint:="SendMessage")>
    Public Shared Function SendMessage(hwnd As IntPtr, msg As UInt32, wParam As IntPtr, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Integer
    End Function




End Class
