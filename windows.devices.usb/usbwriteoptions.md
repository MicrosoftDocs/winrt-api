---
-api-id: T:Windows.Devices.Usb.UsbWriteOptions
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.Usb.UsbWriteOptions : uint
-->

# UsbWriteOptions

## -description
Defines constants for configuration flags that can be set for a USB pipe that the host opens for a USB OUT endpoint.

## -enum-fields
### -field None:0
Clear all flags.

### -field AutoClearStall:1
Automatically clears a stalled pipe without stopping the data flow.

### -field ShortPacketTerminate:2
Sends a zero length packet for a write request in which the buffer is a multiple of the maximum packet size supported by the endpoint.


## -remarks

## -examples

## -see-also