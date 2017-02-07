Imports Windows.UI.Xaml.Shapes

' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page
    ' <SnippetInitialize>
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Pointer event listeners.
        AddHandler touchRectangle.PointerPressed, AddressOf touchRectangle_PointerPressed
        AddHandler touchRectangle.PointerReleased, AddressOf Me.touchRectangle_PointerReleased
        AddHandler touchRectangle.PointerExited, AddressOf touchRectangle_PointerExited

    End Sub
    ' </SnippetInitialize>

    ' <SnippetEventHandlers>
    ' <SnippettouchRectangle_PointerExited>
    ' Handler for pointer exited event.
    Private Sub touchRectangle_PointerExited(sender As Object, e As PointerRoutedEventArgs)
        Dim rect As Rectangle = CType(sender, Rectangle)

        ' Pointer moved outside Rectangle hit test area.
        ' Reset the dimensions of the Rectangle.
        If (rect IsNot Nothing) Then
            rect.Width = 200
            rect.Height = 100
        End If
    End Sub

    ' </SnippettouchRectangle_PointerExited>
    ' <SnippettouchRectangle_PointerReleased>
    ' Handler for pointer released event.
    Private Sub touchRectangle_PointerReleased(sender As Object, e As PointerRoutedEventArgs)
        Dim rect As Rectangle = CType(sender, Rectangle)

        ' Reset the dimensions of the Rectangle.
        If (rect IsNot Nothing) Then
            rect.Width = 200
            rect.Height = 100
        End If
    End Sub
    ' </SnippettouchRectangle_PointerReleased>

    ' <SnippettouchRectangle_PointerPressed>
    ' Handler for pointer pressed event.
    Private Sub touchRectangle_PointerPressed(sender As Object, e As PointerRoutedEventArgs)
        Dim rect As Rectangle = CType(sender, Rectangle)

        ' Change the dimensions of the Rectangle.
        If (rect IsNot Nothing) Then
            rect.Width = 250
            rect.Height = 150
        End If
    End Sub
    ' </SnippettouchRectangle_PointerPressed>
    ' </SnippetEventHandlers>

End Class
