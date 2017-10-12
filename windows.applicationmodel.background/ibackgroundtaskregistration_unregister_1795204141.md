---
-api-id: M:Windows.ApplicationModel.Background.IBackgroundTaskRegistration.Unregister(System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public void Unregister(System.Boolean cancelTask)
-->

# Windows.ApplicationModel.Background.IBackgroundTaskRegistration.Unregister

## -description

Unregisters a registered background task.

## -parameters
### -param cancelTask
True if currently running instances of this background task should be canceled. If this parameter is false, currently running instances of this background task should be allowed to finish. Canceled instances receive a Canceled event with a [BackgroundTaskCancellationReason](backgroundtaskcancellationreason.md) of **Abort**.

## -remarks

## -examples

## -see-also
