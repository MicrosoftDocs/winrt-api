---
-api-id: M:Windows.ApplicationModel.PackageExtensions.PackageExtensionCatalog.Open(System.String)
-api-type: winrt method
---

# Windows.ApplicationModel.PackageExtensions.PackageExtensionCatalog.Open(System.String)

<!--
public static Windows.ApplicationModel.PackageExtensions.PackageExtensionCatalog Open (string packageExtensionName);
-->

## -description

Opens a catalog of extensions.

## -parameters

### -param packageExtensionName

The extension namespace name.

## -returns

A catalog containing the extensions declared with the specified extension namespace name.

## -remarks

Package extensions are scoped by the `<uap17:PackageExtension Name=...>` defined in the extension's Package.appxmanifest file. Only extensions that match the  `<uap17:PackageExtension Name=...>` defined in the host's Package.appxmanifest file appear in the catalog.  

If you have multiple `<uap17:PackageExtensionHost>` declarations in your host app, you need to open a separate catalog for each one.

An instance of the [PackageCatalog](../windows.applicationmodel/packagecatalog.md) is required to handle the events so keep a reference to it as long as you need to manage your app extensions.

## -see-also

[PackageCatalog](../windows.applicationmodel/packagecatalog.md)

## -examples
