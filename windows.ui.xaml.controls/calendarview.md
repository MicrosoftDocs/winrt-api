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
The [CalendarView](calendarview.md) gives you a standardized way to let users view and interact with a calendar. If you need to let a user select multiple dates, you must use a [CalendarView](calendarview.md). If you need to let a user pick only a single date and don’t need a calendar to be always visible, consider using a [CalendarDatePicker](calendardatepicker.md) or [DatePicker](datepicker.md) control. You can use the [CalendarView](calendarview.md) control in its default form with a minimal amount of Extensible Application Markup Language (XAML) or other code, or you can customize it in various ways to suit your app.

The [CalendarView](calendarview.md) is made up of 3 separate views: the month view, year view, and decade view. By default, it starts with the month view open. You can specify a startup view by setting the [DisplayMode](calendarview_displaymode.md) property.

<img src="images/CalendarViews.png" alt="Calendar Month, Year, and Decade views" />
Users click the header in the month view to open the year view, and click the header in the year view to open the decade view. Users pick a year in the decade view to return to the year view, and pick a month in the year view to return to the month view. The two arrows to the side of the header navigate forward or backward by month, by year, or by decade.

### Selecting dates

By default, the [SelectionMode](calendarview_selectionmode.md) property is set to [Single](calendarviewselectionmode.md). This lets a user pick a single date in the calendar. Set [SelectionMode](calendarview_selectionmode.md) to [None](calendarviewselectionmode.md) to disable date selection.

Set [SelectionMode](calendarview_selectionmode.md) to [Multiple](calendarviewselectionmode.md) to let a user select multiple dates. You can select multiple dates programmatically by adding [DateTime](https://msdn.microsoft.com/library/system.datetime.aspx)/[DateTimeOffset](https://msdn.microsoft.com/library/system.datetimeoffset.aspx) objects to the [SelectedDates](calendarview_selecteddates.md) collection, as shown here:

```csharp
calendarView1.SelectedDates.Add(DateTimeOffset.Now);
calendarView1.SelectedDates.Add(new DateTime(1977, 1, 5));

```

A user can deselect a selected date by clicking or tapping it in the calendar grid.

You can handle the [SelectedDatesChanged](calendarview_selecteddateschanged.md) event to be notified when the [SelectedDates](calendarview_selecteddates.md) collection has changed.

### Globalization

The [CalendarView](calendarview.md) supports each of the calendar systems supported by Windows. These calendars are specified in the [Windows.Globalization.CalendarIdentifiers](../windows.globalization/calendaridentifiers.md) class. The [CalendarView](calendarview.md) uses the correct calendar for your app's default language, or you can set the [CalendarIdentifier](calendarview_calendaridentifier.md) property to use a specific calendar system.

### DateTime and Calendar values

The date objects used in a [CalendarView](calendarview.md) have a different representation depending on your programming language. C# and Visual Basic use the [System.DateTimeOffset](https://msdn.microsoft.com/library/system.datetimeoffset.aspx) structure that is part of .NET. Visual C++ component extensions (C++/CX) uses the [Windows::Foundation::DateTime](http://msdn.microsoft.com/library/b5533002-8a72-438d-a3d3-0902ffc21830) structure. A related concept is the **Calendar** class, which influences how dates are interpreted in context. All Windows Runtime apps can use the [Windows.Globalization.Calendar](../windows.globalization/calendar.md) class. C# and Visual Basic apps can alternatively use the [System.Globalization.Calendar](https://msdn.microsoft.com/library/system.globalization.calendar.aspx) class, which has very similar functionality. (Windows Runtime app can use the base .NET [Calendar](https://msdn.microsoft.com/library/system.globalization.calendar.aspx) class but not the specific implementations for example **GregorianCalendar**.)

.NET also supports a type named [DateTime](https://msdn.microsoft.com/library/system.datetime.aspx), which is implicitly convertible to a [DateTimeOffset](https://msdn.microsoft.com/library/system.datetimeoffset.aspx). So you might see a "DateTime" type being used in .NET code that's used to set values that are really [DateTimeOffset](https://msdn.microsoft.com/library/system.datetimeoffset.aspx). For more info on the difference between [DateTime](https://msdn.microsoft.com/library/system.datetime.aspx) and [DateTimeOffset](https://msdn.microsoft.com/library/system.datetimeoffset.aspx), see Remarks in [DateTimeOffset](https://msdn.microsoft.com/library/system.datetimeoffset.aspx).

> [!NOTE]
> Properties that take date objects can't be set as a XAML attribute string, because the Windows Runtime XAML parser doesn't have a conversion logic for converting strings to dates as [DateTime](https://msdn.microsoft.com/library/system.datetime.aspx)/[DateTimeOffset](https://msdn.microsoft.com/library/system.datetimeoffset.aspx) objects. You typically set these values in code. Another possible technique is to define a date that's available as a data object or in the data context, then set the property as a XAML attribute that references a [{Binding} markup extension](http://msdn.microsoft.com/library/3bafe7b5-af33-487f-9ad5-beafd65d04c3) expression that can access the date as data.

### Customizing the CalendarView's appearance

The [CalendarView](calendarview.md) is composed of both Extensible Application Markup Language (XAML) elements defined in the [ControlTemplate](controltemplate.md) and visual elements rendered directly by the control. The Extensible Application Markup Language (XAML) elements defined in the control template include the border that encloses the control, the header, previous and next buttons, and DayOfWeek elements. You can style and re-template these elements like any Extensible Application Markup Language (XAML) control. The calendar grid is composed of [CalendarViewDayItem](calendarviewdayitem.md) objects. You can’t style or re-template these elements, but various properties are provided to let you to customize their appearance.

This diagram shows the elements that make up the month view of the calendar. For more info, see the Remarks on the [CalendarViewDayItem](calendarviewdayitem.md) class.

<img src="images/CalendarMonthElements.png" alt="The elements of a calendar month view" />
This table lists the properties you can change to modify the appearance of calendar elements.

<table>
   <tr><th>Element</th><th>Properties</th></tr>
   <tr><td>DayOfWeek</td><td>[DayOfWeekFormat](calendarview_dayofweekformat.md)</td></tr>
   <tr><td>CalendarItem</td><td>[CalendarItemBackground](calendarview_calendaritembackground.md), [CalendarItemBorderBrush](calendarview_calendaritemborderbrush.md), [CalendarItemBorderThickness](calendarview_calendaritemborderthickness.md), [CalendarItemForeground](calendarview_calendaritemforeground.md)</td></tr>
   <tr><td>DayItem</td><td>[DayItemFontFamily](calendarview_dayitemfontfamily.md), [DayItemFontSize](calendarview_dayitemfontsize.md), [DayItemFontStyle](calendarview_dayitemfontstyle.md), [DayItemFontWeight](calendarview_dayitemfontweight.md), [HorizontalDayItemAlignment](calendarview_horizontaldayitemalignment.md), [VerticalDayItemAlignment](calendarview_verticaldayitemalignment.md), [CalendarViewDayItemStyle](calendarview_calendarviewdayitemstyle.md)</td></tr>
   <tr><td>MonthYearItem (in the year and decade views, equivalent to DayItem)</td><td>[MonthYearItemFontFamily](calendarview_monthyearitemfontfamily.md), [MonthYearItemFontSize](calendarview_monthyearitemfontsize.md), [MonthYearItemFontStyle](calendarview_monthyearitemfontstyle.md), [MonthYearItemFontWeight](calendarview_monthyearitemfontweight.md)</td></tr>
   <tr><td>FirstOfMonthLabel</td><td>[FirstOfMonthLabelFontFamily](calendarview_firstofmonthlabelfontfamily.md), [FirstOfMonthLabelFontSize](calendarview_firstofmonthlabelfontsize.md), [FirstOfMonthLabelFontStyle](calendarview_firstofmonthlabelfontstyle.md), [FirstOfMonthLabelFontWeight](calendarview_firstofmonthlabelfontweight.md), [HorizontalFirstOfMonthLabelAlignment](calendarview_horizontalfirstofmonthlabelalignment.md), [VerticalFirstOfMonthLabelAlignment](calendarview_verticalfirstofmonthlabelalignment.md), [IsGroupLabelVisible](calendarview_isgrouplabelvisible.md)</td></tr>
   <tr><td>FirstofYearDecadeLabel (in the year and decade views, equivalent to FirstOfMonthLabel)</td><td>[FirstOfYearDecadeLabelFontFamily](calendarview_firstofyeardecadelabelfontfamily.md), [FirstOfYearDecadeLabelFontSize](calendarview_firstofyeardecadelabelfontsize.md), [FirstOfYearDecadeLabelFontStyle](calendarview_firstofyeardecadelabelfontstyle.md), [FirstOfYearDecadeLabelFontWeight](calendarview_firstofyeardecadelabelfontweight.md)</td></tr>
   <tr><td>Visual State Borders</td><td>[FocusBorderBrush](calendarview_focusborderbrush.md), [HoverBorderBrush](calendarview_hoverborderbrush.md), [PressedBorderBrush](calendarview_pressedborderbrush.md), [SelectedBorderBrush](calendarview_selectedborderbrush.md), [SelectedForeground](calendarview_selectedforeground.md), [SelectedHoverBorderBrush](calendarview_selectedhoverborderbrush.md), [SelectedPressedBorderBrush](calendarview_selectedpressedborderbrush.md)</td></tr>
   <tr><td>OutofScope</td><td>[IsOutOfScopeEnabled](calendarview_isoutofscopeenabled.md), [OutOfScopeBackground](calendarview_outofscopebackground.md), [OutOfScopeForeground](calendarview_outofscopeforeground.md)</td></tr>
   <tr><td>Today</td><td>[IsTodayHighlighted](calendarview_istodayhighlighted.md), [TodayFontWeight](calendarview_todayfontweight.md), [TodayForeground](calendarview_todayforeground.md)</td></tr>
</table>

By default, the month view shows 6 weeks at a time. You can change the number of weeks shown by setting the [NumberOfWeeksInView](calendarview_numberofweeksinview.md) property. The minimum number of weeks to show is 2; the maximum is 8.

By default, the year and decade views show in a 4x4 grid. To change the number of rows or columns, call [SetYearDecadeDisplayDimensions](calendarview_setyeardecadedisplaydimensions.md) with the your desired number of rows and columns. This will change the grid for both the year and decade views.

Here, the year and decade views are set to show in a 3x4 grid.

```csharp
calendarView1.SetYearDecadeDisplayDimensions(3, 4);

```

By default, the minimum date shown in the [CalendarView](calendarview.md) is 100 years prior to the current date, and the maximum date shown is 100 years past the current date. You can change the minimum and maximum dates that the calendar shows by setting the [MinDate](calendarview_mindate.md) and [MaxDate](calendarview_maxdate.md) properties.

```csharp

calendarView1.MinDate = new DateTime(2000, 1, 1);
calendarView1.MaxDate = new DateTime(2099, 12, 31);

```



### Updating calendar day items

Each day in the calendar is represented by a [CalendarViewDayItem](calendarviewdayitem.md) object. To access an individual day item and use its properties and methods, handle the [CalendarViewDayItemChanging](calendarview_calendarviewdayitemchanging.md) event and use the [Item](calendarviewdayitemchangingeventargs_item.md) property of the event args to access the [CalendarViewDayItem](calendarviewdayitem.md).

You can make a day not selectable in the [CalendarView](calendarview.md) by setting its [CalendarViewDayItem.IsBlackout](calendarviewdayitem_isblackout.md) property to **true**.

You can show contextual information about the density of events in a day by calling the [CalendarViewDayItem.SetDensityColors](calendarviewdayitem_setdensitycolors.md) method. You can show from 0 to 10 density bars for each day, and set the color of each bar.

Here are some day items in a calendar. Days 1 and 2 are blacked out. Days 2, 3, and 4 have various density bars set.

<img src="images/CalendarView_density_bars.png" alt="Calendar days with density bars" />
A [CalendarView](calendarview.md) can contain a large number of [CalendarViewDayItem](calendarviewdayitem.md) objects. To keep the UI responsive and enable smooth navigation through the calendar, [CalendarView](calendarview.md) supports phased rendering. This lets you break up processing of a day item into phases. If a day is moved out of view before all the phases are complete, no more time is used trying to process and render that item.

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\&lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (Windows Software Development Kit (SDK) version 10.0.14393.0), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) section of the [Styling controls](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the [CalendarView](calendarview.md) control.

<table>
   <tr><th>Resource key</th><th>Description</th></tr>
   <tr><td>CalendarViewBorderBrush</td><td>Border color of the calendar grid</td></tr>
   <tr><td>CalendarViewFocusBorderBrush</td><td>Border color of a calendar item when focused</td></tr>
   <tr><td>CalendarViewHoverBorderBrush</td><td>Border color of a calendar item on hover</td></tr>
   <tr><td>CalendarViewPressedBorderBrush</td><td>Border color of a calendar item when pressed</td></tr>
   <tr><td>CalendarViewSelectedBorderBrush</td><td>Border color of a selected calendar item</td></tr>
   <tr><td>CalendarViewSelectedHoverBorderBrush</td><td>Border color of a selected calendar item on hover</td></tr>
   <tr><td>CalendarViewSelectedPressedBorderBrush</td><td>Border color of a selected calendar item when pressed</td></tr>
   <tr><td>CalendarViewBackground</td><td>Background color of the calendar header</td></tr>
   <tr><td>CalendarViewForeground</td><td>Foreground color of the calendar navigation header</td></tr>
   <tr><td>CalendarViewSelectedForeground</td><td>Foreground color of a selected calendar item</td></tr>
   <tr><td>CalendarViewPressedForeground</td><td>Foreground color of a calendar item when pressed</td></tr>
   <tr><td>CalendarViewTodayForeground</td><td>Foreground color of the today calendar item</td></tr>
   <tr><td>CalendarViewBlackoutForeground</td><td>Foreground color of blacked out calendar items</td></tr>
   <tr><td>CalendarViewWeekDayForegroundDisabled</td><td>Color of week and day labels when disabled</td></tr>
   <tr><td>CalendarViewOutOfScopeForeground</td><td>Foreground color of out of scope calendar items</td></tr>
   <tr><td>CalendarViewOutOfScopeBackground</td><td>Background color of out of scope calendar items</td></tr>
   <tr><td>CalendarViewCalendarItemForeground</td><td>Foreground color of calendar items</td></tr>
   <tr><td>CalendarViewCalendarItemBackground</td><td>Background color of calendar items</td></tr>
   <tr><td>CalendarViewNavigationButtonBackground</td><td>Background color of the calendar navigation header</td></tr>
   <tr><td>CalendarViewNavigationButtonForegroundPointerOver</td><td>Foreground color of the calendar navigation header on hover</td></tr>
   <tr><td>CalendarViewNavigationButtonForegroundPressed</td><td>Foreground color of the calendar navigation header when pressed</td></tr>
   <tr><td>CalendarViewNavigationButtonForegroundDisabled</td><td>Foreground color of the calendar navigation header when disabled</td></tr>
</table>

## -examples

<table>
<th align="left">XAML Controls Gallery<th>
<tr>
<td><img src="images/xaml-controls-gallery-sm.png" alt="XAML controls gallery"></img></td>
<td>
    <p>If you have the <strong style="font-weight: semi-bold">XAML Controls Gallery</strong> app installed, click here to <a href="xamlcontrolsgallery:/item/CalendarView">open the app and see the CalendarView in action</a>.</p>
    <ul>
    <li><a href="https://www.microsoft.com/store/productId/9MSVH128X2ZT">Get the XAML Controls Gallery app (Microsoft Store)</a></li>
    <li><a href="https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlUIBasics">Get the source code (GitHub)</a></li>
    </ul>
</td>
</tr>
</table>

This example shows phased rendering of a [CalendarView](calendarview.md) for scheduling appointments. In phase 0, the default day item is rendered. In phase 1, you blackout dates that can't be booked. This includes past dates, Sundays, and dates that are already fully booked. In phase 2, you check each appointment that's booked for the day. You show a green density bar for each confirmed appointment and a blue density bar for each tentative appointment. The `Bookings` class in this example is from a fictitious appointment booking app, and is not shown.

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
[Control](control.md), [Windows.Globalization.CalendarIdentifiers](../windows.globalization/calendaridentifiers.md), [System.DateTimeOffset (C#/VB)](https://msdn.microsoft.com/library/system.datetimeoffset.aspx), [Windows::Foundation::DateTime (C++)](http://msdn.microsoft.com/library/b5533002-8a72-438d-a3d3-0902ffc21830), [Windows.Globalization.Calendar](../windows.globalization/calendar.md), [CalendarView styles and templates](http://msdn.microsoft.com/library/86079c60-3dca-4282-af51-a687869d8493), [CalendarDatePicker](calendardatepicker.md), [DatePicker](datepicker.md), [TimePicker](timepicker.md), [Controls list](http://msdn.microsoft.com/library/11172840-a63d-4f48-9db4-7baca06308ee), [Controls by function](http://msdn.microsoft.com/library/8db4347b-91d6-4659-91f2-80ecf7bbb596)