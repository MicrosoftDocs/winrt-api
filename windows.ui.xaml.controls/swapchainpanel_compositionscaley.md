---
-api-id: P:Windows.UI.Xaml.Controls.SwapChainPanel.CompositionScaleY
-api-type: winrt property
---

<!-- Property syntax
public float CompositionScaleY { get; }
-->

# Windows.UI.Xaml.Controls.SwapChainPanel.CompositionScaleY

## -description
Gets the y-axis scale factor of the [SwapChainPanel](swapchainpanel.md).



## -property-value
The y-axis scale factor of the [SwapChainPanel](swapchainpanel.md). A value of 1.0 means no scaling is applied.

## -remarks
The CompositionScaleY scale factor is applied to the swap chain content when it's rendered to the screen and composited into the XAML content. The scale factor is derived from calculating the render transformations (implicit or explicit) applied to the [SwapChainPanel](swapchainpanel.md) and its ancestors.

The scale factor will be an estimate if a [Projection](../windows.ui.xaml/uielement_projection.md) property value is present on the [SwapChainPanel](swapchainpanel.md) or one of its ancestors.

Check this property any time you are handling [CompositionScaleChanged](swapchainpanel_compositionscalechanged.md) ([CompositionScaleChanged](swapchainpanel_compositionscalechanged.md) doesn't have event data, but if it fires it means that [CompositionScaleX](swapchainpanel_compositionscalex.md), CompositionScaleY, or both have changed values on this [SwapChainPanel](swapchainpanel.md)).

## -examples

## -see-also
[CompositionScaleChanged](swapchainpanel_compositionscalechanged.md)
