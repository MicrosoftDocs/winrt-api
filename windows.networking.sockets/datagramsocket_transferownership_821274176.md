---
-api-id: M:Windows.Networking.Sockets.DatagramSocket.TransferOwnership(System.String,Windows.Networking.Sockets.SocketActivityContext,Windows.Foundation.TimeSpan)
-api-type: winrt method
---

<!-- Method syntax
public void TransferOwnership(System.String socketId, Windows.Networking.Sockets.SocketActivityContext data, Windows.Foundation.TimeSpan keepAliveTime)
-->

# Windows.Networking.Sockets.DatagramSocket.TransferOwnership

## -description
Transfers ownership of the [DatagramSocket](datagramsocket.md) to the socket brokering service, which monitors socket activity and notifies the app through a background task if there is any activity.

## -parameters
### -param socketId
A string the app uses to identify the transferred socket. The string should identify this socket uniquely within the app. When activity occurs on this socket, this string will be provided to the app to identify the socket.

### -param data
Use the [SocketActivityContext](socketactivitycontext.md) to pass context information through the socket broker. When your app is notified by the broker of activity, this [SocketActivityContext](socketactivitycontext.md) will be provided to your app to help establish the context in which you should handle the notification.

### -param keepAliveTime
How long the socket brokering service should monitor the socket for activity.

## -remarks
Your app should call this method to transfer ownership of the [DatagramSocket](datagramsocket.md) to the socket brokering service when the app is about to be suspended, or at the end of a background task. Your app should not access the [DatagramSocket](datagramsocket.md) object after calling this method, except when responding to notifications from the socket brokering service.

## -examples

## -see-also
[TransferOwnership(String)](datagramsocket_transferownership_1291619316.md), [TransferOwnership(String, SocketActivityContext)](datagramsocket_transferownership_440749968.md)