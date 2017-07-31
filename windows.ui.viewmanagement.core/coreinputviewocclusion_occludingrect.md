---
-api-id: P:Windows.UI.ViewManagement.Core.CoreInputViewOcclusion.OccludingRect
-api-type: winrt property
---

<!-- Property syntax.
public Rect OccludingRect { get; }
-->

# Windows.UI.ViewManagement.Core.CoreInputViewOcclusion.OccludingRect

## -description
Gets the bounding rect of the occluding input pane (and associated UI).

## -property-value
The rectangle, in client coordinates, representing the region of the app window hidden behind the pane. Specified in device-independent pixel (DIP).

A *top* value of "0" indicates that the app window is not obstructed by the pane. The pane might still be visible.

A *height* value of "0", and *width* value equal to the width of the pane, indicates that the pane is floating, but not obstructing the app window.

## -remarks

## -examples

## -see-also
