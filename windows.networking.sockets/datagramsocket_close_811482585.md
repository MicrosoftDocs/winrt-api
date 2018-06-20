---
-api-id: M:Windows.Networking.Sockets.DatagramSocket.Close
-api-type: winrt method
---

<!-- Method syntax
public void Close()
-->

# Windows.Networking.Sockets.DatagramSocket.Close

## -description
Closes the [DatagramSocket](datagramsocket.md) object and aborts any pending operation on the **DatagramSocket**.

## -remarks
The **Close** method aborts any pending operations and releases all unmanaged resources associated with the [DatagramSocket](datagramsocket.md) object.

Calling the **Close** method on the **DatagramSocket** also unregisters the [MessageReceived](datagramsocket_messagereceived.md) event.

The **Close** method is used by Windows apps using JavaScript. For apps written using the .NET Framework 4.5 in C# and VB.NET, the **Close** method is exposed as the [Dispose](/uwp/api/windows.networking.sockets.datagramsocket.dispose) method on the [DatagramSocket](datagramsocket.md). For apps written in C++, the **Close** method is called when the object's destructor runs.

## -examples

## -see-also
[Dispose](/uwp/api/windows.networking.sockets.datagramsocket.dispose)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
