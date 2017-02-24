---
-api-id: M:Windows.Storage.Search.IStorageFolderQueryOperations.AreQueryOptionsSupported(Windows.Storage.Search.QueryOptions)
-api-type: winrt method
---

<!-- Method syntax
public bool AreQueryOptionsSupported(Windows.Storage.Search.QueryOptions queryOptions)
-->

# Windows.Storage.Search.IStorageFolderQueryOperations.AreQueryOptionsSupported

## -description
Verifies whether the folder supports the specified search query options (returns true or false).

## -parameters
### -param queryOptions
The search query options to test.

## -returns
True if the folder supports the specified search query options; otherwise false.

## -remarks
Not all locations support all query options. Because folders can be retrieved by the picker and you can't control the location, you can use this method to determine whether the location supports a particular query option.

Folders in a library or the HomeGroup support all query options. Other locations only support the following options:
+ A shallow enumeration, such as [CommonFileQuery.DefaultQuery](commonfilequery.md) or [CommonFolderQuery.DefaultQuery](commonfolderquery.md), or a [QueryOptions](queryoptions.md) class that was created with no constructor arguments.
+ A deep, flat list of files sorted by name, such as [CommonFileQuery.orderByName](commonfilequery.md) or the equivalent [QueryOptions](queryoptions.md) class.
+ A deep, flat list of files sorted by search rank, such as [CommonFileQuery.orderBySearchRank](commonfilequery.md) or the equivalent [QueryOptions](queryoptions.md) class.


## -examples

## -see-also
