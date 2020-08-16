---
-api-id: P:Windows.Storage.Pickers.FolderPicker.FileTypeFilter
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<string> FileTypeFilter { get; }
-->

# Windows.Storage.Pickers.FolderPicker.FileTypeFilter

## -description
Gets the collection of file types that the folder picker displays.

## -property-value
A [FileExtensionVector](fileextensionvector.md) object that contains a collection of file types (file name extensions) , such as ".doc" and ".png". File name extensions are stored in this array as [string](https://docs.microsoft.com/dotnet/api/system.string?redirectedfrom=MSDN) objects.

## -remarks

## -examples
The [File picker sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePicker) demonstrates how to show files of any type in the file picker.

```csharp
FolderPicker folderPicker = new FolderPicker();
folderPicker.SuggestedStartLocation = PickerLocationId.Desktop;
folderPicker.FileTypeFilter.Add("*");
```

```javascript
var folderPicker = new Windows.Storage.Pickers.FolderPicker();
folderPicker.suggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.desktop;
folderPicker.fileTypeFilter.replaceAll(["*"]);
```



## -see-also
[FolderPicker class](folderpicker.md), [FileExtensionVector class](fileextensionvector.md), [FileOpenPicker.FileTypeFilter property](fileopenpicker_filetypefilter.md)
