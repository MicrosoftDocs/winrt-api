---
-api-id: M:Windows.Storage.StorageFolder.GetFilesAsync(Windows.Storage.Search.CommonFileQuery)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Storage.StorageFile>> GetFilesAsync(Windows.Storage.Search.CommonFileQuery query)
-->

# Windows.Storage.StorageFolder.GetFilesAsync

## -description
Gets the files in the current folder. Also gets the files from the subfolders of the current folder when the value of the *query* argument is something other than [CommonFileQuery.DefaultQuery](../windows.storage.search/commonfilequery.md). Files are sorted based on the specified value from the [CommonFileQuery](../windows.storage.search/commonfilequery.md) enumeration.

## -parameters
### -param query
One of the enumeration values that specifies how to sort the files and determines whether the query is shallow or deep.

## -returns
When this method completes successfully, it returns a flat list of files, sorted as specified by *query*. The list is of type **IReadOnlyList**&lt;[StorageFile](storagefile.md)&gt;. Each file in the list is represented by a [StorageFile](storagefile.md) object.

## -exceptions
### T:System.UnauthorizedAccessException

You don't have permission to access the contents of the current folder. For more information, see [File access permissions](/windows/uwp/files/file-access-permissions).

## -remarks

## -examples

## -see-also
[File access permissions](/windows/uwp/files/file-access-permissions), [GetFilesAsync(CommonFileQuery, UInt32, UInt32)](storagefolder_getfilesasync_1563132095.md), [GetFilesAsync](storagefolder_getfilesasync_819750470.md), [GetItemsAsync](/uwp/api/windows.storage.storagefolder.getitemsasync)