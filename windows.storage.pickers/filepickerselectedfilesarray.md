---
-api-id: T:Windows.Storage.Pickers.FilePickerSelectedFilesArray
-api-type: winrt class
---

<!-- Class syntax.
public class FilePickerSelectedFilesArray : Windows.Foundation.Collections.IIterable<Windows.Storage.StorageFile>, Windows.Foundation.Collections.IVectorView<Windows.Storage.StorageFile>
-->

# Windows.Storage.Pickers.FilePickerSelectedFilesArray

## -description
Represents a collection of storage files that the user has selected by using a file picker.

## -remarks
When a call to the [fileOpenPicker.pickMultipleFilesAsync](fileopenpicker_pickmultiplefilesasync_1324933367.md) method completes successfully, it returns a [filePickerSelectedFilesArray](filepickerselectedfilesarray.md) object that contains all the files that were picked by the user. Picked files in this array are represented by [storageFile](../windows.storage/storagefile.md) objects.

### Collection member lists

For JavaScript, [FilePickerSelectedFilesArray](filepickerselectedfilesarray.md) has the members shown in the member lists. In addition, [FilePickerSelectedFilesArray](filepickerselectedfilesarray.md) supports a **length** property, members of **Array.prototype**, and using an index to access items.


<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

[FilePickerSelectedFilesArray](filepickerselectedfilesarray.md) is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<StorageFile>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](https://msdn.microsoft.com/library/system.collections.ienumerable.getenumerator.aspx), cast to [IEnumerable&lt;T&gt;](https://msdn.microsoft.com/library/system.collections.ienumerable.aspx) with a [StorageFile](../windows.storage/storagefile.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples
The [File picker sample](http://go.microsoft.com/fwlink/p/?linkid=234890) demonstrates how capture the [filePickerSelectedFilesArray](filepickerselectedfilesarray.md) (`files` in the example) of picked files after calling [fileOpenPicker.pickMultipleFilesAsync](fileopenpicker_pickmultiplefilesasync_1324933367.md).

> [!NOTE]
> You should always make sure that your app is not snapped (or that it can be unsnapped) and set file picker properties regardless of whether the user is picking a single file or multiple files.



[!code-csharp[all_openpicker_showmulti](../windows.storage.pickers/code/FilePicker/CS/Scenario2.xaml.cs#Snippetall_openpicker_showmulti)]

[!code-js[all_openpicker_showmulti](../windows.storage.pickers/code/FilePicker/js/js/scenario2.js#Snippetall_openpicker_showmulti)]

## -see-also
[File picker sample](http://go.microsoft.com/fwlink/p/?linkid=234890), [Quickstart: Accessing files with ](http://msdn.microsoft.com/library/df082239-381c-462f-9f97-d2b390a2052e), [fileOpenPicker.pickMultipleFilesAsync method](fileopenpicker_pickmultiplefilesasync_1324933367.md)
picker_pickmultiplefilesasync.md)
