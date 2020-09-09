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
Converts a [DeviceInformation ID](/uwp/api/Windows.Devices.Enumeration.DeviceInformation.Id) acquired by a device enumeration into an [AllJoynServiceInfo](alljoynserviceinfo.md) object.

## -parameters
### -param deviceId
The acquired [DeviceInformation ID](/uwp/api/Windows.Devices.Enumeration.DeviceInformation.Id).

## -returns
The [AllJoynServiceInfo](alljoynserviceinfo.md) object corresponding to the ID. This object can be used to establish sessions with remote endpoints and to retrieve About data from them.

## -remarks

## -examples

## -see-also


## -capabilities
allJoyn
