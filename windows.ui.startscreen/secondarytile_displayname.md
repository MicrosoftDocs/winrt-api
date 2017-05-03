---
-api-id: P:Windows.UI.StartScreen.SecondaryTile.DisplayName
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public string DisplayName { get;  set; }
-->

# Windows.UI.StartScreen.SecondaryTile.DisplayName

## -description
Gets or sets a name that is associated with and displayed on the tile. This name is displayed on the tile in Start, in the tile's tooltip, next to the small tile representation in the **Apps** list, and in some Control Panel applications. This property is required when you create a tile. It is the equivalent of the display name declared in the manifest for the app's main tile. 

> On Windows Phone 8.1, the display name is shown only on the wide secondary tile.

## -property-value
The display name. This string is limited to 256 characters, but in reality should be kept short to avoid truncation.

## -remarks
This display name is visible to searches.

## -examples

## -see-also
[Secondary tiles sample](http://go.microsoft.com/fwlink/p/?linkid=231487)