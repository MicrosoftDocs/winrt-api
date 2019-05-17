---
-api-id: P:Windows.ApplicationModel.Activation.FileActivatedEventArgs.NeighboringFilesQuery
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.Search.StorageFileQueryResult NeighboringFilesQuery { get; }
-->

# Windows.ApplicationModel.Activation.FileActivatedEventArgs.NeighboringFilesQuery

## -description
Gets the neighboring files of the files for which the app was activated.

## -property-value
The [StorageFile](../windows.storage/storagefile.md) objects that represent the neighboring files of the files being passed to the app.

## -remarks
Apps that activate to handle file associations get an object that represents the invoked file only. This can be a problem for media gallery apps in which users expect to navigate to neighboring files. Use the NeighboringFilesQuery property to get the collection of the files in the surrounding *view*, which is the collection that the invoked file was selected from.

Your apps need to declare a library capability to get items of the corresponding type. To get pictures in the NeighboringFilesQuery, you need the Pictures library capability, and to get music files, you need the Music library capability.

The NeighboringFilesQuery property is available only when a single file is invoked. If the size of the [Files](fileactivatedeventargs_files.md) collection is more than 1, the value of NeighboringFilesQuery is **null**. Also, the query is not always available for all invocations, so you can use it only if present.

## -examples

## -see-also
