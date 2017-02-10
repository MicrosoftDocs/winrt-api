---
-api-id: M:Windows.Devices.I2c.I2cDevice.GetDeviceSelector(System.String)
-api-type: winrt method
---

<!-- Method syntax
public string GetDeviceSelector(System.String friendlyName)
-->

# Windows.Devices.I2c.I2cDevice.GetDeviceSelector

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
[GetDeviceSelector](i2cdevice_getdeviceselector_838466080.md), [DeviceInformation.FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync.md), [I2cDevice.FromIdAsync](i2cdevice_fromidasync.md), [II2CDeviceStatics.GetDeviceSelector(String)](ii2cdevicestatics_getdeviceselector_1752695616.md)