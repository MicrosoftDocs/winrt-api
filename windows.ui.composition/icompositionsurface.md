---
-api-id: T:Windows.UI.Composition.ICompositionSurface
-api-type: winrt interface
---

<!-- Interface syntax.
public interface ICompositionSurface :
-->

# Windows.UI.Composition.ICompositionSurface

## -description
Represents the content of a surface that can be used to paint the bounds of a SpriteVisual. All surface types that can be used to paint a SpriteVisual must implement this interface. The following classes implement this interface and can be set as content of a SpriteVisual (using a CompositionSurfaceBrush):

|Class                     |Details                                                   |
|--------------------------|----------------------------------------------------------|
|CompositionDrawingSurface |Fixed sized surface that can be rendered with an image using [LoadedImageSurface](https://docs.microsoft.com/en-us/uwp/api/windows.ui.xaml.media.loadedimagesurface) or custom drawing using [Win2D](https://github.com/Microsoft/Win2D) (orD2D) or a video using [MediaPlayer](https://docs.microsoft.com/en-us/uwp/api/Windows.Media.Playback.MediaPlayer).
|CompositionVirtualDrawingSurface|Similar to CompositionDrawingSurface, except the surface is sparsely allocated.Typically used when you need to define a large amount of content but only expects a small portion of content to be visible at a given time. The content can be rendered using Win2D (or D2D). 

