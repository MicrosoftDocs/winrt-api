---
-api-id: T:Windows.ApplicationModel.PackageCatalog
-api-type: winrt class
---

<!-- Class syntax.
public class PackageCatalog : Windows.ApplicationModel.IPackageCatalog, Windows.ApplicationModel.IPackageCatalog2
-->

# Windows.ApplicationModel.PackageCatalog

## -description
Provides access to app packages on the device.

## -remarks
Note that for PackageCatalog events:   

- If the PackageCatalog object is obtained using **[OpenForCurrentUser](/uwp/api/windows.applicationmodel.packagecatalog.OpenForCurrentUser)**, package events will be received for all packages being installed for the current user.  

- If the PackageCatalog object is obtained using **[OpenForCurrentPackage](/uwp/api/windows.applicationmodel.packagecatalog.OpenForCurrentPackage)**, package events will be received for the current package or its related packages such as optional packages.  

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | AddOptionalPackageAsync |
| 1703 | 15063 | PackageContentGroupStaging |
| 1709 | 16299 | RemoveOptionalPackagesAsync |
| 1803 | 17134 | AddResourcePackageAsync |
| 1803 | 17134 | RemoveResourcePackagesAsync |

## -examples

## -see-also
[Package.Dependencies](package_dependencies.md)  
