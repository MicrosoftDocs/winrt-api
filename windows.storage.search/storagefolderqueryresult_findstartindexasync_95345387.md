---
-api-id: M:Windows.Storage.Search.StorageFolderQueryResult.FindStartIndexAsync(System.Object)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<uint> FindStartIndexAsync(System.Object value)
-->

# Windows.Storage.Search.StorageFolderQueryResult.FindStartIndexAsync

## -description
Retrieves the index of the folder from the query results that most closely matches the specified property value. The property that is matched is determined by the first [SortEntry](sortentry.md) of the [QueryOptions.SortOrder](queryoptions_sortorder.md) list.

## -parameters
### -param value
The property value to match when searching the query results. The property to that is used to match this value is the property in the first [SortEntry](sortentry.md) of the [QueryOptions.SortOrder](queryoptions_sortorder.md) list.

## -returns
When this method completes successfully it returns the index of the matched folder in the query results; otherwise it returns **uint.MaxValue**.

## -remarks

## -examples
This example shows how to find the first album that has a title that begins with an "R" in a set of query results that contains albums sorted by title.

```csharp

QueryOptions queryOptions = new QueryOptions();
queryOptions.FolderDepth = FolderDepth.Deep;
queryOptions.IndexerOption = IndexerOption.OnlyUseIndexer;
SortEntry album = new SortEntry();
album.AscendingOrder = true;
album.PropertyName = "System.Music.AlbumTitle";
queryOptions.SortOrder.Add(album);

StorageFolderQueryResult queryResult = musicFolder.CreateFolderQueryWithOptions(queryOptions);
var firstIndex = await queryResult.FindStartIndexAsync("R");
```

## -see-also
