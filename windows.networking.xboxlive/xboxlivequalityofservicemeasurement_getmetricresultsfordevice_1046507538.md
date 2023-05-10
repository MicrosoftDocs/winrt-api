---
-api-id: M:Windows.Networking.XboxLive.XboxLiveQualityOfServiceMeasurement.GetMetricResultsForDevice(Windows.Networking.XboxLive.XboxLiveDeviceAddress)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.Networking.XboxLive.XboxLiveQualityOfServiceMetricResult> GetMetricResultsForDevice(Windows.Networking.XboxLive.XboxLiveDeviceAddress deviceAddress)
-->

# Windows.Networking.XboxLive.XboxLiveQualityOfServiceMeasurement.GetMetricResultsForDevice

## -description

Gets all metric results for a given device.

Your code specifies a set of metrics, device addresses, timeouts, and number of probes to attempt, and then calls **XboxLiveQualityOfServiceMeasurement.MeasureAsync** to begin making the specified measurements. You can call **GetMetricResultsForDevice** at any time while measurements are in progress or after they have finished, and retrieve current values. Note that if you repeatedly call **GetMetricResultsForDevice**, and inspect a given metric while the relevant measurements are in progress, you might get different values as the measurement proceeds.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -parameters

### -param deviceAddress

The address of the device.

## -returns

A list of metric results.

## -remarks

## -examples

## -see-also
