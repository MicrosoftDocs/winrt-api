---
-api-id: M:Windows.Devices.I2c.II2cDeviceStatics.FromIdAsync(System.String,Windows.Devices.I2c.I2cConnectionSettings)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.I2c.I2cDevice> FromIdAsync(System.String deviceId, Windows.Devices.I2c.I2cConnectionSettings settings)
-->

# Windows.Devices.I2c.II2cDeviceStatics.FromIdAsync

## -description
Retrieves an [I2cDevice](i2cdevice.md) object asynchronously for the inter-integrated circuit (I<sup>2</sup> C) bus controller that has the specified plug and play device identifier, using the specified connection settings.

## -parameters
### -param deviceId
The plug and play device identifier of the I<sup>2</sup> C bus controller for which you want to create an [I2cDevice](i2cdevice.md) object.

### -param settings
The connection settings to use for communication with the I<sup>2</sup> C bus controller that *deviceId* specifies.

## -returns
An asynchronous operation that returns the [I2cDevice](i2cdevice.md) object.

## -remarks

## -examples

## -see-also
[I2cConnectionSettings](i2cconnectionsettings.md), [GetDeviceSelector](ii2cdevicestatics_getdeviceselector.md), [I2cDevice.Close](i2cdevice_close.md), [I2cDevice.DeviceId](i2cdevice_deviceid.md), [I2cDevice.FromIdAsync](i2cdevice_fromidasync.md)

## -capabilities
&lt;DeviceCapability name="lowLevel" /&gt;
