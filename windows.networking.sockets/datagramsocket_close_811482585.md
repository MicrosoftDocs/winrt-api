---
-api-id: M:Windows.Networking.Sockets.DatagramSocket.Close
-api-type: winrt method
---

<!-- Method syntax
public void Close()
-->

# Windows.Networking.Sockets.DatagramSocket.Close

## -description
Closes the [DatagramSocket](datagramsocket.md) object and aborts any pending operation on the [DatagramSocket](datagramsocket.md).

## -remarks
The [Close](datagramsocket_close.md) method aborts any pending operations and releases all unmanaged resources associated with the [DatagramSocket](datagramsocket.md) object.

Calling the [Close](datagramsocket_close.md) method on the [DatagramSocket](datagramsocket.md) will also unregister the [MessageReceived](datagramsocket_messagereceived.md) event.

The [Close](datagramsocket_close.md) method is used by Windows app using JavaScript. For apps written using the .NET Framework 4.5 in C# and VB.NET, the [Close](datagramsocket_close.md) method is exposed as the [Dispose](datagramsocket_dispose.md) method on the [DatagramSocket](datagramsocket.md). For apps written in C++, the [Close](datagramsocket_close.md) method will be called when using the delete keyword on the object.

## -examples

## -see-also
[Dispose](datagramsocket_dispose.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]