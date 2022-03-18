---
-api-id: P:Windows.Management.Deployment.RegisterPackageOptions.InstallAllResources
-api-type: winrt property
---

## -description

Gets or sets a value that indicates whether the app skips resource applicability checks. This effectively stages or registers all resource [Packages](/uwp/api/windows.applicationmodel.package) that a user passes in to the command, which forces applicability for all packages contained in a bundle. If a user passes in a bundle, all contained resource packages will be registered.

## -property-value

**TRUE** instructs the app to skip all resource applicability checks and stages or registers all resource packages; otherwise, **FALSE**.

## -remarks

## -see-also

[Package](/uwp/api/windows.applicationmodel.package), [RegisterPackageOptions][registerpackageoptions.md]

## -examples

