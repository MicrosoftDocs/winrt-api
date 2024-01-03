---
-api-id: M:Windows.Globalization.DateTimeFormatting.DateTimeFormatter.#ctor(Windows.Globalization.DateTimeFormatting.YearFormat,Windows.Globalization.DateTimeFormatting.MonthFormat,Windows.Globalization.DateTimeFormatting.DayFormat,Windows.Globalization.DateTimeFormatting.DayOfWeekFormat,Windows.Globalization.DateTimeFormatting.HourFormat,Windows.Globalization.DateTimeFormatting.MinuteFormat,Windows.Globalization.DateTimeFormatting.SecondFormat,Windows.Foundation.Collections.IIterable{System.String},System.String,System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public DateTimeFormatter(Windows.Globalization.DateTimeFormatting.YearFormat yearFormat, Windows.Globalization.DateTimeFormatting.MonthFormat monthFormat, Windows.Globalization.DateTimeFormatting.DayFormat dayFormat, Windows.Globalization.DateTimeFormatting.DayOfWeekFormat dayOfWeekFormat, Windows.Globalization.DateTimeFormatting.HourFormat hourFormat, Windows.Globalization.DateTimeFormatting.MinuteFormat minuteFormat, Windows.Globalization.DateTimeFormatting.SecondFormat secondFormat, Windows.Foundation.Collections.IIterable<System.String> languages, System.String geographicRegion, System.String calendar, System.String clock)
-->

# Windows.Globalization.DateTimeFormatting.DateTimeFormatter.DateTimeFormatter

## -description

Creates a [DateTimeFormatter](datetimeformatter.md) object with all formats and identifiers specified.

## -parameters

### -param yearFormat

The desired year format to include in the template.

### -param monthFormat

The desired month format to include in the template.

### -param dayFormat

The desired day format to include in the template.

### -param dayOfWeekFormat

The desired day of week format to include in the template.

### -param hourFormat

The desired hour format to include in the template.

### -param minuteFormat

The desired minute format to include in the template.

### -param secondFormat

The desired second format to include in the template.

### -param languages

The list of language identifiers, in priority order, that represent the choice of languages. These identifiers are used for resolving the template to a pattern, and for formatting. See Remarks.

### -param geographicRegion

The identifier for the geographic region. This identifier is used for resolving the template to a pattern.

### -param calendar

The calendar identifier to use.

### -param clock

The clock identifier to use.

## -remarks

If your app passes language tags used in this class to any [National Language Support](/windows/desktop/Intl/national-language-support) functions, it must first convert the tags by calling [ResolveLocaleName](/windows/desktop/api/winnls/nf-winnls-resolvelocalename).

Language tags support the Unicode extensions "ca-" and "nu-". (See [Unicode Key/Type Definitions](https://www.unicode.org/reports/tr35/#Key_Type_Definitions).) Note that these extensions can affect the calendar used by Calendar objects.

## -examples

## -see-also

[DateTimeFormatter(String)](datetimeformatter_datetimeformatter_290278668.md), [DateTimeFormatter(String, IIterable, String, String, String)](datetimeformatter_datetimeformatter_1042679024.md), [DateTimeFormatter(YearFormat, MonthFormat, DayFormat, DayOfWeekFormat)](datetimeformatter_datetimeformatter_242098968.md), [DateTimeFormatter(HourFormat, MinuteFormat, SecondFormat)](datetimeformatter_datetimeformatter_884240580.md), [Unicode Key/Type Definitions](https://www.unicode.org/reports/tr35/#Key_Type_Definitions)
