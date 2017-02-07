' <snippet10>

Imports System
Imports System.Windows
Imports System.Windows.Controls


Partial Public Class Page
    Inherits UserControl

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    ' <snippet11>
    Private Sub slider2_ValueChanged(ByVal sender As Object, _
        ByVal e As RoutedPropertyChangedEventArgs(Of Double))
        Dim msg As String = String.Format("Current value: {0}", e.NewValue)
        Me.textBlock1.Text = msg
    End Sub
    ' </snippet11>
End Class
' </snippet10>