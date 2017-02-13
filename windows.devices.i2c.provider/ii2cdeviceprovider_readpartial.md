---
-api-id: M:Windows.Devices.I2c.Provider.II2cDeviceProvider.ReadPartial(System.Byte[])
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.I2c.Provider.ProviderI2cTransferResult ReadPartial(System.Byte[] buffer)
-->

# Windows.Devices.I2c.Provider.II2cDeviceProvider.ReadPartial

## -description
Reads data from the inter-integrated circuit (I<sup>2</sup> C) bus on which the device is connected into the specified buffer, and returns information about the success of the operation that you can use for error handling.

## -parameters
### -param buffer
The buffer to which you want to read the data from the I<sup>2</sup> C bus. The length of the buffer determines how much data to request from the device.

## -returns
A structure that contains information about the success of the read operation and the actual number of bytes that the operation read into the buffer.

## -remarks

## -examples

## -see-also
