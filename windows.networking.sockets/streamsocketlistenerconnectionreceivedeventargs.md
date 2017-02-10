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
The [StreamSocketListenerConnectionReceivedEventArgs](streamsocketlistenerconnectionreceivedeventargs.md) is used to receive connection data on a [StreamSocketListener](streamsocketlistener.md) object.

The [StreamSocketListener.BindServiceNameAsync](streamsocketlistener_bindservicenameasync.md) or [StreamSocketListener.BindEndpointAsync](streamsocketlistener_bindendpointasync.md) method is used to bind a [StreamSocketListener](streamsocketlistener.md) to a local service name or TCP port.

A [StreamSocketListener.ConnectionReceived](streamsocketlistener_connectionreceived.md) event occurs if a [StreamSocketListener](streamsocketlistener.md) object has been bound to a local service name or TCP port and a connection is received. A [StreamSocketListenerConnectionReceivedEventArgs](streamsocketlistenerconnectionreceivedeventargs.md) instance is a parameter specified in the callback.

## -examples

## -see-also
[StreamSocket](streamsocket.md), [StreamSocketListener](streamsocketlistener.md), [ConnectionReceived](streamsocketlistener_connectionreceived.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]