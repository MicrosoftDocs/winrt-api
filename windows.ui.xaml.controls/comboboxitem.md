---
-api-id: T:Windows.UI.Xaml.Controls.ComboBoxItem
-api-type: winrt class
---

<!-- Class syntax.
public class ComboBoxItem : Windows.UI.Xaml.Controls.Primitives.SelectorItem, Windows.UI.Xaml.Controls.IComboBoxItem
-->

# Windows.UI.Xaml.Controls.ComboBoxItem

## -description
Represents the container for an item in a [ComboBox](combobox.md) control.

## -xaml-syntax
```xaml
<ComboBoxItem .../>
-or-
<ComboBoxItem ...>
  content
</ComboBoxItem>
```


## -remarks
The ComboBoxItem class provides the container for items displayed in a [ComboBox](combobox.md) control. You populate the [ComboBox](combobox.md) by adding objects directly to its [Items](itemscontrol_items.md) collection or by binding its [ItemsSource](itemscontrol_itemssource.md) property to a data source. When items are added to the [ComboBox](combobox.md), a ComboBoxItem container is created automatically for each item in the collection.

You can specify the look of the ComboBoxItem by setting the [ComboBox](combobox.md) 's [ItemContainerStyle](itemscontrol_itemcontainerstyle.md) property to a [Style](../windows.ui.xaml/style.md) with a [TargetType](../windows.ui.xaml/style_targettype.md) of ComboBoxItem.

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](https://docs.microsoft.com/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\ &lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (SDK 14393), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](https://docs.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) section of the [Styling controls](https://docs.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the ComboBoxItem control.

<table>
   <tr><th>Resource key</th><th>Description</th></tr>
   <tr><td>ComboBoxItemForeground</td><td>Text color at rest</td></tr>
   <tr><td>ComboBoxItemForegroundPointerOver</td><td>Text color on hover</td></tr>
   <tr><td>ComboBoxItemForegroundPressed</td><td>Text color when pressed</td></tr>
   <tr><td>ComboBoxItemForegroundDisabled</td><td>Text color when disabled</td></tr>
   <tr><td>ComboBoxItemForegroundSelected</td><td>Text color when selected</td></tr>
   <tr><td>ComboBoxItemForegroundSelectedUnfocused</td><td>Text color when unfocused and selected</td></tr>
   <tr><td>ComboBoxItemForegroundSelectedPointerOver</td><td>Text color on hover and selected</td></tr>
   <tr><td>ComboBoxItemForegroundSelectedPressed</td><td>Text color when pressed and selected</td></tr>
   <tr><td>ComboBoxItemForegroundSelectedDisabled</td><td>Text color when disabled and selected</td></tr>
   <tr><td>ComboBoxItemBackground</td><td>Background color at rest</td></tr>
   <tr><td>ComboBoxItemBackgroundPointerOver</td><td>Background color on hover</td></tr>
   <tr><td>ComboBoxItemBackgroundPressed</td><td>Background color when pressed</td></tr>
   <tr><td>ComboBoxItemBackgroundDisabled</td><td>Background color when disabled</td></tr>
   <tr><td>ComboBoxItemBackgroundSelected</td><td>Background color when selected</td></tr>
   <tr><td>ComboBoxItemBackgroundSelectedUnfocused</td><td>Background color when unfocused and selected</td></tr>
   <tr><td>ComboBoxItemBackgroundSelectedPointerOver</td><td>Background color on hover and selected</td></tr>
   <tr><td>ComboBoxItemBackgroundSelectedPressed</td><td>Background color when pressed and selected</td></tr>
   <tr><td>ComboBoxItemBackgroundSelectedDisabled</td><td>Background color when disabled and selected</td></tr>
   <tr><td>ComboBoxItemBorderBrush</td><td>Border color at rest</td></tr>
   <tr><td>ComboBoxItemBorderBrushPointerOver</td><td>Border color on hover</td></tr>
   <tr><td>ComboBoxItemBorderBrushPressed</td><td>Border color when pressed</td></tr>
   <tr><td>ComboBoxItemBorderBrushDisabled</td><td>Border color when disabled</td></tr>
   <tr><td>ComboBoxItemBorderBrushSelected</td><td>Border color when selected</td></tr>
   <tr><td>ComboBoxItemBorderBrushSelectedUnfocused</td><td>Border color when unfocused and selected</td></tr>
   <tr><td>ComboBoxItemBorderBrushSelectedPointerOver</td><td>Border color on hover and selected</td></tr>
   <tr><td>ComboBoxItemBorderBrushSelectedPressed</td><td>Border color when pressed and selected</td></tr>
   <tr><td>ComboBoxItemBorderBrushSelectedDisabled</td><td>Border color when disabled and selected</td></tr>
</table>

## -examples

## -see-also
[SelectorItem](../windows.ui.xaml.controls.primitives/selectoritem.md), [ComboBox](combobox.md), [ItemContainerStyle](itemscontrol_itemcontainerstyle.md), [ComboBoxItem styles and templates](https://docs.microsoft.com/windows/uwp/design/controls-and-patterns/xaml-styles)
