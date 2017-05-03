---
-api-id: M:Windows.Devices.PointOfService.CashDrawer.CheckHealthAsync(Windows.Devices.PointOfService.UnifiedPosHealthCheckLevel)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<string> CheckHealthAsync(Windows.Devices.PointOfService.UnifiedPosHealthCheckLevel level)
-->

# Windows.Devices.PointOfService.CashDrawer.CheckHealthAsync

## -description
Gets the device's health state asynchronously.

## -parameters
### -param level
The specified health check level.

## -returns
This value is intended to be reflected in the app interface immediately so the user of the app can interpret it. For example, it will return “OK” as the health string if the device state is good.

## -remarks
This feature behaves identically to corresponding features in the other POS peripherals, and support for this operation is required by the UPOS standard.

## -examples

## -see-also
