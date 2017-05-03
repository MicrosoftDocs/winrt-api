---
-api-id: P:Windows.Storage.Pickers.Provider.FileOpenPickerUI.SettingsIdentifier
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public string SettingsIdentifier { get; }
-->

# Windows.Storage.Pickers.Provider.FileOpenPickerUI.SettingsIdentifier

## -description
Gets an identifier for the current context of the file picker.

## -property-value
The identifier for the current context of the file picker.

## -remarks
As a provider of files, your app can use this identifier to restore the state your app was in the last time it was used in this context.

The context depends on various factors including the calling app and file types being chosen.

## -examples

## -see-also
[FileOpenPickerUI class](fileopenpickerui.md)