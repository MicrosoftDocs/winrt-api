---
-api-id: T:Windows.Media.Casting.CastingSource
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class CastingSource : Windows.Media.Casting.ICastingSource
-->

# Windows.Media.Casting.CastingSource

## -description
Represents the media content that can be sent to another device.

## -remarks
You can obtain this object from a [MediaPlayer](../windows.media.playback/mediaplayer.md), [Image](../windows.ui.xaml.controls/image.md), or HTML Tag by calling the respective [GetAsCastingSource](../windows.media.playback/mediaplayer_getascastingsource.md) method. In the current release, apps should use **MediaPlayer** and [MediaPlayerElement](../windows.ui.xaml.controls/mediaplayerelement.md) for media playback, but the legacy [MediaElement](../windows.ui.xaml.controls/mediaelement.md) control also provides a [GetAsCastingSource](../windows.ui.xaml.controls/mediaelement_getascastingsource.md) method.

## -examples

## -see-also
[Image.GetAsCastingSource](../windows.ui.xaml.controls/image_getascastingsource.md), [MediaElement.GetAsCastingSource](../windows.ui.xaml.controls/mediaelement_getascastingsource.md)