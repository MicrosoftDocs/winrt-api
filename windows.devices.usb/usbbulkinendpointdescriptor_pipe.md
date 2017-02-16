---
-api-id: P:Windows.Devices.Usb.UsbBulkInEndpointDescriptor.Pipe
-api-type: winrt property
---

<!-- Property syntax
public Windows.Devices.Usb.UsbBulkInPipe Pipe { get; }
-->

# Windows.Devices.Usb.UsbBulkInEndpointDescriptor.Pipe

## -description
Gets the object that represents the pipe that the host opens to communicate with the bulk IN endpoint.

## -property-value
An [UsbBulkInPipe](usbbulkinpipe.md) object that is the pipe for the bulk IN endpoint.

## -remarks
If the alternate setting, which defines this bulk endpoint, is not currently selected, the property returns NULL.

## -examples

## -see-also
