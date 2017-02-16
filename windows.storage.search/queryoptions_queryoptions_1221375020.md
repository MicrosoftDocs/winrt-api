---
-api-id: M:Windows.Storage.Search.QueryOptions.#ctor
-api-type: winrt method
---

<!-- Method syntax
public QueryOptions()
-->

# Windows.Storage.Search.QueryOptions.QueryOptions

## -description
Creates an instance of the [QueryOptions](queryoptions.md) class for enumerating storage items, and initializes it with the following default settings: [QueryOptions.FolderDepth](queryoptions_folderdepth.md) gets [FolderDepth.Shallow](folderdepth.md) and [QueryOptions.IndexerOption](queryoptions_indexeroption.md) gets [IndexerOption.DoNotUseIndexer](indexeroption.md).

A [QueryOptions](queryoptions.md) object with the preceding options will provide shallow, folder-by-folder enumeration of the files and folders in a location. By default, folders are enumerated before files and both files and folders are alphabetized by name.

## -remarks

## -examples

## -see-also
[QueryOptions(CommonFileQuery, IIterable(String))](queryoptions_queryoptions_811500193.md), [QueryOptions(CommonFolderQuery)](queryoptions_queryoptions_1209951623.md)