---
-api-id: T:Windows.UI.Xaml.Controls.ComboBox
-api-type: winrt class
---

<!-- Class syntax.
public class ComboBox : Windows.UI.Xaml.Controls.Primitives.Selector, Windows.UI.Xaml.Controls.IComboBox, Windows.UI.Xaml.Controls.IComboBox2, Windows.UI.Xaml.Controls.IComboBox3, Windows.UI.Xaml.Controls.IComboBoxOverrides
-->

# Windows.UI.Xaml.Controls.ComboBox

## -description
Represents a selection control that combines a non-editable text box and a drop-down list box that allows users to select an item from a list.

## -xaml-syntax
```xaml
<ComboBox .../>
```


## -remarks
[ComboBox](combobox.md) presents a drop-down list of items a user can select from.

<img alt="Open combo box" src="images/controls/ComboBoxBasicOpen.png" />

Use a [ComboBox](combobox.md) to present a list of items that a user can select from. When the [ComboBox](combobox.md) is closed, it either displays the current selection or is empty if there is no selected item. When the [ComboBox](combobox.md) is open, it displays the list of selectable items. You can get or set the combo box's selected item by using the [SelectedItem](../windows.ui.xaml.controls.primitives/selector_selecteditem.md) property, and get or set the index of the selected item by using the [SelectedIndex](../windows.ui.xaml.controls.primitives/selector_selectedindex.md) property.

You populate the [ComboBox](combobox.md) by adding objects directly to the [Items](itemscontrol_items.md) collection or by binding the [ItemsSource](itemscontrol_itemssource.md) property to a data source. Items added to the [ComboBox](combobox.md) are wrapped in [ComboBoxItem](comboboxitem.md) containers.



> [!NOTE]
> [ComboBox](combobox.md) uses a [CarouselPanel](../windows.ui.xaml.controls.primitives/carouselpanel.md) as its [ItemsPanel](itemscontrol_itemspanel.md). Using a different panel as the [ItemsPanel](itemscontrol_itemspanel.md) is not supported and might result in undesired behavior.

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\&lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (Windows Software Development Kit (SDK) version 10.0.14393.0), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) section of the [Styling controls](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the [ComboBox](combobox.md) control.

<table>
   <tr><th>Resource key</th><th>Description</th></tr>
   <tr><td>ComboBoxBackground</td><td>Background color at rest</td></tr>
   <tr><td>ComboBoxBackgroundPointerOver</td><td>Background color on hover</td></tr>
   <tr><td>ComboBoxBackgroundPressed</td><td>Background color when pressed</td></tr>
   <tr><td>ComboBoxBackgroundDisabled</td><td>Background color when disabled</td></tr>
   <tr><td>ComboBoxBackgroundUnfocused</td><td>Background color when unfocused</td></tr>
   <tr><td>ComboBoxBackgroundBorderBrushFocused</td><td>Border color around box after item has been selected and control has focus</td></tr>
   <tr><td>ComboBoxBackgroundBorderBrushUnfocused</td><td>Border color around box after item has been selected and control is unfocused</td></tr>
   <tr><td>ComboBoxForeground</td><td>Text color of selected item at rest</td></tr>
   <tr><td>ComboBoxForegroundDisabled</td><td>Text color of selected item when disabled</td></tr>
   <tr><td>ComboBoxForegroundFocused</td><td>Text color of selected item when focused</td></tr>
   <tr><td>ComboBoxForegroundFocusedPressed</td><td>Text color of selected item pressed and focused</td></tr>
   <tr><td>ComboBoxPlaceHolderForeground</td><td>Placeholder text color</td></tr>
   <tr><td>ComboBoxPlaceHolderForegroundFocusedPressed</td><td>Placeholder text color when pressed and focused</td></tr>
   <tr><td>ComboBoxBorderBrush</td><td>Border color at rest</td></tr>
   <tr><td>ComboBoxBorderBrushPointerOver</td><td>Border color on hover</td></tr>
   <tr><td>ComboBoxBorderBrushPressed</td><td>Border color when pressed</td></tr>
   <tr><td>ComboBoxBorderBrushDisabled</td><td>Border color when disabled</td></tr>
   <tr><td>ComboBoxDropDownGlyphForeground</td><td>Drop down arrow color at rest</td></tr>
   <tr><td>ComboBoxDropDownGlyphForegroundDisabled</td><td>Drop down arrow color when disabled</td></tr>
   <tr><td>ComboBoxDropDownGlyphForegroundFocused</td><td>Drop down arrow color when focused</td></tr>
   <tr><td>ComboBoxDropDownGlyphForegroundFocusedPressed</td><td>Drop down arrow color when focused and pressed</td></tr>
   <tr><td>ComboBoxDropDownBackground</td><td>Background color of drop down arrow control bounds</td></tr>
   <tr><td>ComboBoxDropDownForeground</td><td>Not used</td></tr>
   <tr><td>ComboBoxDropDownBorderBrush</td><td>Border color around control's popup when selecting items</td></tr>
</table>

## -examples
The following example demonstrates binding a [ComboBox](combobox.md) to a collection of [FontFamily](../windows.ui.xaml.media/fontfamily.md) objects.

```xaml
<ComboBox x:Name="FontsCombo" Header="Fonts" Height="44" Width="296" 
          ItemsSource="{x:Bind fonts}" DisplayMemberPath="Source"/>
```




<!--<auto_snippet sample_id="ComboBoxBoundEx" snippet_id="1"/>-->
```csharp
ObservableCollection<FontFamily> fonts = new ObservableCollection<FontFamily>();

public MainPage()
{
    this.InitializeComponent();
    fonts.Add(new FontFamily("Arial"));
    fonts.Add(new FontFamily("Courier New"));
    fonts.Add(new FontFamily("Times New Roman"));
}

```


<!--<auto_snippet sample_id="ComboBoxBoundEx" snippet_id="2"/>-->

## -see-also
[Selector](../windows.ui.xaml.controls.primitives/selector.md), [ComboBox styles and templates](http://msdn.microsoft.com/library/42b25b93-a015-4446-bf57-3effdc164171), [ListBox](listbox.md), [Controls list](http://msdn.microsoft.com/library/11172840-a63d-4f48-9db4-7baca06308ee), [Controls by function](http://msdn.microsoft.com/library/8db4347b-91d6-4659-91f2-80ecf7bbb596)