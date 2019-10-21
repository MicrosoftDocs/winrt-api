---
-api-id: T:Windows.UI.Xaml.Controls.DatePicker
-api-type: winrt class
---

<!-- Class syntax.
public class DatePicker : Windows.UI.Xaml.Controls.Control, Windows.UI.Xaml.Controls.IDatePicker, Windows.UI.Xaml.Controls.IDatePicker2
-->

# Windows.UI.Xaml.Controls.DatePicker

## -description
Represents a control that allows a user to pick a date value.

## -xaml-syntax
```xaml
<DatePicker .../>

```


## -remarks
Use a DatePicker to let a user enter a date value. The user picks the date using [ComboBox](combobox.md) selection for month, day, and year values. You can customize the DatePicker in various ways to suit your app.

<img src="images/controls/DatePicker.png" alt="Date picker control" />

You can use a [DateTimeFormatter](../windows.globalization.datetimeformatting/datetimeformatter.md) object to format the contents of each [ComboBox](combobox.md) selector. For more info, see [Date picker](https://docs.microsoft.com/windows/uwp/controls-and-patterns/date-picker).

> [!NOTE]
> Some date formats should be avoided if the date picker might be displayed in a small area, such as adding the full string value of the day of week. These strings can be long and might be clipped if the DatePicker's width is forced to be small.

### DateTime and Calendar values

The date objects used in a DatePicker have a different representation depending on your programming language. C# and Visual Basic use the [System.DateTimeOffset](https://docs.microsoft.com/dotnet/api/system.datetimeoffset?redirectedfrom=MSDN) structure that is part of .NET. Visual C++ component extensions (C++/CX) uses the [Windows::Foundation::DateTime](https://docs.microsoft.com/windows/desktop/api/windows.foundation/ns-windows-foundation-datetime) structure. A related concept is the **Calendar** class, which influences how dates are interpreted in context. All Windows Runtime apps can use the [Windows.Globalization.Calendar](../windows.globalization/calendar.md) class. C# and Visual Basic apps can alternatively use the [System.Globalization.Calendar](https://docs.microsoft.com/dotnet/api/system.globalization.calendar?redirectedfrom=MSDN) class, which has very similar functionality. (Windows Runtime app can use the base .NET [Calendar](https://docs.microsoft.com/dotnet/api/system.globalization.calendar?redirectedfrom=MSDN) class but not the specific implementations for example **GregorianCalendar**.)

.NET also supports a type named [DateTime](https://docs.microsoft.com/dotnet/api/system.datetime?redirectedfrom=MSDN), which is implicitly convertible to a [DateTimeOffset](https://docs.microsoft.com/dotnet/api/system.datetimeoffset?redirectedfrom=MSDN). So you might see a "DateTime" type being used in .NET code that's used to set values that are really [DateTimeOffset](https://docs.microsoft.com/dotnet/api/system.datetimeoffset?redirectedfrom=MSDN). For more info on the difference between [DateTime](https://docs.microsoft.com/dotnet/api/system.datetime?redirectedfrom=MSDN) and [DateTimeOffset](https://docs.microsoft.com/dotnet/api/system.datetimeoffset?redirectedfrom=MSDN), see Remarks in [DateTimeOffset](https://docs.microsoft.com/dotnet/api/system.datetimeoffset?redirectedfrom=MSDN).

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](https://docs.microsoft.com/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\ &lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (SDK 14393), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](https://docs.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) section of the [Styling controls](https://docs.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the DatePicker control.

<table>
   <tr><th>Resource key</th><th>Description</th></tr>
   <tr><td>DatePickerSpacerFill</td><td>Spacer color</td></tr>
   <tr><td>DatePickerSpacerFillDisabled</td><td>Spacer color when disabled</td></tr>
   <tr><td>DatePickerHeaderForeground</td><td>Header text color</td></tr>
   <tr><td>DatePickerHeaderForegroundDisabled</td><td>Header text color when disabled</td></tr>
   <tr><td>DatePickerButtonForeground</td><td>Button text color</td></tr>
   <tr><td>DatePickerButtonForegroundPointerOver</td><td>Button text color on hover</td></tr>
   <tr><td>DatePickerButtonForegroundPressed</td><td>Button text color when pressed</td></tr>
   <tr><td>DatePickerButtonForegroundDisabled</td><td>Button text color when disabled</td></tr>
   <tr><td>DatePickerButtonForegroundFocused</td><td>Button text color when focused</td></tr>
   <tr><td>DatePickerButtonBackground</td><td>Button background color at rest</td></tr>
   <tr><td>DatePickerButtonBackgroundPointerOver</td><td>Button background color on hover</td></tr>
   <tr><td>DatePickerButtonBackgroundPressed</td><td>Button background color when pressed</td></tr>
   <tr><td>DatePickerButtonBackgroundDisabled</td><td>Button background color when disabled</td></tr>
   <tr><td>DatePickerButtonBackgroundFocused</td><td>Button background color when focused</td></tr>
   <tr><td>DatePickerButtonBorderBrush</td><td>Button border color at rest</td></tr>
   <tr><td>DatePickerButtonBorderBrushPointerOver</td><td>Button border color on hover</td></tr>
   <tr><td>DatePickerButtonBorderBrushPressed</td><td>Button border color when pressed</td></tr>
   <tr><td>DatePickerButtonBorderBrushDisabled</td><td>Button border color when disabled</td></tr>
   <tr><td>DateTimePickerFlyoutButtonForegroundPointerOver</td><td>Flyout button foreground color on hover</td></tr>
   <tr><td>DateTimePickerFlyoutButtonForegroundPressed</td><td>Flyout button foreground color when pressed</td></tr>
   <tr><td>DateTimePickerFlyoutButtonBackground</td><td>Flyout button background color at rest</td></tr>
   <tr><td>DateTimePickerFlyoutButtonBackgroundPointerOver</td><td>Flyout button background color on hover</td></tr>
   <tr><td>DateTimePickerFlyoutButtonBackgroundPressed</td><td>Flyout button background color when pressed</td></tr>
   <tr><td>DateTimePickerFlyoutButtonBorderBrush</td><td>Flyout button border color at rest</td></tr>
   <tr><td>DateTimePickerFlyoutButtonBorderBrushPointerOver</td><td>Flyout button border color on hover</td></tr>
   <tr><td>DateTimePickerFlyoutButtonBorderBrushPressed</td><td>Flyout button border color when pressed</td></tr>
</table>

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | LightDismissOverlayMode |
| 1809 | 17763 | SelectedDate |
| 1809 | 17763 | SelectedDateChanged |

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Date picker](/windows/uwp/design/controls-and-patterns/date-picker).
>
> If you have the **XAML Controls Gallery** app installed, click here to [open the app and see the DatePicker in action](xamlcontrolsgallery:/item/DatePicker).
> + [Get the XAML Controls Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/Xaml-Controls-Gallery)

## -see-also
[Control](control.md), [DatePicker styles and templates](https://docs.microsoft.com/windows/uwp/design/controls-and-patterns/xaml-styles), [Windows.Globalization.CalendarIdentifiers](../windows.globalization/calendaridentifiers.md), [System.DateTimeOffset (C#/VB)](https://docs.microsoft.com/dotnet/api/system.datetimeoffset?redirectedfrom=MSDN), [Windows::Foundation::DateTime (C++)](https://docs.microsoft.com/windows/desktop/api/windows.foundation/ns-windows-foundation-datetime), [Windows.Globalization.Calendar](../windows.globalization/calendar.md), [TimePicker](timepicker.md), [Controls list](https://docs.microsoft.com/windows/uwp/design/controls-and-patterns/), [Controls by function](https://docs.microsoft.com/windows/uwp/controls-and-patterns/controls-by-function)
