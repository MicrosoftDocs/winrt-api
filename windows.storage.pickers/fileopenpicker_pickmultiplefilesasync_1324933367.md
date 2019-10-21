---
-api-id: M:Windows.Storage.Pickers.FileOpenPicker.PickMultipleFilesAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Storage.StorageFile>> PickMultipleFilesAsync()
-->

# Windows.Storage.Pickers.FileOpenPicker.PickMultipleFilesAsync

## -description
Shows the file picker so that the user can pick multiple files. (UWP app)

## -returns
When the call to this method completes successfully, it returns a [filePickerSelectedFilesArray](filepickerselectedfilesarray.md) object that contains all the files that were picked by the user. Picked files in this array are represented by [storageFile](../windows.storage/storagefile.md) objects.

## -remarks
> [!WARNING]
> If you try to show the file picker while your app is snapped the file picker will not be shown and an exception will be thrown. You can avoid this by making sure your app is not snapped or by unsnapping it before you call the file picker. The code examples in [FileOpenPicker](fileopenpicker.md) and the [File picker sample](https://go.microsoft.com/fwlink/p/?linkid=234890) show you how.

## -examples


## -see-also
[File picker sample](https://go.microsoft.com/fwlink/p/?linkid=234890), [Quickstart: Accessing files with ](https://docs.microsoft.com/previous-versions/windows/apps/hh465199(v=win.10)), [fileOpenPicker class](fileopenpicker.md), [filePickerSelectedFilesArray class](filepickerselectedfilesarray.md), [Windows.Storage.storageFile class](../windows.storage/storagefile.md)
