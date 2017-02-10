---
-api-id: M:Windows.Storage.Search.QueryOptions.#ctor(Windows.Storage.Search.CommonFolderQuery)
-api-type: winrt method
---

<!-- Method syntax
public QueryOptions(Windows.Storage.Search.CommonFolderQuery query)
-->

# Windows.Storage.Search.QueryOptions.QueryOptions

## -description
Creates an instance of the [QueryOptions](queryoptions.md) class for enumerating subfolders and initializes it with values based on the specified [CommonFolderQuery](commonfolderquery.md).

## -parameters
### -param query
An enumeration value that specifies how to group the contents of the folder where the query is created into subfolders to enumerate. The subfolders that are retrieved using a [CommonFolderQuery](commonfolderquery.md) can be actual file system folders or virtual folders that represent groups of files (which are determined by the [CommonFolderQuery](commonfolderquery.md) value). For example, the [CommonFolderQuery.GroupByArtist](commonfolderquery.md) uses the [Artist](../windows.storage.fileproperties/musicproperties_artist.md) of the files in the folder (and its subfolders) to group files, creating one virtual folder (or file group) for each artist.

## -remarks

## -examples

## -see-also
[QueryOptions(CommonFileQuery, IIterable(String))](queryoptions_queryoptions_811500193.md)