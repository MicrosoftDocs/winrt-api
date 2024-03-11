---
-api-id: T:Windows.Networking.Sockets.StreamSocketListenerControl
-api-type: winrt class
---

<!-- Class syntax.
public class StreamSocketListenerControl : Windows.Networking.Sockets.IStreamSocketListenerControl, Windows.Networking.Sockets.IStreamSocketListenerControl2
-->

# Windows.Networking.Sockets.StreamSocketListenerControl

## -description
Provides socket control data on a [StreamSocketListener](streamsocketlistener.md) object.

## -remarks
The StreamSocketListenerControl class provides access to advanced socket control data on a [StreamSocketListener](streamsocketlistener.md) object.

A StreamSocketListenerControl object is automatically created with the parent [StreamSocketListener](streamsocketlistener.md) object. The [StreamSocketListener.Control](streamsocketlistener_control.md) property provides access to the associated StreamSocketListenerControl object.

Any changes to the StreamSocketListenerControl property values must be set before the [StreamSocketListener](streamsocketlistener.md) is bound. So changes to the [QualityOfService](streamsocketlistenercontrol_qualityofservice.md) property must be set before the [BindServiceNameAsync](streamsocketlistener_bindservicenameasync_1713574846.md) or [BindEndpointAsync](streamsocketlistener_bindendpointasync_1396029045.md) method is called on the [StreamSocketListener](streamsocketlistener.md).

The following example creates a [StreamSocketListener](streamsocketlistener.md), and then demonstrates how to set the [QualityOfService](datagramsocketcontrol_qualityofservice.md) property to **LowLatency**. After this is done, the app can bind and listen on the [StreamSocketListener](streamsocketlistener.md).

```csharp
using Windows.Networking.Sockets;

StreamSocketListener listenerSocket = new StreamSocketListener();

// Get the current setting for this option.
// This isn't required, but it shows how to get the current setting.
var currentSetting = listenerSocket.Control.QualityOfService;

// Set QualityOfService to LowLatency.
listenerSocket.Control.QualityOfService = SocketQualityOfService.LowLatency;

// Now you can call the BindServiceNameAsync or BindEndpointAsync method to listen for connections.
```

```cppwinrt
#include <winrt/Windows.Networking.Sockets.h>
using namespace winrt;
...
Windows::Networking::Sockets::StreamSocketListener listenerSocket;

// Get the current setting for this option.
// This isn't required, but it shows how to get the current setting.
auto currentSetting{ listenerSocket.Control().QualityOfService() };

// Set QualityOfService to LowLatency.
listenerSocket.Control().QualityOfService(Windows::Networking::Sockets::SocketQualityOfService::LowLatency);

// Now you can call the BindServiceNameAsync or BindEndpointAsync method to listen for connections.
```

```cppcx
using namespace Windows::Networking::Sockets;

StreamSocketListener^ listenerSocket = ref new StreamSocketListener();

// Get the current setting for this option.
// This isn't required, but it shows how to get the current setting.
auto currentSetting = listenerSocket->Control->QualityOfService;

// Set QualityOfService to LowLatency.
listenerSocket->Control->QualityOfService = SocketQualityOfService::LowLatency;

// Now you can call the BindServiceNameAsync or BindEndpointAsync method to listen for connections.
```

For more information on using StreamSocketListenerControl, see [How to use advanced socket controls](/previous-versions/windows/apps/jj150598(v=win.10)).

## -examples

## -see-also
[Connecting with sockets](/previous-versions/windows/apps/hh452976(v=win.10)), [How to use advanced socket controls](/previous-versions/windows/apps/jj150598(v=win.10)), [StreamSocketListener](streamsocketlistener.md), [StreamSocketListener.Control](streamsocketlistener_control.md), [StreamSocketListenerInformation](streamsocketlistenerinformation.md), [Bluetooth Rfcomm Chat sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Bluetooth%20Rfcomm%20Chat), [ControlChannelTrigger StreamSocket sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/ControlChannelTrigger%20StreamSocket%20sample), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Proximity%20sample), [StreamSocket sample](https://github.com/microsoft/Windows-universal-samples/tree/main/Samples/StreamSocket)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]