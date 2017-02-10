---
-api-id: P:Windows.Storage.FileProperties.ImageProperties.Keywords
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<string> Keywords { get; }
-->

# Windows.Storage.FileProperties.ImageProperties.Keywords

## -description
Gets the collection of keywords associated with the image.

## -property-value
The collection of keywords.

## -remarks
This property is read-only. It returns a collection, and you can't delete or replace the collection itself. The contents of the collection, however, are not read-only. You can add items to the collection, remove items from the collection, and change existing items in the collection. Call the **SavePropertiesAsync** method of the parent class to save the updated contents of the collection.

## -examples

## -see-also
