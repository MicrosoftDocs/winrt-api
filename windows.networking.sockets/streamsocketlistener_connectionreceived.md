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
To listen for a connection on the [StreamSocketListener](streamsocketlistener.md) object, an app must assign the [ConnectionReceived](datagramsocket_messagereceived.md) event to an event handler and then call either the [BindEndpointAsync](streamsocketlistener_bindendpointasync.md) or [BindServiceNameAsync](streamsocketlistener_bindservicenameasync.md) method to bind the [StreamSocketListener](streamsocketlistener.md) to a local service name or TCP port on which to listen. To listen for Bluetooth RFCOMM, the bind is to the Bluetooth Service ID.

## -examples

## -see-also
[StreamSocket](streamsocket.md), [StreamSocketListenerConnectionReceivedEventArgs](streamsocketlistenerconnectionreceivedeventargs.md), [StreamSocket sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620609)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]