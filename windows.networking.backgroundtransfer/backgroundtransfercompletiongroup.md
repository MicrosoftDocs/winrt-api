---
-api-id: T:Windows.Networking.BackgroundTransfer.BackgroundTransferCompletionGroup
-api-type: winrt class
---

<!-- Class syntax.
public class BackgroundTransferCompletionGroup : Windows.Networking.BackgroundTransfer.IBackgroundTransferCompletionGroup
-->

# Windows.Networking.BackgroundTransfer.BackgroundTransferCompletionGroup

## -description
Represents a set of background transfer operations ([DownloadOperation](downloadoperation.md) or [UploadOperation](uploadoperation.md) objects) that trigger a background task once all the operations are done (if the operations completed successfully) or fail with an error.

## -remarks
The [BackgroundTransferCompletionGroup](backgroundtransfercompletiongroup.md) class allows an app to register to receive immediate notification after background transfer operations are complete even if the app is not in the foreground. The app registers a background task to receive notification that occurs if the background transfers completed successfully or if an error occurred. This allows the app to be immediately notified at the time of completion, instead of requiring that the app wait until the next time the app is restarted or moved to the foreground to query for completions.

The app must implement the [IBackgroundTask](../windows.applicationmodel.background/ibackgroundtask.md) to run that receives the completion notifications. The [IBackgroundTask](../windows.applicationmodel.background/ibackgroundtask.md) must be registered using the [BackgroundTaskBuilder](../windows.applicationmodel.background/backgroundtaskbuilder.md) class. The background task must be declared in the app manifest. The app does not require lock screen access to use a [BackgroundTransferCompletionGroup](backgroundtransfercompletiongroup.md).

## -examples

## -see-also
[BackgroundTaskBuilder](../windows.applicationmodel.background/backgroundtaskbuilder.md), [DownloadOperation](downloadoperation.md), [IBackgroundTask](../windows.applicationmodel.background/ibackgroundtask.md), [UploadOperation](uploadoperation.md)