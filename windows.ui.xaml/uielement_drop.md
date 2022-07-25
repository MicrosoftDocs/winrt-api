---
-api-id: E:Windows.UI.Xaml.UIElement.Drop
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.DragEventHandler Drop
-->

# Windows.UI.Xaml.UIElement.Drop

## -description

Occurs when the input system reports an underlying drop event with this element as the drop target.



## -xaml-syntax

```xaml
<uiElement Drop="eventhandler"/>
```

## -remarks

For Drop to occur and to invoke a handler, the value of [AllowDrop](uielement_allowdrop.md) on the [UIElement](uielement.md) that is the drop target and also on the drag-drop action source must be **true**.

A typical handler will check the [Data](drageventargs_data.md) value from the [DragEventArgs](drageventargs.md) event data.

You can initiate a drag-drop action on any [UIElement](uielement.md) by calling the [StartDragAsync](uielement_startdragasync_369751260.md) method. Once the action is initiated, any [UIElement](uielement.md) in the app can potentially be a drop target so long as [AllowDrop](uielement_allowdrop.md) is **true** on that element, and any elements that the drag-drop action passes over can handle [DragEnter](uielement_dragenter.md), [DragLeave](uielement_dragleave.md) or [DragOver](uielement_dragover.md).

Drop is a routed event. An element must have [AllowDrop](uielement_allowdrop.md) be **true** to be a Drop event source. If the event is permitted to bubble up to parent elements because it goes unhandled, then it is possible to handle the event on a parent element if [AllowDrop](uielement_allowdrop.md) is **true** on the parent element. Intermediate elements in the route that aren't either the handler object or the drop target don't need [AllowDrop](uielement_allowdrop.md) to be **true**. For more info on the routed event concept, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

For touch actions, drag-drop actions, and also for interaction-specific or manipulation events that are consequences of a touch action, an element must be hit-test visible in order to be the event source and fire the event that is associated with the action. [UIElement.Visibility](uielement_visibility.md) must be [Visible](visibility.md). Other properties of derived types also affect hit-test visibility, for example [IsEnabled](../windows.ui.xaml.controls/control_isenabled.md). For more info, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

Drop supports the ability to attach event handlers to the route that will be invoked even if the event data for the event is marked [Handled](drageventargs_handled.md). See [AddHandler](uielement_addhandler_2121467075.md).

Specific Windows Runtime controls may have class-based handling for the Drop event. If so, the control's logic probably has an override for the method [OnDrop](../windows.ui.xaml.controls/control_ondrop_1015747496.md). Typically the event is marked handled by the class handler, and the Drop event is not raised for handling by any user code handlers on that control. For more info, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

Independent of the event occurrence, some controls may use theme animations such as [DragItemThemeAnimation](../windows.ui.xaml.media.animation/dragitemthemeanimation.md) to visually indicate a drag behavior to the user.

> **Windows 8/Windows 8.1**
> Prior to Windows 10, the Windows Runtime implementation of drag-drop concepts permits only certain controls and input actions to initiate a drag-drop action. There is no [StartDragAsync](uielement_startdragasync_369751260.md) or generalized **DoDragDrop** method that would permit any UI element to initiate a drag-drop action. The main source of a drag-drop action in an app is when you drag the items of a list such as [GridView](../windows.ui.xaml.controls/gridview.md).

## -examples

## -see-also

[DragEventArgs](drageventargs.md), [DragOver](uielement_dragover.md), [AllowDrop](uielement_allowdrop.md), [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview), [Drag and drop overview](/windows/uwp/design/input/drag-and-drop), [Drag and drop sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlDragAndDrop)
