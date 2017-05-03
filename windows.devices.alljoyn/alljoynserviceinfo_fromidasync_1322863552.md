---
-api-id: M:Windows.Devices.AllJoyn.AllJoynServiceInfo.FromIdAsync(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.AllJoyn.AllJoynServiceInfo> FromIdAsync(System.String deviceId)
-->

# Windows.Devices.AllJoyn.AllJoynServiceInfo.FromIdAsync

## -description
Converts a [DeviceInformation ID](https://docs.microsoft.com/uwp/api/Windows.Devices.Enumeration.DeviceInformation#Windows_Devices_Enumeration_DeviceInformation_Id) acquired by a device enumeration into an [AllJoynServiceInfo](alljoynserviceinfo.md) object.

## -parameters
### -param deviceId
The acquired [DeviceInformation ID](https://docs.microsoft.com/uwp/api/Windows.Devices.Enumeration.DeviceInformation#Windows_Devices_Enumeration_DeviceInformation_Id).

## -returns
The [AllJoynServiceInfo](alljoynserviceinfo.md) object corresponding to the ID. This object can be used to establish sessions with remote endpoints and to retrieve About data from them.

## -remarks

## -examples

## -see-also


## -capabilities
allJoyn