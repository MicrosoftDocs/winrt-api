---
-api-id: T:Windows.Globalization.CalendarIdentifiers
-api-type: winrt class
---

<!-- Class syntax.
public class CalendarIdentifiers 
-->

# Windows.Globalization.CalendarIdentifiers

## -description

Contains the calendar identifiers for the supported calendars, as static properties.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | ChineseLunar |
| 1607 | 14393 | JapaneseLunar |
| 1607 | 14393 | KoreanLunar |
| 1607 | 14393 | TaiwanLunar |
| 1607 | 14393 | VietnameseLunar |

## -examples

The following example shows how to specify a [Calendar](calendar.md) system using the [ChangeCalendarSystem](changecalendarsystem.md) method.

```
winrt::Windows::Globalization::Calendar calendar;
calendar.ChangeCalendarSystem(winrt::Windows::Globalization::CalendarIdentifiers::Gregorian);
// Perform Gregorian calendar calculations.
...

calendar.ChangeCalendarSystem(winrt::Windows::Globalization::CalendarIdentifiers::Hebrew);
// Perform Hebrew calendar calculations.
...
```

## -see-also

[Date and time formatting sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/DateTimeFormatting), [Calendar sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=624043)
