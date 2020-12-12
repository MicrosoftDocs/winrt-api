---
-api-id: T:Windows.Storage.Pickers.Provider.SetFileNameResult
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Storage.Pickers.Provider.SetFileNameResult : int
-->

# SetFileNameResult

## -description
Indicates the result of a call to the [FileSavePickerUI.TrySetFileName](filesavepickerui_trysetfilename_1605308267.md) method.

## -enum-fields
### -field Succeeded:0
The file name and extension were updated successfully.

### -field NotAllowed:1
The file name and extension were not updated because the extension wasn't one of the [AllowedFileTypes](filesavepickerui_allowedfiletypes.md).

### -field Unavailable:2
The file name and extension were not updated because the file picker UI wasn't available. The file picker UI is only available while the user is interacting with your app.


## -remarks

## -examples

## -see-also
[FileSavePickerUI class](filesavepickerui.md), [FileSavePickerUI.AllowedFileTypes property](filesavepickerui_allowedfiletypes.md), [FileSavePickerUI.TrySetFileName method](filesavepickerui_trysetfilename_1605308267.md)