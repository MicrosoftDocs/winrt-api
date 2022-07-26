---
-api-id: E:Windows.UI.Xaml.Controls.TreeView.DragItemsStarting
-api-type: winrt event
ms.custom: RS5
---

<!-- Event syntax.
public event TypedEventHandler DragItemsStarting<TreeView, TreeViewDragItemsStartingEventArgs>
-->

# Windows.UI.Xaml.Controls.TreeView.DragItemsStarting

## -description

Occurs when a drag operation that involves one of the items in the view is initiated.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.TreeView.DragItemsStarting](/windows/winui/api/microsoft.ui.xaml.controls.treeview.dragitemsstarting) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<TreeView DragItemsStarting="eventhandler"/>
```

## -remarks

To receive this event, set the [CanDragItems](treeview_candragitems.md) property to **true**.

This event occurs when you start a drag-and-drop operation, including when you perform a reorder operation by drag-and-drop. When you perform custom actions as a result of a drag-and-drop operation, you typically listen to this event and provide more data using the [TreeViewDragItemsStartingEventArgs.Data](treeviewdragitemsstartingeventargs_data.md) property.

You can inspect the items being dragged by checking the [TreeViewDragItemsStartingEventArgs.Items](treeviewdragitemsstartingeventargs_items.md) property.

You can cancel the drag operation by setting the [TreeViewDragItemsStartingEventArgs.Cancel](treeviewdragitemsstartingeventargs_cancel.md) property to **true**.

## -examples

## -see-also
[TreeViewDragItemsStartingEventArgs](treeviewdragitemsstartingeventargs.md)

