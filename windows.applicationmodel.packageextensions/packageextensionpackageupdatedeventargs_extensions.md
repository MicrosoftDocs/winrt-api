---
-api-id: P:Windows.ApplicationModel.PackageExtensions.PackageExtensionPackageUpdatedEventArgs.Extensions
-api-type: winrt property
---

# Windows.ApplicationModel.PackageExtensions.PackageExtensionPackageUpdatedEventArgs.Extensions

<!--
public System.Collections.Generic.IReadOnlyList<Windows.ApplicationModel.PackageExtensions.PackageExtension> Extensions { get; }
-->

## -description

Provides a list of extensions that are in the extension package that was updated.

## -property-value

A list of extensions within the updated extension package.

## -remarks

Extensions are scoped by the `<uap17:PackageExtension Name=...>` in the extension's Package.appxmanifest file. Only extensions that match the `<uap17:PackageExtension Name=...>` defined in the host's Package.appxmanifest file are returned.

## -see-also

## -examples
