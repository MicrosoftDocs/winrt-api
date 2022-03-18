---
-api-id: M:Windows.Globalization.Calendar.EraAsString(System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public string EraAsString(System.Int32 idealLength)
-->

# Windows.Globalization.Calendar.EraAsString

## -description

Returns a string representation of the era. The string chosen is closest in length to the ideal length.

## -parameters

### -param idealLength

A positive integer specifying the ideal length, in characters, for the returned string, or 0 specifying the most common abbreviation available.

## -returns

A string representation of the era.

## -remarks

> [!NOTE]
> This API is being updated to support the May 2019 Japanese era change. If your application supports the Japanese calendar, you should validate that it properly handles the new era. See [Prepare your application for the Japanese era change](/windows/uwp/design/globalizing/japanese-era-change) for more information.

## -examples

## -see-also

[EraAsString](calendar_eraasstring_1742852677.md), [Calendar, date, and time controls](/windows/uwp/design/controls-and-patterns/date-and-time), [Calendar sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Calendar), [Date and time formatting sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/DateTimeFormatting)
