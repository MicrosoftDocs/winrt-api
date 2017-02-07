---
-api-id: T:Windows.Devices.Usb.UsbReadOptions
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.Usb.UsbReadOptions : uint
-->

# UsbReadOptions

## -description
Defines constants for configuration flags that can be set for a USB pipe that the host opens for a USB bulk IN endpoint.

## -enum-fields
### -field None:0
Clear all flags.

### -field AutoClearStall:1
Automatically clears a stalled pipe without stopping the data flow.

### -field OverrideAutomaticBufferManagement:2
Bypasses queuing and error handling to boost performance for multiple read requests. Read operations must be done in multiples of [MaxPacketSize](usbbulkinendpointdescriptor_maxpacketsize.md).

### -field IgnoreShortPacket:4
The host does not complete a read request when a short packet is received. The read request is completed only when an error occurs, the request is canceled, or all requested bytes have been read.

### -field AllowPartialReads:8
Allows read requests from a device that returns more data than requested by the caller.


## -remarks

## -examples

## -see-also