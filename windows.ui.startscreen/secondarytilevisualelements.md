---
-api-id: T:Windows.UI.StartScreen.SecondaryTileVisualElements
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class SecondaryTileVisualElements : Windows.UI.StartScreen.ISecondaryTileVisualElements, Windows.UI.StartScreen.ISecondaryTileVisualElements2, Windows.UI.StartScreen.ISecondaryTileVisualElements3
-->

# Windows.UI.StartScreen.SecondaryTileVisualElements

## -description
Contains properties through which you can get or set a secondary tile's background color, foreground text, tile images, and app name display options. The properties in this class replace these SecondaryTile properties: 
+ [SecondaryTile.BackgroundColor](secondarytile_backgroundcolor.md)
+ [SecondaryTile.ForegroundText](secondarytile_foregroundtext.md)
+ [SecondaryTile.Logo](secondarytile_logo.md)
+ [SecondaryTile.SmallLogo](secondarytile_smalllogo.md)
+ [SecondaryTile.WideLogo](secondarytile_widelogo.md)
+ [SecondaryTile.TileOptions](secondarytile_tileoptions.md) (except **CopyOnDeployment**)


## -remarks
This class object is obtained by calling the [SecondaryTile.VisualElements](secondarytile_visualelements.md) property.

A logo image that is saved locally (ms-appdata://localfolder/) by the app to use in a secondary tile should not be deleted by the app. This prevents loss of the image if the cache is cleared.

## -examples

## -see-also
