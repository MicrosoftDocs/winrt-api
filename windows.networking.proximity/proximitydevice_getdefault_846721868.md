---
-api-id: M:Windows.Networking.Proximity.ProximityDevice.GetDefault
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Networking.Proximity.ProximityDevice GetDefault()
-->

# Windows.Networking.Proximity.ProximityDevice.GetDefault

## -description
Creates an instance of a [ProximityDevice](proximitydevice.md) class and activates the default proximity provider.

## -returns
A new proximity device that uses the default proximity provider. Returns **NULL** if no proximity devices are installed.

## -remarks

## -examples


[!code-csharp[ArriveDepart](../windows.networking.proximity/code/ProximityReferenceSample/csharp/MainPage.xaml.cs#SnippetArriveDepart)]

[!code-vb[ArriveDepart](../windows.networking.proximity/code/ProximityReferenceSample/vbnet/MainPage.xaml.vb#SnippetArriveDepart)]

## -see-also

[Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_PROXIMITY [Windows Phone]
