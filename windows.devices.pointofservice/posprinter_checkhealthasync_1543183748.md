---
-api-id: M:Windows.Devices.PointOfService.PosPrinter.CheckHealthAsync(Windows.Devices.PointOfService.UnifiedPosHealthCheckLevel)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<string> CheckHealthAsync(Windows.Devices.PointOfService.UnifiedPosHealthCheckLevel level)
-->

# Windows.Devices.PointOfService.PosPrinter.CheckHealthAsync

## -description
Gets the health state of the point-of-service printer asynchronously.

## -parameters
### -param level
The type of health check that you want to perform for the point-of-service printer. Only level POSInternal(1) should be used, as any other [UnifiedPosHealthCheckLevel](unifiedposhealthchecklevel.md) levels will result in an error.

## -returns
An asynchronous operation that returns the health state of the point-of-service printer. You should display this value in the app interface immediately so the user of the app can interpret the value. For example, the operation returns “OK” as the health state if the state of the point-of-service printer is good.

## -remarks

## -examples

## -see-also
