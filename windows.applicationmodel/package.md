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

> [!IMPORTANT]
> Although the **Package** class is supported in an unpackaged process (that is, a process belonging to an app that lacks package identity), some members of this class are supported only in a *packaged* process (that is, a process belonging to an app that *has* package identity). For those members, the **Remarks** section of their topics contain more info. And for more info about packaging, see [Package a desktop or UWP app in Visual Studio](/windows/msix/package/packaging-uwp-apps).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | IsOptional |
| 1607 | 14393 | SignatureKind |
| 1607 | 14393 | VerifyContentIntegrityAsync |
| 1703 | 15063 | GetContentGroupAsync |
| 1703 | 15063 | GetContentGroupsAsync |
| 1703 | 15063 | SetInUseAsync |
| 1703 | 15063 | StageContentGroupsAsync(IEnumerable&lt;String&gt;) |
| 1703 | 15063 | StageContentGroupsAsync(IEnumerable&lt;String&gt;,Boolean) |
| 1809 | 17763 | CheckUpdateAvailabilityAsync |
| 1809 | 17763 | GetAppInstallerInfo |
| 1903 | 18362 | EffectiveLocation |
| 1903 | 18362 | MutableLocation |
| 2004 | 19041 | EffectiveExternalLocation |
| 2004 | 19041 | EffectiveExternalPath |
| 2004 | 19041 | EffectivePath |
| 2004 | 19041 | GetAppListEntries |
| 2004 | 19041 | GetLogoAsRandomAccessStreamReference |
| 2004 | 19041 | InstalledPath |
| 2004 | 19041 | IsStub |
| 2004 | 19041 | MachineExternalLocation |
| 2004 | 19041 | MachineExternalPath |
| 2004 | 19041 | MutablePath |
| 2004 | 19041 | UserExternalLocation |
| 2004 | 19041 | UserExternalPath |

## -examples

## -see-also
[App package information sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Package), [Packaging apps](/windows/uwp/packaging/index), [Package.Current](package_current.md), [PackageId](packageid.md)
