---
-api-id: P:Windows.UI.StartScreen.SecondaryTile.Logo
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.Uri Logo { get;  set; }
-->

# Windows.UI.StartScreen.SecondaryTile.Logo

## -description
> [!NOTE]
> [Logo](secondarytile_logo.md) may be altered or unavailable for releases after Windows 8.1. Instead, use [SecondaryTileVisualElements.Square150x150Logo](secondarytilevisualelements_square150x150logo.md).

Gets or sets the logo image used in a medium tile. This property is required when you create either a square or a wide tile.

## -property-value
The location of the image. This can be expressed as one of these schemes: <termdeflist><termdef><name>ms-appx:///</name>A path within the deployed app package. This path is resolved for languages and DPI plateau supported by the app.</termdef><termdef><name>ms-appdata:///local/</name>A file found in the per-user app storage.</termdef></termdeflist>

## -remarks
A logo image that is saved locally (ms-appdata://localfolder/) by the app to use as a secondary tile default image should not be deleted by the app. This prevents loss of the image if the cache is cleared.

## -examples

## -see-also
[WideLogo](secondarytile_widelogo.md), [SmallLogo](secondarytile_smalllogo.md), [Secondary tiles sample](http://go.microsoft.com/fwlink/p/?linkid=231487)