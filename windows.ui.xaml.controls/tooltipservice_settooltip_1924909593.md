---
-api-id: M:Windows.UI.Xaml.Controls.ToolTipService.SetToolTip(Windows.UI.Xaml.DependencyObject,System.Object)
-api-type: winrt method
---

<!-- Method syntax
public void SetToolTip(Windows.UI.Xaml.DependencyObject element, System.Object value)
-->

# Windows.UI.Xaml.Controls.ToolTipService.SetToolTip

## -description
Sets the value of the [ToolTipService.ToolTip](/uwp/api/windows.ui.xaml.controls.tooltipservice#xaml-attached-properties) XAML attached property.

Equivalent WinUI method: [Microsoft.UI.Xaml.Controls.ToolTipService.SetToolTip](/windows/winui/api/microsoft.ui.xaml.controls.tooltipservice.settooltip).

## -parameters
### -param element
The object to set tooltip content on.

### -param value
The value to set for tooltip content.

## -remarks
A [ToolTip](tooltip.md) must be assigned to another UI element that is its owner. In Extensible Application Markup Language (XAML), use the [ToolTipService.Tooltip](/uwp/api/windows.ui.xaml.controls.tooltipservice#xaml-attached-properties) attached property to assign the [ToolTip](tooltip.md) to an owner. In code, use the ToolTipService.SetToolTip method to assign the [ToolTip](tooltip.md) to an owner.

See [ToolTipService.ToolTip](/uwp/api/windows.ui.xaml.controls.tooltipservice#xaml-attached-properties) or [ToolTip](tooltip.md) to learn more about the object content or text that is appropriate to use as tooltip content.

## -examples

## -see-also
