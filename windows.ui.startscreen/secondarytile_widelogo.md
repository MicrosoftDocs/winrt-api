---
-api-id: P:Windows.UI.StartScreen.SecondaryTile.WideLogo
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.Uri WideLogo { get;  set; }
-->

# Windows.UI.StartScreen.SecondaryTile.WideLogo

## -description
> [!NOTE]
> [WideLogo](secondarytile_widelogo.md) may be altered or unavailable for releases after Windows 8.1. Instead, use [SecondaryTileVisualElements.Wide310x150Logo](secondarytilevisualelements_wide310x150logo.md).

Gets or sets the logo image used in a wide secondary tile. This property is required when you create a wide secondary tile and gives the user the option of a wide tile when they resize the tile.

## -property-value
The location of the image. This can be expressed using one of these schemes: <termdeflist><termdef><name>ms-appx:///</name>A path within the deployed app package. This path is resolved for languages and DPI plateau supported by the app.</termdef><termdef><name>ms-appdata:///local/</name>A file found in the per-user app storage.</termdef></termdeflist>

## -remarks
A logo image that is saved locally (ms-appdata://localfolder/) by the app to use in a secondary tile should not be deleted by the app. This prevents loss of the image if the cache is cleared.

## -examples

## -see-also
[Logo](secondarytile_logo.md), [SmallLogo](secondarytile_smalllogo.md), [Secondary tiles sample](http://go.microsoft.com/fwlink/p/?linkid=231487)