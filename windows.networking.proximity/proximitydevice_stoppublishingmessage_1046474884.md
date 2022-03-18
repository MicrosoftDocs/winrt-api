---
-api-id: M:Windows.Networking.Proximity.ProximityDevice.StopPublishingMessage(System.Int64)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void StopPublishingMessage(System.Int64 messageId)
-->

# Windows.Networking.Proximity.ProximityDevice.StopPublishingMessage

## -description
Stops publishing a message.

## -parameters
### -param messageId
The publication ID for the message.

## -remarks
The publication ID for a message is returned from the [PublishMessage](proximitydevice_publishmessage_1881696512.md), [PublishBinaryMessage](proximitydevice_publishbinarymessage_285088637.md), and [PublishUriMessage](proximitydevice_publishurimessage_632953271.md) methods.

## -examples


[!code-csharp[PublishSubscribe](../windows.networking.proximity/code/ProximityReferenceSample/csharp/MainPage.xaml.cs#SnippetPublishSubscribe)]

[!code-vb[PublishSubscribe](../windows.networking.proximity/code/ProximityReferenceSample/vbnet/MainPage.xaml.vb#SnippetPublishSubscribe)]

## -see-also

[Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_PROXIMITY [Windows Phone]
