---
-api-id: M:Windows.Globalization.Calendar.CompareDateTime(Windows.Foundation.DateTime)
-api-type: winrt method
---

<!-- Method syntax
public int CompareDateTime(Windows.Foundation.DateTime other)
-->

# Windows.Globalization.Calendar.CompareDateTime

## -description
Compares this calendar to a [DateTime](../windows.foundation/datetime.md) object and indicates whether the date and time of one is earlier, equal to, or later than that of the other.

## -parameters
### -param other
The [DateTime](../windows.foundation/datetime.md) object to compare to the current calendar.

## -returns
One of the following values:

<table>
   <tr><th>Return value</th><th>Description</th></tr>
   <tr><td>Less than zero</td><td>The date and time of this calendar is earlier than that of *other*.</td></tr>
   <tr><td>Zero</td><td>The date and times are equal.</td></tr>
   <tr><td>Greater than zero</td><td>The date and time of this calendar is later than that of *other*.</td></tr>
</table>

## -remarks

## -examples

## -see-also

[Calendar, date, and time controls](/windows/uwp/design/controls-and-patterns/date-and-time), [Calendar sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Calendar), [Date and time formatting sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/DateTimeFormatting)
