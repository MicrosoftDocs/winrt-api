---
-api-id: E:Windows.UI.Core.CoreWindow.SizeChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler SizeChanged<Windows.UI.Core.CoreWindow,  Windows.UI.Core.WindowSizeChangedEventArgs>
-->

# Windows.UI.Core.CoreWindow.SizeChanged

## -description
Occurs when the window size is changed.

## -remarks
The SizeChanged event is exposed to XAML apps as the [Window.SizeChanged](../windows.ui.xaml/window_sizechanged.md) event and to HTML apps as the [window.resize](/previous-versions/windows/internet-explorer/ie-developer/platform-apis/aa741886(v=vs.85)) event.

This event occurs when the window size changes or when one of the following properties changes:


+ [ApplicationView.AdjacentToLeftDisplayEdge](../windows.ui.viewmanagement/applicationview_adjacenttoleftdisplayedge.md)
+ [ApplicationView.AdjacentToRightDisplayEdge](../windows.ui.viewmanagement/applicationview_adjacenttorightdisplayedge.md)
+ [ApplicationView.IsFullScreen](../windows.ui.viewmanagement/applicationview_isfullscreen.md)
+ [ApplicationView.IsFullScreenMode](../windows.ui.viewmanagement/applicationview_isfullscreenmode.md)
+ [UIViewSettings.UserInteractionMode](../windows.ui.viewmanagement/uiviewsettings_userinteractionmode.md)
You can use this event to listen for changes to the size or position of the current window.

## -examples

## -see-also
