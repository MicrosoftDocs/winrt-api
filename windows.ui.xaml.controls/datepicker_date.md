---
-api-id: P:Windows.UI.Xaml.Controls.DatePicker.Date
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.DateTime Date { get;  set; }
-->

# Windows.UI.Xaml.Controls.DatePicker.Date

## -description
Gets or sets the date currently set in the date picker.

## -property-value
The date currently set in the picker.

## -remarks
The Date property can't be set as a XAML attribute string, because the Windows Runtime XAML parser doesn't have a conversion logic for converting strings to dates as [DateTime](../windows.foundation/datetime.md) / [DateTimeOffset](/dotnet/api/system.datetimeoffset?redirectedfrom=MSDN) objects. Here are some suggested ways these objects can be defined in code and set to a date other than the current date.
+ [DateTime](../windows.foundation/datetime.md): Instantiate a [Windows.Globalization.Calendar](../windows.globalization/calendar.md) object (it is initialized to the current date). Set properties such as [Day](../windows.globalization/calendar_day.md) or [Year](../windows.globalization/calendar_year.md), or call methods such as [AddMonths](../windows.globalization/calendar_addmonths_787442092.md), to adjust the date. Then, call [Calendar.GetDateTime](../windows.globalization/calendar_getdatetime_624256552.md) and use the returned [DateTime](../windows.foundation/datetime.md) to set Date.
+ [DateTimeOffset](/dotnet/api/system.datetimeoffset?redirectedfrom=MSDN): Call the  constructor. For the inner [System.DateTime](/dotnet/api/system.datetime?redirectedfrom=MSDN), use the  constructor signature. Or, construct a default [DateTimeOffset](/dotnet/api/system.datetimeoffset?redirectedfrom=MSDN) (it is initialized to the current date) and call methods such as [AddMonths](/dotnet/api/system.datetimeoffset.addmonths#System_DateTimeOffset_AddMonths_System_Int32_).


Another possible technique is to define a date that's available as a data object or in the data context, then set Date as a XAML attribute that references a [{Binding} markup extension](/windows/uwp/xaml-platform/binding-markup-extension) that can access the date as data.

## -examples

## -see-also
[DateChanged](datepicker_datechanged.md), [Quickstart: Adding a DatePicker](/previous-versions/windows/apps/dn308514(v=win.10)), [XAML DatePicker and TimePicker controls sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20DatePicker%20and%20TimePicker%20controls%20sample)
