Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes


Partial Public Class Page
    Inherits UserControl

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
' <snippet11>
   Private Sub HandleCheck(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim cb As CheckBox = CType(sender, CheckBox)
        If (cb.Name = "cb1") Then
            text1.Text = "Two state CheckBox checked."
        Else
            text2.Text = "Three state CheckBox checked."
        End If
    End Sub

    Private Sub HandleUnchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim cb As CheckBox = CType(sender, CheckBox)
        If (cb.Name = "cb1") Then
            text1.Text = "Two state CheckBox unchecked."
        Else
            text2.Text = "Three state CheckBox unchecked."
        End If
    End Sub

    Private Sub HandleThirdState(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim cb As CheckBox = CType(sender, CheckBox)
        text2.Text = "Three state CheckBox indeterminate."
    End Sub
' </snippet11>
End Class
