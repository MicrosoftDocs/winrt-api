---
-api-id: M:Windows.UI.StartScreen.StartScreenManager.TryRemoveSecondaryTileAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> StartScreenManager.TryRemoveSecondaryTileAsync(String tileId)
-->

# Windows.UI.StartScreen.StartScreenManager.TryRemoveSecondaryTileAsync

## -description
Tries to remove the specified secondary tile from Start.

## -parameters
### -param tileId
The [TileId](secondarytile_tileid.md) of the [SecondaryTile](secondarytile.md) you want to remove.

## -returns
A boolean representing whether the tile is not on Start. If removing wasn't allowed, this returns false.

## -remarks
This API is only relevant when you are pinning your tiles to multiple surfaces, like pinning secondary tiles to taskbar. If you only pin secondary tiles to Start, you should instead use [SecondaryTile.RequestDeleteAsync](secondarytile_requestdeleteasync_880835933.md) which has been present since the first version of Windows 10.

## -see-also

## -examples

