---
-api-id: M:Windows.ApplicationModel.Appointments.AppointmentStore.GetChangeTracker(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public AppointmentStoreChangeTracker AppointmentStore.GetChangeTracker(String identity)
-->

# Windows.ApplicationModel.Appointments.AppointmentStore.GetChangeTracker

## -description
Gets a [AppointmentStoreChangeTracker](appointmentstorechangetracker.md) that provides functionality for monitoring changes to [Appointment](appointment.md) objects in the [AppointmentStore](appointmentstore.md).
## -parameters
### -param identity
A string that identifies the [AppointmentStoreChangeTracker](appointmentstorechangetracker.md) instance in the store.
## -returns
A [AppointmentStoreChangeTracker](appointmentstorechangetracker.md) that provides functionality for monitoring changes to [Appointment](appointment.md) objects in the [AppointmentStore](appointmentstore.md).
## -remarks
You can create multiple [AppointmentStoreChangeTracker](appointmentstorechangetracker.md) instances by using this method. If you pass in a string that identifies a [AppointmentStoreChangeTracker](appointmentstorechangetracker.md) that already exists in the store, this method returns that instance. If the string that you pass into this method does not identify an existing an existing [AppointmentStoreChangeTracker](appointmentstorechangetracker.md), this method returns a new [AppointmentStoreChangeTracker](appointmentstorechangetracker.md).

You can use the [IsTracking](appointmentstorechangetracker_istracking.md) property of the [AppointmentStoreChangeTracker](appointmentstorechangetracker.md) to determine whether change tracking is enabled for the [AppointmentStoreChangeTracker](appointmentstorechangetracker.md).
## -see-also

## -examples

## -capabilities
appointmentsSystem
