---
-api-id: M:Windows.Globalization.Calendar.AddYears(System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public void AddYears(System.Int32 years)
-->

# Windows.Globalization.Calendar.AddYears

## -description
Increments or decrements the year.

## -parameters
### -param years
The number of years by which to increment the year (if the value is positive) or decrement the year (if the value is negative).

## -remarks

> [!NOTE]
> This API is being updated to support the May 2019 Japanese era change. If your application supports the Japanese calendar, you should validate that it properly handles the new era. See [Prepare your application for the Japanese era change](/windows/uwp/design/globalizing/japanese-era-change) for more information.

> [!NOTE]
> This API takes leap years into account when calculating the resulting year. The month and time-of-day part of the resulting Calendar object remains the same as this instance. If the current instance represents the leap day (February 29th) in a leap year, date returned will be February 29th of the resulting year only if that year is a leap year, and February 28th of the resulting year otherwise. For more information on leap years in your app, see [leap year readiness](https://techcommunity.microsoft.com/t5/azure-developer-community-blog/it-s-2020-is-your-code-ready-for-leap-day/ba-p/1157279).

## -examples

## -see-also

[Calendar, date, and time controls](/windows/uwp/design/controls-and-patterns/date-and-time), [Calendar sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Calendar), [Date and time formatting sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/DateTimeFormatting)
