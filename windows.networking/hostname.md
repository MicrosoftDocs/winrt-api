---
-api-id: T:Windows.Networking.HostName
-api-type: winrt class
---

<!-- Class syntax.
public class HostName : Windows.Foundation.IStringable, Windows.Networking.IHostName
-->

# Windows.Networking.HostName

## -description
Provides data for a hostname or an IP address, serving as a fundamental building block for network operations across 
Windows Runtime networking APIs.

## -remarks
The [HostName](hostname.md) class is used to initialize and provide data for a hostname used in network applications. 
A [HostName](hostname.md) object can represent a local hostname or a remote hostname used to establish a network connection.

### Usage across networking APIs

The [HostName](hostname.md) object is used by many classes across Windows Runtime networking namespaces:

**Socket operations:**
- [DatagramSocket](../windows.networking.sockets/datagramsocket.md) and 
  [StreamSocket](../windows.networking.sockets/streamsocket.md) classes use [HostName](hostname.md) objects to establish 
  network connections and transfer data
- [EndpointPair](endpointpair.md) uses [HostName](hostname.md) objects to represent local and remote endpoints

**Network information:**
- [NetworkInformation](../windows.networking.connectivity/networkinformation.md) class in the 
  [Windows.Networking.Connectivity](../windows.networking.connectivity/windows_networking_connectivity.md) namespace
- [GetHostNames](../windows.networking.connectivity/networkinformation_gethostnames_1238522689.md) method returns collections 
  of [HostName](hostname.md) objects

### HostName properties and validation

Key properties of [HostName](hostname.md) include:
- **[Type](hostname_type.md)**: Indicates whether this is a domain name, IPv4 address, IPv6 address, or Bluetooth address
- **[RawName](hostname_rawname.md)**: The original hostname string as provided
- **[DisplayName](hostname_displayname.md)**: A formatted version suitable for display
- **[CanonicalName](hostname_canonicalname.md)**: The standardized form of the hostname
- **[IPInformation](hostname_ipinformation.md)**: Associated IP configuration when available

> [!IMPORTANT]
> Always validate [HostName](hostname.md) objects before using them in network operations. Use 
> [IsEqual](hostname_isequal_1366077980.md) to compare [HostName](hostname.md) instances, and check the 
> [Type](hostname_type.md) property to ensure you're working with the expected address format.

### Creating HostName objects

[HostName](hostname.md) objects are created using the constructor that takes a string parameter. The string can represent:
- Domain names (e.g., "www.contoso.com")
- IPv4 addresses (e.g., "192.168.1.1") 
- IPv6 addresses (e.g., "2001:db8::1")
- Bluetooth addresses (e.g., "12:34:56:78:9A:BC")

```csharp
// Create HostName objects for different address types
var domainName = new HostName("www.contoso.com");
var ipv4Address = new HostName("192.168.1.1");
var ipv6Address = new HostName("2001:db8::1");
```

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
