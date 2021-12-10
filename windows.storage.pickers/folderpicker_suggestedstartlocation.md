---
-api-id: P:Windows.Storage.Pickers.FolderPicker.SuggestedStartLocation
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Storage.Pickers.PickerLocationId SuggestedStartLocation { get;  set; }
-->

# Windows.Storage.Pickers.FolderPicker.SuggestedStartLocation

## -description
Gets or sets the initial location where the folder picker looks for folders to present to the user.

## -property-value
The identifier of the starting location.

## -remarks
The SuggestedStartLocation is not always used as the start location for the folder picker. To give the user a sense of consistency, the folder picker remembers the last location that the user navigated to and will generally start at that location.

## -examples
The [File picker sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePicker) demonstrates how to show files of any type in the file picker.

This short sample code demonstrates a FilePicker opening at a requested location.

```csharp

private async void Button_click(object sender, RoutedEventArgs e)
{
    FileOpenPicker filePicker = new FileOpenPicker();
    filePicker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
    filePicker.ViewMode = PickerViewMode.List;
    filePicker.FileTypeFilter.Add(".txt");
    StorageFile file = await filePicker.PickSingleFileAsync();
}

```

## -see-also
