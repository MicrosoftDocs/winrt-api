---
-api-id: M:Windows.Networking.Proximity.ProximityDevice.FromId(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Networking.Proximity.ProximityDevice FromId(System.String deviceId)
-->

# Windows.Networking.Proximity.ProximityDevice.FromId

## -description
Creates an instance of a [ProximityDevice](proximitydevice.md) class and activates the specified proximity device interface.

## -parameters
### -param deviceId
The [DeviceInformation Id](../windows.devices.enumeration/deviceinformation_id.md) of a proximity device.

## -returns
A new [ProximityDevice](proximitydevice.md) that uses the specified proximity device interface. Throws a **System.IO.FileNotFoundException** exception if the specified proximity device interface isunavailable.

## -remarks
You can enumerate proximity devices by passing the class selection string returned by the [GetDeviceSelector](proximitydevice_getdeviceselector_838466080.md) method to the [FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync_1257462890.md) or [CreateWatcher](../windows.devices.enumeration/deviceinformation_createwatcher_1506431823.md) method. You can then use the resulting [DeviceInformation Id](../windows.devices.enumeration/deviceinformation_id.md) value(s) to create an instance of a [ProximityDevice](proximitydevice.md) using the [FromId](proximitydevice_fromid_114571398.md) method.

## -examples


[!code-csharp[GetDeviceSelector](../windows.networking.proximity/code/Proximity_GetDeviceSelector1/csharp/MainPage.xaml.cs#SnippetGetDeviceSelector)]

[!code-js[GetDeviceSelector](../windows.networking.proximity/code/Proximity_GetDeviceSelector1/javascript/default.js#SnippetGetDeviceSelector)]

[!code-vb[GetDeviceSelector](../windows.networking.proximity/code/Proximity_GetDeviceSelector1/vbnet/MainPage.xaml.vb#SnippetGetDeviceSelector)]

## -see-also
[Proximity and Tapping (JavaScript)](http://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), [Proximity and Tapping (C#/VB/C++)](http://msdn.microsoft.com/library/f25bb1df-1cfd-45cd-8c67-04eec73ebfbd), [Proximity sample](http://go.microsoft.com/fwlink/p/?linkid=245082)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_PROXIMITY [Windows Phone]
