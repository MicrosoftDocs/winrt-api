---
-api-id: P:Windows.UI.StartScreen.SecondaryTile.TileId
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public string TileId { get;  set; }
-->

# Windows.UI.StartScreen.SecondaryTile.TileId

## -description
Gets or sets a unique string to identify the tile within the package. This property is required when you create or delete a tile.

## -property-value
A unique identifier, meaningful to your app. It is limited to 64 characters and must begin with a number or letter and be composed of the characters a-z, A-Z, 0-9, period (.), or underscore (_). It cannot contain spaces, commas, or any of these characters: | &gt; &lt; " / ? * \ ; : ! '

## -remarks
If two secondary tiles have the same ID, the last one to be pinned will overwrite the existing tile.

## -examples

## -see-also
