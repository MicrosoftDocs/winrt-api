---
-api-id: T:Windows.Networking.Proximity.PeerFinder
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class PeerFinder 
-->

# Windows.Networking.Proximity.PeerFinder

## -description
Enables you to discover other instances of your app on nearby devices and create a socket connection between the peer apps by using a tap gesture or by browsing. For creating Bluetooth socket connections on Windows 8.1 and later, use [Windows.Devices.Bluetooth.Rfcomm](../windows.devices.bluetooth.rfcomm/windows_devices_bluetooth_rfcomm.md) instead.

## -remarks
> [!IMPORTANT]
> The Proximity APIs do not provide authentication. You should avoid exchanging sensitive data with these APIs.

## -examples

[!code-csharp[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/csharp/BlankPage.xaml.cs#SnippetConnect_CS)]

[!code-vb[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/vbnet/BlankPage.xaml.vb#SnippetConnect_CS)]

## -see-also

[Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_NETWORKING [Windows Phone], ID_CAP_NETWORKING [Windows Phone]
