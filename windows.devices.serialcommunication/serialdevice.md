---
-api-id: T:Windows.Devices.SerialCommunication.SerialDevice
-api-type: winrt class
---

<!-- Class syntax.
public class SerialDevice : Windows.Devices.SerialCommunication.ISerialDevice, Windows.Foundation.IClosable
-->

# Windows.Devices.SerialCommunication.SerialDevice

## -description
Represents a serial port. The object provides methods and properties that an app can use to find and interact with serials ports on the system.

## -remarks
The serial device capability, `serialCommunication`, is required to use the `SerialDevice` class. For more information, see [Windows.Devices.SerialCommunication](windows_devices_serialcommunication.md).


**Create a SerialDevice object**

1. Generate an Advanced Query Syntax (AQS) string that contains search criteria for finding the device in the enumerated device collection. If you have the vendor and product identifiers, call [GetDeviceSelectorFromUsbVidPid](serialdevice_getdeviceselectorfromusbvidpid_2128196110.md).
1. Pass the retrieved string to [FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync_1257462890.md). The call retrieves a [DeviceInformationCollection](../windows.devices.enumeration/deviceinformationcollection.md) object.
1. Loop through the collection. Each iteration gets a [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) object.
1. Get the [DeviceInformation.Id](../windows.devices.enumeration/deviceinformation_id.md) property value. The string value is the device interface path. (e.g `\\?\usb#vid_03eb&pid_2157&mi_01#7&1435ec7f&0&0001#{86e0d1e0-8089-11d0-9ce4-08003e301f73}`).
1. Call [FromIdAsync](serialdevice_fromidasync_1322863552.md) by passing the device interface string and get the `SerialDevice` object.  If this throws an exception or returns null, it is likely:
    + The device interface path is invalid
    + The device interface path does not respresent a serial device
    + Application is missing the `serialCommunication` capability
    + The serial device is inaccessible. (see [Windows.Devices.SerialCommunication](windows_devices_serialcommunication.md))


**Read and write data**

You can then use the SerialDevice object to read from or write to the serial port by using the [Windows.Storage.Streams](../windows.storage.streams/windows_storage_streams.md) namespace.
1. Obtain a reference to the input stream by getting the [SerialDevice.InputStream](serialdevice_inputstream.md) property.
1. Create a [DataReader](../windows.storage.streams/datareader.md) object by specifying the input stream in the [DataReader](../windows.storage.streams/datareader_datareader_25787062.md) constructor.
1. Obtain a reference to the output stream by getting the [SerialDevice.OutputStream](serialdevice_outputstream.md) property.
1. Create a [DataWriter](../windows.storage.streams/datawriter.md) object by specifying the output stream in the [DataWriter](../windows.storage.streams/datawriter_datawriter_1221375020.md) constructor.

## -examples

```csharp

using System;
using Windows.Devices.Enumeration;
using Windows.Devices.SerialCommunication;
using Windows.Storage.Streams;

...

DeviceInformationCollection serialDeviceInfos = await DeviceInformation.FindAllAsync(SerialDevice.GetDeviceSelector());

foreach (DeviceInformation serialDeviceInfo in serialDeviceInfos)
{
    try
    {
        SerialDevice serialDevice = await SerialDevice.FromIdAsync(serialDeviceInfo.Id);

        if (serialDevice != null)
        {
            // Found a valid serial device.

            // Reading a byte from the serial device.
            DataReader dr = new DataReader(serialDevice.InputStream);
            int readByte = dr.ReadByte();

            // Writing a byte to the serial device.
            DataWriter dw = new DataWriter(serialDevice.OutputStream);
            dw.WriteByte(0x42);
        }
    }
    catch (Exception)
    {
        // Couldn't instantiate the device
    }
}
```

## -see-also
[Custom serial device sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CustomSerialDeviceAccess), [Serial arduino sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SerialArduino)
