---
-api-id: M:Windows.ApplicationModel.AppExtensions.AppExtensionCatalog.Open(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.AppExtensions.AppExtensionCatalog Open(System.String appExtensionName)
-->

# Windows.ApplicationModel.AppExtensions.AppExtensionCatalog.Open

## -description
Opens a catalog of extensions.

## -parameters
### -param appExtensionName
The extension namespace name.

## -returns
A catalog containing the extensions declared with the specified extension namespace name.

## -remarks
Extensions are scoped by the `<uap3:AppExtension Name=...>` defined in the extension's Package.appxmanifest file. Only extensions that match the  `<uap3:AppExtension Name=...>` defined in the host's Package.appxmanifest file appear in the catalog.  

If you have multiple `<uap3:AppExtensionHost>` declarations in your host app, you need to open a separate catalog for each one.

An instance of the **PackageCatalog** is required to handle the events so keep a reference to it as long as you need to manage your app extensions.

## -examples

## -see-also
