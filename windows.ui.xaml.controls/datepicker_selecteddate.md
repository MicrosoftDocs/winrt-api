---
-api-id: P:Windows.UI.Xaml.Controls.DatePicker.SelectedDate
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public IReference<DateTime> SelectedDate { get;  set; }
-->

# Windows.UI.Xaml.Controls.DatePicker.SelectedDate

## -description

Gets or sets the date currently selected in the date picker, or **null** if no date is selected.



## -property-value

The date currently selected in the picker, or **null** if no date is selected.

## -remarks

The date picker control has both [Date](datepicker_date.md) and `SelectedDate` properties. The difference between these is that `Date` is not nullable, while `SelectedDate` is nullable.

The value of `SelectedDate` is used to populate the date picker and is `null` by default. If `SelectedDate` is `null`, the `Date` property is set to 12/31/1600; otherwise, the `Date` value is synchronized with the `SelectedDate` value. When `SelectedDate` is `null`, the picker is 'unset' and shows the field names instead of a date.

To use the `SelectedDate` value in your app, you typically use a data binding to the `SelectedDate` property, or handle the [SelectedDateChanged](datepicker_selecteddatechanged.md) event.

The `SelectedDate` property can't be set as a XAML attribute string, because the Windows Runtime XAML parser doesn't have a conversion logic for converting strings to dates as [DateTime](/uwp/api/windows.foundation.datetime) / [DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true) objects. Here are some suggested ways these objects can be defined in code and set to a date other than the current date.

+ [DateTime](../windows.foundation/datetime.md): Instantiate a [Windows.Globalization.Calendar](../windows.globalization/calendar.md) object (it is initialized to the current date). Set properties such as [Day](../windows.globalization/calendar_day.md) or [Year](../windows.globalization/calendar_year.md), or call methods such as [AddMonths](../windows.globalization/calendar_addmonths_787442092.md), to adjust the date. Then, call [Calendar.GetDateTime](../windows.globalization/calendar_getdatetime_624256552.md) and use the returned [DateTime](../windows.foundation/datetime.md) to set Date.
+ [DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true): Call the  constructor. For the inner [System.DateTime](/dotnet/api/system.datetime?view=dotnet-uwp-10.0&preserve-view=true), use the  constructor signature. Or, construct a default [DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true) (it is initialized to the current date) and call methods such as [AddMonths](/dotnet/api/system.datetimeoffset.addmonths?view=dotnet-uwp-10.0&preserve-view=true).

Another possible technique is to define a date that's available as a data object or in the data context, then set Date as a XAML attribute that references a [{Binding} markup extension](/windows/uwp/xaml-platform/binding-markup-extension) that can access the date as data.

## -see-also

[SelectedDateChanged](datepicker_selecteddatechanged.md), [DatePickerSelectedValueChangedEventArgs](datepickerselectedvaluechangedeventargs.md), [Date picker](/windows/uwp/design/controls-and-patterns/date-picker)

## -examples

This example demonstrates setting the `SelectedDate` property in code.

```xaml
<DatePicker x:Name="myDatePicker"/>
```

```csharp
public MainPage()
{
    this.InitializeComponent();
    myDatePicker.SelectedDate = new DateTimeOffset(new DateTime(1950, 1, 1));
}
```
