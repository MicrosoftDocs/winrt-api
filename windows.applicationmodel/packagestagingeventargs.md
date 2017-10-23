---
-api-id: T:Windows.ApplicationModel.PackageStagingEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class PackageStagingEventArgs : Windows.ApplicationModel.IPackageStagingEventArgs
-->

# Windows.ApplicationModel.PackageStagingEventArgs

## -description
Provides information about the app package that is being staged.

## -remarks
An app package is staged when it is added to the device but is not yet registered.

Apps only receive package events for itself or its related packages such as optional packages.

This object is passed to the [PackageCatalog.PackageStaging event](packagecatalog_packagestaging.md) event handler.

## -examples

## -see-also
[PackageCatalog.PackageStaging event](packagecatalog_packagestaging.md)