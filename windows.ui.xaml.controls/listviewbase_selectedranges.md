---
-api-id: P:Windows.UI.Xaml.Controls.ListViewBase.SelectedRanges
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.UI.Xaml.Data.ItemIndexRange> SelectedRanges { get; }
-->

# Windows.UI.Xaml.Controls.ListViewBase.SelectedRanges

## -description
Gets a collection of [ItemIndexRange](../windows.ui.xaml.data/itemindexrange.md) objects that describe the currently selected items in the list.



## -property-value
The collection of [ItemIndexRange](../windows.ui.xaml.data/itemindexrange.md) objects that describe the currently selected items in the list. The default is an empty collection.

## -remarks
Each [ItemIndexRange](../windows.ui.xaml.data/itemindexrange.md) in the SelectedRanges collection describes a contiguous block of selected items. [ItemIndexRange](../windows.ui.xaml.data/itemindexrange.md) describes the selection by index, so item objects don't need to be created. This is a more efficient way to describe item selection than using [SelectedItems](listviewbase_selecteditems.md), which requires the actual item object to be created for each selected item.

If your datasource performs data virtualization, you can use the SelectedRanges property with the [SelectRange](listviewbase_selectrange_1824826911.md) and [DeselectRange](listviewbase_deselectrange_1629963900.md) methods to modify selection of items that have not been created yet.

> [!NOTE]
> If the [ItemsSource](itemscontrol_itemssource.md) implements [IItemsRangeInfo](../windows.ui.xaml.data/iitemsrangeinfo.md), the [SelectedItems](listviewbase_selecteditems.md) collection is not updated based on selection in the list. Use the SelectedRanges property instead.

## -examples

## -see-also
[SelectRange](listviewbase_selectrange_1824826911.md), [DeselectRange](listviewbase_deselectrange_1629963900.md), [ItemIndexRange](../windows.ui.xaml.data/itemindexrange.md)
