---
-api-id: E:Windows.ApplicationModel.PackageExtensions.PackageExtensionCatalog.PackageStatusChanged
-api-type: winrt event
---

# Windows.ApplicationModel.PackageExtensions.PackageExtensionCatalog.PackageStatusChanged

<!--
public event Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.PackageExtensions.PackageExtensionCatalog,Windows.ApplicationModel.PackageExtensions.PackageExtensionPackageStatusChangedEventArgs> PackageStatusChanged;
-->

## -description

Event that is fired when an extension package in the catalog removed, updated, or installed.

## -remarks

This event helps you identify when a package is no longer available, valid, or has been modified. Handle this event to determine when an extension may no longer be valid and should be disabled. A common use for this event is to detect whether the package providing the extension is installed on removable media. If the user removes the media containing the package, this event is raised for that package.

The [PackageStatus](../windows.applicationmodel/package_status.md) class provides the possible package status states.

Use [PackageStatus.VerifyIsOk](../windows.applicationmodel/package_status.md) to determine if the package is in good condition. If it returns **false**, you can check [PackageStatus.LicenseIssue](../windows.applicationmodel/package_status.md) or [PackageStatus.PackageOffline](../windows.applicationmodel/package_status.md) and provide special handling for those situations. Typically, if the package state is not Ok, you should disable it. It is good practice to call **PackageStatus.VerifyIsOk** any time you are about to load an extension.

Consider handling the this event to provide an indicator in your extension manager UI that the extension is disabled or not usable because there is something wrong with the package.

Continue to handle this event, even if you've certain that there is an issue with a package, because the user may update the package and it may then be Ok to load.  

Like [PackageUpdating](packageextensioncatalog_packageupdating.md) and [PackageUninstalling](packageextensioncatalog_packageuninstalling.md), this event only passes the [Package](../windows.applicationmodel/package.md) with a status that's changed. It is up to you to match the **Package** against the [PackageExtensions](packageextension.md) you have loaded to determine which extensions are affected by the status change.

## -see-also

[PackageStatus](../windows.applicationmodel/package_status.md), [Package](../windows.applicationmodel/package.md), [PackageExtension](packageextension.md)

## -examples
