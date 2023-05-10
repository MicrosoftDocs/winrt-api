---
-api-id: T:Windows.Networking.XboxLive.XboxLiveNetworkAccessKind
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Networking.XboxLive.XboxLiveNetworkAccessKind : int
-->

# XboxLiveNetworkAccessKind

## -description

Defines constants that specify the different levels of peer-to-peer network access observed for **XboxLiveEndpointPair** communication. **XboxLiveNetworkAccessKind** is used to describe peer-to-peer connections established through the Xbox Live Multiplayer Networking API, and is not applicable to connections to Xbox Live web services or to peer-to-peer connections established outside of the Xbox Live Multiplayer Networking API.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -enum-fields

### -field Open:0

NAT type is open. Players behind these network address translation (NAT) types can usually connect to any other player.

### -field Moderate:1

NAT type is moderate. Players behind these NAT types can usually connect to others behind **Open** or **Moderate** types.

### -field Strict:2

NAT type is strict. Players behind this NAT type frequently experience connectivity problems with others unless those players are behind **Open** type devices.

## -remarks

## -examples

## -see-also
