Partial Public Class Page
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    ' <Snippettransforms_ovw_interactive_transforms_code>
    Private Sub HandlePointerPressed(ByVal sender As Object, ByVal e As PointerRoutedEventArgs)
        ' Increase ScaleX and ScaleY by 25%.
        myScaleTransform.ScaleX = (myScaleTransform.ScaleX * 1.25)
        myScaleTransform.ScaleY = (myScaleTransform.ScaleY * 1.25)
    End Sub
    ' </Snippettransforms_ovw_interactive_transforms_code>
End Class