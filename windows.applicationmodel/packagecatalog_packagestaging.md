---
-api-id: E:Windows.ApplicationModel.PackageCatalog.PackageStaging
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler PackageStaging<Windows.ApplicationModel.PackageCatalog,  Windows.ApplicationModel.PackageStagingEventArgs>
-->

# Windows.ApplicationModel.PackageCatalog.PackageStaging

## -description
Indicates that an app package is staging.

## -remarks
An app package is staged when it is added to the device but is not yet registered.

If the PackageCatalog is obtained using **[OpenForCurrentPackage](/uwp/api/windows.applicationmodel.packagecatalog.OpenForCurrentPackage)**, the app only receives package events for itself or its related packages such as optional packages.

To get package events for all packages being staged by a user, obtain the PackageCatalog using **[OpenForCurrentUser](/uwp/api/windows.applicationmodel.packagecatalog.OpenForCurrentUser)** instead.

## -examples

## -see-also
