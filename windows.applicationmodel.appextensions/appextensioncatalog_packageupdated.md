---
-api-id: E:Windows.ApplicationModel.AppExtensions.AppExtensionCatalog.PackageUpdated
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler PackageUpdated<Windows.ApplicationModel.AppExtensions.AppExtensionCatalog,  Windows.ApplicationModel.AppExtensions.AppExtensionPackageUpdatedEventArgs>
-->

# Windows.ApplicationModel.AppExtensions.AppExtensionCatalog.PackageUpdated

## -description
Event that is fired when an extension package in the catalog is updated.

## -remarks
The event arguments contain a list of extensions within the extension package. Extensions are scoped by the `<uap3:AppExtension Name=...>` defined in the extension's Package.appxmanifest file. Only extensions that match the `<uap3:AppExtension Name=...>` defined in the host's Package.appxmanifest file are in the list.

The updated package may include new [AppExtensions](appextension.md), and may no longer contain **AppExtensions** that were there previously. If you are maintaining a list of loaded extensions, the handler for this event is a good place to compare the list of **AppExtensions** in the new package against your list and then update your list accordingly.

**AppExtension** properties may have changed during the update. If you cached any of them, this is a good time to check for updates.

Generally the best way to handle this event is to treat it as you do the [PackageInstalled](appextensioncatalog_packageinstalled.md) event, but update your tracking list of **AppExtensions** instead of creating a new tracking list.

## -examples

## -see-also
