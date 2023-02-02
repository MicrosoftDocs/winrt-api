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

This example uses a named change tracker to update an application's dashboard with appointment information.

```csharp
private async Task UpdateDashboard(AppointmentStore store)
{
    AppointmentStoreChangeTracker tracker = store.GetChangeTracker("DashboardUpdater");

    // Check to see if we were already tracking. If not then we don't know
    // what changed and we should update everything.
    if (!tracker.IsTracking)
    {
        tracker.Enable();
        UpdateFullDashboard();

        // Don't return yet. We still want to process any changes which
        // happened while we were updating the dashboard.
    }

    // check for changes
    IReadOnlyList<AppointmentStoreChange> changes;
    do
    {
        changes = await tracker.GetChangeReader().ReadBatchAsync();
        foreach (AppointmentStoreChange change in changes)
        {
            UpdateDashboardWidget(change);
        }
    } while (changes.Count > 0);
}
```

## -capabilities

appointmentsSystem
