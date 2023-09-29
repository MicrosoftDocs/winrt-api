---
-api-id: M:Windows.ApplicationModel.PackageExtensions.PackageExtension.GetPublicFolderAsync
-api-type: winrt method
---

# Windows.ApplicationModel.PackageExtensions.PackageExtension.GetPublicFolderAsync

<!--
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFolder> GetPublicFolderAsync ();
-->

## -description

Gets the readable subfolder in the extension's isolated storage.

## -returns

The public subfolder as an async operation.

## -remarks

An extension can provide a subfolder containing files that hosting apps can read from. Hosts cannot write to the folder.

## -see-also

[GetPublicFolder](packageextension_getpublicfolder_126839260.md)

## -examples
