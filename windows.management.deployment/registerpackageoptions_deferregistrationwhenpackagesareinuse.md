---
-api-id: P:Windows.Management.Deployment.RegisterPackageOptions.DeferRegistrationWhenPackagesAreInUse
-api-type: winrt property
---

## -description

Gets or sets a value that indicates whether to delay registration of the main [Package](/uwp/api/windows.applicationmodel.package) or dependency packages if the packages are currently in use.

## -property-value

**TRUE** indicates that registration of the main package or dependency packages will be delayed until the next time the application is activated if the packages are currently in use; otherwise, **FALSE**.

## -remarks

## -see-also

[Package](/uwp/api/windows.applicationmodel.package), [RegisterPackageOptions][registerpackageoptions.md]

## -examples

