---
-api-id: M:Windows.Networking.Proximity.PeerFinder.FindAllPeersAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Networking.Proximity.PeerInformation>> FindAllPeersAsync()
-->

# Windows.Networking.Proximity.PeerFinder.FindAllPeersAsync

## -description
Asynchronously browses for peer devices that are running the same app within wireless range.

## -returns
The asynchronous operation for browsing for peer devices that are running your app.

## -remarks
If your app is running on a PC, you can browse for peer PCs that are running your app. Peer discovery in this case takes place over Wi-Fi Direct. If your app is running on a phone, you can browse for peer phones that are running your app. In this case, peer discovery takes place over Bluetooth. Because the transport used for peer discovery differs between PC and phone, your app running on a PC can only find peer PCs and your app running on a phone can only find peer phones.

When the asynchronous browsing operation finishes successfully, it returns a list of peers that are within wireless range. A peer is a device that has an app running in the foreground with a matching app Id. A peer can also have a matching browse Id that's specified as an alternate identity. For more information, see [AlternateIdentities](peerfinder_alternateidentities.md).

If an app calls the [ConnectAsync](peerfinder_connectasync_380619906.md) method to create a connection with a peer, the app will no longer advertise for a connection and will not be found by the FindAllPeersAsync method until the app calls the [Close](../windows.networking.sockets/streamsocket_close_811482585.md) method to close the socket connection.

You will only find peers where the device is within wireless range and the peer app is running in the foreground. If a peer app is running in the background, proximity does not advertise for peer connections.

As an alternative to the FindAllPeersAsync method, you can dynamically search for peer apps as they are discovered within range using the [PeerWatcher](peerwatcher.md) object.

### Windows Phone 8

Wi-Fi Direct is not supported on Windows Phone 8.

## -examples

[!code-csharp[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/csharp/BlankPage.xaml.cs#SnippetConnect_CS)]

[!code-vb[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/vbnet/BlankPage.xaml.vb#SnippetConnect_CS)]

## -see-also
[AlternateIdentities](peerfinder_alternateidentities.md), [SupportedDiscoveryTypes](peerfinder_supporteddiscoverytypes.md), [PeerWatcher](peerwatcher.md), [Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_NETWORKING [Windows Phone], ID_CAP_NETWORKING [Windows Phone]
