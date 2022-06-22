---
-api-id: P:Windows.UI.Xaml.Controls.ListViewBase.CanDragItems
-api-type: winrt property
---

<!-- Property syntax
public bool CanDragItems { get;  set; }
-->

# Windows.UI.Xaml.Controls.ListViewBase.CanDragItems

## -description
Gets or sets a value that indicates whether items in the view can be dragged as data payload.



## -xaml-syntax
```xaml
<listViewBase CanDragItems="bool" />
```


## -property-value

`true` if items in the view can be dragged as data payload; otherwise, `false`. The default is `false`.

## -remarks
Setting [IsSwipeEnabled](listviewbase_isswipeenabled.md) to `false` disables some default touch interactions, so it should be set to `true` when these interactions are needed. For example:
+ If item selection is enabled and you set [IsSwipeEnabled](listviewbase_isswipeenabled.md) to `false`, a user can deselect items by right-clicking with the mouse, but can't deselect an item with touch by using a *swipe* gesture.
+ If you set CanDragItems to `true` and [IsSwipeEnabled](listviewbase_isswipeenabled.md) to `false`, a user can drag items with the mouse, but not with touch.
+ If you set [CanReorderItems](listviewbase_canreorderitems.md) to `true` and [IsSwipeEnabled](listviewbase_isswipeenabled.md) to `false`, a user can reorder items with the mouse, but not with touch.

`CanDragItems` can be set to false as part of visual states that are intended to prevent users from dragging items in views such as a [GridView](gridview.md).

`CanDragItems` does not reflect transient states that might influence the ability to drag items, such as item population lag. The primary scenario where you might get the value of `CanDragItems` in code is to verify that dynamic templates or user-selectable options in your app UI have not changed the value since you last set it.

> [!IMPORTANT]
> In order to receive the [DragItemsStarting](listviewbase_dragitemsstarting.md) and [DragItemsCompleted](listviewbase_dragitemscompleted.md) events, the [CanDragItems](listviewbase_candragitems.md) property must be set to `true`.

## -examples

## -see-also
[AllowDrop](../windows.ui.xaml/uielement_allowdrop.md), [CanReorderItems](listviewbase_canreorderitems.md), [Drag and drop sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlDragAndDrop)
