---
-api-id: T:Windows.Storage.Pickers.FilePickerFileTypesOrderedMap
-api-type: winrt class
---

<!-- Class syntax.
public class FilePickerFileTypesOrderedMap : Windows.Foundation.Collections.IIterable<Windows.Foundation.Collections.IKeyValuePair<System.String, Windows.Foundation.Collections.IVector<System.String>>>, Windows.Foundation.Collections.IMap<System.String, Windows.Foundation.Collections.IVector<System.String>>
-->

# Windows.Storage.Pickers.FilePickerFileTypesOrderedMap

## -description
Represents a collection of display names mapped to the associated file types (extensions). Each element in this collection maps a display name to a corresponding collection of file name extensions. The key is a single string, the value is a list/vector of strings representing one or more extension choices.

## -remarks
Instances of the FilePickerFileTypesOrderedMap class supply the value for the [FileSavePicker.FileTypeChoices](filesavepicker_filetypechoices.md) property. By strict typing, the [FileTypeChoices](filesavepicker_filetypechoices.md) property takes a generic map where the value is a generic vector of strings. But the FilePickerFileTypesOrderedMap class implements this combination of interfaces as a concrete class, so you should always use an FilePickerFileTypesOrderedMap object for a [FileTypeChoices](filesavepicker_filetypechoices.md) value.

The key for an entry in a FilePickerFileTypesOrderedMap is a string that represents a friendly-name/displayname classification of what a file type is intended for. For example, "Plain Text" is an appropriate key for a FilePickerFileTypesOrderedMap where one of the associated file type extensions is ".txt".One display name as a classification of file types might have multiple file types that support it. For example, a display name of "HTML page" could be saved either with ".htm" or ".html" extension. That is why the value of each entry in a FilePickerFileTypesOrderedMap is an ordered list (vector) of strings, displayed in the UI in the order that you place the extensions in the vector.

### Collection member lists

For JavaScript, FilePickerFileTypesOrderedMap supports using an index to access items.

## -examples
The [File picker sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePicker) demonstrates how to add file type choices with a display name.

[!code-csharp[all_savepicker_setprops](../windows.storage.pickers/code/FilePicker/CS/Scenario4.xaml.cs#Snippetall_savepicker_setprops)]

## -see-also
[File picker sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePicker), [Open files and folders with a picker](/windows/uwp/files/quickstart-using-file-and-folder-pickers), [FileSavePicker.FileTypeChoices property](filesavepicker_filetypechoices.md)
