Partial Public Class Page
    Inherits UserControl
    Public Sub New()
        InitializeComponent()
    End Sub

    '<snippet11> 
    Private Sub HandleCheck(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim rb As RadioButton = TryCast(sender, RadioButton)
        choiceTextBlock.Text = "You chose: " + rb.GroupName + ": " + rb.Name
    End Sub
    '</snippet11> 
End Class
