---
-api-id: P:Windows.UI.Xaml.Controls.SelectionChangedEventArgs.RemovedItems
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<object> RemovedItems { get; }
-->

# Windows.UI.Xaml.Controls.SelectionChangedEventArgs.RemovedItems

## -description
Gets a list that contains the items that were unselected.

Equivalent WinUI property: [Microsoft.UI.Xaml.Controls.SelectionChangedEventArgs.RemovedItems](/windows/winui/api/microsoft.ui.xaml.controls.selectionchangedeventargs.removeditems).

## -property-value
The loosely typed list of items that were unselected in this event.

## -remarks
> [!NOTE]
> For [ListView](listview.md) and [GridView](gridview.md): If the [ItemsSource](itemscontrol_itemssource.md) implements [IItemsRangeInfo](../windows.ui.xaml.data/iitemsrangeinfo.md), and selection is modified using [SelectRange](listviewbase_selectrange_1824826911.md) or [DeselectRange](listviewbase_deselectrange_1629963900.md), the [AddedItems](selectionchangedeventargs_addeditems.md) and RemovedItems properties are not set. Setting these properties requires devirtualizing the item object. Use the [SelectedRanges](listviewbase_selectedranges.md) property to get the items instead.



## -examples

## -see-also
