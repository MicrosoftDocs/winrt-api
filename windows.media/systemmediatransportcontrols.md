---
-api-id: T:Windows.Media.SystemMediaTransportControls
-api-type: winrt class
---

<!-- Class syntax.
public class SystemMediaTransportControls : Windows.Media.ISystemMediaTransportControls, Windows.Media.ISystemMediaTransportControls2
-->

# Windows.Media.SystemMediaTransportControls

## -description

Represents an object that enables integration with the system media transport controls and support for media commands.

## -remarks

The SystemMediaTransportControls replaces the [MediaControl](mediacontrol.md) class. In Windows 8.1 and later, you should use this control instead of [MediaControl](mediacontrol.md) to interact with the system transport controls. The system transport controls enable media application developers integrate with the built-in system UI to display media metadata such as artist, album title, or chapter title. The system transport control also allows a user to control the playback of a media app using the built-in system UI, such as pausing playback and skipping forward and backward in a playlist.

<img alt="System Media Transtport Controls" src="images/smtc.png" />

Starting with Windows 10, version 1607, UWP apps that use the [MediaPlayer](../windows.media.playback/mediaplayer.md) class or [AudioGraph](../windows.media.audio/audiograph.md) class to play media are automatically integrated with the SMTC by default. Simply instantiate a new instance of **MediaPlayer** and assign a [MediaSource](../windows.media.core/mediasource.md), [MediaPlaybackItem](../windows.media.playback/mediaplaybackitem.md), or [MediaPlaybackList](../windows.media.playback/mediaplaybacklist.md) to the player's [Source](../windows.media.playback/mediaplayer_source.md) property and the user will see your app name in the SMTC and can play, pause, and move through your playback lists by using the SMTC controls. Get an instance of the SMTC by accessing the **MediaPlayer** object's [SystemMediaTransportControls](../windows.media.playback/mediaplayer_systemmediatransportcontrols.md) property. For how-to guidance on using the SMTC from your app, see [Integrate with the SystemMediaTransportControls](/windows/uwp/audio-video-camera/integrate-with-systemmediatransportcontrols).

For some scenarios, you may want to disable automatic integration with the SMTC. In this case, you should disable the **MediaPlayer** object's [CommandManager](../windows.media.playback/mediaplayer_commandmanager.md) by setting the [IsEnabled](../windows.media.playback/mediaplaybackcommandmanager_isenabled.md) property to false. Call [GetForCurrentView](systemmediatransportcontrols_getforcurrentview_1363600702.md) to get an instance of the SystemMediaTransportControls for current view. You will also need to get an instance this way if you are targeting an older version of Windows. For how-to guidance on manually controlling the SMTC, see [Manual control of the System Media Transport Controls](/windows/uwp/audio-video-camera/system-media-transport-controls).

## -examples

## -see-also

[Integrate with the SystemMediaTransportControls](/windows/uwp/audio-video-camera/integrate-with-systemmediatransportcontrols), [Manual control of the System Media Transport Controls](/windows/uwp/audio-video-camera/system-media-transport-controls), [System media transport controls sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SystemMediaTransportControls)
