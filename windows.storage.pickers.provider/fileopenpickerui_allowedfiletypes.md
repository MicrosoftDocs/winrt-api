---
-api-id: P:Windows.Storage.Pickers.Provider.FileOpenPickerUI.AllowedFileTypes
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<string> AllowedFileTypes { get; }
-->

# Windows.Storage.Pickers.Provider.FileOpenPickerUI.AllowedFileTypes

## -description
Gets a list of file types (extensions) that the user can choose.

## -property-value
The list of allowed file types.

## -remarks
Because the app that called the file picker (the calling app) can limit the types of files that the user can choose, the app that is providing files (the providing app) can use this method to determine which file types are allowed. For example, if the calling app specifies that only picture file types can be chosen, a music file cannot be added to the file picker 's list of chosen files.

## -examples

## -see-also
[FileOpenPickerUI class](fileopenpickerui.md)