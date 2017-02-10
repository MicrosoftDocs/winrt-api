---
-api-id: P:Windows.ApplicationModel.Appointments.Appointment.Duration
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.TimeSpan Duration { get;  set; }
-->

# Windows.ApplicationModel.Appointments.Appointment.Duration

## -description
Gets or sets a time span that represents the time duration of the appointment. [Duration](appointment_duration.md) is of type [TimeSpan](../windows.foundation/timespan.md) and must be non-negative.

## -property-value
A time span that represents the duration of the appointment. The duration can't be a negative value.

## -remarks
This property uses a time span value, which is represented differently depending on which language you are programming with.
+ In JavaScript, set the [Duration](appointment_duration.md) value with a **Number** that represents the time interval. Each unit for a [TimeSpan](../windows.foundation/timespan.md) value represents 1 millisecond. For example, this code sets a [Duration](appointment_duration.md) value to 60 minutes (one hour). ```javascript
appointment.duration = (60 * 60 * 1000); // 1 hour in 1-millisecond units
```


+ In Visual C++ component extensions (C++/CX), use a [TimeSpan](../windows.foundation/timespan.md) structure value with a **Duration** value. In Visual C++ component extensions (C++/CX), each unit for a **Duration** value represents 100 nanoseconds.
+ In C# or Microsoft Visual Basic, you use a [System.TimeSpan](https://msdn.microsoft.com/library/system.timespan.aspx) value. You can use utility API of [System.TimeSpan](https://msdn.microsoft.com/library/system.timespan.aspx) such as [FromSeconds](XREF:TODO:M:System.TimeSpan.FromSeconds(System.Double)) to generate a [System.TimeSpan](https://msdn.microsoft.com/library/system.timespan.aspx) and set the value.




> [!NOTE]
> In JavaScript, [TimeSpan](../windows.foundation/timespan.md) is accessed as a value, not as an object. For example, use `var a = 10000`, not `var a = { duration: 10000 }`. Also, in JavaScript, [TimeSpan](../windows.foundation/timespan.md) is treated as the number of millisecond intervals, not the number of 100-nanosecond intervals so you can lose precision when you port [TimeSpan](../windows.foundation/timespan.md) values between languages.

## -examples

## -see-also
