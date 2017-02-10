---
-api-id: T:Windows.Devices.Usb.UsbBulkInEndpointDescriptor
-api-type: winrt class
---

<!-- Class syntax.
public class UsbBulkInEndpointDescriptor : Windows.Devices.Usb.IUsbBulkInEndpointDescriptor
-->

# Windows.Devices.Usb.UsbBulkInEndpointDescriptor

## -description
The endpoint descriptor for a USB bulk IN endpoint. The descriptor specifies the endpoint type, direction, number and also the maximum number of bytes that can be read from the endpoint, in a single transfer.

## -remarks
**JavaScript (Usage)**



```
var descriptorBulkInEp = device.defaultInterface.descriptors.getAt(1);
var usbEndpointDescriptor = Windows.Devices.Usb.UsbEndpointDescriptor.parse(descriptorBulkInEp);
var usbBulkInEndpointDescriptor = usbEndpointDescriptor.asBulkInEndpointDescriptor();

```



## -examples

## -see-also
