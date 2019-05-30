---
-api-id: P:Windows.Networking.Proximity.ProximityDevice.DeviceId
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public string DeviceId { get; }
-->

# Windows.Networking.Proximity.ProximityDevice.DeviceId

## -description
Gets the [DeviceInformation Id](../windows.devices.enumeration/deviceinformation_id.md) for a proximity device.

## -property-value
The [DeviceInformation Id](../windows.devices.enumeration/deviceinformation_id.md) for a proximity device.

## -remarks
If your computer supports Proximity and has an NFC device installed, which is commonly the case, then the [GetDefault](proximitydevice_getdefault_846721868.md) method will return the device that supports NFC. You can also determine whether your computer has an NFC device installed by querying the device information for the property "{FB3842CD-9E2A-4F83-8FCC-4B0761139AE9} 2". In the [DeviceInformation.Properties](../windows.devices.enumeration/deviceinformation_properties.md) object returned from the query the value for the "{FB3842CD-9E2A-4F83-8FCC-4B0761139AE9} 2" key contains and array of strings that describe the capabilities of the proximity device. If one of the strings is "StandardNfc", then the device supports NFC protocols such as NDEF. For more information on how to query for the properties of a device, see [How to retrieve additional properties for a device or PnP object](https://docs.microsoft.com/previous-versions/windows/apps/hh464997(v=win.10)).

## -examples


[!code-csharp[DeviceId](../windows.networking.proximity/code/Proximity_GetDeviceSelector1/csharp/MainPage.xaml.cs#SnippetDeviceId)]

[!code-js[DeviceId](../windows.networking.proximity/code/Proximity_GetDeviceSelector1/javascript/default.js#SnippetDeviceId)]

[!code-vb[DeviceId](../windows.networking.proximity/code/Proximity_GetDeviceSelector1/vbnet/MainPage.xaml.vb#SnippetDeviceId)]

## -see-also
[Proximity and Tapping (JavaScript)](https://docs.microsoft.com/previous-versions/windows/apps/hh465229(v=win.10)), [Proximity and Tapping (C#/VB/C++)](https://docs.microsoft.com/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://go.microsoft.com/fwlink/p/?linkid=245082)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_PROXIMITY [Windows Phone]
