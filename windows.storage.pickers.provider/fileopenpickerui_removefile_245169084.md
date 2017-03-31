---
-api-id: M:Windows.Storage.Pickers.Provider.FileOpenPickerUI.RemoveFile(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void RemoveFile(System.String id)
-->

# Windows.Storage.Pickers.Provider.FileOpenPickerUI.RemoveFile

## -description
Removes the specified file from the list of files the user has chosen.

## -parameters
### -param id
The identifier of the file to remove.

## -remarks
The specified *id* should be the same as the one provided when the file was added to the file picker UI.

When the user deselects a file in the app's file picker view, the app calls this method to remove the item from the file picker UI.

## -examples

## -see-also
[FileOpenPickerUI class](fileopenpickerui.md)