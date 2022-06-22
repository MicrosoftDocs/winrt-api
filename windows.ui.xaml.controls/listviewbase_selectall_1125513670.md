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
> Call the SelectAll method only when the [SelectionMode](listviewbase_selectionmode.md) property is set to [Multiple](listviewselectionmode.md) or [Extended](listviewselectionmode.md). If you call SelectAll when the [SelectionMode](listviewbase_selectionmode.md) is **Single** or **None**, an exception is thrown.

Starting in Windows 10, you can use the [SelectRange](listviewbase_selectrange_1824826911.md) and [DeselectRange](listviewbase_deselectrange_1629963900.md) methods with the [SelectedRanges](listviewbase_selectedranges.md) property to make selections using ranges of indexes. This is a more efficient way to describe item selection than using [SelectedItems](listviewbase_selecteditems.md), which requires the actual item object to be created for each selected item. To select all items using index ranges, use [SelectRange](listviewbase_selectrange_1824826911.md).

## -examples
```xaml
<GridView x:Name="itemGridView"/>
```

```csharp
if (itemGridView.SelectionMode == ListViewSelectionMode.Multiple ||
    itemGridView.SelectionMode == ListViewSelectionMode.Extended)
{
    itemGridView.SelectAll();
}
```

```cppwinrt
if (itemGridView().SelectionMode() == Windows::UI::Xaml::Controls::ListViewSelectionMode::Multiple ||
    itemGridView().SelectionMode() == Windows::UI::Xaml::Controls::ListViewSelectionMode::Extended)
{
    itemGridView().SelectAll();
}
```

```cppcx
if (itemGridView->SelectionMode == ListViewSelectionMode::Multiple ||
    itemGridView->SelectionMode == ListViewSelectionMode::Extended)
{
    itemGridView->SelectAll();
}
```

```vb
If itemGridView.SelectionMode = ListViewSelectionMode.Multiple OrElse
   itemGridView.SelectionMode = ListViewSelectionMode.Extended Then

   itemGridView.SelectAll()
End If
```

## -see-also
[SelectedRanges](listviewbase_selectedranges.md), [SelectRange](listviewbase_selectrange_1824826911.md), [DeselectRange](listviewbase_deselectrange_1629963900.md), [ItemIndexRange](../windows.ui.xaml.data/itemindexrange.md)
