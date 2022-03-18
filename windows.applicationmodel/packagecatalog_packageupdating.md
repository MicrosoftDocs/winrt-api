---
-api-id: E:Windows.ApplicationModel.PackageCatalog.PackageUpdating
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler PackageUpdating<Windows.ApplicationModel.PackageCatalog,  Windows.ApplicationModel.PackageUpdatingEventArgs>
-->

# Windows.ApplicationModel.PackageCatalog.PackageUpdating

## -description
Indicates that an app package is being updated.

## -remarks
If the PackageCatalog is obtained using **[OpenForCurrentPackage](/uwp/api/windows.applicationmodel.packagecatalog.OpenForCurrentPackage)**, the app only receives package events for itself or its related packages such as optional packages.

To get package events for all of a user's packages, obtain the PackageCatalog using **[OpenForCurrentUser](/uwp/api/windows.applicationmodel.packagecatalog.OpenForCurrentUser)** instead.

## -examples

## -see-also
