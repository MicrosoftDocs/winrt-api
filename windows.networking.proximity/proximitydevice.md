---
-api-id: T:Windows.Networking.Proximity.ProximityDevice
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class ProximityDevice : Windows.Networking.Proximity.IProximityDevice
-->

# Windows.Networking.Proximity.ProximityDevice

## -description
Enables you to publish messages to proximate devices or subscribe to messages from proximate devices.

## -remarks
The ProximityDevice class enables applications to communicate with running applications on devices, typically within a range of 3 centimeters to 4 centimeters.

You can create an instance of ProximityDevice by using the [GetDefault](proximitydevice_getdefault_846721868.md) or [FromId](proximitydevice_fromid_114571398.md) static method.

The ProximityDevice class uses publish/subscribe semantics and is useful for advertising and receiving small blocks of data. For larger amounts of data, or for persistent communications, use the [PeerFinder](peerfinder.md) and [StreamSocket](../windows.networking.sockets/streamsocket_streamsocket_1221375020.md) classes. For UWP apps, publications and subscriptions are active only if the calling app is in the foreground.



> [!IMPORTANT]
> The proximity APIs do not provide authentication, encryption, or message integrity. Do not use proximity to exchange user sensitive information such as passwords, financial data, text messages, email, photographs, or government id numbers.

## -examples


[!code-csharp[ArriveDepart](../windows.networking.proximity/code/ProximityReferenceSample/csharp/MainPage.xaml.cs#SnippetArriveDepart)]

[!code-vb[ArriveDepart](../windows.networking.proximity/code/ProximityReferenceSample/vbnet/MainPage.xaml.vb#SnippetArriveDepart)]

## -see-also

[Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_PROXIMITY [Windows Phone]
