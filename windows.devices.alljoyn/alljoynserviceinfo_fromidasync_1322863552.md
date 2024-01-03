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

> [!IMPORTANT]
> The types in the **Windows.Devices.AllJoyn** namespace are deprecated, and might not be available in future versions of Windows. [AllJoyn](https://openconnectivity.org/technology/reference-implementation/alljoyn/)&mdash;sponsored by AllSeen Alliance&mdash;was an open-source discovery and communication protocol for Internet of Things (IoT) scenarios such as turning lights on and off, and reading temperatures. For alternatives, such as [IoTivity Lite](https://github.com/iotivity/iotivity-lite) and [IoTivity](https://github.com/iotivity/iotivity), refer to the [iotivity.org](https://iotivity.org/) website.

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
