---
-api-id: M:Windows.Globalization.Calendar.#ctor(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public Calendar(Windows.Foundation.Collections.IIterable<System.String> languages)
-->

# Windows.Globalization.Calendar.Calendar

## -description

Creates a [Calendar](calendar.md) object that is initialized with a language list.

## -parameters

### -param languages

The list of language identifiers, in priority order, that represents the choice of languages. These are used for resolving patterns to strings.

## -remarks

Language tags support the Unicode extensions "ca-" and "nu-". (See [Unicode Key/Type Definitions](https://www.unicode.org/reports/tr35/#Key_Type_Definitions).) Note that these extensions can affect the calendar used by Calendar objects.

## -examples

## -see-also

[Calendar(IIterable(String), String, String)](calendar_calendar_1820927522.md), [Unicode Key/Type Definitions](https://www.unicode.org/reports/tr35/#Key_Type_Definitions), [Calendar, date, and time controls](/windows/uwp/design/controls-and-patterns/date-and-time), [Calendar sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Calendar), [Date and time formatting sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/DateTimeFormatting)
