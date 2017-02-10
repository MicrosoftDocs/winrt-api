---
-api-id: M:Windows.Storage.Search.IStorageFolderQueryOperations.IsCommonFileQuerySupported(Windows.Storage.Search.CommonFileQuery)
-api-type: winrt method
---

<!-- Method syntax
public bool IsCommonFileQuerySupported(Windows.Storage.Search.CommonFileQuery query)
-->

# Windows.Storage.Search.IStorageFolderQueryOperations.IsCommonFileQuerySupported

## -description
Verifies whether this folder supports the specified file query (returns true or false).

## -parameters
### -param query
The file query to test.

## -returns
True if the folder supports the specified file query; otherwise false.

## -remarks
Not all locations support all query options. Because files can be retrieved by the picker and you can't control the location, you can use this method to determine whether the location supports a particular query option.

Folders in a library or the HomeGroup support all query options. Other locations only support the following options:
+ A shallow enumeration, such as [CommonFileQuery.DefaultQuery](commonfilequery.md) or [CommonFolderQuery.DefaultQuery](commonfolderquery.md), or a [QueryOptions](queryoptions.md) class that was created with no constructor arguments.
+ A deep, flat list of files sorted by name, such as [CommonFileQuery.orderByName](commonfilequery.md) or the equivalent [QueryOptions](queryoptions.md) class.
+ A deep, flat list of files sorted by search rank, such as [CommonFileQuery.orderBySearchRank](commonfilequery.md) or the equivalent [QueryOptions](queryoptions.md) class.


## -examples

## -see-also
