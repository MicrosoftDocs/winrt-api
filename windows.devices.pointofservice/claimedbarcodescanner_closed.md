---
-api-id: E:Windows.Devices.PointOfService.ClaimedBarcodeScanner.Closed
-api-type: winrt event
ms.custom: RS5
---

<!-- Event syntax.
public event TypedEventHandler Closed<ClaimedBarcodeScanner, ClaimedBarcodeScannerClosedEventArgs>
-->

# Windows.Devices.PointOfService.ClaimedBarcodeScanner.Closed

## -description
Event that is raised when the **ClaimedBarcodeScanner** is closed.

## -remarks
When an application is suspended, all **ClaimedBarcodeScanner** objects are closed. This event can be useful to determine when barcode scanner connections need to be re-established.

## -see-also
[IClosable](../windows.foundation/iclosable.md)

## -examples

