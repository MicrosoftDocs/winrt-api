---
-api-id: T:Windows.Globalization.Calendar
-api-type: winrt class
---

<!-- Class syntax.
public class Calendar : Windows.Globalization.ICalendar, Windows.Globalization.ITimeZoneOnCalendar
-->

# Windows.Globalization.Calendar

## -description
Manipulates the representation of a date and time within a given calendar and clock.

## -remarks
If your app passes language tags used in this class to any [National Language Support](http://msdn.microsoft.com/library/7a548074-0782-45e1-8051-80c3b9d81885) functions, it must first convert the tags by calling [ResolveLocaleName](http://msdn.microsoft.com/library/99264b22-3fb5-47e2-b0b9-42a6768e67c1).

**Starting in :** Language tags support the Unicode extensions "ca-" and "nu-". (See [Unicode Key/Type Definitions](http://go.microsoft.com/fwlink/p/?LinkId=308919).) Note that these extensions can affect the calendar used by [Calendar](calendar.md) objects.

## -examples

## -see-also
[Calendar sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=624043), [Globalization preferences sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=624045)