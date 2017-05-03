---
-api-id: P:Windows.UI.ViewManagement.InputPane.OccludedRect
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Rect OccludedRect { get; }
-->

# Windows.UI.ViewManagement.InputPane.OccludedRect

## -description
Gets the region of the app window obscured by the input pane.

## -property-value
The rectangle, in client coordinates, representing the region of the app window hidden behind the input pane. Specified in device-independent pixel (DIP).

A *top* value of "0" indicates that the app window is not obstructed by the input pane. The input pane might still be visible.

A *height* value of "0", and *width* value equal to the width of the input pane, indicates that the input pane is floating, but not obstructing the app window.

## -remarks
Universal apps should use this property, rather than [Visible](inputpane_visible.md).

> In some cases, overlay UI such as an [InputPane](inputpane.md) is not fully supported. This includes:+ [ apps](https://msdn.microsoft.com/en-us/windows/uwp/gaming/index) in full-screen mode.
+ Windows Holographic apps in [holographic view](https://developer.microsoft.com/en-us/windows/holographic/app_model#app_views).


## -examples

## -see-also
