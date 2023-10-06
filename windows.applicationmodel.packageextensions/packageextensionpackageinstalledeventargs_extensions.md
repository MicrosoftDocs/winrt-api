---
-api-id: P:Windows.ApplicationModel.PackageExtensions.PackageExtensionPackageInstalledEventArgs.Extensions
-api-type: winrt property
---

# Windows.ApplicationModel.PackageExtensions.PackageExtensionPackageInstalledEventArgs.Extensions

<!--
public System.Collections.Generic.IReadOnlyList<Windows.ApplicationModel.PackageExtensions.PackageExtension> Extensions { get; }
-->

## -description

Provides a list of extensions in the extension package that was just installed.

## -property-value

The list of extensions within the extension package.

Extensions are scoped by the `<uap17:PackageExtension Name=...>` defined in the extension's Package.appxmanifest file. Only extensions that match the `<uap17:PackageExtension Name=...>` defined in the host's Package.appxmanifest file are returned.

## -remarks

## -see-also

## -examples
