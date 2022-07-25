---
-api-id: T:Windows.UI.Xaml.Media.CompositionTarget
-api-type: winrt class
---

<!-- Class syntax.
public class CompositionTarget : Windows.UI.Xaml.Media.ICompositionTarget
-->

# Windows.UI.Xaml.Media.CompositionTarget

## -description
Represents the composited display surface for an app. This class provides application-wide rendering events.



## -remarks

CompositionTarget events are useful for rendering scenarios like:

- synchronizing [DirectX interop rendering](/windows/uwp/gaming/directx-and-xaml-interop) using the [Rendering](compositiontarget_rendering.md) event

- measuring frame rendering time using the [Rendered](compositiontarget_rendered.md) event

- regenerating custom visual content on screen in response to the [SurfaceContentsLost](compositiontarget_surfacecontentslost.md) event, for example regenerating a [RenderTargetBitmap](../windows.ui.xaml.media.imaging/rendertargetbitmap.md) or DirectX interop content in a [SurfaceImageSource](../windows.ui.xaml.media.imaging/surfaceimagesource.md) 

For scenarios that don't involve custom rendering or frame time measurement you probably won't need CompositionTarget and can just rely on the XAML rendering system running and performing all your composition and layout.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | Rendered |

## -examples

## -see-also
[DirectX and XAML interop](/windows/uwp/gaming/directx-and-xaml-interop), [Optimize animations and media](/windows/uwp/debug-test-perf/optimize-animations-and-media)
