---
-api-id: M:Windows.Globalization.Calendar.SetToMin
-api-type: winrt method
---

<!-- Method syntax
public void SetToMin()
-->

# Windows.Globalization.Calendar.SetToMin

## -description
Sets the components of this [Calendar](calendar.md) object to the earliest [DateTime](../windows.foundation/datetime.md) supported.

## -remarks
If you're using a .NET language (for example, C#, or Visual Basic), then use the Coordinated Universal Time (UTC) time zone with a **Calendar** object if you wish to follow this set of steps.
- Call either SetToMin or [SetToMax](calendar_settomax_44967827.md), and then
- Call [GetDateTime](calendar_getdatetime_624256552.md) to convert the **Calendar** to a .NET [System.DateTime](/dotnet/api/system.datetime?view=dotnet-uwp-10.0&preserve-view=true) struct.

If you don't use the Coordinated Universal Time (UTC) time zone, then **GetDateTime** will throw an exception because the computed number of ticks will under- or overflow due to the timezone offset.

## -examples

## -see-also

[Calendar, date, and time controls](/windows/uwp/design/controls-and-patterns/date-and-time), [Calendar sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Calendar), [Date and time formatting sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/DateTimeFormatting)
