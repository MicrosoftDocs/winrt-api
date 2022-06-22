---
-api-id: P:Windows.UI.Xaml.Controls.SelectionChangedEventArgs.AddedItems
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<object> AddedItems { get; }
-->

# Windows.UI.Xaml.Controls.SelectionChangedEventArgs.AddedItems

## -description
Gets a list that contains the items that were selected.



## -property-value
The loosely typed collection of items that were selected in this event.

## -remarks
> [!NOTE]
> For [ListView](listview.md) and [GridView](gridview.md): If the [ItemsSource](itemscontrol_itemssource.md) implements [IItemsRangeInfo](../windows.ui.xaml.data/iitemsrangeinfo.md), and selection is modified using [SelectRange](listviewbase_selectrange_1824826911.md) or [DeselectRange](listviewbase_deselectrange_1629963900.md), the AddedItems and [RemovedItems](selectionchangedeventargs_removeditems.md) properties are not set. Setting these properties requires devirtualizing the item object. Use the [SelectedRanges](listviewbase_selectedranges.md) property to get the items instead.



## -examples

## -see-also
