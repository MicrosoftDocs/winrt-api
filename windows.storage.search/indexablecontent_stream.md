---
-api-id: P:Windows.Storage.Search.IndexableContent.Stream
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.Streams.IRandomAccessStream Stream { get;  set; }
-->

# Windows.Storage.Search.IndexableContent.Stream

## -description
Gets or sets a [Stream](indexablecontent_stream.md) that provides full-text content. Changes to the actual representation of the item in the index can be made using the [ContentIndexer](contentindexer.md) class.

## -property-value
The stream used to provide the full-text content for the item.

## -remarks
Assign the [Stream](indexablecontent_stream.md) property when the content properties are backed by a file or another kind of stream. This is particularly useful for providing full text content.

## -examples

## -see-also
[AddAsync](contentindexer_addasync_916871935.md), [ContentIndexer](contentindexer.md)