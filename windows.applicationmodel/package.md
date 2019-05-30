---
-api-id: T:Windows.ApplicationModel.Package
-api-type: winrt class
---

<!-- Class syntax.
public class Package : Windows.ApplicationModel.IPackage, Windows.ApplicationModel.IPackage2, Windows.ApplicationModel.IPackage3, Windows.ApplicationModel.IPackage4, Windows.ApplicationModel.IPackage5, Windows.ApplicationModel.IPackageWithMetadata
-->

# Windows.ApplicationModel.Package

## -description
Provides information about a package.

## -remarks
Although Package is supported in desktop apps, some members of this class are supported only in UWP app. The remarks section will indicate whether a member has any restrictions on its behavior.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | IsOptional |
| 1607 | 14393 | SignatureKind |
| 1607 | 14393 | VerifyContentIntegrityAsync |
| 1703 | 15063 | GetContentGroupAsync |
| 1703 | 15063 | GetContentGroupsAsync |
| 1703 | 15063 | SetInUseAsync |
| 1703 | 15063 | StageContentGroupsAsync(IEnumerable<String>) |
| 1703 | 15063 | StageContentGroupsAsync(IEnumerable<String>,Boolean) |
| 1809 | 17763 | CheckUpdateAvailabilityAsync |
| 1809 | 17763 | GetAppInstallerInfo |
| 1903 | 18362 | EffectiveLocation |
| 1903 | 18362 | MutableLocation |

## -examples

## -see-also
[App package information sample](https://code.msdn.microsoft.com/windowsapps/Package-sample-46e239fa), [Packaging apps](https://docs.microsoft.com/windows/uwp/packaging/index), [Package.Current](package_current.md), [PackageId](packageid.md), [App package information sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620581)
