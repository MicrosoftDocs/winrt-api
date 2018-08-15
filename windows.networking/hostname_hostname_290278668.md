---
-api-id: M:Windows.Networking.HostName.#ctor(System.String)
-api-type: winrt method
---

<!-- Method syntax
public HostName(System.String hostName)
-->

# Windows.Networking.HostName.HostName

## -description
Creates a new [HostName](hostname.md) object from a string that contains a hostname or an IP address.

## -parameters
### -param hostName
A string that contains a hostname or an IP address.

## -remarks
This constructor creates a new [HostName](hostname.md) object. The *hostName* parameter can contain a hostname or an IP address. A [HostName](hostname.md) object can be used for a local hostname or a remote hostname.

The *hostName* parameter can contain one of the following:


+ The name of a host that can be resolved by the Domain Name System (DNS) or by another namespace provider.
+ The name of a host that matches a string in the following file on the local computer: *%WINDIR%\\system32\drivers\etc\hosts*
+ A string that contains an IPv4 or an IPv6 network address of the host. An IPv4 address string is in dotted-decimal notation ("192.168.1.111", for example). An IPv6 address is in hexadecimal notation ("21DA:00D3:0010:2F3B:02AA:00FF:FE28:9C5A", for example).
If the *hostName* parameter is the "localhost" string, this represents all loopback addresses on the local computer.

The [NetworkInformation.GetHostNames](../windows.networking.connectivity/networkinformation_gethostnames_136280557.md) method in the [Windows.Networking.Connectivity](../windows.networking.connectivity/windows_networking_connectivity.md) namespace can be used to retrieve a list of host names or IP addresses associated with the local machine. One of these hostnames or IP addresses can then be used for the *hostName* parameter.

The constructor will fail if the *hostName* parameter is null or contains an empty string.

## -examples

## -see-also
[Windows.Networking](windows_networking.md)