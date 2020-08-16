---
-api-id: M:Windows.Globalization.Calendar.Compare(Windows.Globalization.Calendar)
-api-type: winrt method
---

<!-- Method syntax
public int Compare(Windows.Globalization.Calendar other)
-->

# Windows.Globalization.Calendar.Compare

## -description
Compares this calendar to another [Calendar](calendar.md) object and indicates whether the [DateTime](../windows.foundation/datetime.md) of one is earlier, equal to, or later than that of the other.

## -parameters
### -param other
The [Calendar](calendar.md) object to compare to the current calendar.

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
