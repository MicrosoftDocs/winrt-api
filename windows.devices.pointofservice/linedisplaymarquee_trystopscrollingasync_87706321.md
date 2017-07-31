---
-api-id: M:Windows.Devices.PointOfService.LineDisplayMarquee.TryStopScrollingAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> LineDisplayMarquee.TryStopScrollingAsync()
-->

# Windows.Devices.PointOfService.LineDisplayMarquee.TryStopScrollingAsync

## -description
Attempts to asynchronously exit Marquee mode and/or Marquee Init mode. Format is set to None.

## -returns
Returns True if the marquee was successfully stopped; otherwise, False.

## -remarks
If the device is not already claimed when this method is called, this method will claim the device (without delay) and enable the device. If the device is already claimed by another process the call will fail.

## -see-also

## -examples

