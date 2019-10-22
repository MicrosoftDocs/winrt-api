---
-api-id: M:Windows.Devices.I2c.I2cDevice.WriteRead(System.Byte[],System.Byte[])
-api-type: winrt method
---

<!-- Method syntax
public void WriteRead(System.Byte[] writeBuffer, System.Byte[] readBuffer)
-->

# Windows.Devices.I2c.I2cDevice.WriteRead

## -description
Performs an atomic operation to write data to and then read data from the inter-integrated circuit (I<sup>2</sup> C) bus on which the device is connected, and sends a restart condition between the write and read operations.

## -parameters
### -param writeBuffer
A buffer that contains the data that you want to write to the I<sup>2</sup> C device. This data should not include the bus address.

### -param readBuffer
The buffer to which you want to read the data from the I<sup>2</sup> C bus. The length of the buffer determines how much data to request from the device.

## -remarks

#### Error Codes
##### 0x80070002

The bus address was not acknowledged.

##### 0x8007045D

The I<sup>2</sup> C device negatively acknowledged the data transfer before the entire buffer was read.

## -examples

## -see-also
[WriteReadPartial](i2cdevice_writereadpartial_776061530.md), [Write](i2cdevice_write_1047802370.md), [Read](i2cdevice_read_1437850332.md)

## -capabilities
lowLevel
