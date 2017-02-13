---
-api-id: M:Windows.ApplicationModel.Background.BackgroundTaskBuilder.SetTrigger(Windows.ApplicationModel.Background.IBackgroundTrigger)
-api-type: winrt method
---

<!-- Method syntax
public void SetTrigger(Windows.ApplicationModel.Background.IBackgroundTrigger trigger)
-->

# Windows.ApplicationModel.Background.BackgroundTaskBuilder.SetTrigger

## -description
Sets the event trigger for a background task.

## -parameters
### -param trigger
An instance of an event trigger object such as a [SystemTrigger](systemtrigger.md), [TimeTrigger](timetrigger.md), or [NetworkOperatorNotificationTrigger](networkoperatornotificationtrigger.md).

## -remarks
In addition to specifying the type of event trigger for a background task, an application must also enable background tasks that use the event trigger type in the `<Extensions><Extension><BackgroundTasks>` section of its manifest. Valid types include the following:
+ `<Task Type="audio"/>`
+ `<Task Type="timer"/>`
+ `<Task Type="systemEvent"/>`
+ `<Task Type="pushNotification"/>`
+ `<Task Type="realTimeCommunication"/>`


If the background task type is not specified or specified incorrectly in the manifest, calls that attempt to use that kind of background task will fail.

## -examples

## -see-also
