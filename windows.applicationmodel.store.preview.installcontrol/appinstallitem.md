---
-api-id: T:Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallItem
-api-type: winrt class
---

<!-- Class syntax.
public class AppInstallItem : Windows.ApplicationModel.Store.Preview.InstallControl.IAppInstallItem, Windows.ApplicationModel.Store.Preview.InstallControl.IAppInstallItem2
-->

# Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallItem

## -description
Represents an app that is in the installation queue.

## -remarks
Use the [AppInstallManager.AppInstallItems](appinstallmanager_appinstallitems.md) property to retrieve a vector view of AppInstallItem objects.

> [!IMPORTANT]
> Access to this API is protected by a private capability that is restricted to apps that are developed by Microsoft.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | Cancel(String) |
| 1511 | 10586 | Pause(String) |
| 1511 | 10586 | Restart(String) |
| 1703 | 15063 | Children |
| 1703 | 15063 | ItemOperationsMightAffectOtherItems |
| 1803 | 17134 | LaunchAfterInstall |
| 1809 | 17763 | CompletedInstallToastNotificationMode |
| 1809 | 17763 | InstallInProgressToastNotificationMode |
| 1809 | 17763 | PinToDesktopAfterInstall |
| 1809 | 17763 | PinToStartAfterInstall |
| 1809 | 17763 | PinToTaskbarAfterInstall |

## -examples

## -see-also

## -capabilities
runFullTrust
