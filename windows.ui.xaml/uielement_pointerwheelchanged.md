---
-api-id: E:Windows.UI.Xaml.UIElement.PointerWheelChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.Input.PointerEventHandler PointerWheelChanged
-->

# Windows.UI.Xaml.UIElement.PointerWheelChanged

## -description

Occurs when the delta value of a pointer wheel changes.



## -xaml-syntax

```xaml
<uielement PointerWheelChanged = "eventhandler" .../>
```

## -remarks

When you handle PointerWheelChanged, you are usually interested in the [MouseWheelDelta](../windows.ui.input/pointerpointproperties_mousewheeldelta.md) property value:

1. Call [GetCurrentPoint](../windows.ui.xaml.input/pointerroutedeventargs_getcurrentpoint_1761708789.md) from the [PointerRoutedEventArgs](../windows.ui.xaml.input/pointerroutedeventargs.md) available to your handler. This returns a [PointerPoint](../windows.ui.input/pointerpoint.md).
1. Get the [Properties](../windows.ui.input/pointerpoint_properties.md) of the [PointerPoint](../windows.ui.input/pointerpoint.md). It contains a [PointerPointProperties](../windows.ui.input/pointerpointproperties.md) object.
1. Get the [MouseWheelDelta](../windows.ui.input/pointerpointproperties_mousewheeldelta.md) property value from the [PointerPointProperties](../windows.ui.input/pointerpointproperties.md) object. A positive value indicates that the wheel was rotated forward (away from the user) or tilted to the right; a negative value indicates that the wheel was rotated backward (toward the user) or tilted to the left.

If the element where pointer events occur has a non-default [ManipulationMode](uielement_manipulationmode.md) value, then the action might also result in various manipulation events like [ManipulationStarted](uielement_manipulationstarted.md). In addition, mouse wheel input can be handled as a built-in manipulation behavior by controls, even with no [ManipulationMode](uielement_manipulationmode.md) value set. For example, certain controls like [GridView](../windows.ui.xaml.controls/gridview.md) and [ListView](../windows.ui.xaml.controls/listview.md) can process mouse wheel input to initiate a scroll/pan action.

PointerWheelChanged is a routed event. For more info on the routed event concept, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

For touch actions and also for interaction-specific or manipulation events that are consequences of a touch action, an element must be hit-test visible in order to be the event source and fire the event that is associated with the action. [UIElement.Visibility](uielement_visibility.md) must be [Visible](visibility.md). Other properties of derived types also affect hit-test visibility. For more info, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

PointerWheelChanged supports the ability to attach event handlers to the route that will be invoked even if the event data for the event is marked [Handled](../windows.ui.xaml.input/pointerroutedeventargs_handled.md). See [AddHandler](uielement_addhandler_2121467075.md).

Specific Windows Runtime controls may have class-based handling for the PointerWheelChanged input event. If so, the control probably has an override for the method [OnPointerWheelChanged](../windows.ui.xaml.controls/control_onpointerwheelchanged_1180757497.md). Typically the event is marked handled by the class handler, and the PointerWheelChanged event is not raised for handling by any user code handlers on that control. A control might do this in order to support traversal of its child elements by using a pointer wheel action. For more info on how class-based handling for events works, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

### Windows 8 behavior

For Windows 8, track pad device gestures that were input-handled by a [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md) control part were interpreted as mouse wheel input, and thus would fire a PointerWheelChanged event. Starting with Windows 8.1, [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md) uses an underlying manipulation logic that interprets track pad gestures as actions that the [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md) responds to, and thus the gesture is considered handled by the control and the PointerWheelChanged event is not fired anymore.

If you migrate your app code from Windows 8 to Windows 8.1 you may want to account for this behavior change, because it results in PointerWheelChanged being fired in fewer cases. Also, the behavior that's now built-in to [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md) may be duplicating what your handler would have done.

Apps that were compiled for Windows 8 but running on Windows 8.1 continue to use the Windows 8 behavior.

## -examples

## -see-also

[PointerRoutedEventArgs](../windows.ui.xaml.input/pointerroutedeventargs.md), [Handle pointer input](/windows/uwp/design/input/handle-pointer-input), [Relative mouse movement and CoreWindow](/windows/uwp/gaming/relative-mouse-movement)
