---
-api-id: T:Windows.Storage.Search.ContentIndexer
-api-type: winrt class
---

<!-- Class syntax.
public class ContentIndexer : Windows.Storage.Search.IContentIndexer, Windows.Storage.Search.IContentIndexerQueryOperations
-->

# Windows.Storage.Search.ContentIndexer

## -description

Enables UWP apps to make private content searchable by using the system index.

## -remarks

The ContentIndexer class enables apps to push a property bag into the system index which can later be searched quickily by the app or user. The property bag can contain any properties from the shell property system and is available to search instantly after the API call returns.

The properties are defined as string-object key-value pairs, where the keys are standard Windows property names, like [System.Author](https://msdn.microsoft.com/library/windows/desktop/bb760652.aspx), and the values are [PropertyValue](../windows.foundation/propertyvalue.md) instances. The property must be registered on the system and have isColumn and isInvertedIndex set to true. You can also provide full-text search content by using a stream and content type. This corresponds to running the [IFilter](https://msdn.microsoft.com/library/windows/desktop/bb266451.aspx) implementation for the type and indexing the content.

You can query over content by using Advanced Query Syntax ([AQS](https://msdn.microsoft.com/en-us/library/windows/desktop/bb266512(v=vs.85).aspx)).

Don't use the index as a primary data store, the index is only a cache of searchable properties. All data in the index must be stored elsewhere in case the cache is lost. Content is separated per app package and per user. A package can't query another package's data, but the operating system can access any data that is pushed in.

For more information on the properties available to use, see the [Windows Property System](http://msdn.microsoft.com/library/c2094bbe-a4ca-4f30-b16e-14dced2912bc).

## -examples

[Content indexer sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620524)

[Video Walkthrough of a demo app](https://channel9.msdn.com/events/Build/2016/P407)

## -see-also

[ContentIndexerQuery](contentindexerquery.md), [IndexableContent](indexablecontent.md), [QueryOptions](queryoptions.md), [StorageFileQueryResult](storagefilequeryresult.md), [StorageFolderQueryResult](storagefolderqueryresult.md), [StorageItemQueryResult](storageitemqueryresult.md), [Windows Property System](http://msdn.microsoft.com/library/c2094bbe-a4ca-4f30-b16e-14dced2912bc)
