---
-api-id: M:Windows.Globalization.DateTimeFormatting.DateTimeFormatter.#ctor(Windows.Globalization.DateTimeFormatting.YearFormat,Windows.Globalization.DateTimeFormatting.MonthFormat,Windows.Globalization.DateTimeFormatting.DayFormat,Windows.Globalization.DateTimeFormatting.DayOfWeekFormat,Windows.Globalization.DateTimeFormatting.HourFormat,Windows.Globalization.DateTimeFormatting.MinuteFormat,Windows.Globalization.DateTimeFormatting.SecondFormat,Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public DateTimeFormatter(Windows.Globalization.DateTimeFormatting.YearFormat yearFormat, Windows.Globalization.DateTimeFormatting.MonthFormat monthFormat, Windows.Globalization.DateTimeFormatting.DayFormat dayFormat, Windows.Globalization.DateTimeFormatting.DayOfWeekFormat dayOfWeekFormat, Windows.Globalization.DateTimeFormatting.HourFormat hourFormat, Windows.Globalization.DateTimeFormatting.MinuteFormat minuteFormat, Windows.Globalization.DateTimeFormatting.SecondFormat secondFormat, Windows.Foundation.Collections.IIterable<System.String> languages)
-->

# Windows.Globalization.DateTimeFormatting.DateTimeFormatter.DateTimeFormatter

## -description
Creates a [DateTimeFormatter](datetimeformatter.md) object that is initialized with year, month, day, day of week, hour, minute, and second formats, and a language list.

## -parameters
### -param yearFormat
The year format to include in the template.

### -param monthFormat
The month format to include in the template.

### -param dayFormat
The day format to include in the template.

### -param dayOfWeekFormat
The day of week format to include in the template.

### -param hourFormat
The hour format to include in the template.

### -param minuteFormat
The minute format to include in the template.

### -param secondFormat
The second format to include in the template.

### -param languages
The list of language identifiers, in priority order, that represent the choice of languages. These identifiers are used for resolving the template to a pattern and for formatting. See Remarks.

## -remarks
If your app passes language tags used in this class to any [National Language Support](https://msdn.microsoft.com/library/7a548074-0782-45e1-8051-80c3b9d81885) functions, it must first convert the tags by calling [ResolveLocaleName](https://msdn.microsoft.com/library/99264b22-3fb5-47e2-b0b9-42a6768e67c1).

**Starting in :** Language tags support the Unicode extensions "ca-" and "nu-". (See [Unicode Key/Type Definitions](https://go.microsoft.com/fwlink/p/?LinkId=308919).) Note that the "ca-" extension can affect the calendar used by [DateTimeFormatter](datetimeformatter.md) objects.

## -examples

## -see-also
[DateTimeFormatter(String)](datetimeformatter_datetimeformatter_290278668.md), [DateTimeFormatter(String, IIterable(String))](datetimeformatter_datetimeformatter_204585840.md), [DateTimeFormatter(String, IIterable(String), String, String, String)](datetimeformatter_datetimeformatter_1042679024.md), [DateTimeFormatter(YearFormat, MonthFormat, DayFormat, DayOfWeekFormat)](datetimeformatter_datetimeformatter_242098968.md), [DateTimeFormatter(HourFormat, MinuteFormat, SecondFormat)](datetimeformatter_datetimeformatter_884240580.md), [DateTimeFormatter(YearFormat, MonthFormat, DayFormat, DayOfWeekFormat, HourFormat, MinuteFormat, SecondFormat, IIterable(String), String, String, String)](datetimeformatter_datetimeformatter_321918312.md), [Unicode Key/Type Definitions](https://go.microsoft.com/fwlink/p/?LinkId=308919)
