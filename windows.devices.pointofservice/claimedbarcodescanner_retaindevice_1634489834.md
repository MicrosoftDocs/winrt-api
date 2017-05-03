---
-api-id: M:Windows.Devices.PointOfService.ClaimedBarcodeScanner.RetainDevice
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void RetainDevice()
-->

# Windows.Devices.PointOfService.ClaimedBarcodeScanner.RetainDevice

## -description
Retains exclusive claim to the barcode scanner.

## -remarks
When the application receives a request to release its exclusive claim to the barcode scanner, it must call [RetainDevice](claimedbarcodescanner_retaindevice.md), otherwise it will lose its claim to the device.

## -examples

## -see-also
[ReleaseDeviceRequested](claimedbarcodescanner_releasedevicerequested.md)