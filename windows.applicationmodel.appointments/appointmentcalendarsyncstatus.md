---
-api-id: T:Windows.ApplicationModel.Appointments.AppointmentCalendarSyncStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Appointments.AppointmentCalendarSyncStatus : int
-->

# AppointmentCalendarSyncStatus

## -description
Specifies the current sync status of an [AppointmentCalendar](appointmentcalendar.md).

## -enum-fields
### -field Idle:0
There is no sync operation currently occurring.

### -field Syncing:1
A sync operation is in progress.

### -field UpToDate:2
The local machine and server are up to date.

### -field AuthenticationError:3
An authentication error occurred when trying to connect to the server.

### -field PolicyError:4
A policy error occurred.

### -field UnknownError:5
An unknown error occurred.

### -field ManualAccountRemovalRequired:6
The account must be manually removed.


## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | ManualAccountRemovalRequired |

## -examples

## -see-also
## -capabilities
appointmentsSystem
