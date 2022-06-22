---
-api-id: M:Windows.UI.Xaml.Controls.ToolTipService.SetPlacement(Windows.UI.Xaml.DependencyObject,Windows.UI.Xaml.Controls.Primitives.PlacementMode)
-api-type: winrt method
---

<!-- Method syntax
public void SetPlacement(Windows.UI.Xaml.DependencyObject element, Windows.UI.Xaml.Controls.Primitives.PlacementMode value)
-->

# Windows.UI.Xaml.Controls.ToolTipService.SetPlacement

## -description
Sets the [ToolTipService.Placement](tooltipservice_placement.md) XAML attached property value for the specified target element.



## -parameters
### -param element
The target element for the attached property value.

### -param value
One of the [PlacementMode](../windows.ui.xaml.controls.primitives/placementmode.md) values, which specifies where the tooltip should appear relative to the control that is the placement target.

## -remarks
This method supports the [ToolTipService.Placement](tooltipservice_placement.md) attached property usage for Extensible Application Markup Language (XAML). The target element is not necessarily a [ToolTip](tooltip.md), it might be an element that owns an inferred tooltip through usage of [ToolTipService](tooltipservice.md) APIs. Also, the target element is not necessarily the final placement target, because that can be reset by setting the [ToolTipService.PlacementTarget](tooltipservice_placement.md) attached property.

## -examples

## -see-also

[ToolTipService.Placement](tooltipservice_placement.md), [Attached properties overview](/windows/uwp/xaml-platform/attached-properties-overview)
