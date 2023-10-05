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

For a packaged app to see/enumerate appextensions it must meet at least one of the following criteria:

- Run as MediumIL (or higher)
- Run in an AppContainer and declare a matching appextensionhost
- Run in an AppContainer and have the packageQuery capability

This check is called by [AppExtensionCatalog.Open](/uwp/api/windows.applicationmodel.appextensions.appextensioncatalog.open) and [AppExtensionCatalog::RequestRemovePackageAsync](/uwp/api/windows.applicationmodel.appextensions.

If you have multiple `<uap3:AppExtensionHost>` declarations in your host app, you need to open a separate catalog for each one.

An instance of the **PackageCatalog** is required to handle the events so keep a reference to it as long as you need to manage your app extensions.

|App Extension|Purpose|
|----|----|
|com.microsoft.windows.dontmaximizeonsmallscreen|Prevents app from maximizing on launch on small devices. Currently used by the Calculator app.|


## -examples

## -see-also
