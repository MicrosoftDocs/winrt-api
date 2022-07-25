---
-api-id: M:Windows.UI.Xaml.Controls.Control.OnPointerWheelChanged(Windows.UI.Xaml.Input.PointerRoutedEventArgs)
-api-type: winrt method
---

<!-- Method syntax
virtual protected void OnPointerWheelChanged(Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
-->

# Windows.UI.Xaml.Controls.Control.OnPointerWheelChanged

## -description
Called before the [PointerWheelChanged](../windows.ui.xaml/uielement_pointerwheelchanged.md) event occurs.



## -parameters
### -param e
Event data for the event.

## -remarks
<!--The following remark is relevant for Windows 8 > 8.1 migration. See WBB 462116-->
### Windows 8 behavior

For Windows 8, track pad device gestures that were input-handled by a [ScrollViewer](scrollviewer.md) control part were interpreted as mouse wheel input, and thus would fire a [PointerWheelChanged](../windows.ui.xaml/uielement_pointerwheelchanged.md) event. Starting with Windows 8.1, [ScrollViewer](scrollviewer.md) uses an underlying manipulation logic that interprets track pad gestures as actions that the [ScrollViewer](scrollviewer.md) responds to, and thus the gesture is considered handled by the control and the [PointerWheelChanged](../windows.ui.xaml/uielement_pointerwheelchanged.md) event is not fired anymore.

If you migrate your app code from Windows 8 to Windows 8.1 you may want to account for this behavior change, because it results in [PointerWheelChanged](../windows.ui.xaml/uielement_pointerwheelchanged.md) being fired in fewer cases. Also, the behavior that's now built-in to [ScrollViewer](scrollviewer.md) may be duplicating what your handler would have done.

Apps that were compiled for Windows 8 but running on Windows 8.1 continue to use the Windows 8 behavior.

## -examples

## -see-also
[PointerRoutedEventArgs](../windows.ui.xaml.input/pointerroutedeventargs.md), [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview), [Custom user interactions](/windows/uwp/design/layout/index), [Handle pointer input](/windows/uwp/input-and-devices/handle-pointer-input)
