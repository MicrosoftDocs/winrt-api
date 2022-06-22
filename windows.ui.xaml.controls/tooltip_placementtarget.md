---
-api-id: P:Windows.UI.Xaml.Controls.ToolTip.PlacementTarget
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.UIElement PlacementTarget { get;  set; }
-->

# Windows.UI.Xaml.Controls.ToolTip.PlacementTarget

## -description
Gets or sets the visual element or control that the tool tip should be positioned in relation to when opened by the [ToolTipService](tooltipservice.md).



## -xaml-syntax
```xaml
<ToolTip PlacementTarget="{Binding ElementName=placementTargetName}"/>
```


## -xaml-values
<dl><dt>placementTargetName</dt><dd>placementTargetNameThe Name or x:Name attribute of the element that serves as the placement target. This syntax assumes that the working data context contains the named element. For more information, see ElementName.</dd>
</dl>
## -property-value
The visual element or control that the tool tip is positioned in relation to when opened by the [ToolTipService](tooltipservice.md). The default is **null**.

## -remarks
If there is no explicit PlacementTarget, the placement target for a [ToolTip](tooltip.md) is the element that specifies the [ToolTip](slider_isthumbtooltipenabled.md) as the value for its [TooltipService.ToolTip](/uwp/api/windows.ui.xaml.controls.tooltipservice.tooltip) attached property value, and any [Placement](tooltip_placement.md) value applies to that target. The placement target determination is based on visual tree composition, and whether to display a tooltip at all is parallel to the target's hit test characteristics. A [Control](control.md) instance where [IsEnabled](control_isenabled.md) is false will not display a [ToolTip](tooltip.md).

[Placement](tooltip_placement.md) and PlacementTarget are usually left as the defaults. The scenario for specifying either or both of these properties is if you are trying to avoid a case where the tooltip obscures the content it is referring to while the tooltip is displayed.

## -examples

## -see-also
[Placement](tooltip_placement.md), [PlacementMode](../windows.ui.xaml.controls.primitives/placementmode.md)
