---
-api-id: M:Windows.Networking.XboxLive.XboxLiveQualityOfServiceMeasurement.GetMetricResultsForMetric(Windows.Networking.XboxLive.XboxLiveQualityOfServiceMetric)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.Networking.XboxLive.XboxLiveQualityOfServiceMetricResult> GetMetricResultsForMetric(Windows.Networking.XboxLive.XboxLiveQualityOfServiceMetric metric)
-->

# Windows.Networking.XboxLive.XboxLiveQualityOfServiceMeasurement.GetMetricResultsForMetric

## -description

Gets the most recent values of a given metric, across all devices being measured.

Your code specifies a set of metrics, device addresses, timeouts, and number of probes to attempt, and then calls **XboxLiveQualityOfServiceMeasurement.MeasureAsync** to begin making the specified measurements. You can call **GetMetricResultsForMetric** at any time while measurements are in progress or after they have finished, and retrieve current values. Note that if you repeatedly call **GetMetricResultsForMetric**. and inspect a given metric for a particular device while the relevant measurements are in progress, you might get different values as the measurement proceeds.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -parameters

### -param metric

The metric to be retrieved.

## -returns

A list of metric values for all devices being measured.

## -remarks

## -examples

## -see-also
