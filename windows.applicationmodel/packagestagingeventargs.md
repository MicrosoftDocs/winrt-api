---
-api-id: T:Windows.ApplicationModel.PackageStagingEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class PackageStagingEventArgs : Windows.ApplicationModel.IPackageStagingEventArgs
-->

# Windows.ApplicationModel.PackageStagingEventArgs

## -description
Provides information about the optional package that is being staged.

## -remarks
An appx package is staged when it is added to the device but is not yet registered.

Apps only receive package events for their optional packages.

This object is passed to the [PackageCatalog.PackageStaging event](packagecatalog_packagestaging.md) event handler.

## -examples

## -see-also
[PackageCatalog.PackageStaging event](packagecatalog_packagestaging.md)