---
-api-id: T:Windows.Foundation.TimeSpan
-api-type: winrt struct
---

<!-- Structure syntax.
public struct TimeSpan 
-->

# TimeSpan

## -description
Represents a time interval as a signed 64-bit integer value.



> **.NET**
> When programming with .NET, this structure is hidden and developers should use the [System.TimeSpan](https://msdn.microsoft.com/library/system.timespan.aspx) type.

## -struct-fields

### -field Duration
A time period expressed in 100-nanosecond units. In C++/WinRT, this field does not exist, because **TimeSpan** is a specialization of [std::chrono::duration](https://docs.microsoft.com/cpp/standard-library/duration-class). If you need the raw integer value, use duration's [count()](https://docs.microsoft.com/cpp/standard-library/duration-class#count) method to obtain the raw value.
    

## -remarks
When programming with .NET, this structure is hidden and developers should use the [System.TimeSpan](https://msdn.microsoft.com/library/system.timespan.aspx) structure.

In JavaScript, this structure is accessed as a value, not as an object. For example, use `var a = 10000`, not `var a = { duration: 10000 }`.



> [!NOTE]
> In JavaScript, [TimeSpan](timespan.md) values interpreted as **Number** are treated as the number of millisecond intervals, not the number of 100-nanosecond intervals. Therefore, [Windows.Foundation.TimeSpan](timespan.md) values can lose precision when being ported between languages.

## -examples

## -see-also
[DateTime](datetime.md), [System.TimeSpan](https://msdn.microsoft.com/library/system.timespan.aspx)