---
-api-id: E:Windows.ApplicationModel.PackageCatalog.PackageContentGroupStaging
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler PackageContentGroupStaging<PackageCatalog, PackageContentGroupStagingEventArgs>
-->

# Windows.ApplicationModel.PackageCatalog.PackageContentGroupStaging

## -description
The event that is fired when a package content group starts staging.

## -remarks
If the PackageCatalog is obtained using **[OpenForCurrentPackage](/uwp/api/windows.applicationmodel.packagecatalog.OpenForCurrentPackage)**, the app only receives package events for itself or its related packages such as optional packages.

To get package events for all of a user's packages, obtain the PackageCatalog using **[OpenForCurrentUser](/uwp/api/windows.applicationmodel.packagecatalog.OpenForCurrentUser)** instead.

## -see-also

## -examples
