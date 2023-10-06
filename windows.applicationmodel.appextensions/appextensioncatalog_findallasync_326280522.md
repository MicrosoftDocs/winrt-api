---
-api-id: M:Windows.ApplicationModel.AppExtensions.AppExtensionCatalog.FindAllAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.ApplicationModel.AppExtensions.AppExtension>> FindAllAsync()
-->

# Windows.ApplicationModel.AppExtensions.AppExtensionCatalog.FindAllAsync

## -description

Provides the list of extensions in the catalog.
<!--What's the scope - need to understand open() better-->

## -returns

The list of extensions in the catalog. Note that this method returns a list of [AppExtensions](appextension.md), not [Packages](/uwp/api/windows.applicationmodel.package). You can get the **Package** for each **AppExtension** with [AppExtension.Package](appextension_package.md).

## -remarks

Extensions are scoped by the `<uap3:AppExtension Name=...>` defined in the extension's Package.appxmanifest file. This method returns the list of extensions installed on the machine that match the `<uap3:AppExtension Name=...>` defined in the host's Package.appxmanifest file.

You typically call this method when your app launches or resumes from suspension. Then use the events on this class to listen for updates to the extensions in the catalog.

## -examples

## -see-also

[AppExtension](appextension.md), [Package](/uwp/api/windows.applicationmodel.package), [AppExtension.Package](appextension_package.md), [FindAll](appextensioncatalog_findall_1149612203.md)
