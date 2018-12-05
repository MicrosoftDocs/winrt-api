---
-api-id: T:Windows.Storage.Pickers.FileOpenPicker
-api-type: winrt class
---

<!-- Class syntax.
public class FileOpenPicker : Windows.Storage.Pickers.IFileOpenPicker, Windows.Storage.Pickers.IFileOpenPicker2, Windows.Storage.Pickers.IFileOpenPickerWithOperationId
-->

# Windows.Storage.Pickers.FileOpenPicker

## -description

Represents a UI element that lets the user choose and open files.

## -remarks

To get started accessing files and folders file picker, see [Quickstart: Accessing files with ](http://msdn.microsoft.com/library/df082239-381c-462f-9f97-d2b390a2052e).

## -examples

The [File picker sample](http://go.microsoft.com/fwlink/p/?linkid=234890) demonstrates how to check whether the app is snapped, how to set file picker properties, and how to show a file picker so that the user can pick one file.

[!code-csharp[all_openpicker_checksnapped_showsingle](../windows.storage.pickers/code/FilePicker/CS/Scenario1.xaml.cs#Snippetall_openpicker_checksnapped_showsingle)]

[!code-js[all_openpicker_checksnapped_showsingle](../windows.storage.pickers/code/FilePicker/js/js/scenario1.js#Snippetall_openpicker_checksnapped_showsingle)]

[!code-csharp[cs_checksnapped](../windows.storage.pickers/code/FilePicker/CS/Constants.cs#Snippetcs_checksnapped)]

> [!NOTE]
> You should always make sure that your app is not snapped (or that it can be unsnapped) and set file picker properties regardless of whether the user is picking a single file or multiple files.

[!code-csharp[all_openpicker_showmulti](../windows.storage.pickers/code/FilePicker/CS/Scenario2.xaml.cs#Snippetall_openpicker_showmulti)]

[!code-js[all_openpicker_showmulti](../windows.storage.pickers/code/FilePicker/js/js/scenario2.js#Snippetall_openpicker_showmulti)]

## -see-also

[File picker sample](http://go.microsoft.com/fwlink/p/?LinkId=619994), [Quickstart: Accessing files with File Pickers ](https://docs.microsoft.com/en-us/windows/uwp/files/quickstart-using-file-and-folder-pickers), Blobs sample](http://go.microsoft.com/fwlink/p/?LinkId=620573),
