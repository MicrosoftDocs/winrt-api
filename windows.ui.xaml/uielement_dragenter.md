---
-api-id: E:Windows.UI.Xaml.UIElement.DragEnter
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.DragEventHandler DragEnter
-->

# Windows.UI.Xaml.UIElement.DragEnter

## -description
Occurs when the input system reports an underlying drag event with this element as the target.

## -xaml-syntax
```xaml
<uiElement DragEnter="eventhandler"/>
```


## -remarks
For a [DragEnter](uielement_dragenter.md) event to occur, the value of [AllowDrop](uielement_allowdrop.md) on the current [UIElement](uielement.md) and on the event source must be **true**. Otherwise, consider using [PointerEntered](uielement_pointerentered.md).

You can initiate a drag-drop action on any [UIElement](uielement.md) by calling the [StartDragAsync](uielement_startdragasync.md) method. Once the action is initiated, any [UIElement](uielement.md) in the app can potentially be a drop target so long as [AllowDrop](uielement_allowdrop.md) is **true** on that element. Any elements that the drag-drop action passes over can handle [DragEnter](uielement_dragenter.md), [DragLeave](uielement_dragleave.md) or [DragOver](uielement_dragover.md).


<!--For more info see ...-->
[DragEnter](uielement_dragenter.md) is a routed event. For more info on the routed event concept, see [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832).

For touch actions, drag-drop actions, and also for interaction-specific or manipulation events that are consequences of a touch action, an element must be hit-test visible in order to be the event source and fire the event that is associated with the action. [UIElement.Visibility](uielement_visibility.md) must be [Visible](visibility.md). Other properties of derived types also affect hit-test visibility, for example [IsEnabled](../windows.ui.xaml.controls/control_isenabled.md). For more info, see [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832).

[DragEnter](uielement_dragenter.md) supports the ability to attach event handlers to the route that will be invoked even if the event data for the event is marked [Handled](drageventargs_handled.md). See [AddHandler](uielement_addhandler.md).

Specific Windows Runtime controls may have class-based handling for the [DragEnter](uielement_dragenter.md) event. If so, the control probably has an override for the method [OnDragEnter](../windows.ui.xaml.controls/control_ondragenter.md). Typically the event is marked handled by the class handler, and the [DragEnter](uielement_dragenter.md) event is not raised for handling by any user code handlers on that control. For more info, see [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832).

Independent of the event occurrence, some controls may use theme animations such as [DragItemThemeAnimation](../windows.ui.xaml.media.animation/dragitemthemeanimation.md) to visually indicate a drag behavior to the user.

> **Windows 8/Windows 8.1**
> Prior to Windows 10, the Windows Runtime implementation of drag-drop concepts permits only certain controls and input actions to initiate a drag-drop action. There is no [StartDragAsync](uielement_startdragasync.md) or generalized **DoDragDrop** method that would permit any UI element to initiate a drag-drop action. The main source of a drag-drop action in an app is when you drag the items of a list such as [GridView](../windows.ui.xaml.controls/gridview.md).

## -examples

## -see-also
[DragOver](uielement_dragover.md), [AllowDrop](uielement_allowdrop.md), [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832), [Drag and drop sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620634)