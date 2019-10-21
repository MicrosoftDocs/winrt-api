---
-api-id: T:Windows.Devices.SerialCommunication.SerialDevice
-api-type: winrt class
---

<!-- Class syntax.
public class SerialDevice : Windows.Devices.SerialCommunication.ISerialDevice, Windows.Foundation.IClosable
-->

# Windows.Devices.SerialCommunication.SerialDevice

## -description
Represents a serial port. The object provides methods and properties that an app can use to find the port (in the system).

## -remarks
The serial device capability, [&lt;DeviceCapability&gt;](https://docs.microsoft.com/uwp/schemas/appxpackage/appxmanifestschema/element-devicecapability), is required to use the SerialDevice class. For more info, see [Windows.Devices.SerialCommunication](windows_devices_serialcommunication.md).


**Create a SerialDevice object**

1. Get this information about the serial port.+ The COM port name that represents the serial port, such as "COM1". In Device Manager, open **Ports (COM &amp; LPT)**, the device node string indicates the port number.
+ If you are using a Serial-to-USB converter, the virtual COM port name such as "COM1" or the vendor and product identifiers of the converter. You can derive the identifiers from the **Hardware Ids** property in Device Manager. For example, if **Hardware Id** is "USB\VID_045E&amp;PID_078E", vendor ID is "0x045E" and product Id is "0x078E".

1. Generate an Advanced Query Syntax (AQS) string that contains search criteria for finding the device in the enumerated device collection. If you have the vendor and product identifiers, call [GetDeviceSelectorFromUsbVidPid](serialdevice_getdeviceselectorfromusbvidpid_2128196110.md).
1. Pass the retrieved string to [FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync_1257462890.md). The call retrieves a [DeviceInformationCollection](../windows.devices.enumeration/deviceinformationcollection.md) object.
1. Loop through the collection. Each iteration gets a [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) object.
1. Get the [DeviceInformation.Id](../windows.devices.enumeration/deviceinformation_id.md) property value. The string value is the device instance path. For example, PCI#VEN_9710&amp;DEV_9835&amp;SUBSYS_00011000&amp;REV_01\5&amp;338FDA70&amp;0&amp;20F0#CHILD0000.
1. Call [FromIdAsync](serialdevice_fromidasync_1322863552.md) by passing the device instance string and get the SerialDevice object.


**Read and write data**

You can then use the SerialDevice object to read from or write to the serial port by using the [Windows.Storage.Streams](../windows.storage.streams/windows_storage_streams.md) namespace.
1. Obtain a reference to the input stream by getting the [SerialDevice.InputStream](serialdevice_inputstream.md) property.
1. Create a [DataReader](../windows.storage.streams/datareader.md) object by specifying the input stream in the [DataReader](../windows.storage.streams/datareader_datareader_25787062.md) constructor.

1. Obtain a reference to the output stream by getting the [SerialDevice.OutputStream](serialdevice_outputstream.md) property.
1. Create a [DataWriter](../windows.storage.streams/datawriter.md) object by specifying the output stream in the [DataWriter](../windows.storage.streams/datawriter_datawriter_1221375020.md) constructor.


**Release the SerialDevice object**

After you are finished using the SerialDevice object, release it.

C++ apps must release the reference by using the delete keyword. C#/VB apps must call the SerialDevice.Dispose method. JavaScript apps must call [SerialDevice.Close](serialdevice_close_811482585.md).

## -examples

## -see-also
[IClosable](../windows.foundation/iclosable.md)
