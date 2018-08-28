---
-api-id: T:Windows.UI.Xaml.Controls.SwapChainPanel
-api-type: winrt class
---

<!-- Class syntax.
public class SwapChainPanel : Windows.UI.Xaml.Controls.Grid, Windows.UI.Xaml.Controls.ISwapChainPanel
-->

# Windows.UI.Xaml.Controls.SwapChainPanel

## -description

Provides a hosting surface, where Microsoft DirectX swap chains provide content that can be rendered into a XAML UI. A [SwapChainPanel](swapchainpanel.md) element is a key component for an app that renders Microsoft DirectX graphics and then presents those visuals within a XAML page.

## -xaml-syntax

```xaml
<SwapChainPanel .../>
```

## -remarks

A [SwapChainPanel](swapchainpanel.md) is a [Grid](grid.md) subclass, so you can use [ColumnDefinitions](grid_columndefinitions.md) and [RowDefinitions](grid_rowdefinitions.md) properties to declare the panel's characteristics, and the attached properties of [Grid](grid.md) such as [Grid.Row](grid_row.md) and [Grid.Column](grid_column.md) on child elements to position those child elements in the layout.

For code examples that use [SwapChainPanel](swapchainpanel.md), see [XAML SwapChainPanel DirectX interop sample](http://go.microsoft.com/fwlink/p/?LinkID=309155).

The [SwapChainPanel](swapchainpanel.md) class does not inherit from the [Control](control.md) class, so you can't programmatically focus it directly for purposes of capturing key events. Consider setting the focus to a focusable element inside the panel and letting the key event bubble.

In order to maintain crisp vector rendering, you should listen for the [CompositionScaleChanged](swapchainpanel_compositionscalechanged.md) event and query the [CompositionScaleX](swapchainpanel_compositionscalex.md) and [CompositionScaleY](swapchainpanel_compositionscaley.md) property values to account for the current UI scale, and potentially [render again from DirectX](http://msdn.microsoft.com/library/f795a719-71ba-4a25-b41a-9d93f96b6ca4). Otherwise XAML layout might do the scaling and your visuals might be degraded.

### Initializing a **SwapChainPanel** element

Before a [SwapChainPanel](swapchainpanel.md) can render content, you must initialize it from the Microsoft DirectX side.

Cast the [SwapChainPanel](swapchainpanel.md) instance to [IInspectable](http://msdn.microsoft.com/library/0657e51f-d4c0-46c6-927d-b01e54b6846c) or [IUnknown](http://msdn.microsoft.com/library/33f1d79a-33fc-4ce5-a372-e08bda378332), then call [QueryInterface](http://msdn.microsoft.com/library/54d5ff80-18db-43f2-b636-f93ac053146d) to obtain a reference to the [ISwapChainPanelNative](http://msdn.microsoft.com/library/b36147c7-1304-4175-8ad3-cd5fca17b4ae) interface (this is the native interface implementation that is the complement to the [SwapChainPanel](swapchainpanel.md) and enables the interop bridge). Then, call [ISwapChainPanelNative.SetSwapChain](http://msdn.microsoft.com/library/8269a6dc-1732-40cf-96c7-fa13bc6763d2) on that reference to associate your implemented swap chain with the [SwapChainPanel](swapchainpanel.md) instance.

It's common to put the code that queries the interface and sets the swap chain as part of a **Create*Resources** method. The **Create*Resources** methods are an implementation pattern that's seen in the Microsoft DirectX  **Renderer** class templates/examples, and you'll also see this implementation pattern in the SDK samples, and in the code you get from the **DirectX (XAML)** project template in Microsoft Visual Studio. Specifically, in the **DirectX (XAML)** project template, you'll see the **QueryInterface** call and the call to [ISwapChainPanelNative.SetSwapChain](http://msdn.microsoft.com/library/8269a6dc-1732-40cf-96c7-fa13bc6763d2) in the `DeviceResources::CreateWindowSizeDependentResources` method implementation in DeviceResources.cpp.

The API that enables you to add a **SwapChain** to an existing [SwapChainPanel](swapchainpanel.md) is not a runtime class API, it is a Microsoft DirectX  API. You implement the swap chain input as a Microsoft DirectX interface ([IDXGISwapChain](http://msdn.microsoft.com/library/344ada45-35a0-4e99-b3b7-0f316df029ab)).

### **SwapChainPanel** and **SwapChainBackgroundPanel**

[SwapChainPanel](swapchainpanel.md) has less restrictions on its interactions and placement in UI than does [SwapChainBackgroundPanel](swapchainbackgroundpanel.md).

+ [SwapChainPanel](swapchainpanel.md) can be used as a control anywhere in a visual tree of a page. [SwapChainBackgroundPanel](swapchainbackgroundpanel.md) can only be the root element.
+ The typical XAML UI API that are inherited from the [Grid](grid.md) base class can be used on a [SwapChainPanel](swapchainpanel.md). [SwapChainBackgroundPanel](swapchainbackgroundpanel.md) doesn't permit you to set most [Grid](grid.md) inherited API.
+ For new apps you should generally use [SwapChainPanel](swapchainpanel.md) and should consider [SwapChainBackgroundPanel](swapchainbackgroundpanel.md) to be a legacy technique for Windows 8 apps that weren't updated for Windows 8.1.

### Swap chains

+ Swap chains must run on the main UI thread. This is usually accomplished by calling **SetSwapChain** on a reference that was initialized as a XAML object element.
+ A single swap chain can be associated with multiple [SwapChainPanel](swapchainpanel.md) elements. Or, your app can have multiple swap chains, with each providing the presentation for a separate [SwapChainPanel](swapchainpanel.md).
+ However, performance can decline if many swap chains are updated simultaneously. We recommend that your app use no more than four swap chains.
+ Content that's rendered via the swap chain is not stretched when it's resized by the user; instead, the resizing behavior is similar to setting `Stretch="None"` on an [Image](image.md) element.
+ There are other techniques for rendering swap chain content that goes directly to the app's core window rather than a XAML-composed element. See [CreateSwapChainForCoreWindow](http://msdn.microsoft.com/library/b3ac3aeb-3449-4444-9fd3-866a3795c41f).

### Processing input on background threads

Using the [CreateCoreIndependentInputSource](swapchainpanel_createcoreindependentinputsource_467679991.md) method, apps can process input and render to a [SwapChainPanel](swapchainpanel.md) entirely on one or more background threads. This enables high performance input and rendering independent of the XAML UI thread.

## -examples

## -see-also

[Grid](grid.md), [SwapChainBackgroundPanel](swapchainbackgroundpanel.md), [ISwapChainPanelNative](http://msdn.microsoft.com/library/b36147c7-1304-4175-8ad3-cd5fca17b4ae), [DirectX and XAML interop](http://msdn.microsoft.com/library/17987eea-6771-423c-9b68-6b9aeadc7b7f), [XAML SwapChainPanel DirectX interop sample](http://go.microsoft.com/fwlink/p/?LinkID=309155), [DirectX and XAML game sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620599), [Direct2D photo adjustment sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620533), [Low latency input sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/LowLatencyInput), [Direct2D SVG image rendering sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/D2DSvgImage)
