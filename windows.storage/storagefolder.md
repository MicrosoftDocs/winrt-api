---
-api-id: T:Windows.Storage.StorageFolder
-api-type: winrt class
---

<!-- Class syntax.
public class StorageFolder : Windows.Storage.IStorageFolder, Windows.Storage.IStorageFolder2, Windows.Storage.IStorageItem, Windows.Storage.IStorageItem2, Windows.Storage.IStorageItemProperties, Windows.Storage.IStorageItemProperties2, Windows.Storage.IStorageItemPropertiesWithProvider, Windows.Storage.Search.IStorageFolderQueryOperations
-->

# Windows.Storage.StorageFolder

## -description
Manages folders and their contents and provides information about them.

## -remarks
Typically you get [StorageFolder](storagefolder.md) objects as the return value of asynchronous method calls. For example, the static method [GetFolderFromPathAsync](storagefolder_getfolderfrompathasync.md) returns a [StorageFolder](storagefolder.md) that represents the specified folder.

Additionally, when you call a file picker to let the user pick a folder, the file picker returns the folder as a [StorageFolder](storagefolder.md).

## -examples

## -see-also
[StorageFile](storagefile.md), [Folder enumeration sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=619993)

## -capabilities
picturesLibrary, videosLibrary, musicLibrary, documentsLibrary