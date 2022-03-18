---
-api-id: E:Windows.Devices.PointOfService.ClaimedBarcodeScanner.ReleaseDeviceRequested
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.EventHandler ReleaseDeviceRequested<Windows.Devices.PointOfService.ClaimedBarcodeScanner>
-->

# Windows.Devices.PointOfService.ClaimedBarcodeScanner.ReleaseDeviceRequested

## -description
Occurs when the device gets a request to release its exclusive claim.

## -remarks
If your application receives a ReleaseDeviceRequested event from another application, it may lose its exclusive claim unless your application retains the device.

## -examples
The following example shows how to setup the event handler.



[!code-cpp[SetupBarcodeScanner](../windows.devices.pointofservice/code/BarcodeScanner/cpp/Scenario1.xaml.cpp#SnippetSetupBarcodeScanner)]

[!code-csharp[SetupBarcodeScanner](../windows.devices.pointofservice/code/BarcodeScanner/cs/Scenario1.xaml.cs#SnippetSetupBarcodeScanner)]



[!code-cpp[ReleaseDeviceRequested](../windows.devices.pointofservice/code/BarcodeScanner/cpp/Scenario1.xaml.cpp#SnippetReleaseDeviceRequested)]

[!code-csharp[ReleaseDeviceRequested](../windows.devices.pointofservice/code/BarcodeScanner/cs/Scenario1.xaml.cs#SnippetReleaseDeviceRequested)]

## -see-also
[Barcode scanner sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BarcodeScanner)
