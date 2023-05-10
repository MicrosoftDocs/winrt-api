---
-api-id: M:Windows.Networking.XboxLive.XboxLiveQualityOfServiceMeasurement.#ctor
-api-type: winrt method
---

<!-- Method syntax
public XboxLiveQualityOfServiceMeasurement()
-->

# Windows.Networking.XboxLive.XboxLiveQualityOfServiceMeasurement.XboxLiveQualityOfServiceMeasurement

## -description

Creates an **XboxLiveQualityOfServiceMeasurement** object.

To perform a Quality of Service (QoS) measurement, create an instance of this class, then set the parameters of the measurement using the **DeviceAddresses**, **Metrics**, **NumberOfProbesToAttempt**, **ShouldRequestPrivatePayloads**, and **TimeoutInMilliseconds** members. Then call **MeasureAsync** to initiate measurements. You can query results while the measurement is in progress, or you can wait until the operation finishes, and then query final results.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -remarks

## -examples

## -see-also
