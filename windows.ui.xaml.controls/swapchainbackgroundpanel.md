---
-api-id: T:Windows.UI.Xaml.Controls.SwapChainBackgroundPanel
-api-type: winrt class
---

<!-- Class syntax.
public class SwapChainBackgroundPanel : Windows.UI.Xaml.Controls.Grid, Windows.UI.Xaml.Controls.ISwapChainBackgroundPanel, Windows.UI.Xaml.Controls.ISwapChainBackgroundPanel2
-->

# Windows.UI.Xaml.Controls.SwapChainBackgroundPanel

## -description

Implements a XAML layout surface target for Microsoft DirectX interoperation scenarios. This panel has some atypical restrictions on its usage within an app window; see Remarks.

> [!IMPORTANT]
> SwapChainBackgroundPanel may be altered or unavailable for releases after Windows 8.1. Instead, use [SwapChainPanel](swapchainpanel.md).


## -xaml-syntax

```xaml
<SwapChainBackgroundPanel .../>
```

## -remarks

> [!IMPORTANT]
> SwapChainBackgroundPanel is deprecated and may not be supported in future releases. Change any existing code that used SwapChainBackgroundPanel to use [SwapChainPanel](swapchainpanel.md) instead. There's no downside to using [SwapChainPanel](swapchainpanel.md); the API is new because it relies upon an upgrade in the internal rendering and composition systems that were introduced starting with Windows 8.1.

For most scenarios a [SwapChainPanel](swapchainpanel.md) will provide a more versatile Microsoft DirectX interop render surface than a SwapChainBackgroundPanel does. That's because a [SwapChainPanel](swapchainpanel.md) doesn't have many of the XAML-side composition limitations that are listed in the "Composition limitations" section below. For example you can apply a [RenderTransform](../windows.ui.xaml/uielement_rendertransform.md) to a [SwapChainPanel](swapchainpanel.md). For more info, see [DirectX and XAML interop](/previous-versions/windows/apps/hh825871(v=win.10)) and [SwapChainPanel](swapchainpanel.md).

A SwapChainBackgroundPanel is a [Grid](grid.md) subclass, so you can use [ColumnDefinitions](grid_columndefinitions.md) and [RowDefinitions](grid_rowdefinitions.md) properties to declare the panel's characteristics, and the attached properties of [Grid](grid.md) such as [Grid.Row](/uwp/api/windows.ui.xaml.controls.grid.row) and [Grid.Column](/uwp/api/windows.ui.xaml.controls.grid.column) on child elements to position those child elements in the layout.

For more info on how to use SwapChainBackgroundPanel, including sample code, see [DirectX and XAML interop](/previous-versions/windows/apps/hh825871(v=win.10)).

The SwapChainBackgroundPanel class does not inherit from the [Control](control.md) class, and you cannot force focus to this element. Events that rely on having focus, such as **KeyUp** and **KeyDown**, may have no effect.

### Initializing a **SwapChainPanel** element

Before a [SwapChainBackgroundPanel](swapchainpanel.md) can render content, you must initialize it from the Microsoft DirectX side.

Cast the SwapChainBackgroundPanel instance to [IInspectable](/windows/desktop/api/inspectable/nn-inspectable-iinspectable) or [IUnknown](/windows/desktop/api/unknwn/nn-unknwn-iunknown), then call [QueryInterface](/windows/win32/api/unknwn/nf-unknwn-iunknown-queryinterface(q)) to obtain a reference to the [ISwapChainBackgroundPanelNative](/windows/desktop/api/windows.ui.xaml.media.dxinterop/nn-windows-ui-xaml-media-dxinterop-iswapchainbackgroundpanelnative) interface (this is the native interface implementation that is the complement to the SwapChainBackgroundPanel and enables the interop bridge). Then, call [ISwapChainBackgroundPanelNative.SetSwapChain](/windows/desktop/api/windows.ui.xaml.media.dxinterop/nf-windows-ui-xaml-media-dxinterop-iswapchainbackgroundpanelnative-setswapchain) on that reference to associate your implemented swap chain with the SwapChainBackgroundPanel instance.

It's common to put the code that queries the interface and sets the swap chain as part of a **Create*Resources** method. The **Create*Resources** methods are an implementation pattern that's seen in the Microsoft DirectX  **Renderer** class templates/examples.

The API that enables you to add a **SwapChain** to an existing [SwapChainBackgroundPanel](swapchainpanel.md) is not a runtime class API, it is a Microsoft DirectX  API. You implement the swap chain input as a Microsoft DirectX interface ([IDXGISwapChain](/windows/desktop/api/dxgi/nn-dxgi-idxgiswapchain)).

### Composition limitations

+ A SwapChainBackgroundPanel element can only appear as the root element of a XAML element tree, or cannot have a parent element if the object tree is established through code.
+ The SwapChainBackgroundPanel exists as a discrete layout element mainly so that you can satisfy some of the existing restrictions on Microsoft DirectX  **SwapChain** integration within a Windows  UI. In particular, there can only be one **SwapChain** per window, and the visuals in that overlay appear last in any possible z-order displayed in the window.
+ Although SwapChainBackgroundPanel is a [UIElement](../windows.ui.xaml/uielement.md) derived class, projection and transformation API have no effect upon its rendering presentation.
+ Some of the non-layout properties that are inherited from [Grid](grid.md) or from base classes such as [FrameworkElement](../windows.ui.xaml/frameworkelement.md) have no effect when set on a SwapChainBackgroundPanel. This is because it is the Microsoft DirectX  **SwapChain** that should have the greater influence over what appears within the panel.


## -examples

## -see-also
[Grid](grid.md), [SwapChainPanel](swapchainpanel.md), [DirectX and XAML interop](/previous-versions/windows/apps/hh825871(v=win.10))
