---
-api-id: P:Windows.UI.Xaml.UIElement.CompositeMode
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.ElementCompositeMode CompositeMode { get;  set; }
-->

# Windows.UI.Xaml.UIElement.CompositeMode

## -description
Gets or sets a property that declares alternate composition and blending modes for the element in its parent layout and window. This is relevant for elements that are involved in a mixed XAML / Microsoft DirectX UI.



## -xaml-syntax
```xaml
<uiElement CompositeMode="elementCompositeModeMemberName" />
```


## -property-value
A value of the enumeration. The default is **Inherit**, but see Remarks.

## -remarks
If left unset, the default value of **CompositeMode** is **ElementCompositeMode.Inherits**. This means that the composite mode inherits from successive parents in the visual tree. However, at the root of a XAML visual tree is a final object representing the **hWnd** that is not typically represented in user code, and its effective **CompositeMode** behavior is **SourceOver**. Therefore, unless some element in the chain is specifically set to **MinBlend**, the render behavior of XAML elements all inherit to use **SourceOver** as inherited from the parent window.

Setting **CompositeMode** to **MinBlend** is useful for a mixed XAML / Microsoft DirectX UI because it is information used by the Direct Composition layer when it combines the UI sources. The **MinBlend** behavior can be better for situations such as text overlays.

Setting a value of **MinBlend** is typically most relevant for a [SwapChainPanel](../windows.ui.xaml.controls/swapchainbackgroundpanel.md) element, so that the hosted content gets this behavior. But for some scenarios such as text overlays it can also be set on specific UI elements such as [Rectangle](../windows.ui.xaml.shapes/rectangle.md), [Canvas](../windows.ui.xaml.controls/canvas.md) and so on.


## -examples

## -see-also
[SwapChainBackgroundPanel](../windows.ui.xaml.controls/swapchainbackgroundpanel.md), [DirectX and XAML interop](/previous-versions/windows/apps/hh825871(v=win.10))
