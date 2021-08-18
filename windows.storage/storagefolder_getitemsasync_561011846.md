---
-api-id: M:Windows.Storage.StorageFolder.GetItemsAsync(System.UInt32,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Storage.IStorageItem>> GetItemsAsync(System.UInt32 startIndex, System.UInt32 maxItemsToRetrieve)
-->

# Windows.Storage.StorageFolder.GetItemsAsync

## -description
Gets an index-based range of files and folders from the list of all files and subfolders in the current folder.

## -parameters
### -param startIndex
The zero-based index of the first item in the range to get.

### -param maxItemsToRetrieve
The maximum number of items to get.

## -returns
When this method completes successfully, it returns a list of the files and subfolders in the current folder. The list is of type **IReadOnlyList**&lt;[IStorageItem](istorageitem.md)&gt;. Each item in the list is represented by an [IStorageItem](istorageitem.md) object.

To work with the returned items, call the [IsOfType](istorageitem_isoftype_1417811226.md) method of the [IStorageItem](istorageitem.md) interface to determine whether each item is a file or a folder. Then cast the item to a [StorageFolder](storagefolder.md) or [StorageFile](storagefile.md).

## -exceptions
### T:System.UnauthorizedAccessException

You don't have permission to access the contents of the current folder. For more information, see [File access permissions](/windows/uwp/files/file-access-permissions).

## -remarks

## -examples

## -see-also
[File access permissions](/windows/uwp/files/file-access-permissions), [GetItemsAsync](storagefolder_getitemsasync_1518547059.md), [GetFilesAsync](/uwp/api/windows.storage.storagefolder.getfilesasync), [GetFoldersAsync](/uwp/api/windows.storage.storagefolder.getfoldersasync)