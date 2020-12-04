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

Equivalent WinUI class: [Microsoft.UI.Xaml.Controls.ListBoxItem](/windows/winui/api/microsoft.ui.xaml.controls.listboxitem).

## -xaml-syntax
```xaml
<ListBoxItem .../>
-or-
<ListBoxItem ...>
  content
</ListBoxItem>
```

## -remarks
The ListBoxItem class provides the container for items displayed in a [ListBox](listbox.md) control. You populate the [ListBox](listbox.md) by adding ListBoxItems directly to its [Items](itemscontrol_items.md) collection or by binding its [ItemsSource](itemscontrol_itemssource.md) property to a data source. When items are added to the [ListBox](listbox.md), a ListBoxItem container is created automatically for each item in the collection.

You can specify the look of the ListBoxItem by setting the [ListBox](listbox.md)'s [ItemContainerStyle](itemscontrol_itemcontainerstyle.md) property to a [Style](../windows.ui.xaml/style.md) with a [TargetType](../windows.ui.xaml/style_targettype.md) of ListBoxItem.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [List boxes](/windows/uwp/design/controls-and-patterns/lists#list-boxes).
>
> If you have the **XAML Controls Gallery** app installed, click here to [open the app and see the ListBox in action](xamlcontrolsgallery:/item/ListBox).
> + [Get the XAML Controls Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/Xaml-Controls-Gallery)

## -see-also

[SelectorItem](../windows.ui.xaml.controls.primitives/selectoritem.md), [ListBox](listbox.md), [ItemContainerStyle](itemscontrol_itemcontainerstyle.md), [ListBoxItem styles and templates](/windows/uwp/design/controls-and-patterns/xaml-styles)
