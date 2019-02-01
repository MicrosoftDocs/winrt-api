---
-api-id: T:Windows.UI.Xaml.Controls.TimePicker
-api-type: winrt class
---

<!-- Class syntax.
public class TimePicker : Windows.UI.Xaml.Controls.Control, Windows.UI.Xaml.Controls.ITimePicker, Windows.UI.Xaml.Controls.ITimePicker2
-->

# Windows.UI.Xaml.Controls.TimePicker

## -description
Represents a control that allows a user to pick a time value.

## -xaml-syntax
```xaml
<TimePicker .../>

```


## -remarks
[TimePicker](timepicker.md) is a control that lets a user set a time value.

<img src="images/controls/TimePicker.png" alt="TimePicker control" />

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\&lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (Windows Software Development Kit (SDK) version 10.0.14393.0), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) section of the [Styling controls](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the [TimePicker](timepicker.md) control.

<table>
   <tr><th>Resource key</th><th>Description</th></tr>
   <tr><td>TimePickerSpacerFill</td><td>Spacer color</td></tr>
   <tr><td>TimePickerSpacerFillDisabled</td><td>Spacer color when disabled</td></tr>
   <tr><td>TimePickerHeaderForeground</td><td>Header text color</td></tr>
   <tr><td>TimePickerHeaderForegroundDisabled</td><td>Header text color when disabled</td></tr>
   <tr><td>TimePickerButtonForeground</td><td>Button text color</td></tr>
   <tr><td>TimePickerButtonForegroundPointerOver</td><td>Button text color on hover</td></tr>
   <tr><td>TimePickerButtonForegroundPressed</td><td>Button text color when pressed</td></tr>
   <tr><td>TimePickerButtonForegroundDisabled</td><td>Button text color when disabled</td></tr>
   <tr><td>TimePickerButtonForegroundFocused</td><td>Button text color when focused</td></tr>
   <tr><td>TimePickerButtonBackground</td><td>Button background color at rest</td></tr>
   <tr><td>TimePickerButtonBackgroundPointerOver</td><td>Button background color on hover</td></tr>
   <tr><td>TimePickerButtonBackgroundPressed</td><td>Button background color when pressed</td></tr>
   <tr><td>TimePickerButtonBackgroundDisabled</td><td>Button background color when disabled</td></tr>
   <tr><td>TimePickerButtonBackgroundFocused</td><td>Button background color when focused</td></tr>
   <tr><td>TimePickerButtonBorderBrush</td><td>Button border color at rest</td></tr>
   <tr><td>TimePickerButtonBorderBrushPointerOver</td><td>Button border color on hover</td></tr>
   <tr><td>TimePickerButtonBorderBrushPressed</td><td>Button border color when pressed</td></tr>
   <tr><td>TimePickerButtonBorderBrushDisabled</td><td>Button border color when disabled</td></tr>
   <tr><td>DateTimePickerFlyoutButtonForegroundPointerOver</td><td>Flyout button foreground color on hover</td></tr>
   <tr><td>DateTimePickerFlyoutButtonForegroundPressed</td><td>Flyout button foreground color when pressed</td></tr>
   <tr><td>DateTimePickerFlyoutButtonBackground</td><td>Flyout button background color at rest</td></tr>
   <tr><td>DateTimePickerFlyoutButtonBackgroundPointerOver</td><td>Flyout button background color on hover</td></tr>
   <tr><td>DateTimePickerFlyoutButtonBackgroundPressed</td><td>Flyout button background color when pressed</td></tr>
   <tr><td>DateTimePickerFlyoutButtonBorderBrush</td><td>Flyout button border color at rest</td></tr>
   <tr><td>DateTimePickerFlyoutButtonBorderBrushPointerOver</td><td>Flyout button border color on hover</td></tr>
   <tr><td>DateTimePickerFlyoutButtonBorderBrushPressed</td><td>Flyout button border color when pressed</td></tr>
</table>

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Time picker](/windows/uwp/design/controls-and-patterns/time-picker).
>
> If you have the **XAML Controls Gallery** app installed, click here to [open the app and see the TimePicker in action](xamlcontrolsgallery:/item/TimePicker).
> + [Get the XAML Controls Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/Xaml-Controls-Gallery)

## -see-also
[Time picker overview](/windows/uwp/design/controls-and-patterns/time-picker), [Windows.Globalization.ClockIdentifiers](../windows.globalization/clockidentifiers.md), [System.TimeSpan (C#/VB)](https://msdn.microsoft.com/library/system.timespan.aspx), [Windows::Foundation::TimeSpan (C++)](https://msdn.microsoft.com/library/fbc6ecc2-6372-4b15-9532-3cd68a72e7b4), [DatePicker](datepicker.md), [Controls list](https://msdn.microsoft.com/library/11172840-a63d-4f48-9db4-7baca06308ee), [Controls by function](https://msdn.microsoft.com/library/8db4347b-91d6-4659-91f2-80ecf7bbb596)
