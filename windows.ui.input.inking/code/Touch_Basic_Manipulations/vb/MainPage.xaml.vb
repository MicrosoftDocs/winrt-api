Imports Windows.UI.Xaml.Media

' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
''' 
Public NotInheritable Class MainPage
    Inherits Page
    ' <SnippetGlobals>
    ' Global translation transform used for changing the position of 
    ' the Rectangle based on input data from the touch contact.
    Private dragTranslation As TranslateTransform
    ' </SnippetGlobals>

    ' <SnippetInitialize>
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Listener for the ManipulationDelta event.
        AddHandler touchRectangle.ManipulationDelta,
            AddressOf testRectangle_ManipulationDelta
        ' New translation transform populated in 
        ' the ManipulationDelta handler.
        dragTranslation = New TranslateTransform()
        ' Apply the translation to the Rectangle.
        touchRectangle.RenderTransform = dragTranslation

    End Sub
    ' </SnippetInitialize>

    ' <SnippettestRectangle_ManipulationDelta>
    ' Handler for the ManipulationDelta event.
    ' ManipulationDelta data Is loaded into the
    ' translation transform And applied to the Rectangle.
    Private Sub testRectangle_ManipulationDelta(
        sender As Object,
        e As ManipulationDeltaRoutedEventArgs)

        ' Move the rectangle.
        dragTranslation.X = (dragTranslation.X + e.Delta.Translation.X)
        dragTranslation.Y = (dragTranslation.Y + e.Delta.Translation.Y)

    End Sub
    ' </SnippettestRectangle_ManipulationDelta>

End Class
