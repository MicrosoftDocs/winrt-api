---
-api-id: M:Windows.UI.Shell.TaskbarManager.TryUnpinSecondaryTileAsync(System.String)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public IAsyncOperation<bool> TaskbarManager.TryUnpinSecondaryTileAsync(String tileId)
-->

# Windows.UI.Shell.TaskbarManager.TryUnpinSecondaryTileAsync

## -description

Tries to unpin the secondary tile from taskbar. Requires user approval as described [here](/windows/uwp/design/shell/pin-to-taskbar#4-pin-your-app)

## -parameters

### -param tileId

The [TileId](../windows.ui.startscreen/secondarytile_tileid.md) of the [SecondaryTile](../windows.ui.startscreen/secondarytile.md) you want to unpin.

## -returns

A boolean representing whether the tile is not pinned to taskbar. If unpinning wasn't allowed, this returns false.

## -remarks

This API can only be used with Limited-Access. See the docs for pinning secondary tiles to taskbar to learn more.

## -see-also

[Pin your app to the taskbar](/windows/uwp/design/shell/pin-to-taskbar)

## -examples
