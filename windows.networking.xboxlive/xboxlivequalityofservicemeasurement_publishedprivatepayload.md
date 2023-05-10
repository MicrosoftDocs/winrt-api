---
-api-id: P:Windows.Networking.XboxLive.XboxLiveQualityOfServiceMeasurement.PublishedPrivatePayload
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.Streams.IBuffer PublishedPrivatePayload { get;  set; }
-->

# Windows.Networking.XboxLive.XboxLiveQualityOfServiceMeasurement.PublishedPrivatePayload

## -description

Gets or sets the private payload published for the local device.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -property-value

The local private payload.

## -remarks

The buffer is not permitted to exceed **MaxPrivatePayloadSize**, in Bytes.

The private payload is used by your app to pass app-specific state about the currently running game without creating an **XboxLiveEndpointPair**. An example could be: number of slots available in game, or time left in the current round. 

Private payload data bytes aren't interpreted or validated by **XboxLiveQualityOfServiceMeasurement** objects. They are transmitted as-is. As with all messages exchanged with remote devices over the network, apps should be mindful that the remote device publishing or receiving the private payload might not be running the same version of the app that's running locally. Consider using a versioning scheme, and always check that a payload is well-formed before acting on it.

## -examples

## -see-also
