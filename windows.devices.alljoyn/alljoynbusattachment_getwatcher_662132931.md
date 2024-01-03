---
-api-id: M:Windows.Devices.AllJoyn.AllJoynBusAttachment.GetWatcher(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Devices.Enumeration.DeviceWatcher GetWatcher(Windows.Foundation.Collections.IIterable<System.String> requiredInterfaces)
-->

# Windows.Devices.AllJoyn.AllJoynBusAttachment.GetWatcher

## -description

> [!IMPORTANT]
> The types in the **Windows.Devices.AllJoyn** namespace are deprecated, and might not be available in future versions of Windows. [AllJoyn](https://openconnectivity.org/technology/reference-implementation/alljoyn/)&mdash;sponsored by AllSeen Alliance&mdash;was an open-source discovery and communication protocol for Internet of Things (IoT) scenarios such as turning lights on and off, and reading temperatures. For alternatives, such as [IoTivity Lite](https://github.com/iotivity/iotivity-lite) and [IoTivity](https://github.com/iotivity/iotivity), refer to the [iotivity.org](https://iotivity.org/) website.

Creates a [DeviceWatcher](../windows.devices.enumeration/devicewatcher.md) that yields AllJoyn bus objects that implement the entire set of interfaces.

## -parameters
### -param requiredInterfaces
The required interfaces that must be implemented by the bus objects. This can be a **List** of **String**.

## -returns
The device watcher for the bus objects.

## -remarks

## -examples

## -see-also

## -capabilities
allJoyn
