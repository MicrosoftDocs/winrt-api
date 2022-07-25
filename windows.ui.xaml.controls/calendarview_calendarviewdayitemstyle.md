---
-api-id: P:Windows.UI.Xaml.Controls.CalendarView.CalendarViewDayItemStyle
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Style CalendarViewDayItemStyle { get;  set; }
-->

# Windows.UI.Xaml.Controls.CalendarView.CalendarViewDayItemStyle

## -description
Gets or sets the [Style](../windows.ui.xaml/style.md) associated with the control's internal [CalendarViewDayItem](calendarviewdayitem.md) object.



## -xaml-syntax
```xaml

<CalendarView CalendarViewDayItemStyle={StaticResource styleResourceKey}/>
- or -
<CalendarView>
  <CalendarView.CalendarViewDayItemStyle>
    <Style TargetType="CalendarViewDayItem">
      oneOrMoreSetters
    </Style>
  </CalendarView.CalendarViewDayItemStyle>
</CalendarView>
```


## -xaml-values
<dl><dt>styleResourceKey</dt><dd>styleResourceKeyThe key that identifies the style being requested. The key refers to an existing resource in a ResourceDictionary.</dd>
<dt>oneOrMoreSetters</dt><dd>oneOrMoreSettersOne or more Setter elements with Property attributes that target the dependency properties of the CalendarViewDayItem component of the CalendarView template.</dd>
</dl>
## -property-value
The [Style](../windows.ui.xaml/style.md) associated with the control's internal [CalendarViewDayItem](calendarviewdayitem.md) object.

## -remarks

## -examples

## -see-also
[CalendarViewDayItem](calendarviewdayitem.md)
