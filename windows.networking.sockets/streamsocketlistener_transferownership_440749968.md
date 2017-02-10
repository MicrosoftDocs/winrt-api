---
-api-id: M:Windows.Networking.Sockets.StreamSocketListener.TransferOwnership(System.String,Windows.Networking.Sockets.SocketActivityContext)
-api-type: winrt method
---

<!-- Method syntax
public void TransferOwnership(System.String socketId, Windows.Networking.Sockets.SocketActivityContext data)
-->

# Windows.Networking.Sockets.StreamSocketListener.TransferOwnership

## -description
Transfers ownership of the [StreamSocketListener](streamsocketlistener.md) to the socket brokering service, which monitors socket activity and notifies the app through a background task if there is any activity.

## -parameters
### -param socketId
A string the app uses to identify the transferred socket. The string should identify this socket uniquely within the app. When activity occurs on this socket, this string will be provided to the app to identify the socket.

### -param data
Use the [SocketActivityContext](socketactivitycontext.md) to pass context information through the socket broker. When your app is notified by the broker of activity, this [SocketActivityContext](socketactivitycontext.md) will be provided to your app to help establish the context in which you should handle the notification.

## -remarks

## -examples

## -see-also
[TransferOwnership(String)](streamsocketlistener_transferownership_1291619316.md)