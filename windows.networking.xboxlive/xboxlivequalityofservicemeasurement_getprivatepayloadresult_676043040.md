---
-api-id: M:Windows.Networking.XboxLive.XboxLiveQualityOfServiceMeasurement.GetPrivatePayloadResult(Windows.Networking.XboxLive.XboxLiveDeviceAddress)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Networking.XboxLive.XboxLiveQualityOfServicePrivatePayloadResult GetPrivatePayloadResult(Windows.Networking.XboxLive.XboxLiveDeviceAddress deviceAddress)
-->

# Windows.Networking.XboxLive.XboxLiveQualityOfServiceMeasurement.GetPrivatePayloadResult

## -description

Gets the private payload for a device currently being measured, if **ShouldRequestPrivatePayloads** was set to `true` for this measurement.

Your code specifies a set of metrics, device addresses, timeouts, number of probes to attempt, and whether to request private payloads, and then calls **XboxLiveQualityOfServiceMeasurement.MeasureAsync** to begin making the specified measurements, and to retrieve any private payloads.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -parameters

### -param deviceAddress

Device address of the device whose private payload is being retrieved.

## -returns

The private payload.

## -remarks

## -examples

## -see-also
