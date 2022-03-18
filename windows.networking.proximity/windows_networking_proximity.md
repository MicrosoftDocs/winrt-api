---
-api-id: N:Windows.Networking.Proximity
-api-type: winrt namespace
---

# Windows.Networking.Proximity

## -description

Contains classes that support connections between devices that are within close range.

## -remarks

You can use proximity to connect computers by using a simple tap gesture. If two computers come within 3 centimeters to 4 centimeters of each other, or are tapped together, the operating system of each computer detects the other computer. You can then connect the two computers to share content or publish and subscribe to messages. Proximity also supports discovery of peer devices via Wi-Fi Direct.

> [!IMPORTANT]
> The proximity APIs do not provide authentication, encryption, or message integrity. Do not use proximity to exchange user sensitive information such as passwords, financial data, text messages, email, photographs, or government id numbers.

## -examples
This example shows how you can use the [ProximityDevice](proximitydevice.md) class to determine when a device enters and leaves proximity.

[!code-csharp[ArriveDepart](../windows.networking.proximity/code/ProximityReferenceSample/csharp/MainPage.xaml.cs#SnippetArriveDepart)]

[!code-vb[ArriveDepart](../windows.networking.proximity/code/ProximityReferenceSample/vbnet/MainPage.xaml.vb#SnippetArriveDepart)]

## -see-also

[Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities

proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_PROXIMITY [Windows Phone]
