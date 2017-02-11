---
-api-id: P:Windows.Networking.EndpointPair.RemoteHostName
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.HostName RemoteHostName { get;  set; }
-->

# Windows.Networking.EndpointPair.RemoteHostName

## -description
Get or set the remote hostname for the [EndpointPair](endpointpair.md) object.

## -property-value
The remote hostname for the [EndpointPair](endpointpair.md) object.

## -remarks
The [RemoteHostName](endpointpair_remotehostname.md) property can contain a hostname or an IP address to connect to. The remote hostname must be supplied for the remote endpoint of the [EndpointPair](endpointpair.md) object before a network connection can be established by a client app.

The [RemoteHostName](endpointpair_remotehostname.md) property can be set to one of the following:


+ The name of the remote host that can be resolved by the Domain Name System (DNS) or by another namespace provider.
+ The name of the host that matches a string in the following file on the local computer: *%WINDIR%\\system32\drivers\etc\hosts*
+ A string that contains an IPv4 or an IPv6 network address of the remote host. An IPv4 address string is in dotted-decimal notation ("192.168.1.111", for example). An IPv6 address is in hexadecimal notation ("21DA:00D3:0010:2F3B:02AA:00FF:FE28:9C5A", for example).
When this property is set to the "localhost" string, this represents all loopback addresses on the local computer.

It is an error to set the [RemoteHostName](endpointpair_remotehostname.md) property to null or an empty string.

## -examples

## -see-also
[HostName](hostname.md), [Windows.Networking](windows_networking.md)