---
-api-id: P:Windows.Networking.HostName.IPInformation
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.Connectivity.IPInformation IPInformation { get; }
-->

# Windows.Networking.HostName.IPInformation

## -description
Gets the [IPInformation](../windows.networking.connectivity/ipinformation.md) object for a local IP address assigned to a [HostName](hostname.md) object.

## -property-value
The [IPInformation](../windows.networking.connectivity/ipinformation.md) object for the IP address.

## -remarks
The [IPInformation](../windows.networking.connectivity/ipinformation.md) property is only set when the [HostName](hostname.md) object is a local IPv4 or IPv6 address returned by the [GetHostNames](../windows.networking.connectivity/networkinformation_gethostnames.md) method. This property represents the [IPInformation](../windows.networking.connectivity/ipinformation.md) object for the local IP address. If the [HostName](hostname.md) object is not a local IPv4 or IPv6 address, this property will be null.

## -examples

## -see-also
[DatagramSocket](../windows.networking.sockets/datagramsocket.md), [StreamSocket](../windows.networking.sockets/streamsocket.md)