---
-api-id: P:Windows.UI.Composition.Visual.RelativeSizeAdjustment
-api-type: winrt property
---

<!-- Property syntax.
public Vector2 RelativeSizeAdjustment { get;  set; }
-->

# Windows.UI.Composition.Visual.RelativeSizeAdjustment

## -description

Gets or sets the size of the visual with respect to the size of its parent visual.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Composition.Visual.RelativeSizeAdjustment](/windows/winui/api/microsoft.ui.composition.visual.relativesizeadjustment) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

The size of the visual with respect to the size of its parent visual.

## -remarks

The value is normalized with respect to the size of the visual's parent. For example, a value of (1.0, 0.5) indicates that the visual should be the full width of its parent but only half the height.

The effective size of a `Visual` is found by adding its [Size](visual_size.md) to its `RelativeSizeAdjustment` combined with the effective size of the [Parent](visual_parent.md) `Visual`:

`var Effective_Size = Size + (RelativeSizeAdjustment * Parent.Effective_Size)`.

## -see-also

## -examples
