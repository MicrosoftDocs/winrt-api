---
-api-id: P:Windows.UI.Xaml.Controls.Primitives.Selector.SelectedIndex
-api-type: winrt property
---

<!-- Property syntax
public int SelectedIndex { get;  set; }
-->

# Windows.UI.Xaml.Controls.Primitives.Selector.SelectedIndex

## -description
Gets or sets the index of the selected item.



## -xaml-syntax
```xaml
<selector SelectedIndex="int" .../>
```


## -property-value
The index of the selected item. The default is -1, which indicates that no item is selected.

## -remarks
Some controls that are derived from [Selector](selector.md), like [ListBox](../windows.ui.xaml.controls/listbox.md), [ListView](../windows.ui.xaml.controls/listview.md), and [GridView](../windows.ui.xaml.controls/gridview.md), also support multi-selection. When multi-selection is enabled in those controls, use their [SelectedItems](../windows.ui.xaml.controls/listviewbase_selecteditems.md) property to get the selected item collection.

## -examples

## -see-also
[ListBox.SelectionMode](../windows.ui.xaml.controls/listbox_selectionmode.md), [ListBox.SelectedItems](../windows.ui.xaml.controls/listbox_selecteditems.md), [ListViewBase.SelectionMode](../windows.ui.xaml.controls/listviewbase_selectionmode.md), [ListViewBase.SelectedItems](../windows.ui.xaml.controls/listviewbase_selecteditems.md)
