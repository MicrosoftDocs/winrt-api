---
-api-id: E:Windows.ApplicationModel.PackageCatalog.PackageStatusChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler PackageStatusChanged<Windows.ApplicationModel.PackageCatalog,  Windows.ApplicationModel.PackageStatusChangedEventArgs>
-->

# Windows.ApplicationModel.PackageCatalog.PackageStatusChanged

## -description
Indicates that an app package has been removed or updated

## -remarks
If the PackageCatalog is obtained using **[OpenForCurrentPackage](/uwp/api/windows.applicationmodel.packagecatalog.OpenForCurrentPackage)**, the app only receives package events for itself or its related packages such as optional packages.

To get package events for all of a user's packages, obtain the PackageCatalog using **[OpenForCurrentUser](/uwp/api/windows.applicationmodel.packagecatalog.OpenForCurrentUser)** instead.

## -examples

## -see-also
