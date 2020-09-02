---
-api-id: T:Windows.Media.Playback.MediaPlayerSurface
-api-type: winrt class
---

<!-- Class syntax.
public class MediaPlayerSurface : Windows.Foundation.IClosable, Windows.Media.Playback.IMediaPlayerSurface
-->

# Windows.Media.Playback.MediaPlayerSurface

## -description
Provides access to a [ICompositionSurface](../windows.ui.composition/icompositionsurface.md) that is shared between a [MediaPlayer](mediaplayer.md) and a [Compositor](../windows.ui.composition/compositor.md) to enable the rendering of **MediaPlayer** content using the [Windows.UI.Composition](../windows.ui.composition/windows_ui_composition.md) APIs without requiring the use of the XAML framework.

## -remarks
Get an instance of this class by calling [MediaPlayer.GetSurface](mediaplayer_getsurface_812026623.md).

For more information on using the [Windows.UI.Composition](../windows.ui.composition/windows_ui_composition.md) APIs to render visuals, see [Visual layer](/windows/uwp/graphics/visual-layer).

For how-to guidance for rendering video to a composition surface, see [Play audio and video with MediaPlayer](/windows/uwp/audio-video-camera/play-audio-and-video-with-mediaplayer).

## -examples

## -see-also
[IClosable](../windows.foundation/iclosable.md), [Visual layer](/windows/uwp/graphics/visual-layer), [Play audio and video with MediaPlayer](/windows/uwp/audio-video-camera/play-audio-and-video-with-mediaplayer)