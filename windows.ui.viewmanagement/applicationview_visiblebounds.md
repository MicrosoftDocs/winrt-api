---
-api-id: P:Windows.UI.ViewManagement.ApplicationView.VisibleBounds
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Rect VisibleBounds { get; }
-->

# Windows.UI.ViewManagement.ApplicationView.VisibleBounds

## -description
Gets the visible region of the window (app view). The visible region is the region not occluded by chrome such as the status bar and app bar.

## -property-value
The visible region of the window (app view).

## -remarks
Parts of a window (app view) can be covered up (occluded) by chrome, such as the status bar and the app bar. The non-occluded region is referred to as the visible bounds. Note that, when shown, the status bar and app bar occlude the window even if their opacity is not 100%.

## -examples

## -see-also
