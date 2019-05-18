---
-api-id: P:Windows.Networking.EndpointPair.RemoteServiceName
-api-type: winrt property
---

<!-- Property syntax
public string RemoteServiceName { get;  set; }
-->

# Windows.Networking.EndpointPair.RemoteServiceName

## -description
Get or set the remote service name for the [EndpointPair](endpointpair.md) object.

## -property-value
The remote service name for the [EndpointPair](endpointpair.md) object.

## -remarks
The RemoteServiceName property can contain a service name or a TCP or UDP port number for a remote network destination. The remote service name must be supplied for the remote endpoint of the [EndpointPair](endpointpair.md) object before a network connection can be established by a client app.

The RemoteServiceName property can be set to one of the following:


+ A numeric literal for a TCP or UDP port number (80 for the TCP port used for http, for example).
+ A string alias for a port number ("http", for example) that matches a string in the following file on the local computer: *%WINDIR%\system32\drivers\etc\services*
+ A service name that can be resolved by a namespace provider using a SRV record.
It is an error to set the RemoteServiceName property to null.

## -examples

## -see-also
[Windows.Networking](windows_networking.md)
