---
-api-id: M:Windows.Storage.Search.StorageFileQueryResult.FindStartIndexAsync(System.Object)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<uint> FindStartIndexAsync(System.Object value)
-->

# Windows.Storage.Search.StorageFileQueryResult.FindStartIndexAsync

## -description
Retrieves the index of the file from the query results that most closely matches the specified property value (or file, if used with [FileActivatedEventArgs.NeighboringFilesQuery](../windows.applicationmodel.activation/fileactivatedeventargs_neighboringfilesquery.md)). The property that is matched is determined by the first [SortEntry](sortentry.md) of the [QueryOptions.SortOrder](queryoptions_sortorder.md) list.

## -parameters
### -param value
The property value to match when searching the query results. The property to that is used to match this value is the property in the first [SortEntry](sortentry.md) of the [QueryOptions.SortOrder](queryoptions_sortorder.md) list.

Or, the file to match when searching with [FileActivatedEventArgs.NeighboringFilesQuery](../windows.applicationmodel.activation/fileactivatedeventargs_neighboringfilesquery.md).

## -returns
When this method completes successfully, it returns the index of the matched file in the query results or the index of the file in the [FileActivatedEventArgs.NeighboringFilesQuery](../windows.applicationmodel.activation/fileactivatedeventargs_neighboringfilesquery.md). In the latter case, the file is expected to be sourced from [FileActivatedEventArgs.Files](../windows.applicationmodel.activation/ifileactivatedeventargs_files.md). If this function fails, it returns **uint.MaxValue**.

## -remarks
You can use this method in conjunction with [FileActivatedEventArgs.NeighboringFilesQuery](../windows.applicationmodel.activation/fileactivatedeventargs_neighboringfilesquery.md) to iterate between neighboring files while preserving the original view's sort order.

## -examples
This example shows how to find the first song in an album that has a title beginning with the "R" in a set of query results that contains songs grouped by album title.

```csharp

QueryOptions queryOptions = new QueryOptions();
queryOptions.FolderDepth = FolderDepth.Deep;
queryOptions.IndexerOption = IndexerOption.OnlyUseIndexer;
SortEntry album = new SortEntry();
album.AscendingOrder = true;
album.PropertyName = "System.Music.AlbumTitle";
queryOptions.SortOrder.Add(album);

StorageFileQueryResult queryResult = musicFolder.CreateFileQueryWithOptions(queryOptions);
var firstIndex = await queryResult.FindStartIndexAsync("R");
```

```javascript
var queryOptions = new Windows.Storage.Search.QueryOptions();
queryOptions.folderDepth = Windows.Storage.Search.FolderDepth.deep;
queryOptions.indexerOption = Windows.Storage.Search.IndexerOptions.onlyUseIndexer;
queryOptions.sortOrder.append({
 ascendingOrder: true,
 propertyName: "System.Music.AlbumTitle"
});

var queryResult = Windows.Storage.KnownFolders.picturesLibrary.createFileQueryWithOptions(queryOptions);
var firstIndex = queryResult.findStartIndexAsync("R");
```



## -see-also
