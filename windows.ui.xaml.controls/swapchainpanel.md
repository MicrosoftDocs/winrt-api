---
-api-id: T:Windows.UI.Xaml.Controls.SwapChainPanel
-api-type: winrt class
---

<!-- Class syntax.
public class SwapChainPanel : Windows.UI.Xaml.Controls.Grid, Windows.UI.Xaml.Controls.ISwapChainPanel
-->

# Windows.UI.Xaml.Controls.SwapChainPanel

## -description

Provides a hosting surface, where Microsoft DirectX swap chains provide content that can be rendered into a XAML UI. A SwapChainPanel element is a key component for an app that renders Microsoft DirectX graphics and then presents those visuals within a XAML page.


## -xaml-syntax

```xaml
<SwapChainPanel .../>
```

## -remarks

A SwapChainPanel is a [Grid](grid.md) subclass, so you can use [ColumnDefinitions](grid_columndefinitions.md) and [RowDefinitions](grid_rowdefinitions.md) properties to declare the panel's characteristics, and the attached properties of [Grid](grid.md) such as [Grid.Row](/uwp/api/windows.ui.xaml.controls.grid.row) and [Grid.Column](/uwp/api/windows.ui.xaml.controls.grid.column) on child elements to position those child elements in the layout.

SwapChainPanel inherits the Background property from Panel, but you can't set the Background on a SwapChainPanel. An error occurs if you attempt to set it.

The SwapChainPanel class does not inherit from the [Control](control.md) class, so you can't programmatically focus it directly for purposes of capturing key events. Consider setting the focus to a focusable element inside the panel and letting the key event bubble.

In order to maintain crisp vector rendering, you should listen for the [CompositionScaleChanged](swapchainpanel_compositionscalechanged.md) event and query the [CompositionScaleX](swapchainpanel_compositionscalex.md) and [CompositionScaleY](swapchainpanel_compositionscaley.md) property values to account for the current UI scale, and potentially [render again from DirectX](/windows/desktop/api/dxgi1_2/nf-dxgi1_2-idxgiswapchain1-present1). Otherwise XAML layout might do the scaling and your visuals might be degraded.

### Initializing a **SwapChainPanel** element

For code examples that use SwapChainPanel, see [XAML SwapChainPanel DirectX interop sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20SwapChainPanel%20DirectX%20interop%20sample).

Before a SwapChainPanel can render content, you must initialize it from the Microsoft DirectX side.

Cast the SwapChainPanel instance to [IInspectable](/windows/desktop/api/inspectable/nn-inspectable-iinspectable) or [IUnknown](/windows/desktop/api/unknwn/nn-unknwn-iunknown), then call [QueryInterface](/windows/win32/api/unknwn/nf-unknwn-iunknown-queryinterface(q)) to obtain a reference to the [ISwapChainPanelNative](/windows/desktop/api/windows.ui.xaml.media.dxinterop/nn-windows-ui-xaml-media-dxinterop-iswapchainpanelnative) interface (this is the native interface implementation that is the complement to the SwapChainPanel and enables the interop bridge). Then, call [ISwapChainPanelNative.SetSwapChain](/windows/desktop/api/windows.ui.xaml.media.dxinterop/nf-windows-ui-xaml-media-dxinterop-iswapchainpanelnative-setswapchain) on that reference to associate your implemented swap chain with the SwapChainPanel instance.

It's common to put the code that queries the interface and sets the swap chain as part of a **Create*Resources** method. The **Create*Resources** methods are an implementation pattern that's seen in the Microsoft DirectX  **Renderer** class templates/examples, and you'll also see this implementation pattern in the SDK samples, and in the code you get from the **DirectX (XAML)** project template in Microsoft Visual Studio. Specifically, in the **DirectX (XAML)** project template, you'll see the **QueryInterface** call and the call to [ISwapChainPanelNative.SetSwapChain](/windows/desktop/api/windows.ui.xaml.media.dxinterop/nf-windows-ui-xaml-media-dxinterop-iswapchainpanelnative-setswapchain) in the `DeviceResources::CreateWindowSizeDependentResources` method implementation in DeviceResources.cpp.

The API that enables you to add a **SwapChain** to an existing SwapChainPanel is not a runtime class API, it is a Microsoft DirectX  API. You implement the swap chain input as a Microsoft DirectX interface ([IDXGISwapChain](/windows/desktop/api/dxgi/nn-dxgi-idxgiswapchain)).

### **SwapChainPanel** and **SwapChainBackgroundPanel**

SwapChainPanel has less restrictions on its interactions and placement in UI than does [SwapChainBackgroundPanel](swapchainbackgroundpanel.md).

+ SwapChainPanel can be used as a control anywhere in a visual tree of a page. [SwapChainBackgroundPanel](swapchainbackgroundpanel.md) can only be the root element.
+ The typical XAML UI API that are inherited from the [Grid](grid.md) base class can be used on a SwapChainPanel. [SwapChainBackgroundPanel](swapchainbackgroundpanel.md) doesn't permit you to set most [Grid](grid.md) inherited API.
+ For new apps you should generally use SwapChainPanel and should consider [SwapChainBackgroundPanel](swapchainbackgroundpanel.md) to be a legacy technique for Windows 8 apps that weren't updated for Windows 8.1.

### Swap chains

+ Swap chains must run on the main UI thread. This is usually accomplished by calling **SetSwapChain** on a reference that was initialized as a XAML object element.
+ A single swap chain can be associated with multiple SwapChainPanel elements. Or, your app can have multiple swap chains, with each providing the presentation for a separate SwapChainPanel.
+ However, performance can decline if many swap chains are updated simultaneously. We recommend that your app use no more than four swap chains.
+ Content that's rendered via the swap chain is not stretched when it's resized by the user; instead, the resizing behavior is similar to setting `Stretch="None"` on an [Image](image.md) element.
+ There are other techniques for rendering swap chain content that goes directly to the app's core window rather than a XAML-composed element. See [CreateSwapChainForCoreWindow](/windows/desktop/api/dxgi1_2/nf-dxgi1_2-idxgifactory2-createswapchainforcorewindow).

### Processing input on background threads

Using the [CreateCoreIndependentInputSource](swapchainpanel_createcoreindependentinputsource_467679991.md) method, apps can process input and render to a SwapChainPanel entirely on one or more background threads. This enables high performance input and rendering independent of the XAML UI thread.

## -examples

## -see-also

[Grid](grid.md), [SwapChainBackgroundPanel](swapchainbackgroundpanel.md), [ISwapChainPanelNative](/windows/desktop/api/windows.ui.xaml.media.dxinterop/nn-windows-ui-xaml-media-dxinterop-iswapchainpanelnative), [DirectX and XAML interop](/previous-versions/windows/apps/hh825871(v=win.10)), [XAML SwapChainPanel DirectX interop sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20SwapChainPanel%20DirectX%20interop%20sample), [DirectX and XAML game sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Simple3DGameXaml), [Direct2D photo adjustment sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620533), [Low latency input sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/LowLatencyInput), [Direct2D SVG image rendering sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/D2DSvgImage)
