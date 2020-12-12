---
-api-id: E:Windows.Storage.Pickers.Provider.FileSavePickerUI.FileNameChanged
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler FileNameChanged<Windows.Storage.Pickers.Provider.FileSavePickerUI,  object>
-->

# Windows.Storage.Pickers.Provider.FileSavePickerUI.FileNameChanged

## -description
Fired when the user changes the file name in the file name text box or changes the extension in the file type drop-down menu.

## -remarks
In response to this event, your app should get the new file name from the [FileName](filesavepickerui_filename.md) property and check the [AllowedFileTypes](filesavepickerui_allowedfiletypes.md) as these also could have changed.

Register for this event by adding an event listener to the [FileSavePickerUI](filesavepickerui.md) object and assigning a handler function for the event.

## -examples

## -see-also
[FileSavePickerUI class](filesavepickerui.md), [FileSavePickerUI.FileName property](filesavepickerui_filename.md)