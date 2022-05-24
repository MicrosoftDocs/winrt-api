---
-api-id: M:Windows.Storage.StorageFolder.GetFoldersAsync(Windows.Storage.Search.CommonFolderQuery)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Storage.StorageFolder>> GetFoldersAsync(Windows.Storage.Search.CommonFolderQuery query)
-->

# Windows.Storage.StorageFolder.GetFoldersAsync

## -description
Gets the subfolders in the current folder. When the value of the *query* argument is something other than [CommonFolderQuery.DefaultQuery](../windows.storage.search/commonfolderquery.md), gets a list of virtual folders that represent containers for groups of files in the subfolders of the current folder. Files are grouped into folders based on the specified value from the [CommonFolderQuery](../windows.storage.search/commonfolderquery.md) enumeration.

## -parameters
### -param query
One of the enumeration values that specifies how to group the files into folders and determines whether the query is shallow or deep.

## -returns
When this method completes successfully, it returns a list of subfolders. When the value of the *query* argument is something other than [CommonFolderQuery.DefaultQuery](../windows.storage.search/commonfolderquery.md), this method returns a list of virtual folders that represent containers for groups of files in the subfolders of the current folder. (Files from the current folder are not included.) The files are grouped as specified by *query*. The list is of type **IReadOnlyList**&lt;[StorageFolder](storagefolder.md)&gt;. Each folder in the list is represented by a [StorageFolder](storagefolder.md) object.

## -exceptions
### T:System.UnauthorizedAccessException

You don't have permission to access the contents of the current folder. For more information, see [File access permissions](/windows/uwp/files/file-access-permissions).

## -remarks

## -examples

## -see-also
[File access permissions](/windows/uwp/files/file-access-permissions), [GetFoldersAsync(CommonFolderQuery, UInt32, UInt32)](storagefolder_getfoldersasync_731846614.md), [GetFoldersAsync](storagefolder_getfoldersasync_592765033.md), [GetItemsAsync](/uwp/api/windows.storage.storagefolder.getitemsasync)