---
-api-id: M:Windows.Devices.PointOfService.BarcodeScanner.GetDefaultAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.PointOfService.BarcodeScanner> GetDefaultAsync()
-->

# Windows.Devices.PointOfService.BarcodeScanner.GetDefaultAsync

## -description
Returns the first available barcode scanner.

## -returns
The first available barcode scanner. Returns a null object in the following cases:
+ A device is not found.
+ Access denied to the existing device. The user can deny access to a device, which is not treated as an exception.


## -remarks

## -examples


[!code-cpp[CreateBarcodeScanner](../windows.devices.pointofservice/code/BarcodeScanner/cpp/Scenario1.xaml.cpp#SnippetCreateBarcodeScanner)]

[!code-csharp[CreateBarcodeScanner](../windows.devices.pointofservice/code/BarcodeScanner/cs/Scenario1.xaml.cs#SnippetCreateBarcodeScanner)]

## -see-also
[Barcode scanner sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BarcodeScanner)
