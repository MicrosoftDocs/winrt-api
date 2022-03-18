---
-api-id: P:Windows.ApplicationModel.Appointments.Appointment.StartTime
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.DateTime StartTime { get;  set; }
-->

# Windows.ApplicationModel.Appointments.Appointment.StartTime

## -description
Gets or sets the starting time for the appointment. StartTime is of type [DateTime](../windows.foundation/datetime.md).

## -property-value
The date and time to use as the starting time for the appointment.

## -remarks
This property uses an object representing date and time, and that object is represented differently depending on which language you are programming with.
+ In JavaScript, set the StartTime value with a **Date** object. For example, this code sets a StartTime value to a specific date and time. ```javascript
appointment.startTime = new Date(2015, 9, 10, 9); // October 10th, 2015 at 9:00am
```


+ In Visual C++ component extensions (C++/CX), use a [DateTime](../windows.foundation/datetime.md) structure value.
+ In C# or Microsoft Visual Basic, you use a [System.DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true) value. You can use utility API of [System.DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true) to generate a [DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true) from different inputs (local time, parsed strings, and so on) and set the value.


## -examples

## -see-also

## -capabilities
appointmentsSystem
