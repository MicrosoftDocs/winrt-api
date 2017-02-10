---
-api-id: P:Windows.Devices.I2c.I2cDevice.ConnectionSettings
-api-type: winrt property
---

<!-- Property syntax
public Windows.Devices.I2c.I2cConnectionSettings ConnectionSettings { get; }
-->

# Windows.Devices.I2c.I2cDevice.ConnectionSettings

## -description
Gets the connection settings used for communication with the inter-integrated circuit (I<sup>2</sup> C) device.

## -property-value
The connection settings used for communication with the inter-integrated circuit (I<sup>2</sup> C) device.

## -remarks
If you try to change the values of the [I2cConnectionSettings](i2cconnectionsettings.md) object that you get through this property, those changes will have no effect. You cannot change the connection settings after you create the [I2cDevice](i2cdevice.md) object. To specify the connection settings, use the [I2cConnectionSettings(Int32)](i2cconnectionsettings_i2cconnectionsettings.md) constructor to create an [I2cConnectionSettings](i2cconnectionsettings.md) object, and set the property values for that [I2cConnectionSettings](i2cconnectionsettings.md) object before you pass it to the [FromIdAsync](i2cdevice_fromidasync.md) method to create the [I2cDevice](i2cdevice.md) object.

## -examples

## -see-also
[I2cConnectionSettings](i2cconnectionsettings.md), [I2cConnectionSettings(Int32)](i2cconnectionsettings_i2cconnectionsettings.md), [I2cDevice.FromIdAsync](i2cdevice_fromidasync.md)

## -capabilities
lowLevelDevices