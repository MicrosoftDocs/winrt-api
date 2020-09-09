---
-api-id: P:Windows.UI.Xaml.Controls.DatePicker.MinYear
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.DateTime MinYear { get;  set; }
-->

# Windows.UI.Xaml.Controls.DatePicker.MinYear

## -description
Gets or sets the minimum Gregorian year available for picking.

## -property-value
The minimum Gregorian year available for picking.

## -remarks
The MinYear property can't be set as a XAML attribute string, because the Windows Runtime XAML parser doesn't have a conversion logic for converting strings to dates as [DateTime](../windows.foundation/datetime.md) / [DateTimeOffset](/dotnet/api/system.datetimeoffset?redirectedfrom=MSDN) objects. Here are some suggested ways these objects can be defined in code and set to a date other than the current date.
+ [DateTime](../windows.foundation/datetime.md): Instantiate a [Windows.Globalization.Calendar](../windows.globalization/calendar.md) object (it is initialized to the current date). Set [Year](../windows.globalization/calendar_year.md), or call [AddYears](../windows.globalization/calendar_addyears_1853430648.md), to adjust the date. Then, call [Calendar.GetDateTime](../windows.globalization/calendar_getdatetime_624256552.md) and use the returned [DateTime](../windows.foundation/datetime.md) to set MinYear.
+ [DateTimeOffset](/dotnet/api/system.datetimeoffset?redirectedfrom=MSDN): Call the  constructor. For the inner [System.DateTime](/dotnet/api/system.datetime?redirectedfrom=MSDN), use the  constructor signature. Or, construct a default [DateTimeOffset](/dotnet/api/system.datetimeoffset?redirectedfrom=MSDN) (it is initialized to the current date) and call [AddYears](/dotnet/api/system.datetimeoffset.addyears).


Another possible technique is to define a date that's available as a data object or in the data context, then set MinYear as a XAML attribute that references a [{Binding} markup extension](/windows/uwp/xaml-platform/binding-markup-extension) that can access the date as data.

## -examples

## -see-also
[MaxYear](datepicker_maxyear.md), [Quickstart: Adding a DatePicker](/previous-versions/windows/apps/dn308514(v=win.10))
