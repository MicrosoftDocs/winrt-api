---
-api-id: M:Windows.UI.Shell.TaskbarManager.IsSecondaryTilePinnedAsync(System.String)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public IAsyncOperation<bool> TaskbarManager.IsSecondaryTilePinnedAsync(String tileId)
-->

# Windows.UI.Shell.TaskbarManager.IsSecondaryTilePinnedAsync

## -description

Checks if the specified secondary tile is pinned to taskbar. Requires user approval as described [here](/windows/uwp/design/shell/pin-to-taskbar#4-pin-your-app)

## -parameters

### -param tileId

The [TileId](../windows.ui.startscreen/secondarytile_tileid.md) of the [SecondaryTile](../windows.ui.startscreen/secondarytile.md) that you want to check is pinned.

## -returns

A boolean representing whether the specified secondary tile is pinned to taskbar.

## -remarks

This API can only be used with Limited-Access. See the docs for pinning secondary tiles to taskbar to learn more.

## -see-also

[Pin your app to the taskbar](/windows/uwp/design/shell/pin-to-taskbar)

## -examples
