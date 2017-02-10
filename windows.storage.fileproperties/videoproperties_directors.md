---
-api-id: P:Windows.Storage.FileProperties.VideoProperties.Directors
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<string> Directors { get; }
-->

# Windows.Storage.FileProperties.VideoProperties.Directors

## -description
Gets the directors of the video.

## -property-value
A list of the names of the video's directors.

## -remarks
This property is read-only. It returns a collection, and you can't delete or replace the collection itself. The contents of the collection, however, are not read-only. You can add items to the collection, remove items from the collection, and change existing items in the collection. Call the **SavePropertiesAsync** method of the parent class to save the updated contents of the collection.

## -examples

## -see-also
