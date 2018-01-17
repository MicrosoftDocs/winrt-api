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
[CalendarDatePicker](calendardatepicker.md) is a drop down control that’s optimized for picking a single date from a calendar view where contextual information like the day of the week or fullness of the calendar is important. It’s similar to the [DatePicker](datepicker.md) control, but the [DatePicker](datepicker.md) is optimized for picking a known date, such as a date of birth, where the context of the calendar is not important.

You can use the [CalendarDatePicker](calendardatepicker.md) control in its default form with a minimal amount of Extensible Application Markup Language (XAML) or other code, or you can customize it in various ways to suit your app. Here's a simple [CalendarDatePicker](calendardatepicker.md) created in Extensible Application Markup Language (XAML) and code.



```csharp
CalendarDatePicker arrivalCalendarDatePicker = new CalendarDatePicker();
```

```xaml
<CalendarDatePicker x:Name="arrivalCalendarDatePicker"/>
```

Here's what the control look like when it's closed and a date is not selected.

<img src="images/Controls/CalendarDatePicker_Closed.png" alt="Closed calendar date picker" />
Here's what it looks like with the calendar open and a date selected.

<img src="images/Controls/CalendarDatePicker_Open.png" alt="Open calendar date picker" />[CalendarDatePicker](calendardatepicker.md) has an internal [CalendarView](calendarview.md) for picking a date. A subset of [CalendarView](calendarview.md) properties, like [IsTodayHighlighted](calendardatepicker_istodayhighlighted.md) and [FirstDayOfWeek](calendardatepicker_firstdayofweek.md), exist on [CalendarDatePicker](calendardatepicker.md) and are forwarded to the internal [CalendarView](calendarview.md) to let you modify it. However, you can't change the [SelectionMode](calendarview_selectionmode.md) of the internal [CalendarView](calendarview.md) to allow multiple selection. If you need to let a user pick multiple dates or need a calendar to be always visible, consider using a [CalendarView](calendarview.md) instead of a [CalendarDatePicker](calendardatepicker.md). See the [CalendarView](calendarview.md) class for more info on how you can modify the calendar display.

### Selecting dates

Use the [Date](calendardatepicker_date.md) property to get or set the selected date. By default, the [Date](calendardatepicker_date.md) property is null. When a user selects a date in the calendar view, this property is updated. A user can clear the date by clicking the selected date in the calendar view to deselect it.

You can set the date in your code like this.

```csharp
myCalendarDatePicker.Date = new DateTime(1977, 1, 5);
```

When you set the [Date](calendardatepicker_date.md) in code, the value is constrained by the [MinDate](calendardatepicker_mindate.md) and [MaxDate](calendardatepicker_maxdate.md) properties. If [Date](calendardatepicker_date.md) is smaller than [MinDate](calendardatepicker_mindate.md), the value is set to [MinDate](calendardatepicker_mindate.md). If [Date](calendardatepicker_date.md) is greater than [MaxDate](calendardatepicker_maxdate.md), the value is set to [MaxDate](calendardatepicker_maxdate.md).

You can handle the [DateChanged](calendardatepicker_datechanged.md) event to be notified when the [Date](calendardatepicker_date.md) value has changed.

### Formatting the selected date

You can change the display format of the day, month, and year of the selected date. The string content of the [TextBox](textbox.md) portion of the [CalendarDatePicker](calendardatepicker.md) is created by a [DateTimeFormatter](../windows.globalization.datetimeformatting/datetimeformatter.md). You tell the [DateTimeFormatter](../windows.globalization.datetimeformatting/datetimeformatter.md) how to format the value by providing a string that is either a *format template* or a *format pattern*. For the complete list of format templates and format patterns, see the Remarks section of the [DateTimeFormatter](../windows.globalization.datetimeformatting/datetimeformatter.md) class documentation.

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

You can add a [Header](calendardatepicker_header.md) (or label) and [PlaceholderText](calendardatepicker_placeholdertext.md) (or watermark) to the [CalendarDatePicker](calendardatepicker.md) to give the user an indication of what it's used for. To customize the look of the header, you can set the [HeaderTemplate](calendardatepicker_headertemplate.md) property instead of [Header](calendardatepicker_header.md). For design info, see [Guidelines for labels](http://msdn.microsoft.com/library/cfacccd4-749f-43fb-947e-2591ae673804).

The default placeholder text is "**select a date** ". You can remove this by setting the [PlaceholderText](calendardatepicker_placeholdertext.md) property to an empty string, or you can provide custom text as shown here.

```xaml
<CalendarDatePicker x:Name="arrivalCalendarDatePicker" Header="Arrival date" PlaceholderText="Choose your arrival date"/>
```



### Globalization

The [CalendarDatePicker](calendardatepicker.md) supports each of the calendar systems supported by Windows. These calendars are specified in the [Windows.Globalization.CalendarIdentifiers](../windows.globalization/calendaridentifiers.md) class. The [CalendarDatePicker](calendardatepicker.md) uses the correct calendar for your app's default language, or you can set the [CalendarIdentifier](calendarview_calendaridentifier.md) property to use a specific calendar system.

### DateTime and Calendar values

The date objects used in a [CalendarDatePicker](calendardatepicker.md) have a different representation depending on your programming language. C# and Visual Basic use the [System.DateTimeOffset](https://msdn.microsoft.com/library/system.datetimeoffset.aspx) structure that is part of .NET. Visual C++ component extensions (C++/CX) uses the [Windows::Foundation::DateTime](http://msdn.microsoft.com/library/b5533002-8a72-438d-a3d3-0902ffc21830) structure. A related concept is the **Calendar** class, which influences how dates are interpreted in context. All Windows Runtime apps can use the [Windows.Globalization.Calendar](../windows.globalization/calendar.md) class. C# and Visual Basic apps can alternatively use the [System.Globalization.Calendar](https://msdn.microsoft.com/library/system.globalization.calendar.aspx) class, which has very similar functionality. (Windows Runtime app can use the base .NET [Calendar](https://msdn.microsoft.com/library/system.globalization.calendar.aspx) class but not the specific implementations for example **GregorianCalendar**.)

.NET also supports a type named [DateTime](https://msdn.microsoft.com/library/system.datetime.aspx), which is implicitly convertible to a [DateTimeOffset](https://msdn.microsoft.com/library/system.datetimeoffset.aspx). So you might see a "DateTime" type being used in .NET code that's used to set values that are really [DateTimeOffset](https://msdn.microsoft.com/library/system.datetimeoffset.aspx). For more info on the difference between [DateTime](https://msdn.microsoft.com/library/system.datetime.aspx) and [DateTimeOffset](https://msdn.microsoft.com/library/system.datetimeoffset.aspx), see Remarks in [DateTimeOffset](https://msdn.microsoft.com/library/system.datetimeoffset.aspx).

> [!NOTE]
> Properties that take date objects can't be set as a XAML attribute string, because the Windows Runtime XAML parser doesn't have a conversion logic for converting strings to dates as [DateTime](https://msdn.microsoft.com/library/system.datetime.aspx)/[DateTimeOffset](https://msdn.microsoft.com/library/system.datetimeoffset.aspx) objects. You typically set these values in code. Another possible technique is to define a date that's available as a data object or in the data context, then set the property as a XAML attribute that references a [{Binding} markup extension](http://msdn.microsoft.com/library/3bafe7b5-af33-487f-9ad5-beafd65d04c3) expression that can access the date as data.

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\&lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (Windows Software Development Kit (SDK) version 10.0.14393.0), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) section of the [Styling controls](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the [CalendarDatePicker](calendardatepicker.md) control.

<table>
   <tr><th>Resource key</th><th>Description</th></tr>
   <tr><td>CalendarDatePickerForeground</td><td>Header text color</td></tr>
   <tr><td>CalendarDatePickerForegroundDisabled</td><td>Foreground color when disabled</td></tr>
   <tr><td>CalendarDatePickerCalendarGlyphForeground</td><td>Calendar icon color</td></tr>
   <tr><td>CalendarDatePickerCalendarGlyphForegroundDisabled</td><td>Calendar icon color when disabled</td></tr>
   <tr><td>CalendarDatePickerTextForeground</td><td>Placeholder text color</td></tr>
   <tr><td>CalendarDatePickerTextForegroundDisabled</td><td>Placeholder text when disabled</td></tr>
   <tr><td>CalendarDatePickerTextForegroundSelected</td><td>Placeholder text when selected</td></tr>
   <tr><td>CalendarDatePickerHeaderForegroundDisabled</td><td>Header text color when disabled</td></tr>
   <tr><td>CalendarDatePickerBackground</td><td>Background color at rest</td></tr>
   <tr><td>CalendarDatePickerBackgroundPointerOver</td><td>Background color on hover</td></tr>
   <tr><td>CalendarDatePickerBackgroundPressed</td><td>Background color when pressed</td></tr>
   <tr><td>CalendarDatePickerBackgroundDisabled</td><td>Background color when disabled</td></tr>
   <tr><td>CalendarDatePickerBackgroundFocused</td><td>Background color when focused</td></tr>
   <tr><td>CalendarDatePickerBorderBrush</td><td>Border color at rest</td></tr>
   <tr><td>CalendarDatePickerBorderBrushPointerOver</td><td>Border color on hover</td></tr>
   <tr><td>CalendarDatePickerBorderBrushPressed</td><td>Border color when pressed</td></tr>
   <tr><td>CalendarDatePickerBorderBrushDisabled</td><td>Border color when disabled</td></tr>
</table>

## -examples

<table>
<th align="left">XAML Controls Gallery<th>
<tr>
<td><img src="images/xaml-controls-gallery-sm.png" alt="XAML controls gallery"></img></td>
<td>
    <p>If you have the <strong style="font-weight: semi-bold">XAML Controls Gallery</strong> app installed, click here to <a href="xamlcontrolsgallery:/item/CalendarDatePicker">open the app and see the CalendarDatePicker in action</a>.</p>
    <ul>
    <li><a href="https://www.microsoft.com/store/productId/9MSVH128X2ZT">Get the XAML Controls Gallery app (Microsoft Store)</a></li>
    <li><a href="https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlUIBasics">Get the source code (GitHub)</a></li>
    </ul>
</td>
</tr>
</table>

## -see-also
[Control](control.md), [CalendarDatePicker styles and templates](http://msdn.microsoft.com/library/30d22fcc-3a79-412e-ac0d-ce3c5eb59487)