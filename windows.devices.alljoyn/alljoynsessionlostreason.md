---
-api-id: T:Windows.Devices.AllJoyn.AllJoynSessionLostReason
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.AllJoyn.AllJoynSessionLostReason : int
-->

# AllJoynSessionLostReason

## -description

> [!IMPORTANT]
> The types in the **Windows.Devices.AllJoyn** namespace are deprecated, and might not be available in future versions of Windows. [AllJoyn](https://openconnectivity.org/technology/reference-implementation/alljoyn/)&mdash;sponsored by AllSeen Alliance&mdash;was an open-source discovery and communication protocol for Internet of Things (IoT) scenarios such as turning lights on and off, and reading temperatures. For alternatives, such as [IoTivity Lite](https://github.com/iotivity/iotivity-lite) and [IoTivity](https://github.com/iotivity/iotivity), refer to the [iotivity.org](https://iotivity.org/) website.

Defines values used by [AllJoynSessionLostEventArgs](alljoynsessionlosteventargs.md) to indicate the reason for a lost session.

## -enum-fields
### -field None:0
No reason indicated.

### -field ProducerLeftSession:1
The Producer left the session.

### -field ProducerClosedAbruptly:2
The Producer closed the session unexpectedly.

### -field RemovedByProducer:3
The Consumer was removed from the session by the Producer.

### -field LinkTimeout:4
The connection supporting the session timed out.

### -field Other:5
The session was lost due to any other reason.


## -remarks

## -examples

## -see-also


## -capabilities
allJoyn
