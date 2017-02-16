---
-api-id: P:Windows.Networking.ServiceDiscovery.Dnssd.DnssdServiceInstance.TextAttributes
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IMap<string, string> TextAttributes { get; }
-->

# Windows.Networking.ServiceDiscovery.Dnssd.DnssdServiceInstance.TextAttributes

## -description
Gets the attributes of this service instance, as a list of [name, value] pairs of strings. Attributes can be inspected by service clients to determine additional information about a service instance.

The specific attribute names and values used by a service are determined by the designer of the service. For example, a service instance for a multiplayer game might have attributes describing which game map the instance is using, or the game difficulty level of the instance. Different service instances would be active for different maps or difficulty levels, and a client using the game service could use the attribute values to determine which game server instance to connect to for the player's preferred map or difficulty level.

## -property-value
A collection of attribute [name,value] pairs.

## -remarks

## -examples

## -see-also
