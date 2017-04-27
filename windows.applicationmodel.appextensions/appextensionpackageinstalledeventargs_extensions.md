---
-api-id: P:Windows.ApplicationModel.AppExtensions.AppExtensionPackageInstalledEventArgs.Extensions
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.ApplicationModel.AppExtensions.AppExtension> Extensions { get; }
-->

# Windows.ApplicationModel.AppExtensions.AppExtensionPackageInstalledEventArgs.Extensions

## -description
Provides a list of extensions in the extension package that was just installed.

## -property-value
The list of extensions within the extension package.

Extensions are scoped by the `<uap3:AppExtension Name=...>` defined in the extension's Package.appxmanifest file. Only extensions that match the `<uap3:AppExtension Name=...>` defined in the host's Package.appxmanifest file are returned.


## -remarks

## -examples

## -see-also
