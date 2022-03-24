---
-api-id: N:Windows.Devices.HumanInterfaceDevice
-api-type: winrt namespace
---

# Windows.Devices.HumanInterfaceDevice

## -description

This namespace gives your UWP app access to devices that support the [Human Interface Device (HID)](https://www.usb.org/hid) protocol.

## Device Support

This namespace supports most HIDs. However, it does not provide access to top-level application collections (TLCs) represented by the following usages.

### Inaccessible Usages.

|UsagePage|UsageIds|
|---|---|
|`HID_USAGE_PAGE_UNDEFINED` (`0x00`)|All|
|`HID_USAGE_PAGE_GENERIC` (`0x01`)| `HID_USAGE_GENERIC_MOUSE` (`0x02`)<br>`HID_USAGE_GENERIC_KEYBOARD` (`0x06`)<br>`HID_USAGE_GENERIC_KEYPAD` (`0x07`)<br>`HID_USAGE_GENERIC_SYSTEM_CTL` (`0x80`) |
|`HID_USAGE_PAGE_KEYBOARD` (`0x07`)| All|
|`HID_USAGE_PAGE_CONSUMER` (`0x0C`)|All|
|`HID_USAGE_PAGE_DIGITIZER` (`0x0D`)|All|
|`HID_USAGE_PAGE_SENSOR` (`0x20`)|All|
|`HID_USAGE_PAGE_LIGHTING_ILLUMINATION` (`0x59`) | `HID_USAGE_LAMPARRAY` (`0x01`)

+ Keyboard and mouse devices are system reserved devices
+ [LampArray HIDs](https://www.usb.org/sites/default/files/hutrr84_-_lighting_and_illumination_page.pdf) can be enumerated with [HidDevice.GetDeviceSelector](hiddevice_getdeviceselector_1541481733.md) but must be instantiated with [LampArray.FromIdAsync](../windows.devices.lights/lamparray_fromidasync_1322863552.md)
+ Sensor HIDs can be enumerated with [HidDevice.GetDeviceSelector](hiddevice_getdeviceselector_1541481733.md) but must be instantiated with their respective [Windows.Devices.Sensors](../windows.devices.sensors/windows_devices_sensors.md) device (e.g. [LightSensor.FromIdAsync](../windows.devices.sensors/lightsensor_fromidasync_1322863552.md))


## Human Interface Device Capabilities

A UWP app that accesses a HID must include specific device capability data in the capabilities node of its manifest. This data identifies the device and its purpose (or function). Note that some devices may have multiple functions.

**Since Windows 10, version 1809 (October 2018 Update)**

+ [&lt;DeviceCapability&gt;](/uwp/schemas/appxpackage/appxmanifestschema/element-devicecapability): The **Name** attribute must be `humanInterfaceDevice`.
```xml
<DeviceCapability Name="humanInterfaceDevice"/>
```

If targeting a HID telephony device (UsagePage==`0x0B`), the additional capability ```hidTelephony``` must also be specified.
```xml
<DeviceCapability Name="humanInterfaceDevice"/>
<DeviceCapability Name="hidTelephony"/>
```

**Before Windows 10, version 1809 (October 2018 Update)**

Since 1809, the **VendorId**/**ProductId** and **function-type** no longer need to be specified and will be ignored on newer systems.  If targeting systems before 1809, then see below.

+ [&lt;DeviceCapability&gt;](/uwp/schemas/appxpackage/appxmanifestschema/element-devicecapability): The **Name** attribute must be `humanInterfaceDevice`.

   + **&lt;Device&gt;**: The **Id** attribute must specify the device identifier. This element may specify a combination **Vendor Id** (vid) and **Product Id** (pid); or, it may specify a generic string ```any```. In addition, the ```Device Id``` may contain an optional provider string of ```usb``` or ```bluetooth```.

      + **&lt;Function&gt;**: The **Type** attribute specifies the device function. This element contains one or more HID usage values. These values consist of a ```UsagePage``` and an optional ```UsageId```, each of which are 16-bit hexadecimal values.

In the following vendor-defined usage data, the device is identified by the **Vendor Id** and **Product Id** combination.

```xml
<DeviceCapability Name="humaninterfacedevice">
    <Device Id="vidpid:0A81 0701">
      <Function Type="usage:ffa0 0001"/>
    </Device>
</DeviceCapability>
```

The following is identical to the first with the exception of the additional provider string ```usb``` in the ```Device Id``` element.

```xml
<DeviceCapability Name="humaninterfacedevice">
    <Device Id="vidpid:0A81 0701 usb">
      <Function Type="usage:ffa0 0001"/>
    </Device>
</DeviceCapability>
```

In the following gaming-device data there is no **Vendor Id** and **Product Id**.

```xml
<!-- Any gamepad device  -->
<DeviceCapability Name="humaninterfacedevice">
    <Device Id="any">
      <Function Type="usage:0005 *"/>
    </Device>
</DeviceCapability>
```

In the following joystick and game pad data there is no **Vendor Id** and **Product Id**

```xml
<!-- Any generic gaming device  -->
<DeviceCapability Name="humaninterfacedevice">
    <Device Id="any">
      <Function Type="usage:0004 *"/>
      <Function Type="usage:0005 *"/>
    </Device>
</DeviceCapability>
```

## Troubleshooting

+ Verify the HID capability (```humanInterfaceDevice```) is in the application manifest.  If a telephony device, ensure the ```hidTelephony``` capability is also included.
+ Verify the user has granted permission for the application to utilize HIDs.
+ Verify the device type is not one designated as inaccessible.
  + Inaccessible HIDs may still be enumerated by [DeviceInformation.FindAllAsync()](../windows.devices.enumeration/deviceinformation_findallasync_1257462890.md), but cannot be opened by [HumanInterfaceDevice.FromIdAsync()](hiddevice_fromidasync_1634380010.md).  Attemping to open such a device will either throw an exception or return `null`.
+ Machine-internal devices (`DEVPKEY_Device_InLocalMachineContainer == TRUE`) are generally *not* accessible unless running on a SKU with [embedded mode](/windows/iot-core/develop-your-app/EmbeddedMode) and `lowLevelDevices` capability.
+ Devices with stacks that contain upper/lower filter drivers are generally *not* accessible.  These are sometimes added by 3rd parties to enable additional functionality for [custom hardware](/windows-hardware/drivers/install/inf-addreg-directive).
  + Device restriction is partially determined by `hidclass.sys` during device enumeration, which may set the device interface property `DEVPKEY_DeviceInterface_Restricted` to `TRUE` on the HID Device Interface [`GUID_DEVINTERFACE_HID`](/windows-hardware/drivers/install/guid-devinterface-hid) based on the presence of device/class filters.
  + The presence of device [UpperFilter](/windows-hardware/drivers/install/devpkey-device-upperfilters)/[LowerFilter](/windows-hardware/drivers/install/devpkey-device-lowerfilters) drivers can be determined using DeviceManager by looking for `UpperFilters` and `LowerFilters` properties.
  + The presence of HID class [UpperFilter](/windows-hardware/drivers/install/devpkey-deviceclass-upperfilters)/[LowerFilter](/windows-hardware/drivers/install/devpkey-deviceclass-lowerfilters) drivers can be determined using DeviceManager by looking for `Class upper filters` and `Class lower filters` properties.
  + Device Interface properties can be inspected by calling [`CM_Get_Device_Interface_Property`](/windows/win32/api/cfgmgr32/nf-cfgmgr32-cm_get_device_interface_propertyw) where `pszDeviceInterface` is the same string as would be passed to [FromIdAsync](hiddevice_fromidasync_1634380010.md).
+ These restrictions can be bypassed when making a custom device by working with the driver-developer to create a [Hardware Support App](/windows-hardware/drivers/devapps/hardware-support-app--hsa--steps-for-app-developers)

## -remarks

## -examples

## -see-also

[Custom HID device sample](https://github.com/Microsoft/Windows-universal-samples/tree/6370138b150ca8a34ff86de376ab6408c5587f5d/Samples/CustomHidDeviceAccess)
