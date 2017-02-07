---
-api-id: T:Windows.Networking.Sockets.SocketActivityConnectedStandbyAction
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Networking.Sockets.SocketActivityConnectedStandbyAction : int
-->

# SocketActivityConnectedStandbyAction

## -description
Indicates whether an app that uses the socket brokering service can receive packets when the system goes to connected stand by.

## -enum-fields
### -field DoNotWake:0
The app should not receive packets when the system goes to stand by.

### -field Wake:1
The app can receive packets even when the system goes to stand by.


## -remarks

## -examples

## -see-also
[DatagramSocket.TransferOwnership(String, SocketActivityContext)](datagramsocket_transferownership_440749968.md), [DatagramSocket.TransferOwnership(String, SocketActivityContext, TimeSpan)](datagramsocket_transferownership_821274176.md), [StreamSocket.TransferOwnership(String, SocketActivityContext)](streamsocket_transferownership_440749968.md), [StreamSocket.TransferOwnership(String, SocketActivityContext, TimeSpan)](streamsocket_transferownership_821274176.md), [StreamSocketListener.TransferOwnership(String, SocketActivityContext)](streamsocketlistener_transferownership_440749968.md)