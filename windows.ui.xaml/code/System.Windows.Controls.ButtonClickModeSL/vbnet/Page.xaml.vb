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
        InitializeComponent()
    End Sub
    '<snippet11> 
    Private Sub OnClick1(ByVal sender As Object, ByVal e As RoutedEventArgs)
        btn1.Foreground = New SolidColorBrush(Windows.UI.Colors.Blue)
        text1.Text = "Click event handled on Hover."
        text2.Text = ""
        text3.Text = ""
    End Sub

    Private Sub OnClick2(ByVal sender As Object, ByVal e As RoutedEventArgs)
        btn2.Foreground = New SolidColorBrush(Windows.UI.Colors.Green)
        text1.Text = ""
        text2.Text = "Click event handled on Press."
        text3.Text = ""
    End Sub

    Private Sub OnClick3(ByVal sender As Object, ByVal e As RoutedEventArgs)
        btn1.Foreground = New SolidColorBrush(Windows.UI.Colors.Green)
        btn2.Foreground = New SolidColorBrush(Windows.UI.Colors.Blue)
        text1.Text = ""
        text2.Text = ""
        text3.Text = "Click event handled on Release."
    End Sub
    '</snippet11> 

End Class
