---
-api-id: P:Windows.Devices.PointOfService.MagneticStripeReaderReport.CardAuthenticationDataLength
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public uint CardAuthenticationDataLength { get; }
-->

# Windows.Devices.PointOfService.MagneticStripeReaderReport.CardAuthenticationDataLength

## -description
Gets the length of the raw [CardAuthenticationData](magneticstripereaderreport_cardauthenticationdata.md) before it is encrypted.

## -property-value
The length of the raw [CardAuthenticationData](magneticstripereaderreport_cardauthenticationdata.md) before it is encrypted.

## -remarks
Many encryption algorithms require padding of the input data before it can be encrypted. This property contains the length of the original unpadded data before it is encrypted. It may be needed to restore the original data after decryption.

## -examples

## -see-also
