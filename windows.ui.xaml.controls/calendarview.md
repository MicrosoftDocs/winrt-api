---
-api-id: T:Windows.UI.Xaml.Controls.CalendarView
-api-type: winrt class
---

<!-- Class syntax.
public class CalendarView : Windows.UI.Xaml.Controls.Control, Windows.UI.Xaml.Controls.ICalendarView
-->

# Windows.UI.Xaml.Controls.CalendarView

## -description
Represents a control that enables a user to select a date by using a visual calendar display.


## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Calendar view](/windows/uwp/design/controls-and-patterns/calendar-view).

The CalendarView gives you a standardized way to let users view and interact with a calendar. If you need to let a user select multiple dates, you must use a CalendarView. If you need to let a user pick only a single date and don't need a calendar to be always visible, consider using a [CalendarDatePicker](calendardatepicker.md) or [DatePicker](datepicker.md) control. You can use the CalendarView control in its default form with a minimal amount of Extensible Application Markup Language (XAML) or other code, or you can customize it in various ways to suit your app.

The CalendarView is made up of 3 separate views: the month view, year view, and decade view. By default, it starts with the month view open. You can specify a startup view by setting the [DisplayMode](calendarview_displaymode.md) property.

<img src="images/CalendarViews.png" alt="Calendar Month, Year, and Decade views" />
Users click the header in the month view to open the year view, and click the header in the year view to open the decade view. Users pick a year in the decade view to return to the year view, and pick a month in the year view to return to the month view. The two arrows to the side of the header navigate forward or backward by month, by year, or by decade.

### Selecting dates

By default, the [SelectionMode](calendarview_selectionmode.md) property is set to [Single](calendarviewselectionmode.md). This lets a user pick a single date in the calendar. Set [SelectionMode](calendarview_selectionmode.md) to [None](calendarviewselectionmode.md) to disable date selection.

Set [SelectionMode](calendarview_selectionmode.md) to [Multiple](calendarviewselectionmode.md) to let a user select multiple dates. You can select multiple dates programmatically by adding [DateTime](/dotnet/api/system.datetime?view=dotnet-uwp-10.0&preserve-view=true)/[DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true) objects to the [SelectedDates](calendarview_selecteddates.md) collection, as shown here:

```csharp
calendarView1.SelectedDates.Add(DateTimeOffset.Now);
calendarView1.SelectedDates.Add(new DateTime(1977, 1, 5));

```

A user can deselect a selected date by clicking or tapping it in the calendar grid.

You can handle the [SelectedDatesChanged](calendarview_selecteddateschanged.md) event to be notified when the [SelectedDates](calendarview_selecteddates.md) collection has changed.

### Globalization

The CalendarView supports each of the calendar systems supported by Windows. These calendars are specified in the [Windows.Globalization.CalendarIdentifiers](../windows.globalization/calendaridentifiers.md) class. The CalendarView uses the correct calendar for your app's default language, or you can set the [CalendarIdentifier](calendarview_calendaridentifier.md) property to use a specific calendar system.

### DateTime and Calendar values

The date objects used in a CalendarView have a different representation depending on your programming language. C# and Visual Basic use the [System.DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true) structure that is part of .NET. Visual C++ component extensions (C++/CX) uses the [Windows::Foundation::DateTime](/windows/desktop/api/windows.foundation/ns-windows-foundation-datetime) structure. A related concept is the **Calendar** class, which influences how dates are interpreted in context. All Windows Runtime apps can use the [Windows.Globalization.Calendar](../windows.globalization/calendar.md) class. C# and Visual Basic apps can alternatively use the [System.Globalization.Calendar](/dotnet/api/system.globalization.calendar?view=dotnet-uwp-10.0&preserve-view=true) class, which has very similar functionality. (Windows Runtime app can use the base .NET [Calendar](/dotnet/api/system.globalization.calendar?view=dotnet-uwp-10.0&preserve-view=true) class but not the specific implementations for example **GregorianCalendar**.)

.NET also supports a type named [DateTime](/dotnet/api/system.datetime?view=dotnet-uwp-10.0&preserve-view=true), which is implicitly convertible to a [DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true). So you might see a "DateTime" type being used in .NET code that's used to set values that are really [DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true). For more info on the difference between [DateTime](/dotnet/api/system.datetime?view=dotnet-uwp-10.0&preserve-view=true) and [DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true), see Remarks in [DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true).

> [!NOTE]
> Properties that take date objects can't be set as a XAML attribute string, because the Windows Runtime XAML parser doesn't have a conversion logic for converting strings to dates as [DateTime](/dotnet/api/system.datetime?view=dotnet-uwp-10.0&preserve-view=true)/[DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true) objects. You typically set these values in code. Another possible technique is to define a date that's available as a data object or in the data context, then set the property as a XAML attribute that references a [{Binding} markup extension](/windows/uwp/xaml-platform/binding-markup-extension) expression that can access the date as data.

### Customizing the CalendarView's appearance

The CalendarView is composed of both Extensible Application Markup Language (XAML) elements defined in the [ControlTemplate](controltemplate.md) and visual elements rendered directly by the control. The Extensible Application Markup Language (XAML) elements defined in the control template include the border that encloses the control, the header, previous and next buttons, and DayOfWeek elements. You can style and re-template these elements like any Extensible Application Markup Language (XAML) control. The calendar grid is composed of [CalendarViewDayItem](calendarviewdayitem.md) objects. You can't style or re-template these elements, but various properties are provided to let you to customize their appearance.

This diagram shows the elements that make up the month view of the calendar. For more info, see the Remarks on the [CalendarViewDayItem](calendarviewdayitem.md) class.

<img src="images/CalendarMonthElements.png" alt="The elements of a calendar month view" />

This table lists the properties you can change to modify the appearance of calendar elements.

| Element | Properties |
| - | - |
| DayOfWeek | [DayOfWeekFormat](calendarview_dayofweekformat.md) |
| CalendarItem | [CalendarItemBackground](calendarview_calendaritembackground.md), [CalendarItemBorderBrush](calendarview_calendaritemborderbrush.md), [CalendarItemBorderThickness](calendarview_calendaritemborderthickness.md), [CalendarItemForeground](calendarview_calendaritemforeground.md) |
| DayItem | [DayItemFontFamily](calendarview_dayitemfontfamily.md), [DayItemFontSize](calendarview_dayitemfontsize.md), [DayItemFontStyle](calendarview_dayitemfontstyle.md), [DayItemFontWeight](calendarview_dayitemfontweight.md), [HorizontalDayItemAlignment](calendarview_horizontaldayitemalignment.md), [VerticalDayItemAlignment](calendarview_verticaldayitemalignment.md), [CalendarViewDayItemStyle](calendarview_calendarviewdayitemstyle.md) |
| MonthYearItem (in the year and decade views, equivalent to DayItem) | [MonthYearItemFontFamily](calendarview_monthyearitemfontfamily.md), [MonthYearItemFontSize](calendarview_monthyearitemfontsize.md), [MonthYearItemFontStyle](calendarview_monthyearitemfontstyle.md), [MonthYearItemFontWeight](calendarview_monthyearitemfontweight.md) |
| FirstOfMonthLabel | [FirstOfMonthLabelFontFamily](calendarview_firstofmonthlabelfontfamily.md), [FirstOfMonthLabelFontSize](calendarview_firstofmonthlabelfontsize.md), [FirstOfMonthLabelFontStyle](calendarview_firstofmonthlabelfontstyle.md), [FirstOfMonthLabelFontWeight](calendarview_firstofmonthlabelfontweight.md), [HorizontalFirstOfMonthLabelAlignment](calendarview_horizontalfirstofmonthlabelalignment.md), [VerticalFirstOfMonthLabelAlignment](calendarview_verticalfirstofmonthlabelalignment.md), [IsGroupLabelVisible](calendarview_isgrouplabelvisible.md) |
| FirstofYearDecadeLabel (in the year and decade views, equivalent to FirstOfMonthLabel) | [FirstOfYearDecadeLabelFontFamily](calendarview_firstofyeardecadelabelfontfamily.md), [FirstOfYearDecadeLabelFontSize](calendarview_firstofyeardecadelabelfontsize.md), [FirstOfYearDecadeLabelFontStyle](calendarview_firstofyeardecadelabelfontstyle.md), [FirstOfYearDecadeLabelFontWeight](calendarview_firstofyeardecadelabelfontweight.md) |
| Visual State Borders | [FocusBorderBrush](calendarview_focusborderbrush.md), [HoverBorderBrush](calendarview_hoverborderbrush.md), [PressedBorderBrush](calendarview_pressedborderbrush.md), [SelectedBorderBrush](calendarview_selectedborderbrush.md), [SelectedForeground](calendarview_selectedforeground.md), [SelectedHoverBorderBrush](calendarview_selectedhoverborderbrush.md), [SelectedPressedBorderBrush](calendarview_selectedpressedborderbrush.md) |
| OutofScope | [IsOutOfScopeEnabled](calendarview_isoutofscopeenabled.md), [OutOfScopeBackground](calendarview_outofscopebackground.md), [OutOfScopeForeground](calendarview_outofscopeforeground.md) |
| Today | [IsTodayHighlighted](calendarview_istodayhighlighted.md), [TodayFontWeight](calendarview_todayfontweight.md), [TodayForeground](calendarview_todayforeground.md) |

By default, the month view shows 6 weeks at a time. You can change the number of weeks shown by setting the [NumberOfWeeksInView](calendarview_numberofweeksinview.md) property. The minimum number of weeks to show is 2; the maximum is 8.

By default, the year and decade views show in a 4x4 grid. To change the number of rows or columns, call [SetYearDecadeDisplayDimensions](calendarview_setyeardecadedisplaydimensions_388826447.md) with the your desired number of rows and columns. This will change the grid for both the year and decade views.

Here, the year and decade views are set to show in a 3x4 grid.

```csharp
calendarView1.SetYearDecadeDisplayDimensions(3, 4);
```

By default, the minimum date shown in the CalendarView is 100 years prior to the current date, and the maximum date shown is 100 years past the current date. You can change the minimum and maximum dates that the calendar shows by setting the [MinDate](calendarview_mindate.md) and [MaxDate](calendarview_maxdate.md) properties.

```csharp
calendarView1.MinDate = new DateTime(2000, 1, 1);
calendarView1.MaxDate = new DateTime(2099, 12, 31);
```

### Updating calendar day items

Each day in the calendar is represented by a [CalendarViewDayItem](calendarviewdayitem.md) object. To access an individual day item and use its properties and methods, handle the [CalendarViewDayItemChanging](calendarview_calendarviewdayitemchanging.md) event and use the [Item](calendarviewdayitemchangingeventargs_item.md) property of the event args to access the [CalendarViewDayItem](calendarviewdayitem.md).

You can make a day not selectable in the CalendarView by setting its [CalendarViewDayItem.IsBlackout](calendarviewdayitem_isblackout.md) property to **true**.

You can show contextual information about the density of events in a day by calling the [CalendarViewDayItem.SetDensityColors](calendarviewdayitem_setdensitycolors_669941734.md) method. You can show from 0 to 10 density bars for each day, and set the color of each bar.

Here are some day items in a calendar. Days 1 and 2 are blacked out. Days 2, 3, and 4 have various density bars set.

<img src="images/CalendarView_density_bars.png" alt="Calendar days with density bars"/>

A CalendarView can contain a large number of [CalendarViewDayItem](calendarviewdayitem.md) objects. To keep the UI responsive and enable smooth navigation through the calendar, CalendarView supports phased rendering. This lets you break up processing of a day item into phases. If a day is moved out of view before all the phases are complete, no more time is used trying to process and render that item.

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is available locally with the SDK or NuGet package installation.

- **[WinUI Styles (recommended)](/windows/apps/design/style/xaml-styles#winui-and-styles):** For updated styles from WinUI, see `\Users\<username>\.nuget\packages\microsoft.ui.xaml\<version>\lib\uap10.0\Microsoft.UI.Xaml\Themes\generic.xaml`.
- **Non-WinUI styles:** For built-in styles, see `%ProgramFiles(x86)%\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\<SDK version>\Generic\generic.xaml`.

Locations might be different if you customized the installation. Styles and resources from different versions of the SDK might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article. Light-weight styling resources are available starting in Windows 10, version 1607 (SDK 14393).

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Calendar view](/windows/apps/design/controls/calendar-view).

> [!div class="nextstepaction"]
> [Open the WinUI 2 Gallery app and see CalendarView in action](winui2gallery:/item/CalendarView)

> The **WinUI 2 Gallery** app includes interactive examples of most WinUI 2 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9MSVH128X2ZT) or get the source code on [GitHub](https://github.com/Microsoft/WinUI-Gallery/tree/winui2).

This example shows phased rendering of a CalendarView for scheduling appointments. In phase 0, the default day item is rendered. In phase 1, you blackout dates that can't be booked. This includes past dates, Sundays, and dates that are already fully booked. In phase 2, you check each appointment that's booked for the day. You show a green density bar for each confirmed appointment and a blue density bar for each tentative appointment. The `Bookings` class in this example is from a fictitious appointment booking app, and is not shown.

(To see this code running in a complete app sample, see the [Lunch scheduler sample](https://github.com/Microsoft/Windows-appsample-lunch-scheduler).)

```xaml
<CalendarView CalendarViewDayItemChanging="CalendarView_CalendarViewDayItemChanging"/>
```

```csharp
private void CalendarView_CalendarViewDayItemChanging(CalendarView sender, 
                                   CalendarViewDayItemChangingEventArgs args)
{
    // Render basic day items.
    if (args.Phase == 0)
    {
        // Register callback for next phase.
        args.RegisterUpdateCallback(CalendarView_CalendarViewDayItemChanging);
    }
    // Set blackout dates.
    else if (args.Phase == 1)
    {   
        // Blackout dates in the past, Sundays, and dates that are fully booked.
        if (args.Item.Date < DateTimeOffset.Now ||
            args.Item.Date.DayOfWeek == DayOfWeek.Sunday ||
            Bookings.HasOpenings(args.Item.Date) == false)
        {
            args.Item.IsBlackout = true;
        }
        // Register callback for next phase.
        args.RegisterUpdateCallback(CalendarView_CalendarViewDayItemChanging);
    }
    // Set density bars.
    else if (args.Phase == 2)
    {
        // Avoid unnecessary processing.
        // You don't need to set bars on past dates or Sundays.
        if (args.Item.Date > DateTimeOffset.Now &&
            args.Item.Date.DayOfWeek != DayOfWeek.Sunday)
        {
            // Get bookings for the date being rendered.
            var currentBookings = Bookings.GetBookings(args.Item.Date);

            List<Color> densityColors = new List<Color>();
            // Set a density bar color for each of the days bookings.
            // It's assumed that there can't be more than 10 bookings in a day. Otherwise,
            // further processing is needed to fit within the max of 10 density bars.
            foreach (booking in currentBookings)
            {
                if (booking.IsConfirmed == true)
                {
                    densityColors.Add(Colors.Green);
                }
                else
                {
                    densityColors.Add(Colors.Blue);
                }
            }
            args.Item.SetDensityColors(densityColors);
        }
    }
}
```



## -see-also
[Control](control.md), [Windows.Globalization.CalendarIdentifiers](../windows.globalization/calendaridentifiers.md), [System.DateTimeOffset (C#/VB)](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true), [Windows::Foundation::DateTime (C++)](/windows/desktop/api/windows.foundation/ns-windows-foundation-datetime), [Windows.Globalization.Calendar](../windows.globalization/calendar.md), [CalendarDatePicker](calendardatepicker.md), [DatePicker](datepicker.md), [TimePicker](timepicker.md), [Controls list](/windows/uwp/design/controls-and-patterns/), [Controls by function](/windows/uwp/controls-and-patterns/controls-by-function)
