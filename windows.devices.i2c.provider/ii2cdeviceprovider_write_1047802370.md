---
-api-id: M:Windows.Devices.I2c.Provider.II2cDeviceProvider.Write(System.Byte[])
-api-type: winrt method
---

<!-- Method syntax
public void Write(System.Byte[] buffer)
-->

# Windows.Devices.I2c.Provider.II2cDeviceProvider.Write

## -description
Writes data to the inter-integrated circuit (I<sup>2</sup> C) bus on which the device is connected.

## -parameters
### -param buffer
A buffer that contains the data that you want to write to the I<sup>2</sup> C device. This data should not include the bus address.

## -remarks

#### Error Codes
##### 0x80070002

The bus address was not acknowledged.

##### 0x8007045D

The I<sup>2</sup> C device negatively acknowledged the data transfer before the entire buffer was read.

## -examples

## -see-also
[I2cDevice](../windows.devices.i2c/i2cdevice.md)