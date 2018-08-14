---
-api-id: M:Windows.Devices.PointOfService.ClaimedMagneticStripeReader.RetainDevice
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void RetainDevice()
-->

# Windows.Devices.PointOfService.ClaimedMagneticStripeReader.RetainDevice

## -description
Retains exclusive claim to the magnetic stripe reader.

## -remarks
When the application receives a request to release its exclusive claim to the magnetic stripe reader, it must call [RetainDevice](claimedmagneticstripereader_retaindevice_1634489834.md), otherwise it will lose its claim to the device.

## -examples

## -see-also
[ReleaseDeviceRequested](claimedmagneticstripereader_releasedevicerequested.md)