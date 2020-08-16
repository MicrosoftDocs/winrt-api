---
-api-id: P:Windows.ApplicationModel.Package.EffectiveExternalLocation
-api-type: winrt property
---

<!-- Property syntax.
public StorageFolder EffectiveExternalLocation { get; }
-->

# Windows.ApplicationModel.Package.EffectiveExternalLocation

## -description

Gets the location of the machine-wide or per-user external folder specified in the package manifest for the current package, depending on how the app is installed.

## -property-value

The location of the machine-wide or per-user machine-wide external folder specified in the package manifest for the current package, depending on how the app is installed.

## -remarks

The external folder is a disk location outside of the package where the package manifest can reference application content. This property returns either the machine-wide or per-user location of the external folder for the current package as a [StorageFolder](../windows.storage/storagefolder.md) object, depending on whether the app is provisioned for all users on the machine or on a per-user basis.

This property is intended to be used when you are granting identity to an unpackaged desktop application by using a *sparse* package. A sparse package contains only a package manifest (not an executable or other application content). The package manifest references application content in an external disk location outside of the package.

To set the external folder, use one of the following combinations of [PackageManager](../windows.management.deployment/packagemanager.md) methods and related options properties:

* [AddPackageByUriAsync](../windows.management.deployment/packagemanager_addpackagebyuriasync_797417417.md): Set the [ExternalLocationUri](../windows.management.deployment/addpackageoptions_externallocationuri.md) property of the *options* parameter.
* [RegisterPackageByUriAsync](../windows.management.deployment/packagemanager_registerpackagebyuriasync_1415074502.md): Set the [ExternalLocationUri](../windows.management.deployment/registerpackageoptions_externallocationuri.md) property of the *options* parameter.
* [StagePackageByUriAsync](../windows.management.deployment/packagemanager_stagepackagebyuriasync_446584280.md): Set the [ExternalLocationUri](../windows.management.deployment/stagepackageoptions_externallocationuri.md) property of the *options* parameter.

## -see-also

[AddPackageByUriAsync](../windows.management.deployment/packagemanager_addpackagebyuriasync_797417417.md),[RegisterPackageByUriAsync](../windows.management.deployment/packagemanager_registerpackagebyuriasync_1415074502.md),[StagePackageByUriAsync](../windows.management.deployment/packagemanager_stagepackagebyuriasync_446584280.md)

## -examples

