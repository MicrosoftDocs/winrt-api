---
-api-id: M:Windows.Networking.Connectivity.RoutePolicy.#ctor(Windows.Networking.Connectivity.ConnectionProfile,Windows.Networking.HostName,Windows.Networking.DomainNameType)
-api-type: winrt method
---

<!-- Method syntax
public RoutePolicy(Windows.Networking.Connectivity.ConnectionProfile connectionProfile, Windows.Networking.HostName hostName, Windows.Networking.DomainNameType type)
-->

# Windows.Networking.Connectivity.RoutePolicy.RoutePolicy

## -description
Creates an instance of [RoutePolicy](routepolicy.md) using the defined connection profile and host name values.

## -parameters
### -param connectionProfile
The connection profile

### -param hostName
The host name for the route policy to the special PDP context.

### -param type
The domain type of *hostName* when the [HostNameType](../windows.networking/hostnametype.md) value indicates a domain name.

## -remarks
A host name can be:<table>
   <tr><th>Value</th><th>Description</th></tr>
   <tr><td>Domain Name</td><td>All the traffic destined to this domain name will be routed to special PDP Context. If you specify Contoso.com, for example, all traffic going to *.Contoso.com will be routed to special PDP Context.</td></tr>
   <tr><td>IP Address</td><td>All the traffic destined to this IP Address will be routed to special PDP Context.</td></tr>
   <tr><td>Not specified</td><td>Windows will route all traffic to special PDP context.</td></tr>
</table>

## -examples

## -see-also
