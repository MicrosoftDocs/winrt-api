---
-api-id: M:Windows.Networking.Proximity.PeerFinder.ConnectAsync(Windows.Networking.Proximity.PeerInformation)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Networking.Sockets.StreamSocket> ConnectAsync(Windows.Networking.Proximity.PeerInformation peerInformation)
-->

# Windows.Networking.Proximity.PeerFinder.ConnectAsync

## -description
Connects to a peer discovered by a call to the [FindAllPeersAsync](peerfinder_findallpeersasync_830195586.md) method.

## -parameters
### -param peerInformation
A peer information object representing the peer to connect to.

## -returns
An asynchronous operation for connecting to a remote peer using the supplied [StreamSocket](../windows.networking.sockets/streamsocket_streamsocket_1221375020.md) object.

## -remarks
You can obtain an instance of a [PeerInformation](peerinformation.md) object for a peer from a call to the [FindAllPeersAsync](peerfinder_findallpeersasync_830195586.md) method, or in a handler for the [ConnectionRequested](peerfinder_connectionrequested.md) event.

If an app calls the ConnectAsync method to create a connection with a peer, the app will no longer advertise for a connection and will not be found by the [FindAllPeersAsync](peerfinder_findallpeersasync_830195586.md) method until the app calls the [Close](../windows.networking.sockets/streamsocket_close_811482585.md) method to close the socket connection.

If you open a socket connection by calling the ConnectAsync method, only one socket connection can be open at a time for the computer. If your app, or another app calls the ConnectAsync method, then the existing socket connection will close.

An *Access Denied* exception will be thrown if you attempt to call **ConnectAsync** when your app is in the background.



> [!IMPORTANT]
> The Proximity APIs do not provide authentication. You should avoid exchanging sensitive data with these APIs.

### Windows Phone 8

Wi-Fi Direct is not supported on Windows Phone 8. 

## -examples

[!code-csharp[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/csharp/BlankPage.xaml.cs#SnippetConnect_CS)]

[!code-vb[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/vbnet/BlankPage.xaml.vb#SnippetConnect_CS)]

## -see-also
[FindAllPeersAsync](peerfinder_findallpeersasync_830195586.md), [PeerInformation](peerinformation.md), [ConnectionRequested](peerfinder_connectionrequested.md), [Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_NETWORKING [Windows Phone], ID_CAP_NETWORKING [Windows Phone]
