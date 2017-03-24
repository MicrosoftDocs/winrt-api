---
-api-id: M:Windows.Networking.Proximity.ProximityDevice.GetDeviceSelector
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public string GetDeviceSelector()
-->

# Windows.Networking.Proximity.ProximityDevice.GetDeviceSelector

## -description
Returns the class selection string that you can use to enumerate proximity devices.

## -returns
The class selection string for proximity devices.

## -remarks
You can enumerate proximity devices by passing the class selection string returned by the [GetDeviceSelector](proximitydevice_getdeviceselector.md) method to the [FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync.md) or [CreateWatcher](../windows.devices.enumeration/deviceinformation_createwatcher.md) method.

If your computer supports Proximity and has an NFC device installed, which is commonly the case, then the [GetDefault](proximitydevice_getdefault.md) method will return the device that supports NFC. You can also determine whether your computer has an NFC device installed by querying the device information for the property "{FB3842CD-9E2A-4F83-8FCC-4B0761139AE9} 2". In the [DeviceInformation.Properties](../windows.devices.enumeration/deviceinformation_properties.md) object returned from the query the value for the "{FB3842CD-9E2A-4F83-8FCC-4B0761139AE9} 2" key contains and array of strings that describe the capabilities of the proximity device. If one of the strings is "StandardNfc", then the device supports NFC protocols such as NDEF. For more information on how to query for the properties of a device, see [How to retrieve additional properties for a device or PnP object](http://msdn.microsoft.com/library/74e2a9c2-9551-45a9-8de1-71a425dab3d3).

## -examples


[!code-csharp[GetDeviceSelector](../windows.networking.proximity/code/Proximity_GetDeviceSelector1/csharp/MainPage.xaml.cs#SnippetGetDeviceSelector)]

[!code-js[GetDeviceSelector](../windows.networking.proximity/code/Proximity_GetDeviceSelector1/javascript/default.js#SnippetGetDeviceSelector)]

[!code-vb[GetDeviceSelector](../windows.networking.proximity/code/Proximity_GetDeviceSelector1/vbnet/MainPage.xaml.vb#SnippetGetDeviceSelector)]

## -see-also
[DeviceId](proximitydevice_deviceid.md), [Proximity and Tapping (JavaScript)](http://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), [Proximity and Tapping (C#/VB/C++)](http://msdn.microsoft.com/library/f25bb1df-1cfd-45cd-8c67-04eec73ebfbd), [Proximity sample](http://go.microsoft.com/fwlink/p/?linkid=245082)

## -capabilities
proximity, ID_CAP_PROXIMITY [Windows Phone]
 ID_CAP_PROXIMITY [Windows Phone]
