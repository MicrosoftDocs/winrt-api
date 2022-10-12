---
-api-id: P:Windows.ApplicationModel.Package.UserExternalPath
-api-type: winrt property
---

<!-- Property syntax.
public string UserExternalPath { get; }
-->

# Windows.ApplicationModel.Package.UserExternalPath

## -description

Gets the path of the per-user external folder specified in the package manifest for the current package.

## -property-value

The path of the per-user external folder specified in the package manifest for the current package.

## -remarks

The external folder is a disk location outside of the package where the package manifest can reference application content. This property returns the path of the external folder for an app that is installed on a per-user basis.

This property is intended to be used when you are granting package identity by packaging with external location. A package with external location contains only a package manifest (not an executable or other application content). The package manifest references application content in an external disk location outside of the package.

To set the external folder, use one of the following combinations of [PackageManager](../windows.management.deployment/packagemanager.md) methods and related options properties:

* [AddPackageByUriAsync](../windows.management.deployment/packagemanager_addpackagebyuriasync_797417417.md): Set the [ExternalLocationUri](../windows.management.deployment/addpackageoptions_externallocationuri.md) property of the *options* parameter.
* [RegisterPackageByUriAsync](../windows.management.deployment/packagemanager_registerpackagebyuriasync_1415074502.md): Set the [ExternalLocationUri](../windows.management.deployment/registerpackageoptions_externallocationuri.md) property of the *options* parameter.
* [StagePackageByUriAsync](../windows.management.deployment/packagemanager_stagepackagebyuriasync_446584280.md): Set the [ExternalLocationUri](../windows.management.deployment/stagepackageoptions_externallocationuri.md) property of the *options* parameter.

## -see-also

[AddPackageByUriAsync](../windows.management.deployment/packagemanager_addpackagebyuriasync_797417417.md),[RegisterPackageByUriAsync](../windows.management.deployment/packagemanager_registerpackagebyuriasync_1415074502.md),[StagePackageByUriAsync](../windows.management.deployment/packagemanager_stagepackagebyuriasync_446584280.md)

## -examples

