---
-api-id: M:Windows.UI.StartScreen.SecondaryTile.UpdateAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> UpdateAsync()
-->

# Windows.UI.StartScreen.SecondaryTile.UpdateAsync

## -description
Updates a secondary tile after that tile is pinned to the Start screen.

> On Windows Phone 8.1, your app is suspended and the user is taken to the Start screen when a secondary tile is pinned. Therefore, be aware that any code called after [RequestCreateAsync](secondarytile_requestcreateasync_1444672734.md) is not guaranteed to be run before the app is suspended. To avoid this potential issue you should use the OnSuspended event of your app to run any code, such as updating the pinned tile, that should be run before the app suspends. To see an example of this pattern, download and run the [Tile update on suspend sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%20Phone%208.1%20samples/%5BC%23%5D-Windows%20Phone%208.1%20samples/Updating%20a%20pinned%20secondary%20tile%20on%20Suspend/C%23).

## -returns
An object used to launch the asynchronous create operation as well as to retrieve information about it.

## -remarks
This method updates the following properties of the secondary tile:


+ [DisplayName](secondarytile_displayname.md)
+ [SecondaryTile.Arguments](secondarytile_arguments.md)
+ [SecondaryTile.LockScreenBadgeLogo](secondarytile_lockscreenbadgelogo.md)
+ [SecondaryTile.LockScreenDisplayBadgeAndTileText](secondarytile_lockscreendisplaybadgeandtiletext.md)
+ [SecondaryTile.RoamingEnabled](secondarytile_roamingenabled.md)
+ [SecondaryTileVisualElements.BackgroundColor](secondarytilevisualelements_backgroundcolor.md)
+ [SecondaryTileVisualElements.ForegroundText](secondarytilevisualelements_foregroundtext.md)
+ [SecondaryTileVisualElements.ShowNameOnSquare150x150Logo](secondarytilevisualelements_shownameonsquare150x150logo.md)
+ [SecondaryTileVisualElements.ShowNameOnSquare310x310Logo](secondarytilevisualelements_shownameonsquare310x310logo.md)
+ [SecondaryTileVisualElements.ShowNameOnWide310x150Logo](secondarytilevisualelements_shownameonwide310x150logo.md)
+ [SecondaryTileVisualElements.Square30x30Logo](secondarytilevisualelements_square30x30logo.md)
+ [SecondaryTileVisualElements.Square70x70Logo](secondarytilevisualelements_square70x70logo.md)
+ [SecondaryTileVisualElements.Square150x150Logo](secondarytilevisualelements_square150x150logo.md)
+ [SecondaryTileVisualElements.Square310x310Logo](secondarytilevisualelements_square310x310logo.md)
+ [SecondaryTileVisualElements.Wide310x150Logo](secondarytilevisualelements_wide310x150logo.md)
+ [TileId](secondarytile_tileid.md)


On Windows 8 and Windows 8.1, this method doesn't update these properties:


+ [DisplayName](secondarytile_displayname.md)
+ [SecondaryTileVisualElements.Square30x30Logo](secondarytilevisualelements_square30x30logo.md)
+ [TileId](secondarytile_tileid.md)


If the [TileId](secondarytile_tileid.md) property is not set before you call this method, the call will raise an exception.

## -examples

## -see-also
