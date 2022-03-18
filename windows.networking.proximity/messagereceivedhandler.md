---
-api-id: T:Windows.Networking.Proximity.MessageReceivedHandler
-api-type: winrt delegate
-api-device-family-note: xbox
---
<!-- Delegate syntax.
public delegate void MessageReceivedHandler(Windows.Networking.Proximity.ProximityDevice sender, Windows.Networking.Proximity.ProximityMessage message)
-->
# Windows.Networking.Proximity.MessageReceivedHandler

## -description
Describes the method that will handle the event that's fired when a message that has been subscribed to has been received.

## -parameters
### -param sender
The proximity device that received the message.

### -param message
The message and related data that were passed to the event handler.


## -remarks


## -examples


[!code-csharp[PublishSubscribe](../windows.networking.proximity/code/ProximityReferenceSample/csharp/MainPage.xaml.cs#SnippetPublishSubscribe)]

[!code-vb[PublishSubscribe](../windows.networking.proximity/code/ProximityReferenceSample/vbnet/MainPage.xaml.vb#SnippetPublishSubscribe)]

## -see-also
[SubscribeForMessage](proximitydevice_subscribeformessage_2022774312.md), [Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_PROXIMITY [Windows Phone]
