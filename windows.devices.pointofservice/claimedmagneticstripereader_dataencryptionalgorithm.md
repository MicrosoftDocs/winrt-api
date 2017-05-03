---
-api-id: P:Windows.Devices.PointOfService.ClaimedMagneticStripeReader.DataEncryptionAlgorithm
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public uint DataEncryptionAlgorithm { get;  set; }
-->

# Windows.Devices.PointOfService.ClaimedMagneticStripeReader.DataEncryptionAlgorithm

## -description
Gets or sets the [MagneticStripeReaderEncryptionAlgorithms](magneticstripereaderencryptionalgorithms.md) that will be used to encrypt the track data.

## -property-value
The encryption algorithm the will be used to encrypt the track data.

## -remarks
This property can only be updated when the device is opened and claimed; it cannot be updated when the device is enabled.

## -examples

## -see-also
[MagneticStripeReaderEncryptionAlgorithms](magneticstripereaderencryptionalgorithms.md)