---
-api-id: T:Windows.ApplicationModel.AppService.AppServiceConnection
-api-type: winrt class
---

<!-- Class syntax.
public class AppServiceConnection : Windows.ApplicationModel.AppService.IAppServiceConnection, Windows.ApplicationModel.AppService.IAppServiceConnection2, Windows.Foundation.IClosable
-->

# Windows.ApplicationModel.AppService.AppServiceConnection

## -description

Represents a connection to the endpoint for an app service. App services enable app-to-app communication by allowing you to provide services from your Universal Windows app to other Universal Windows app. The AppService provider receives the connection request as part of their background task; see [AppServiceTriggerDetails class](/uwp/api/windows.applicationmodel.appservice.appservicetriggerdetails) for details.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | OpenRemoteAsync |
| 1607 | 14393 | User |
| 1903 | 18362 | SendStatelessMessageAsync |

## -examples

## -see-also

[IClosable](../windows.foundation/iclosable.md), [App services sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/AppServices), [AppServiceTriggerDetails](/uwp/api/windows.applicationmodel.appservice.appservicetriggerdetails)

