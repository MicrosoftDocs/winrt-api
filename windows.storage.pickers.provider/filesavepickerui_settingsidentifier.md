---
-api-id: P:Windows.Storage.Pickers.Provider.FileSavePickerUI.SettingsIdentifier
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public string SettingsIdentifier { get; }
-->

# Windows.Storage.Pickers.Provider.FileSavePickerUI.SettingsIdentifier

## -description
Gets an identifier for the current context of the file picker.

## -property-value
The identifier for the current context of the file picker.

## -remarks
As the provider of a save location, your app can use this identifier to restore the state your app was in the last time it was used in this context.

The context depends on various factors including the calling app and file types being chosen.

## -examples

## -see-also
[FileOpenPickerUI class](fileopenpickerui.md)