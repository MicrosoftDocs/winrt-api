---
-api-id: P:Windows.Networking.XboxLive.XboxLiveEndpointPair.RemotePort
-api-type: winrt property
---

<!-- Property syntax
public string RemotePort { get; }
-->

# Windows.Networking.XboxLive.XboxLiveEndpointPair.RemotePort

## -description

Gets the port for the remote endpoint.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -property-value

The port for the remote endpoint.

## -remarks

This value will be zero if the **XboxLiveEndpointPairTemplate** allowed dynamically-assigned port numbers. In that case, your app will have to determine the remote port number through other means.

The remote port number returned by this property is valid only on the calling device. To retrieve the remote network identity for use by other peers, use the corresponding **XboxLiveDeviceAddress** object, and send a snapshot of that object to the other peers. 

## -examples

## -see-also
