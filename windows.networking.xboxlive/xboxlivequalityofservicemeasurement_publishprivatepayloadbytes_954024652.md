---
-api-id: M:Windows.Networking.XboxLive.XboxLiveQualityOfServiceMeasurement.PublishPrivatePayloadBytes(System.Byte[])
-api-type: winrt method
---

<!-- Method syntax
public void PublishPrivatePayloadBytes(System.Byte[] payload)
-->

# Windows.Networking.XboxLive.XboxLiveQualityOfServiceMeasurement.PublishPrivatePayloadBytes

## -description

Sets the private payload that's returned when a remote host queries for the private payload.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -parameters

### -param payload

The payload to publish when this host is queried for the private payload. The **MaxPrivatePayloadSize** property value specifies the maximum permitted size of the private payload, in bytes.

## -remarks

The private payload data being published is used by your app to pass app-specific state about the currently running game without creating an **XboxLiveEndpointPair**. Examples could be: number of slots available in game, or time left in the current round. 

Private payload data bytes aren't interpreted or validated by **XboxLiveQualityOfServiceMeasurement** objects. They are transmitted as-is. As with all messages exchanged with remote devices over the network, apps should be mindful that the remote device publishing or receiving the private payload might not be running the same version of the app that is running locally. Consider using a versioning scheme, and always check that a payload is well-formed before acting on it.

## -examples

## -see-also
