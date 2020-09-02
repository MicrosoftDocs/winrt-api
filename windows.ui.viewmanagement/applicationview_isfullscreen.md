---
-api-id: P:Windows.UI.ViewManagement.ApplicationView.IsFullScreen
-api-type: winrt property
---

<!-- Property syntax
public bool IsFullScreen { get; }
-->

# Windows.UI.ViewManagement.ApplicationView.IsFullScreen

## -description
> [!NOTE]
> IsFullScreen may be altered or unavailable for releases after Windows 10. Instead, use [IsFullScreenMode](applicationview_isfullscreenmode.md).

Gets a value that indicates whether the window touches both the left and right sides of the display.

## -property-value
**true** if the window touches both the left and right sides of the display; otherwise, **false**.

## -remarks
The system raises the [CoreWindow.SizeChanged](../windows.ui.core/corewindow_sizechanged.md) event when the value of this property changes. This is exposed to XAML apps as the [Window.SizeChanged](../windows.ui.xaml/window_sizechanged.md) event and to HTML apps as the [window.resize](/previous-versions/windows/internet-explorer/ie-developer/platform-apis/aa741886(v=vs.85)) event.

The property is a nonstatic member of the window object. For JavaScript, this means that it is a property of the window object that [getForCurrentView](applicationview_getforcurrentview_1363600702.md) creates, not of the [ApplicationView](applicationview.md) class.

> **Windows 10**
> In Windows 10, apps run in resizable windows and this property is deprecated. To check if the app is full screen, use the [IsFullScreenMode](applicationview_isfullscreenmode.md) property. To check if the app is close to the edges of the display, use the [AdjacentToLeftDisplayEdge](applicationview_adjacenttoleftdisplayedge.md) and [AdjacentToRightDisplayEdge](applicationview_adjacenttorightdisplayedge.md) properties.

> **Windows 8**
> In Windows 8, apps always use the full height of the screen, so this property returns **true** if the app touches both sides of the display.

## -examples

## -see-also
