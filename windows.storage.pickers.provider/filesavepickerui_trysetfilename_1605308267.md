---
-api-id: M:Windows.Storage.Pickers.Provider.FileSavePickerUI.TrySetFileName(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Storage.Pickers.Provider.SetFileNameResult TrySetFileName(System.String value)
-->

# Windows.Storage.Pickers.Provider.FileSavePickerUI.TrySetFileName

## -description
Tries to set the file name and extension in the file picker UI.

## -parameters
### -param value
The file name and extension that are used to update the file name text box and file type drop-down menu in the file picker UI.

## -returns
The enumeration value that indicates whether the file name and extension were updated in the file picker UI.

## -remarks
As the provider of a save location, your app should call this method when the user selects a file that is displayed on your app page (which is hosted in the file picker).

This method fails if:

+ The extension specified for the file in *value* isn't one of the [AllowedFileTypes](filesavepickerui_allowedfiletypes.md).
+ The file picker UI isn't visible to the user.
+ The user is interacting with the file name text box in the file picker UI.


## -examples

## -see-also
