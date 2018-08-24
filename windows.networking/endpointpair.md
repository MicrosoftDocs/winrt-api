---
-api-id: T:Windows.Networking.EndpointPair
-api-type: winrt class
---

<!-- Class syntax.
public class EndpointPair : Windows.Networking.IEndpointPair
-->

# Windows.Networking.EndpointPair

## -description
Provides data for the local endpoint and remote endpoint for a network connection used by network apps.

## -remarks
The [EndpointPair](endpointpair.md) class is used to initialize and provide data for an endpoint pair used in network apps. The [EndpointPair](endpointpair.md) object provides data for the local endpoint and remote endpoint for a network connection. The [EndpointPair](endpointpair.md) object is used by many classes in other related namespaces for network apps. These include the following:


+ Many classes in the [Windows.Networking.Sockets](../windows.networking.sockets/windows_networking_sockets.md) namespace using sockets. Methods on the [DatagramSocket](../windows.networking.sockets/datagramsocket.md) and [StreamSocket](../windows.networking.sockets/streamsocket.md) classes can be used to establish network connections and transfer data using an [EndpointPair](endpointpair.md) object.
+ The [NetworkInformation](../windows.networking.connectivity/networkinformation.md) class in the [Windows.Networking.Connectivity](../windows.networking.connectivity/windows_networking_connectivity.md) namespace.
An endpoint consists of two elements:


+ The hostname or IP address.
+ The service name or the TCP or UDP port number.
An endpoint pair consists of two elements:


+ The local endpoint.
+ The remote endpoint.
If the local hostname is null for the local endpoint before a network connection is established by a client app, then the system will automatically provide the local IP address for the app to use.

If the local service name is an empty string for the local endpoint before a network connection is established by a client app, then the system will automatically provide a TCP or UDP port for the app to use.

The [WiFiDirectDevice](../windows.devices.wifidirect/wifidirectdevice.md) class can be used to locate other devices that have a Wi-Fi Direct (WFD) capable device. The [WiFiDirectDevice.GetDeviceSelector](../windows.devices.wifidirect/wifidirectdevice_getdeviceselector_185243134.md) method gets the device identifier for a nearby WFD device. Once you have a reference to a nearby WFD device, you can call the [WiFiDirectDevice.GetConnectionEndpointPairs](../windows.devices.wifidirect/wifidirectdevice_getconnectionendpointpairs_1958888015.md) method to get an [EndpointPair](endpointpair.md) object.

## -examples

## -see-also
[DatagramSocket](../windows.networking.sockets/datagramsocket.md), [HostName](hostname.md), [NetworkInformation](../windows.networking.connectivity/networkinformation.md), [StreamSocket](../windows.networking.sockets/streamsocket.md), [Windows.Networking](windows_networking.md), [Windows.Networking.Sockets](../windows.networking.sockets/windows_networking_sockets.md), [WiFiDirectDevice.GetConnectionEndpointPairs](../windows.devices.wifidirect/wifidirectdevice_getconnectionendpointpairs_1958888015.md)