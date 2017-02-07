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


    ' <SnippetInitialize_CS>
    Private proximityDevice As Windows.Networking.Proximity.ProximityDevice

    Public Sub New()
        proximityDevice = Windows.Networking.Proximity.ProximityDevice.GetDefault()

        If proximityDevice IsNot Nothing Then
            AddHandler proximityDevice.DeviceArrived, AddressOf ProximityDeviceArrived
            AddHandler proximityDevice.DeviceDeparted, AddressOf ProximityDeviceDeparted
        Else
            MessageTextBlock.Text &= "Failed to initialize proximity device." & vbCrLf
        End If
    End Sub
    ' </SnippetInitialize_CS>

    ' <SnippetEvents_CS>
    Private Async Sub ProximityDeviceArrived()
        Await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
                            Sub()
                                MessageTextBlock.Text &= "Proximate device arrived." & vbCrLf
                            End Sub)
    End Sub

    Private Async Sub ProximityDeviceDeparted()
        Await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
                    Sub()
                                MessageTextBlock.Text &= "Proximate device departed." & vbCrLf
                            End Sub)
    End Sub
    ' </SnippetEvents_CS>

End Class
