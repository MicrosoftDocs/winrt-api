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
The StreamSocketControl class provides access to advanced socket control data on a [StreamSocket](streamsocket.md) object.

A StreamSocketControl object is automatically created with the parent [StreamSocket](streamsocket.md) object. The [StreamSocket.Control](streamsocket_control.md) property provides access to the associated StreamSocketControl object.

Any changes to the property values on the StreamSocketControl must be set before the [StreamSocket](streamsocket.md) is connected. As a result if you need to make changes to the [ClientCertificate](streamsocketcontrol_clientcertificate.md), [IgnorableServerCertificateErrors](streamsocketcontrol_ignorableservercertificateerrors.md), [KeepAlive](streamsocketcontrol_keepalive.md), [NoDelay](streamsocketcontrol_nodelay.md), [OutboundBufferSizeInBytes](streamsocketcontrol_outboundbuffersizeinbytes.md) , [OutboundUnicastHopLimit](streamsocketcontrol_outboundunicasthoplimit.md), or [QualityOfService](streamsocketcontrol_qualityofservice.md) properties, then these changes must occur before a successful call to one of the [ConnectAsync](streamsocket_connectasync_13692504.md) methods on the [StreamSocket](streamsocket.md).

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

```cppcx
using namespace Windows::Networking::Sockets;

StreamSocket^ clientSocket = ref new StreamSocket();

// Get the current setting for this option.
// This isn't required, but it shows how to get the current setting.
bool currentSetting = clientSocket->Control->NoDelay;

// Set NoDelay to false so that the Nagle algorithm is not disabled.
clientSocket->Control->NoDelay = false;

// Now you can call the ConnectAsync method to connect the StreamSocket.
```

For more information on using StreamSocketControl, see [How to use advanced socket controls](/previous-versions/windows/apps/jj150598(v=win.10)).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | MinProtectionLevel |

## -examples

## -see-also
[Connecting with sockets](/previous-versions/windows/apps/hh452976(v=win.10)), [How to use advanced socket controls](/previous-versions/windows/apps/jj150598(v=win.10)), [StreamSocket](streamsocket.md), [StreamSocket.Control](streamsocket_control.md), [StreamSocketInformation](datagramsocketinformation.md), [ControlChannelTrigger StreamSocket sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/%5BC%23%5D-Windows%208.1%20Store%20app%20samples/ControlChannelTrigger%20StreamSocket%20sample/C%23), [StreamSocket sample](https://github.com/microsoft/Windows-universal-samples/tree/main/Samples/StreamSocket)

## -capabilities
ID_CAP_NETWORKING [Windows Phone], bluetooth.rfcomm