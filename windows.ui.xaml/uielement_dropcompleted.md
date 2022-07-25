---
-api-id: E:Windows.UI.Xaml.UIElement.DropCompleted
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler DropCompleted<Windows.UI.Xaml.UIElement,  Windows.UI.Xaml.DropCompletedEventArgs>
-->

# Windows.UI.Xaml.UIElement.DropCompleted

## -description

Occurs when a drag-and-drop operation with this element as the source is ended.



## -xaml-syntax

```xaml
<uiElement DropCompleted="eventhandler"/>
```

## -remarks

DropCompleted is raised on the drag source element after [DragStarting](uielement_dragstarting.md), when the dragged element has been dropped. You can handle this event and take appropriate action based on the [DropResult](dropcompletedeventargs_dropresult.md) in the event args. For example, if the DropResult is [Move](../windows.applicationmodel.datatransfer/datapackageoperation.md), you should delete the original drag source.

DragStarting and DropCompleted are raised only if [CanDrag](uielement_candrag.md) is **true**.

DropCompleted is a routed event. For more info on the routed event concept, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

## -examples

## -see-also

[DropCompletedEventArgs](dropcompletedeventargs.md)
