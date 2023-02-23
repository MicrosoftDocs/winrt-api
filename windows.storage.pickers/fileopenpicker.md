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

In a desktop app, before using an instance of this class in a way that displays UI, you'll need to associate the object with its owner's window handle. For more info, and code examples, see [Display WinRT UI objects that depend on CoreWindow](/windows/apps/develop/ui-input/display-ui-objects#winui-3-with-c).

## -remarks

To get started accessing files and folders file picker, see [Quickstart: Accessing files with File Pickers](/windows/uwp/files/quickstart-using-file-and-folder-pickers).

For information about how to use this API outside of UWP apps, see [Call interop APIs from a .NET app](/windows/apps/desktop/modernize/winrt-com-interop-csharp).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1903 | 18362 | CreateForUser |
| 1903 | 18362 | User |

## -examples

The [File picker sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FilePicker) demonstrates how to check whether the app is snapped, how to set file picker properties, and how to show a file picker so that the user can pick one file.

[!code-csharp[all_openpicker_checksnapped_showsingle](../windows.storage.pickers/code/FilePicker/CS/Scenario1.xaml.cs#Snippetall_openpicker_checksnapped_showsingle)]

[!code-js[all_openpicker_checksnapped_showsingle](../windows.storage.pickers/code/FilePicker/js/js/scenario1.js#Snippetall_openpicker_checksnapped_showsingle)]

[!code-csharp[cs_checksnapped](../windows.storage.pickers/code/FilePicker/CS/Constants.cs#Snippetcs_checksnapped)]

> [!NOTE]
> You should always make sure that your app is not snapped (or that it can be unsnapped) and set file picker properties regardless of whether the user is picking a single file or multiple files.

[!code-csharp[all_openpicker_showmulti](../windows.storage.pickers/code/FilePicker/CS/Scenario2.xaml.cs#Snippetall_openpicker_showmulti)]

[!code-js[all_openpicker_showmulti](../windows.storage.pickers/code/FilePicker/js/js/scenario2.js#Snippetall_openpicker_showmulti)]

## -see-also

[File picker sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FilePicker), [Quickstart: Accessing files with File Pickers](/windows/uwp/files/quickstart-using-file-and-folder-pickers), [Blobs sample](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/MsBlobBuilder), [Display WinRT UI objects that depend on CoreWindow](/windows/apps/develop/ui-input/display-ui-objects)
