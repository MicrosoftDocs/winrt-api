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


Public Class Page
    Inherits UserControl

    '<SnippetScrollBarCode>
    Public Sub New()
        MyBase.New()
        InitializeComponent()
        CreateControls()
    End Sub

    Private Sub CreateControls()

        'Create stack panel
        Dim MyStackPanel As StackPanel = New StackPanel

        'Create the first text box
        Dim MyTB1 As TextBox = New TextBox
        MyTB1.Width = 300
        MyTB1.Height = 50
        MyTB1.Text = "A text box that demonstrates TextWrapping, TextAlignment, MaxLength and AcceptsReturn"
        MyTB1.TextWrapping = TextWrapping.Wrap
        MyTB1.TextAlignment = TextAlignment.Center
        MyTB1.MaxLength = 500
        MyTB1.AcceptsReturn = True
        MyTB1.Margin = New Thickness(20, 20, 0, 0)

        'Create the second text box
        Dim MyTB2 As TextBox = New TextBox
        MyTB2.Margin = New Thickness(20, 20, 0, 0)
        MyTB2.Text = "A text box that demonstrates HorizontalScrollBarVisibility and VerticalScrollBarVisibility"
        MyTB2.Width = 300
        MyTB2.Height = 50
        MyTB2.AcceptsReturn = True
        MyTB2.HorizontalScrollBarVisibility = ScrollBarVisibility.Visible
        MyTB2.VerticalScrollBarVisibility = ScrollBarVisibility.Visible

        'Add the text boxes to the stack panel
        MyStackPanel.Children.Add(MyTB1)
        MyStackPanel.Children.Add(MyTB2)
        Me.Content = MyStackPanel
    End Sub
    '</SnippetScrollBarCode>
End Class
