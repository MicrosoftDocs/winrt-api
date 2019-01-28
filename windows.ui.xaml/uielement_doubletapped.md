---
-api-id: E:Windows.UI.Xaml.UIElement.DoubleTapped
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.Input.DoubleTappedEventHandler DoubleTapped
-->

# Windows.UI.Xaml.UIElement.DoubleTapped

## -description

Occurs when an otherwise unhandled **DoubleTap** interaction occurs over the hit test area of this element.

## -xaml-syntax

```xaml
<uiElement DoubleTapped="eventhandler"/>
```

## -remarks

A **DoubleTap** interaction is simply two **Tap** interactions that occur in quick succession. The exact timing of what the system interprets as a double tap is adjustable by users through system settings.

See [Touch interaction design](http://msdn.microsoft.com/library/9ba7f613-e5d1-40d4-920b-143094209e3a) for more info on how to use a **DoubleTap** interaction in your app design.

If a user interaction also fires [DoubleTapped](uielement_doubletapped.md), [Tapped](uielement_tapped.md) will fire first to represent the first tap, but the second tap won't fire an additional [Tapped](uielement_doubletapped.md). If you want different logic for [Tapped](uielement_tapped.md) versus [DoubleTapped](uielement_doubletapped.md), your [Tapped](uielement_tapped.md) handler may need to use app-specific variables and a timer in order to avoid running on interactions that are eventually interpreted as a **DoubleTap** action.

A [DoubleTapped](uielement_doubletapped.md) event represents a gesture, whereas a [PointerPressed](uielement_pointerpressed.md) event is a lower-level input event. [DoubleTapped](uielement_doubletapped.md) and [PointerPressed](uielement_pointerpressed.md) events can fire as the result of a single user interaction. Even if a control is already handling pointer events in the control logic, or is handling manipulations, that doesn't prevent [DoubleTapped](uielement_doubletapped.md) from firing.

A [DoubleTapped](uielement_doubletapped.md) event is potentially the result of more than one pointer point. For the higher-level gesture events like [DoubleTapped](uielement_doubletapped.md) you no longer have immediate access to [PointerPoint](../windows.ui.input/pointerpoint.md) details such as individual [PointerId](../windows.ui.input/pointerpoint_pointerid.md) values or individual coordinates. You do have access to device type ([PointerDeviceType](../windows.ui.xaml.input/doubletappedroutedeventargs_pointerdevicetype.md)) and for coordinates you can call [GetPosition](../windows.ui.xaml.input/doubletappedroutedeventargs_getposition_1813281865.md), which gives an average of the coordinates for a **DoubleTap** from more than one pointer point.

[DoubleTapped](uielement_doubletapped.md) is a routed event. Also, an element must have [IsDoubleTapEnabled](uielement_isdoubletapenabled.md) be **true** to be a [DoubleTapped](uielement_doubletapped.md) event source (**true** is the default). It is possible to handle [DoubleTapped](uielement_doubletapped.md) on parent elements even if [IsDoubleTapEnabled](uielement_isdoubletapenabled.md) is **false** on the parent element, if the event bubbles to a parent from an event source child element where [IsDoubleTapEnabled](uielement_isdoubletapenabled.md) is **false**. For more info on the routed event concept, see [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832).

For touch actions and also for interaction-specific or manipulation events that are consequences of a touch action, an element must be hit-test visible in order to be the event source and fire the event that is associated with the action. [UIElement.Visibility](uielement_visibility.md) must be [Visible](visibility.md). Other properties of derived types also affect hit-test visibility. For more info, see [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832).

[DoubleTapped](uielement_doubletapped.md) supports the ability to attach event handlers to the route that will be invoked even if the event data for the event is marked **Handled**. See [AddHandler](uielement_addhandler_2121467075.md).

Specific Windows Runtime controls may have class-based handling for the [DoubleTapped](uielement_doubletapped.md) input event. If so, the control probably has an override for the method [OnDoubleTapped](../windows.ui.xaml.controls/control_ondoubletapped_1132552853.md). Typically the event is marked handled by the class handler, and the [DoubleTapped](uielement_doubletapped.md) event is not raised for handling by any user code handlers on that control. For more info on how class-based handling for events works, see [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832).

## -examples

## -see-also

[DoubleTappedRoutedEventArgs](../windows.ui.xaml.input/doubletappedroutedeventargs.md), [Handle pointer input](https://docs.microsoft.com/windows/uwp/design/input/handle-pointer-input), [XAML user input events sample](http://go.microsoft.com/fwlink/p/?linkid=231524)