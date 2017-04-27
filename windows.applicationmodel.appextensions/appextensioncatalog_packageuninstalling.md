---
-api-id: E:Windows.ApplicationModel.AppExtensions.AppExtensionCatalog.PackageUninstalling
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler PackageUninstalling<Windows.ApplicationModel.AppExtensions.AppExtensionCatalog,  Windows.ApplicationModel.AppExtensions.AppExtensionPackageUninstallingEventArgs>
-->

# Windows.ApplicationModel.AppExtensions.AppExtensionCatalog.PackageUninstalling

## -description
Event that is fired when an extension package is being uninstalled.

## -remarks
Update the list of extensions that you are tracking when you handle this event to reflect the ones that have been unloaded. If the user re-installs the package, then a [PackageInstalled](appextensioncatalog_packageinstalled.md) event will be raised and you can re-add the extensions while handling that event just as you would the addition of any extension.

Like [PackageUpdating](appextensioncatalog_packageupdating.md), this event only passes the package that is being uninstalled and not a list of [AppExtensions](appextension.md).

## -examples

## -see-also
