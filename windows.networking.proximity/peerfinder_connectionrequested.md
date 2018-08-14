---
-api-id: E:Windows.Networking.Proximity.PeerFinder.ConnectionRequested
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
static public event Windows.Foundation.TypedEventHandler ConnectionRequested<object,  Windows.Networking.Proximity.ConnectionRequestedEventArgs>
-->

# Windows.Networking.Proximity.PeerFinder.ConnectionRequested

## -description
Occurs when a remote peer requests a connection using the [ConnectAsync](peerfinder_connectasync_380619906.md) method.

## -remarks
The **ConnectionRequested** event occurs when a remote peer calls the [FindAllPeersAsync](peerfinder_findallpeersasync_830195586.md) method, finds the current peer, and passes that peer information to the [ConnectAsync](peerfinder_connectasync_380619906.md) method to request a connection.



> [!IMPORTANT]
> The Proximity APIs do not provide authentication. You should avoid exchanging sensitive data with these APIs.

## -examples


[!code-js[FindPeers](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/js/default.js#SnippetFindPeers)]

[!code-csharp[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/csharp/BlankPage.xaml.cs#SnippetConnect_CS)]

[!code-vb[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/vbnet/BlankPage.xaml.vb#SnippetConnect_CS)]

## -see-also
[FindAllPeersAsync](peerfinder_findallpeersasync_830195586.md), [ConnectAsync](peerfinder_connectasync_380619906.md), [Proximity and Tapping (JavaScript)](http://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), [Proximity and Tapping (C#/VB/C++)](http://msdn.microsoft.com/library/f25bb1df-1cfd-45cd-8c67-04eec73ebfbd), [Proximity sample](http://go.microsoft.com/fwlink/p/?linkid=245082)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_NETWORKING [Windows Phone], ID_CAP_NETWORKING [Windows Phone]
