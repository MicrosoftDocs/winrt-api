---
-api-id: E:Windows.ApplicationModel.PackageCatalog.PackageInstalling
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler PackageInstalling<Windows.ApplicationModel.PackageCatalog,  Windows.ApplicationModel.PackageInstallingEventArgs>
-->

# Windows.ApplicationModel.PackageCatalog.PackageInstalling

## -description
Indicates that an app package is installing.

## -remarks
If the PackageCatalog object is obtained using **[OpenForCurrentUser](/uwp/api/windows.applicationmodel.packagecatalog.OpenForCurrentUser)**, package events will be received for all packages being installed for the current user.

If the PackageCatalog object is obtained using **[OpenForCurrentPackage](/uwp/api/windows.applicationmodel.packagecatalog.OpenForCurrentPackage)**, package events will be received for the current package or its related packages such as optional packages.

## -examples

## -see-also
