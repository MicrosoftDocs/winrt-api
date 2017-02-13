---
-api-id: M:Windows.Devices.I2c.I2cConnectionSettings.#ctor(System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public I2cConnectionSettings(System.Int32 slaveAddress)
-->

# Windows.Devices.I2c.I2cConnectionSettings.I2cConnectionSettings

## -description
Creates and initializes a new instance of the [I2cConnectionSettings](i2cconnectionsettings_i2cconnectionsettings.md) class for inter-integrated circuit (I<sup>2</sup> C) device with specified bus address, using the default settings of the standard mode for the bus speed and exclusive sharing mode.

## -parameters
### -param slaveAddress
The bus address of the inter-integrated circuit (I<sup>2</sup> C) device to which the settings of the [I2cConnectionSettings](i2cconnectionsettings_i2cconnectionsettings.md) should apply. Only 7-bit addressing is supported, so the range of values that are valid is from 8 to 119.

## -remarks

## -examples

## -see-also
[SlaveAddress](i2cconnectionsettings_slaveaddress.md), [I2cDevice.ConnectionSettings](i2cdevice_connectionsettings.md)