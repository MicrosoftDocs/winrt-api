---
-api-id: E:Windows.ApplicationModel.PackageExtensions.PackageExtensionCatalog.PackageUninstalling
-api-type: winrt event
---

# Windows.ApplicationModel.PackageExtensions.PackageExtensionCatalog.PackageUninstalling

<!--
public event Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.PackageExtensions.PackageExtensionCatalog,Windows.ApplicationModel.PackageExtensions.PackageExtensionPackageUninstallingEventArgs> PackageUninstalling;
-->

## -description

Event that is fired when an extension package is being uninstalled.

## -remarks

Update the list of extensions that you are tracking when you handle this event to reflect the ones that have been unloaded. If the user re-installs the package, then a [PackageInstalled](packageextensioncatalog_packageinstalled.md) event will be raised and you can re-add the extensions while handling that event just as you would the addition of any extension.

Like [PackageUpdating](packageextensioncatalog_packageupdating.md), this event only passes the package that is being uninstalled and not a list of [PackageExtensions](packageextension.md).

## -see-also

[PackageInstalled](packageextensioncatalog_packageinstalled.md), [PackageUpdating](packageextensioncatalog_packageupdating.md), [PackageExtension](packageextension.md)

## -examples
