---
-api-id: P:Windows.Storage.Pickers.FileOpenPicker.FileTypeFilter
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<string> FileTypeFilter { get; }
-->

# Windows.Storage.Pickers.FileOpenPicker.FileTypeFilter

## -description

Gets the collection of file types that the file open picker displays.

## -property-value

A [fileExtensionVector](fileextensionvector.md) object that contains a collection of file types (file name extensions) , such as ".doc" and ".png". Using `.` before the file extension is required (e.g. ".txt") unless specifying only a wildcard "*". See examples below. File name extensions are stored in this array as [string](/dotnet/api/system.string?view=dotnet-uwp-10.0&preserve-view=true) objects.

## -remarks

## -examples

The [File picker sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePicker) demonstrates how to specify the file types that the user can see and pick from in the file picker.

[!code-csharp[all_openpicker_setprops](../windows.storage.pickers/code/FilePicker/CS/Scenario1.xaml.cs#Snippetall_openpicker_setprops)]

[!code-csharp[all_openpicker_displayAllTypes](../windows.storage.pickers/code/FilePicker/CS/Scenario2.xaml.cs#Snippetall_openpicker_displayAllTypes)]

## -see-also

[File picker sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePicker), [fileOpenPicker class](fileopenpicker.md), [fileExtensionVector class](fileextensionvector.md)
