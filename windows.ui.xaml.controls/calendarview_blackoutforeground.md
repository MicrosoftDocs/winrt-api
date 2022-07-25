---
-api-id: P:Windows.UI.Xaml.Controls.CalendarView.BlackoutForeground
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Brush BlackoutForeground { get;  set; }
-->

# Windows.UI.Xaml.Controls.CalendarView.BlackoutForeground

## -description
Gets or sets a brush that provides the foreground of a date that can't be selected.



## -xaml-syntax
```xaml
<CalendarView BlackoutForeground="{StaticResource resourceName}"/>
- or -
<CalendarView BlackoutForeground="colorString"/>
- or -
<CalendarView>
  CalendarView.BlackoutForeground>singleBrush</CalendarView.BlackoutForeground>
</CalendarView>

```


## -xaml-values
<dl><dt>resourceName</dt><dd>resourceNameThe resource name (x:Key attribute value) of an existing XAML resource that defines a brush. This is the recommended way to specify Brush values in XAML if you have any intention of using the same colors or brushes in more than one part of your UI. See Remarks in Brush or ResourceDictionary and XAML resource references.</dd>
<dt>colorString</dt><dd>colorStringThe Color for a SolidColorBrush expressed as an attribute string. This can be a named color, an RGB value, or an ScRGB value. RGB or ScRGB may also specify alpha information. See the XAML Values section in Color.</dd>
<dt>singleBrush</dt><dd>singleBrushWithin opening and closing property elements, exactly one object element for an object that derives from Brush. This is typically one of the following classes: LinearGradientBrush, ImageBrush, SolidColorBrush.</dd>
</dl>
## -property-value
A brush that provides the foreground of a date that can't be selected.

## -remarks

To mark a date as not selectable, set the [CalendarViewDayItem.IsBlackout](calendarviewdayitem_isblackout.md) property to `true`. For more information, see [Updating calendar day items](/uwp/api/windows.ui.xaml.controls.calendarview#updating-calendar-day-items).

## -examples

## -see-also

[CalendarViewDayItem.IsBlackout](calendarviewdayitem_isblackout.md), [Updating calendar day items](/uwp/api/windows.ui.xaml.controls.calendarview#updating-calendar-day-items)
