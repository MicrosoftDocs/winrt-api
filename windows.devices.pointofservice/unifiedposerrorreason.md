---
-api-id: T:Windows.Devices.PointOfService.UnifiedPosErrorReason
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.PointOfService.UnifiedPosErrorReason : int
-->

# UnifiedPosErrorReason

## -description
Defines the constants that indicates the reason for the error event.

## -enum-fields
### -field UnknownErrorReason:0
Unknown reason.

### -field NoService:1
Cannot communicate with the device, possibly due to a configuration error.

### -field Disabled:2
The device is not enabled.

### -field Illegal:3
The operation is not supported or not available on the device.

### -field NoHardware:4
The device is not connected or not powered on.

### -field Closed:5
The device is closed.

### -field Offline:6
The device is offline.

### -field Failure:7
The operation failed although the device was connected and powered on.

### -field Timeout:8
The operation timed out while waiting for a response from the device.

### -field Busy:9
The device is busy.

### -field Extended:10
The operation failed and returned a vendor specific error information.


## -remarks

## -examples

## -see-also
[ClaimedMagneticStripeReader.ErrorOccurred](claimedmagneticstripereader_erroroccurred.md), [ClaimedBarcodeScanner.ErrorOccurred](claimedbarcodescanner_erroroccurred.md)