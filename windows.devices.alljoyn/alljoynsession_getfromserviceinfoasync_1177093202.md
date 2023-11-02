---
-api-id: M:Windows.Devices.AllJoyn.AllJoynSession.GetFromServiceInfoAsync(Windows.Devices.AllJoyn.AllJoynServiceInfo,Windows.Devices.AllJoyn.AllJoynBusAttachment)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.AllJoyn.AllJoynSession> GetFromServiceInfoAsync(Windows.Devices.AllJoyn.AllJoynServiceInfo serviceInfo, Windows.Devices.AllJoyn.AllJoynBusAttachment busAttachment)
-->

# Windows.Devices.AllJoyn.AllJoynSession.GetFromServiceInfoAsync

## -description

> [!IMPORTANT]
> The types in the **Windows.Devices.AllJoyn** namespace are deprecated, and might not be available in future versions of Windows. [AllJoyn](https://openconnectivity.org/technology/reference-implementation/alljoyn/)&mdash;sponsored by AllSeen Alliance&mdash;was an open-source discovery and communication protocol for Internet of Things (IoT) scenarios such as turning lights on and off, and reading temperatures. For alternatives, such as [IoTivity Lite](https://github.com/iotivity/iotivity-lite) and [IoTivity](https://github.com/iotivity/iotivity), refer to the [iotivity.org](https://iotivity.org/) website.

Gets a session with the producer based on the specified service info and bus attachment.

## -parameters
### -param serviceInfo
The service info to acquire the correct session.

### -param busAttachment
The bus attachment to identify the AllJoyn session. If not specified, it is set to the result of [AllJoynBusAttachment.GetDefault](alljoynbusattachment_getdefault_846721868.md).

## -returns
An AllJoyn object for the AllJoyn session based off the service info.

## -remarks

## -examples

## -see-also
[GetFromServiceInfoAsync(AllJoynServiceInfo)](alljoynsession_getfromserviceinfoasync_1563007946.md)
## -capabilities
allJoyn
