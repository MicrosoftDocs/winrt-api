---
-api-id: P:Windows.Media.Playback.MediaPlaybackSession.NormalizedSourceRect
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Rect NormalizedSourceRect { get;  set; }
-->

# Windows.Media.Playback.MediaPlaybackSession.NormalizedSourceRect

## -description
Gets or sets a normalized rectangle within the video source which is rendered by the [MediaPlayer](mediaplayer.md). This enables pan and zoom within video.

## -property-value
A normalized rectangle specifying the rectangle within the source video that is rendered by the [MediaPlayer](mediaplayer.md).

## -remarks
The **x** and **y** fields of the supplied [Rect](../windows.foundation/rect.md) express the top and left coordinates of the source rectangle. The values for **x** and **y** must be non-negative and less than 1.0. To get a normalized top, left coordinate from pixel values, divide the desired **x** value, in pixels, by the value of the [NaturalVideoWidth](mediaplaybacksession_naturalvideowidth.md) property, and multiply the desired **y** value, in pixels, by the value of the [NaturalVideoHeight](mediaplaybacksession_naturalvideoheight.md) property.

The **width** and **height** fields of the supplied [Rect](../windows.foundation/rect.md) must be non-negative. To get normalized width and height values, divide the desired width, in pixels, by the value of the [NaturalVideoWidth](mediaplaybacksession_naturalvideowidth.md) property, and multiply the desired height value, in pixels, by the value of the [NaturalVideoHeight](mediaplaybacksession_naturalvideoheight.md) property.

The sum of the **x** value and the **width** value must be less than 1+10<sup>-4</sup>. The sum of the **y** value and the **height** value must be less than 1+10<sup>-4</sup>.

The default value for this property is (0,0,1,1) which selects the entire source rectangle to be rendered.

## -examples

## -see-also
