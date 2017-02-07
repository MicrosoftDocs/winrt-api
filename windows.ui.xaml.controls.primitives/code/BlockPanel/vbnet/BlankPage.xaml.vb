' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
NotInheritable Public Class BlankPage
    Inherits Page

    ''' <summary>
    ''' Invoked when this page is about to be displayed in a Frame.
    ''' </summary>
    ''' <param name="e">Event data that describes how this page was reached.  The Parameter
    ''' property is typically used to configure the page.</param>
    Protected Overrides Sub OnNavigatedTo(e As Navigation.NavigationEventArgs)
    
    End Sub

End Class
Public Class BlockPanel
    Inherits Panel
    Public Sub New()
        MyBase.New()
    End Sub
    '<Snippet1> 
    'First measure all children and return available size of panel 
    Protected Overrides Function MeasureOverride(ByVal availableSize As Size) As Size
        'Measure first 9 children giving them space up to 100x100, remaining children get 0x0 
        Dim i As Integer = 0
        For Each child As FrameworkElement In Children
            If i < 9 Then
                child.Measure(New Size(100, 100))
            Else
                child.Measure(New Size(0, 0))
            End If
            i += 1
        Next
        'return the size available to the whole panel, which is 300x300 
        Return New Size(300, 300)
    End Function
    '</Snippet1> 
    '<Snippet2> 
    'Second arrange all children and return final size of panel 
    Protected Overrides Function ArrangeOverride(ByVal finalSize As Size) As Size
        'Get the collection of children 
        Dim mychildren As UIElementCollection = Children
        'Get total number of children 
        Dim count As Integer = mychildren.Count
        'Arrange children 
        'only allowing 9 children in this panel. More children will get a 0x0 layout slot. 
        Dim i As Integer
        For i = 0 To 8
            'Get (left, top) origin point for the element in the 3x3 block 
            Dim cellOrigin As Point = GetOrigin(i, 3, New Size(100, 100))
            'Arrange child 
            'Get desired height and width. This will not be larger than 100x100 as set in MeasureOverride. 
            Dim dw As Double = mychildren(i).DesiredSize.Width
            Dim dh As Double = mychildren(i).DesiredSize.Height
            mychildren(i).Arrange(New Rect(cellOrigin.X, cellOrigin.Y, dw, dh))
        Next
        For i = 9 To count - 1
            'Give the remaining children a 0x0 layout slot 
            mychildren(i).Arrange(New Rect(0, 0, 0, 0))
        Next
        'Return final size of the panel 
        Return New Size(300, 300)
    End Function
    'Calculate point origin of the Block you are in 
    Protected Function GetOrigin(ByVal blockNum As Integer, ByVal blocksPerRow As Integer, ByVal itemSize As Size) As Point
        'Get row number (zero-based) 
        Dim row As Integer = CInt(Math.Floor(blockNum / blocksPerRow))
        'Get column number (zero-based) 
        Dim column As Integer = blockNum - blocksPerRow * row
        'Calculate origin 
        Dim origin As New Point(itemSize.Width * column, itemSize.Height * row)
        Return origin
    End Function
    '</Snippet2> 
End Class
