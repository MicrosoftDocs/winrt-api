---
-api-id: M:Windows.Globalization.Calendar.#ctor(Windows.Foundation.Collections.IIterable{System.String},System.String,System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Calendar(Windows.Foundation.Collections.IIterable<System.String> languages, System.String calendar, System.String clock, System.String timeZoneId)
-->

# Windows.Globalization.Calendar.Calendar

## -description
Creates a [Calendar](calendar.md) object that is initialized with a language list, calendar, clock, and time zone.

## -parameters
### -param languages
The list of language identifiers, in priority order, representing the choice of languages. These are used for resolving patterns to strings. See Remarks for [Calendar](calendar.md).

### -param calendar
The calendar identifier to use.

### -param clock
The clock identifier to use.

### -param timeZoneId
An identifier from the [IANA Time Zone Database](https://www.iana.org/time-zones) which identifies the time zone that should be used (for example, "America/Los_Angeles" for Pacific Time).

## -remarks

## -examples

## -see-also
[Calendar(IIterable(String))](calendar_calendar_1181929246.md), [Calendar(IIterable(String), String, String)](calendar_calendar_1820927522.md), [Unicode Key/Type Definitions](https://www.unicode.org/reports/tr35/#Key_Type_Definitions)
