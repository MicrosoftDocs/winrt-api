---
-api-id: T:Windows.UI.Xaml.Controls.CheckBox
-api-type: winrt class
---

<!-- Class syntax.
public class CheckBox : Windows.UI.Xaml.Controls.Primitives.ToggleButton, Windows.UI.Xaml.Controls.ICheckBox
-->

# Windows.UI.Xaml.Controls.CheckBox

## -description
Represents a control that a user can select (check) or clear (uncheck). A CheckBox can also report its value as indeterminate.

## -xaml-syntax
```xaml
<CheckBox .../>
-or-
<CheckBox>
  singleObject
</CheckBox>
-or-
<CheckBox>stringContent</CheckBox>
```


## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Check boxes](/windows/uwp/design/controls-and-patterns/checkbox).

CheckBox is a control that a user can select or clear.

<img alt="The 3 states of a check box" src="images/controls/CheckBox_DefaultStates.png" />

Use the CheckBox control to provide a list of options that a user can select, such as a list of settings to apply to an application. Both CheckBox and [RadioButton](radiobutton.md) controls allow the user to select from a list of options. CheckBox controls allow the user to select a combination of options. In contrast, [RadioButton](radiobutton.md) controls allow the user to select from mutually exclusive options.

The CheckBox control inherits from [ToggleButton](../windows.ui.xaml.controls.primitives/togglebutton.md) and can have three states: <table>
   <tr><th>State</th><th>Property</th><th>Value</th></tr>
   <tr><td>checked</td><td>[  IsChecked](../windows.ui.xaml.controls.primitives/togglebutton_ischecked.md)</td><td>**true**</td></tr>
   <tr><td>unchecked</td><td>[  IsChecked](../windows.ui.xaml.controls.primitives/togglebutton_ischecked.md)</td><td>**false**</td></tr>
   <tr><td>indeterminate</td><td>[  IsChecked](../windows.ui.xaml.controls.primitives/togglebutton_ischecked.md)</td><td>**null**</td></tr>
</table>

 For the CheckBox to report the indeterminate state, you must set the [IsThreeState](../windows.ui.xaml.controls.primitives/togglebutton_isthreestate.md) property to **true**.

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](https://docs.microsoft.com/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\ &lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (SDK 14393), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](https://docs.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) section of the [Styling controls](https://docs.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the CheckBox control.

<table>
   <tr><th>Resource key</th><th>Description</th></tr>
   <tr><td>CheckBoxForegroundUnchecked</td><td>Label text color at rest and unchecked</td></tr>
   <tr><td>CheckBoxForegroundUncheckedPointerOver</td><td>Label text color on hover and unchecked</td></tr>
   <tr><td>CheckBoxForegroundUncheckedPressed</td><td>Label text color when pressed and unchecked</td></tr>
   <tr><td>CheckBoxForegroundUncheckedDisabled</td><td>Label text color when disabled and unchecked</td></tr>
   <tr><td>CheckBoxForegroundChecked</td><td>Label text color at rest and checked</td></tr>
   <tr><td>CheckBoxForegroundCheckedPointerOver</td><td>Label text color on hover and checked</td></tr>
   <tr><td>CheckBoxForegroundCheckedPressed</td><td>Label text color when pressed and checked</td></tr>
   <tr><td>CheckBoxForegroundCheckedDisabled</td><td>Label text color when disabled and checked</td></tr>
   <tr><td>CheckBoxForegroundIndeterminate</td><td>Label text color at rest and indeterminate</td></tr>
   <tr><td>CheckBoxForegroundIndeterminatePointerOver</td><td>Label text color on hover and indeterminate</td></tr>
   <tr><td>CheckBoxForegroundIndeterminatePressed</td><td>Label text color when pressed and indeterminate</td></tr>
   <tr><td>CheckBoxForegroundIndeterminateDisabled</td><td>Label text color when disabled and indeterminate</td></tr>
   <tr><td>CheckBoxBackgroundUnchecked</td><td>Background color of entire control at rest and unchecked</td></tr>
   <tr><td>CheckBoxBackgroundUncheckedPointerOver</td><td>Background color of entire control on hover and unchecked</td></tr>
   <tr><td>CheckBoxBackgroundUncheckedPressed</td><td>Background color of entire control when pressed and unchecked</td></tr>
   <tr><td>CheckBoxBackgroundUncheckedDisabled</td><td>Background color of entire control when disabled and unchecked</td></tr>
   <tr><td>CheckBoxBackgroundChecked</td><td>Background color of entire control at rest and checked</td></tr>
   <tr><td>CheckBoxBackgroundCheckedPointerOver</td><td>Background color of entire control on hover and checked</td></tr>
   <tr><td>CheckBoxBackgroundCheckedPressed</td><td>Background color of entire control when pressed and checked</td></tr>
   <tr><td>CheckBoxBackgroundCheckedDisabled</td><td>Background color of entire control when disabled and checked</td></tr>
   <tr><td>CheckBoxBackgroundIndeterminate</td><td>Background color of entire control at rest and indeterminate</td></tr>
   <tr><td>CheckBoxBackgroundIndeterminatePointerOver</td><td>Background color of entire control on hover and indeterminate</td></tr>
   <tr><td>CheckBoxBackgroundIndeterminatePressed</td><td>Background color of entire control when pressed and indeterminate</td></tr>
   <tr><td>CheckBoxBackgroundIndeterminateDisabled</td><td>Background color of entire control when disabled and indeterminate</td></tr>
   <tr><td>CheckBoxBorderBrushUnchecked</td><td>Border color of entire control at rest and unchecked</td></tr>
   <tr><td>CheckBoxBorderBrushUncheckedPointerOver</td><td>Border color of entire control on hover and unchecked</td></tr>
   <tr><td>CheckBoxBorderBrushUncheckedPressed</td><td>Border color of entire control when pressed and unchecked</td></tr>
   <tr><td>CheckBoxBorderBrushUncheckedDisabled</td><td>Border color of entire control when disabled and unchecked</td></tr>
   <tr><td>CheckBoxBorderBrushChecked</td><td>Border color of entire control at rest and checked</td></tr>
   <tr><td>CheckBoxBorderBrushCheckedPointerOver</td><td>Border color of entire control on hover and checked</td></tr>
   <tr><td>CheckBoxBorderBrushCheckedPressed</td><td>Border color of entire control when pressed and checked</td></tr>
   <tr><td>CheckBoxBorderBrushCheckedDisabled</td><td>Border color of entire control when disabled and checked</td></tr>
   <tr><td>CheckBoxBorderBrushIndeterminate</td><td>Border color of entire control at rest and indeterminate</td></tr>
   <tr><td>CheckBoxBorderBrushIndeterminatePointerOver</td><td>Border color of entire control on hover and indeterminate</td></tr>
   <tr><td>CheckBoxBorderBrushIndeterminatePressed</td><td>Border color of entire control when pressed and indeterminate</td></tr>
   <tr><td>CheckBoxBorderBrushIndeterminateDisabled</td><td>Border color of entire control when disabled and indeterminate</td></tr>
   <tr><td>CheckBoxCheckBackgroundStrokeUnchecked</td><td>Border color of checkmark box at rest and unchecked</td></tr>
   <tr><td>CheckBoxCheckBackgroundStrokeUncheckedPointerOver</td><td>Border color of checkmark box on hover and unchecked</td></tr>
   <tr><td>CheckBoxCheckBackgroundStrokeUncheckedPressed</td><td>Border color of checkmark box when pressed and unchecked</td></tr>
   <tr><td>CheckBoxCheckBackgroundStrokeUncheckedDisabled</td><td>Border color of checkmark box when disabled and unchecked</td></tr>
   <tr><td>CheckBoxCheckBackgroundStrokeChecked</td><td>Border color of checkmark box at rest and checked</td></tr>
   <tr><td>CheckBoxCheckBackgroundStrokeCheckedPointerOver</td><td>Border color of checkmark box on hover and checked</td></tr>
   <tr><td>CheckBoxCheckBackgroundStrokeCheckedPressed</td><td>Border color of checkmark box when pressed and checked</td></tr>
   <tr><td>CheckBoxCheckBackgroundStrokeCheckedDisabled</td><td>Border color of checkmark box when disabled and checked</td></tr>
   <tr><td>CheckBoxCheckBackgroundStrokeIndeterminate</td><td>Border color of checkmark box at rest and indeterminate</td></tr>
   <tr><td>CheckBoxCheckBackgroundStrokeIndeterminatePointerOver</td><td>Border color of checkmark box on hover and indeterminate</td></tr>
   <tr><td>CheckBoxCheckBackgroundStrokeIndeterminatePressed</td><td>Border color of checkmark box when pressed and indeterminate</td></tr>
   <tr><td>CheckBoxCheckBackgroundStrokeIndeterminateDisabled</td><td>Border color of checkmark box when disabled and indeterminate</td></tr>
   <tr><td>CheckBoxCheckBackgroundFillUnchecked</td><td>Background color of checkmark box at rest and unchecked</td></tr>
   <tr><td>CheckBoxCheckBackgroundFillUncheckedPointerOver</td><td>Background color of checkmark box on hover and unchecked</td></tr>
   <tr><td>CheckBoxCheckBackgroundFillUncheckedPressed</td><td>Background color of checkmark box when pressed and unchecked</td></tr>
   <tr><td>CheckBoxCheckBackgroundFillUncheckedDisabled</td><td>Background color of checkmark box when disabled and unchecked</td></tr>
   <tr><td>CheckBoxCheckBackgroundFillChecked</td><td>Background color of checkmark box at rest and checked</td></tr>
   <tr><td>CheckBoxCheckBackgroundFillCheckedPointerOver</td><td>Background color of checkmark box on hover and checked</td></tr>
   <tr><td>CheckBoxCheckBackgroundFillCheckedPressed</td><td>Background color of checkmark box when pressed and checked</td></tr>
   <tr><td>CheckBoxCheckBackgroundFillCheckedDisabled</td><td>Background color of checkmark box when disabled and checked</td></tr>
   <tr><td>CheckBoxCheckBackgroundFillIndeterminate</td><td>Background color of checkmark box at rest and indeterminate</td></tr>
   <tr><td>CheckBoxCheckBackgroundFillIndeterminatePointerOver</td><td>Background color of checkmark box on hover and indeterminate</td></tr>
   <tr><td>CheckBoxCheckBackgroundFillIndeterminatePressed</td><td>Background color of checkmark box when pressed and indeterminate</td></tr>
   <tr><td>CheckBoxCheckBackgroundFillIndeterminateDisabled</td><td>Background color of checkmark box when disabled and indeterminate</td></tr>
   <tr><td>CheckBoxCheckGlyphForegroundUnchecked</td><td>Check mark color at rest and unchecked</td></tr>
   <tr><td>CheckBoxCheckGlyphForegroundUncheckedPointerOver</td><td>Check mark color on hover and unchecked</td></tr>
   <tr><td>CheckBoxCheckGlyphForegroundUncheckedPressed</td><td>Check mark color when pressed and unchecked</td></tr>
   <tr><td>CheckBoxCheckGlyphForegroundUncheckedDisabled</td><td>Check mark color when disabled and unchecked</td></tr>
   <tr><td>CheckBoxCheckGlyphForegroundChecked</td><td>Check mark color at rest and checked</td></tr>
   <tr><td>CheckBoxCheckGlyphForegroundCheckedPointerOver</td><td>Check mark color on hover and checked</td></tr>
   <tr><td>CheckBoxCheckGlyphForegroundCheckedPressed</td><td>Check mark color when pressed and checked</td></tr>
   <tr><td>CheckBoxCheckGlyphForegroundCheckedDisabled</td><td>Check mark color when disabled and checked</td></tr>
   <tr><td>CheckBoxCheckGlyphForegroundIndeterminate</td><td>Check mark color at rest and indeterminate</td></tr>
   <tr><td>CheckBoxCheckGlyphForegroundIndeterminatePointerOver</td><td>Check mark color on hover and indeterminate</td></tr>
   <tr><td>CheckBoxCheckGlyphForegroundIndeterminatePressed</td><td>Check mark color when pressed and indeterminate</td></tr>
   <tr><td>CheckBoxCheckGlyphForegroundIndeterminateDisabled</td><td>Check mark color when disabled and indeterminate</td></tr>
</table>

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Check boxes](/windows/uwp/design/controls-and-patterns/checkbox).
>
> If you have the **XAML Controls Gallery** app installed, click here to [open the app and see the CheckBox in action](xamlcontrolsgallery:/item/CheckBox).
> + [Get the XAML Controls Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/Xaml-Controls-Gallery)

The following example shows two check box controls. The first check box demonstrates the checked and unchecked states. The second check box demonstrates the checked, unchecked, and indeterminate states. You can select the controls to change their appearance and see which state they are in.

[!code-xml[1](../windows.ui.xaml.data/code/System.Windows.Controls.CheckBoxEx/csharp/Page.xaml#Snippet1)]

[!code-csharp[11](../windows.ui.xaml.data/code/System.Windows.Controls.CheckBoxEx/csharp/Page.xaml.cs#Snippet11)]

[!code-vb[11](../windows.ui.xaml.data/code/System.Windows.Controls.CheckBoxEx/vbnet/Page.xaml.vb#Snippet11)]

<img alt="The 3 states of a check box" src="images/CheckBox_3State.png" />

```xaml
<StackPanel>
    <CheckBox x:Name="OptionsAllCheckBox" Content="Select all" IsThreeState="True" 
              Checked="SelectAll_Checked" Unchecked="SelectAll_Unchecked" Indeterminate="SelectAll_Indeterminate"/>
    <CheckBox x:Name="Option1CheckBox" Content="Option 1" Margin="24,0,0,0" 
              Checked="Option_Checked" Unchecked="Option_Unchecked"/>
    <CheckBox x:Name="Option2CheckBox" Content="Option 2" Margin="24,0,0,0" 
              Checked="Option_Checked" Unchecked="Option_Unchecked" IsChecked="True"/>
    <CheckBox x:Name="Option3CheckBox" Content="Option 3" Margin="24,0,0,0"
              Checked="Option_Checked" Unchecked="Option_Unchecked"/>
</StackPanel>
```

```csharp
private void SelectAll_Checked(object sender, RoutedEventArgs e)
{
    Option1CheckBox.IsChecked = Option2CheckBox.IsChecked = Option3CheckBox.IsChecked = true;
}

private void SelectAll_Unchecked(object sender, RoutedEventArgs e)
{
    Option1CheckBox.IsChecked = Option2CheckBox.IsChecked = Option3CheckBox.IsChecked = false;
}

private void SelectAll_Indeterminate(object sender, RoutedEventArgs e)
{
    // If the SelectAll box is checked (all options are selected), 
    // clicking the box will change it to its indeterminate state.
    // Instead, we want to uncheck all the boxes,
    // so we do this programatically. The indeterminate state should
    // only be set programatically, not by the user.

    if (Option1CheckBox.IsChecked == true &&
        Option2CheckBox.IsChecked == true &&
        Option3CheckBox.IsChecked == true)
    {
        // This will cause SelectAll_Unchecked to be executed, so
        // we don't need to uncheck the other boxes here.
        OptionsAllCheckBox.IsChecked = false;
    }
}

private void SetCheckedState()
{
    // Controls are null the first time this is called, so we just 
    // need to perform a null check on any one of the controls.
    if (Option1CheckBox != null)
    {
        if (Option1CheckBox.IsChecked == true &&
            Option2CheckBox.IsChecked == true &&
            Option3CheckBox.IsChecked == true)
        {
            OptionsAllCheckBox.IsChecked = true;
        }
        else if (Option1CheckBox.IsChecked == false &&
            Option2CheckBox.IsChecked == false &&
            Option3CheckBox.IsChecked == false)
        {
            OptionsAllCheckBox.IsChecked = false;
        }
        else
        {
            // Set third state (indeterminate) by setting IsChecked to null.
            OptionsAllCheckBox.IsChecked = null;
        }
    }
}

private void Option_Checked(object sender, RoutedEventArgs e)
{
    SetCheckedState();
}

private void Option_Unchecked(object sender, RoutedEventArgs e)
{
    SetCheckedState();
} 
```



## -see-also
[Check boxes overview](https://docs.microsoft.com/windows/uwp/controls-and-patterns/checkbox), [CheckBox styles and templates](https://docs.microsoft.com/windows/uwp/design/controls-and-patterns/xaml-styles), [RadioButton](radiobutton.md), [ToggleButton](../windows.ui.xaml.controls.primitives/togglebutton.md), [Controls list](https://docs.microsoft.com/windows/uwp/design/controls-and-patterns/), [Controls by function](https://docs.microsoft.com/windows/uwp/controls-and-patterns/controls-by-function)
p://msdn.microsoft.com/library/8db4347b-91d6-4659-91f2-80ecf7bbb596)
