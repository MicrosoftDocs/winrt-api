---
-api-id: T:Windows.Management.Deployment.AddPackageByAppInstallerOptions
-api-type: winrt enum
ms.custom: 19H1
---

<!-- Enumeration syntax.
public enum AddPackageByAppInstallerOptions : uint 
-->

# Windows.Management.Deployment.AddPackageByAppInstallerOptions

## -description
A subset of [DeploymentOptions](deploymentoptions.md) that are valid for App Installer.

## -enum-fields
### -field None:0
The default behavior is used.

### -field InstallAllResources:32
When you set this option, the app is instructed to skip resource applicability checks. This effectively stages or registers all resource packages that a user passes in to the command, which forces applicability for all packages contained in a bundle. If a user passes in a bundle, all contained resource packages will be registered.

### -field ForceTargetAppShutdown:64
If this package is currently in use, the processes associated with the package are shut down forcibly so that registration can continue.

### -field RequiredContentGroupOnly:256
When you set this option, only the required content group will be staged. An app can be installed as a package with the required content group alone.

### -field LimitToExistingPackages:512
Do not download missing referenced packages


## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1903 | 18362 | LimitToExistingPackages |

## -see-also
[AddPackageByAppInstallerFileAsync()](packagemanager_addpackagebyappinstallerfileasync_1097728195.md)
[RequestAddPackageByAppInstallerFileAsync](packagemanager_requestaddpackagebyappinstallerfileasync_1360655875.md)

## -examples


