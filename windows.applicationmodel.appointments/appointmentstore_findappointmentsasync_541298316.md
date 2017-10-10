---
-api-id: M:Windows.ApplicationModel.Appointments.AppointmentStore.FindAppointmentsAsync(Windows.Foundation.DateTime,Windows.Foundation.TimeSpan,Windows.ApplicationModel.Appointments.FindAppointmentsOptions)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.ApplicationModel.Appointments.Appointment>> FindAppointmentsAsync(Windows.Foundation.DateTime rangeStart, Windows.Foundation.TimeSpan rangeLength, Windows.ApplicationModel.Appointments.FindAppointmentsOptions options)
-->

# Windows.ApplicationModel.Appointments.AppointmentStore.FindAppointmentsAsync

## -description
Retrieves a list of appointments in the appointment calendar that fall within the specified date range and meet the criteria specified by the supplied [FindAppointmentsOptions](findappointmentsoptions.md) object..

## -parameters
### -param rangeStart
The start of the date range for which appointments are retrieved.

### -param rangeLength
The length of the date range for which appointments are retrieved. If the *rangeLength* parameter is set to 0, no appointments will be returned. Even if appointments exist on the device that have a [StartTime](appointment_starttime.md) that is exactly the same as the *rangeStart* value, the returned list will be empty.

### -param options
A [FindAppointmentsOptions](findappointmentsoptions.md) object that is used to specify more options for this operation. You must set the *options* parameter to specify the values to retrieve.

## -returns
An asynchronous operation that returns an [IVectorView](../windows.foundation.collections/ivectorview_1.md) list of [Appointment](appointment.md) objects upon successful completion.

## -remarks
> [!IMPORTANT]
> For performance reasons, [FindAppointmentsAsync](appointmentstore_findappointmentsasync.md) will not load most properties. To load specific properties, add values to the [FindAppointmentsOptions.FetchProperties](findappointmentsoptions_fetchproperties.md) member in the *options* parameter. See the example below for more info.

## -examples
Set [FindAppointmentOptions.FetchProperties](findappointmentsoptions_fetchproperties.md) to specify the values to retrieve.

```csharp
AppointmentStore calendar = await AppointmentManager.RequestStoreAsync(AppointmentStoreAccessType.AllCalendarsReadOnly);

// Specify which values to retrieve
FindAppointmentsOptions options = new FindAppointmentsOptions(); 
options.FetchProperties.Add(AppointmentProperties.Subject); 
options.FetchProperties.Add(AppointmentProperties.Details); 
options.FetchProperties.Add(AppointmentProperties.DetailsKind);

var iteratingAppointments = await calendar.FindAppointmentsAsync(DateTimeOffset.Now, TimeSpan.FromDays(31), options);

foreach (var i in iteratingAppointments) 
{ 
  // do stuff with each appointment 
}
```



## -see-also
[FindAppointmentsAsync(DateTime, TimeSpan)](appointmentstore_findappointmentsasync_1659613836.md), [Appointment](appointment.md)
## -capabilities
appointmentsSystem
