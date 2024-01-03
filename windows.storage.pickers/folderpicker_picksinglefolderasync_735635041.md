---
-api-id: M:Windows.Storage.Pickers.FolderPicker.PickSingleFolderAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFolder> PickSingleFolderAsync()
-->

# Windows.Storage.Pickers.FolderPicker.PickSingleFolderAsync

## -description
Shows the [folderPicker](folderpicker.md) object so that the user can pick a folder. (UWP app)

> [!NOTE]
> You must specify the [FileTypeFilter](folderpicker_filetypefilter.md) before calling this method, or it will throw an exception. To list all folders, use "*" as the filter.

## -returns
When the call to this method completes successfully, it returns a [storageFolder](../windows.storage/storagefolder.md) object that represents the folder that the user picked.

## -remarks

### Notes for previous versions

> **Windows 8.x**
> If you try to show the file picker while your app is snapped the file picker will not be shown and an exception will be thrown. You can avoid this by making sure your app is not snapped or by unsnapping it before you call the file picker.

## -examples

## -see-also

[folderPicker class](folderpicker.md)
