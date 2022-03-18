---
-api-id: M:Windows.Networking.Proximity.PeerFinder.Start
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void Start()
-->

# Windows.Networking.Proximity.PeerFinder.Start

## -description
Makes an app discoverable to remote peers.

## -remarks

You can call the **Start** method to begin the process of finding a peer app and to make your app discoverable to remote peers that call the [FindAllPeersAsync](peerfinder_findallpeersasync_830195586.md) method. A peer is a device that has an app running in the foreground with a matching AppId. A peer can also have a matching Browse Id that's specified as an alternate identity. For more information, see [AlternateIdentities](peerfinder_alternateidentities.md).

You can connect to only one peer at a time if your app is in the peer or client role. If your app is in the host role, you can connect up to 5 clients at a time.

When an app is activated by tapping a nearby device, the activation parameters indicate whether the [PeerFinder](peerfinder.md) should be started or if the app was launched with activation arguments. The format of the activation parameters is *"Windows.Networking.Proximity.PeerFinder:StreamSocket Role=&lt;Host|Client&gt;"*. For more information, see the "Activating apps using Proximity" section of [Supporting Proximity and Tapping.](/previous-versions/windows/apps/hh465229(v=win.10))



> [!IMPORTANT]
> Always set the [DisplayName](peerfinder_displayname.md) property to a unique value for your app before you call the [Start](peerfinder_start_119778276.md) method.

### Windows Phone 8

Wi-Fi Direct is not supported on Windows Phone 8. 

## -examples

[!code-csharp[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/csharp/BlankPage.xaml.cs#SnippetConnect_CS)]

[!code-vb[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/vbnet/BlankPage.xaml.vb#SnippetConnect_CS)]

## -see-also
[AlternateIdentities](peerfinder_alternateidentities.md), [Start(String)](peerfinder_start_119778276.md), [Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_PROXIMITY [Windows Phone], ID_CAP_NETWORKING [Windows Phone], ID_CAP_NETWORKING [Windows Phone]
