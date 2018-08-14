---
-api-id: M:Windows.Networking.EndpointPair.#ctor(Windows.Networking.HostName,System.String,Windows.Networking.HostName,System.String)
-api-type: winrt method
---

<!-- Method syntax
public EndpointPair(Windows.Networking.HostName localHostName, System.String localServiceName, Windows.Networking.HostName remoteHostName, System.String remoteServiceName)
-->

# Windows.Networking.EndpointPair.EndpointPair

## -description
Creates a new [EndpointPair](endpointpair.md) object.

## -parameters
### -param localHostName
The local hostname or IP address for the [EndpointPair](endpointpair.md) object.

### -param localServiceName
The local service name or the local TCP or UDP port number for the [EndpointPair](endpointpair.md) object.

### -param remoteHostName
The remote hostname or IP address for the [EndpointPair](endpointpair.md) object.

### -param remoteServiceName
The remote service name or the remote TCP or UDP port number for the [EndpointPair](endpointpair.md) object.

## -remarks
This constructor creates a new [EndpointPair](endpointpair.md) object from a local hostname, a local service name, a remote hostname, and a remote service name. The [EndpointPair](endpointpair.md) object provides data used by network apps for the local endpoint and remote endpoint for a network connection.

An endpoint consists of two components:


+ The hostname or IP address.
+ The service name or the TCP or UDP port number.
An endpoint pair consists of two components:


+ The local endpoint for a network connection.
+ The remote endpoint for a network connection.
The *localHostName* parameter can contain one of the following:


+ The name of the local host that can be resolved by the Domain Name System (DNS) or by another namespace provider.
+ The name of the local host that matches a string in the following file on the local computer: *%WINDIR%\\system32\drivers\etc\hosts*
+ A string that contains an IPv4 or an IPv6 network address of the local host. An IPv4 address string is in dotted-decimal notation ("192.168.1.111", for example). An IPv6 address is in hexadecimal notation ("21DA:00D3:0010:2F3B:02AA:00FF:FE28:9C5A", for example).
If the *localHostName* parameter is the "localhost" string, this represents all loopback addresses on the local computer.

The [NetworkInformation.GetHostNames](../windows.networking.connectivity/networkinformation_gethostnames_136280557.md) method in the [Windows.Networking.Connectivity](../windows.networking.connectivity/windows_networking_connectivity.md) namespace can be used to retrieve a list of host names or IP addresses associated with the local machine. One of these hostnames or IP addresses can then be used for the *localHostName* parameter.

The *localHostName* parameter can also be set to null. If the *localHostName* is null before a network connection is established by a client app, then the system will automatically provide the local IP address for the app to use.

The *localServiceName* parameter can contain one of the following:


+ A numeric literal for a TCP or UDP port number (80 for the TCP port used for http, for example).
+ A string alias for a port number ("http", for example) that matches a string in the following file on the local computer: *%WINDIR%\system32\drivers\etc\services*
+ A service name that can be resolved by a namespace provider using a SRV record.
The *localServiceName* parameter can also contain an empty string. If the local service name is an empty string for the local endpoint before a network connection is established, then the system will automatically provide a TCP or UDP IP port number for the app to use when establishing a network connection.

The constructor will fail if the *localServiceName* parameter is null.

The *remoteHostName* parameter can contain one of the following:


+ The name of the remote host that can be resolved by the Domain Name System (DNS) or by another namespace provider.
+ The name of the host that matches a string in the following file on the local computer: *%WINDIR%\\system32\drivers\etc\hosts*
+ A string that contains an IPv4 or an IPv6 network address of the remote host. An IPv4 address string is in dotted-decimal notation ("192.168.1.111", for example). An IPv6 address is in hexadecimal notation ("21DA:00D3:0010:2F3B:02AA:00FF:FE28:9C5A", for example).
If the *remoteHostName* parameter is the "localhost" string, this represents all loopback addresses on the local computer.

The constructor will fail if the *remoteHostName* parameter is null or contains an empty string.

The *remoteServiceName* parameter can contain one of the following:


+ A numeric literal for a TCP or UDP port number (80 for the TCP port used for http, for example).
+ A string alias for a port number ("http", for example) that matches a string in the following file on the local computer: *%WINDIR%\system32\drivers\etc\services*
+ A service name that can be resolved by a namespace provider using a SRV record.
The constructor will fail if the *remoteServiceName* parameter is null or contains an empty string.

## -examples

## -see-also
[Windows.Networking](windows_networking.md)