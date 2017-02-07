Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes

Partial Public Class MainPage
    Inherits UserControl
    Public Sub New()
        InitializeComponent()
    End Sub
    '<snippetViewBoxCode>
    '<snippetViewBoxStretch>
    'Setting the Stretch property to None
    Private Sub stretchNone(ByVal sender As Object, ByVal e As RoutedEventArgs)
        vb1.Stretch = Stretch.None
        vb2.Stretch = Stretch.None
        vb3.Stretch = Stretch.None
        txt1.Text = "Stretch is now set to None."
    End Sub

    'Setting the Stretch property to Fill
    Private Sub stretchFill(ByVal sender As Object, ByVal e As RoutedEventArgs)
        vb1.Stretch = Stretch.Fill
        vb2.Stretch = Stretch.Fill
        vb3.Stretch = Stretch.Fill
        txt1.Text = "Stretch is now set to Fill."
    End Sub

    'Setting the Stretch property to Uniform
    Private Sub stretchUni(ByVal sender As Object, ByVal e As RoutedEventArgs)
        vb1.Stretch = Stretch.Uniform
        vb2.Stretch = Stretch.Uniform
        vb3.Stretch = Stretch.Uniform
        txt1.Text = "Stretch is now set to Uniform."
    End Sub

    'Setting the Stretch property to UniformToFill
    Private Sub stretchUniFill(ByVal sender As Object, ByVal e As RoutedEventArgs)
        vb1.Stretch = Stretch.UniformToFill
        vb2.Stretch = Stretch.UniformToFill
        vb3.Stretch = Stretch.UniformToFill
        txt1.Text = "Stretch is now set to UniformToFill."
    End Sub
    '</snippetViewBoxStretch>

    '<snippetViewBoxStretchDirection>
    'Setting the StretchDirection property to UpOnly
    Private Sub sdUpOnly(ByVal sender As Object, ByVal e As RoutedEventArgs)
        vb1.StretchDirection = StretchDirection.UpOnly
        vb2.StretchDirection = StretchDirection.UpOnly
        vb3.StretchDirection = StretchDirection.UpOnly
        txt2.Text = "StretchDirection is now UpOnly."
    End Sub

    'Setting the StretchDirection property to DownOnly
    Private Sub sdDownOnly(ByVal sender As Object, ByVal e As RoutedEventArgs)
        vb1.StretchDirection = StretchDirection.DownOnly
        vb2.StretchDirection = StretchDirection.DownOnly
        vb3.StretchDirection = StretchDirection.DownOnly
        txt2.Text = "StretchDirection is now DownOnly."
    End Sub

    'Setting the StretchDirection property to Both
    Private Sub sdBoth(ByVal sender As Object, ByVal e As RoutedEventArgs)
        vb1.StretchDirection = StretchDirection.Both
        vb2.StretchDirection = StretchDirection.Both
        vb3.StretchDirection = StretchDirection.Both
        txt2.Text = "StretchDirection is now Both."
    End Sub
    '</snippetViewBoxStretchDirection>
    '</snippetViewBoxCode>
End Class


