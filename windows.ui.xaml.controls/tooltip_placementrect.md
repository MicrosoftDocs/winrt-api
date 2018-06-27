---
-api-id: P:Windows.UI.Xaml.Controls.ToolTip.PlacementRect
-api-type: winrt property
---

<!-- Property syntax.
public Rect PlacementRect { get;  set; }
-->

# Windows.UI.Xaml.Controls.ToolTip.PlacementRect

## -description
Gets or sets the rectangular area that the tool tip should be positioned in relation to when opened by the [ToolTipService](tooltipservice.md). If space allows, the open tool tip will not occlude the area defined by its PlacementRect. 

## -property-value
The rectangular area that the tool tip is positioned in relation to when opened by the [ToolTipService](tooltipservice.md). The default is **null**.

## -remarks
PlacementRect anchors the tool tip's position and also serves as an area that the opened tool tip will not occlude, provided there's sufficient space to draw tool tip outside this area. You can specify the origin of the rectangle relative to the tool tip's owner, and the height and width of the exclusion area. The [Placement](tooltip_placement.md) property will define if tool tip should draw above, below, left, or right of the PlacementRect.

## -see-also
[PlacementTarget](tooltip_placementtarget.md), [Placement](tooltip_placement.md)

## -examples

