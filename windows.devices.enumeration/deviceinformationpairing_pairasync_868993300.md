---
-api-id: M:Windows.Devices.Enumeration.DeviceInformationPairing.PairAsync(Windows.Devices.Enumeration.DevicePairingProtectionLevel)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Enumeration.DevicePairingResult> PairAsync(Windows.Devices.Enumeration.DevicePairingProtectionLevel minProtectionLevel)
-->

# Windows.Devices.Enumeration.DeviceInformationPairing.PairAsync

## -description
Attempts to pair the device using a provided level of protection.

## -parameters
### -param minProtectionLevel
The required level of protection to use for the pairing action.

## -returns
The result of the pairing action.

## -remarks
For all protocols other than Bluetooth, the *minProtectionLevel* value is ignored and the default behavior is always assumed. For the Bluetooth protocol, the pairing attempt will fail if the device doesn’t support the specified minimum protection level or a higher level. If the device doesn’t support the specified minimum protection level but does support a higher protection level, the higher protection level is used.

## -examples

## -see-also
[PairAsync](deviceinformationpairing_pairasync_819565643.md)