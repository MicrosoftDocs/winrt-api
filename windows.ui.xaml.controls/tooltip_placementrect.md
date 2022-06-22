---
-api-id: P:Windows.UI.Xaml.Controls.ToolTip.PlacementRect
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public Rect PlacementRect { get;  set; }
-->

# Windows.UI.Xaml.Controls.ToolTip.PlacementRect

## -description
Gets or sets the rectangular area that the tooltip should be positioned in relation to when opened by the [ToolTipService](tooltipservice.md). If space allows, the open tooltip will not occlude the area defined by its PlacementRect. 



## -property-value
The rectangular area that the tooltip is positioned in relation to when opened by the [ToolTipService](tooltipservice.md). The default is **null**.

## -remarks
PlacementRect anchors the tooltip's position and also serves as an area that the opened tooltip will not occlude, provided there's sufficient space to draw tooltip outside this area. You can specify the origin of the rectangle relative to the tooltip's owner, and the height and width of the exclusion area. The [Placement](tooltip_placement.md) property will define if tooltip should draw above, below, left, or right of the PlacementRect.

## -see-also
[PlacementTarget](tooltip_placementtarget.md), [Placement](tooltip_placement.md)

## -examples

