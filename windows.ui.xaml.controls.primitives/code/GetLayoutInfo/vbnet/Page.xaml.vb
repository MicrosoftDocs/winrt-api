Imports System.Windows.Controls.Primitives

Partial Public Class Page
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    '<Snippet2> 
    Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        'Get Layout Slot of Rectangle 
        Dim r1 As Rect = LayoutInformation.GetLayoutSlot(rect1)
        Dim rg1 As New RectangleGeometry()
        rg1.Rect = r1
        Dim mypath As New Path()
        mypath.Data = rg1
        mypath.Stroke = New SolidColorBrush(Colors.Black)
        mypath.StrokeThickness = 4
        LayoutRoot.Children.Add(mypath)
    End Sub
    '</Snippet2> 


End Class

