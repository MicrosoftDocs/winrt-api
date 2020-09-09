---
-api-id: E:Windows.Media.SystemMediaTransportControls.ButtonPressed
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ButtonPressed<Windows.Media.SystemMediaTransportControls,  Windows.Media.SystemMediaTransportControlsButtonPressedEventArgs>
-->

# Windows.Media.SystemMediaTransportControls.ButtonPressed

## -description
Occurs when a button is pressed on the [SystemMediaTransportControls](systemmediatransportcontrols.md).

## -remarks
Starting with Windows 10, version 1607, UWP apps that use the [MediaPlayer](../windows.media.playback/mediaplayer.md) class or [AudioGraph](../windows.media.audio/audiograph.md) class to play media are automatically integrated with the SMTC by default. For some scenarios, you may want to manually control the SMTC. In this case, you should **ButtonPressed** event to be notified that the user has pressed one of the SMTC buttons. For how-to guidance on manually controlling the SMTC, see [Manual control of the System Media Transport Controls](/windows/uwp/audio-video-camera/system-media-transport-controls).

## -examples

## -see-also
[Manual control of the System Media Transport Controls](/windows/uwp/audio-video-camera/system-media-transport-controls)