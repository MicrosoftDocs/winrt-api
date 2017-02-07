Imports System.Windows.Controls.Primitives

Partial Public Class Page
    Inherits UserControl
    Public Sub New()
        InitializeComponent()
    End Sub
    ' <snippet11> 
    ' Create the popup object. 
    Private p As New Popup()
    Private Sub showPopup_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        ' Create some content to show in the popup. Typically you would 
        ' create a user control. 
        Dim border As New Border()
        border.BorderBrush = New SolidColorBrush(Colors.Black)
        border.BorderThickness = New Thickness(5)

        Dim panel1 As New StackPanel()
        panel1.Background = New SolidColorBrush(Colors.LightGray)

        Dim button1 As New Button()
        button1.Content = "Close"
        button1.Margin = New Thickness(5)
        AddHandler button1.Click, AddressOf button1_Click
        Dim textblock1 As New TextBlock()
        textblock1.Text = "The popup control"
        textblock1.Margin = New Thickness(5)
        panel1.Children.Add(textblock1)
        panel1.Children.Add(button1)
        border.Child = panel1

        ' Set the Child property of Popup to the border 
        ' which contains a stackpanel, textblock and button. 
        p.Child = border

        ' Set where the popup will show up on the screen. 
        p.VerticalOffset = 25
        p.HorizontalOffset = 25

        ' Open the popup. 
        p.IsOpen = True

    End Sub

    Private Sub button1_Click(ByVal sender As Object, _
        ByVal e As RoutedEventArgs)
        ' Close the popup. 
        p.IsOpen = False

    End Sub
    ' </snippet11> 
End Class
