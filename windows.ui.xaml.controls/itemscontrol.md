---
-api-id: T:Windows.UI.Xaml.Controls.ItemsControl
-api-type: winrt class
---

<!-- Class syntax.
public class ItemsControl : Windows.UI.Xaml.Controls.Control, Windows.UI.Xaml.Controls.IItemContainerMapping, Windows.UI.Xaml.Controls.IItemsControl, Windows.UI.Xaml.Controls.IItemsControl2, Windows.UI.Xaml.Controls.IItemsControl3, Windows.UI.Xaml.Controls.IItemsControlOverrides
-->

# Windows.UI.Xaml.Controls.ItemsControl

## -description
Represents a control that can be used to present a collection of items.



## -xaml-syntax
```xaml
<ItemsControl ...>
  oneOrMoreItems
</ItemsControl>
```


## -remarks
An ItemsControl object can serve two roles. It can be used to present a fixed set of items, or it can be used to display a list obtained from data binding to a data source. Using an ItemsControl for data is more common. To display data, specify the binding to the data as the [ItemsSource](itemscontrol_itemssource.md) value (or use the data context) and don't populate [Items](itemscontrol_items.md). If you want to display a fixed list, populate [Items](itemscontrol_items.md) with one or more [FrameworkElement](../windows.ui.xaml/frameworkelement.md) child objects, and don't specify [ItemsSource](itemscontrol_itemssource.md).

There are several controls that inherit from ItemsControl that you can use in your app, but you can also use an ItemsControl directly, because it does offer a basic presentation of data or items. Controls that derive from ItemsControl and which add additional presentation features include: [ListView](listview.md), [GridView](gridview.md), [ListBox](listbox.md), other [Selector](../windows.ui.xaml.controls.primitives/selector.md) derived controls ([ComboBox](combobox.md), [FlipView](flipview.md)), [MenuFlyoutPresenter](menuflyoutpresenter.md).

[ListView](listview.md) and [GridView](gridview.md) are the two most commonly used controls for displaying data. For more info on how to use these controls, including sample code, see [Adding ListView and GridView controls](/previous-versions/windows/apps/hh780618(v=win.10)).

[ItemsSource](itemscontrol_itemssource.md) typically references a list of items. This can be a fixed list from a business object, or a list that's designed to fire notifications if the underlying data changes. The list might be a generic interface (for example [IList&lt;T&gt;](/dotnet/api/system.collections.generic.ilist-1?view=dotnet-uwp-10.0&preserve-view=true)) or a practical class that implements the collection interfaces that Windows Runtime data binding supports. When you display items in an ItemsControl, you can use the [ItemTemplate](itemscontrol_itemtemplate.md) property, the [ItemsPanel](itemscontrol_itemspanel.md) property, or both to specify the appearance of the items. The [DisplayMemberPath](itemscontrol_displaymemberpath.md) property can be used for a master-details view of the data. For more info on how to use these properties in data binding scenarios, how lists are supported, and how to implement two-way bindings or notifications on changes, see the "Binding to collections" section of [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth). Support for data and items is one of the areas where you'll use different interfaces and techniques for Visual C++ component extensions (C++/CX) than you do for C# or Microsoft Visual Basic; [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth) also includes a table for that info.

You can provide a custom template for an ItemsControl because it is a [Control](control.md) class. But before retemplating ItemsControl you should check whether one of the derived classes already offers a similar template and gives you the presentation experience you want. In particular, if you're looking for data presentation that has an association with the orientation of the items (list is either horizontal or vertical) you should look at [ListView](listview.md) and [GridView](gridview.md).

ItemsControl implements [IItemContainerMapping](iitemcontainermapping.md), which is mainly a helper interface that supports other features. App code seldom calls the [IItemContainerMapping](iitemcontainermapping.md) methods directly, and controls that derive from ItemsControl or any of the deeper classes typically don't have to reimplement [IItemContainerMapping](iitemcontainermapping.md).

### **ItemsControl** derived classes

ItemsControl is the parent class for [MenuFlyoutPresenter](menuflyoutpresenter.md) and [Selector](../windows.ui.xaml.controls.primitives/selector.md). Most of the practical items controls derive from [Selector](../windows.ui.xaml.controls.primitives/selector.md) in some way, either through [ListViewBase](listviewbase.md) or directly from [Selector](../windows.ui.xaml.controls.primitives/selector.md).

## -examples

## -see-also
[Control](control.md), [ListView](listview.md), [GridView](gridview.md), [Selector](../windows.ui.xaml.controls.primitives/selector.md), [Controls list](/windows/uwp/design/controls-and-patterns/), [Adding ListView and GridView controls](/previous-versions/windows/apps/hh780618(v=win.10)), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth)
