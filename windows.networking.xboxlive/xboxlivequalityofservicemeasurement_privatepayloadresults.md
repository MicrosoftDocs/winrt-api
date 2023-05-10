---
-api-id: P:Windows.Networking.XboxLive.XboxLiveQualityOfServiceMeasurement.PrivatePayloadResults
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.Networking.XboxLive.XboxLiveQualityOfServicePrivatePayloadResult> PrivatePayloadResults { get; }
-->

# Windows.Networking.XboxLive.XboxLiveQualityOfServiceMeasurement.PrivatePayloadResults

## -description

Gets a list of private payloads that have been retrieved in this Quality of Service (QoS) measurement.

Note that private payloads are retrieved only when the **ShouldRequestPrivatePayloads** property is set to `true` before **MeasureAsync** is called.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -property-value

List of private payload information.

## -remarks

## -examples

## -see-also
