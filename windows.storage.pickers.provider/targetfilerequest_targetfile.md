---
-api-id: P:Windows.Storage.Pickers.Provider.TargetFileRequest.TargetFile
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Storage.IStorageFile TargetFile { get;  set; }
-->

# Windows.Storage.Pickers.Provider.TargetFileRequest.TargetFile

## -description
Gets or sets the [IStorageFile](../windows.storage/istoragefile.md) object that is provided to represent the file to save by the app that is providing the save location.

## -property-value
The object that represents the file to save. The app that called the file picker in order to save will write content to this file.

## -remarks
If your app (as the provider of the save location) can't provide an object for the file to save, set this property to **null**. Unless the user selects an existing file to save, your app should create a [StorageFile](../windows.storage/storagefile.md) object to represent the file sets this property to that object.

The file name and extension of the object that represents the file to save must match the file name and extension specified by the user (and accessible through the [FileName](filesavepickerui_filename.md) property) or the attempt to save the file will fail. If the attempt fails, the user can try to save the file again.

## -examples

## -see-also
[TargetFileRequest class](targetfilerequest.md), [Windows.Storage.IStorageFile interface](../windows.storage/istoragefile.md), [Windows.Storage.StorageFile class](../windows.storage/storagefile.md)