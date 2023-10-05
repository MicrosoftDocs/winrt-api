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

Extensions are scoped by the `<uap3:AppExtension Name=...>` defined in the extension's Package.appxmanifest file. For a packaged app to see and enumerate app extensions, it must meet at least one of the following criteria:

- Run as MediumIL (or higher)
- Run in an AppContainer and declare a matching `<uap3:AppExtensionHost>`
- Run in an AppContainer and have the **packageQuery** capability

An instance of the **PackageCatalog** is required to handle the events so keep a reference to it as long as you need to manage your app extensions.

|App Extension|Purpose|
|----|----|
|com.microsoft.windows.dontmaximizeonsmallscreen|Prevents app from maximizing on launch on small devices. Currently used by the Calculator app.|

## -examples

## -see-also
