---
-api-id: M:Windows.Networking.Sockets.DatagramSocket.TransferOwnership(System.String)
-api-type: winrt method
---

<!-- Method syntax
public void TransferOwnership(System.String socketId)
-->

# Windows.Networking.Sockets.DatagramSocket.TransferOwnership

## -description
Transfers ownership of the [DatagramSocket](datagramsocket.md) to the socket brokering service, which monitors socket activity and notifies the app through a background task if there is any activity.

## -parameters
### -param socketId
A string the app uses to identify the transferred socket. The string should identify this socket uniquely within the app. When activity occurs on this socket, this string will be provided to the app to identify the socket.

## -remarks
Your app should call this method to transfer ownership of the [DatagramSocket](datagramsocket.md) to the socket brokering service when the app is about to be suspended, or at the end of a background task. Your app should not access the [DatagramSocket](datagramsocket.md) object after calling this method, except when responding to notifications from the socket brokering service.

## -examples

## -see-also
[TransferOwnership(String, SocketActivityContext)](datagramsocket_transferownership_440749968.md), [TransferOwnership(String, SocketActivityContext, TimeSpan)](datagramsocket_transferownership_821274176.md)