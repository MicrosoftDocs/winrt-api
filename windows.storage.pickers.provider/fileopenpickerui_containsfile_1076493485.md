---
-api-id: M:Windows.Storage.Pickers.Provider.FileOpenPickerUI.ContainsFile(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public bool ContainsFile(System.String id)
-->

# Windows.Storage.Pickers.Provider.FileOpenPickerUI.ContainsFile

## -description
Determines whether the specified file is in the list of files that the user has chosen.

## -parameters
### -param id
The identifier of the file.

## -returns
True if the file is in the basket; otherwise false.

## -remarks
An app hosted in the file picker can use this method to determine whether a file that the app previously added is still in the file picker UI. The user or the app might have removed the file, or the file might not have been added in the first place.

## -examples

## -see-also
[FileOpenPickerUI class](fileopenpickerui.md)