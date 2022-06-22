---
-api-id: M:Windows.UI.Xaml.Controls.ToolTipService.SetPlacementTarget(Windows.UI.Xaml.DependencyObject,Windows.UI.Xaml.UIElement)
-api-type: winrt method
---

<!-- Method syntax
public void SetPlacementTarget(Windows.UI.Xaml.DependencyObject element, Windows.UI.Xaml.UIElement value)
-->

# Windows.UI.Xaml.Controls.ToolTipService.SetPlacementTarget

## -description
Sets the [ToolTipService.PlacementTarget](tooltipservice_placementtarget.md) XAML attached property value for the specified target element.



## -parameters
### -param element
The target element for the attached property value.

### -param value
The visual element that should be the placement target for the tooltip.

## -remarks
This method supports the [ToolTipService.PlacementTarget](tooltipservice_placementtarget.md) attached property usage for Extensible Application Markup Language (XAML). The value for *element* is not necessarily a [ToolTip](tooltip.md), it might be an element that owns an inferred tooltip through usage of [ToolTipService](tooltipservice.md) APIs. You can use the [ToolTipService.PlacementTarget](tooltipservice_placementtarget.md) attached property to set the placement target to be different than the element that owns the [ToolTip](tooltip.md) for purposes of UI behavior and built-in [PointerEntered](../windows.ui.xaml/uielement_pointerentered.md) / [PointerExited](../windows.ui.xaml/uielement_pointerexited.md) handling. This enables controls to act like a unit for tooltip display, so that the tooltip from one control does not obscure an important part of a related control when it displays.

## -examples

## -see-also

[ToolTipService.PlacementTarget](tooltipservice_placementtarget.md), [Attached properties overview](/windows/uwp/xaml-platform/attached-properties-overview)
