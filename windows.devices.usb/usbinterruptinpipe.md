---
-api-id: T:Windows.Devices.Usb.UsbInterruptInPipe
-api-type: winrt class
---

<!-- Class syntax.
public class UsbInterruptInPipe : Windows.Devices.Usb.IUsbInterruptInPipe
-->

# Windows.Devices.Usb.UsbInterruptInPipe

## -description
Represents the pipe that the underlying USB driver opens to communicate with a USB interrupt IN endpoint of the device. The object also enables the app to specify an event handler. That handler that gets invoked when data is read from the endpoint.

## -remarks
When the app registers an event handler, the host controller polls the endpoint for data at regular intervals. That interval value can be obtained in the [Interval](usbinterruptinendpointdescriptor_interval.md) property.

## -examples

## -see-also
