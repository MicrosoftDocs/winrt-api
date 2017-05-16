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
> [SwapChainBackgroundPanel](swapchainbackgroundpanel.md) may be altered or unavailable for releases after Windows 8.1 Instead, use [SwapChainPanel](swapchainpanel.md).

## -xaml-syntax

```xaml
<SwapChainBackgroundPanel .../>
```

## -remarks

> [!IMPORTANT]
> [SwapChainBackgroundPanel](swapchainbackgroundpanel.md) is deprecated and may not be supported in future releases. Change any existing code that used [SwapChainBackgroundPanel](swapchainbackgroundpanel.md) to use [SwapChainPanel](swapchainpanel.md) instead. There's no downside to using [SwapChainPanel](swapchainpanel.md), the API is new because it relies upon an upgrade in the internal rendering and composition systems that were introduced starting with Windows 8.1.

For most scenarios a [SwapChainPanel](swapchainpanel.md) will provide a more versatile Microsoft DirectX interop render surface than a [SwapChainBackgroundPanel](swapchainbackgroundpanel.md) does. That's because a [SwapChainPanel](swapchainpanel.md) doesn't have many of the XAML-side composition limitations that are listed in the "Composition limitations" section below. For example you can apply a [RenderTransform](../windows.ui.xaml/uielement_rendertransform.md) to a [SwapChainPanel](swapchainpanel.md). For more info, see [DirectX and XAML interop](http://msdn.microsoft.com/library/17987eea-6771-423c-9b68-6b9aeadc7b7f) and [SwapChainPanel](swapchainpanel.md).

A [SwapChainBackgroundPanel](swapchainbackgroundpanel.md) is a [Grid](grid.md) subclass, so you can use [ColumnDefinitions](grid_columndefinitions.md) and [RowDefinitions](grid_rowdefinitions.md) properties to declare the panel's characteristics, and the attached properties of [Grid](grid.md) such as [Grid.Row](grid_row.md) and [Grid.Column](grid_column.md) on child elements to position those child elements in the layout.

For more info on how to use [SwapChainBackgroundPanel](swapchainbackgroundpanel.md), including sample code, see [DirectX and XAML interop](http://msdn.microsoft.com/library/17987eea-6771-423c-9b68-6b9aeadc7b7f).

The [SwapChainBackgroundPanel](swapchainbackgroundpanel.md) class does not inherit from the [Control](control.md) class, and you cannot force focus to this element. Events that rely on having focus, such as **KeyUp** and **KeyDown**, may have no effect.

### Initializing a **SwapChainPanel** element

Before a [SwapChainBackgroundPanel](swapchainpanel.md) can render content, you must initialize it from the Microsoft DirectX side.

Cast the [SwapChainBackgroundPanel](swapchainbackgroundpanel.md) instance to [IInspectable](http://msdn.microsoft.com/library/0657e51f-d4c0-46c6-927d-b01e54b6846c) or [IUnknown](http://msdn.microsoft.com/library/33f1d79a-33fc-4ce5-a372-e08bda378332), then call [QueryInterface](http://msdn.microsoft.com/library/54d5ff80-18db-43f2-b636-f93ac053146d) to obtain a reference to the [ISwapChainBackgroundPanelNative](http://msdn.microsoft.com/library/77f5eb53-0df9-4ba7-810c-9b7b073e76a7) interface (this is the native interface implementation that is the complement to the [SwapChainBackgroundPanel](swapchainbackgroundpanel.md) and enables the interop bridge). Then, call [ISwapChainBackgroundPanelNative::SetSwapChain](http://msdn.microsoft.com/library/edaea67f-78cd-49f8-84fc-a7037629239a) on that reference to associate your implemented swap chain with the [SwapChainBackgroundPanel](swapchainbackgroundpanel.md) instance.

It's common to put the code that queries the interface and sets the swap chain as part of a **Create*Resources** method. The **Create*Resources** methods are an implementation pattern that's seen in the Microsoft DirectX  **Renderer** class templates/examples.

The API that enables you to add a **SwapChain** to an existing [SwapChainBackgroundPanel](swapchainpanel.md) is not a runtime class API, it is a Microsoft DirectX  API. You implement the swap chain input as a Microsoft DirectX interface ([IDXGISwapChain](http://msdn.microsoft.com/library/344ada45-35a0-4e99-b3b7-0f316df029ab)).

### Composition limitations

+ A [SwapChainBackgroundPanel](swapchainbackgroundpanel.md) element can only appear as the root element of a XAML element tree, or cannot have a parent element if the object tree is established through code.
+ The [SwapChainBackgroundPanel](swapchainbackgroundpanel.md) exists as a discrete layout element mainly so that you can satisfy some of the existing restrictions on Microsoft DirectX  **SwapChain** integration within a Windows  UI. In particular, there can only be one **SwapChain** per window, and the visuals in that overlay appear last in any possible z-order displayed in the window.
+ Although [SwapChainBackgroundPanel](swapchainbackgroundpanel.md) is a [UIElement](../windows.ui.xaml/uielement.md) derived class, projection and transformation API have no effect upon its rendering presentation.
+ Some of the non-layout properties that are inherited from [Grid](grid.md) or from base classes such as [FrameworkElement](../windows.ui.xaml/frameworkelement.md) have no effect when set on a [SwapChainBackgroundPanel](swapchainbackgroundpanel.md). This is because it is the Microsoft DirectX  **SwapChain** that should have the greater influence over what appears within the panel.


## -examples

## -see-also
[Grid](grid.md), [SwapChainPanel](swapchainpanel.md), [DirectX and XAML interop](http://msdn.microsoft.com/library/17987eea-6771-423c-9b68-6b9aeadc7b7f)