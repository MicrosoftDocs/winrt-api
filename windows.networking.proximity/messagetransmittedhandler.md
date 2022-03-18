---
-api-id: T:Windows.Networking.Proximity.MessageTransmittedHandler
-api-type: winrt delegate
-api-device-family-note: xbox
---
<!-- Delegate syntax.
public delegate void MessageTransmittedHandler(Windows.Networking.Proximity.ProximityDevice sender, System.Int64 messageId)
-->
# Windows.Networking.Proximity.MessageTransmittedHandler

## -description
Describes the method that will handle the event that's fired when a published message has been transmitted.

## -parameters
### -param sender
The proximity device that published the message.

### -param messageId
The publication ID of the message.


## -remarks
Messages continue to be published until the [StopPublishingMessage](proximitydevice_stoppublishingmessage_1046474884.md) method is called or the [ProximityDevice](proximitydevice.md) on the publishing computer is released. Messages are delivered to all apps that have subscribed for the same message type.

When using the [PublishMessage](proximitydevice_publishmessage_1881696512.md) method, the only supported message type is one that begins with "Windows.". To publish messages using another message type, such as "WindowsMime." or "NDEF:WriteTag", you must use the [PublishBinaryMessage](proximitydevice_publishbinarymessage_285088637.md) method.

The MessageTransmittedHandler delegate is called each time a message is successfully transmitted to a device, regardless of whether any apps were subscribed to the message on that device.

## -examples


[!code-csharp[PublishSubscribe2](../windows.networking.proximity/code/ProximityReferenceSample/csharp/MainPage.xaml.cs#SnippetPublishSubscribe2)]

[!code-vb[PublishSubscribe2](../windows.networking.proximity/code/ProximityReferenceSample/vbnet/MainPage.xaml.vb#SnippetPublishSubscribe2)]

## -see-also
[PublishMessage(String, String, MessageTransmittedHandler)](proximitydevice_publishmessage_1989900324.md), [PublishBinaryMessage(String, IBuffer, MessageTransmittedHandler)](proximitydevice_publishbinarymessage_374148007.md), [PublishUriMessage(Uri, MessageTransmittedHandler)](proximitydevice_publishurimessage_652448219.md), [Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_PROXIMITY [Windows Phone]
