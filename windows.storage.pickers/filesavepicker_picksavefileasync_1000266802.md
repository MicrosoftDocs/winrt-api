---
-api-id: M:Windows.Storage.Pickers.FileSavePicker.PickSaveFileAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFile> PickSaveFileAsync()
-->

# Windows.Storage.Pickers.FileSavePicker.PickSaveFileAsync

## -description
Shows the file picker so that the user can save a file and set the file name, extension, and location of the file to be saved. (UWP app)

## -returns
When the call to this method completes successfully, it returns a [storageFile](../windows.storage/storagefile.md) object that was created to represent the saved file. The file name, extension, and location of this [storageFile](../windows.storage/storagefile.md) match those specified by the user, but the file has no content.

To save the content of the file, your app must write the content to this [storageFile](../windows.storage/storagefile.md).

## -remarks
> [!WARNING]
> You must use the [FileTypeChoices property](filesavepicker_filetypechoices.md)  to set one or more valid file extensions before calling this method, or it will thrown an exception. 


> [!WARNING]
> If you try to show the file picker while your app is snapped the file picker will not be shown and an exception will be thrown. You can avoid this by making sure your app is not snapped or by unsnapping it before you call the file picker. The code examples in [FileSavePicker](filesavepicker.md) and the [File picker sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePicker) show you how.

## -examples

## -see-also
[FileSavePicker class](filesavepicker.md)
