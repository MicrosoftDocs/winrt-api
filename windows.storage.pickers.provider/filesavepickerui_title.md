---
-api-id: P:Windows.Storage.Pickers.Provider.FileSavePickerUI.Title
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public string Title { get;  set; }
-->

# Windows.Storage.Pickers.Provider.FileSavePickerUI.Title

## -description
Gets or sets a title to display in the file picker UI that identifies the location that the file picker is displaying to the user.

## -property-value
The title to display in the file picker UI. This title should identify the location and type of files that the user can see on the app page (which is hosted by the file picker) of the app that is providing files.

## -remarks
As a provider of files, you should consider updating the title if the user navigates to another location or if the [AllowedFileTypes](fileopenpickerui_allowedfiletypes.md) change.

## -examples

## -see-also
[FileOpenPickerUI class](fileopenpickerui.md)