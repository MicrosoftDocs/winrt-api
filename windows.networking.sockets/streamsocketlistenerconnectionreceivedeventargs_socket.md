---
-api-id: P:Windows.Networking.Sockets.StreamSocketListenerConnectionReceivedEventArgs.Socket
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.Sockets.StreamSocket Socket { get; }
-->

# Windows.Networking.Sockets.StreamSocketListenerConnectionReceivedEventArgs.Socket

## -description
The [StreamSocket](streamsocket.md) object created when a connection is received by the [StreamSocketListener](streamsocketlistener.md) object.

## -property-value
The [StreamSocket](streamsocket.md) object created when a connection is received by the [StreamSocketListener](streamsocketlistener.md) object.

## -remarks

**Note** From the perspective of a **StreamSocket**, a Parallel Patterns Library (PPL) completion handler is done executing (and the socket is eligible for disposal) before the continuation body runs. So, to keep your socket from being disposed if you want to use it inside a continuation, you'll need to use one of the techniques described in [References to StreamSockets in C++ PPL continuations](/windows/uwp/networking/sockets#references-to-streamsockets-in-c-ppl-continuations).

## -examples

## -see-also
[StreamSocket](streamsocket.md), [StreamSocketListener](streamsocketlistener.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
