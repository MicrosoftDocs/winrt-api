---
-api-id: M:Windows.Globalization.Calendar.TimeZoneAsString(System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public string TimeZoneAsString(System.Int32 idealLength)
-->

# Windows.Globalization.Calendar.TimeZoneAsString

## -description
Returns the abbreviated time zone name applicable at the instant of time that this [Calendar](calendar.md) object represents.

## -parameters
### -param idealLength
The desired length of the abbreviation to be returned. Use 0 to request the abbreviation in most common use.

## -returns
The time zone abbreviation that is closest in length to *idealLength*. If there is a tie, the shorter abbreviation is returned. If *idealLength* is 0, the abbreviation in most common use is returned. (An example is "America/Los_Angeles" for Pacific Time.)

## -remarks

## -examples

## -see-also
[TimeZoneAsString](calendar_timezoneasstring_1880050689.md), [Calendar, date, and time controls](/windows/uwp/design/controls-and-patterns/date-and-time), [Calendar sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Calendar), [Date and time formatting sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/DateTimeFormatting)
