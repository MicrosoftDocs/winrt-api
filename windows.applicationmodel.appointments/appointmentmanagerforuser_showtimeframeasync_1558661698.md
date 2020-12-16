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
When this method returns, it does not return a result. On completion, the [AsyncActionCompletedHandler ](../windows.foundation/asyncactioncompletedhandler.md) specified by [get_Completed](/windows/desktop/WinRT/iasyncaction-get-completed) / [Completed](/windows/desktop/api/objidl/nf-objidl-ipersistfile-savecompleted) is invoked.

## -remarks
This method uses parameter values representing date-time and timespan that are represented differently depending on which language you are programming with.
+ In JavaScript, set the *timeToShow* value with a **Date** object. Set the *duration* value with a [TimeSpan](../windows.foundation/timespan.md) representing a time span in 100-nanosecond units.
+ In Visual C++ component extensions (C++/CX), set the *timeToShow* value with a [DateTime](../windows.foundation/datetime.md) structure. Set the *duration* value with a [TimeSpan](../windows.foundation/timespan.md) representing a time span in 100-nanosecond units.
+ In C#, use a [System.DateTimeOffset](/dotnet/api/system.datetimeoffset?view=dotnet-uwp-10.0&preserve-view=true) value for *timeToShow*, and a [System.TimeSpan](/dotnet/api/system.timespan?view=dotnet-uwp-10.0&preserve-view=true) value for *duration*. You can use utility API of these structures to declare the values.


For info about how to manage appointments, see [Manage appointments](/windows/uwp/contacts-and-calendar/managing-appointments).

## -examples

## -see-also

## -capabilities
appointmentsSystem
