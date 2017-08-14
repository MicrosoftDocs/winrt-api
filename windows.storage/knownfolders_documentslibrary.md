---
-api-id: P:Windows.Storage.KnownFolders.DocumentsLibrary
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.StorageFolder DocumentsLibrary { get; }
-->

# Windows.Storage.KnownFolders.DocumentsLibrary

## -description
Gets the Documents library. The Documents library is not intended for general use.

## -property-value
The Documents library.

## -remarks
> > [!IMPORTANT]
> The Documents library is not intended for general use. For more info, see [App capability declarations](http://msdn.microsoft.com/library/25b18ba5-e584-4537-9f19-bb2c8c52dfe1).

If your app has to create and update files that only your app uses, consider using the app's [LocalCache](applicationdata_localcachefolder.md) folder. For more information on which folders you should use for your app's data, see [ApplicationData](applicationdata.md) class.

Alternatively, let the user select the file location by using a file picker. For more info, see [Open files and folders with a picker](http://msdn.microsoft.com/library/f87dbe2f-77db-4573-8172-29e11abefd34).

### Prerequisites

To access the Documents library, do the following things.

+ In the app manifest, specify the **Documents Library** capability. This capability is not visible in Manifest Designer. To add the Documents Library capability, open the app manifest in code view and edit the XML directly.
+ In the app manifest, register at least one File Type Association declaration. This declaration explicitly indicates the file types (extensions) that your app wants to access in the Documents library. The app can only enumerate, create, or change files that have the file types declared in the app manifest. For more info, see [Handle file activation](http://msdn.microsoft.com/library/a0f914c5-62bc-4ff7-9236-e34c5277c363).


### Return value

To work with the Documents library and its contents, call the methods and properties of the [StorageFolder](storagefolder.md) class. For general info about how to use files and folders, see [Enumerate and query files and folders](http://msdn.microsoft.com/library/4c59d5ac-58f7-4863-a884-e9e54228a5ad).

## -examples

## -see-also


## -capabilities
documentsLibrary
