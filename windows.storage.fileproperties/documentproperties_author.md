---
-api-id: P:Windows.Storage.FileProperties.DocumentProperties.Author
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<string> Author { get; }
-->

# Windows.Storage.FileProperties.DocumentProperties.Author

## -description
Gets the collection of the document's authors.

## -property-value
The name of the document author.

## -remarks
This property is read-only. It returns a collection, and you can't delete or replace the collection itself. The contents of the collection, however, are not read-only. You can add items to the collection, remove items from the collection, and change existing items in the collection. Call the **SavePropertiesAsync** method of the parent class to save the updated contents of the collection.

## -examples

## -see-also
