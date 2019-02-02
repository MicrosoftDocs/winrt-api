---
-api-id: N:Windows.Devices.SerialCommunication
-api-type: winrt namespace
---

# Windows.Devices.SerialCommunication

## -description

The [Windows.Devices.SerialCommunication](windows_devices_serialcommunication.md) namespace defines Windows Runtime classes that a UWP app can use to communicate with a device that exposes a serial port or some abstraction of a serial port. The classes provide functionality to discover such serial device, read and write data, and control serial-specific properties for flow control, such as setting baud rate, signal states.

The namespace also supports devices that belong to the USB CDC device class. This includes ports exposed by Serial-to-USB adapters and internal USB to serial bridge chips like those used in Arduino Uno R3s. See note below on compatible IDs.

System-internal or on-chassis serial ports may be enumerated by [DeviceInformation.FindAllAsync()](../windows.devices.enumeration/deviceinformation_findallasync_1257462890.md), but cannot be opened by [SerialDevice.FromIdAsync()](serialdevice_fromidasync_1322863552.md) because they currently are not supported. However, serial ports connected over USB, such as on USB-to-Serial cables are supported.

It is possible that the **DeviceInformation** collection returned by [DeviceInformation.FindAllAsync()](../windows.devices.enumeration/deviceinformation_findallasync_1257462890.md) may have a serial device whose [DeviceInformation.Name](../windows.devices.enumeration/deviceinformation_name.md) property is set to the machine name. This is by design and may occur when enumerating an on-board serial port. Apps should handle this case by either:

+ Filtering such serial ports from the user's view, so that the user will not be able to interact with such an unsupported serial port at all.
+ If the app decides to let the user interact with such a serial port, then note that when the app calls the [DeviceAccessInformation.CreateFromId()](../windows.devices.enumeration/deviceaccessinformation_createfromid_1774777795.md) function, an exception with the message: "The system cannot find the file specified. (Exception from HRESULT: 0x80070002)" will be thrown. The app should handle such an exception and let the user know that the port is unsupported.

Serial devices that use the following compatible IDs can be supported by the in-box Windows 10 usbser.sys driver; these are automatically supported by [Windows.Devices.SerialCommunication](windows_devices_serialcommunication.md). In addition, USB serial devices that use other compatible IDs are supported through a vendor-supplied driver.
<!--Removed mention of PRO SKU for now-->

+ USB\Class_02&amp;SubClass_02&amp;Prot_01
+ USB\Class_02&amp;SubClass_02

**Serial device capability usage**

Your UWP app must include certain device capabilities in its App package manifest. The capabilities identify the device and its purpose. Here are the required elements in hierarchical order:

+ [&lt;DeviceCapability&gt;](https://msdn.microsoft.com/library/4353c4fd-f038-4986-81ed-d2ec0c6235ef): The **Name** attribute must be "serialcommunication".

   + **&lt;Device&gt;**: The **Id** attribute must specify the device identifier. If you are using a Serial-to-USB adapter, **Id** must specify vendor/product identifiers or can be "any" to allow access to any device that matches the function type.

      + **&lt;Function&gt;**: The **Type** attribute specifies the device function. For serial devices this must be "serialPort".

```
<DeviceCapability Name="serialcommunication">
    <Device Id="vidpid:xxxx xxxx">
      <Function Type="name:serialPort"/>
    </Device>
</DeviceCapability>
```

**Serial device capability example**

Here is an example for defining serial device capabilities. It allows the app to access the serial port through a Serial-to-USB adapter.

```
<DeviceCapability Name="serialcommunication">
  <Device Id="vidpid:045E 0610">
    <Function Type="name:serialPort"/>
  </Device>
</DeviceCapability>

```

## -remarks

## -examples

## -see-also
[Custom serial device sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CustomSerialDeviceAccess), [Serial arduino sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SerialArduino)
