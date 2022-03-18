---
-api-id: M:Windows.Networking.HostName.IsEqual(Windows.Networking.HostName)
-api-type: winrt method
---

<!-- Method syntax
public bool IsEqual(Windows.Networking.HostName hostName)
-->

# Windows.Networking.HostName.IsEqual

## -description
Determines whether the specified [HostName](hostname.md) object has an equivalent value to the current [HostName](hostname.md) object.

## -parameters
### -param hostName
A [HostName](hostname.md) object that is compared with the current [HostName](hostname.md).

## -returns
A Boolean value that indicates whether the specified [HostName](hostname.md) object is equal to the current [HostName](hostname.md) object.

## -remarks
The [Equals](/dotnet/api/system.object.equals?view=dotnet-uwp-10.0&preserve-view=true) method determines whether the [HostName](hostname.md) object specified by the *hostName* parameter is the same instance of the current [HostName](hostname.md) object.

The IsEqual method determines whether the [HostName](hostname.md) object specified by the *hostName* parameter has an equivalent value to the current [HostName](hostname.md) object. Two [HostName](hostname.md) objects are considered to have the equivalent value if the [CanonicalName](hostname_canonicalname.md) property has the same value.

## -examples

## -see-also
[DatagramSocket](../windows.networking.sockets/datagramsocket.md), [StreamSocket](../windows.networking.sockets/streamsocket.md)
