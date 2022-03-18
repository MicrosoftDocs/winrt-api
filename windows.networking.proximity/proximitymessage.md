---
-api-id: T:Windows.Networking.Proximity.ProximityMessage
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class ProximityMessage : Windows.Networking.Proximity.IProximityMessage
-->

# Windows.Networking.Proximity.ProximityMessage

## -description
Represents a message that's received from a subscription.

## -remarks
Messages published using the [PublishMessage](proximitydevice_publishmessage_1881696512.md), [PublishBinaryMessage](proximitydevice_publishbinarymessage_285088637.md), or [PublishUriMessage](proximitydevice_publishurimessage_632953271.md) methods and received by the [MessageReceivedEventHandler](messagereceivedhandler.md) passed to the [SubscribeForMessage](proximitydevice_subscribeformessage_2022774312.md) method are of type ProximityMessage.

## -examples


[!code-csharp[PublishSubscribe](../windows.networking.proximity/code/ProximityReferenceSample/csharp/MainPage.xaml.cs#SnippetPublishSubscribe)]

[!code-vb[PublishSubscribe](../windows.networking.proximity/code/ProximityReferenceSample/vbnet/MainPage.xaml.vb#SnippetPublishSubscribe)]

## -see-also

[Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_PROXIMITY [Windows Phone]
