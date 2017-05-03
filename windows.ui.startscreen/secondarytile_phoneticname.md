---
-api-id: P:Windows.UI.StartScreen.SecondaryTile.PhoneticName
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public string PhoneticName { get;  set; }
-->

# Windows.UI.StartScreen.SecondaryTile.PhoneticName

## -description
Gets or sets a phonetic version of the secondary tile name. Used with character-based languages for UI sorting purposes.

## -property-value
The phonetic name.

## -remarks
In certain character-based languages such as Japanese, the sort order in the UI is based on a phonetic spelling of the characters that make up the app's display name. This phonetic spelling is a separate string from the display name. When a user pins a secondary tile, they can specify a display name for that tile in the pinning flyout but they cannot specify a phonetic spelling. Windows makes a guess as to the phonetic string, but it is not always right.

Apps, however, sometimes know the right phonetic string because the app lets a user define it. In Windows 8.1, an app can then use that information to set this property. Note that this string is tied to the default display name associated with the secondary tile. If the user changes the display name through the pinning flyout, then the system's guess for the phonetic spelling will be used instead.

## -examples

## -see-also
