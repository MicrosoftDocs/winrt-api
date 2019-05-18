---
-api-id: T:Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager
-api-type: winrt class
---

<!-- Class syntax.
public class AppInstallManager : Windows.ApplicationModel.Store.Preview.InstallControl.IAppInstallManager, Windows.ApplicationModel.Store.Preview.InstallControl.IAppInstallManager2, Windows.ApplicationModel.Store.Preview.InstallControl.IAppInstallManager3, Windows.ApplicationModel.Store.Preview.InstallControl.IAppInstallManager4
-->

# Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager

## -description
Provides members for programmatically installing apps, including the ability to start an app install and get a list of app installs currently in progress.

## -remarks

> [!IMPORTANT]
> Access to this API is protected by a private capability that is restricted to apps that are developed by Microsoft.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | Cancel(String,String) |
| 1511 | 10586 | GetIsAppAllowedToInstallAsync(String,String,String,String) |
| 1511 | 10586 | Pause(String,String) |
| 1511 | 10586 | Restart(String,String) |
| 1511 | 10586 | SearchForAllUpdatesAsync(String) |
| 1511 | 10586 | SearchForUpdatesAsync(String,String,String,String) |
| 1511 | 10586 | StartAppInstallAsync(String,String,Boolean,Boolean,String,String,String) |
| 1511 | 10586 | UpdateAppByPackageFamilyNameAsync(String,String) |
| 1607 | 14393 | GetIsAppAllowedToInstallForUserAsync |
| 1607 | 14393 | GetIsApplicableForUserAsync |
| 1607 | 14393 | MoveToFrontOfDownloadQueue |
| 1607 | 14393 | SearchForAllUpdatesForUserAsync(User,String) |
| 1607 | 14393 | SearchForUpdatesForUserAsync(User,String,String,String,String) |
| 1607 | 14393 | StartProductInstallAsync(String,String,String,String,Boolean,Boolean,String,PackageVolume) |
| 1607 | 14393 | StartProductInstallForUserAsync(User,String,String,String,String,Boolean,Boolean,String,PackageVolume) |
| 1607 | 14393 | UpdateAppByPackageFamilyNameForUserAsync |
| 1703 | 15063 | AppInstallItemsWithGroupSupport |
| 1703 | 15063 | GetFreeDeviceEntitlementAsync |
| 1703 | 15063 | GetFreeUserEntitlementAsync |
| 1703 | 15063 | GetFreeUserEntitlementForUserAsync |
| 1803 | 17134 | GetIsPackageIdentityAllowedToInstallAsync |
| 1803 | 17134 | GetIsPackageIdentityAllowedToInstallForUserAsync |
| 1803 | 17134 | SearchForAllUpdatesAsync(String,String,AppUpdateOptions) |
| 1803 | 17134 | SearchForAllUpdatesForUserAsync(User,String,String,AppUpdateOptions) |
| 1803 | 17134 | SearchForUpdatesAsync(String,String,String,String,AppUpdateOptions) |
| 1803 | 17134 | SearchForUpdatesForUserAsync(User,String,String,String,String,AppUpdateOptions) |
| 1803 | 17134 | StartProductInstallAsync(String,String,String,String,AppInstallOptions) |
| 1803 | 17134 | StartProductInstallForUserAsync(User,String,String,String,String,AppInstallOptions) |
| 1809 | 17763 | CanInstallForAllUsers |

## -examples

## -see-also

## -capabilities
runFullTrust
