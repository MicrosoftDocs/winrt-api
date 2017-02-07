---
-api-id: T:Windows.ApplicationModel.Background.BackgroundTaskCancellationReason
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Background.BackgroundTaskCancellationReason : int
-->

# BackgroundTaskCancellationReason

## -description
Specifies the reasons for cancelling a background task.

## -enum-fields
### -field Abort:0
The background task was canceled by the application. This can happen for one of the following four reasons: 
+ The task is considered an idle task. This means that the background task is still running, but without doing anything – for example, a JavaScript task that does not call the **close()** function.
+ The background task uses the [MaintenanceTrigger](maintenancetrigger.md) and the system transitions to DC (battery power).
+ The app unregisters the background task, in which case the task is cancelled if it is currently running.
+ The app that registered the background task is uninstalled while the task is running.


### -field Terminating:1
The background task was canceled because the application is about to be terminated due to system policy. The application should save any state that will be needed when the application restarts.

### -field LoggingOff:2
The background task was canceled because the user has logged off the system.

### -field ServicingUpdate:3
The background task was canceled because the application was updated.

### -field IdleTask:4
The background task was canceled because it was active, but not doing any work.

### -field Uninstall:5
The background task was canceled because the application was uninstalled.

### -field ConditionLoss:6
The background task was canceled because one or more of its required conditions is no longer met.

### -field SystemPolicy:7
The background task was cancelled because of system policy.

### -field QuietHoursEntered:8
The background task was cancelled because the device entered the quiet hours period.

> [!NOTE]
> **QuietHoursEntered** is no longer available for use as of Windows 10.

### -field ExecutionTimeExceeded:9
The background task was cancelled because it exceeded its allotted time to run.

### -field ResourceRevocation:10
The background task was cancelled because the system needed additional resources. The background task was cancelled to free up those resources.

### -field EnergySaver:11
The background task was cancelled because of the current Energy Saver policy.


## -remarks

## -examples

## -see-also