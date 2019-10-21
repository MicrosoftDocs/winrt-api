---
-api-id: T:Windows.Networking.HostNameSortOptions
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Networking.HostNameSortOptions : uint
-->

# HostNameSortOptions

## -description
Options for how a list of [EndpointPair](endpointpair.md) objects is sorted.

## -enum-fields
### -field None:0
Sort a list of [EndpointPair](endpointpair.md) objects by the default criteria used the system which is to minimize connection delays.

### -field OptimizeForLongConnections:2
Sort a list of [EndpointPair](endpointpair.md) objects to optimize for long connections.


## -remarks
The HostNameSortOptions enumeration affects how a list of [EndpointPair](endpointpair.md) objects are sorted.

Given an array of sorted address pairs, the **None** value returns a sorted list ordering the [EndpointPair](endpointpair.md) entries such that pairs with least tried source and destination addresses are prioritized over pairs whose addresses have been tried before and were unsuccessful. The goal is to minimize the connection establishment delay by trying [EndpointPair](endpointpair.md) entries with unique addresses first. This might result in less efficient address pairs to be preferred over efficient ones when considering network transfer speeds for long running connections, but that is considered less important than minimizing connection delays for short connections.

For example, if [EndpointPair](endpointpair.md) objects can have source addresses of S1 or S2 and destination addresses of D1 or D2, then by default if S1+D1 is the first [EndpointPair](endpointpair.md) tried and the connection fails, then S2+D2 is the second pair that would be tried. If the S1+D1 connection fails, the problem might be with either S1 or D1. So the safest option to minimize connection establishment delays would be to try S2+D2 when S1+D1 fails. For activities such as web browsing where speed of getting a connection established dominates, that is most likely the behavior you want.

However if the application is streaming media for a long time, you might be willing to accept a few initial failed connection attempts until you find a more efficient path for transferring data. That would use a different order for sorting. The **OptimizeForLongConnections** enumeration value would be used for this case. With this setting if S1+D1 fails, then S1+D2 or S2+D1 would be tried next.

## -examples

## -see-also
[HostName](hostname.md), [EndpointPair](endpointpair.md), [DatagramSocket.GetEndpointPairsAsync(HostName, String, HostNameSortOptions)](../windows.networking.sockets/datagramsocket_getendpointpairsasync_903639760.md)
