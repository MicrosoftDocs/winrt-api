---
-api-id: M:Windows.Globalization.DateTimeFormatting.DateTimeFormatter.#ctor(System.String,Windows.Foundation.Collections.IIterable{System.String},System.String,System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public DateTimeFormatter(System.String formatTemplate, Windows.Foundation.Collections.IIterable<System.String> languages, System.String geographicRegion, System.String calendar, System.String clock)
-->

# Windows.Globalization.DateTimeFormatting.DateTimeFormatter.DateTimeFormatter

## -description

Creates a [DateTimeFormatter](datetimeformatter.md) object that is initialized by a format template string, language list, geographic region, calendar, and clock.

## -parameters

### -param formatTemplate

A format template string that specifies the requested components. The order of the components is irrelevant. This can also be a format pattern. See the remarks for the [DateTimeFormatter](datetimeformatter.md) class for a list of valid format templates and format patterns.

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

[DateTimeFormatter(String)](datetimeformatter_datetimeformatter_290278668.md), [DateTimeFormatter(YearFormat, MonthFormat, DayFormat, DayOfWeekFormat)](datetimeformatter_datetimeformatter_242098968.md), [DateTimeFormatter(HourFormat, MinuteFormat, SecondFormat)](datetimeformatter_datetimeformatter_884240580.md), [DateTimeFormatter(YearFormat, MonthFormat, DayFormat, DayOfWeekFormat, HourFormat, MinuteFormat, SecondFormat, IIterable, String, String, String)](datetimeformatter_datetimeformatter_321918312.md), [Date and time formatting sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Date%20and%20time%20formatting%20sample), [Unicode Key/Type Definitions](https://www.unicode.org/reports/tr35/#Key_Type_Definitions)
