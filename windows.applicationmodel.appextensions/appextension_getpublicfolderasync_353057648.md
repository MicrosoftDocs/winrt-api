---
-api-id: M:Windows.ApplicationModel.AppExtensions.AppExtension.GetPublicFolderAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFolder> GetPublicFolderAsync()
-->

# Windows.ApplicationModel.AppExtensions.AppExtension.GetPublicFolderAsync

## -description

Gets the subfolder provided by the `PublicFolder` attribute in the app extension for sharing files between the extension and the host.

## -returns

The public sub-folder.

## -remarks

Extensions must create this folder by populating it with files as part of their package defintion. It is read-only to both the
extension and its host.

## -examples

## -see-also

[GetPublicFolder](appextension_getpublicfolder_126839260.md), [GetPublicPath](./appextension_getpublicpath_925518924.md)
