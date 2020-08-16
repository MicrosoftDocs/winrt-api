---
-api-id: P:Windows.Storage.Pickers.FileOpenPicker.SettingsIdentifier
-api-type: winrt property
---

<!-- Property syntax
public string SettingsIdentifier { get;  set; }
-->

# Windows.Storage.Pickers.FileOpenPicker.SettingsIdentifier

## -description
Gets or sets the settings identifier associated with the state of the file open picker.

## -property-value
The settings identifier.

## -remarks
If your application uses multiple instances of the file open picker, you can use this property to identify the individual instances.

To give the user a sense of consistency, the file open picker remembers the last location that the user navigated to and will generally start at that location. Normally, this remembered location is shared by all file open pickers used by the app. To remember a different location for different pickers, choose a different SettingsIdentifier for each picker.

For example, if you use one file open picker for picking flowers, and another for picking fruit, you can set the SettingsIdentifier for the first picker to "Flowers" and the SettingsIdentifier for the second picker to "Fruit". That way, each time the user picks flowers, they default to the last location they used for picking flowers; and each time the user picks fruit, they default to the last location they used for picking fruit.

## -examples

## -see-also
