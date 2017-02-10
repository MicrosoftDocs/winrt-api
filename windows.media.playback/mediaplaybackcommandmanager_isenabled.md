---
-api-id: P:Windows.Media.Playback.MediaPlaybackCommandManager.IsEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsEnabled { get;  set; }
-->

# Windows.Media.Playback.MediaPlaybackCommandManager.IsEnabled

## -description
Gets or sets a value indicating whether the [MediaPlaybackCommandManager](mediaplaybackcommandmanager.md) is enabled.

## -property-value
True if the [MediaPlaybackCommandManager](mediaplaybackcommandmanager.md) is enabled; otherwise, false.

## -remarks
If your app scenario requires manual control of the System Media Transport Controls you can disable the [MediaPlaybackCommandManager](mediaplaybackcommandmanager.md) and using the events and properties of the [SystemMediaTransportControls](mediaplayer_systemmediatransportcontrols.md) directly.

> [!NOTE]
> If you disable the **MediaPlaybackCommandManager** by setting **IsEnabled** to false, it will break the link between the [MediaPlayer](mediaplayer.md) the [TransportControls](../windows.ui.xaml.controls/mediaplayerelement_transportcontrols.md) provided by the [MediaPlayerElement](../windows.ui.xaml.controls/mediaplayerelement.md), so the built-in transport controls will no longer automatically control the playback of the player. Instead, you must implement your own controls to control the **MediaPlayer**.

## -examples

## -see-also
