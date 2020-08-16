---
-api-id: T:Windows.Storage.Pickers.FileSavePicker
-api-type: winrt class
---

<!-- Class syntax.
public class FileSavePicker : Windows.Storage.Pickers.IFileSavePicker, Windows.Storage.Pickers.IFileSavePicker2, Windows.Storage.Pickers.IFileSavePicker3
-->

# Windows.Storage.Pickers.FileSavePicker

## -description

Represents a file picker that lets the user choose the file name, extension, and storage location for a file.

## -remarks

> [!IMPORTANT]
> You must use the [FileTypeChoices property](filesavepicker_filetypechoices.md) property to specify one or more file types before you call the PickSaveFileAsync method, or the picker will thrown an exception. 

To learn how to save files through the file picker, see [How to save files through file pickers](https://docs.microsoft.com/windows/uwp/files/quickstart-save-a-file-with-a-picker).

To get started accessing files and folders file picker, see [Files, folders, and libraries ](https://docs.microsoft.com/windows/uwp/files/index).

> [!WARNING]
> If you try to show the file picker while your app is snapped the file picker will not be shown and an exception will be thrown. You can avoid this by making sure your app is not snapped or by unsnapping it before you call the file picker. The following code examples and the [File picker sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePicker) show you how.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1903 | 18362 | CreateForUser |
| 1903 | 18362 | User |

## -examples

The [File picker sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePicker) demonstrates how to check whether the app is snapped, how to set file picker properties, and how to show a file picker so that the user can save a file.

[!code-csharp[all_savepicker_checksnapped_show](../windows.storage.pickers/code/FilePicker/CS/Scenario4.xaml.cs#Snippetall_savepicker_checksnapped_show)]

[!code-js[all_savepicker_checksnapped_show](../windows.storage.pickers/code/FilePicker/js/js/scenario4.js#Snippetall_savepicker_checksnapped_show)]

[!code-cpp[all_savepicker_checksnapped_show](../windows.storage.pickers/code/FilePicker/CPP/Scenario4.xaml.cpp#Snippetall_savepicker_checksnapped_show)]

[!code-csharp[cs_checksnapped](../windows.storage.pickers/code/FilePicker/CS/Constants.cs#Snippetcs_checksnapped)]

## -see-also

[File picker sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FilePicker), [Files, folders, and libraries](https://docs.microsoft.com/windows/uwp/files/index), [How to save files with a file picker](https://docs.microsoft.com/windows/uwp/files/quickstart-save-a-file-with-a-picker),  [Windows.Storage.StorageFile class](../windows.storage/storagefile.md)
