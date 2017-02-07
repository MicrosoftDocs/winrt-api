---
-api-id: E:Windows.Devices.PointOfService.ClaimedBarcodeScanner.DataReceived
-api-type: winrt event
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



> [!div class="tabbedCodeSnippets"][!code-cpp[SetupBarcodeScanner](../windows.devices.pointofservice/code/BarcodeScanner/cpp/Scenario1.xaml.cpp#SnippetSetupBarcodeScanner)][!code-cs[SetupBarcodeScanner](../windows.devices.pointofservice/code/BarcodeScanner/cs/Scenario1.xaml.cs#SnippetSetupBarcodeScanner)]



> [!div class="tabbedCodeSnippets"][!code-cpp[DataReceived](../windows.devices.pointofservice/code/BarcodeScanner/cpp/Scenario1.xaml.cpp#SnippetDataReceived)][!code-cs[DataReceived](../windows.devices.pointofservice/code/BarcodeScanner/cs/Scenario1.xaml.cs#SnippetDataReceived)][!code-js[DataReceived](../windows.devices.pointofservice/code/BarcodeScanner/js/scenario1.js#SnippetDataReceived)]



[!code-js[CreateBarcodeScannerJS](../windows.devices.pointofservice/code/BarcodeScanner/js/scenario1.js#SnippetCreateBarcodeScannerJS)]



[!code-js[DataReceivedJS](../windows.devices.pointofservice/code/BarcodeScanner/js/scenario1.js#SnippetDataReceivedJS)]

## -see-also
[Barcode scanner sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620014)
