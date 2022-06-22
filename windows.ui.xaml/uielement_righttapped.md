---
-api-id: E:Windows.UI.Xaml.UIElement.RightTapped
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.Input.RightTappedEventHandler RightTapped
-->

# Windows.UI.Xaml.UIElement.RightTapped

## -description

Occurs when a right-tap input stimulus happens while the pointer is over the element.



## -xaml-syntax

```xaml
<uielement RightTapped = "eventhandler" .../>
```

## -remarks

RightTapped for a touch action results from processing an action that remains in one place for a certain amount of time. If it's a touch action, a [Holding](uielement_holding.md) event from the same element always precedes this, but RightTapped won't fire until the touch point is released. If the time the pointer is pressed is too short and [Tapped](uielement_tapped.md) fires instead of [Holding](uielement_holding.md), or if the **Hold** action ends with [HoldingState](../windows.ui.xaml.input/holdingroutedeventargs_holdingstate.md) as **Canceled**, RightTapped won't fire.

RightTapped is the event to handle for displaying context menus. See [Touch interaction design](https://msdn.microsoft.com/library/9ba7f613-e5d1-40d4-920b-143094209e3a) and [UX guidelines for custom user interactions](/windows/uwp/design/layout/index) for more info on how to use a right-tap interaction in your app design.

A RightTapped event represents a gesture, whereas a [PointerReleased](uielement_pointerreleased.md) event is a lower-level input event. RightTapped and [PointerReleased](uielement_pointerreleased.md) events can fire as the result of a single user interaction. Even if a control is already handling pointer events in the control logic, or is handling manipulations, that doesn't prevent RightTapped from firing.

A RightTapped event is potentially the result of more than one pointer point. For the higher-level gesture events like RightTapped you no longer have immediate access to [PointerPoint](../windows.ui.input/pointerpoint.md) details such as individual [PointerId](../windows.ui.input/pointerpoint_pointerid.md) values or individual coordinates. You do have access to device type ([PointerDeviceType](../windows.ui.xaml.input/righttappedroutedeventargs_pointerdevicetype.md)) and for coordinates you can call [GetPosition](../windows.ui.xaml.input/righttappedroutedeventargs_getposition_1813281865.md), which gives an average of the coordinates for a **RightTap** from more than one pointer point.

RightTapped is a routed event. Also, an element must have [IsRightTapEnabled](uielement_isrighttapenabled.md) be **true** to be a RightTapped event source (**true** is the default). It is possible to handle RightTapped on parent elements even if [IsRightTapEnabled](uielement_isrighttapenabled.md) is **false** on the parent element, if the event bubbles to a parent from an event source child element where [IsRightTapEnabled](uielement_isrighttapenabled.md) is **false**. For more info on the routed event concept, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

For touch actions and also for interaction-specific or manipulation events that are consequences of a touch action, an element must be hit-test visible in order to be the event source and fire the event that is associated with the action. [UIElement.Visibility](uielement_visibility.md) must be [Visible](visibility.md). Other properties of derived types also affect hit-test visibility. For more info, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

RightTapped supports the ability to attach event handlers to the route that will be invoked even if the event data for the event is marked [Handled](../windows.ui.xaml.input/righttappedroutedeventargs_handled.md). See [AddHandler](uielement_addhandler_2121467075.md).

Specific Windows Runtime controls may have class-based handling for the RightTapped event. If so, the control probably has an override for the method [OnRightTapped](../windows.ui.xaml.controls/control_onrighttapped_206844945.md). A right-tap action might be associated with displaying a context menu or secondary window. For more info on how class-based handling for events works, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

### RightTapped for mouse and pen/stylus input

The input system processes an action where the user clicks the right mouse button while over the element as a RightTapped action. The event doesn't fire until the right mouse button is released. Mouse input doesn't produce [Holding](uielement_holding.md) events by default, no matter how long a mouse button is held down, or which button is held.

Some pen devices have multiple buttons, one of which can be used the same way that the right button on a mouse device is used. This depends on the device and its settings, but if a right-click equivalent is enabled by the pen device, the input system can fire RightTapped for these actions also.

### Windows 8 behavior

Windows 8 had an issue with the data for the RightTapped event, where the **X** and **Y** values for the point you'd get from [RightTappedRoutedEventArgs.GetPosition](../windows.ui.xaml.input/righttappedroutedeventargs_getposition_1813281865.md) were reversed (**X** was really **Y**; **Y** was really **X**). This issue has been fixed starting with Windows 8.1. But if you're retargeting a Windows 8 app for Windows 8.1, you might have had code that worked around this issue by swapping the **X** and **Y** back. If so, remove that code when you retarget because the issue is now fixed.

Apps that were compiled for Windows 8 but running on Windows 8.1 continue to use this Windows 8 behavior.

Also, Windows 8 didn't include default key handling for Shift+F10 that would fire this event and then display context menus. Shift+F10 is typically a secondary key combination for the VK_APP virtual key value (the Properties key), and thus Shift+F10 might be expected to fire RightTapped too. This issue has been fixed starting with Windows 8.1; Shift+F10 now fires RightTapped. You can see this change as default event handling on some controls that have default context menus for text, such as [TextBox](../windows.ui.xaml.controls/textbox.md), or when invoking custom menus and flyouts.

Apps that were compiled for Windows 8 but running on Windows 8.1 do not use this Windows 8 behavior, they use the corrected Windows 8.1 behavior.

## -examples

## -see-also

[RightTappedRoutedEventArgs](../windows.ui.xaml.input/righttappedroutedeventargs.md), [IsRightTapEnabled](uielement_isrighttapenabled.md), [PopupMenu](../windows.ui.popups/popupmenu.md), [Handle pointer input](/windows/uwp/design/input/handle-pointer-input), [XAML user input events sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Input%20XAML%20user%20input%20events%20sample), [Context  menu sample](https://code.msdn.microsoft.com/windowsapps/Context-menu-sample-40840351/view/SourceCode)
