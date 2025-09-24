---
-api-id: T:Windows.Networking.EndpointPair
-api-type: winrt class
---

<!-- Class syntax.
public class EndpointPair : Windows.Networking.IEndpointPair
-->

# Windows.Networking.EndpointPair

## -description
Represents a pairing of local and remote host/service identifiers (host name or IP plus service name or port) used to initiate or describe a network connection.

## -remarks
### Purpose
Encapsulates the tuple of (local host, local service, remote host, remote service) used by higher-level networking APIs
(e.g., sockets, Wi‑Fi Direct, connectivity helpers) to establish or describe a connection attempt.

### Components
| Role | Members | Notes |
| -- | -- | -- |
| Local endpoint | [LocalHostName](endpointpair_localhostname.md), [LocalServiceName](endpointpair_localservicename.md) | Either or both may be unspecified (null / empty) and resolved by the system |
| Remote endpoint | [RemoteHostName](endpointpair_remotehostname.md), [RemoteServiceName](endpointpair_remoteservicename.md) | Must normally identify the target host + service/port |

### Automatic resolution
- If `LocalHostName` is null when a socket bind/connect starts, the system selects an appropriate local interface address.
- If `LocalServiceName` is empty, an ephemeral (dynamic) port is allocated.
Query the resulting bound socket properties after connect/bind to learn the chosen address/port.

### Common usage
| Scenario | API pattern |
| -- | -- |
| Establish UDP / TCP socket | Pass an `EndpointPair` to [DatagramSocket.ConnectAsync] or [StreamSocket.ConnectAsync] |
| Ordered connection attempts (Happy Eyeballs / multi-path) | Use [NetworkInformation.GetSortedEndpointPairs](../windows.networking.connectivity/networkinformation_getsortedendpointpairs_1067659180.md) then iterate |
| Wi‑Fi Direct connection endpoints | Retrieve list from [WiFiDirectDevice.GetConnectionEndpointPairs](../windows.devices.wifidirect/wifidirectdevice_getconnectionendpointpairs_1958888015.md) |

### Best practices
- Avoid hard-coding numeric ports where a well-known service name (e.g., "https") conveys intent and may map correctly on non-standard configurations.
- Reuse a resolved local endpoint only while the underlying interface remains valid; interface changes (roam / suspend) can invalidate prior local addresses.
- Prefer specifying the remote service name (string) instead of resolving it separately to a port number—lets the platform apply service-specific policies.
- For dual-stack (IPv4/IPv6) targets, obtain a ranked list with `GetSortedEndpointPairs` and attempt in order rather than guessing.

### Diagnostics
Log both remote and resolved local endpoint information (host + port) when capturing connection telemetry to accelerate troubleshooting (e.g., NAT / firewall issues).

> [!NOTE]  
> Ephemeral local ports are automatically recycled by the OS after the socket closes; do not attempt manual reservation beyond the socket lifetime.


## -examples

## -see-also
[DatagramSocket](../windows.networking.sockets/datagramsocket.md),
[HostName](hostname.md),
[NetworkInformation](../windows.networking.connectivity/networkinformation.md),
[NetworkInformation.GetSortedEndpointPairs](../windows.networking.connectivity/networkinformation_getsortedendpointpairs_1067659180.md),
[StreamSocket](../windows.networking.sockets/streamsocket.md),
[WiFiDirectDevice.GetConnectionEndpointPairs](../windows.devices.wifidirect/wifidirectdevice_getconnectionendpointpairs_1958888015.md),
[Windows.Networking.Sockets](../windows.networking.sockets/windows_networking_sockets.md)
