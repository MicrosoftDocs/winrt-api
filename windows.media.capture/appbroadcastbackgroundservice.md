---
-api-id: T:Windows.Media.Capture.AppBroadcastBackgroundService
-api-type: winrt class
---

<!-- Class syntax.
public class AppBroadcastBackgroundService : Windows.Media.Capture.IAppBroadcastBackgroundService
-->

# Windows.Media.Capture.AppBroadcastBackgroundService

## -description
Provides an interface between the broadcasting UWP app and the system-hosted broadcast service. This class provides access to objects that facilitate broadcast service authentication, test the bandwidth capabilities of the device's internet to the broadcasting provider service, and allow your task to acquire captured audio and video frames so that they can be sent to the broadcast provider service.

> [!NOTE]
> This API requires the **appBroadcast** and **appBroadcastSettings** capability which is not available to all Windows apps. Unless your developer account is specially provisioned by Microsoft, calls to this API will fail at runtime.

## -remarks
Get an instance of this class by casting the [TriggerDetails](../windows.applicationmodel.background/ibackgroundtaskinstance_triggerdetails.md) property of the [IBackgroundTaskInstance](../windows.applicationmodel.background/ibackgroundtaskinstance.md) passed into your background task's [Run](../windows.applicationmodel.background/ibackgroundtask_run.md) method to a [AppBroadcastTriggerDetails](appbroadcasttriggerdetails.md) and then accessing the [BackgroundService](appbroadcasttriggerdetails_backgroundservice.md) property.

## -examples

## -see-also

## -capabilities
appBroadcast
appBroadcastSettings