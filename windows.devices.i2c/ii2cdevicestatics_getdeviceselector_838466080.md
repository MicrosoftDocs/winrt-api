---
-api-id: M:Windows.Devices.I2c.II2cDeviceStatics.GetDeviceSelector
-api-type: winrt method
---

<!-- Method syntax
public string GetDeviceSelector()
-->

# Windows.Devices.I2c.II2cDeviceStatics.GetDeviceSelector

## -description
Retrieves an Advanced Query Syntax (AQS) string for all of the inter-integrated circuit (I<sup>2</sup> C) bus controllers on the system. You can use this string with the [DeviceInformation.FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync_1257462890.md) method to get [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) objects for those bus controllers.

## -returns
An AQS string for all of the I<sup>2</sup> C bus controllers on the system, which you can use with the [DeviceInformation.FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync_1257462890.md) method to get [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) objects for those bus controllers.

## -remarks

## -examples

## -see-also
[GetDeviceSelector(String)](ii2cdevicestatics_getdeviceselector_1752695616.md), [DeviceInformation.FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync_1257462890.md), [I2Device.GetDeviceSelector()](i2cdevice_getdeviceselector_838466080.md)