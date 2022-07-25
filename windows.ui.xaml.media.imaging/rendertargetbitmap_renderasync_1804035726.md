---
-api-id: M:Windows.UI.Xaml.Media.Imaging.RenderTargetBitmap.RenderAsync(Windows.UI.Xaml.UIElement)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction RenderAsync(Windows.UI.Xaml.UIElement element)
-->

# Windows.UI.Xaml.Media.Imaging.RenderTargetBitmap.RenderAsync

## -description
Renders a snapshot of a [UIElement](../windows.ui.xaml/uielement.md) visual tree to an image source.



## -parameters
### -param element
A [UIElement](../windows.ui.xaml/uielement.md) that represents the visual tree fragment to render.

## -returns
An [IAsyncAction](../windows.foundation/iasyncaction.md) object that you can use to control the asynchronous operation.

## -remarks
The rendered image isn't returned by this method. But after it returns, so long as the async [Status](../windows.foundation/iasyncinfo_status.md) value doesn't indicate an error, the [RenderTargetBitmap](rendertargetbitmap.md) that called it will have valid image info. The [RenderTargetBitmap](rendertargetbitmap.md) can then be assigned in code as an image source for an [Image](../windows.ui.xaml.controls/image.md) control or [ImageBrush](../windows.ui.xaml.media/imagebrush.md) instance.

If you need a pixel buffer representation of the rendered content and not just an image source, use [GetPixelsAsync](rendertargetbitmap_getpixelsasync_1480284075.md) after calling RenderAsync.

This is an async method, so there's no guarantee of exact frame synchronization with the UI source. See Remarks in [RenderTargetBitmap](rendertargetbitmap.md) for info on some other limitations.

You can pass **null** for the *element* parameter, and that renders the root visual tree of the app.

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
[RenderAsync(UIElement, Int32, Int32)](rendertargetbitmap_renderasync_806843678.md), [XAML render to bitmap sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20render%20to%20bitmap%20sample)
