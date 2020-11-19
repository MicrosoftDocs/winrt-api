---
-api-id: E:Windows.Networking.Proximity.PeerFinder.TriggeredConnectionStateChanged
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
static public event Windows.Foundation.TypedEventHandler TriggeredConnectionStateChanged<object,  Windows.Networking.Proximity.TriggeredConnectionStateChangedEventArgs>
-->

# Windows.Networking.Proximity.PeerFinder.TriggeredConnectionStateChanged

## -description
Occurs during a tap gesture from a remote peer.

## -remarks
You can determine when a peer is available to connect to, and the progress of a connection to a peer, by using the **TriggeredConnectionStateChanged** event. Use the **TriggeredConnectionStateChanged** event to determine when a new peer has been found and to access the connection to that peer after you've finished connecting.

The **TriggeredConnectionStateChanged** event occurs several times during a tap gesture. You can determine where you are in the connection process by using the [State](triggeredconnectionstatechangedeventargs_state.md) property.

The first [State](triggeredconnectionstatechangedeventargs_state.md) value in a Proximity connection is **PeerFound**. At this point, you can tell users of your app that the Proximity gesture is complete and they can pull their devices away.

If the [State](triggeredconnectionstatechangedeventargs_state.md) property returns **Connecting**, you know that your device initiated the tap gesture. If the [State](triggeredconnectionstatechangedeventargs_state.md) property returns **Listening**, you know that the other device initiated the tap gesture. This information is useful in determining which peer should initiate communications when the connection is complete.

When the [State](triggeredconnectionstatechangedeventargs_state.md) property returns **Completed**, you can access the [Socket](triggeredconnectionstatechangedeventargs_socket.md) property to obtain a reference to a [StreamSocket](../windows.networking.sockets/streamsocket_streamsocket_1221375020.md) object. You can use this reference to communicate with the peer app. The transport over which this communication takes place on this socket connection will either be Bluetooth, Infrastructure or Wi-Fi Direct.

> Wi-Fi Direct is not supported for Windows Phone 8.x apps.

## -examples

[!code-csharp[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/csharp/BlankPage.xaml.cs#SnippetConnect_CS)]

[!code-vb[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/vbnet/BlankPage.xaml.vb#SnippetConnect_CS)]

## -see-also

[Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_NETWORKING [Windows Phone], ID_CAP_NETWORKING [Windows Phone]
