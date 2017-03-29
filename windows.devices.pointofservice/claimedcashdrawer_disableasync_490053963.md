---
-api-id: M:Windows.Devices.PointOfService.ClaimedCashDrawer.DisableAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> DisableAsync()
-->

# Windows.Devices.PointOfService.ClaimedCashDrawer.DisableAsync

## -description
Notifies the underlying hardware to power off.

## -returns
Whether the attempt to disable succeeded or not.

## -remarks
This behaves identically to the existing POS peripheral API with the exception that this API returns an instance of IAsyncOperation&lt;boolean&gt; instead of IAsyncAction, so the caller does not need to catch exceptions to determine whether the attempt to disable succeeded or not.

## -examples

## -see-also
