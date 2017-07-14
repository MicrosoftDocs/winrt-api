---
-api-id: M:Windows.Storage.StorageFolder.GetFilesAsync(Windows.Storage.Search.CommonFileQuery,System.UInt32,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Storage.StorageFile>> GetFilesAsync(Windows.Storage.Search.CommonFileQuery query, System.UInt32 startIndex, System.UInt32 maxItemsToRetrieve)
-->

# Windows.Storage.StorageFolder.GetFilesAsync

## -description
<!--{annotation author="miriamw" time="2/22/2012 4:21:25 PM"}TODO: confirm that the files are assigned indexes based on teh sorting dictated by CommonfileQuery-->
Gets an index-based range of files from the list of all files in the current folder. Also gets the files from the subfolders of the current folder when the value of the *query* argument is something other than [CommonFileQuery.DefaultQuery](../windows.storage.search/commonfilequery.md). Files are sorted based on the specified value from the [CommonFileQuery](../windows.storage.search/commonfilequery.md) enumeration.

## -parameters
### -param query
One of the enumeration values that specifies how to sort the files and determines whether the query is shallow or deep.

### -param startIndex
The zero-based index of the first file in the range to retrieve.

### -param maxItemsToRetrieve
The maximum number of files to retrieve.

## -returns
When this method completes successfully, it returns a flat list of files sorted as specified by *query*. The list is of type **IReadOnlyList**&lt;[StorageFile](storagefile.md)&gt;. Each file in the list is represented by a [StorageFile](storagefile.md) object.

## -exceptions
### System.UnauthorizedAccessException

You don't have permission to access the contents of the current folder.

## -remarks

## -examples

using Windows.Storage;

...

Task<IStorageFile> OpenOrCreateFile(string FileName, IStorageFolder InFolder)
{  
    try
    {
        return await InFolder.GetFileAsync(FileName);
    }
    catch (Exception eIn)
    {
        try
        {
            return await InFolder.CreateFileAsync(FileName);
        }
        catch (Exception eOut)
        { 
            throw new Exception(eOut.Message, eIn);
        }
    }

}

## -see-also
[GetFilesAsync(CommonFileQuery)](storagefolder_getfilesasync_1429382825.md), [GetFilesAsync](storagefolder_getfilesasync_819750470.md), [GetItemsAsync](storagefolder_getitemsasync.md)
