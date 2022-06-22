---
-api-id: P:Windows.UI.Xaml.Controls.CalendarViewDayItem.IsBlackout
-api-type: winrt property
---

<!-- Property syntax
public bool IsBlackout { get;  set; }
-->

# Windows.UI.Xaml.Controls.CalendarViewDayItem.IsBlackout

## -description
Gets or sets a value that indicates whether the date is unavailable.



## -xaml-syntax
```xaml

      <CalendarViewDayItem IsBlackout="bool" .../>
    
```


## -property-value
**true** if the date unavailable; otherwise, **false**. The default is **false**.

## -remarks

To mark a date as not selectable, set this property to `true`. For more information, see [Updating calendar day items](/uwp/api/windows.ui.xaml.controls.calendarview#updating-calendar-day-items).

## -examples

## -see-also

[CalendarView.BlackoutForeground](calendarview_blackoutforeground.md), [CalendarView.BlackoutBackground](calendarview_blackoutbackground.md), [Updating calendar day items](/uwp/api/windows.ui.xaml.controls.calendarview#updating-calendar-day-items)
