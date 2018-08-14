---
-api-id: T:Windows.Networking.BackgroundTransfer.BackgroundTransferCompletionGroupTriggerDetails
-api-type: winrt class
---

<!-- Class syntax.
public class BackgroundTransferCompletionGroupTriggerDetails : Windows.Networking.BackgroundTransfer.IBackgroundTransferCompletionGroupTriggerDetails
-->

# Windows.Networking.BackgroundTransfer.BackgroundTransferCompletionGroupTriggerDetails

## -description
Contains information about a [BackgroundTransferCompletionGroup](backgroundtransfercompletiongroup.md) that can be only accessed from the [Run](../windows.applicationmodel.background/ibackgroundtask_run_2017283929.md) method on the [IBackgroundTask](../windows.applicationmodel.background/ibackgroundtask.md).

## -remarks
The [BackgroundTransferCompletionGroup](backgroundtransfercompletiongroup.md) class allows an app to register to receive immediate notification after background transfer operations are complete even if the app is not in the foreground. The app registers a background task to receive notification that occurs if the background transfers completed successfully or if an error occurred. This allows the app to be immediately notified at the time of completion, instead of requiring that the app wait until the next time the app is restarted or moved to the foreground to query for completions.

The app must implement the [IBackgroundTask](../windows.applicationmodel.background/ibackgroundtask.md) to run that receives the completion notifications. The [IBackgroundTask](../windows.applicationmodel.background/ibackgroundtask.md) must be registered using the [BackgroundTaskBuilder](../windows.applicationmodel.background/backgroundtaskbuilder.md) class. The background task must be declared in the app manifest. The app does not require lock screen access to use a [BackgroundTransferCompletionGroup](backgroundtransfercompletiongroup.md).

A [BackgroundTransferCompletionGroupTriggerDetails](backgroundtransfercompletiongrouptriggerdetails.md) instance is created when the background task for a [BackgroundTransferCompletionGroup](backgroundtransfercompletiongroup.md) has received a notification after background transfer operations are complete.

## -examples

## -see-also
[IBackgroundTask](../windows.applicationmodel.background/ibackgroundtask.md), [IBackgroundTask.Run](../windows.applicationmodel.background/ibackgroundtask_run_2017283929.md), [BackgroundTaskBuilder](../windows.applicationmodel.background/backgroundtaskbuilder.md), [BackgroundTransferCompletionGroup](backgroundtransfercompletiongroup.md)