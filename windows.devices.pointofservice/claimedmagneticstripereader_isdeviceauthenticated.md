---
-api-id: P:Windows.Devices.PointOfService.ClaimedMagneticStripeReader.IsDeviceAuthenticated
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public bool IsDeviceAuthenticated { get; }
-->

# Windows.Devices.PointOfService.ClaimedMagneticStripeReader.IsDeviceAuthenticated

## -description
Indicates whether the device is authenticated.

## -property-value
True is the device is authenticated; otherwise, false.

## -remarks
This property is only valid in the devices that support authentication.

When the device authentication state changes, the [StatusUpdated](magneticstripereader_statusupdated.md) event occurs to indicate the change.

## -examples

## -see-also
