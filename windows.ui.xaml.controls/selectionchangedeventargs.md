---
-api-id: T:Windows.UI.Xaml.Controls.SelectionChangedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class SelectionChangedEventArgs : Windows.UI.Xaml.RoutedEventArgs, Windows.UI.Xaml.Controls.ISelectionChangedEventArgs
-->

# Windows.UI.Xaml.Controls.SelectionChangedEventArgs

## -description
Provides data for the [SelectionChanged](../windows.ui.xaml.controls.primitives/selector_selectionchanged.md) event.



## -remarks
> [!NOTE]
> For [ListView](listview.md) and [GridView](gridview.md): If the [ItemsSource](itemscontrol_itemssource.md) implements [IItemsRangeInfo](../windows.ui.xaml.data/iitemsrangeinfo.md), and selection is modified using [SelectRange](listviewbase_selectrange_1824826911.md) or [DeselectRange](listviewbase_deselectrange_1629963900.md), the [AddedItems](selectionchangedeventargs_addeditems.md) and [RemovedItems](selectionchangedeventargs_removeditems.md) properties are not set. Setting these properties requires devirtualizing the item object. Use the [SelectedRanges](listviewbase_selectedranges.md) property to get the items instead.



## -examples

## -see-also
[RoutedEventArgs](../windows.ui.xaml/routedeventargs.md)
