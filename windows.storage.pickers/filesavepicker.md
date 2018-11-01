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

To learn how to save files through the file picker, see [How to save files through file pickers](https://docs.microsoft.com/windows/uwp/files/quickstart-save-a-file-with-a-picker).

To get started accessing files and folders file picker, see [Files, folders, and libraries ](https://docs.microsoft.com/windows/uwp/files/index).

> [!WARNING]
> If you try to show the file picker while your app is snapped the file picker will not be shown and an exception will be thrown. You can avoid this by making sure your app is not snapped or by unsnapping it before you call the file picker. The following code examples and the [File picker sample](http://go.microsoft.com/fwlink/p/?linkid=234890) show you how.

## -examples

The [File picker sample](http://go.microsoft.com/fwlink/p/?linkid=234890) demonstrates how to check whether the app is snapped, how to set file picker properties, and how to show a file picker so that the user can save a file.

[!code-csharp[all_savepicker_checksnapped_show](../windows.storage.pickers/code/FilePicker/CS/Scenario4.xaml.cs#Snippetall_savepicker_checksnapped_show)]

[!code-js[all_savepicker_checksnapped_show](../windows.storage.pickers/code/FilePicker/js/js/scenario4.js#Snippetall_savepicker_checksnapped_show)]

[!code-cpp[all_savepicker_checksnapped_show](../windows.storage.pickers/code/FilePicker/CPP/Scenario4.xaml.cpp#Snippetall_savepicker_checksnapped_show)]

[!code-csharp[cs_checksnapped](../windows.storage.pickers/code/FilePicker/CS/Constants.cs#Snippetcs_checksnapped)]

## -see-also

[File picker sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=619994), [Files, folders, and libraries](https://docs.microsoft.com/windows/uwp/files/index), [How to save files with a file picker](https://docs.microsoft.com/windows/uwp/files/quickstart-save-a-file-with-a-picker),  [Windows.Storage.StorageFile class](../windows.storage/storagefile.md)
