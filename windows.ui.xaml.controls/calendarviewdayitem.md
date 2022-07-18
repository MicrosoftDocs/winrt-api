---
-api-id: T:Windows.UI.Xaml.Controls.CalendarViewDayItem
-api-type: winrt class
---

<!-- Class syntax.
public class CalendarViewDayItem : Windows.UI.Xaml.Controls.Control, Windows.UI.Xaml.Controls.ICalendarViewDayItem
-->

# Windows.UI.Xaml.Controls.CalendarViewDayItem

## -description
Represents a day on a [CalendarView](calendarview.md).



## -xaml-syntax
```xaml
<CalendarViewDayItem .../>
```


## -remarks
The calendar grid of a [CalendarView](calendarview.md) control is composed of CalendarViewDayItem objects. You typically modify the day item in the [CalendarViewDayItemChanging](calendarview_calendarviewdayitemchanging.md) event of either a [CalendarView](calendarview.md) or [CalendarDatePicker](calendardatepicker.md) control. Use the [Item](calendarviewdayitemchangingeventargs_item.md) property of the [CalendarViewDayItemChangingEventArgs](calendarviewdayitemchangingeventargs.md) to access the CalendarViewDayItem object. For more info, see the, "Updating calendar day items ", section of the [CalendarView](calendarview.md) class remarks.

To improve performance, the visual elements of a CalendarViewDayItem are rendered directly by the control, not defined in the control template as XAML elements. This means you can’t style or re-template these elements. However, [CalendarView](calendarview.md) provides several "calendar item" and "day item" properties that you can use to customize these elements, such as [CalendarItemBackground](calendarview_calendaritembackground.md), [CalendarItemBorderBrush](calendarview_calendaritemborderbrush.md), and [DayItemFontSize](calendarview_dayitemfontsize.md).

Even though the visual elements of a CalendarViewDayItem are rendered directly by the control, you can use [CalendarView.CalendarViewDayItemStyle](calendarview_calendarviewdayitemstyle.md) to set properties like [MinWidth](../windows.ui.xaml/frameworkelement_minwidth.md), [MinHeight](../windows.ui.xaml/frameworkelement_minheight.md), [Margin](../windows.ui.xaml/frameworkelement_margin.md), and [Padding](control_padding.md). The default [Style](../windows.ui.xaml/style.md) (see CalendarViewDayItem styles and template) also includes an empty [ControlTemplate](controltemplate.md) that you can use to inject custom XAML elements into the CalendarViewDayItem. Your XAML elements are rendered on top of the background elements, and below the day number and labels.

Use the [Date](calendarviewdayitem_date.md) property to get the date represented by this day item. The time portions of this property's [DateTime](/dotnet/api/system.datetime?view=dotnet-uwp-10.0&preserve-view=true) value are ignored. If you compare two dates from a [CalendarView](calendarview.md), be sure to compare only the **Date** portion of the [DateTime](/dotnet/api/system.datetime?view=dotnet-uwp-10.0&preserve-view=true) value.

Use the [IsBlackout](calendarviewdayitem_isblackout.md) property to get or set a value that indicates whether the date is unavailable.

Call the [SetDensityColors](calendarviewdayitem_setdensitycolors_669941734.md) method to set the collection of [Color](../windows.ui/color.md) values used to display the density bar.

> [!NOTE]
> The [IsBlackout](calendarviewdayitem_isblackout.md) property and the density colors collection are reset each time the day item container is recycled. If you use these features, you should set the values each time the [CalendarViewDayItemChanging](calendarview_calendarviewdayitemchanging.md) event occurs.

## -examples

## -see-also
[Control](control.md), [CalendarView](calendarview.md), [CalendarView.CalendarViewDayItemChanging](calendarview_calendarviewdayitemchanging.md), [CalendarDatePicker.CalendarViewDayItemChanging](calendardatepicker_calendarviewdayitemchanging.md)
