---
-api-id: P:Windows.Networking.XboxLive.XboxLiveQualityOfServicePrivatePayloadResult.Value
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.Streams.IBuffer Value { get; }
-->

# Windows.Networking.XboxLive.XboxLiveQualityOfServicePrivatePayloadResult.Value

## -description

Gets the private payload. Format and meaning of the private payload bytes are determined by each individual app.

Private payload data bytes are not interpreted or validated by **XboxLiveQualityOfServiceMeasurement** objects. They are transmitted as-is. As with all messages exchanged with remote devices over the network, apps should be mindful that the remote device publishing or receiving the private payload might not be running the same version of the app that's running locally. Consider using a versioning scheme, and always check that a payload is well-formed before acting on it.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -property-value

The private payload.

## -remarks

## -examples

## -see-also
