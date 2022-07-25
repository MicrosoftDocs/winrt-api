---
-api-id: E:Windows.UI.Xaml.Controls.Primitives.Selector.SelectionChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.Controls.SelectionChangedEventHandler SelectionChanged
-->

# Windows.UI.Xaml.Controls.Primitives.Selector.SelectionChanged

## -description
Occurs when the currently selected item changes.



## -xaml-syntax
```xaml
<selector SelectionChanged="eventhandler"/>
```


## -remarks
> [!NOTE]
> For [ListView](../windows.ui.xaml.controls/listview.md) and [GridView](../windows.ui.xaml.controls/gridview.md): If the [ItemsSource](../windows.ui.xaml.controls/itemscontrol_itemssource.md) implements [IItemsRangeInfo](../windows.ui.xaml.data/iitemsrangeinfo.md), and selection is modified using [SelectRange](../windows.ui.xaml.controls/listviewbase_selectrange_1824826911.md) or [DeselectRange](../windows.ui.xaml.controls/listviewbase_deselectrange_1629963900.md), the [AddedItems](../windows.ui.xaml.controls/selectionchangedeventargs_addeditems.md) and [RemovedItems](../windows.ui.xaml.controls/selectionchangedeventargs_removeditems.md) properties are not set in the [SelectionChangedEventArgs](../windows.ui.xaml.controls/selectionchangedeventargs.md). Setting these properties requires devirtualizing the item object. Use the [SelectedRanges](../windows.ui.xaml.controls/listviewbase_selectedranges.md) property to get the items instead.



## -examples

## -see-also
