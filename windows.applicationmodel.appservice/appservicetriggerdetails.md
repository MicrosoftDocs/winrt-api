---
-api-id: T:Windows.ApplicationModel.AppService.AppServiceTriggerDetails
-api-type: winrt class
---

<!-- Class syntax.
public class AppServiceTriggerDetails : Windows.ApplicationModel.AppService.IAppServiceTriggerDetails, Windows.ApplicationModel.AppService.IAppServiceTriggerDetails2
-->

# Windows.ApplicationModel.AppService.AppServiceTriggerDetails

## -description

Represents details associated with the background task for the app service. App services enable app-to-app communication by allowing you to provide services from your Universal Windows app to other Universal Windows app.

## -remarks

To get the AppServiceTriggerDetails for an app service, use the [IBackgroundTaskInstance.TriggerDetails](../windows.applicationmodel.background/ibackgroundtaskinstance_triggerdetails.md) property.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | IsRemoteSystemConnection |
| 1709 | 16299 | CheckCallerForCapabilityAsync |
| 1903 | 18362 | CallerRemoteConnectionToken |

## -examples

## -see-also

[IBackgroundTaskInstance.TriggerDetails](../windows.applicationmodel.background/ibackgroundtaskinstance_triggerdetails.md), [App services sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/AppServices)
