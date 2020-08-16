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
| 2004 | 19041 | AddPackageByUriAsync |
| 2004 | 19041 | FindProvisionedPackages |
| 2004 | 19041 | GetPackageStubPreference |
| 2004 | 19041 | RegisterPackageByUriAsync |
| 2004 | 19041 | RegisterPackagesByFullNameAsync |
| 2004 | 19041 | SetPackageStubPreference |
| 2004 | 19041 | StagePackageByUriAsync |

## -examples

## -see-also

- [Package](https://docs.microsoft.com/uwp/api/windows.applicationmodel.package)
- [Add app package sample](https://github.com/microsoft/Windows-classic-samples/tree/master/Samples/PackageManagerAddPackage)
- [Enumerate app packages sample](https://github.com/microsoft/Windows-classic-samples/tree/master/Samples/PackageManagerFindProvisionedPackages)
- [Enumerate app packages by name and publisher sample](https://github.com/microsoft/Windows-classic-samples/tree/master/Samples/PackageManagerFindPackagesByNameAndPublisher)
- [Enumerate app packages by user SID sample](https://github.com/microsoft/Windows-classic-samples/tree/master/Samples/PackageManagerFindPackagesByUserSecurityId)
- [Remove app package sample](https://github.com/microsoft/Windows-classic-samples/tree/master/Samples/PackageManagerRemovePackage)
- [Packaging apps](https://docs.microsoft.com/windows/uwp/packaging/index)
- [DeploymentResult](deploymentresult.md)
- [PackageUserInformation](packageuserinformation.md)
