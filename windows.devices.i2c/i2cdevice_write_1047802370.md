---
-api-id: M:Windows.Devices.I2c.I2cDevice.Write(System.Byte[])
-api-type: winrt method
---

<!-- Method syntax
public void Write(System.Byte[] buffer)
-->

# Windows.Devices.I2c.I2cDevice.Write

## -description
Writes data to the inter-integrated circuit (I<sup>2</sup> C) bus on which the device is connected, based on the bus address specified in the [I2cConnectionSetting](i2cconnectionsettings.md) s object that you used to create the [I2cDevice](i2cdevice.md) object.

## -parameters
### -param buffer
A buffer that contains the data that you want to write to the I<sup>2</sup> C device. This data should not include the bus address.

## -exceptions
### 0x80070002

The bus address was not acknowledged.

### 0x8007045D

The I<sup>2</sup> C device negatively acknowledged the data transfer before the entire buffer was written.

## -remarks

## -examples

## -see-also
[WritePartial](i2cdevice_writepartial.md), [Read](i2cdevice_read.md), [WriteRead](i2cdevice_writeread.md), [I2cConnectionSetting](i2cconnectionsettings.md)

## -capabilities
lowLevelDevices