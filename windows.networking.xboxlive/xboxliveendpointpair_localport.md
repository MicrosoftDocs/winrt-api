---
-api-id: P:Windows.Networking.XboxLive.XboxLiveEndpointPair.LocalPort
-api-type: winrt property
---

<!-- Property syntax
public string LocalPort { get; }
-->

# Windows.Networking.XboxLive.XboxLiveEndpointPair.LocalPort

## -description

Gets the port for the local endpoint.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -property-value

The local port.

## -remarks

This value will be zero if the **XboxLiveEndpointPairTemplate** allowed dynamically-assigned port numbers. In that case, your app will have to determine the remote port number through external means. 

The local port number returned by this property is valid only on the calling device. To retrieve the local network identity for use by remote peers, use the corresponding **XboxLiveDeviceAddress** object, and send a snapshot of that object to the remote peer.

## -examples

## -see-also
