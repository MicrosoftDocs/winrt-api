---
-api-id: T:Windows.Storage.Pickers.Provider.AddFileResult
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Storage.Pickers.Provider.AddFileResult : int
-->

# AddFileResult

## -description
Indicates the result of a call to the [FileOpenPickerUI.AddFile](fileopenpickerui_addfile_887814693.md) method.

## -enum-fields
### -field Added:0
The file was successfully added to the file picker UI.

### -field AlreadyAdded:1
The file was already in the file picker UI.

### -field NotAllowed:2
The file wasn't added because it is not one of the allowed file types.

### -field Unavailable:3
The file wasn't added because the file picker UI is unavailable.  The file picker UI is only available while the user is interacting with your app.


## -remarks

## -examples

## -see-also
[FileOpenPickerUI](fileopenpickerui.md), [FileOpenPickerUI.AddFile method](fileopenpickerui_addfile_887814693.md)