---
-api-id: E:Windows.Networking.Sockets.StreamSocketListener.ConnectionReceived
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ConnectionReceived<Windows.Networking.Sockets.StreamSocketListener,  Windows.Networking.Sockets.StreamSocketListenerConnectionReceivedEventArgs>
-->

# Windows.Networking.Sockets.StreamSocketListener.ConnectionReceived

## -description
An event that indicates that a connection was received on the [StreamSocketListener](streamsocketlistener.md) object.

## -remarks
To listen for a connection on the [StreamSocketListener](streamsocketlistener.md) object, an app must assign the [ConnectionReceived](datagramsocket_messagereceived.md) event to an event handler and then call either the [BindEndpointAsync](streamsocketlistener_bindendpointasync_1396029045.md) or [BindServiceNameAsync](streamsocketlistener_bindservicenameasync_1713574846.md) method to bind the [StreamSocketListener](streamsocketlistener.md) to a local service name or TCP port on which to listen. To listen for Bluetooth RFCOMM, the bind is to the Bluetooth Service ID.

**Note** From the perspective of a **StreamSocket**, a Parallel Patterns Library (PPL) completion handler is done executing (and the socket is eligible for disposal) before the continuation body runs. So, to keep your socket from being disposed if you want to use it inside a continuation, you'll need to use one of the techniques described in [References to StreamSockets in C++ PPL continuations](/windows/uwp/networking/sockets#references-to-streamsockets-in-c-ppl-continuations).

## -examples

## -see-also
[StreamSocket](streamsocket.md), [StreamSocketListenerConnectionReceivedEventArgs](streamsocketlistenerconnectionreceivedeventargs.md), [StreamSocket sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/StreamSocket)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
