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
### Selection behavior and CollectionViewSource

List controls that derive from [Selector](selector.md) have a default selection behavior that depends on what the items source is (the type that's used for [ItemsSource](../windows.ui.xaml.controls/itemscontrol_itemssource.md)). If the items source is a [CollectionViewSource](../windows.ui.xaml.data/collectionviewsource.md) instance, then the behavior in the selection control is that the selection will default to the current item. When the list is first displayed, the selection defaults to the first item as current item. If you don't want the first item to be selected in this case, set [IsSynchronizedWithCurrentItem](selector_issynchronizedwithcurrentitem.md) to **false** in the [GridView](../windows.ui.xaml.controls/gridview.md), the [ListView](../windows.ui.xaml.controls/listview.md), or other [Selector](selector.md)-based control that is showing the selection.

### **Selector** derived classes

[Selector](selector.md) is the parent class for these controls:
+ [ComboBox](../windows.ui.xaml.controls/combobox.md)
+ [FlipView](../windows.ui.xaml.controls/flipview.md)
+ [ListBox](../windows.ui.xaml.controls/listbox.md)
+ [ListViewBase](../windows.ui.xaml.controls/listviewbase.md) (parent of [GridView](../windows.ui.xaml.controls/gridview.md) and [ListView](../windows.ui.xaml.controls/listview.md))


> [!NOTE]
> [SemanticZoom](../windows.ui.xaml.controls/semanticzoom.md) is a similar control but it doesn't enable selection itself. [SemanticZoom](../windows.ui.xaml.controls/semanticzoom.md) inherits directly from [Control](../windows.ui.xaml.controls/control.md) . A [SemanticZoom](../windows.ui.xaml.controls/semanticzoom.md) typically displays one of the [Selector](selector.md) derived controls in each of its views.

## -examples

## -see-also
[ItemsControl](../windows.ui.xaml.controls/itemscontrol.md), [Adding ListView and GridView controls](http://msdn.microsoft.com/library/ede8164f-ad0f-4249-b5ab-6f46ca65754a), [Adding ListView, SemanticZoom, and other data controls](http://msdn.microsoft.com/library/d43a9e84-6b76-4d33-86bd-505cc7e73145), [How to add a list box](http://msdn.microsoft.com/library/da62d0a1-60e6-42b6-9f72-70e2ed047c0d)