---
-api-id: T:Windows.Networking.HostName
-api-type: winrt class
---

<!-- Class syntax.
public class HostName : Windows.Foundation.IStringable, Windows.Networking.IHostName
-->

# Windows.Networking.HostName

## -description
Represents a host name or IP address (domain, IPv4, IPv6, or Bluetooth) used by Windows networking APIs.

## -remarks
### Purpose
Encapsulates a network host identifier (domain, literal IP, or Bluetooth address) for use by higher-level APIs (sockets, connectivity queries, Wi‑Fi Direct).

### Types
`[Type](hostname_type.md)` distinguishes:
| Type | Example |
| -- | -- |
| DomainName | www.contoso.com |
| Ipv4 | 192.168.1.1 |
| Ipv6 | 2001:db8::1 |
| Bluetooth | 12:34:56:78:9A:BC |

### Key properties
| Property | Meaning |
| -- | -- |
| [RawName](hostname_rawname.md) | Original input string |
| [DisplayName](hostname_displayname.md) | Friendly / formatted representation |
| [CanonicalName](hostname_canonicalname.md) | Normalized form (useful for comparisons / logging) |
| [IPInformation](hostname_ipinformation.md) | Interface/IP metadata when bound to a local address |

### Usage patterns
| Scenario | Guidance |
| -- | -- |
| Socket connect | Pass a `HostName` plus service name to `StreamSocket.ConnectAsync` / `DatagramSocket.ConnectAsync` |
| Endpoint pairing | Combine in an [EndpointPair](endpointpair.md) for local/remote mapping |
| Local enumeration | Use [NetworkInformation.GetHostNames](../windows.networking.connectivity/networkinformation_gethostnames_1238522689.md) |

### Creation
```csharp
var domain  = new HostName("www.contoso.com");
var ipv4    = new HostName("192.168.1.1");
var ipv6    = new HostName("2001:db8::1");
```

### Comparison
Use [IsEqual](hostname_isequal_1366077980.md) instead of string comparison (canonicalization & type awareness).

### Best practices
- Validate expected `Type` before use (e.g., require literal IP vs domain if policy demands).
- Prefer domain names over hard-coded IPs to benefit from DNS / load balancing.
- Cache resolution results only briefly; allow the platform to re-resolve for failover.

### Security considerations
- Never assume a domain resolves to the same IP indefinitely; re-resolve for long-lived sessions as appropriate.
- Log canonical + raw forms for diagnostics, excluding user-entered sensitive hostnames if privacy policy restricts.

> [!NOTE]  
> A `HostName` does not perform DNS resolution until used by an API that needs an address.


## -examples

The following example creates a [HostName](hostname.md) and then tries to connect to the [HostName](hostname.md) using a 
[StreamSocket](../windows.networking.sockets/streamsocket.md).

```csharp
using Windows.Networking;
using Windows.Networking.Sockets;

HostName serverHost = new HostName("www.contoso.com");
StreamSocket clientSocket = new Windows.Networking.Sockets.StreamSocket();

// Try to connect to the remote host
await clientSocket.ConnectAsync(serverHost, "http");
```

```cppwinrt
#include <winrt/Windows.Networking.Sockets.h>
using namespace winrt;

int main()
{
    winrt::init_apartment();

    Windows::Networking::HostName hostName{ L"www.contoso.com" };
    Windows::Networking::Sockets::StreamSocket streamSocket;
    // Try to connect.
    streamSocket.ConnectAsync(hostName, L"http").get();
}
```

```cppcx
using namespace Windows::Networking;
using namespace Windows::Networking::Sockets;

HostName^ serverHost= ref new HostName("www.contoso.com");
StreamSocket^ clientSocket = ref new StreamSocket();

// Try to connect to the remote host
clientSocket->ConnectAsync(serverHost, "http");
```

## -see-also
[EndpointPair](endpointpair.md),
[IPInformation](../windows.networking.connectivity/ipinformation.md),
[NetworkInformation](../windows.networking.connectivity/networkinformation.md),
[NetworkInformation.GetHostNames](../windows.networking.connectivity/networkinformation_gethostnames_1238522689.md),
[DatagramSocket](../windows.networking.sockets/datagramsocket.md),
[StreamSocket](../windows.networking.sockets/streamsocket.md),
[Windows.Networking.Sockets](../windows.networking.sockets/windows_networking_sockets.md)

## -capabilities
internetClient, privateNetworkClientServer
