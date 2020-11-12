---
-api-id: E:Windows.Devices.PointOfService.ClaimedBarcodeScanner.DataReceived
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler DataReceived<Windows.Devices.PointOfService.ClaimedBarcodeScanner,  Windows.Devices.PointOfService.BarcodeScannerDataReceivedEventArgs>
-->

# Windows.Devices.PointOfService.ClaimedBarcodeScanner.DataReceived

## -description
Occurs when the device scans a barcode.

## -remarks

## -examples
The following example shows how to setup the barcode scanner to receive data after a scanning event.



[!code-cpp[SetupBarcodeScanner](../windows.devices.pointofservice/code/BarcodeScanner/cpp/Scenario1.xaml.cpp#SnippetSetupBarcodeScanner)]

[!code-csharp[SetupBarcodeScanner](../windows.devices.pointofservice/code/BarcodeScanner/cs/Scenario1.xaml.cs#SnippetSetupBarcodeScanner)]



[!code-cpp[DataReceived](../windows.devices.pointofservice/code/BarcodeScanner/cpp/Scenario1.xaml.cpp#SnippetDataReceived)]

[!code-csharp[DataReceived](../windows.devices.pointofservice/code/BarcodeScanner/cs/Scenario1.xaml.cs#SnippetDataReceived)]

## -see-also
[Barcode scanner sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BarcodeScanner)
