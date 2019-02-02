---
-api-id: P:Windows.Storage.KnownFolders.RemovableDevices
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.StorageFolder RemovableDevices { get; }
-->

# Windows.Storage.KnownFolders.RemovableDevices

## -description
Gets the removable devices folder.

## -property-value
The removable devices folder.

## -remarks
### Prerequisites

To access the removable devices folder, you must:

+ In the app manifest, specify the **Removable Storage** capability.
+ In the app manifest, register at least one File Type Association declaration. This declaration explicitly indicates the file types (extensions) that your app wants to access on the removable devices. The app can only enumerate, create, or change files that have the file types declared in the app manifest. For more info, see [Handle file activation](https://msdn.microsoft.com/library/a0f914c5-62bc-4ff7-9236-e34c5277c363).


### Return value

To work with the removable devices folder and its contents, call the methods and properties of the [StorageFolder](storagefolder.md) class. For general info about how to use files and folders, see [Enumerate and query files and folders](https://msdn.microsoft.com/library/4c59d5ac-58f7-4863-a884-e9e54228a5ad).

The folder returned by the **RemovableDevices** property is a virtual folder. This virtual folder contains a subfolder for each removable device that's present. For example, if a single removable device is attached to the computer, the removable devices folder contains a single subfolder for which the name and path may be `D:\`.

If no removable devices are available, reading the value of this property returns an empty folder. It does not raise an exception.

## -examples

## -see-also
[CreateFileQuery](/uwp/api/windows.storage.storagefolder.createfilequery), [CreateFileQueryWithOptions](storagefolder_createfilequerywithoptions_2038131323.md), [CreateFolderQuery](/uwp/api/windows.storage.storagefolder.createfolderquery), [CreateFolderQueryWithOptions](storagefolder_createfolderquerywithoptions_573382953.md)

## -capabilities
removableStorage
