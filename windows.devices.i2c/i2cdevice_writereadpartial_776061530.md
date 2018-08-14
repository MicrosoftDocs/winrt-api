---
-api-id: M:Windows.Devices.I2c.I2cDevice.WriteReadPartial(System.Byte[],System.Byte[])
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.I2c.I2cTransferResult WriteReadPartial(System.Byte[] writeBuffer, System.Byte[] readBuffer)
-->

# Windows.Devices.I2c.I2cDevice.WriteReadPartial

## -description
Performs an atomic operation to write data to and then read data from the inter-integrated circuit (I<sup>2</sup> C) bus on which the device is connected, and returns information about the success of the operation that you can use for error handling.

## -parameters
### -param writeBuffer
A buffer that contains the data that you want to write to the I<sup>2</sup> C device. This data should not include the bus address.

### -param readBuffer
The buffer to which you want to read the data from the I<sup>2</sup> C bus. The length of the buffer determines how much data to request from the device.

## -returns
A structure that contains information about whether both the read and write parts of the operation succeeded and the sum of the actual number of bytes that the operation wrote and the actual number of bytes that the operation read.

## -remarks

## -examples

## -see-also
[WriteRead](i2cdevice_writeread_1176071171.md), [ReadPartial](i2cdevice_readpartial_589466211.md), [WritePartial](i2cdevice_writepartial_1107922632.md), [I2cTransferResult](i2ctransferresult.md), [I2CTransferStatus](i2ctransferstatus.md)

## -capabilities
&lt;DeviceCapability name="lowLevel" /&gt;
