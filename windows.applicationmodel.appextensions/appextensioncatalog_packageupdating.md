---
-api-id: E:Windows.ApplicationModel.AppExtensions.AppExtensionCatalog.PackageUpdating
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler PackageUpdating<Windows.ApplicationModel.AppExtensions.AppExtensionCatalog,  Windows.ApplicationModel.AppExtensions.AppExtensionPackageUpdatingEventArgs>
-->

# Windows.ApplicationModel.AppExtensions.AppExtensionCatalog.PackageUpdating

## -description
Event that is fired when an extension package is being updated.

## -remarks
This event marks when a package update has started. It precedes the [PackageUpdated](appextensioncatalog_packageupdated.md) event. In most cases, treat this as you do  [PackageUninstalling](appextensioncatalog_packageuninstalling.md).

A good way to handle this event is to treat the associated extensions within the package as unavailable when you handle **PackageUpdating**, and then reload them when you handle the **PackageUpdated** event. The time between these two events is typically less than a second.  

The event argument, [AppExtensionPackageUpdatingEventArgs.Extensions](appextensionpackageupdatingeventargs.md), only includes the Package and the extension namespace name specified in the extension's Package.appxmanifest file as  `<uap3:AppExtension Name=...>`. It doesn't contain the list of extensions.

When you handle the **PackageUpdating** event, match the package that is being updated against any extensions that you have loaded from that package so that you can keep track of which extensions are now available. This is why you should keep track of the [AppExtensions](appextension.md) that you have loaded, the packages to which they belong, and a unique identifier for them that you can use as a key as described in the remarks for **AppExtensionCatalog.Open**.

## -examples

## -see-also
