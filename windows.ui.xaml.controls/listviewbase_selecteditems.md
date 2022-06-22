---
-api-id: P:Windows.UI.Xaml.Controls.ListViewBase.SelectedItems
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<object> SelectedItems { get; }
-->

# Windows.UI.Xaml.Controls.ListViewBase.SelectedItems

## -description
Gets the currently selected items.



## -property-value
A collection of the currently selected items. The default is an empty collection.

## -remarks
When [SelectionMode](listviewbase_selectionmode.md) is **Multiple** or **Extended**, use the SelectedItems property to get the items that are selected. When [SelectionMode](listviewbase_selectionmode.md) is **Single**, use the [Selector.SelectedItem](../windows.ui.xaml.controls.primitives/selector_selecteditem.md) property to get the item that's selected.

Starting in Windows 10, you can use the [SelectRange](listviewbase_selectrange_1824826911.md) and [DeselectRange](listviewbase_deselectrange_1629963900.md) methods with the [SelectedRanges](listviewbase_selectedranges.md) property to make selections using ranges of indexes. This is a more efficient way to describe item selection than using SelectedItems, which requires the actual item object to be created for each selected item.

> [!NOTE]
> If the [ItemsSource](itemscontrol_itemssource.md) implements [IItemsRangeInfo](../windows.ui.xaml.data/iitemsrangeinfo.md), the SelectedItems collection is not updated based on selection in the list. Use the [SelectedRanges](listviewbase_selectedranges.md) property instead.

## -examples

## -see-also
[SelectionMode](listviewbase_selectionmode.md), [Selector.SelectedItem](../windows.ui.xaml.controls.primitives/selector_selecteditem.md), [Selector.SelectedIndex](../windows.ui.xaml.controls.primitives/selector_selectedindex.md), [Selector.SelectionChanged](../windows.ui.xaml.controls.primitives/selector_selectionchanged.md), [SelectedRanges](listviewbase_selectedranges.md), [SelectRange](listviewbase_selectrange_1824826911.md), [DeselectRange](listviewbase_deselectrange_1629963900.md)
