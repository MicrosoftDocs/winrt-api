---
-api-id: T:Windows.Devices.Usb.UsbBulkInPipe
-api-type: winrt class
---

<!-- Class syntax.
public class UsbBulkInPipe : Windows.Devices.Usb.IUsbBulkInPipe
-->

# Windows.Devices.Usb.UsbBulkInPipe

## -description
Represents the pipe that the underlying USB driver opens to communicate with a USB bulk IN endpoint of the device. The app can get an input stream from the pipe and access data is being read from the endpoint.

## -remarks


This code example shows how to read data from a bulk IN pipe. The example assumes that the app has previously obtained the [UsbDevice](usbdevice.md) object.

```csharp
UsbDevice device;
UInt32 readLen = 8;

// Get the UsbDevice object. Not shown.

...
            
UsbBulkInPipe bulkIn = device.DefaultInterface.BulkInPipes[0];

DataReader reader = new DataReader(bulkIn.InputStream);
            
await reader.LoadAsync(readLen);
            
UInt64 data = reader.ReadUInt64();
            
ShowData(data);

```



## -examples

## -see-also
