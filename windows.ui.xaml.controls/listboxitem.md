---
-api-id: T:Windows.UI.Xaml.Controls.ListBoxItem
-api-type: winrt class
---

<!-- Class syntax.
public class ListBoxItem : Windows.UI.Xaml.Controls.Primitives.SelectorItem, Windows.UI.Xaml.Controls.IListBoxItem
-->

# Windows.UI.Xaml.Controls.ListBoxItem

## -description
Represents the container for an item in a [ListBox](listbox.md) control.

## -xaml-syntax
```xaml
<ListBoxItem .../>
-or-
<ListBoxItem ...>
  content
</ListBoxItem>
```


## -remarks
The [ListBoxItem](listboxitem.md) class provides the container for items displayed in a [ListBox](listbox.md) control. You populate the [ListBox](listbox.md) by adding [ListBoxItem](listboxitem.md) s directly to its [Items](itemscontrol_items.md) collection or by binding its [ItemsSource](itemscontrol_itemssource.md) property to a data source. When items are added to the [ListBox](listbox.md), a [ListBoxItem](listboxitem.md) container is created automatically for each item in the collection.

You can specify the look of the [ListBoxItem](listboxitem.md) by setting the [ListBox](listbox.md) 's [ItemContainerStyle](itemscontrol_itemcontainerstyle.md) property to a [Style](../windows.ui.xaml/style.md) with a [TargetType](../windows.ui.xaml/style_targettype.md) of [ListBoxItem](listboxitem.md).

## -examples

## -see-also
[SelectorItem](../windows.ui.xaml.controls.primitives/selectoritem.md), [ListBox](listbox.md), [ItemContainerStyle](itemscontrol_itemcontainerstyle.md), [ListBoxItem styles and templates](https://msdn.microsoft.com/library/d133a9ff-32f4-4b15-b5e2-a538e60d5402)
