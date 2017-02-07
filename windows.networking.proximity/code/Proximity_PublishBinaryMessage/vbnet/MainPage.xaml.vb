' The Blank Page item template is documented at http:'go.microsoft.com/fwlink/?LinkId=234238

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

    End Sub

    ' <SnippetLaunchAppWriteTag1>
    Private proximityDevice As Windows.Networking.Proximity.ProximityDevice

    Private Sub PublishLaunchApp()
        proximityDevice = Windows.Networking.Proximity.ProximityDevice.GetDefault()
 
   	If proximityDevice IsNot Nothing Then
            ' The format of the app launch string is: "<args>" & vbTab & "Windows" vbTab & "<AppName>".
            ' The string is tab or null delimited.

            ' The <args> string must have at least one character.
            Dim launchArgs = "user=default"

            ' The format of the AppName is: PackageFamilyName!PRAID.
            Dim praid = "MyAppId" ' The Application Id value from your package.appxmanifest.

            Dim appName = Windows.ApplicationModel.Package.Current.Id.FamilyName & "!" & praid

            Dim launchAppMessage = launchArgs & vbTab & "Windows" & vbTab & appName

            Dim dataWriter = New Windows.Storage.Streams.DataWriter()
            dataWriter.UnicodeEncoding = Windows.Storage.Streams.UnicodeEncoding.Utf16LE
            dataWriter.WriteString(launchAppMessage)
            Dim launchAppPubId =
               proximityDevice.PublishBinaryMessage(
                  "LaunchApp:WriteTag", dataWriter.DetachBuffer(),
                  AddressOf proximityWriteTagLaunchAppMessageTransmitCallback)
        End If
    End Sub

    Private Sub proximityWriteTagLaunchAppMessageTransmitCallback(
        sender As Windows.Networking.Proximity.ProximityDevice,
        messageId As Long)
        ' The LaunchApp message has been successfully written to a tag.
    End Sub
    ' </SnippetLaunchAppWriteTag1>

End Class

Class Exclude
    ' <SnippetLaunchAppWriteTag2>
    Private proximityDevice As Windows.Networking.Proximity.ProximityDevice

    Private Sub PublishLaunchApp()
        proximityDevice = Windows.Networking.Proximity.ProximityDevice.GetDefault()

   	If proximityDevice IsNot Nothing Then
            ' The format of the app launch string is: "<args>" & vbTab & "Windows" vbTab & "<AppName>".
            ' The string is tab or null delimited.

            ' The <args> string must have at least one character.
            Dim launchArgs = "user=default"

            ' The format of the AppName is: PackageFamilyName!PRAID.
            Dim praid = "MyAppId" ' The Application Id value from your package.appxmanifest.

            Dim appName = Windows.ApplicationModel.Package.Current.Id.FamilyName & "!" & praid

            Dim launchAppMessage = launchArgs & vbTab & "Windows" & vbTab & appName

            Dim dataWriter = New Windows.Storage.Streams.DataWriter()
            dataWriter.UnicodeEncoding = Windows.Storage.Streams.UnicodeEncoding.Utf16LE
            dataWriter.WriteString(launchAppMessage)
            Dim launchAppPubId =
               proximityDevice.PublishBinaryMessage(
                  "LaunchApp:WriteTag", dataWriter.DetachBuffer())
        End If
    End Sub
    ' </SnippetLaunchAppWriteTag2>
End Class
