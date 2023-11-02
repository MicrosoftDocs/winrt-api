---
-api-id: M:Windows.Devices.AllJoyn.AllJoynBusAttachment.GetAboutDataAsync(Windows.Devices.AllJoyn.AllJoynServiceInfo)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax.
public IAsyncOperation<AllJoynAboutDataView> AllJoynBusAttachment.GetAboutDataAsync(AllJoynServiceInfo serviceInfo)
-->

# Windows.Devices.AllJoyn.AllJoynBusAttachment.GetAboutDataAsync

## -description

> [!IMPORTANT]
> The types in the **Windows.Devices.AllJoyn** namespace are deprecated, and might not be available in future versions of Windows. [AllJoyn](https://openconnectivity.org/technology/reference-implementation/alljoyn/)&mdash;sponsored by AllSeen Alliance&mdash;was an open-source discovery and communication protocol for Internet of Things (IoT) scenarios such as turning lights on and off, and reading temperatures. For alternatives, such as [IoTivity Lite](https://github.com/iotivity/iotivity-lite) and [IoTivity](https://github.com/iotivity/iotivity), refer to the [iotivity.org](https://iotivity.org/) website.

Gets the About data for a specific AllJoyn endpoint. This method is intended to replace the less intuitive static [AllJoynAboutDataView.GetDataBySessionPortAsync()](alljoynaboutdataview_getdatabysessionportasync_660342083.md).

## -parameters

### -param serviceInfo
The AllJoyn endpoint from which to retrieve About data.

## -returns

## -remarks
This method makes acquiring About data more intuitive than it was in previous Windows releases.

## -see-also
[GetAboutDataAsync(AllJoynServiceInfo serviceInfo, Language language)](alljoynbusattachment_getaboutdataasync_522145388.md)

## -examples

## -capabilities
allJoyn
