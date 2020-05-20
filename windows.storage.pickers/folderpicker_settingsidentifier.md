---
-api-id: P:Windows.Storage.Pickers.FolderPicker.SettingsIdentifier
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public string SettingsIdentifier { get;  set; }
-->

# Windows.Storage.Pickers.FolderPicker.SettingsIdentifier

## -description
Gets or sets the settings identifier associated with the with the current [FolderPicker](folderpicker.md) instance.

## -property-value
The settings identifier.

## -remarks
If your application uses multiple instances of the folder picker, you can use this property to identify the individual instances.

To give the user a sense of consistency, the folder picker remembers the last location that the user navigated to and will generally start at that location. Normally, this remembered location is shared by all folder pickers used by the app. To remember a different location for different pickers, choose a different SettingsIdentifier for each picker.

For example, if you use one folder picker for picking flowers, and another for picking fruit, you can set the SettingsIdentifier for the first picker to "Flowers" and the SettingsIdentifier for the second picker to "Fruit". That way, each time the user picks flowers, they default to the last location they used for picking flowers; and each time the user picks fruit, they default to the last location they used for picking fruit.

## -examples

## -see-also
