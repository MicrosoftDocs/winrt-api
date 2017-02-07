Partial Public Class Page
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
        Rearrange()
    End Sub

    '<Snippet01> 
    Private Sub Rearrange()
        Dim TB4 As New TextBlock()
        TB4.Text = "Age"
        MyStackPanel.Children.Insert(2, TB4)
    End Sub
    '</Snippet01> 
End Class