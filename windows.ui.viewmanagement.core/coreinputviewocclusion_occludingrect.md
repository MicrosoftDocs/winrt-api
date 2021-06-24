---
-api-id: P:Windows.UI.ViewManagement.Core.CoreInputViewOcclusion.OccludingRect
-api-type: winrt property
---

<!-- Property syntax.
public Rect OccludingRect { get; }
-->

# Windows.UI.ViewManagement.Core.CoreInputViewOcclusion.OccludingRect

## -description

Gets the bounding rect of the occluding input pane.

## -property-value

The rectangle formed by the intersection of the input pane and the application window (the region of the app window hidden behind the pane). Specified in device-independent pixels (DIP).

If [Rect.Y](/uwp/api/windows.foundation.rect.y) has value of 0, the app window is not obstructed by the pane (the pane might still be visible).

## -remarks

## -examples

## -see-also
