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
Imports System.Windows.Controls.Primitives


Partial Public Class Page
    Inherits UserControl

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        ' Note-this sample does not run because there are two button1 added to the visual tree..1 in XAML, 1 in code.
        '<snippet11>
        Dim button1 As Button = New Button
        button1.Content = "Click Me"
        button1.Name = "button1"
        LayoutRoot.Children.Add(button1)
        '</snippet11>


        '<snippet21>
        Dim button2 As Button = New Button
        button2.Height = 50
        button2.Width = 100
        button2.Background = New SolidColorBrush(Colors.Blue)
        button2.Content = "Click Me"
        '</snippet21>
    End Sub

    Private Sub myButton2_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)

    End Sub

    '<snippet51>
    Private Sub button5_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)

    End Sub
    '</snippet51>

    '<snippet611>
    Private Sub button6_Click(ByVal sender As Object, ByVal e As RoutedEventArgs) Handles button6.Click

    End Sub
    '</snippet611>


End Class
