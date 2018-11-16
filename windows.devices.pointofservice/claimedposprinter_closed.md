---
-api-id: E:Windows.Devices.PointOfService.ClaimedPosPrinter.Closed
-api-type: winrt event
ms.custom: RS5
---

<!-- Event syntax.
public event TypedEventHandler Closed<ClaimedPosPrinter, ClaimedPosPrinterClosedEventArgs>
-->

# Windows.Devices.PointOfService.ClaimedPosPrinter.Closed

## -description
Event that is raised when the **ClaimedPosPrinter** is closed.

## -remarks
When an app is suspended, all **ClaimedPosPrinter** objects are closed. This event can be useful to determine when printer connections need to be re-established.

## -see-also
[IClosable](../windows.foundation/iclosable.md)

## -examples
