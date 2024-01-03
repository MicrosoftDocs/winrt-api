---
-api-id: M:Windows.Devices.AllJoyn.AllJoynBusAttachment.GetDefault
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Devices.AllJoyn.AllJoynBusAttachment GetDefault()
-->

# Windows.Devices.AllJoyn.AllJoynBusAttachment.GetDefault

## -description

> [!IMPORTANT]
> The types in the **Windows.Devices.AllJoyn** namespace are deprecated, and might not be available in future versions of Windows. [AllJoyn](https://openconnectivity.org/technology/reference-implementation/alljoyn/)&mdash;sponsored by AllSeen Alliance&mdash;was an open-source discovery and communication protocol for Internet of Things (IoT) scenarios such as turning lights on and off, and reading temperatures. For alternatives, such as [IoTivity Lite](https://github.com/iotivity/iotivity-lite) and [IoTivity](https://github.com/iotivity/iotivity), refer to the [iotivity.org](https://iotivity.org/) website.

Gets the default [AllJoynBusAttachment](alljoynbusattachment.md) as defined by the app's manifest.

## -returns
The default bus attachment.

## -remarks
This method is thread-safe, and each call of it is guarenteed to return the same bus attachment instance.

## -examples

## -see-also

## -capabilities
allJoyn
