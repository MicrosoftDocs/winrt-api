---
-api-id: T:Windows.Devices.AllJoyn.AllJoynTrafficType
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.AllJoyn.AllJoynTrafficType : int
-->

# AllJoynTrafficType

## -description

> [!IMPORTANT]
> The types in the **Windows.Devices.AllJoyn** namespace are deprecated, and might not be available in future versions of Windows. [AllJoyn](https://openconnectivity.org/technology/reference-implementation/alljoyn/)&mdash;sponsored by AllSeen Alliance&mdash;was an open-source discovery and communication protocol for Internet of Things (IoT) scenarios such as turning lights on and off, and reading temperatures. For alternatives, such as [IoTivity Lite](https://github.com/iotivity/iotivity-lite) and [IoTivity](https://github.com/iotivity/iotivity), refer to the [iotivity.org](https://iotivity.org/) website.

Defines values used to indicate the type of data carried in session traffic.

## -enum-fields
### -field Unknown:0
Traffic type currently unknown.

### -field Messages:1
Message traffic.

### -field RawUnreliable:2
Unreliable (lossy) byte stream.

### -field RawReliable:4
Session carries a reliable byte stream.


## -remarks

## -examples

## -see-also


## -capabilities
allJoyn
