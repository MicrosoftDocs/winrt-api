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
Use a [DatePicker](datepicker.md) to let a user enter a date value. The user picks the date using [ComboBox](combobox.md) selection for month, day, and year values. You can customize the [DatePicker](datepicker.md) in various ways to suit your app.

<img src="images/controls/DatePicker.png" alt="Date picker control" />

You can use a [DateTimeFormatter](../windows.globalization.datetimeformatting/datetimeformatter.md) object to format the contents of each [ComboBox](combobox.md) selector. For more info, see [Date picker](https://docs.microsoft.com/windows/uwp/controls-and-patterns/date-picker).

> [!NOTE]
> Some date formats should be avoided if the date picker might be displayed in a small area, such as adding the full string value of the day of week. These strings can be long and might be clipped if the DatePicker's width is forced to be small.

### DateTime and Calendar values

The date objects used in a [DatePicker](datepicker.md) have a different representation depending on your programming language. C# and Visual Basic use the [System.DateTimeOffset](https://msdn.microsoft.com/library/system.datetimeoffset.aspx) structure that is part of .NET. Visual C++ component extensions (C++/CX) uses the [Windows::Foundation::DateTime](http://msdn.microsoft.com/library/b5533002-8a72-438d-a3d3-0902ffc21830) structure. A related concept is the **Calendar** class, which influences how dates are interpreted in context. All Windows Runtime apps can use the [Windows.Globalization.Calendar](../windows.globalization/calendar.md) class. C# and Visual Basic apps can alternatively use the [System.Globalization.Calendar](https://msdn.microsoft.com/library/system.globalization.calendar.aspx) class, which has very similar functionality. (Windows Runtime app can use the base .NET [Calendar](https://msdn.microsoft.com/library/system.globalization.calendar.aspx) class but not the specific implementations for example **GregorianCalendar**.)

.NET also supports a type named [DateTime](https://msdn.microsoft.com/library/system.datetime.aspx), which is implicitly convertible to a [DateTimeOffset](https://msdn.microsoft.com/library/system.datetimeoffset.aspx). So you might see a "DateTime" type being used in .NET code that's used to set values that are really [DateTimeOffset](https://msdn.microsoft.com/library/system.datetimeoffset.aspx). For more info on the difference between [DateTime](https://msdn.microsoft.com/library/system.datetime.aspx) and [DateTimeOffset](https://msdn.microsoft.com/library/system.datetimeoffset.aspx), see Remarks in [DateTimeOffset](https://msdn.microsoft.com/library/system.datetimeoffset.aspx).

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\&lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (Windows Software Development Kit (SDK) version 10.0.14393.0), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) section of the [Styling controls](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the [DatePicker](datepicker.md) control.

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

## -examples

## -see-also
[Control](control.md), [DatePicker styles and templates](http://msdn.microsoft.com/library/e67b7981-cc6a-473c-bb57-eeacf9241160), [Windows.Globalization.CalendarIdentifiers](../windows.globalization/calendaridentifiers.md), [System.DateTimeOffset (C#/VB)](https://msdn.microsoft.com/library/system.datetimeoffset.aspx), [Windows::Foundation::DateTime (C++)](http://msdn.microsoft.com/library/b5533002-8a72-438d-a3d3-0902ffc21830), [Windows.Globalization.Calendar](../windows.globalization/calendar.md), [TimePicker](timepicker.md), [Controls list](http://msdn.microsoft.com/library/11172840-a63d-4f48-9db4-7baca06308ee), [Controls by function](http://msdn.microsoft.com/library/8db4347b-91d6-4659-91f2-80ecf7bbb596)