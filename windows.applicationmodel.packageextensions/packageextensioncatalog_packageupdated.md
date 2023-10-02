---
-api-id: E:Windows.ApplicationModel.PackageExtensions.PackageExtensionCatalog.PackageUpdated
-api-type: winrt event
---

# Windows.ApplicationModel.PackageExtensions.PackageExtensionCatalog.PackageUpdated

<!--
public event Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.PackageExtensions.PackageExtensionCatalog,Windows.ApplicationModel.PackageExtensions.PackageExtensionPackageUpdatedEventArgs> PackageUpdated;
-->

## -description

Event that is fired when an extension package in the catalog is updated.

## -remarks

The event arguments contain a list of extensions within the extension package. Extensions are scoped by the `<uap17:PackageExtension Name=...>` defined in the extension's Package.appxmanifest file. Only extensions that match the `<uap17:PackageExtension Name=...>` defined in the host's Package.appxmanifest file are in the list.

The updated package may include new [PackageExtensions](packageextension.md), and may no longer contain **PackageExtensions** that were there previously. If you are maintaining a list of loaded extensions, the handler for this event is a good place to compare the list of **PackageExtensions** in the new package against your list and then update your list accordingly.

**PackageExtension** properties may have changed during the update. If you cached any of them, this is a good time to check for updates.

Generally the best way to handle this event is to treat it as you do the [PackageInstalled](packageextensioncatalog_packageinstalled.md) event, but update your tracking list of **PackageExtensions** instead of creating a new tracking list.

## -see-also

[PackageExtension](packageextension.md), [PackageInstalled](packageextensioncatalog_packageinstalled.md)

## -examples
