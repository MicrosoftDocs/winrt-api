' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    ''' <summary>
    ''' Invoked when this page is about to be displayed in a Frame.
    ''' </summary>
    ''' <param name="e">Event data that describes how this page was reached.  The Parameter
    ''' property is typically used to configure the page.</param>
    Protected Overrides Sub OnNavigatedTo(e As Navigation.NavigationEventArgs)
        InitializeProximity()
        QueryDeviceProperties()
    End Sub

    ' <SnippetGetDeviceSelector>
    Private proximityDevice As Windows.Networking.Proximity.ProximityDevice

    Private Async Sub InitializeProximity()
        Dim selectorString = Windows.Networking.Proximity.ProximityDevice.GetDeviceSelector()

        Dim deviceInfoCollection =
            Await Windows.Devices.Enumeration.DeviceInformation.FindAllAsync(selectorString, {"{FB3842CD-9E2A-4F83-8FCC-4B0761139AE9} 2"})

        If deviceInfoCollection.Count = 0 Then
            StatusTextBlock.Text = "No proximity devices found."
        Else
            StatusTextBlock.Text = "Proximity Device id = " & deviceInfoCollection(0).Id
            proximityDevice =
                Windows.Networking.Proximity.ProximityDevice.FromId(deviceInfoCollection(0).Id)
        End If
    End Sub
    '</SnippetGetDeviceSelector>

    ' <SnippetDeviceId>
    Private Async Sub QueryDeviceProperties()
        ' Include the proximity properties key
        Dim propertiesToRetrieve = New List(Of String) From {"{FB3842CD-9E2A-4F83-8FCC-4B0761139AE9} 2"}

        Dim defaultProximityDevice =
            Windows.Networking.Proximity.ProximityDevice.GetDefault()

        If defaultProximityDevice IsNot Nothing Then
            Dim devInfo = Await Windows.Devices.Enumeration.DeviceInformation.CreateFromIdAsync(
                defaultProximityDevice.DeviceId, propertiesToRetrieve)

            If devInfo.Properties.ContainsKey("{FB3842CD-9E2A-4F83-8FCC-4B0761139AE9} 2") Then
                Dim proximityCapabilities =
                    TryCast(devInfo.Properties("{FB3842CD-9E2A-4F83-8FCC-4B0761139AE9} 2"), String())

                If proximityCapabilities.Contains("StandardNfc") Then
                    ' This proximity device supports NFC
                End If
            End If
        End If
    End Sub
    ' </SnippetDeviceId>

End Class
