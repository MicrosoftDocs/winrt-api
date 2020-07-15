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

Typically you get StorageFolder objects as the return value of asynchronous method calls. For example, the static method [GetFolderFromPathAsync](storagefolder_getfolderfrompathasync_1337535799.md) returns a StorageFolder that represents the specified folder.

Note that when you call a file picker to let the user pick a folder, the file picker returns the folder as a StorageFolder.

There is not currently a "MoveAsync" or similar method. One simple implementation of moving a folder might be to get the desired folder, copy it to the desired location, and then delete the original folder.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | TryGetChangeTracker |
| 2004 | 19041 | GetFolderFromPathForUserAsync |

## -examples

## -see-also

[StorageFile](storagefile.md), [Folder enumeration sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FolderEnumeration), [Content indexer sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ContentIndexer), [File access sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FileAccess), [File search sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FileSearch)

## -capabilities

documentsLibrary, musicLibrary, picturesLibrary, videosLibrary
