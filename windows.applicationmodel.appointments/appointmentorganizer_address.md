---
-api-id: P:Windows.ApplicationModel.Appointments.AppointmentOrganizer.Address
-api-type: winrt property
---

<!-- Property syntax
public string Address { get;  set; }
-->

# Windows.ApplicationModel.Appointments.AppointmentOrganizer.Address

## -description
Gets or sets a string that communicates the address of the organizer of an appointment. The address is required, inherited from [IAppointmentParticipant](iappointmentparticipant.md), and a Simple Mail Transfer Protocol (SMTP) e-mail address. It is also of type [String](/dotnet/api/system.string?view=dotnet-uwp-10.0&preserve-view=true) and between 1 and 321 characters in length (non-empty).

## -property-value
The address of the organizer of an appointment.

## -remarks
When saving an appointment that has an [AppointmentOrganizer](appointmentorganizer.md) with an email address, if the address contains one of the characters listed in the table below, which are not allowed for this property, the address will be saved incorrectly and an exception won’t be thrown: ‘&lt;’, ‘&gt;’, ‘:’, ‘;’, ‘\’.

## -examples

## -see-also

## -capabilities
appointmentsSystem
