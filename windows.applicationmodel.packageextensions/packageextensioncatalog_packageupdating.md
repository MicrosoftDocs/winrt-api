---
-api-id: E:Windows.ApplicationModel.PackageExtensions.PackageExtensionCatalog.PackageUpdating
-api-type: winrt event
---

# Windows.ApplicationModel.PackageExtensions.PackageExtensionCatalog.PackageUpdating

<!--
public event Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.PackageExtensions.PackageExtensionCatalog,Windows.ApplicationModel.PackageExtensions.PackageExtensionPackageUpdatingEventArgs> PackageUpdating;
-->

## -description

Event that is fired when an extension package is being updated.

## -remarks

This event marks when a package update has started. It precedes the [PackageUpdated](packageextensioncatalog_packageupdated.md) event. In most cases, treat this as you do [PackageUninstalling](packageextensioncatalog_packageuninstalling.md).

A good way to handle this event is to treat the associated extensions within the package as unavailable when you handle **PackageUpdating**, and then reload them when you handle the **PackageUpdated** event. The time between these two events is typically less than a second.  

The event arguments, [PackageExtensionPackageUpdatingEventArgs](./packageextensionpackageupdatingeventargs.md), only include the **Package** and the **PackageExtensionName** specified in the extension's Package.appxmanifest file as  `<uap17:PackageExtension Name=...>`. It doesn't contain the list of extensions.

When you handle the **PackageUpdating** event, match the package that is being updated against any extensions that you have loaded from that package so that you can keep track of which extensions are now available. This is why you should keep track of the [PackageExtensions](packageextension.md) that you have loaded, the packages to which they belong, and a unique identifier for them that you can use as a key as described in the remarks for [PackageExtensionCatalog.Open](./packageextensioncatalog_open_1320339374.md).

## -see-also

[PackageExtension](packageextension.md), [PackageExtensionCatalog.Open](./packageextensioncatalog_open_1320339374.md), [PackageExtensionPackageUpdatingEventArgs](./packageextensionpackageupdatingeventargs.md), [PackageUpdated](packageextensioncatalog_packageupdated.md), [PackageUninstalling](packageextensioncatalog_packageuninstalling.md)

## -examples
