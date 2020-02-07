---
-api-id: M:Windows.Devices.PointOfService.ClaimedBarcodeScanner.StartSoftwareTriggerAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction StartSoftwareTriggerAsync()
-->

# Windows.Devices.PointOfService.ClaimedBarcodeScanner.StartSoftwareTriggerAsync

## -description
Used to signal the barcode scanner to start scanning. A session is active until [StopSoftwareTriggerAsync](claimedbarcodescanner_stopsoftwaretriggerasync_1202164471.md) is invoked, or until the scanner ends the session on its own.

## -returns
No object or value is returned when this method completes.

## -remarks
When barcode data is received, your [DataReceived](/uwp/api/windows.devices.pointofservice.claimedbarcodescanner.datareceived) event handler is called. Also see [Use a software trigger](/windows/uwp/devices-sensors/pos-barcodescanner-software-trigger), and the [Barcode scanner sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/BarcodeScanner) application.

## -examples

## -see-also
