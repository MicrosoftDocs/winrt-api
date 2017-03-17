---
-api-id: T:Windows.UI.Xaml.Controls.ListBox
-api-type: winrt class
---

<!-- Class syntax.
public class ListBox : Windows.UI.Xaml.Controls.Primitives.Selector, Windows.UI.Xaml.Controls.IListBox, Windows.UI.Xaml.Controls.IListBox2
-->

# Windows.UI.Xaml.Controls.ListBox

## -description
Presents a list of items the user can select from.

## -xaml-syntax
```xaml
<ListBox .../>
-or-
<ListBox ...>
  oneOrMoreItems
</ListBox>
```

## -remarks
[ListBox](listbox.md) lets users select from a pre-defined list of options presented like a text control. Use a [ListBox](listbox.md) when you want the options to be visible all the time or when users can select more than one option at a time. [ListBox](listbox.md) controls are always open, so several items can be displayed without user interaction.

<img alt="List box control" src="images/controls/ListBox.png" />

> [!NOTE]
> ListBox is useful when you are upgrading a Universal Windows 8 app that uses ListBox, and need to minimize changes. For new apps in Windows 10, we recommend using the [ListView](listview.md) control instead.

### Using a ListBox

Use a [ListBox](listbox.md) control to present a list of items that a user can select from. More than one item in a [ListBox](listbox.md) control is visible at a time. You specify whether the [ListBox](listbox.md) control allows multiple selections by setting the [SelectionMode](listbox_selectionmode.md) property. You can get or set the selected items for the list box by using the [SelectedItems](listbox_selecteditems.md) property.

### Populating a ListBox

You populate the [ListBox](listbox.md) control by adding [UIElement](../windows.ui.xaml/uielement.md) items directly to the [Items](itemscontrol_items.md) collection, or by binding the [ItemsSource](itemscontrol_itemssource.md) property to a data source. [ItemsSource](itemscontrol_itemssource.md) items from data will initially clear the [Items](itemscontrol_items.md) collection when the binding is evaluated, so don't set both properties.

[ListBox](listbox.md) has a dedicated control for its items, [ListBoxItem](listboxitem.md). But when you populate the [Items](itemscontrol_items.md) collection, you can use elements or data, you don't typically use explicit [ListBoxItem](listboxitem.md) objects. What happens internally is that when the [ListBox](listbox.md) composes its visual tree from its templates, specifically when expanding the [ItemTemplate](itemscontrol_itemtemplate.md), it creates a [ListBoxItem](listboxitem.md) wrapper for each of the objects it's including as items. At run time, the [Items](itemscontrol_items.md) collection still contains the original items you declared. The created [ListBoxItem](listboxitem.md) wrappers are deeper in the visual tree, inside the items panel (see [ItemsPanel](itemscontrol_itemspanel.md)) as its children. You don't usually need direct access to a [ListBoxItem](listboxitem.md) object. But if you want to access the created [ListBoxItem](listboxitem.md) wrappers, you can use Microsoft UI Automation techniques, or use [VisualTreeHelper](../windows.ui.xaml.media/visualtreehelper.md) APIs, to walk into the object tree representation and find them.

### ListBox vs. ListView and GridView

[ListBox](listbox.md) has many similarities with [ListView](listview.md) or [GridView](gridview.md) (they share the parent class [ItemsControl](itemscontrol.md)), but each control is oriented towards different scenarios. [ListBox](listbox.md) is best for general UI composition, particularly when the elements are always intended to be selectable, whereas [ListView](listview.md) or [GridView](gridview.md) are best for data binding scenarios, particularly if virtualization or large data sets are involved. For more info on virtualization, see [Using virtualization with a list or grid](http://msdn.microsoft.com/library/c6f8727a-2a3a-4f0d-9a5a-82780994839f).

## -examples
This example demonstrates how to add a collection of [FontFamily](../windows.ui.xaml.media/fontfamily.md) objects directly to a [ListBox](listbox.md) control.

```xaml
<ListBox>
    <TextBlock Text="Arial" FontFamily="Arial"/>
    <TextBlock Text="Courier New" FontFamily="Courier New"/> 
    <TextBlock Text="Times New Roman" FontFamily="Times New Roman"/>
</ListBox>
```

This example uses data binding to fill a [ListBox](listbox.md) control with a collection of [FontFamily](../windows.ui.xaml.media/fontfamily.md) objects.

```xaml

<ListBox x:Name="FontsList" Height="20" Width="150" 
         ItemsSource="{x:Bind fonts}" DisplayMemberPath="Source"/>

```

```csharp

ObservableCollection<FontFamily> fonts = new ObservableCollection<FontFamily>();

public BlankPage()
{
    this.InitializeComponent();
    fonts.Add(new FontFamily("Arial"));
    fonts.Add(new FontFamily("Courier New"));
    fonts.Add(new FontFamily("Times New Roman"));
}
```

```vbnet

Dim fonts As New ObservableCollection(of FontFamily) 

Public Sub New()
    MyBase.New()
    InitializeComponent()    
    fonts.Add(New FontFamily("Arial"))
    fonts.Add(New FontFamily("Courier New"))
    fonts.Add(New FontFamily("Times New Roman"))
End Sub
```



## -see-also
[Selector](../windows.ui.xaml.controls.primitives/selector.md), [ItemsControl](itemscontrol.md), [ListBoxItem](listboxitem.md), [ListBox styles and templates](http://msdn.microsoft.com/library/5eb7a713-4669-4da4-b6bb-73acf064d323), [ComboBox](combobox.md), [Controls list](http://msdn.microsoft.com/library/11172840-a63d-4f48-9db4-7baca06308ee), [Controls by function](http://msdn.microsoft.com/library/8db4347b-91d6-4659-91f2-80ecf7bbb596)