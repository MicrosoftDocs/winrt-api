---
-api-id: P:Windows.UI.Xaml.Controls.DatePicker.MaxYear
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.DateTime MaxYear { get;  set; }
-->

# Windows.UI.Xaml.Controls.DatePicker.MaxYear

## -description
Gets or sets the maximum Gregorian year available for picking.

## -property-value
The maximum Gregorian year available for picking.

## -remarks
The [MaxYear](datepicker_maxyear.md) property can't be set as a XAML attribute string, because the Windows Runtime XAML parser doesn't have a conversion logic for converting strings to dates as [DateTime](../windows.foundation/datetime.md) / [DateTimeOffset](https://msdn.microsoft.com/library/system.datetimeoffset.aspx) objects. Here are some suggested ways these objects can be defined in code and set to a date other than the current date.
+ [DateTime](../windows.foundation/datetime.md): Instantiate a [Windows.Globalization.Calendar](../windows.globalization/calendar.md) object (it is initialized to the current date). Set [Year](../windows.globalization/calendar_year.md), or call [AddYears](../windows.globalization/calendar_addyears_1853430648.md), to adjust the date. Then, call [Calendar.GetDateTime](../windows.globalization/calendar_getdatetime_624256552.md) and use the returned [DateTime](../windows.foundation/datetime.md) to set [MaxYear](datepicker_maxyear.md).
+ [DateTimeOffset](https://msdn.microsoft.com/library/system.datetimeoffset.aspx): Call the  constructor. For the inner [System.DateTime](https://msdn.microsoft.com/library/system.datetime.aspx), use the  constructor signature. Or, construct a default [DateTimeOffset](https://msdn.microsoft.com/library/system.datetimeoffset.aspx) (it is initialized to the current date) and call [AddYears](https://docs.microsoft.com/dotnet/api/system.datetimeoffset.addyears).


Another possible technique is to define a date that's available as a data object or in the data context, then set [MaxYear](datepicker_maxyear.md) as a XAML attribute that references a [{Binding} markup extension](http://msdn.microsoft.com/library/3bafe7b5-af33-487f-9ad5-beafd65d04c3) that can access the date as data.

## -examples

## -see-also
[MinYear](datepicker_minyear.md), [Quickstart: Adding a DatePicker](http://msdn.microsoft.com/library/feae870d-e423-457b-9d0a-3929247952a9)