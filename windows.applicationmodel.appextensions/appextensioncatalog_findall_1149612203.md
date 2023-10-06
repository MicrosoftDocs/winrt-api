---
-api-id: M:Windows.ApplicationModel.AppExtensions.AppExtensionCatalog.FindAll
-api-type: winrt method
---

# Windows.ApplicationModel.AppExtensions.AppExtensionCatalog.FindAll

<!--
public System.Collections.Generic.IReadOnlyList<Windows.ApplicationModel.AppExtensions.AppExtension> FindAll ();
-->

## -description

Provides a read-only list of extensions in the catalog.

## -returns

The list of extensions in the catalog.

## -remarks

Note that this method returns a read-only list of [AppExtensions](appextension.md), not [Packages](/uwp/api/windows.applicationmodel.package). You can get the **Package** for each **AppExtension** with [AppExtension.Package](appextension_package.md).

Extensions are scoped by the `<uap3:AppExtension Name=...>` defined in the extension's Package.appxmanifest file. This method returns the list of extensions installed on the machine that match the `<uap3:AppExtension Name=...>` defined in the host's Package.appxmanifest file.

You typically call this method when your app launches or resumes from suspension. Then use the events on this class to listen for updates to the extensions in the catalog.

## -examples

## -see-also

[AppExtension](appextension.md), [Package](/uwp/api/windows.applicationmodel.package), [AppExtension.Package](appextension_package.md), [FindAllAsync](appextensioncatalog_findallasync_326280522.md)
