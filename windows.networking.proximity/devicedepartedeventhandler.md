---
-api-id: T:Windows.Networking.Proximity.DeviceDepartedEventHandler
-api-type: winrt delegate
-api-device-family-note: xbox
---
<!-- Delegate syntax.
public delegate void DeviceDepartedEventHandler(Windows.Networking.Proximity.ProximityDevice sender)
-->
# Windows.Networking.Proximity.DeviceDepartedEventHandler

## -description
Describes the method that handles the [DeviceDeparted](proximitydevice_devicedeparted.md) event.

## -parameters
### -param sender
The proximity device that raised the [DeviceDeparted](proximitydevice_devicedeparted.md) event.


## -remarks


## -examples


[!code-csharp[ArriveDepart](../windows.networking.proximity/code/ProximityReferenceSample/csharp/MainPage.xaml.cs#SnippetArriveDepart)]

[!code-vb[ArriveDepart](../windows.networking.proximity/code/ProximityReferenceSample/vbnet/MainPage.xaml.vb#SnippetArriveDepart)]

## -see-also

[Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_PROXIMITY [Windows Phone]
