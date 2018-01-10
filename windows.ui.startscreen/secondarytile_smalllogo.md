---
-api-id: P:Windows.UI.StartScreen.SecondaryTile.SmallLogo
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.Uri SmallLogo { get;  set; }
-->

# Windows.UI.StartScreen.SecondaryTile.SmallLogo

## -description
> [!NOTE]
> [SmallLogo](secondarytile_smalllogo.md) may be altered or unavailable for releases after Windows 8.1. Instead, use [SecondaryTileVisualElements.Square30x30Logo](secondarytilevisualelements_square30x30logo.md).

Gets or sets the small logo image, used in search results, the All Programs list, and other locations in the UI.

> The small logo is not used with a Windows Phone 8.1 secondary tile.

## -property-value
The location of the image. This must be expressed using this scheme: <termdeflist><termdef><name>ms-appx:///</name>A path within the deployed app package. This path is resolved for languages and DPI plateau supported by the app.</termdef></termdeflist>

## -remarks
If this image is not provided, the small logo of this secondary tile's parent app is used.

A logo image that is saved locally (ms-appdata://localfolder/) by the app to use in a secondary tile should not be deleted by the app. This prevents loss of the image if the cache is cleared.

## -examples

## -see-also
