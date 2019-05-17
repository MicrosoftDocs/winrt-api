---
-api-id: P:Windows.Devices.PointOfService.ClaimedBarcodeScanner.IsDisabledOnDataReceived
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public bool IsDisabledOnDataReceived { get;  set; }
-->

# Windows.Devices.PointOfService.ClaimedBarcodeScanner.IsDisabledOnDataReceived

## -description
Gets or sets a Boolean value that indicates whether the barcode scanner is disabled after receiving the data.

## -property-value
Set to true if the application wants to receive and process only one input or only one input at a time.

## -remarks
When IsDisabledOnDataReceived is true, the application can only received one data at a time and the device is disabled after the [DataReceived](claimedbarcodescanner_datareceived.md) event. The application must call [EnableAsync](claimedbarcodescanner_enableasync_208845947.md) to enable the device to received data.

## -examples

## -see-also
