---
-api-id: T:Windows.Networking.XboxLive.XboxLiveEndpointPair
-api-type: winrt class
---

<!-- Class syntax.
public class XboxLiveEndpointPair : Windows.Networking.XboxLive.IXboxLiveEndpointPair
-->

# Windows.Networking.XboxLive.XboxLiveEndpointPair

## -description

An **XboxLiveEndpointPair** is a security and network quality relationship established between two devices for socket-based communication.

The **Windows.Networking.XboxLive** API enables peer-to-peer (P2P) connectivity in varied environments, leveraging IPv4, IPv6, and Microsoft's Network Address Translation (NAT) traversal technologies and services (such as Teredo) to determine and configure the best available network path between endpoints. It also establishes encryption of traffic and protection against tampering, as a measure to reduce cheating. Additionally, it authenticates users and applications through the Xbox Live ecosystem&dmash;integrating connectivity information with other Xbox Live services. This information can then be used in matchmaking, to attempt to match players with similar connectivity stats against each other.

The **Windows.Networking.XboxLive** API complements and extends traditional networking transports such as TCP and UDP, and the available sockets APIs, WinSock and **Windows.Networking.Sockets**. You create an **XboxLiveEndpointPair** using this API, and then use your preferred transport API for actual data transmission. The **XboxLiveEndpointPair** concept itself is related to **Windows.Networking.EndpointPair** in that it can be interpreted as a set of local and remote IP addresses and ports; but with an **XboxLiveEndpointPair**, those properties are read-only (because the system negotiates them) and have an associated validity lifetime (because an **XboxLiveEndpointPair** represents an active security relationship that can be terminated for various reasons).

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -remarks

You don't create instances of this class using a constructor. Instead, you do so using one of the **CreateEndpointPairAsync** or **CreateEndpointPairForPorts** methods in the **XboxLiveEndpointPairTemplate** class, in order to create an endpoint pair that follows a particular communication template.

## -examples

## -see-also
