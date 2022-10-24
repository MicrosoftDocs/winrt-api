---
-api-id: T:Windows.Networking.Sockets.StreamSocketListenerConnectionReceivedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class StreamSocketListenerConnectionReceivedEventArgs : Windows.Networking.Sockets.IStreamSocketListenerConnectionReceivedEventArgs
-->

# Windows.Networking.Sockets.StreamSocketListenerConnectionReceivedEventArgs

## -description
Provides data for a [ConnectionReceived](streamsocketlistener_connectionreceived.md) event on a [StreamSocketListener](streamsocketlistener.md) object.

## -remarks
The StreamSocketListenerConnectionReceivedEventArgs is used to receive connection data on a [StreamSocketListener](streamsocketlistener.md) object.

The [StreamSocketListener.BindServiceNameAsync](streamsocketlistener_bindservicenameasync_1713574846.md) or [StreamSocketListener.BindEndpointAsync](streamsocketlistener_bindendpointasync_1396029045.md) method is used to bind a [StreamSocketListener](streamsocketlistener.md) to a local service name or TCP port.

A [StreamSocketListener.ConnectionReceived](streamsocketlistener_connectionreceived.md) event occurs if a [StreamSocketListener](streamsocketlistener.md) object has been bound to a local service name or TCP port and a connection is received. A StreamSocketListenerConnectionReceivedEventArgs instance is a parameter specified in the callback.

**Note** From the perspective of a **StreamSocket**, a Parallel Patterns Library (PPL) completion handler is done executing (and the socket is eligible for disposal) before the continuation body runs. So, to keep your socket from being disposed if you want to use it inside a continuation, you'll need to use one of the techniques described in [References to StreamSockets in C++ PPL continuations](/windows/uwp/networking/sockets#references-to-streamsockets-in-c-ppl-continuations).

## -examples

## -see-also
[StreamSocket](streamsocket.md), [StreamSocketListener](streamsocketlistener.md), [ConnectionReceived](streamsocketlistener_connectionreceived.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
