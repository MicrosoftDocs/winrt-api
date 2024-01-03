---
-api-id: M:Windows.ApplicationModel.AppExtensions.AppExtension.GetPublicFolder
-api-type: winrt method
---

# Windows.ApplicationModel.AppExtensions.AppExtension.GetPublicFolder

<!--
public Windows.Storage.StorageFolder GetPublicFolder ();
-->

## -description

Gets the readable subfolder in the extension's isolated storage.

## -returns

The public sub-folder.

## -remarks

An extension can provide a subfolder containing files that hosting apps can read from. Hosts cannot write to the folder.

## -examples

## -see-also

[GetPublicFolderAsync](appextension_getpublicfolderasync_353057648.md), [GetPublicPath](./appextension_getpublicpath_925518924.md)
