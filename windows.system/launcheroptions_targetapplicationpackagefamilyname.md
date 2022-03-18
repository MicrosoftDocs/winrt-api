---
-api-id: P:Windows.System.LauncherOptions.TargetApplicationPackageFamilyName
-api-type: winrt property
---

<!-- Property syntax
public string TargetApplicationPackageFamilyName { get;  set; }
-->

# Windows.System.LauncherOptions.TargetApplicationPackageFamilyName

## -description
The package family name of the target package that should be used to launch a file or URI. This property is optional.

## -property-value
The package family name of the target package that should be used to launch a file or URI. This property is optional.

## -remarks
An application's PackageFamilyName can be obtained via the [PackageID class](/en-us/uwp/api/Windows.ApplicationModel.PackageId#Windows_ApplicationModel_PackageId_FamilyName)

A PackageFamilyName can vary depending on how an application has been published, but it will generally follow the form of `[package name]_[publisher_id]`. For example, an unpublished app has a family name similar to `c04742a8-1c87-41c1-b951-cc6e6f353400_g3nsfcgfwzqga`

## -examples

## -see-also
