---
-api-id: M:Windows.ApplicationModel.PackageCatalog.OpenForCurrentUser
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.PackageCatalog OpenForCurrentUser()
-->

# Windows.ApplicationModel.PackageCatalog.OpenForCurrentUser

## -description
Opens the catalog of app packages on the device that are available to the current user.

## -returns
The catalog of packages for the current user.

## -remarks

In terms of capability requirements, **OpenForCurrentUser** requires that the caller has either the `packageQuery` or the `packageManagement` capability; or else that the caller has integrity level (IL) greater than or equal to Medium.

## -examples

## -see-also
[PackageManager.FindPackages](/uwp/api/windows.management.deployment.packagemanager.findpackages)

## -capabilities
packageQuery, packageManagement
