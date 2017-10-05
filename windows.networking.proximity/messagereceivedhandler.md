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

[!code-js[PublishSubscribe](../windows.networking.proximity/code/ProximityReferenceSample/js/default.js#SnippetPublishSubscribe)]

[!code-vb[PublishSubscribe](../windows.networking.proximity/code/ProximityReferenceSample/vbnet/MainPage.xaml.vb#SnippetPublishSubscribe)]

## -see-also
[SubscribeForMessage](proximitydevice_subscribeformessage.md), [Proximity and Tapping (JavaScript)](http://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), [Proximity and Tapping (C#/VB/C++)](http://msdn.microsoft.com/library/f25bb1df-1cfd-45cd-8c67-04eec73ebfbd), [Proximity sample](http://go.microsoft.com/fwlink/p/?linkid=245082)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_PROXIMITY [Windows Phone]
