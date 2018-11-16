---
-api-id: E:Windows.Devices.PointOfService.ClaimedMagneticStripeReader.Closed
-api-type: winrt event
ms.custom: RS5
---

<!-- Event syntax.
public event TypedEventHandler Closed<ClaimedMagneticStripeReader, ClaimedMagneticStripeReaderClosedEventArgs>
-->

# Windows.Devices.PointOfService.ClaimedMagneticStripeReader.Closed

## -description
Event that is raised when the **ClaimedMagneticStripeReader** is closed.

## -remarks
When an app is suspended, all **ClaimedMagneticStripeReader** objects are closed. This event can be useful to determine when magnetic stripe reader connections need to be re-established.

## -see-also
[IClosable](../windows.foundation/iclosable.md)

## -examples

