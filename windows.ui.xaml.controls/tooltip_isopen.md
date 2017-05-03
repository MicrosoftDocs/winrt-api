---
-api-id: P:Windows.UI.Xaml.Controls.ToolTip.IsOpen
-api-type: winrt property
---

<!-- Property syntax
public bool IsOpen { get;  set; }
-->

# Windows.UI.Xaml.Controls.ToolTip.IsOpen

## -description
Gets or sets a value that indicates whether the [ToolTip](tooltip.md) is visible.

## -property-value
**true** if the [ToolTip](tooltip.md) is visible; otherwise, **false**. The default is **false**.

## -remarks
This property is not typically set in XAML.

A [ToolTip](tooltip.md) must be assigned to another UI element that is its owner. In XAML, use the [ToolTipService.Tooltip](tooltipservice_tooltip.md) attached property to assign the [ToolTip](tooltip.md) to an owner. In code, use the [ToolTipService.SetToolTip](tooltipservice_settooltip.md) method to assign the [ToolTip](tooltip.md) to an owner. If you set the [IsOpen](tooltip_isopen.md) property to **true** in your app code before the [ToolTip](tooltip.md) is assigned to an owner, an exception is thrown.

## -examples

## -see-also
[ToolTipService.Tooltip](tooltipservice_tooltip.md)