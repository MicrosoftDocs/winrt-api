---
-api-id: M:Windows.Media.MediaExtensionManager.RegisterMediaExtensionForAppService(Windows.Media.IMediaExtension,Windows.ApplicationModel.AppService.AppServiceConnection)
-api-type: winrt method
---

<!-- Method syntax.
public void MediaExtensionManager.RegisterMediaExtensionForAppService(IMediaExtension extension, AppServiceConnection connection)
-->

# Windows.Media.MediaExtensionManager.RegisterMediaExtensionForAppService


## -description

Registers a media extension that provides a background task that decodes media.

## -parameters

### -param extension

An object that implements [IMediaExtension](../windows.media/imediaextension.md).

### -param connection

An [AppServiceConnection](../windows.applicationmodel.appservice/appserviceconnection.md)  object that represents an endpoint connection for an app service.

## -remarks

Call this method from within the [Run](../windows.applicationmodel.background/ibackgroundtask_run_2017283929.md) method of a Windows Runtime Component that exposes your media extension.

Get an instance of [AppServiceConnection](../windows.applicationmodel.appservice/appserviceconnection.md) by casting the [TriggerDetails](../windows.applicationmodel.background/ibackgroundtaskinstance_triggerdetails.md)  property of the [IBackgroundTaskInstance](../windows.applicationmodel.background/ibackgroundtaskinstance.md) passed into the **Run** method to an [AppServiceTriggerDetails](../windows.applicationmodel.appservice/appservicetriggerdetails.md)  object and then accessing the [AppServiceConnection](../windows.applicationmodel.appservice/appservicetriggerdetails_appserviceconnection.md) property. 

In order for your background task to receive an [AppServiceTriggerDetails](../windows.applicationmodel.appservice/appservicetriggerdetails.md) object, you must register it as an app service in you app manifest file. For more information, see [Create and consume an app service](/windows/uwp/launch-resume/how-to-create-and-consume-an-app-service).

## -see-also

## -examples

