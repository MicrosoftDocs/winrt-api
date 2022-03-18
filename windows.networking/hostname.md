---
-api-id: T:Windows.Networking.HostName
-api-type: winrt class
---

<!-- Class syntax.
public class HostName : Windows.Foundation.IStringable, Windows.Networking.IHostName
-->

# Windows.Networking.HostName

## -description
Provides data for a hostname or an IP address.

## -remarks
The HostName class is used to initialize and provide data for a hostname used in network apps. A HostName object can be used for a local hostname or a remote hostname used to establish a network connection.

The HostName object is used by many classes in other related namespaces for network apps. These include the following:

+ Many classes in the [Windows.Networking.Sockets](../windows.networking.sockets/windows_networking_sockets.md) namespace using sockets. Methods on the [DatagramSocket](../windows.networking.sockets/datagramsocket.md) and [StreamSocket](../windows.networking.sockets/streamsocket.md) classes can be used to establish network connections and transfer data to a remote HostName object.
+ The [NetworkInformation](../windows.networking.connectivity/networkinformation.md) class in the [Windows.Networking.Connectivity](../windows.networking.connectivity/windows_networking_connectivity.md) namespace.
The following example creates a HostName and then tries to connect to the HostName using a [StreamSocket](../windows.networking.sockets/streamsocket.md).

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

## -examples

## -see-also
[DatagramSocket](../windows.networking.sockets/datagramsocket.md), [EndpointPair](endpointpair.md), [IStringable](../windows.foundation/istringable.md), [NetworkInformation](../windows.networking.connectivity/networkinformation.md), [StreamSocket](../windows.networking.sockets/streamsocket.md), [Windows.Networking](windows_networking.md), [Windows.Networking.Sockets](../windows.networking.sockets/windows_networking_sockets.md)

## -capabilities
internetClient, privateNetworkClientServer
