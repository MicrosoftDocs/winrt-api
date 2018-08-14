---
-api-id: M:Windows.Devices.I2c.I2cDevice.WritePartial(System.Byte[])
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.I2c.I2cTransferResult WritePartial(System.Byte[] buffer)
-->

# Windows.Devices.I2c.I2cDevice.WritePartial

## -description
Writes data to the inter-integrated circuit (I<sup>2</sup> C) bus on which the device is connected, and returns information about the success of the operation that you can use for error handling.

## -parameters
### -param buffer
A buffer that contains the data that you want to write to the I<sup>2</sup> C device. This data should not include the bus address.

## -returns
A structure that contains information about the success of the write operation and the actual number of bytes that the operation wrote into the buffer.

## -remarks

## -examples

## -see-also
[Write](i2cdevice_write_1047802370.md), [ReadPartial](i2cdevice_readpartial_589466211.md), [WriteReadPartial](i2cdevice_writereadpartial_776061530.md), [I2cTransferResult](i2ctransferresult.md), [I2cTransferStatus](i2ctransferstatus.md)

## -capabilities
&lt;DeviceCapability name="lowLevel" /&gt;
