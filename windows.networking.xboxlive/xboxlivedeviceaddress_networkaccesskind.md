---
-api-id: P:Windows.Networking.XboxLive.XboxLiveDeviceAddress.NetworkAccessKind
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.XboxLive.XboxLiveNetworkAccessKind NetworkAccessKind { get; }
-->

# Windows.Networking.XboxLive.XboxLiveDeviceAddress.NetworkAccessKind

## -description

Gets a value that describes the level of peer-to-peer network access observed for **XboxLiveEndpointPair** communication involving this **XboxLiveDeviceAddress**. The indicated access is applicable only to communication established through the Xbox Live Multiplayer Networking API infrastructure. If you establish your own insecure communication, or implement your own NAT traversal, then you might find that that code encounters a different access kind.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -property-value

Use this value to determine the network access level to the device represented by this **XboxLiveDeviceAddress**.

## -remarks

## -examples

## -see-also
