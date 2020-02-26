---
-api-id: M:Windows.Globalization.Calendar.YearAsPaddedString(System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public string YearAsPaddedString(System.Int32 minDigits)
-->

# Windows.Globalization.Calendar.YearAsPaddedString

## -description
Returns a string representation of the year, optionally zero-padded.

## -parameters
### -param minDigits
The minimum number of integer digits to be displayed. If the year does not have enough integer digits, it will be padded with zeros to the correct amount. For example, for the year 42, a parameter of 1 or 2 returns 42, and a parameter of 3 returns 042.

## -returns
A string representation of the year.

## -remarks

## -examples

## -see-also

[Calendar, date, and time controls](/windows/uwp/design/controls-and-patterns/date-and-time), [Calendar sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Calendar), [Date and time formatting sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/DateTimeFormatting)
