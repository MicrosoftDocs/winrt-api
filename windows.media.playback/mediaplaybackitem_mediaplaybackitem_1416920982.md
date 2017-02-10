---
-api-id: M:Windows.Media.Playback.MediaPlaybackItem.#ctor(Windows.Media.Core.MediaSource)
-api-type: winrt method
---

<!-- Method syntax
public MediaPlaybackItem(Windows.Media.Core.MediaSource source)
-->

# Windows.Media.Playback.MediaPlaybackItem.MediaPlaybackItem

## -description
Initializes a new instance of the [MediaPlaybackItem](mediaplaybackitem.md) class.

## -parameters
### -param source
The media source from which the [MediaPlaybackItem](mediaplaybackitem.md) is created.

## -remarks
A [MediaSource](../windows.media.core/mediasource.md) can only be used by a single **MediaPlaybackItem**. If you attempt to create a second **MediaPlaybackItem** from the same **MediaSource**, the constructor will fail with an MF_E_UNEXPECTED error. In C# this error is projected as a **System.Exception**.

## -examples

## -see-also
