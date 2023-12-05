---
-api-id: T:Windows.UI.Xaml.Controls.CalendarDatePicker
-api-type: winrt class
---

<!-- Class syntax.
public class CalendarDatePicker : Windows.UI.Xaml.Controls.Control, Windows.UI.Xaml.Controls.ICalendarDatePicker, Windows.UI.Xaml.Controls.ICalendarDatePicker2
-->

# Windows.UI.Xaml.Controls.CalendarDatePicker

## -description
Represents a control that allows a user to pick a date from a calendar display.


## -remarks

CalendarDatePicker is a drop down control that's optimized for picking a single date from a calendar view where contextual information like the day of the week or fullness of the calendar is important. It's similar to the [DatePicker](datepicker.md) control, but the [DatePicker](datepicker.md) is optimized for picking a known date, such as a date of birth, where the context of the calendar is not important.

You can use the CalendarDatePicker control in its default form with a minimal amount of Extensible Application Markup Language (XAML) or other code, or you can customize it in various ways to suit your app. Here's a simple CalendarDatePicker created in Extensible Application Markup Language (XAML) and code.

```csharp
CalendarDatePicker arrivalCalendarDatePicker = new CalendarDatePicker();
```

```xaml
<CalendarDatePicker x:Name="arrivalCalendarDatePicker"/>
```

Here's what the control look like when it's closed and a date is not selected.

<img src="images/Controls/CalendarDatePicker_Closed.png" alt="Closed calendar date picker" />

Here's what it looks like with the calendar open and a date selected.

<img src="images/Controls/CalendarDatePicker_Open.png" alt="Open calendar date picker" />

CalendarDatePicker has an internal [CalendarView](calendarview.md) for picking a date. A subset of [CalendarView](calendarview.md) properties, like [IsTodayHighlighted](calendardatepicker_istodayhighlighted.md) and [FirstDayOfWeek](calendardatepicker_firstdayofweek.md), exist on CalendarDatePicker and are forwarded to the internal [CalendarView](calendarview.md) to let you modify it. However, you can't change the [SelectionMode](calendarview_selectionmode.md) of the internal [CalendarView](calendarview.md) to allow multiple selection. If you need to let a user pick multiple dates or need a calendar to be always visible, consider using a [CalendarView](calendarview.md) instead of a CalendarDatePicker. See the [CalendarView](calendarview.md) class for more info on how you can modify the calendar display.

### Selecting dates

Use the [Date](calendardatepicker_date.md) property to get or set the selected date. By default, the [Date](calendardatepicker_date.md) property is null. When a user selects a date in the calendar view, this property is updated. A user can clear the date by clicking the selected date in the calendar view to deselect it.

You can set the date in your code like this.

```csharp
myCalendarDatePicker.Date = new DateTime(1977, 1, 5);
```

When you set the [Date](calendardatepicker_date.md) in code, the value is constrained by the [MinDate](calendardatepicker_mindate.md) and [MaxDate](calendardatepicker_maxdate.md) properties. If [Date](calendardatepicker_date.md) is smaller than [MinDate](calendardatepicker_mindate.md), the value is set to [MinDate](calendardatepicker_mindate.md). If [Date](calendardatepicker_date.md) is greater than [MaxDate](calendardatepicker_maxdate.md), the value is set to [MaxDate](calendardatepicker_maxdate.md).

You can handle the [DateChanged](calendardatepicker_datechanged.md) event to be notified when the [Date](calendardatepicker_date.md) value has changed.

### Formatting the selected date

You can change the display format of the day, month, and year of the selected date. The string content of the [TextBox](textbox.md) portion of the CalendarDatePicker is created by a [DateTimeFormatter](../windows.globalization.datetimeformatting/datetimeformatter.md). You tell the [DateTimeFormatter](../windows.globalization.datetimeformatting/datetimeformatter.md) how to format the value by providing a string that is either a *format template* or a *format pattern*. For the complete list of format templates and format patterns, see the Remarks section of the [DateTimeFormatter](../windows.globalization.datetimeformatting/datetimeformatter.md) class documentation.

Here's how to specify a format in XAML and in code using format patterns.

```xaml
<CalendarDatePicker x:Name="myCalendarDatePicker"
                    DateFormat = "{}{dayofweek.full}‎, ‎{month.full}‎ ‎{day.integer}‎, ‎{year.full}"/>
```

```csharp
myCalendarDatePicker.DateFormat = "{dayofweek.full}‎, ‎{month.full}‎ ‎{day.integer}‎, ‎{year.full}";
```

The selected date looks like this with the date formatted.

<img src="images/CalendarDatePicker_Formatted.png" alt="Formatted calendar date picker" />

### Setting a header and placeholder text

You can add a [Header](calendardatepicker_header.md) (or label) and [PlaceholderText](calendardatepicker_placeholdertext.md) (or watermark) to the CalendarDatePicker to give the user an indication of what it's used for. To customize the look of the header, you can set the [HeaderTemplate](calendardatepicker_headertemplate.md) property instead of [Header](calendardatepicker_header.md). For design info, see [Guidelines for labels](/windows/uwp/controls-and-patterns/labels).

The default placeholder text is "**select a date** ". You can remove this by setting the [PlaceholderText](calendardatepicker_placeholdertext.md) property to an empty string, or you can provide custom text as shown here.

```xaml
<CalendarDatePicker x:Name="arrivalCalendarDatePicker" Header="Arrival date" PlaceholderText="Choose your arrival date"/>
```

### Globalization

The CalendarDatePicker supports each of the calendar systems supported by Windows. These calendars are specified in the [Windows.Globalization.CalendarIdentifiers](../windows.globalization/calendaridentifiers.md) class. The CalendarDatePicker uses the correct calendar for your app's default language, or you can set the [CalendarIdentifier](calendarview_calendaridentifier.md) property to use a specific calendar system.

### DateTime and Calendar values

The date objects used in a CalendarDatePicker have a different representation depending on your programming language. C# and Visual Basic use the [System.DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true) structure that is part of .NET. Visual C++ component extensions (C++/CX) uses the [Windows::Foundation::DateTime](/windows/desktop/api/windows.foundation/ns-windows-foundation-datetime) structure. A related concept is the **Calendar** class, which influences how dates are interpreted in context. All Windows Runtime apps can use the [Windows.Globalization.Calendar](../windows.globalization/calendar.md) class. C# and Visual Basic apps can alternatively use the [System.Globalization.Calendar](/dotnet/api/system.globalization.calendar?view=dotnet-uwp-10.0&preserve-view=true) class, which has very similar functionality. (Windows Runtime app can use the base .NET [Calendar](/dotnet/api/system.globalization.calendar?view=dotnet-uwp-10.0&preserve-view=true) class but not the specific implementations for example **GregorianCalendar**.)

.NET also supports a type named [DateTime](/dotnet/api/system.datetime?view=dotnet-uwp-10.0&preserve-view=true), which is implicitly convertible to a [DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true). So you might see a "DateTime" type being used in .NET code that's used to set values that are really [DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true). For more info on the difference between [DateTime](/dotnet/api/system.datetime?view=dotnet-uwp-10.0&preserve-view=true) and [DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true), see Remarks in [DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true).

> [!NOTE]
> Properties that take date objects can't be set as a XAML attribute string, because the Windows Runtime XAML parser doesn't have a conversion logic for converting strings to dates as [DateTime](/dotnet/api/system.datetime?view=dotnet-uwp-10.0&preserve-view=true)/[DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true) objects. You typically set these values in code. Another possible technique is to define a date that's available as a data object or in the data context, then set the property as a XAML attribute that references a [{Binding} markup extension](/windows/uwp/xaml-platform/binding-markup-extension) expression that can access the date as data.

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is available locally with the SDK or NuGet package installation.

- **[WinUI Styles (recommended)](/windows/apps/design/style/xaml-styles#winui-and-styles):** For updated styles from WinUI, see `\Users\<username>\.nuget\packages\microsoft.ui.xaml\<version>\lib\uap10.0\Microsoft.UI.Xaml\Themes\generic.xaml`.
- **Non-WinUI styles:** For built-in styles, see `%ProgramFiles(x86)%\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\<SDK version>\Generic\generic.xaml`.

Locations might be different if you customized the installation. Styles and resources from different versions of the SDK might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article. Light-weight styling resources are available starting in Windows 10, version 1607 (SDK 14393).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | LightDismissOverlayMode |
| 1809 | 17763 | Description |

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Calendar date picker](/windows/apps/design/controls/calendar-date-picker).

> [!div class="nextstepaction"]
> [Open the WinUI 2 Gallery app and see the CalendarDatePicker in action](winui2gallery:/item/CalendarDatePicker)

> The **WinUI 2 Gallery** app includes interactive examples of most WinUI 2 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9MSVH128X2ZT) or get the source code on [GitHub](https://github.com/Microsoft/WinUI-Gallery/tree/winui2).

## -see-also
[Control](control.md)
