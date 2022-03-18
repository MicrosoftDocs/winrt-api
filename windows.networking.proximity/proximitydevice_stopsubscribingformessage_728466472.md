---
-api-id: M:Windows.Networking.Proximity.ProximityDevice.StopSubscribingForMessage(System.Int64)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void StopSubscribingForMessage(System.Int64 subscriptionId)
-->

# Windows.Networking.Proximity.ProximityDevice.StopSubscribingForMessage

## -description
Cancels a message subscription.

## -parameters
### -param subscriptionId
The subscription ID for the message.

## -remarks
The subscription ID for a message subscription is returned from the [SubscribeForMessage](proximitydevice_subscribeformessage_2022774312.md) method.

## -examples


[!code-csharp[PublishSubscribe](../windows.networking.proximity/code/ProximityReferenceSample/csharp/MainPage.xaml.cs#SnippetPublishSubscribe)]

[!code-vb[PublishSubscribe](../windows.networking.proximity/code/ProximityReferenceSample/vbnet/MainPage.xaml.vb#SnippetPublishSubscribe)]

## -see-also

[Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_PROXIMITY [Windows Phone]
