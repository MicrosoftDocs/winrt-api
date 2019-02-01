---
-api-id: T:Windows.UI.Xaml.Controls.Slider
-api-type: winrt class
---

<!-- Class syntax.
public class Slider : Windows.UI.Xaml.Controls.Primitives.RangeBase, Windows.UI.Xaml.Controls.ISlider, Windows.UI.Xaml.Controls.ISlider2
-->

# Windows.UI.Xaml.Controls.Slider

## -description
Represents a control that lets the user select from a range of values by moving a [Thumb](../windows.ui.xaml.controls.primitives/thumb.md) control along a track.

## -xaml-syntax
```xaml
<Slider .../>
```


## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Sliders](/windows/uwp/design/controls-and-patterns/slider).

[Slider](slider.md) is a control that lets the user select from a range of values by moving a [Thumb](../windows.ui.xaml.controls.primitives/thumb.md) control along a track.

<img alt="Slider control" src="images/controls/Slider.png" />

Use a [Slider](slider.md) control when you want your users to be able to set defined, contiguous values (such as volume or brightness) or a range of discrete values (such as screen resolution settings). [Slider](slider.md) s are for user interaction. If a user can't ever change the value, use read-only text instead. For more information on when to use a [Slider](slider.md), see [Guidelines for sliders](https://msdn.microsoft.com/library/7ec7ea33-be7e-4fd5-b205-b8fa7b729acc).

### Binding Minimum and Maximum values

> [!NOTE]
> When binding [Minimum](../windows.ui.xaml.controls.primitives/rangebase_minimum.md) and [Maximum](../windows.ui.xaml.controls.primitives/rangebase_maximum.md) values in Extensible Application Markup Language (XAML), declare the [Binding](../windows.ui.xaml.data/binding.md) for [Maximum](../windows.ui.xaml.controls.primitives/rangebase_maximum.md) first. If the [Binding](../windows.ui.xaml.data/binding.md) for [Maximum](../windows.ui.xaml.controls.primitives/rangebase_maximum.md) is declared after [Minimum](../windows.ui.xaml.controls.primitives/rangebase_minimum.md), the bound value for [Maximum](../windows.ui.xaml.controls.primitives/rangebase_maximum.md) is ignored and the following situations can occur: + If the bound [Minimum](../windows.ui.xaml.controls.primitives/rangebase_minimum.md) value is negative, the [Maximum](../windows.ui.xaml.controls.primitives/rangebase_maximum.md) value is set to 0.
+ If the bound [Minimum](../windows.ui.xaml.controls.primitives/rangebase_minimum.md) value is greater than the default [Maximum](../windows.ui.xaml.controls.primitives/rangebase_maximum.md) (100 for [Slider](slider.md) and [ProgressBar](progressbar.md)), the [Maximum](../windows.ui.xaml.controls.primitives/rangebase_maximum.md) value is set equal to the [Minimum](../windows.ui.xaml.controls.primitives/rangebase_minimum.md) value.
To avoid this behavior, declare the [Binding](../windows.ui.xaml.data/binding.md) for [Maximum](../windows.ui.xaml.controls.primitives/rangebase_maximum.md) first in your Extensible Application Markup Language (XAML).

These behaviors can also occur if you set the [Minimum](../windows.ui.xaml.controls.primitives/rangebase_minimum.md) value without also explicitly setting the [Maximum](../windows.ui.xaml.controls.primitives/rangebase_maximum.md) value.

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. To change certain aspects of the slider’s appearance, such as the [Thumb](../windows.ui.xaml.controls.primitives/thumb.md) color, you need to retemplate the control (or use the resources in the table below on Windows 10, version 1607 or later). For information about modifying a control's style and template, see [Styling controls](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\&lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (Windows Software Development Kit (SDK) version 10.0.14393.0), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) section of the [Styling controls](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the [Slider](slider.md) control.

<table>
   <tr><th>Resource key</th><th>Description</th></tr>
   <tr><td>SliderContainerBackground</td><td>Background color at rest</td></tr>
   <tr><td>SliderContainerBackgroundPointerOver</td><td>Background color on hover</td></tr>
   <tr><td>SliderContainerBackgroundPressed</td><td>Background color when pressed</td></tr>
   <tr><td>SliderContainerBackgroundDisabled</td><td>Background color when disabled</td></tr>
   <tr><td>SliderThumbBackground</td><td>Background color of the thumb at rest</td></tr>
   <tr><td>SliderThumbBackgroundPointerOver</td><td>Background color of the thumb on hover</td></tr>
   <tr><td>SliderThumbBackgroundPressed</td><td>Background color of the thumb when pressed</td></tr>
   <tr><td>SliderThumbBackgroundDisabled</td><td>Background color of the thumb when disabled</td></tr>
   <tr><td>SliderTrackFill</td><td>Color of unfilled portion of track</td></tr>
   <tr><td>SliderTrackFillPointerOver</td><td>Color of unfilled portion of track on hover</td></tr>
   <tr><td>SliderTrackFillPressed</td><td>Color of unfilled portion of track when pressed</td></tr>
   <tr><td>SliderTrackFillDisabled</td><td>Color of unfilled portion of track when disabled</td></tr>
   <tr><td>SliderTrackValueFill</td><td>Color of filled portion of track</td></tr>
   <tr><td>SliderTrackValueFillPointerOver</td><td>Color of filled portion of track on hover</td></tr>
   <tr><td>SliderTrackValueFillPressed</td><td>Color of filled portion of track when pressed</td></tr>
   <tr><td>SliderTrackValueFillDisabled</td><td>Color of filled portion of track when disabled</td></tr>
   <tr><td>SliderHeaderForeground</td><td>Foreground color of the label</td></tr>
   <tr><td>SliderHeaderForegroundDisabled</td><td>Foreground color of the label when disabled</td></tr>
   <tr><td>SliderTickBarFill</td><td>Color of the tick marks</td></tr>
   <tr><td>SliderTickBarFillDisabled</td><td>Color of the tick marks when disabled</td></tr>
   <tr><td>SliderInlineTickBarFill</td><td>Color of inline tick marks</td></tr>
</table>

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Sliders](/windows/uwp/design/controls-and-patterns/slider).
>
> If you have the **XAML Controls Gallery** app installed, click here to [open the app and see the Slider in action](xamlcontrolsgallery:/item/Slider).
> + [Get the XAML Controls Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/Xaml-Controls-Gallery)

The following code example shows several slider controls and how to handle the [ValueChanged](../windows.ui.xaml.controls.primitives/rangebase_valuechanged.md) event. The [ValueChanged](../windows.ui.xaml.controls.primitives/rangebase_valuechanged.md) event is used to update the value of a [TextBlock](textblock.md) as the [Value](../windows.ui.xaml.controls.primitives/rangebase_value.md) property of the slider changes.



[!code-xml[1](../windows.ui.xaml.data/code/System.Windows.Controls.Extended.SliderSL/csharp/Page.xaml#Snippet1)]

[!code-csharp[11](../windows.ui.xaml.data/code/System.Windows.Controls.Extended.SliderSL/csharp/Page.xaml.cs#Snippet11)]

[!code-vb[11](../windows.ui.xaml.data/code/System.Windows.Controls.Extended.SliderSL/vbnet/Page.xaml.vb#Snippet11)]

## -see-also
[Sliders overview](https://docs.microsoft.com/windows/uwp/controls-and-patterns/slider), [Slider styles and templates](https://msdn.microsoft.com/library/beef17b1-50bb-49e5-83c3-59645cb36389), [RangeBase](../windows.ui.xaml.controls.primitives/rangebase.md), [ComboBox](combobox.md), [ListBox](listbox.md), [Controls list](https://msdn.microsoft.com/library/11172840-a63d-4f48-9db4-7baca06308ee), [Controls by function](https://msdn.microsoft.com/library/8db4347b-91d6-4659-91f2-80ecf7bbb596)
