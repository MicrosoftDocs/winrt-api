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
The date and time to be formatted.

### -param timeZoneId
An identifier from the [IANA Time Zone Database](http://go.microsoft.com/fwlink/p/?LinkId=302107) which identifies the time zone that should be used (for example, "Americas/Los_Angeles" for Pacific Time).

## -returns
A string that represents the date, time, and time zone.

## -remarks

> [!NOTE]
> This API is being updated to support the May 2019 Japanese era change. If your application supports the Japanese calendar, you should validate that it properly handles the new era. See [Prepare your application for the Japanese era change](https://docs.microsoft.com/windows/uwp/design/globalizing/japanese-era-change) for more information.

## -examples

## -see-also
[Format(DateTime)](datetimeformatter_format_1437572336.md), [Date and time formatting sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=624044)