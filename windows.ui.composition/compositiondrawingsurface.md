---
-api-id: T:Windows.UI.Composition.CompositionDrawingSurface
-api-type: winrt class
---

<!-- Class syntax.
public class CompositionDrawingSurface : Windows.UI.Composition.CompositionObject, Windows.UI.Composition.ICompositionDrawingSurface, Windows.UI.Composition.ICompositionDrawingSurface2, Windows.UI.Composition.ICompositionSurface
-->

# Windows.UI.Composition.CompositionDrawingSurface

## -description
A drawing surface for interoperation with Direct2D or Direct3D.



## -remarks

`CompositionDrawingSurface` is a fixed sized surface that can be rendered with:

- an image using [LoadedImageSurface](/uwp/api/windows.ui.xaml.media.loadedimagesurface).
- a custom drawing using [Win2D](https://github.com/Microsoft/Win2D) (orD2D).
- a video using [MediaPlayer](/uwp/api/Windows.Media.Playback.MediaPlayer).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | Resize |
| 1703 | 15063 | Scroll(PointInt32) |
| 1703 | 15063 | Scroll(PointInt32,RectInt32) |
| 1703 | 15063 | ScrollWithClip(PointInt32,RectInt32) |
| 1703 | 15063 | ScrollWithClip(PointInt32,RectInt32,RectInt32) |
| 1703 | 15063 | SizeInt32 |

## -examples

See the code example in [Composition native interoperation with DirectX and Direct2D](/windows/uwp/composition/composition-native-interop).

## -see-also
[CompositionObject](compositionobject.md), [IClosable](../windows.foundation/iclosable.md), [ICompositionSurface](icompositionsurface.md)
