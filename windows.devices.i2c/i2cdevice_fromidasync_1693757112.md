---
-api-id: M:Windows.Devices.I2c.I2cDevice.FromIdAsync(System.String,Windows.Devices.I2c.I2cConnectionSettings)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.I2c.I2cDevice> FromIdAsync(System.String deviceId, Windows.Devices.I2c.I2cConnectionSettings settings)
-->

# Windows.Devices.I2c.I2cDevice.FromIdAsync

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
[I2cConnectionSettings](i2cconnectionsettings.md), [GetDeviceSelector](i2cdevice_getdeviceselector_1752695616.md), [I2cDevice.Close](i2cdevice_close_811482585.md), [I2cDevice.DeviceId](i2cdevice_deviceid.md), [II2cDeviceStatics.FromIdAsync](ii2cdevicestatics_fromidasync_1693757112.md)

## -capabilities
lowLevel
