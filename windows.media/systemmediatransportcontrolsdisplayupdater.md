---
-api-id: T:Windows.Media.SystemMediaTransportControlsDisplayUpdater
-api-type: winrt class
---

<!-- Class syntax.
public class SystemMediaTransportControlsDisplayUpdater : Windows.Media.ISystemMediaTransportControlsDisplayUpdater
-->

# Windows.Media.SystemMediaTransportControlsDisplayUpdater

## -description
Provides functionality to update the music information that is displayed on the [SystemMediaTransportControls](systemmediatransportcontrols.md).

## -remarks
Starting with Windows 10, version 1607, UWP apps that use the [MediaPlayer](../windows.media.playback/mediaplayer.md) class to play media are automatically integrated with the SMTC by default. With automatic integration, you update the media metadata, such as the title of a media item, using the [MediaPlaybackItem](../windows.media.playback/mediaplaybackitem.md) class. Call [GetDisplayProperties](../windows.media.playback/mediaplaybackitem_getdisplayproperties_103236454.md) to get an instance of the [MediaItemDisplayProperties](../windows.media.playback/mediaitemdisplayproperties.md) class. Update the object with the values you want to be displayed for the item in the SMTC and then call [ApplyDisplayProperties](../windows.media.playback/mediaplaybackitem_applydisplayproperties_1634192028.md) to commit the changes. For how-to guidance on using the SMTC from your app, see [Integrate with the SystemMediaTransportControls](/windows/uwp/audio-video-camera/integrate-with-systemmediatransportcontrols).

If you are disabling manual SMTC integration or you are targeting an older version of Windows, you must use the [SystemMediaTransportControls.DisplayUpdater](systemmediatransportcontrols_displayupdater.md) to update the media metadata. For how-to guidance on manually controlling the SMTC, see [Manual control of the System Media Transport Controls](/windows/uwp/audio-video-camera/system-media-transport-controls).

## -examples

## -see-also
[Integrate with the SystemMediaTransportControls](/windows/uwp/audio-video-camera/integrate-with-systemmediatransportcontrols), [Manual control of the System Media Transport Controls](/windows/uwp/audio-video-camera/system-media-transport-controls)