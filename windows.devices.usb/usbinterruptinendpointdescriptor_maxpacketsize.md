---
-api-id: P:Windows.Devices.Usb.UsbInterruptInEndpointDescriptor.MaxPacketSize
-api-type: winrt property
---

<!-- Property syntax
public uint MaxPacketSize { get; }
-->

# Windows.Devices.Usb.UsbInterruptInEndpointDescriptor.MaxPacketSize

## -description
Gets the maximum number of bytes that can be sent to or received (in a packet) from this endpoint.

## -property-value
Indicates the maximum packet size of the endpoint. This value is the **wMaxPacketSize** field value of the endpoint descriptor. For information, see Table 9-13 in the Universal Serial Bus Specification (version 2.0) or Table 9-18 in the Universal Serial Bus 3.0 Specification.

## -remarks
The [MaxPacketSize](usbinterruptinendpointdescriptor_maxpacketsize.md) property value does not necessarily indicate the number of bytes that will be read at a time, in one interval.

## -examples

## -see-also
