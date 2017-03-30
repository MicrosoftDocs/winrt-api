---
-api-id: T:Windows.Storage.Search.ContentIndexer
-api-type: winrt class
---

<!-- Class syntax.
public class ContentIndexer : Windows.Storage.Search.IContentIndexer, Windows.Storage.Search.IContentIndexerQueryOperations
-->

# Windows.Storage.Search.ContentIndexer

## -description
Enables Windows Store app to place content properties in the system index.

## -remarks
The index is a cache of searchable properties for data that's backed by storage elsewhere. Don't use the index as a primary data store.

Define properties for the index with string-object key-value pairs, where the keys are standard Windows property names, like [System.Author](https://msdn.microsoft.com/library/windows/desktop/bb760652.aspx), and the values are [PropertyValue](../windows.foundation/propertyvalue.md) instances. The property must be registered on the system and have isColumn and isInvertedIndex set to true. 

You query over content by using Advanced Query Syntax (AQS).

Also, you can provide full-text search content by using a stream and content type. This corresponds to running the [IFilter](https://msdn.microsoft.com/library/windows/desktop/bb266451.aspx) implementation for the type and indexing the content.

For more information, see the [Windows Property System](http://msdn.microsoft.com/library/c2094bbe-a4ca-4f30-b16e-14dced2912bc).

Define properties for the index with string-object key-value pairs, where the keys are standard Windows property names, like [System.Author](https://msdn.microsoft.com/library/windows/desktop/bb760652.aspx), and the values are [PropertyValue](../windows.foundation/propertyvalue.md) instances. The property must be registered on the system. The keys should be described as standard Windows property canonical names.

Content is separated per app package and per user. A package can't query another package's data, but the operating system can access the data.

## -examples

## -see-also
[ContentIndexerQuery](contentindexerquery.md), [IndexableContent](indexablecontent.md), [QueryOptions](queryoptions.md), [StorageFileQueryResult](storagefilequeryresult.md), [StorageFolderQueryResult](storagefolderqueryresult.md), [StorageItemQueryResult](storageitemqueryresult.md), [Windows Property System](http://msdn.microsoft.com/library/c2094bbe-a4ca-4f30-b16e-14dced2912bc), [Content indexer sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620524)
