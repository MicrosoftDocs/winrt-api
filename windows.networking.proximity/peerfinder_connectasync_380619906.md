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
Connects to a peer discovered by a call to the [FindAllPeersAsync](peerfinder_findallpeersasync.md) method.

## -parameters
### -param peerInformation
A peer information object representing the peer to connect to.

## -returns
An asynchronous operation for connecting to a remote peer using the supplied [StreamSocket](../windows.networking.sockets/streamsocket_streamsocket.md) object.

## -remarks
You can obtain an instance of a [PeerInformation](peerinformation.md) object for a peer from a call to the [FindAllPeersAsync](peerfinder_findallpeersasync.md) method, or in a handler for the [ConnectionRequested](peerfinder_connectionrequested.md) event.

If an app calls the [ConnectAsync](peerfinder_connectasync.md) method to create a connection with a peer, the app will no longer advertise for a connection and will not be found by the [FindAllPeersAsync](peerfinder_findallpeersasync.md) method until the app calls the [Close](../windows.networking.sockets/streamsocket_close.md) method to close the socket connection.

If you open a socket connection by calling the [ConnectAsync](peerfinder_connectasync.md) method, only one socket connection can be open at a time for the computer. If your app, or another app calls the [ConnectAsync](peerfinder_connectasync.md) method, then the existing socket connection will close.

An *Access Denied* exception will be thrown if you attempt to call **ConnectAsync** when your app is in the background.



> [!IMPORTANT]
> The Proximity APIs do not provide authentication. You should avoid exchanging sensitive data with these APIs.

### Windows Phone 8

Wi-Fi Direct is not supported on Windows Phone 8. For more information, see [Proximity](XREF:TODO:d3654cbf-7e79-4833-9bd3-f4c926eb7282).

## -examples


[!code-js[FindPeers](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/js/default.js#SnippetFindPeers)]

[!code-csharp[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/csharp/BlankPage.xaml.cs#SnippetConnect_CS)]

[!code-vb[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/vbnet/BlankPage.xaml.vb#SnippetConnect_CS)]

## -see-also
[FindAllPeersAsync](peerfinder_findallpeersasync.md), [PeerInformation](peerinformation.md), [ConnectionRequested](peerfinder_connectionrequested.md), [Proximity and Tapping (JavaScript)](http://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), [Proximity and Tapping (C#/VB/C++)](http://msdn.microsoft.com/library/f25bb1df-1cfd-45cd-8c67-04eec73ebfbd), [Proximity sample](http://go.microsoft.com/fwlink/p/?linkid=245082)

## -capabilities
proximity, ID_CAP_PROXIMITY [Windows Phone], ID_CAP_NETWORKING [Windows Phone]
ID_CAP_NETWORKING [Windows Phone]
