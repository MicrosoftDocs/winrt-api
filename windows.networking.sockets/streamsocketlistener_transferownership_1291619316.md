---
-api-id: M:Windows.Networking.Sockets.StreamSocketListener.TransferOwnership(System.String)
-api-type: winrt method
---

<!-- Method syntax
public void TransferOwnership(System.String socketId)
-->

# Windows.Networking.Sockets.StreamSocketListener.TransferOwnership

## -description
Transfers ownership of the [StreamSocketListener](streamsocketlistener.md) to the socket brokering service, which monitors socket activity and notifies the app through a background task if there is any activity.

## -parameters
### -param socketId
A string the app uses to identify the transferred socket. The string should identify this socket uniquely within the app. When activity occurs on this socket, this string will be provided to the app to identify the socket.

## -remarks

## -examples

## -see-also
[TransferOwnership(String, SocketActivityContext)](streamsocketlistener_transferownership_440749968.md)