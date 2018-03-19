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
[RightTapped](uielement_righttapped.md) for a touch action results from processing an action that remains in one place for a certain amount of time. If it's a touch action, a [Holding](uielement_holding.md) event from the same element always precedes this, but [RightTapped](uielement_righttapped.md) won't fire until the touch point is released. If the time the pointer is pressed is too short and [Tapped](uielement_tapped.md) fires instead of [Holding](uielement_holding.md), or if the **Hold** action ends with [HoldingState](../windows.ui.xaml.input/holdingroutedeventargs_holdingstate.md) as **Canceled**, [RightTapped](uielement_righttapped.md) won't fire.

[RightTapped](uielement_righttapped.md) is the event to handle for displaying context menus. See [Touch interaction design](http://msdn.microsoft.com/library/9ba7f613-e5d1-40d4-920b-143094209e3a) and [UX guidelines for custom user interactions](http://msdn.microsoft.com/library/52f9607d-e2d0-44e4-9e1c-f856f7072a1e) for more info on how to use a right-tap interaction in your app design.

A [RightTapped](uielement_righttapped.md) event represents a gesture, whereas a [PointerReleased](uielement_pointerreleased.md) event is a lower-level input event. [RightTapped](uielement_righttapped.md) and [PointerReleased](uielement_pointerreleased.md) events can fire as the result of a single user interaction. Even if a control is already handling pointer events in the control logic, or is handling manipulations, that doesn't prevent [RightTapped](uielement_righttapped.md) from firing.

A [RightTapped](uielement_righttapped.md) event is potentially the result of more than one pointer point. For the higher-level gesture events like [RightTapped](uielement_righttapped.md) you no longer have immediate access to [PointerPoint](../windows.ui.input/pointerpoint.md) details such as individual [PointerId](../windows.ui.input/pointerpoint_pointerid.md) values or individual coordinates. You do have access to device type ([PointerDeviceType](../windows.ui.xaml.input/righttappedroutedeventargs_pointerdevicetype.md)) and for coordinates you can call [GetPosition](../windows.ui.xaml.input/righttappedroutedeventargs_getposition.md), which gives an average of the coordinates for a **RightTap** from more than one pointer point.

[RightTapped](uielement_righttapped.md) is a routed event. Also, an element must have [IsRightTapEnabled](uielement_isrighttapenabled.md) be **true** to be a [RightTapped](uielement_righttapped.md) event source (**true** is the default). It is possible to handle [RightTapped](uielement_righttapped.md) on parent elements even if [IsRightTapEnabled](uielement_isrighttapenabled.md) is **false** on the parent element, if the event bubbles to a parent from an event source child element where [IsRightTapEnabled](uielement_isrighttapenabled.md) is **false**. For more info on the routed event concept, see [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832).

For touch actions and also for interaction-specific or manipulation events that are consequences of a touch action, an element must be hit-test visible in order to be the event source and fire the event that is associated with the action. [UIElement.Visibility](uielement_visibility.md) must be [Visible](visibility.md). Other properties of derived types also affect hit-test visibility. For more info, see [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832).

[RightTapped](uielement_righttapped.md) supports the ability to attach event handlers to the route that will be invoked even if the event data for the event is marked [Handled](../windows.ui.xaml.input/righttappedroutedeventargs_handled.md). See [AddHandler](uielement_addhandler.md).

Specific Windows Runtime controls may have class-based handling for the [RightTapped](uielement_righttapped.md) event. If so, the control probably has an override for the method [OnRightTapped](../windows.ui.xaml.controls/control_onrighttapped.md). A right-tap action might be associated with displaying a context menu or secondary window. For more info on how class-based handling for events works, see [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832).

### RightTapped for mouse and pen/stylus input

The input system processes an action where the user clicks the right mouse button while over the element as a [RightTapped](uielement_righttapped.md) action. The event doesn't fire until the right mouse button is released. Mouse input doesn't produce [Holding](uielement_holding.md) events by default, no matter how long a mouse button is held down, or which button is held.

Some pen devices have multiple buttons, one of which can be used the same way that the right button on a mouse device is used. This depends on the device and its settings, but if a right-click equivalent is enabled by the pen device, the input system can fire [RightTapped](uielement_righttapped.md) for these actions also.


<!--The following remark is relevant for Windows 8 > 8.1 migration. See WBB 458128-->
### Windows 8 behavior

Windows 8 had an issue with the data for the [RightTapped](uielement_righttapped.md) event, where the **X** and **Y** values for the point you'd get from [RightTappedRoutedEventArgs.GetPosition](../windows.ui.xaml.input/righttappedroutedeventargs_getposition.md) were reversed (**X** was really **Y**; **Y** was really **X**). This issue has been fixed starting with Windows 8.1. But if you're retargeting a Windows 8 app for Windows 8.1, you might have had code that worked around this issue by swapping the **X** and **Y** back. If so, remove that code when you retarget because the issue is now fixed.

Apps that were compiled for Windows 8 but running on Windows 8.1 continue to use this Windows 8 behavior.


<!--The following remark is relevant for Windows 8 > 8.1 migration. See WBB 458260-->
Also, Windows 8 didn't include default key handling for Shift+F10 that would fire this event and then display context menus. Shift+F10 is typically a secondary key combination for the VK_APP virtual key value (the Properties key), and thus Shift+F10 might be expected to fire [RightTapped](uielement_righttapped.md) too. This issue has been fixed starting with Windows 8.1; Shift+F10 now fires [RightTapped](uielement_righttapped.md). You can see this change as default event handling on some controls that have default context menus for text, such as [TextBox](../windows.ui.xaml.controls/textbox.md), or when invoking custom menus and flyouts.

Apps that were compiled for Windows 8 but running on Windows 8.1 do not use this Windows 8 behavior, they use the corrected Windows 8.1 behavior.

## -examples

## -see-also
[IsRightTapEnabled](uielement_isrighttapenabled.md), [PopupMenu](../windows.ui.popups/popupmenu.md), [Handle pointer input](https://docs.microsoft.com/windows/uwp/design/input/handle-pointer-input), [XAML user input events sample](http://go.microsoft.com/fwlink/p/?linkid=231524), [Context  menu sample](http://code.msdn.microsoft.com/windowsapps/Context-menu-sample-40840351/view/SourceCode)