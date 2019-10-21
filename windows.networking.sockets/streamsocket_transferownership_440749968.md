---
-api-id: M:Windows.Networking.Sockets.StreamSocket.TransferOwnership(System.String,Windows.Networking.Sockets.SocketActivityContext)
-api-type: winrt method
---

<!-- Method syntax
public void TransferOwnership(System.String socketId, Windows.Networking.Sockets.SocketActivityContext data)
-->

# Windows.Networking.Sockets.StreamSocket.TransferOwnership

## -description
Transfers ownership of the [StreamSocket](streamsocket.md) to the socket brokering service, which monitors socket activity and notifies the app through a background task if there is any activity. Specifies a new [SocketActivityContext](socketactivitycontext.md) for the socket.

## -parameters
### -param socketId
A string the app uses to identify the transferred socket. The string should identify this socket uniquely within the app. When activity occurs on this socket, this string will be provided to the app to identify the socket.

### -param data
Use the [SocketActivityContext](socketactivitycontext.md) to pass context information through the socket broker. When your app is notified by the broker of activity, this [SocketActivityContext](socketactivitycontext.md) will be provided to your app to help establish the context in which you should handle the notification.

## -remarks
Your app should call this method to transfer ownership of the [StreamSocket](streamsocket.md) to the socket brokering service when the app is about to be suspended, or at the end of a background task. Your app should not access the [StreamSocket](streamsocket.md) object after calling this method, except when responding to notifications from the socket brokering service.

> [!NOTE]
> This call fails if there is any pending I/O on the [StreamSocket](streamsocket.md). Your code should call [StreamSocket.CancelIOAsync](streamsocket_cancelioasync_169683529.md) to cancel any further new traffic, then handle all pending traffic, and then update the [SocketActivityContext](socketactivitycontext.md), before calling StreamSocket.TransferOwnership.

## -examples

## -see-also
[TransferOwnership(String)](streamsocket_transferownership_1291619316.md), [TransferOwnership(String, SocketActivityContext, TimeSpan)](streamsocket_transferownership_821274176.md)
