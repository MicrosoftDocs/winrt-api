---
-api-id: T:Windows.Devices.I2c.I2cSharingMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.I2c.I2cSharingMode : int
-->

# I2cSharingMode

## -description
Describes the modes in which you can connect to an inter-integrated circuit (I<sup>2</sup> C) bus address. These modes determine whether other connections to the I<sup>2</sup> C bus address can be opened while you are connected to the I<sup>2</sup> C bus address.

## -enum-fields
### -field Exclusive:0
Connects to the I<sup>2</sup> C bus address exclusively, so that no other connection to the I<sup>2</sup> C bus address can be made while you remain connected. This mode is the default mode.

### -field Shared:1
Connects to the I<sup>2</sup> C bus address in shared mode, so that other connections to the I<sup>2</sup> C bus address can be made while you remain connected.

You can perform all operations on shared connections, but use such connections with care. When multiple client apps change the global state of the I<sup>2</sup> C device, race conditions can result.

An example use case for using a shared connection is a sensor that obtains readings without changing the state of the device.


## -remarks

## -examples

## -see-also
[I2cConnectionSettings.SharingMode](i2cconnectionsettings_sharingmode.md), [I2cDevice.FromIdAsync](i2cdevice_fromidasync.md)