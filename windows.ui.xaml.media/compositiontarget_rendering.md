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
Handling [Rendering](compositiontarget_rendering.md) is mainly interesting if you have interop scenarios with Microsoft DirectX content. For example you might want to know when the XAML system is rendering and synchronize that with your Microsoft DirectX generated content and when your [SwapChainPanel](../windows.ui.xaml.controls/swapchainpanel.md) draws. For more info, see [DirectX and XAML interop](http://msdn.microsoft.com/library/17987eea-6771-423c-9b68-6b9aeadc7b7f).

Because this event is for an interop scenario, it's rare that you would handle [Rendering](compositiontarget_rendering.md) in C# or Microsoft Visual Basic code. You'd usually only handle it in the Visual C++ component extensions (C++/CX) code that supports the XAML portion of your UI, as part of an interop/hybrid app that also has a Microsoft DirectX component.

To satisfy the compiler, the second *e*/*args* parameter of your handler for a [Rendering](compositiontarget_rendering.md) event must be **Object**. Don't use **EventArgs**. However, within the handler, you can cast the *e*/*args* reference as [RenderingEventArgs](renderingeventargs.md). [RenderingEventArgs](renderingeventargs.md) has one property, [RenderingTime](renderingeventargs_renderingtime.md), that might be useful in your rendering scenario, but not all handlers would need this info. It may be enough just to know that the event fires and handle every occurrence.

Handlers for [Rendering](compositiontarget_rendering.md) run on the UI thread even though they're not tied to any specific UI element. It's a good idea to remove any [Rendering](compositiontarget_rendering.md) handlers when you no longer need them, and add them only when you do need them. For example add the handler only when specific pages with interop content are loaded, and then remove the handler as part of page cleanup ([OnNavigatedFrom](../windows.ui.xaml.controls/page_onnavigatedfrom.md)).

For example code of handling [Rendering](compositiontarget_rendering.md), see [ shooting game sample](http://go.microsoft.com/fwlink/p/?linkid=238717). The `App::OnRendering` method in this sample is the handler. This handler is noteworthy because it has code in it that checks its own UI state (such as checking for whether the control has focus). For certain states the handler acts as its own one-time cleanup by calling `::remove` with an app-level stored event token from the initial `::add`.

## -examples

## -see-also
[DirectX and XAML interop](http://msdn.microsoft.com/library/17987eea-6771-423c-9b68-6b9aeadc7b7f), [Optimize animations and media](http://msdn.microsoft.com/library/de5b084c-dac1-430b-a15b-5b3d5fb698f7), [ shooting game sample](http://go.microsoft.com/fwlink/p/?linkid=238717)