---
-api-id: P:Windows.Networking.BackgroundTransfer.BackgroundTransferCompletionGroup.Trigger
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.Background.IBackgroundTrigger Trigger { get; }
-->

# Windows.Networking.BackgroundTransfer.BackgroundTransferCompletionGroup.Trigger

## -description
Gets the [IBackgroundTrigger](../windows.applicationmodel.background/ibackgroundtrigger.md) used to set up the background task associated with the [BackgroundTransferCompletionGroup](backgroundtransfercompletiongroup.md).

## -property-value
The trigger used to set up the background task associated with the [BackgroundTransferCompletionGroup](backgroundtransfercompletiongroup.md).

## -remarks
An [IBackgroundTrigger](../windows.applicationmodel.background/ibackgroundtrigger.md) must be used to set up the [IBackgroundTask](../windows.applicationmodel.background/ibackgroundtask.md) associated with a [BackgroundTransferCompletionGroup](backgroundtransfercompletiongroup.md).

An [IBackgroundTrigger](../windows.applicationmodel.background/ibackgroundtrigger.md) can be associated only with one [IBackgroundTask](../windows.applicationmodel.background/ibackgroundtask.md).

This property never is **NULL**.

## -examples

## -see-also
[IBackgroundTask](../windows.applicationmodel.background/ibackgroundtask.md), [IBackgroundTrigger](../windows.applicationmodel.background/ibackgroundtrigger.md)