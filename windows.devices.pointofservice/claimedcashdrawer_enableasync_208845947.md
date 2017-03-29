---
-api-id: M:Windows.Devices.PointOfService.ClaimedCashDrawer.EnableAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> EnableAsync()
-->

# Windows.Devices.PointOfService.ClaimedCashDrawer.EnableAsync

## -description
Asynchronously notifies the underlying hardware to power on for use.

## -returns
Whether the attempt to enable succeeded or not.

## -remarks
This behaves identically to the existing POS peripheral API with the exception that this API returns an instance of IAsyncOperation&lt;boolean&gt; instead of IAsyncAction, so the caller does not need to catch exceptions to determine whether the attempt to enable succeeded or not.

## -examples

## -see-also
