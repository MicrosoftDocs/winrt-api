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

[!code-csharp[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/csharp/BlankPage.xaml.cs#SnippetConnect_CS)]

[!code-vb[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/vbnet/BlankPage.xaml.vb#SnippetConnect_CS)]

## -see-also
[FindAllPeersAsync](peerfinder_findallpeersasync_830195586.md), [ConnectAsync](peerfinder_connectasync_380619906.md), [Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_NETWORKING [Windows Phone], ID_CAP_NETWORKING [Windows Phone]
