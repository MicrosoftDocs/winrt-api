---
-api-id: P:Windows.Globalization.Calendar.ResolvedLanguage
-api-type: winrt property
---

<!-- Property syntax
public string ResolvedLanguage { get; }
-->

# Windows.Globalization.Calendar.ResolvedLanguage

## -description

Gets the language that was most recently used to perform calendar formatting or operations.

## -property-value

The language from the [priority list of language identifiers](calendar_languages.md) that was most recently used to perform calendar formatting or operations.

## -remarks

Language tags support the Unicode extensions "ca-" and "nu-". (See [Unicode Key/Type Definitions](https://www.unicode.org/reports/tr35/#Key_Type_Definitions).) Note that these extensions can affect the calendar used by Calendar objects.

## -examples

## -see-also

[Calendar, date, and time controls](/windows/uwp/design/controls-and-patterns/date-and-time), [Calendar sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Calendar), [Date and time formatting sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/DateTimeFormatting)
