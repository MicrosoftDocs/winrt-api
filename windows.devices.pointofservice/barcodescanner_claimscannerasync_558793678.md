---
-api-id: M:Windows.Devices.PointOfService.BarcodeScanner.ClaimScannerAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.PointOfService.ClaimedBarcodeScanner> ClaimScannerAsync()
-->

# Windows.Devices.PointOfService.BarcodeScanner.ClaimScannerAsync

## -description
Attempts to get an exclusive access to the barcode scanner.

## -returns
When the method completes, it returns a [ClaimedBarcodeScanner](claimedbarcodescanner.md).

## -remarks

## -examples


[!code-cpp[ClaimBarcodeScanner](../windows.devices.pointofservice/code/BarcodeScanner/cpp/Scenario1.xaml.cpp#SnippetClaimBarcodeScanner)]

[!code-csharp[ClaimBarcodeScanner](../windows.devices.pointofservice/code/BarcodeScanner/cs/Scenario1.xaml.cs#SnippetClaimBarcodeScanner)]

## -see-also
[Barcode scanner sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BarcodeScanner)
soft.com/fwlink/p/?LinkId=620014)
