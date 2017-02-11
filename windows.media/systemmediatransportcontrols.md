---
-api-id: T:Windows.Media.SystemMediaTransportControls
-api-type: winrt class
---

<!-- Class syntax.
public class SystemMediaTransportControls : Windows.Media.ISystemMediaTransportControls, Windows.Media.ISystemMediaTransportControls2
-->

# Windows.Media.SystemMediaTransportControls

## -description
Represents an object that enables integrate with the system media transport controls and support for media commands.

## -remarks
The [SystemMediaTransportControls](systemmediatransportcontrols.md) replaces the [MediaControl](mediacontrol.md) class. In Windows 8.1 and later, you should use this control instead of [MediaControl](mediacontrol.md) to interact with the system transport controls. The system transport controls enable music application developers to hook into a system-wide transport control. The system transport control allows a user to control a music application that is in the background as well as get and set the current information on which track is playing.

Starting with Windows 10, version 1607, UWP apps that use the [MediaPlayer](../windows.media.playback/mediaplayer.md) class or [AudioGraph](../windows.media.audio/audiograph.md) class to play media are automatically integrated with the SMTC by default. Simply instantiate a new instance of **MediaPlayer** and assign a [MediaSource](../windows.media.core/mediasource.md), [MediaPlaybackItem](../windows.media.playback/mediaplaybackitem.md), or [MediaPlaybackList](../windows.media.playback/mediaplaybacklist.md) to the player's [Source](../windows.media.playback/mediaplayer_source.md) property and the user will see your app name in the SMTC and can play, pause, and move through your playback lists by using the SMTC controls. Get an instance of the SMTC by accessing the **MediaPlayer** object's [SystemMediaTransportControls](../windows.media.playback/mediaplayer_systemmediatransportcontrols.md) property. For how-to guidance on using the SMTC from your app, see [Integrate with the SystemMediaTransportControls](https://msdn.microsoft.com/en-us/windows/uwp/audio-video-camera/integrate-with-systemmediatransportcontrols).

For some scenarios, you may want to disable automatic integration with the SMTC. In this case, you should disable the **MediaPlayer** object's [CommandManager](../windows.media.playback/mediaplayer_commandmanager.md) by setting the [IsEnabled](../windows.media.playback/mediaplaybackcommandmanager_isenabled.md) property to false. Call [GetForCurrentView](systemmediatransportcontrols_getforcurrentview.md) to get an instance of the [SystemMediaTransportControls](systemmediatransportcontrols.md) for current view. You will also need to get an instance this way if you are targeting an older version of Windows. For how-to guidance on manually controlling the SMTC, see [Manual control of the System Media Transport Controls](https://msdn.microsoft.com/en-us/windows/uwp/audio-video-camera/system-media-transport-controls).

## -examples

## -see-also
[Integrate with the SystemMediaTransportControls](https://msdn.microsoft.com/en-us/windows/uwp/audio-video-camera/integrate-with-systemmediatransportcontrols), [Manual control of the System Media Transport Controls](https://msdn.microsoft.com/en-us/windows/uwp/audio-video-camera/system-media-transport-controls)