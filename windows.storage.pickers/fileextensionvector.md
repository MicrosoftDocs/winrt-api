---
-api-id: T:Windows.Storage.Pickers.FileExtensionVector
-api-type: winrt class
---

<!-- Class syntax.
public class FileExtensionVector : Windows.Foundation.Collections.IIterable<System.String>, Windows.Foundation.Collections.IVector<System.String>
-->

# Windows.Storage.Pickers.FileExtensionVector

## -description
Represents a random-access collection of file name extensions.

## -remarks
### Collection member lists

For JavaScript, FileExtensionVector has the members shown in the member lists. In addition, FileExtensionVector supports a **length** property, members of **Array.prototype**, and using an index to access items.


<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

A FileExtensionVector is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<String>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator?view=dotnet-uwp-10.0&preserve-view=true), cast to [IEnumerable&lt;T&gt;](/dotnet/api/system.collections.ienumerable?view=dotnet-uwp-10.0&preserve-view=true) with a [String](/dotnet/api/system.string?view=dotnet-uwp-10.0&preserve-view=true) constraint.


<!--End NET note for IEnumerable support-->

## -examples
The [File picker sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePicker) demonstrates how to specify the file types that the user can see and pick from in the file picker.

[!code-csharp[all_openpicker_setprops](../windows.storage.pickers/code/FilePicker/CS/Scenario1.xaml.cs#Snippetall_openpicker_setprops)]

[!code-csharp[all_openpicker_displayAllTypes](../windows.storage.pickers/code/FilePicker/CS/Scenario2.xaml.cs#Snippetall_openpicker_displayAllTypes)]

## -see-also
[File picker sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePicker), [Open files and folders with a picker](/windows/uwp/files/quickstart-using-file-and-folder-pickers), [fileOpenPicker.fileTypeFilter property](fileopenpicker_filetypefilter.md), [folderPicker.fileTypeFilter property](folderpicker_filetypefilter.md)
