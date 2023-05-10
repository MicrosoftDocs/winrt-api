---
-api-id: M:Windows.Networking.XboxLive.XboxLiveQualityOfServiceMeasurement.GetMetricResult(Windows.Networking.XboxLive.XboxLiveDeviceAddress,Windows.Networking.XboxLive.XboxLiveQualityOfServiceMetric)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Networking.XboxLive.XboxLiveQualityOfServiceMetricResult GetMetricResult(Windows.Networking.XboxLive.XboxLiveDeviceAddress deviceAddress, Windows.Networking.XboxLive.XboxLiveQualityOfServiceMetric metric)
-->

# Windows.Networking.XboxLive.XboxLiveQualityOfServiceMeasurement.GetMetricResult

## -description

Gets the results of the most recent measurement of a given metric on the connection to a given address.

Your code specifies a set of metrics, device addresses, timeouts, and number of probes to attempt, and then calls **XboxLiveQualityOfServiceMeasurement.MeasureAsync** to begin making the specified measurements. You can call **GetMetricResult** at any time while measurements are in progress or after they have finished, and retrieve its current value. Note that if you repeatedly call **GetMetricResult** for a given metric while the relevant measurements are in progress, you might get different values as the measurement proceeds.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -parameters

### -param deviceAddress

The target address of the measurement.

### -param metric

The metric value to retrieve.

## -returns

The result of the measurement.

## -remarks

## -examples

## -see-also
