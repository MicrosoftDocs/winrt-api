---
-api-id: E:Windows.UI.Xaml.Media.CompositionTarget.Rendering
-api-type: winrt event
---

<!-- Event syntax
static public event Windows.Foundation.EventHandler Rendering<object>
-->

# Windows.UI.Xaml.Media.CompositionTarget.Rendering

## -description
Occurs when the core rendering process renders a frame.



## -remarks
Handling Rendering can be useful if you have interop scenarios with Microsoft DirectX content. For example you might want to know when the XAML framework is rendering a frame and synchronize that with your Microsoft DirectX generated content in a [SwapChainPanel](../windows.ui.xaml.controls/swapchainpanel.md) or [SurfaceImageSource](../windows.ui.xaml.media.imaging/surfaceimagesource.md) so visual updates are presented to the screen at the same time. For more info, see [DirectX and XAML interop](/windows/uwp/gaming/directx-and-xaml-interop).

To satisfy the compiler, the second *e*/*args* parameter of your handler for a Rendering event must be **Object**. Don't use **EventArgs**. However, within the handler, you can cast the *e*/*args* reference as [RenderingEventArgs](renderingeventargs.md). [RenderingEventArgs](renderingeventargs.md) has one property, [RenderingTime](renderingeventargs_renderingtime.md), that might be useful in your rendering scenario, but not all handlers would need this info. It may be enough just to know that the event fires and handle every occurrence.

Handlers for Rendering run on the UI thread even though they're not tied to any specific UI element. This is similar to running an infinite animation. Normally the UI thread is active only when there is work to do, but adding a handler for this event forces it to run every frame which can prevent system power usage optimizations. It's therefore a good idea to remove any Rendering handlers when you no longer need them, and add them only when you do need them. For example add the handler only when specific pages with synchronized DirectX content are loaded, and then remove the handler as part of page cleanup ([OnNavigatedFrom](../windows.ui.xaml.controls/page_onnavigatedfrom_1389759661.md)). For more information see the [Use infinite animations sparingly section of the performance guide](/windows/uwp/debug-test-perf/optimize-animations-and-media#use-infinite-animations-sparingly).

## -examples

## -see-also
[CompositionTarget.Rendered](compositiontarget_rendered.md), [DirectX and XAML interop](/windows/uwp/gaming/directx-and-xaml-interop), [Optimize animations and media](/windows/uwp/debug-test-perf/optimize-animations-and-media)
