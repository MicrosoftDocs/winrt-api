---
-api-id: T:Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallStatus
-api-type: winrt class
---

<!-- Class syntax.
public class AppInstallStatus : Windows.ApplicationModel.Store.Preview.InstallControl.IAppInstallStatus, Windows.ApplicationModel.Store.Preview.InstallControl.IAppInstallStatus2
-->

# Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallStatus

## -description
Describes the status of an app that is in the installation queue.

## -remarks
To retrieve an instance of this class, use the [GetCurrentStatus](appinstallitem_getcurrentstatus_1536936899.md) method of the [AppInstallItem](appinstallitem.md) class.

> [!IMPORTANT]
> Access to this API is protected by a private capability that is restricted to apps that are developed by Microsoft.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | ReadyForLaunch |
| 1607 | 14393 | User |
| 1803 | 17134 | IsStaged |

## -examples

## -see-also

## -capabilities
runFullTrust
