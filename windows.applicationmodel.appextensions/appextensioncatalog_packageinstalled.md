---
-api-id: E:Windows.ApplicationModel.AppExtensions.AppExtensionCatalog.PackageInstalled
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler PackageInstalled<Windows.ApplicationModel.AppExtensions.AppExtensionCatalog,  Windows.ApplicationModel.AppExtensions.AppExtensionPackageInstalledEventArgs>
-->

# Windows.ApplicationModel.AppExtensions.AppExtensionCatalog.PackageInstalled

## -description
Event that is fired when an extension package is installed.

## -remarks
The event argument, [AppExtensionPackageInstalledEventArgs.Extensions](appextensionpackageinstalledeventargs.md), contains a list of extensions within the extension package.

Extensions are scoped by the `<uap3:AppExtension Name=...>` defined in the extension's Package.appxmanifest file. Only extensions that match the `<uap3:AppExtension Name=...>` defined in the host's Package.appxmanifest file, are in the list of extensions.

An event handler for this event is a good place to examine each app extension for correctness and to provide the user the option to use it.

The unit of deployment for an [AppExtension](/uwp/api/windows.applicationmodel.appextensions.appextension) is the [Package](/uwp/api/windows.applicationmodel.package). That's why this is a **Package** install event and not an **AppExtension** install event.  

Typically there will only be one extension in a package. However, be prepared to handle the case where there are multiple extensions in the package.

Use [AppExtension.Id](/uwp/api/windows.applicationmodel.appextensions.appextension) to distinguish between extensions in the same package. To uniquely identify an extension in your app, consider concatenating [AppInfo.AppUserModelId](/uwp/api/windows.applicationmodel.appinfo) and [AppExtension.Id](/uwp/api/windows.applicationmodel.appinfo):

```cs
_uniqueId = yourAppExtention.AppInfo.AppUserModelId + "!" + yourAppExtention.Id;
```

This guarantees that each **AppExtension** has a unique name that you can use to track it with in your app. We recommend using this as a key for your **AppExtensions** so that you can efficiently and correctly identify if a given **AppExtension** is one that you already know about.

## -examples

## -see-also
