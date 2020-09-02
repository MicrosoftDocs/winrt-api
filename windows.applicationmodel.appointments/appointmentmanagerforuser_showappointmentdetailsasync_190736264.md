---
-api-id: M:Windows.ApplicationModel.Appointments.AppointmentManagerForUser.ShowAppointmentDetailsAsync(System.String,Windows.Foundation.DateTime)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction ShowAppointmentDetailsAsync(System.String appointmentId, Windows.Foundation.DateTime instanceStartDate)
-->

# Windows.ApplicationModel.Appointments.AppointmentManagerForUser.ShowAppointmentDetailsAsync

## -description
Shows the Appointments provider Appointment Details UI, to enable the user to view the specified appointment.

## -parameters
### -param appointmentId
The [LocalId](appointment_localid.md) of the appointment to be displayed.

### -param instanceStartDate
A [DateTime](../windows.foundation/datetime.md) object with the start time of the appointment instance to be displayed.

## -returns
When this method returns, it does not return a result. On completion, the [AsyncActionCompletedHandler ](../windows.foundation/asyncactioncompletedhandler.md) specified by [get_Completed](/windows/desktop/WinRT/iasyncaction-get-completed) / [Completed](/windows/desktop/api/objidl/nf-objidl-ipersistfile-savecompleted) is invoked.

## -remarks

## -examples

## -see-also
[ShowAppointmentDetailsAsync(String)](appointmentmanagerforuser_showappointmentdetailsasync_1792084630.md)
## -capabilities
appointmentsSystem
