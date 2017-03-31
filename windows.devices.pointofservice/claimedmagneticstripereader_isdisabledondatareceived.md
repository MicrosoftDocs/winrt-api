---
-api-id: P:Windows.Devices.PointOfService.ClaimedMagneticStripeReader.IsDisabledOnDataReceived
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public bool IsDisabledOnDataReceived { get;  set; }
-->

# Windows.Devices.PointOfService.ClaimedMagneticStripeReader.IsDisabledOnDataReceived

## -description
Gets or sets a Boolean value that indicates whether the magnetic stripe reader is disabled after receiving the data from the most recently swiped card.

## -property-value
Set to true if the application wants to receive and process only one input or only one input at a time.

## -remarks
[IsDisabledOnDataReceived](claimedmagneticstripereader_isdisabledondatareceived.md) provides the application the option to disable the magnetic stripe reader after receiving the data. When set to true, the device is disabled as soon as it receives the data from the most recently swiped card. The application must call [EnableAsync](claimedmagneticstripereader_enableasync.md) to get the device ready for the next data event.

This property is initialized to false.

## -examples

## -see-also
