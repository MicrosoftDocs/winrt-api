---
-api-id: M:Windows.UI.StartScreen.SecondaryTile.FindAllAsync(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.UI.StartScreen.SecondaryTile>> FindAllAsync(System.String applicationId)
-->

# Windows.UI.StartScreen.SecondaryTile.FindAllAsync

## -description
Retrieves a list of secondary tiles created for another app in the same package as the calling app.

## -parameters
### -param applicationId
The package-relative application identifier (PRAID) of the app. The specified app must be in the same package as the calling app. For more info on the PRAID, see the **Id** attribute of the [Application](/uwp/schemas/appxpackage/appxmanifestschema/element-application#attributes-and-elements) element.

If you are hosting background task(s) in an out-of-process COM server, separate from your main application, then pass as the argument for `applicationId` the PRAID of the application that defines the `windows.backgroundTask` extension in its own package manifest.

## -returns
An enumeration object that allows you to examine the set of tiles.

## -remarks

## -examples

## -see-also