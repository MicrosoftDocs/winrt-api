---
-api-id: M:Windows.UI.Xaml.Controls.ListViewBase.SelectAll
-api-type: winrt method
---

<!-- Method syntax
public void SelectAll()
-->

# Windows.UI.Xaml.Controls.ListViewBase.SelectAll

## -description
Selects all the items in a view.

## -remarks
> [!WARNING]
> Call the [SelectAll](listviewbase_selectall.md) method only when the [SelectionMode](listviewbase_selectionmode.md) property is set to [Multiple](listviewselectionmode.md) or [Extended](listviewselectionmode.md). If you call [SelectAll](listviewbase_selectall.md) when the [SelectionMode](listviewbase_selectionmode.md) is **Single** or **None**, an exception is thrown.

Starting in Windows 10, you can use the [SelectRange](listviewbase_selectrange.md) and [DeselectRange](listviewbase_deselectrange.md) methods with the [SelectedRanges](listviewbase_selectedranges.md) property to make selections using ranges of indexes. This is a more efficient way to describe item selection than using [SelectedItems](listviewbase_selecteditems.md), which requires the actual item object to be created for each selected item. To select all items using index ranges, use [SelectRange](listviewbase_selectrange.md).

## -examples
```cpp
if (itemGridView->SelectionMode == ListViewSelectionMode::Multiple ||
    itemGridView->SelectionMode == ListViewSelectionMode::Extended)
{
    itemGridView->SelectAll();
}
```

```csharp
if (itemGridView.SelectionMode == ListViewSelectionMode.Multiple ||
    itemGridView.SelectionMode == ListViewSelectionMode.Extended)
{
    itemGridView.SelectAll();
}
```

```vbnet
If itemGridView.SelectionMode = ListViewSelectionMode.Multiple OrElse
   itemGridView.SelectionMode = ListViewSelectionMode.Extended Then

   itemGridView.SelectAll()
End If
```



## -see-also
[SelectedRanges](listviewbase_selectedranges.md), [SelectRange](listviewbase_selectrange.md), [DeselectRange](listviewbase_deselectrange.md), [ItemIndexRange](../windows.ui.xaml.data/itemindexrange.md)