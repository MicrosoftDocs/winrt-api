---
-api-id: E:Windows.Networking.Sockets.DatagramSocket.MessageReceived
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler MessageReceived<Windows.Networking.Sockets.DatagramSocket,  Windows.Networking.Sockets.DatagramSocketMessageReceivedEventArgs>
-->

# Windows.Networking.Sockets.DatagramSocket.MessageReceived

## -description
An event that indicates that a message was received on the [DatagramSocket](datagramsocket.md) object.

## -remarks
To receive data on the [DatagramSocket](datagramsocket.md) object, an app must assign the [MessageReceived  event to an event handler and then call either the [BindEndpointAsync](datagramsocket_bindendpointasync_1396029045.md) or [BindServiceNameAsync](datagramsocket_bindservicenameasync_440542334.md) method to bind the [DatagramSocket](datagramsocket.md) to a local service name or UDP port. The [ConnectAsync](datagramsocket_connectasync_13692504.md) methods will also result in a bind operation. Writing to a stream returned by one of the [GetOutputStreamAsync](datagramsocket_getoutputstreamasync_1619245957.md) methods will also result in a bind operation. The MessageReceived event handler will be invoked whenever a message from a remote endpoint arrives.

To receive multicast packets on the [DatagramSocket](datagramsocket.md) object, an app must assign the [MessageReceived  event to an event handler and then call the [JoinMulticastGroup](datagramsocket_joinmulticastgroup_1508568147.md) method to join the multicast group.

To unregister the [MessageReceived  event, the [DatagramSocket](datagramsocket.md) object must be closed. The [Close](datagramsocket_close_811482585.md) method is used by Windows app using JavaScript. For apps written using the .NET Framework 4.5 in C# and VB.NET, the [Close](datagramsocket_close_811482585.md) method is exposed as the  method on the [DatagramSocket](datagramsocket.md). For apps written in C++, the [Close](datagramsocket_close_811482585.md) method will be called when using the delete keyword on the object.

## -examples

## -see-also
[DatagramSocket sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/DatagramSocket)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
