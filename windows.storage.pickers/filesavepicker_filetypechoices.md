---
-api-id: P:Windows.Storage.Pickers.FileSavePicker.FileTypeChoices
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IMap<string, Windows.Foundation.Collections.IVector<string>> FileTypeChoices { get; }
-->

# Windows.Storage.Pickers.FileSavePicker.FileTypeChoices

## -description
Gets the collection of valid file types that the user can choose to assign to a file.

## -property-value
A [FilePickerFileTypesOrderedMap](filepickerfiletypesorderedmap.md) object that contains a collection of valid file types (extensions) that the user can use to save a file. Each element in this collection maps a display name to a corresponding collection of file name extensions. The key is a single string, the value is a list/vector of strings representing one or more extension choices.

## -remarks
Some apps do not need to understand a file format in order to process it - such as a cloud storage provider. Therefore, using the file wildcard character - "*" - is supported for the [FileOpenPicker.FileTypeFilter](fileopenpicker_filetypefilter.md) collection. However, writing a file requires knowledge of its format. As a result, the wildcard is not supported for [FileSavePicker.FileTypeChoices](filesavepicker_filetypechoices.md).

One display name as a classification of file types might have multiple file types that support it. For example, a display name of "HTML page" could be saved either with ".htm" or ".html" extension. That is why the value of each entry in a [FilePickerFileTypesOrderedMap](filepickerfiletypesorderedmap.md) is an ordered list (vector) of strings, displayed in the UI in the order that you place the extensions in the vector.

## -examples
The [File picker sample](https://go.microsoft.com/fwlink/p/?linkid=234890) demonstrates how to add file type choices with a display name.



[!code-csharp[all_savepicker_setprops](../windows.storage.pickers/code/FilePicker/CS/Scenario4.xaml.cs#Snippetall_savepicker_setprops)]

[!code-js[all_savepicker_setprops](../windows.storage.pickers/code/FilePicker/js/js/scenario4.js#Snippetall_savepicker_setprops)]

## -see-also
[File picker sample](https://go.microsoft.com/fwlink/p/?linkid=234890), [FileSavePicker class](filesavepicker.md), [FilePickerFileTypesOrderedMap](filepickerfiletypesorderedmap.md)
filepickerfiletypesorderedmap.md)
