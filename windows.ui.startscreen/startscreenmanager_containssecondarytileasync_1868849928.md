---
-api-id: M:Windows.UI.StartScreen.StartScreenManager.ContainsSecondaryTileAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> StartScreenManager.ContainsSecondaryTileAsync(String tileId)
-->

# Windows.UI.StartScreen.StartScreenManager.ContainsSecondaryTileAsync

## -description
Checks if the specified secondary tile is pinned to Start.

## -parameters
### -param tileId
The [TileId](secondarytile_tileid.md) of the [SecondaryTile](secondarytile.md) that you want to check is pinned.

## -returns
A boolean representing whether the specified secondary tile is pinned to Start.

## -remarks
This API is only relevant when you are pinning your tiles to multiple surfaces, like pinning secondary tiles to taskbar. If you only pin secondary tiles to Start, you should instead use [SecondaryTile.Exists](secondarytile_exists_1536819090.md) which has been present since the first version of Windows 10.

## -see-also

## -examples

