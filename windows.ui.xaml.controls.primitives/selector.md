---
-api-id: T:Windows.UI.Xaml.Controls.Primitives.Selector
-api-type: winrt class
---

<!-- Class syntax.
public class Selector : Windows.UI.Xaml.Controls.ItemsControl, Windows.UI.Xaml.Controls.Primitives.ISelector
-->

# Windows.UI.Xaml.Controls.Primitives.Selector

## -description
Represents a control that enables a user to select an item from a collection of items.



## -remarks

Selector has properties that enable selection of a single item in a collection.

- [SelectedIndex](selector_selectedindex.md): The 0-based index of the selected item. The default is -1, which indicates no item is selected.
- [SelectedItem](selector_selecteditem.md): The selected data item. The default is **null**, which indicates no item is selected.
- [SelectedValue](selector_selectedindex.md): The value of the selected data item, obtained by using the [SelectedValuePath](selector_selectedvaluepath.md).

Some controls that are derived from Selector, like [ListBox](../windows.ui.xaml.controls/listbox.md), [ListView](../windows.ui.xaml.controls/listview.md), and [GridView](../windows.ui.xaml.controls/gridview.md), also support multi-selection. When multi-selection is enabled in those controls, use their [SelectedItems](../windows.ui.xaml.controls/listviewbase_selecteditems.md) property to get the selected item collection.

### Selection behavior and CollectionViewSource

List controls that derive from Selector have a default selection behavior that depends on what the items source is (the type that's used for [ItemsSource](../windows.ui.xaml.controls/itemscontrol_itemssource.md)). If the items source is a [CollectionViewSource](../windows.ui.xaml.data/collectionviewsource.md) instance, then the behavior in the selection control is that the selection will default to the current item. When the list is first displayed, the selection defaults to the first item as current item. If you don't want the first item to be selected in this case, set [IsSynchronizedWithCurrentItem](selector_issynchronizedwithcurrentitem.md) to **false** in the [GridView](../windows.ui.xaml.controls/gridview.md), the [ListView](../windows.ui.xaml.controls/listview.md), or other Selector-based control that is showing the selection.

### **Selector** derived classes

Selector is the parent class for these controls:
+ [ComboBox](../windows.ui.xaml.controls/combobox.md)
+ [FlipView](../windows.ui.xaml.controls/flipview.md)
+ [ListBox](../windows.ui.xaml.controls/listbox.md)
+ [ListViewBase](../windows.ui.xaml.controls/listviewbase.md) (parent of [GridView](../windows.ui.xaml.controls/gridview.md) and [ListView](../windows.ui.xaml.controls/listview.md))


> [!NOTE]
> [SemanticZoom](../windows.ui.xaml.controls/semanticzoom.md) is a similar control but it doesn't enable selection itself. [SemanticZoom](../windows.ui.xaml.controls/semanticzoom.md) inherits directly from [Control](../windows.ui.xaml.controls/control.md) . A [SemanticZoom](../windows.ui.xaml.controls/semanticzoom.md) typically displays one of the Selector derived controls in each of its views.

## -examples

## -see-also
[ItemsControl](../windows.ui.xaml.controls/itemscontrol.md), [Adding ListView and GridView controls](/previous-versions/windows/apps/hh780618(v=win.10)), [Adding ListView, SemanticZoom, and other data controls](/previous-versions/windows/apps/hh780615(v=win.10)), [How to add a list box](/previous-versions/windows/apps/hh868196(v=win.10))
