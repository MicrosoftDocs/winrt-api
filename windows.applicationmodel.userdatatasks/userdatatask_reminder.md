---
-api-id: P:Windows.ApplicationModel.UserDataTasks.UserDataTask.Reminder
-api-type: winrt property
---

<!-- Property syntax.
public IReference<DateTime> Reminder { get;  set; }
-->

# Windows.ApplicationModel.UserDataTasks.UserDataTask.Reminder

## -description
Gets or sets a time span value. The value declares the amount of time to subtract from the [DueDate](userdatatask_duedate.md), and that time used as the issue time for a reminder for a task. A **null** value indicates that the task won't issue a reminder. [Reminder](userdatatask_reminder.md) is of type [IReference(TimeSpan)](../windows.foundation/ireference_1.md).

## -property-value
A time span value, or **null** to issue no reminder.

## -remarks
This property uses a time span value, which is represented differently depending on which language you are programming with. For more information about how to use a time span value, see the [Duration](../windows.applicationmodel.appointments/appointment_duration.md) property.

## -see-also

## -examples
