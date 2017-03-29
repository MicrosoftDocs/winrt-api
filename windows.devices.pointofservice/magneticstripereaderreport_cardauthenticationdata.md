---
-api-id: P:Windows.Devices.PointOfService.MagneticStripeReaderReport.CardAuthenticationData
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Storage.Streams.IBuffer CardAuthenticationData { get; }
-->

# Windows.Devices.PointOfService.MagneticStripeReaderReport.CardAuthenticationData

## -description
Gets the card authentication information for the recently swiped card.

## -property-value
The card authentication data.

## -remarks
The information and internal format of this property vary among services. This property is empty if the device does not support authentication. Otherwise, the value of this property is encrypted using the encryption algorithm in [DataEncryptionAlgorithm](claimedmagneticstripereader_dataencryptionalgorithm.md) property.

## -examples

## -see-also
