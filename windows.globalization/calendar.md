---
-api-id: T:Windows.Globalization.Calendar
-api-type: winrt class
---

<!-- Class syntax.
public class Calendar : Windows.Globalization.ICalendar, Windows.Globalization.ITimeZoneOnCalendar
-->

# Windows.Globalization.Calendar

## -description

Manipulates the representation of a [DateTime](../windows.foundation/datetime.md) within a given calendar and clock.

## -remarks

If your app passes language tags used in this class to any [National Language Support](/windows/desktop/Intl/national-language-support) functions, it must first convert the tags by calling [ResolveLocaleName](/windows/desktop/api/winnls/nf-winnls-resolvelocalename).

Language tags support the Unicode extensions "ca-" and "nu-". (See [Unicode Key/Type Definitions](https://www.unicode.org/reports/tr35/#Key_Type_Definitions).) Note that these extensions can affect the calendar used by Calendar objects.

## -examples

## -see-also

[Calendar, date, and time controls](/windows/uwp/design/controls-and-patterns/date-and-time), [Calendar sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Calendar), [Date and time formatting sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/DateTimeFormatting), [Globalization preferences sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/GlobalizationPreferences), [Prepare your application for the Japanese era change](/windows/uwp/design/globalizing/japanese-era-change)
