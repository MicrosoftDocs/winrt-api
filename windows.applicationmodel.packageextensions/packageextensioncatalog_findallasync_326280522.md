---
-api-id: M:Windows.ApplicationModel.PackageExtensions.PackageExtensionCatalog.FindAllAsync
-api-type: winrt method
---

# Windows.ApplicationModel.PackageExtensions.PackageExtensionCatalog.FindAllAsync

<!--
public Windows.Foundation.IAsyncOperation<System.Collections.Generic.IReadOnlyList<Windows.ApplicationModel.PackageExtensions.PackageExtension>> FindAllAsync ();
-->

## -description

Provides the list of extensions in the catalog.

## -returns

The list of extensions in the catalog as an async operation. Note that this method returns a list of [PackageExtensions](packageextension.md), not [Packages](/uwp/api/windows.applicationmodel.package). You can get the **Package** for each **PackageExtension** with [PackageExtension.Package](packageextension_package.md).

## -remarks

Package extensions are scoped by the `<uap17:PackageExtension Name=...>` defined in the extension's Package.appxmanifest file. This method returns the list of extensions installed on the machine that match the `<uap17:PackageExtension Name=...>` defined in the host's Package.appxmanifest file.

You typically call this method when your app launches or resumes from suspension. Then use the events on this class to listen for updates to the extensions in the catalog.

## -see-also

[FindAll](./packageextensioncatalog_findall_1149612203.md), [PackageExtension](packageextension.md), [Package](/uwp/api/windows.applicationmodel.package), [PackageExtension.Package](packageextension_package.md)

## -examples
