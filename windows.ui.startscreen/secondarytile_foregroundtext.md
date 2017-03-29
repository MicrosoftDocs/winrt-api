---
-api-id: P:Windows.UI.StartScreen.SecondaryTile.ForegroundText
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.UI.StartScreen.ForegroundText ForegroundText { get;  set; }
-->

# Windows.UI.StartScreen.SecondaryTile.ForegroundText

## -description
> [!NOTE]
> [ForegroundText](secondarytile_foregroundtext.md) may be altered or unavailable for releases after Windows 8.1. Instead, use [SecondaryTileVisualElements.ForegroundText](secondarytilevisualelements_foregroundtext.md).

Gets or sets whether the tile should use dark or light text.

## -property-value
One of the two values that specifies either the default dark or default light text.

## -remarks
> This property is ignored on Windows Phone 8.1.

If this property is not specified, it is inherited from the foreground text property of the parent app's tile.

Only two text colors are available— default dark and default light— and are set by Windows. Choose the text color that will look best with your choice of [background color](secondarytile_backgroundcolor.md) and the opacity of your logo image.

## -examples

## -see-also
[BackgroundColor](secondarytile_backgroundcolor.md), [Secondary tiles sample](http://go.microsoft.com/fwlink/p/?linkid=231487)