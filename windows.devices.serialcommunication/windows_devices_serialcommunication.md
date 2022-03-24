---
-api-id: N:Windows.Devices.SerialCommunication
-api-type: winrt namespace
---

# Windows.Devices.SerialCommunication

## -description

The `Windows.Devices.SerialCommunication` namespace defines Windows Runtime classes that a UWP app can use to communicate with a device that exposes a serial port or some abstraction of a serial port. The classes provide functionality to discover such serial devices, read and write data, and control serial-specific properties for flow control, such as setting baud rate, signal states.

## Device Support

A serial device will expose itself to the system by the property `DEVPKEY_Device_ClassGuid` = `{4d36e978-e325-11ce-bfc1-08002be10318}` and create a DeviceInterface with `DEVPKEY_DeviceInterface_ClassGuid` = `{86e0d1e0-8089-11d0-9ce4-08003e301f73}` (`GUID_DEVINTERFACE_COMPORT`).

Windows natively supports ports exposed by Serial-to-USB adapters that belong to the USB-CDC device class using the inbox `usbser.sys` driver (such as those used in Arduino Uno R3s).  USB-CDC compatible Ids are:
+ `USB\Class_02&amp;SubClass_02&amp;Prot_01`
+ `USB\Class_02&amp;SubClass_02`

Other Serial-to-USB adapters (such as FTDI/Prolific/Silicon-Labs) that expose `GUID_DEVINTERFACE_COMPORT`s are also supported, but require additional vendor-specific drivers.

Serial ports marked as internal to the machine (`DEVPKEY_Device_InLocalMachineContainer == TRUE`) are *not* accessible unless explictly marked by the vendor driver as unrestricted (`DEVPKEY_DeviceInterface_Restricted == TRUE`).  Devices connect via most PCI COM port expansion cards are therefore *not* accessible.

Inaccessible serial ports may still be enumerated by [DeviceInformation.FindAllAsync()](../windows.devices.enumeration/deviceinformation_findallasync_1257462890.md), but cannot be opened by [SerialDevice.FromIdAsync()](serialdevice_fromidasync_1322863552.md).  Attemping to open such a device will either throw an exception or return null. Apps should handle this case by filtering such serial ports from the user's view, so that the user will not be able to interact with such an unsupported serial port.

It is possible that the **DeviceInformation** collection returned by [DeviceInformation.FindAllAsync()](../windows.devices.enumeration/deviceinformation_findallasync_1257462890.md) may have a serial device whose [DeviceInformation.Name](../windows.devices.enumeration/deviceinformation_name.md) property is set to the machine name. This is by design and may occur when enumerating an onboard serial port.  Apps should handle this case by either:

+ Filtering such serial ports from the user's view, so that the user will not be able to interact with such an unsupported serial port at all.
+ If the app decides to let the user interact with such a serial port, then note that when the app calls the [DeviceAccessInformation.CreateFromId()](../windows.devices.enumeration/deviceaccessinformation_createfromid_1774777795.md) function, an exception with the message: "The system cannot find the file specified. (Exception from HRESULT: 0x80070002)" will be thrown. The app should handle such an exception and let the user know that the port is unsupported.

Accessbility/capability policy can always be overridden by writing a custom driver and matching [Hardware Support App](/windows-hardware/drivers/devapps/hardware-support-app--hsa--steps-for-driver-developers)

## Serial Device Capabilities

Your UWP app must include certain device capabilities in its App package manifest. The capabilities identify the device and its purpose. Here are the required elements in hierarchical order:

**Since Windows 10, version 1809 (October 2018 Update)**

Since 1809, the vidpid and function-type no longer need to be specified and will be ignored on these systems.  If targeting systems before 1809, then see below.

+ [&lt;DeviceCapability&gt;](/uwp/schemas/appxpackage/appxmanifestschema/element-devicecapability): The **Name** attribute must be `serialcommunication`.
```xml
<DeviceCapability Name="serialcommunication"/>
```

**Before Windows 10, version 1809 (October 2018 Update)**

+ [&lt;DeviceCapability&gt;](/uwp/schemas/appxpackage/appxmanifestschema/element-devicecapability): The **Name** attribute must be `serialcommunication`.

   + **&lt;Device&gt;**: The **Id** attribute must specify the device identifier. If you are using a Serial-to-USB adapter, **Id** must specify vendor/product identifiers or can be "any" to allow access to any device that matches the function type.

      + **&lt;Function&gt;**: The **Type** attribute specifies the device function. For serial devices this must be `serialPort`.

```xml
<DeviceCapability Name="serialcommunication">
    <Device Id="vidpid:xxxx xxxx">
      <Function Type="name:serialPort"/>
    </Device>
</DeviceCapability>
```

**Serial device capability example**

Here is an example for defining serial device capabilities. It allows the app to access the serial port through a Serial-to-USB adapter.

```xml
<DeviceCapability Name="serialcommunication">
  <Device Id="vidpid:045E 0610">
    <Function Type="name:serialPort"/>
  </Device>
</DeviceCapability>
```

## Troubleshooting

+ Verify the serial capability (```serialcommunication```) is in the application manifest.
+ Verify the user has granted permission for the application to utilize serial devices.
+ Machine-internal devices (`DEVPKEY_Device_InLocalMachineContainer == TRUE`) are generally *not* accessible. (e.g. PCI COM port expansion cards)
  + Unless the device interface property `DEVPKEY_DeviceInterface_Restricted` for `GUID_DEVINTERFACE_COMPORT` is set to `FALSE`, internal devices are not accessible.  Certain drivers, especially on IoT SKUs may set this property to `FALSE`.
  + If accessing a Serial controller based on [`SerCx` or `SerCx2`](/windows-hardware/drivers/serports/serial-drivers-overview#sercx-and-sercx2) then starting Windows 10 1903 (May 2019 Update) the device can opt-in to be [directly accessible](/windows/uwp/devices-sensors/enable-usermode-access) from user-mode or by enabling `RhProxy`.
+ These restrictions can be bypassed when making a custom device by working with the driver-developer to create a [Hardware Support App](/windows-hardware/drivers/devapps/hardware-support-app--hsa--steps-for-app-developers)


## -remarks

## -examples

## -see-also
[Custom serial device sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CustomSerialDeviceAccess), [Serial arduino sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SerialArduino)
