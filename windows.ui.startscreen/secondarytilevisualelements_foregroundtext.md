---
-api-id: P:Windows.UI.StartScreen.SecondaryTileVisualElements.ForegroundText
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.UI.StartScreen.ForegroundText ForegroundText { get;  set; }
-->

# Windows.UI.StartScreen.SecondaryTileVisualElements.ForegroundText

## -description
Specifies whether the tile should use dark or light text.

> This value is ignored on Windows Phone 8.1. The foreground text color of a secondary tile on the phone is always light.

## -property-value
One of the two values that specifies either the default dark or default light text.

## -remarks
If this property is not specified, it is inherited from the foreground text property of the parent app's tile.

Only two text colors are available— default dark and default light— and are set by Windows. Choose the text color that will look best with your choice of [background color](secondarytile_backgroundcolor.md) and the opacity of your logo image.

## -examples

## -see-also
[Secondary tiles sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Secondary%20tiles%20sample), [BackgroundColor](secondarytilevisualelements_backgroundcolor.md)
