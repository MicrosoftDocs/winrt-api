---
-api-id: E:Windows.UI.Xaml.Controls.ListViewBase.DragItemsStarting
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.Controls.DragItemsStartingEventHandler DragItemsStarting
-->

# Windows.UI.Xaml.Controls.ListViewBase.DragItemsStarting

## -description
Occurs when a drag operation that involves one of the items in the view is initiated.



## -xaml-syntax
```xaml
<listViewBase DragItemsStarting="eventhandler" />
```


## -remarks

> [!IMPORTANT]
> In order to receive this event, the [CanDragItems](listviewbase_candragitems.md) property must be set to `true`.

This event occurs when you start a drag-and-drop operation, including when you perform a reorder operation by drag-and-drop. When you perform custom actions as a result of a drag-and-drop operation, you typically listen to this event and provide more data using the [DragItemsStartingEventArgs.Data](dragitemsstartingeventargs_data.md) property.

You can inspect the items being dragged by checking the [DragItemsStartingEventArgs.Items](dragitemsstartingeventargs_items.md) property.

You can cancel the drag operation by setting the [DragItemsStartingEventArgs.Cancel](dragitemsstartingeventargs_cancel.md) property to `true`.

## -examples

## -see-also
[DragItemsStartingEventArgs](dragitemsstartingeventargs.md), [Drag and drop sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlDragAndDrop)
