---
-api-id: M:Windows.ApplicationModel.Background.BackgroundTaskRegistration.Unregister(System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public void Unregister(System.Boolean cancelTask)
-->

# Windows.ApplicationModel.Background.BackgroundTaskRegistration.Unregister

## -description
Cancels the registration of a registered background task.

## -parameters
### -param cancelTask
True if currently running instances of this background task should be canceled. If this parameter is false, currently running instances are allowed to finish. Canceled instances receive a Canceled event with a cancellation reason of **Abort**.

## -remarks

## -examples

## -see-also
