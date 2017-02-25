---
-api-id: T:Windows.Media.Capture.AppBroadcastTriggerDetails
-api-type: winrt class
---

<!-- Class syntax.
public class AppBroadcastTriggerDetails : Windows.Media.Capture.IAppBroadcastTriggerDetails
-->

# Windows.Media.Capture.AppBroadcastTriggerDetails

## -description
Provides details associated with a broadcast app background task.

> [!NOTE]
> This API requires the **appBroadcast** and **appBroadcastSettings** capability which is not available to all Windows apps. Unless your developer account is specially provisioned by Microsoft, calls to this API will fail at runtime.

## -remarks
Get an instance of this class by casting the [TriggerDetails](../windows.applicationmodel.background/ibackgroundtaskinstance_triggerdetails.md) property of the [IBackgroundTaskInstance](../windows.applicationmodel.background/ibackgroundtaskinstance.md) passed into your background task's [Run](../windows.applicationmodel.background/ibackgroundtask_run.md) method.

## -examples

## -see-also

## -capabilities
appBroadcast
appBroadcastSettings