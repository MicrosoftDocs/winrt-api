---
-api-id: T:Windows.Media.Playback.MediaItemDisplayProperties
-api-type: winrt class
---

<!-- Class syntax.
public class MediaItemDisplayProperties : Windows.Media.Playback.IMediaItemDisplayProperties
-->

# Windows.Media.Playback.MediaItemDisplayProperties

## -description
Defines a set of metadata for a [MediaPlaybackItem](mediaplaybackitem.md) that is displayed in the System Media Transport Controls while the item is playing.

## -remarks
Get an instance of the **MediaItemDisplayProperties** class by calling [GetDisplayProperties](mediaplaybackitem_getdisplayproperties_103236454.md) on an initialized [MediaPlaybackItem](mediaplaybackitem.md) object. Update the display properties for the playback item by setting the properties of the retrieved **MediaItemDisplayProperties** object and then calling [ApplyDisplayProperties](mediaplaybackitem_applydisplayproperties_1634192028.md).

For how-to guidance for integrating with the SMTC, see [Integrate with the System Media Transport Controls](/windows/uwp/audio-video-camera/integrate-with-systemmediatransportcontrols).

## -examples

## -see-also
[Integrate with the System Media Transport Controls](/windows/uwp/audio-video-camera/integrate-with-systemmediatransportcontrols)