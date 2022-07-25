---
-api-id: P:Windows.UI.Xaml.Controls.ListBox.SelectedItems
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<object> SelectedItems { get; }
-->

# Windows.UI.Xaml.Controls.ListBox.SelectedItems

## -description
Gets the list of currently selected items for the [ListBox](listbox.md) control.



## -property-value
The list of currently selected items for the [ListBox](listbox.md) control.

## -remarks
When [SelectionMode](listbox_selectionmode.md) is **Multiple** or **Extended**, use the [SelectedItems](listviewbase_selecteditems.md) property to get the items that are selected. When [SelectionMode](listbox_selectionmode.md) is **Single**, use the [Selector.SelectedItem](../windows.ui.xaml.controls.primitives/selector_selecteditem.md) property to get the item that's selected.

## -examples

## -see-also
[SelectionMode](listviewbase_selectionmode.md), [Selector.SelectedItem](../windows.ui.xaml.controls.primitives/selector_selecteditem.md), [Selector.SelectedIndex](../windows.ui.xaml.controls.primitives/selector_selectedindex.md), [Selector.SelectionChanged](../windows.ui.xaml.controls.primitives/selector_selectionchanged.md)
