---
-api-id: T:Windows.Management.Deployment.PackageManager
-api-type: winrt class
---

<!-- Class syntax.
public class PackageManager : Windows.Management.Deployment.IPackageManager, Windows.Management.Deployment.IPackageManager2, Windows.Management.Deployment.IPackageManager3, Windows.Management.Deployment.IPackageManager4, Windows.Management.Deployment.IPackageManager5
-->

# Windows.Management.Deployment.PackageManager

## -description
Manages the software available to a user.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | GetPackageVolumesAsync |
| 1703 | 15063 | AddPackageAsync(Uri,IEnumerable<Uri>,DeploymentOptions,PackageVolume,IEnumerable<String>,IEnumerable<Uri>) |
| 1703 | 15063 | DebugSettings |
| 1703 | 15063 | RegisterPackageByFamilyNameAsync |
| 1703 | 15063 | StagePackageAsync(Uri,IEnumerable<Uri>,DeploymentOptions,PackageVolume,IEnumerable<String>,IEnumerable<Uri>) |
| 1709 | 16299 | AddPackageAsync(Uri,IEnumerable<Uri>,DeploymentOptions,PackageVolume,IEnumerable<String>,IEnumerable<Uri>,IEnumerable<Uri>) |
| 1709 | 16299 | AddPackageByAppInstallerFileAsync |
| 1709 | 16299 | ProvisionPackageForAllUsersAsync |
| 1709 | 16299 | RequestAddPackageAsync(Uri,IEnumerable<Uri>,DeploymentOptions,PackageVolume,IEnumerable<String>,IEnumerable<Uri>) |
| 1709 | 16299 | RequestAddPackageByAppInstallerFileAsync |
| 1709 | 16299 | StagePackageAsync(Uri,IEnumerable<Uri>,DeploymentOptions,PackageVolume,IEnumerable<String>,IEnumerable<Uri>,IEnumerable<Uri>) |
| 1803 | 17134 | RequestAddPackageAsync(Uri,IEnumerable<Uri>,DeploymentOptions,PackageVolume,IEnumerable<String>,IEnumerable<Uri>,IEnumerable<Uri>) |
| 1809 | 17763 | DeprovisionPackageForAllUsersAsync |

## -examples

## -see-also
[Add app package sample](https://go.microsoft.com/fwlink/p/?linkid=236968), [Enumerate app packages sample](https://code.msdn.microsoft.com/windowsdesktop/Package-Manager-Inventory-ee821079), [Enumerate app packages by name and publisher sample](https://code.msdn.microsoft.com/windowsdesktop/Package-Manager-Inventory-fe747b8a), [Enumerate app packages by user SID sample](https://code.msdn.microsoft.com/windowsdesktop/Package-Manager-Inventory-5bee970a), [Remove app package sample](https://go.microsoft.com/fwlink/p/?linkid=236972), [Packaging apps](https://docs.microsoft.com/windows/uwp/packaging/index), [DeploymentResult](deploymentresult.md), [PackageUserInformation](packageuserinformation.md)
