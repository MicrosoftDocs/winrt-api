---
-api-id: P:Windows.UI.StartScreen.SecondaryTile.ShortName
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public string ShortName { get;  set; }
-->

# Windows.UI.StartScreen.SecondaryTile.ShortName

## -description
> [!NOTE]
> [ShortName](secondarytile_shortname.md) may be altered or unavailable for releases after Windows 8.1. Instead, use [SecondaryTile.DisplayName](secondarytile_displayname.md).

Gets or sets a short name to display directly on the tile. 

> [!NOTE]
> As of Windows 8.1, this property is ignored and the display name declared in the manifest is used in its place.

## -property-value
The short name. Anything over 40 characters will be truncated. The user has the option to change this value as part of the pinning process.

## -remarks
This display name is shown on the tile if the [ShowName](tileoptions.md) attribute is set through either the tile constructor or the [tileOptions](secondarytile_tileoptions.md) property.

This display name is visible to searches.

The user has the option to change this value to a string of their own choosing as part of the pinning process.

## -examples

## -see-also