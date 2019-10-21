---
-api-id: P:Windows.Networking.EndpointPair.LocalServiceName
-api-type: winrt property
---

<!-- Property syntax
public string LocalServiceName { get;  set; }
-->

# Windows.Networking.EndpointPair.LocalServiceName

## -description
Get or set the local service name for the [EndpointPair](endpointpair.md) object.

## -property-value
The local service name for the [EndpointPair](endpointpair.md) object.

## -remarks
The LocalServiceName property can contain a service name or a TCP or UDP port number. The LocalServiceName property can be set to one of the following:


+ A numeric literal for a TCP or UDP port number (80 for the TCP port typically used for http, for example).
+ A string alias for a port number ("http", for example) that matches a string in the following file on the local computer: *%WINDIR%\system32\drivers\etc\services*
+ A service name that can be resolved by a namespace provider using a SRV record.
The LocalServiceName property can also be set to an empty string. If the local service name is an empty string for the local endpoint before a network connection is established, then the system will automatically provide a TCP or UDP port number for the app to use when establishing a network connection.

It is an error to set the LocalServiceName property to null.

## -examples

## -see-also
[Windows.Networking](windows_networking.md)
