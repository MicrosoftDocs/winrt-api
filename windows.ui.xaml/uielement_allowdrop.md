---
-api-id: P:Windows.UI.Xaml.UIElement.AllowDrop
-api-type: winrt property
---

<!-- Property syntax
public bool AllowDrop { get;  set; }
-->

# Windows.UI.Xaml.UIElement.AllowDrop

## -description
Gets or sets a value that determines whether this [UIElement](uielement.md) can be a drop target for purposes of drag-and-drop operations.



## -xaml-syntax
```xaml
<uiElement AllowDrop="bool"/>
```


## -property-value
**true** if this [UIElement](uielement.md) can be a drop target for purposes of drag-and-drop operations; otherwise, **false**. The default is **false**.

## -remarks
The value of AllowDrop determines whether various events related to being a drop target or responding to being dragged over can be handled. Such events only can be handled if AllowDrop is **true** on the [UIElement](uielement.md) that is a potential drop target. These events are:
+ [DragEnter](uielement_dragenter.md)
+ [DragLeave](uielement_dragleave.md)
+ [DragOver](uielement_dragover.md)
+ [Drop](uielement_drop.md)
 Each of the listed events is a routed event. If you want to handle a bubbling drag-drop event, the potential drop target must have AllowDrop set to **true**, and the object where the event is handled must have AllowDrop set to **true**. For more info on routed event concepts, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

The Windows Runtime implementation of drag-drop concepts permits only certain controls and input actions to initiate a drag-drop action. There is no generalized **DoDragDrop** method that would permit any UI element to initiate a drag-drop action. The main source of a drag-drop action in an app is when you drag the items of a list such as [GridView](../windows.ui.xaml.controls/gridview.md). However once the action is initiated, any [UIElement](uielement.md) in the app can potentially be a drop target so long as AllowDrop is **true** on that element. Any elements that the drag-drop action passes over can handle [DragEnter](uielement_dragenter.md), [DragLeave](uielement_dragleave.md) or [DragOver](uielement_dragover.md). The initiating list view does not require AllowDrop. Instead, the value of [CanDragItems](../windows.ui.xaml.controls/listviewbase_candragitems.md) is used to determine whether the items in the list can be used to start a drag-drop action.

A UI element can't be a drop target for any drag-drop action that begins from outside the current UWP app. This includes actions that come from another UWP app, which is possible for a snapped view.

## -examples

## -see-also

[Drag and drop overview](/windows/uwp/design/input/drag-and-drop), [Drag and drop sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlDragAndDrop)
