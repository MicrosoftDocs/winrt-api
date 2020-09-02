---
-api-id: P:Windows.Globalization.Calendar.NumberOfYearsInThisEra
-api-type: winrt property
---

<!-- Property syntax
public int NumberOfYearsInThisEra { get; }
-->

# Windows.Globalization.Calendar.NumberOfYearsInThisEra

## -description
Gets the number of years in the current era of this [Calendar](calendar.md) object.

## -property-value
The number of years in the current era, or – 1 if there is no known bound to the number of years in the current era.

## -remarks

> [!NOTE]
> This API is being updated to support the May 2019 Japanese era change. If your application supports the Japanese calendar, you should validate that it properly handles the new era. See [Prepare your application for the Japanese era change](/windows/uwp/design/globalizing/japanese-era-change) for more information.

## -examples

## -see-also

[Calendar, date, and time controls](/windows/uwp/design/controls-and-patterns/date-and-time), [Calendar sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Calendar), [Date and time formatting sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/DateTimeFormatting)
