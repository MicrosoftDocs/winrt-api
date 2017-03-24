---
-api-id: P:Windows.Devices.PointOfService.MagneticStripeReaderReport.AdditionalSecurityInformation
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Storage.Streams.IBuffer AdditionalSecurityInformation { get; }
-->

# Windows.Devices.PointOfService.MagneticStripeReaderReport.AdditionalSecurityInformation

## -description
Gets the additional security or encryption information for the recently swiped card.

## -property-value
The additional security or encryption information.

## -remarks
The information content and internal format of this property vary among encryption algorithms. For example, for DUKPT this property contains the DUKPT sequence number. This property is empty if the encryption algorithm does not require it.

## -examples

## -see-also
