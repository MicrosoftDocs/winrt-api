---
-api-id: E:Windows.ApplicationModel.PackageExtensions.PackageExtensionCatalog.PackageInstalled
-api-type: winrt event
---

# Windows.ApplicationModel.PackageExtensions.PackageExtensionCatalog.PackageInstalled

<!--
public event Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.PackageExtensions.PackageExtensionCatalog,Windows.ApplicationModel.PackageExtensions.PackageExtensionPackageInstalledEventArgs> PackageInstalled;
-->

## -description

Event that is fired when an extension package is installed.

## -remarks

The event argument, [PackageExtensionPackageInstalledEventArgs.Extensions](packageextensionpackageinstalledeventargs_extensions.md), contains a list of extensions within the extension package.

Extensions are scoped by the `<uap17:PackageExtension Name=...>` defined in the extension's Package.appxmanifest file. Only extensions that match the `<uap17:PackageExtension Name=...>` defined in the host's Package.appxmanifest file, are in the list of extensions.

An event handler for this event is a good place to examine each package extension for correctness and to provide the user the option to use it.

The unit of deployment for a [PackageExtension](packageextension.md) is the [Package](../windows.applicationmodel/package.md). That's why this is a **Package** install event and not a **PackageExtension** install event.  

Typically there will only be one extension in a package. However, be prepared to handle the case where there are multiple extensions in the package.

Use [PackageExtension.Id](packageextension_id.md) to distinguish between extensions in the same package. To uniquely identify an extension in your package, consider concatenating [Package.Id](../windows.applicationmodel/package_id.md) and **PackageExtension.Id**:

```cs
_uniqueId = yourPackageExtension.Package.Id + "|" + yourPackageExtension.Id;
```

This guarantees that each **PackageExtension** has a unique name that you can use to track it. We recommend using this as a key for your **PackageExtensions** so that you can efficiently and correctly identify if a given **PackageExtension** is one that you already know about.

## -see-also

[PackageExtensionPackageInstalledEventArgs.Extensions](packageextensionpackageinstalledeventargs_extensions.md), [PackageExtension](packageextension.md), [Package](../windows.applicationmodel/package.md)

## -examples
