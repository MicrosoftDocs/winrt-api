Partial Public Class Page
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
    End Sub
    '<Snippet2_VB>
    Private Sub ListBox_SelectionChanged(ByVal sender As Object, ByVal e As SelectionChangedEventArgs)
        Dim lbi As ListBoxItem = CType(CType(sender, ListBox).SelectedItem, ListBoxItem)
        SelectDataTemplate(lbi.Content)

    End Sub

    Private Sub SelectDataTemplate(ByVal value As Object)
        Dim numberStr As String = CType(value, String)

        If Not numberStr Is Nothing Then
            Dim num As Integer

            Try
                num = Convert.ToInt32(numberStr)
            Catch
                Return
            End Try

            Dim template As DataTemplate


            ' Select one of the DataTemplate objects, based on the 
            ' value of the selected item in the ComboBox.
            If num Mod 2 <> 0 Then
                template = CType(rootStackPanel.Resources("oddNumberTemplate"), DataTemplate)
            Else
                template = CType(rootStackPanel.Resources("evenNumberTemplate"), DataTemplate)
            End If

            selectedItemDisplay.Child = CType(template.LoadContent(), UIElement)
            Dim tb As TextBlock = FindVisualChild(Of TextBlock)(selectedItemDisplay)
            tb.Text = numberStr

        End If
    End Sub

    Private Function FindVisualChild(Of childItem As DependencyObject) _
            (ByVal obj As DependencyObject) As childItem

        Dim i As Integer

        For i = 0 To VisualTreeHelper.GetChildrenCount(obj) - 1

            Dim child As DependencyObject = VisualTreeHelper.GetChild(obj, i)
            If ((Not child Is Nothing) And (TypeOf child Is childItem)) Then
                Return child
            End If

            Dim childOfChild As childItem = Me.FindVisualChild(Of childItem)(child)
            If (Not childOfChild Is Nothing) Then
                Return childOfChild
            End If

        Next i

        Return Nothing

    End Function
    '</Snippet2_VB>
End Class