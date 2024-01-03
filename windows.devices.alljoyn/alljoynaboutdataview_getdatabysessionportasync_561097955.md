---
-api-id: M:Windows.Devices.AllJoyn.AllJoynAboutDataView.GetDataBySessionPortAsync(System.String,Windows.Devices.AllJoyn.AllJoynBusAttachment,System.UInt16,Windows.Globalization.Language)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.AllJoyn.AllJoynAboutDataView> GetDataBySessionPortAsync(System.String uniqueName, Windows.Devices.AllJoyn.AllJoynBusAttachment busAttachment, System.UInt16 sessionPort, Windows.Globalization.Language language)
-->

# Windows.Devices.AllJoyn.AllJoynAboutDataView.GetDataBySessionPortAsync

## -description

> [!IMPORTANT]
> The types in the **Windows.Devices.AllJoyn** namespace are deprecated, and might not be available in future versions of Windows. [AllJoyn](https://openconnectivity.org/technology/reference-implementation/alljoyn/)&mdash;sponsored by AllSeen Alliance&mdash;was an open-source discovery and communication protocol for Internet of Things (IoT) scenarios such as turning lights on and off, and reading temperatures. For alternatives, such as [IoTivity Lite](https://github.com/iotivity/iotivity-lite) and [IoTivity](https://github.com/iotivity/iotivity), refer to the [iotivity.org](https://iotivity.org/) website.

Gets the About data for a session in a particular language.

## -parameters
### -param uniqueName
The unique name.

### -param busAttachment
The bus attachment supporting the session.

### -param sessionPort
The port used to connect to the session.

### -param language
The language to return the descriptive data in.

## -returns
An object containing About data for the session in the set language.

## -remarks

## -examples

## -see-also
[GetDataBySessionPortAsync(String, AllJoynBusAttachment, UInt16)](alljoynaboutdataview_getdatabysessionportasync_660342083.md)

## -capabilities
allJoyn
