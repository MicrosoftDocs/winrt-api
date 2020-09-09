---
-api-id: T:Windows.Media.VideoDisplayProperties
-api-type: winrt class
---

<!-- Class syntax.
public class VideoDisplayProperties : Windows.Media.IVideoDisplayProperties, Windows.Media.IVideoDisplayProperties2
-->

# Windows.Media.VideoDisplayProperties

## -description
Provides properties for video information that is displayed by [SystemMediaTransportControlsDisplayUpdater](systemmediatransportcontrolsdisplayupdater.md) class.

## -remarks
Starting with Windows 10, version 1607, UWP apps that use the [MediaPlayer](../windows.media.playback/mediaplayer.md) class or [AudioGraph](../windows.media.audio/audiograph.md) class to play media are automatically integrated with the System Media Transport Controls by default. When using automatic integration, you can get an instance of the **VideoDisplayProperties** class using the [MediaPlaybackItem](../windows.media.playback/mediaplaybackitem.md) class. Call [GetDisplayProperties](../windows.media.playback/mediaplaybackitem_getdisplayproperties_103236454.md) to get an instance of the [MediaItemDisplayProperties](../windows.media.playback/mediaitemdisplayproperties.md) class. Update the object with the values you want to be displayed for the item in the SMTC and then call [ApplyDisplayProperties](../windows.media.playback/mediaplaybackitem_applydisplayproperties_1634192028.md) to commit the changes. For how-to guidance on using the SMTC from your app, see [Integrate with the SystemMediaTransportControls](/windows/uwp/audio-video-camera/integrate-with-systemmediatransportcontrols).

When manually controlling the SMTC, get an instance of **VideoDisplayProperties** by using the [SystemMediaTransportControlsDisplayUpdater](systemmediatransportcontrolsdisplayupdater.md) class. For how-to guidance on manually controlling the SMTC, see [Manual control of the System Media Transport Controls](/windows/uwp/audio-video-camera/system-media-transport-controls).

## -examples

## -see-also
[MediaPlaybackItem](../windows.media.playback/mediaplaybackitem.md), [MediaItemDisplayProperties](../windows.media.playback/mediaitemdisplayproperties.md), [SystemMediaTransportControlsDisplayUpdater](systemmediatransportcontrolsdisplayupdater.md), [Integrate with the SystemMediaTransportControls](/windows/uwp/audio-video-camera/integrate-with-systemmediatransportcontrols), [Manual control of the System Media Transport Controls](/windows/uwp/audio-video-camera/system-media-transport-controls)