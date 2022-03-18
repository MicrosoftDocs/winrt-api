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
> The Documents library is not intended for general use. For more info, see [App capability declarations](/windows/uwp/packaging/app-capability-declarations).

If your app has to create and update files that only your app uses, consider using the app's [LocalCache](applicationdata_localcachefolder.md) folder. For more information on which folders you should use for your app's data, see [ApplicationData](applicationdata.md) class.

Alternatively, let the user select the file location by using a file picker. For more info, see [Open files and folders with a picker](/windows/uwp/files/quickstart-using-file-and-folder-pickers) and in particular the [`SuggestedStartLocation` property](/uwp/api/windows.storage.pickers.fileopenpicker.suggestedstartlocation?view=winrt-19041) which can be set to [`DocumentsLibrary`](/uwp/api/windows.storage.pickers.pickerlocationid?view=winrt-19041). If the user selects the Documents Library from within the picker, you **do not** need to use this property nor do you need the **documentsLibrary** capability. 

### Prerequisites

To access the Documents library *without* using a picker, do the following things.

+ In the app manifest, specify the **Documents Library** capability. This capability is not visible in Manifest Designer. To add the Documents Library capability, open the app manifest in code view and edit the XML directly. You **do not** need this capability if you use the file pickers.
+ In the app manifest, register at least one File Type Association declaration. This declaration explicitly indicates the file types (extensions) that your app wants to access in the Documents library. The app can only enumerate, create, or change files that have the file types declared in the app manifest. For more info, see [Handle file activation](/windows/uwp/launch-resume/handle-file-activation). You **do not** need to add this declaration if you use the file pickers.


### Return value

To work with the Documents library and its contents, call the methods and properties of the [StorageFolder](storagefolder.md) class. For general info about how to use files and folders, see [Enumerate and query files and folders](/windows/uwp/files/quickstart-listing-files-and-folders).

## -examples

## -see-also


## -capabilities
documentsLibrary
