---
-api-id: T:Windows.Networking.EndpointPair
-api-type: winrt class
---

<!-- Class syntax.
public class EndpointPair : Windows.Networking.IEndpointPair
-->

# Windows.Networking.EndpointPair

## -description
Provides data for the local endpoint and remote endpoint for a network connection, encapsulating both the hostname/IP address and 
service name/port information needed for network operations.

## -remarks
[EndpointPair](endpointpair.md) is used to initialize and provide data for endpoint pairs used in networking applications. 
The [EndpointPair](endpointpair.md) object provides data for both local and remote endpoints for a network connection, 
making it a fundamental building block for network connectivity scenarios.

### Endpoint composition

Each endpoint within an [EndpointPair](endpointpair.md) consists of two elements:
- **Hostname or IP address**: Represented by a [HostName](hostname.md) object
- **Service name or port number**: Represented as a string (e.g., "80", "http", "https")

The [EndpointPair](endpointpair.md) combines these into:
- **Local endpoint**: [LocalHostName](endpointpair_localhostname.md) and [LocalServiceName](endpointpair_localservicename.md)
- **Remote endpoint**: [RemoteHostName](endpointpair_remotehostname.md) and [RemoteServiceName](endpointpair_remoteservicename.md)

### Automatic endpoint resolution

The system provides automatic resolution for unspecified endpoint components:

[!NOTE]
If the [LocalHostName](endpointpair_localhostname.md) is null before establishing a network connection, the system will 
automatically provide an appropriate local IP address for the application to use.

[!NOTE]
If the [LocalServiceName](endpointpair_localservicename.md) is an empty string before establishing a network connection, 
the system will automatically assign an available TCP or UDP port for the application to use.

### Usage across networking APIs

[EndpointPair](endpointpair.md) is used by many classes across Windows Runtime networking namespaces:

**Socket operations:**
- [DatagramSocket](../windows.networking.sockets/datagramsocket.md) and 
  [StreamSocket](../windows.networking.sockets/streamsocket.md) classes can establish network connections and transfer data 
  using [EndpointPair](endpointpair.md) objects
- [GetSortedEndpointPairs](../windows.networking.connectivity/networkinformation_getsortedendpointpairs_1067659180.md) 
  returns optimized endpoint pairs for connection attempts

**Network discovery and Wi-Fi Direct:**
- [WiFiDirectDevice.GetConnectionEndpointPairs](../windows.devices.wifidirect/wifidirectdevice_getconnectionendpointpairs_1958888015.md) 
  returns [EndpointPair](endpointpair.md) objects for Wi-Fi Direct connections
- [NetworkInformation](../windows.networking.connectivity/networkinformation.md) class uses endpoint pairs for network 
  optimization scenarios

## -examples

## -see-also
[HostName](hostname.md),
[NetworkInformation](../windows.networking.connectivity/networkinformation.md),
[NetworkInformation.GetSortedEndpointPairs](../windows.networking.connectivity/networkinformation_getsortedendpointpairs_1067659180.md),
[DatagramSocket](../windows.networking.sockets/datagramsocket.md),
[StreamSocket](../windows.networking.sockets/streamsocket.md),
[Windows.Networking.Sockets](../windows.networking.sockets/windows_networking_sockets.md),
[WiFiDirectDevice.GetConnectionEndpointPairs](../windows.devices.wifidirect/wifidirectdevice_getconnectionendpointpairs_1958888015.md)
