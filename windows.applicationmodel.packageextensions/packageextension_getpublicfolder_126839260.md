---
-api-id: M:Windows.ApplicationModel.PackageExtensions.PackageExtension.GetPublicFolder
-api-type: winrt method
---

# Windows.ApplicationModel.PackageExtensions.PackageExtension.GetPublicFolder

<!--
public Windows.Storage.StorageFolder GetPublicFolder ();
-->

## -description

Gets the readable subfolder in the extension's isolated storage.

## -returns

The public subfolder.

## -remarks

An extension can provide a subfolder containing files that hosting apps can read from. Hosts cannot write to the folder.

## -see-also

[GetPublicFolderAsync](packageextension_getpublicfolderasync_353057648.md)

## -examples
