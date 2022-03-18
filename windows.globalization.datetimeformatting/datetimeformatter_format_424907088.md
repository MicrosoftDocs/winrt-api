---
-api-id: M:Windows.Globalization.DateTimeFormatting.DateTimeFormatter.Format(Windows.Foundation.DateTime,System.String)
-api-type: winrt method
---

<!-- Method syntax
public string Format(Windows.Foundation.DateTime datetime, System.String timeZoneId)
-->

# Windows.Globalization.DateTimeFormatting.DateTimeFormatter.Format

## -description

Returns a string that represents the given date and time in the given time zone, conforming to the template the formatter is currently using.

## -parameters

### -param datetime

The date, time, and timezone to be formatted.

### -param timeZoneId

An identifier from the [IANA Time Zone Database](https://www.iana.org/time-zones) that identifies the time zone to use (for example, "Americas/Los_Angeles" for Pacific Time).

## -returns

A string that represents the date, time, and time zone.

## -remarks

> [!NOTE]
> If your application supports the Japanese calendar, you should validate that it properly handles the May 2019 Japanese era change. See [Prepare your application for the Japanese era change](/windows/uwp/design/globalizing/japanese-era-change) for more information.

## -examples

## -see-also

[Date and time formatting sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/DateTimeFormatting)
