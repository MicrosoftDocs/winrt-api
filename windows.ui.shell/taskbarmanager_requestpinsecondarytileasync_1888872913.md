---
-api-id: M:Windows.UI.Shell.TaskbarManager.RequestPinSecondaryTileAsync(Windows.UI.StartScreen.SecondaryTile)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public IAsyncOperation<bool> TaskbarManager.RequestPinSecondaryTileAsync(SecondaryTile secondaryTile)
-->

# Windows.UI.Shell.TaskbarManager.RequestPinSecondaryTileAsync

## -description

Requests to pin the specified tile to taskbar. Requires user approval as described [here](https://docs.microsoft.com/en-us/windows/uwp/design/shell/pin-to-taskbar#4-pin-your-app).

## -parameters

### -param secondaryTile

The secondary tile to be pinned.

## -returns

A boolean representing whether the tile is pinned to the takbar. If the tile was already pinned, this will update the tile and return true. If pinning wasn't allowed or taskbar isn't supported, this will return false.

## -remarks

This API can only be used with Limited-Access. See the docs for pinning secondary tiles to taskbar to learn more.

## -see-also

https://docs.microsoft.com/en-us/windows/uwp/design/shell/pin-to-taskbar

## -examples
