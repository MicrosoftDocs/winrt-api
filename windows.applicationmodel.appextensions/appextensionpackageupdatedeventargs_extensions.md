---
-api-id: P:Windows.ApplicationModel.AppExtensions.AppExtensionPackageUpdatedEventArgs.Extensions
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.ApplicationModel.AppExtensions.AppExtension> Extensions { get; }
-->

# Windows.ApplicationModel.AppExtensions.AppExtensionPackageUpdatedEventArgs.Extensions

## -description
Provides a list of extensions that are in the extension package that was updated

## -property-value
A list of extensions within the updated extension package.

## -remarks
Extensions are scoped by the `<uap3:AppExtension Name=...>` in the extension's Package.appxmanifest file. Only extensions that match the `<uap3:AppExtension Name=...>` defined in the host's Package.appxmanifest file are returned.

## -examples

## -see-also
