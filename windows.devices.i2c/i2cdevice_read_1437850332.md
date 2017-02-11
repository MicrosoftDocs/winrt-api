---
-api-id: M:Windows.Devices.I2c.I2cDevice.Read(System.Byte[])
-api-type: winrt method
---

<!-- Method syntax
public void Read(System.Byte[] buffer)
-->

# Windows.Devices.I2c.I2cDevice.Read

## -description
Reads data from the inter-integrated circuit (I<sup>2</sup> C) bus on which the device is connected into the specified buffer.

## -parameters
### -param buffer
The buffer to which you want to read the data from the I<sup>2</sup> C bus. The length of the buffer determines how much data to request from the device.

## -exceptions
### 0x80070002

The bus address was not acknowledged.

### 0x8007045D

The I<sup>2</sup> C device negatively acknowledged the data transfer before the entire buffer was read.

## -remarks

## -examples

## -see-also
[ReadPartial](i2cdevice_readpartial.md), [Write](i2cdevice_write.md), [WriteRead](i2cdevice_writeread.md)

## -capabilities
lowLevelDevices