---
-api-id: M:Windows.ApplicationModel.Appointments.AppointmentManagerForUser.ShowTimeFrameAsync(Windows.Foundation.DateTime,Windows.Foundation.TimeSpan)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction ShowTimeFrameAsync(Windows.Foundation.DateTime timeToShow, Windows.Foundation.TimeSpan duration)
-->

# Windows.ApplicationModel.Appointments.AppointmentManagerForUser.ShowTimeFrameAsync

## -description
Shows the Appointments provider app's primary UI. This typically displays a time frame from an appointments calendar.

## -parameters
### -param timeToShow
A date and time object that specifies the beginning of the time frame that the Appointments provider app should display.

### -param duration
A timespan that hints to the Appointments provider app how long the time frame shown should be.

## -returns
When this method returns, it does not return a result. On completion, the [AsyncActionCompletedHandler ](../windows.foundation/asyncactioncompletedhandler.md) specified by [get_Completed](http://msdn.microsoft.com/library/5050bf84-f9e0-4b3e-9252-6c5c1060826e) / [Completed](http://msdn.microsoft.com/library/eda29981-0c24-409a-8fb9-2dc2eb96d108) is invoked.

## -remarks
This method uses parameter values representing date-time and timespan that are represented differently depending on which language you are programming with.
+ In JavaScript, set the *timeToShow* value with a **Date** object. Set the *duration* value with a [TimeSpan](../windows.foundation/timespan.md) representing a time span in 100-nanosecond units.
+ In Visual C++ component extensions (C++/CX), set the *timeToShow* value with a [DateTime](../windows.foundation/datetime.md) structure. Set the *duration* value with a [TimeSpan](../windows.foundation/timespan.md) representing a time span in 100-nanosecond units.
+ In C#, use a [System.DateTimeOffset](https://msdn.microsoft.com/library/system.datetimeoffset.aspx) value for *timeToShow*, and a [System.TimeSpan](https://msdn.microsoft.com/library/system.timespan.aspx) value for *duration*. You can use utility API of these structures to declare the values.


For info about how to manage appointments, see [Manage appointments](http://msdn.microsoft.com/library/292e9249-07c3-4791-b32c-6ec153c2b538).

## -examples

## -see-also

## -capabilities
appointmentsSystem
