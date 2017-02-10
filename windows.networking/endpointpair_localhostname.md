---
-api-id: P:Windows.Networking.EndpointPair.LocalHostName
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.HostName LocalHostName { get;  set; }
-->

# Windows.Networking.EndpointPair.LocalHostName

## -description
Get or set the local hostname for the [EndpointPair](endpointpair.md) object.

## -property-value
The local hostname for the [EndpointPair](endpointpair.md) object.

## -remarks
The [LocalHostName](endpointpair_localhostname.md) property can contain a local hostname or an IP address.

The [LocalHostName](endpointpair_localhostname.md) property can be set to one of the following:


+ The name of the local host that can be resolved by the Domain Name System (DNS) or by another namespace provider.
+ The name of the local host that matches a string in the following file on the local computer: *%WINDIR%\\system32\drivers\etc\hosts*
+ A string that contains an IPv4 or an IPv6 network address of the local host. An IPv4 address string is in dotted-decimal notation ("192.168.1.111", for example). An IPv6 address is in hexadecimal notation ("21DA:00D3:0010:2F3B:02AA:00FF:FE28:9C5A", for example).
When this property is set to the "localhost" string, this represents all loopback addresses on the local computer.

The [NetworkInformation.GetHostNames](../windows.networking.connectivity/networkinformation_gethostnames.md) method in the [Windows.Networking.Connectivity](../windows.networking.connectivity/windows_networking_connectivity.md) namespace can be used to retrieve a list of hostnames or IP addresses associated with the local machine. The [LocalHostName](endpointpair_localhostname.md) property can then be set to one of these hostnames or IP addresses.

The [LocalHostName](endpointpair_localhostname.md) property can also be set to null. If the [LocalHostName](endpointpair_localhostname.md) property is null before a network connection is established by a client app, then the system will automatically provide the local IP address for the app to use.

## -examples

## -see-also
[HostName](hostname.md), [Windows.Networking](windows_networking.md)