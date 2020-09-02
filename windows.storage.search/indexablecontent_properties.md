---
-api-id: P:Windows.Storage.Search.IndexableContent.Properties
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IMap<string, object> Properties { get; }
-->

# Windows.Storage.Search.IndexableContent.Properties

## -description
Gets the content properties.

## -property-value
The collection of properties, represented as a [Map](../windows.foundation.collections/imap_2.md) of key-value pairs.

## -remarks
While access to this type is read-only, it returns a read/write map.

Add a property to index by calling the [Insert](../windows.foundation.collections/imap_2_insert_884970571.md) method with a standard Windows property name, like [System.Author](/windows/desktop/properties/props-system-author), and a [PropertyValue](../windows.foundation/propertyvalue.md).

When you're done adding properties to the current [IndexableContent](indexablecontent.md), call the [AddAsync](contentindexer_addasync_916871935.md) method to add the properties to the system index.

## -examples

## -see-also
[AddAsync](contentindexer_addasync_916871935.md), [ContentIndexer](contentindexer.md)