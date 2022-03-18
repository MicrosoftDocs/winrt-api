---
-api-id: P:Windows.UI.ViewManagement.ApplicationView.AdjacentToRightDisplayEdge
-api-type: winrt property
---

<!-- Property syntax
public bool AdjacentToRightDisplayEdge { get; }
-->

# Windows.UI.ViewManagement.ApplicationView.AdjacentToRightDisplayEdge

## -description
Gets a value that indicates whether the current window is in close proximity to the right edge of the screen.

## -property-value
**true** if the current window is in close proximity to the right edge of the screen; otherwise, **false**.

## -remarks
The system raises the [CoreWindow.SizeChanged](../windows.ui.core/corewindow_sizechanged.md) event when the value of this property changes. This is exposed to XAML apps as the [Window.SizeChanged](../windows.ui.xaml/window_sizechanged.md) event and to HTML apps as the [window.resize](/previous-versions/windows/internet-explorer/ie-developer/platform-apis/aa741886(v=vs.85)) event.

The property is a nonstatic member of the window object. For JavaScript, this means that it is a method of the window object that [getForCurrentView](applicationview_getforcurrentview_1363600702.md) creates, not of the [ApplicationView](applicationview.md) class.

## -examples

## -see-also
