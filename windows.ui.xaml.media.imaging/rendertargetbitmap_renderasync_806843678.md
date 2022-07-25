---
-api-id: M:Windows.UI.Xaml.Media.Imaging.RenderTargetBitmap.RenderAsync(Windows.UI.Xaml.UIElement,System.Int32,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction RenderAsync(Windows.UI.Xaml.UIElement element, System.Int32 scaledWidth, System.Int32 scaledHeight)
-->

# Windows.UI.Xaml.Media.Imaging.RenderTargetBitmap.RenderAsync

## -description
Renders a snapshot of a [UIElement](../windows.ui.xaml/uielement.md) visual tree to an image source. Specify values for *scaledWidth* and *scaledHeight* to alter the original source's rendering dimension.



## -parameters
### -param element
A [UIElement](../windows.ui.xaml/uielement.md) that represents the visual tree fragment to render.

### -param scaledWidth
Specifies the target width at which to render. The default is 0. *scaledWidth* and/or *scaledHeight* can be optional; see Remarks.

### -param scaledHeight
Specifies the target height at which to render. The default is 0. *scaledWidth* and/or *scaledHeight* can be optional; see Remarks.

## -returns
An [IAsyncAction](../windows.foundation/iasyncaction.md) object that you can use to control the asynchronous operation.

## -remarks
The rendered image isn't returned by this method. But after it returns, so long as the async [Status](../windows.foundation/iasyncinfo_status.md) value doesn't indicate an error, the [RenderTargetBitmap](rendertargetbitmap.md) that called it will have valid image info. The [RenderTargetBitmap](rendertargetbitmap.md) can then be assigned in code as an image source for an [Image](../windows.ui.xaml.controls/image.md) control or [ImageBrush](../windows.ui.xaml.media/imagebrush.md) instance.

If you need a pixel buffer representation of the rendered content and not just an image source, use [GetPixelsAsync](rendertargetbitmap_getpixelsasync_1480284075.md) after calling [RenderAsync](rendertargetbitmap_renderasync_1804035726.md).

This is an async method, so there's no guarantee of exact frame synchronization with the UI source. See Remarks in [RenderTargetBitmap](rendertargetbitmap.md) for info on some other limitations.

Calling [RenderAsync](rendertargetbitmap_renderasync_1804035726.md) will fail if the scaled height or width of the [UIElement](../windows.ui.xaml/uielement.md) visual tree are larger than the amount of video memory the system is able to allocate internally.

You can pass **null** for the *element* parameter, and that renders the root visual tree of the app.

### *scaledWidth* and *scaledHeight* values

If *scaledWidth* and *scaledHeight* are both set, the aspect ratio of the original bitmap is ignored, and your values can alter the aspect ratio.

If either *scaledWidth* or *scaledHeight* but not both is specified, the value you provide controls that dimension but the aspect ratio is preserved (the other dimension is calculated based on factoring the original bitmap's aspect ratio).

You can call this method and leave the *scaledWidth* and *scaledHeight* values both as 0. In this case the [UIElement](../windows.ui.xaml/uielement.md) tree will be rendered at its native size. This is the same behavior as the [RenderAsync(UIElement)](rendertargetbitmap_renderasync_1804035726.md) overload.

The maximum rendered size of a XAML visual tree is restricted by the maximum dimensions of a Microsoft DirectX texture; for more info see [Resource Limits ()](/windows/desktop/direct3d11/overviews-direct3d-11-resources-limits). This resource limit can vary depending on the hardware where the app runs. Very large content that exceeds this limit might be scaled to fit. If scaling limits are applied in this way, the rendered size after scaling can be queried using the [PixelWidth](rendertargetbitmap_pixelwidth.md) and [PixelHeight](rendertargetbitmap_pixelheight.md) properties. For example, a 10000 by 10000 pixel XAML visual tree might be scaled to 4096 by 4096 pixels, an example of a particular resource limit on 2D textures being applied.

### XAML visuals and **RenderTargetBitmap** capture capabilities

There are a few scenarios for XAML-composed visual content that you can't capture to a [RenderTargetBitmap](rendertargetbitmap.md):
+ Video content in a [MediaElement](../windows.ui.xaml.controls/mediaelement.md) or [CaptureElement](../windows.ui.xaml.controls/captureelement.md) can't be captured using [RenderTargetBitmap](rendertargetbitmap.md). That includes capturing frames from within video content.
+ Custom Microsoft DirectX content (your own swap chain) inside a [SwapChainBackgroundPanel](../windows.ui.xaml.controls/swapchainbackgroundpanel.md) or [SwapChainPanel](../windows.ui.xaml.controls/swapchainpanel.md) can't be captured using [RenderTargetBitmap](rendertargetbitmap.md).
+ Content that's in the tree but with its [Visibility](../windows.ui.xaml/uielement_visibility.md) set to **Collapsed** won't be captured.
+ Content that's not directly connected to the XAML visual tree and the content of the main window won't be captured. This includes [Popup](../windows.ui.xaml.controls.primitives/popup.md) content, which is considered to be like a sub-window.
+ For Windows Phone 8.x app: the contents of a [WebView](../windows.ui.xaml.controls/webview.md) control can't be rendered into a [RenderTargetBitmap](rendertargetbitmap.md).
+ Content that can't be captured will appear as blank in the captured image, but other content in the same visual tree can still be captured and will render (the presence of content that can't be captured won't invalidate the entire capture of that XAML composition).
+ Content that's in the XAML visual tree but offscreen can be captured, so long as it's not [Visibility](../windows.ui.xaml/uielement_visibility.md) = **Collapsed** or in the other restricted cases.


## -examples

## -see-also
[RenderAsync(UIElement)](rendertargetbitmap_renderasync_1804035726.md), [XAML render to bitmap sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20render%20to%20bitmap%20sample)
