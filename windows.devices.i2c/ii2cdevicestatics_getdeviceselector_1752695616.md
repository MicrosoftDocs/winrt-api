---
-api-id: M:Windows.Devices.I2c.II2cDeviceStatics.GetDeviceSelector(System.String)
-api-type: winrt method
---

<!-- Method syntax
public string GetDeviceSelector(System.String friendlyName)
-->

# Windows.Devices.I2c.II2cDeviceStatics.GetDeviceSelector

## -description
Retrieves an Advanced Query Syntax (AQS) string for the inter-integrated circuit (I<sup>2</sup> C) bus that has the specified friendly name. You can use this string with the [DeviceInformation.FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync.md) method to get a [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) object for that bus.

## -parameters
### -param friendlyName
A friendly name for the particular I<sup>2</sup> C bus on a particular hardware platform for which you want to get the AQS string.

## -returns
An AQS string for the I<sup>2</sup> C bus that *friendlyName* specifies, which you can use with the [DeviceInformation.FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync.md) method to get a [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) object for that bus.

## -remarks

## -examples

## -see-also
[GetDeviceSelector](ii2cdevicestatics_getdeviceselector_838466080.md), [DeviceInformation.FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync.md), [II2cDeviceStatics.FromIdAsync](ii2cdevicestatics_fromidasync.md), [I2cDevice.GetDeviceSelector(String)](i2cdevice_getdeviceselector_1752695616.md)