---
-api-id: M:Windows.Globalization.Calendar.HourAsPaddedString(System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public string HourAsPaddedString(System.Int32 minDigits)
-->

# Windows.Globalization.Calendar.HourAsPaddedString

## -description

Returns a string representation of the hour, optionally zero-padded.

## -parameters

### -param minDigits

The minimum number of integer digits to be displayed. If the hour does not have enough integer digits, it will be padded with zeros to the correct amount. For example, for the hour 3, a parameter of 1 returns 3, and a parameter of 2 returns 03.

## -returns

A string representation of the hour, in language-specific format (12 or 24 hour clock).

## -remarks

This value is dependent on the Preferred languages setting in Settings -> Time & Language -> Language.

## -examples

## -see-also

[Windows.Globalization.ClockIdentifiers](clockidentifiers.md), [Calendar, date, and time controls](/windows/uwp/design/controls-and-patterns/date-and-time), [Calendar sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Calendar), [Date and time formatting sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/DateTimeFormatting)
