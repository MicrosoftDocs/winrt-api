---
-api-id: P:Windows.UI.Xaml.Controls.ListViewBase.CanReorderItems
-api-type: winrt property
---

<!-- Property syntax
public bool CanReorderItems { get;  set; }
-->

# Windows.UI.Xaml.Controls.ListViewBase.CanReorderItems

## -description
Gets or sets a value that indicates whether items in the view can be reordered through user interaction.

## -xaml-syntax
```xaml
<listViewBase CanReorderItems="bool" />
```


## -property-value
**True** if items in the view can be reordered through user interaction; otherwise, **false**. The default is **false**.

## -remarks
To enable users to reorder items using drag-and-drop interaction, you must set both the [CanReorderItems](listviewbase_canreorderitems.md) and [AllowDrop](../windows.ui.xaml/uielement_allowdrop.md) properties to **true**.

Built in reordering is not supported when items are grouped, or when a [VariableSizedWrapGrid](variablesizedwrapgrid.md) is used as the [ItemsPanel](itemscontrol_itemspanel.md).

Setting [IsSwipeEnabled](listviewbase_isswipeenabled.md) to **false** disables some default touch interactions, so it should be set to **true** when these interactions are needed. For example:
+ If item selection is enabled and you set [IsSwipeEnabled](listviewbase_isswipeenabled.md) to **false**, a user can deselect items by right-clicking with the mouse, but can't deselect an item with touch by using a *swipe* gesture.
+ If you set [CanDragItems](listviewbase_candragitems.md) to **true** and [IsSwipeEnabled](listviewbase_isswipeenabled.md) to **false**, a user can drag items with the mouse, but not with touch.
+ If you set [CanReorderItems](listviewbase_canreorderitems.md) to **true** and [IsSwipeEnabled](listviewbase_isswipeenabled.md) to **false**, a user can reorder items with the mouse, but not with touch.


## -examples
Here's a [GridView](gridview.md) that contains 6 rectangles that a user can reorder by drag-and-drop.

```xaml
<GridView MaxHeight="310" 
          AllowDrop="True" 
          CanReorderItems="True">
    <Rectangle Height="100" Width="100" Fill="Blue"/>
    <Rectangle Height="100" Width="100" Fill="Red"/>
    <Rectangle Height="100" Width="100" Fill="Yellow"/>
    <Rectangle Height="100" Width="100" Fill="Green"/>
    <Rectangle Height="100" Width="100" Fill="Gray"/>
    <Rectangle Height="100" Width="100" Fill="LightBlue"/>
</GridView>
```



## -see-also
[AllowDrop](../windows.ui.xaml/uielement_allowdrop.md), [CanDragItems](listviewbase_candragitems.md), [Drag and drop sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620634)
