Imports System.Windows.Media.Imaging



Partial Public Class MainPage
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
    End Sub
    '<SnippetXAML>
    'Set the xamlTb TextBox with the current XAML of the RichTextBox and make it visible. Any changes to the XAML made 
    'in xamlTb is also reflected back on the RichTextBox. Note that the Xaml string returned by RichTextBox.Xaml will 
    'not include any UIElement contained in the current RichTextBox. Hence the UIElements will be lost when you 
    'set the Xaml back again from the xamlTb to the RichTextBox.

    Public Sub btnMarkUp_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        If btnMarkUp.IsChecked.Value Then
            xamlTb.Visibility = System.Windows.Visibility.Visible
            xamlTb.IsTabStop = True
            xamlTb.Text = rtb.Xaml
        Else
            rtb.Xaml = xamlTb.Text
            xamlTb.Visibility = System.Windows.Visibility.Collapsed
            xamlTb.IsTabStop = False

        End If
    End Sub
    '</SnippetXAML>

    '<SnippetImage>
    'Insert an image into the RichTextBox
    Private Sub btnImage_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim container As InlineUIContainer = New InlineUIContainer
        container.Child = MainPage.createImageFromUri(New Uri("/RichNotepad;component/images/Desert.jpg", UriKind.RelativeOrAbsolute), 200, 150)
        rtb.Selection.Insert(container)
        'ReturnFocus()
    End Sub

    Private Shared Function createImageFromUri(ByVal URI As Uri, ByVal width As Double, ByVal height As Double) As Image
        Dim img As Image = New Image
        img.Stretch = Stretch.Uniform
        img.Width = width
        img.Height = height
        Dim bi As BitmapImage = New BitmapImage(URI)
        img.Source = bi
        img.Tag = bi.UriSource.ToString
        Return img
    End Function
    '</SnippetImage>


End Class