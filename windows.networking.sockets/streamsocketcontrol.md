---
-api-id: T:Windows.Networking.Sockets.StreamSocketControl
-api-type: winrt class
---

<!-- Class syntax.
public class StreamSocketControl : Windows.Networking.Sockets.IStreamSocketControl, Windows.Networking.Sockets.IStreamSocketControl2, Windows.Networking.Sockets.IStreamSocketControl3
-->

# Windows.Networking.Sockets.StreamSocketControl

## -description
Provides socket control data on a [StreamSocket](streamsocket.md) object.

## -remarks
The [StreamSocketControl](streamsocketcontrol.md) class provides access to advanced socket control data on a [StreamSocket](streamsocket.md) object.

A [StreamSocketControl](streamsocketcontrol.md) object is automatically created with the parent [StreamSocket](streamsocket.md) object. The [StreamSocket.Control](streamsocket_control.md) property provides access to the associated [StreamSocketControl](streamsocketcontrol.md) object.

Any changes to the property values on the [StreamSocketControl](streamsocketcontrol.md) must be set before the [StreamSocket](streamsocket.md) is connected. As a result if you need to make changes to the [ClientCertificate](streamsocketcontrol_clientcertificate.md), [IgnorableServerCertificateErrors](streamsocketcontrol_ignorableservercertificateerrors.md), [KeepAlive](streamsocketcontrol_keepalive.md), [NoDelay](streamsocketcontrol_nodelay.md), [OutboundBufferSizeInBytes](streamsocketcontrol_outboundbuffersizeinbytes.md) , [OutboundUnicastHopLimit](streamsocketcontrol_outboundunicasthoplimit.md), or [QualityOfService](streamsocketcontrol_qualityofservice.md) properties, then these changes must occur before a successful call to one of the [ConnectAsync](streamsocket_connectasync_13692504.md) methods on the [StreamSocket](streamsocket.md).

Use the [ClientCertificate](streamsocketcontrol_clientcertificate.md) to set a client certificate to be used to make secure connections over the associated [StreamSocket](streamsocket.md) object.

The following example creates a [StreamSocket](streamsocket.md), and then demonstrates how to set the [NoDelay](streamsocketcontrol_nodelay.md) property to **false**. Other properties may be set in a similar manner. After this is done, the app can connect the [StreamSocket](streamsocket.md).

```csharp
using Windows.Networking.Sockets;

StreamSocket clientSocket = new StreamSocket();

// Get the current setting for this option.
// This isn't required, but it shows how to get the current setting.
bool currentSetting = clientSocket.Control.NoDelay;

// Set NoDelay to false so that the Nagle algorithm is not disabled.
clientSocket.Control.NoDelay = false;

// Now you can call the ConnectAsync method to connect the StreamSocket.
```

```cppwinrt
#include <winrt/Windows.Networking.Sockets.h>
using namespace winrt;
...
Windows::Networking::Sockets::StreamSocket clientSocket;

// Get the current setting for this option.
// This isn't required, but it shows how to get the current setting.
bool currentSetting{ clientSocket.Control().NoDelay() };

// Set NoDelay to false so that the Nagle algorithm is not disabled.
clientSocket.Control().NoDelay(false);

// Now you can call the ConnectAsync function to connect the StreamSocket.
```

```cpp
using namespace Windows::Networking::Sockets;

StreamSocket^ clientSocket = ref new StreamSocket();

// Get the current setting for this option.
// This isn't required, but it shows how to get the current setting.
bool currentSetting = clientSocket->Control->NoDelay;

// Set NoDelay to false so that the Nagle algorithm is not disabled.
clientSocket->Control->NoDelay = false;

// Now you can call the ConnectAsync method to connect the StreamSocket.
```

```javascript
var clientSocket = new Windows.Networking.Sockets.StreamSocket();

// Get the current setting for this option
// This isn't required, but it shows how to get the current setting
var currentSetting = clientSocket.Control.noDelay; 

// Set noDelay to false so that the Nagle algorithm is not disabled
clientSocket.control.noDelay = false;
   
// Now you can call the ConnectAsync method to connect the StreamWebSocket.
```

For more information on using [StreamSocketControl](streamsocketcontrol.md), see [How to use advanced socket controls ](https://msdn.microsoft.com/library/2e1071d8-a1c7-44c0-b93a-31a701d431c4) and [How to use advanced socket controls ](https://msdn.microsoft.com/library/f2c5be73-3461-452e-a38f-d2ddef9b5682).

## -examples

## -see-also
[Connecting with sockets ](https://msdn.microsoft.com/library/67cfa78f-570f-4dd4-a0f2-cd6c891f5446), [Connecting with sockets ](https://msdn.microsoft.com/library/2a6448d0-e21f-4963-bca5-aae001ae4fc7), [How to use advanced socket controls ](https://msdn.microsoft.com/library/2e1071d8-a1c7-44c0-b93a-31a701d431c4), [How to use advanced socket controls ](https://msdn.microsoft.com/library/f2c5be73-3461-452e-a38f-d2ddef9b5682), [StreamSocket](streamsocket.md), [StreamSocket.Control](streamsocket_control.md), [StreamSocketInformation](datagramsocketinformation.md), [ControlChannelTrigger StreamSocket sample](https://go.microsoft.com/fwlink/p/?linkid=243039), [StreamSocket sample](https://go.microsoft.com/fwlink/p/?linkid=243037)

## -capabilities
ID_CAP_NETWORKING [Windows Phone], bluetooth.rfcomm
