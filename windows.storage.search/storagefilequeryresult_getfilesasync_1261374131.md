---
-api-id: M:Windows.Storage.Search.StorageFileQueryResult.GetFilesAsync(System.UInt32,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Storage.StorageFile>> GetFilesAsync(System.UInt32 startIndex, System.UInt32 maxNumberOfItems)
-->

# Windows.Storage.Search.StorageFileQueryResult.GetFilesAsync

## -description
Retrieves a list of files in a specified range.

## -parameters
### -param startIndex
The zero-based index of the first file to retrieve. This parameter is 0 by default.

### -param maxNumberOfItems
The maximum number of files to retrieve. Use the max value of `UInt32` (e.g. `uint.MaxValue` in C#, `std::numeric_limits<uint32_t>::max()` in C++. Some code in C++ may use `-1` if implicit conversion is allowed) to retrieve all files. If the range contains fewer files than the max number, all files in the range are returned.

## -returns
When this method completes successfully, it returns a list (type [IVectorView](../windows.foundation.collections/ivectorview_1.md)) of files that are represented by [StorageFile](../windows.storage/storagefile.md) objects.

## -remarks
Use this overload to improve system performance by presenting a virtualized view of the query results that includes only the necessary subset of files. For example, if your app displays many files in a gallery you could use this range to retrieve only the files that are currently visible to the user.

## -examples

## -see-also
[StorageFileQueryResult class](storagefilequeryresult.md), [StorageFileQueryResult.GetFilesAsync() method](storagefilequeryresult_getfilesasync_819750470.md), [Windows.Foundation.Collections.IVectorView interface](../windows.foundation.collections/ivectorview_1.md)
