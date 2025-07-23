---
-api-id: M:Windows.ApplicationModel.AppExtensions.AppExtension.GetPublicFolder
-api-type: winrt method
---

# Windows.ApplicationModel.AppExtensions.AppExtension.GetPublicFolder

<!--
public Windows.Storage.StorageFolder GetPublicFolder ();
-->

## -description

Gets the subfolder provided by the `PublicFolder` attribute in the app extension for sharing files between the extension and the host.

## -returns

The public sub-folder.

## -remarks

Extensions must create this folder by populating it with files as part of their package definition. It is read-only to both the extension and its host.

## -examples

## -see-also

[GetPublicFolderAsync](appextension_getpublicfolderasync_353057648.md), [GetPublicPath](./appextension_getpublicpath_925518924.md)
