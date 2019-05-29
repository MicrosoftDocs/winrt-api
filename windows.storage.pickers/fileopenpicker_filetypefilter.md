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
A [fileExtensionVector](fileextensionvector.md) object that contains a collection of file types (file name extensions) , such as ".doc" and ".png". File name extensions are stored in this array as [string](https://docs.microsoft.com/dotnet/api/system.string?redirectedfrom=MSDN) objects.

## -remarks

## -examples
The [File picker sample](https://go.microsoft.com/fwlink/p/?linkid=234890) demonstrates how to specify the file types that the user can see and pick from in the file picker.



[!code-csharp[all_openpicker_setprops](../windows.storage.pickers/code/FilePicker/CS/Scenario1.xaml.cs#Snippetall_openpicker_setprops)]

[!code-js[all_openpicker_setprops](../windows.storage.pickers/code/FilePicker/js/js/scenario1.js#Snippetall_openpicker_setprops)]



[!code-csharp[all_openpicker_displayAllTypes](../windows.storage.pickers/code/FilePicker/CS/Scenario2.xaml.cs#Snippetall_openpicker_displayAllTypes)]

[!code-js[all_openpicker_displayAllTypes](../windows.storage.pickers/code/FilePicker/js/js/scenario2.js#Snippetall_openpicker_displayAllTypes)]

## -see-also
[File picker sample](https://go.microsoft.com/fwlink/p/?linkid=234890), [Quickstart: Accessing files with ](https://docs.microsoft.com/previous-versions/windows/apps/hh465199(v=win.10)), [fileOpenPicker class](fileopenpicker.md), [fileExtensionVector class](fileextensionvector.md), [fileExtensionVector class](fileextensionvector.md)
